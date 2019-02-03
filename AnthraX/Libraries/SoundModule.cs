using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Un4seen.Bass;
using Un4seen.Bass.Misc;

namespace AnthraX.Libraries {

    // ################################################################################
    //  XXXX    X        XXX    X   X      XXXX   XXXXX    XXX    XXXXX   X   X    XXXX
    //  X   X   X       X   X   X   X     X         X     X   X     X     X   X   X    
    //  XXXX    X       XXXXX    XXX       XXX      X     XXXXX     X     X   X    XXX 
    //  X       X       X   X     X           X     X     X   X     X     X   X       X
    //  X       XXXXX   X   X     X       XXXX      X     X   X     X      XXX    XXXX 
    // ################################################################################
    public enum PlayStatus {
        Stop    =   0,
        Play    =   1,
        Pause   =   2
    }

    // ################################################################################
    //   xxxx    xxx    x   x   x   x   xxxx 
    //  x       x   x   x   x   xx  x    x  x
    //   xxx    x   x   x   x   x x x    x  x
    //      x   x   x   x   x   x  xx    x  x
    //  xxxx     xxx     xxx    x   x   xxxx 
    //
    //  x   x    xxx    xxxx    x   x   x       xxxxx
    //  xx xx   x   x    x  x   x   x   x       x    
    //  x x x   x   x    x  x   x   x   x       xxxx 
    //  x   x   x   x    x  x   x   x   x       x    
    //  x   x    xxx    xxxx     xxx    xxxxx   xxxxx
    // ################################################################################
    public static class SoundModule {

        private static  int         selectedDevice      =   1;
        private static  bool        initialized         =   false;
        private static  bool        activated           =   false;
        private static  BASSError   error;
        private static  string      selectedFile        =   "";
        private static  int         stream              =   0;
        private static  int[]       channelsMeter       =   new int[] { 0, 0 };

        // --- Equalizer ---
        private static  int[]       presetData          =   new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        // ---Effects ---
        private static  BASS_DX8_ECHO       echoData        =   null;
        private static  int                 echoHandle      =   0;
        private static  BASS_DX8_REVERB     reverbData      =   null;
        private static  int                 reverbHandle    =   0;
        private static  BASS_DX8_CHORUS     chorusData      =   null;
        private static  int                 chorusHandle    =   0;
        private static  DSP_Gain            amplification;
		private static  DSP_StereoEnhancer  stereoEnhancer;
		private static  DSP_IIRDelay        iRRDelay;
		private static  DSP_SoftSaturation  softSaturation;
        private static  DSP_PeakLevelMeter  channelMeter;


        // ######################################################################
        //  xxxxx   x   x   xxxx     xxx    xxxx    xxxxx
        //    x     xx xx   x   x   x   x   x   x     x  
        //    x     x x x   xxxx    x   x   xxxx      x  
        //    x     x   x   x       x   x   x   x     x  
        //  xxxxx   x   x   x        xxx    x   x     x  
        // ######################################################################

        [DllImport("kernel32", SetLastError = true)]
        static extern IntPtr LoadLibrary(string lpFileName);

        // ######################################################################
        //  xxxx    xxxxx   x   x   xxxxx    xxx    xxxxx    xxxx
        //   x  x   x       x   x     x     x   x   x       x    
        //   x  x   xxxx    x   x     x     x       xxxx     xxx 
        //   x  x   x        x x      x     x   x   x           x
        //  xxxx    xxxxx     x     xxxxx    xxx    xxxxx   xxxx 
        // ######################################################################
        #region device
        public static string[] GetDevices() {
            string[]    devices     =   new string[ Bass.BASS_GetDeviceCount() ];
            int         counter     =   0;
            foreach( var bass_device in Bass.BASS_GetDeviceInfos() ) {
                devices[counter]    =   bass_device.name;
                counter++;
            }

            if ( !SelectDevice( selectedDevice ) ) {
                SelectDefaultDevice();
            }
            return devices;
        }

        // ----------------------------------------------------------------------
        public static int GetSelectedDevice() { return selectedDevice; }

        // ----------------------------------------------------------------------
        public static bool SelectDevice( int deviceIndex ) {
            if ( deviceIndex >= 0 && deviceIndex < Bass.BASS_GetDeviceCount() ) {
                selectedDevice = deviceIndex;
                return true;
            }
            return false;
        }

        // ----------------------------------------------------------------------
        public static bool SelectDefaultDevice() {
            if ( 1 > Bass.BASS_GetDeviceCount() ) {
                selectedDevice = 0;
                return false;
            }
            selectedDevice = 1;
            return true;
        }

        #endregion devices
        // ######################################################################
        //  xxx      xxx     xxxx    xxxx
        //  x  x    x   x   x       x    
        //  xxxx    xxxxx    xxx     xxx 
        //  x   x   x   x       x       x
        //  xxxx    x   x   xxxx    xxxx 
        // ######################################################################
        #region BASS 
        public static bool CheckLibrary( string fileName ) {
            return LoadLibrary( fileName ) != IntPtr.Zero;
        }

        // ----------------------------------------------------------------------
        public static bool CheckVersion( int major, int minor ) {
            Version expectedVersion     =   new Version( major, minor );

            if ( Bass.BASS_GetVersion(2) < expectedVersion ) {
                return false;
            }

            return true;
        }

        #endregion BASS
        // ######################################################################
        //  xxxxx   x   x   xxxxx   xxxxx
        //    x     xx  x     x       x  
        //    x     x x x     x       x  
        //    x     x  xx     x       x  
        //  xxxxx   x   x   xxxxx     x  
        // ######################################################################
        #region Init 
        public static bool Init( FormAnthraX mainWindow ) {
            int         device      =   selectedDevice;
            int         frequency   =   44100;
            BASSInit    flags       =   BASSInit.BASS_DEVICE_DEFAULT;

            initialized     =   Bass.BASS_Init( device, frequency, flags, mainWindow.Handle);
			error           =   Bass.BASS_ErrorGetCode();

            EchoCreate();
            ChorusCreate();
            ReverbCreate();

            return initialized;
        }

        // ----------------------------------------------------------------------
        public static bool IsInitialized() { return initialized; }

        // ----------------------------------------------------------------------
        public static bool Unload() {
            bool    result  =   true;

            if ( IsInitialized() ) {
                if ( IsActivated() ) { UnloadStream(); }
                result  =   Bass.BASS_Free();
                error   =   Bass.BASS_ErrorGetCode();
            }

            activated       =   false;
            initialized     =   false;
            return result;
        }

        #endregion Init
        // ######################################################################
        //   xxx     xxx    xxxxx   xxxxx   x   x   xxxxx
        //  x   x   x   x     x       x     x   x   x    
        //  xxxxx   x         x       x     x   x   xxxx 
        //  x   x   x   x     x       x      x x    x    
        //  x   x    xxx      x     xxxxx     x     xxxxx
        // ######################################################################
        #region Active 
        public static bool LoadStream( string fullpath ) {
            if ( !IsInitialized() ) { return false; }

            long        offset  =   0;
            long        length  =   0;
            BASSFlag    flags   =   BASSFlag.BASS_DEFAULT;

            stream              =   Bass.BASS_StreamCreateFile( fullpath, offset, length, flags );
            activated           =   stream != 0;
            selectedFile        =   fullpath;
            error               =   Bass.BASS_ErrorGetCode();

            CreateChannelMeters();
            EqualizerInit();
            AmplificationInit();
            SoftSaturationInit();
            StereoEnhancerInit();
            IRRDelayInit();
            EchoInit();
            ReverbInit();
            ChorusInit();

            return activated;
        }

        // ----------------------------------------------------------------------
        public static bool IsActivated() { return initialized && activated; }

        // ----------------------------------------------------------------------
        public static bool UnloadStream() {
            bool    result  =   true;

            if ( IsInitialized() ) {
                if ( IsActivated() && stream != 0 ) {
                    if ( GetPlayStatus() == PlayStatus.Play ) { Stop(); }
                    result  =   Bass.BASS_StreamFree(stream);
                    error   =   Bass.BASS_ErrorGetCode();
                }
            }
            
            activated       =   false;
            stream          =   0;
            selectedFile    =   "";
            return result;
        }

        #endregion Active
        // ######################################################################
        //  x   x   xxxx    xxxx     xxx    xxxxx   xxxxx
        //  x   x   x   x    x  x   x   x     x     x    
        //  x   x   xxxx     x  x   xxxxx     x     xxxx 
        //  x   x   x        x  x   x   x     x     x    
        //   xxx    x       xxxx    x   x     x     xxxxx
        // ######################################################################
        #region Update     
        public static bool Reinit( FormAnthraX mainWindow ) {
            bool result = false;
            if ( Unload() ) { result = Init( mainWindow ); }
            return result;
        }

        // ----------------------------------------------------------------------
        public static void ReloadStream() {
            bool        result          =   false;
            string      temp_path       =   "";
            long        temp_position   =   0;
            PlayStatus  temp_play       =   PlayStatus.Stop;

            if ( IsInitialized() ) {
                if ( IsActivated() || stream != 0 ) {
                    temp_path       =   selectedFile;
                    temp_position   =   Bass.BASS_ChannelGetPosition( stream );
                    temp_play       =   GetPlayStatus();
                    if ( GetPlayStatus() == PlayStatus.Play ) { Stop(); }
                    if ( UnloadStream() ) { result = LoadStream( temp_path ); }
                    if ( result ) { SetPosition( temp_position ); }
                    if ( result && temp_play == PlayStatus.Play ) { Play(); }
                }
            }
        }

        // ----------------------------------------------------------------------
        public static bool ReinitWithStream( FormAnthraX mainWindow ) {
            bool        result          =   false;
            bool        active          =   false;
            string      temp_path       =   "";
            long        temp_position   =   0;
            PlayStatus  temp_play       =   PlayStatus.Stop;

            if ( IsInitialized() ) {
                if ( IsActivated() || stream != 0 ) {
                    temp_path       =   selectedFile;
                    temp_position   =   Bass.BASS_ChannelGetPosition( stream );
                    temp_play       =   GetPlayStatus();
                    if ( GetPlayStatus() == PlayStatus.Play ) { Stop(); }
                    active          =   UnloadStream();
                }
                result  =   Unload();
            }

            result  =   Init( mainWindow );
            if ( result && active ) { result = LoadStream( temp_path ); }
            if ( result && temp_play == PlayStatus.Play ) { SetPosition( temp_position ); }
            if ( result && temp_play == PlayStatus.Play ) { Play(); }

            return result;
        }

        #endregion Update
        // ######################################################################
        //  xxxxx   xxxx    xxxx     xxx    xxxx 
        //  x       x   x   x   x   x   x   x   x
        //  xxxx    xxxx    xxxx    x   x   xxxx 
        //  x       x   x   x   x   x   x   x   x
        //  xxxxx   x   x   x   x    xxx    x   x
        // ######################################################################
        #region Error
        public static string GetError() {
            return Enum.GetName( typeof(BASSError), error ).ToString();
        }

        #endregion Error
        // ######################################################################
        //  xxxx    x        xxx    x   x   xxxxx   xxxx 
        //  x   x   x       x   x   x   x   x       x   x
        //  xxxx    x       xxxxx    xxx    xxxx    xxxx 
        //  x       x       x   x     x     x       x   x
        //  x       xxxxx   x   x     x     xxxxx   x   x
        // ######################################################################
        #region Player       
        public static bool Play() {
            bool    result  =   false;

            if ( IsInitialized() ) {
                if ( IsActivated() && stream != 0 ) {
                    switch ( Bass.BASS_ChannelIsActive( stream ) ) {
                        case BASSActive.BASS_ACTIVE_STOPPED:
                            result  =   Bass.BASS_ChannelPlay( stream, true );
                            break;
                        case BASSActive.BASS_ACTIVE_PAUSED:
                            result  =   Bass.BASS_ChannelPlay( stream, false );
                            break;
                        default:
                            result  =   false;
                            break;
                    }
                }
            }

            return result;
        }

        // ----------------------------------------------------------------------
        public static bool Pause() {
            bool    result  =   false;

            if ( IsInitialized() ) {
                if ( IsActivated() && stream != 0 ) {
                    switch ( Bass.BASS_ChannelIsActive( stream ) ) {
                        case BASSActive.BASS_ACTIVE_PLAYING:
                            result  =   Bass.BASS_ChannelPause( stream );
                            break;
                        default:
                            result  =   false;
                            break;
                    }
                }
            }

            return result;
        }

        // ----------------------------------------------------------------------
        public static bool Stop() {
            bool    result  =   false;

            if ( IsInitialized() ) {
                if ( IsActivated() && stream != 0 ) {
                    switch ( Bass.BASS_ChannelIsActive( stream ) ) {
                        case BASSActive.BASS_ACTIVE_PLAYING:
                            result  =   Bass.BASS_ChannelStop( stream );
                            break;
                        case BASSActive.BASS_ACTIVE_PAUSED:
                            result  =   Bass.BASS_ChannelStop( stream );
                            break;
                        default:
                            result  =   false;
                            break;
                    }

                    Bass.BASS_ChannelSetPosition( stream, 0 );
                }
            }

            return result;
        }

        // ----------------------------------------------------------------------
        public static PlayStatus GetPlayStatus() {
            PlayStatus  status  =   PlayStatus.Stop;

            if ( IsInitialized() ) {
                if ( IsActivated() && stream != 0 ) {
                    switch ( Bass.BASS_ChannelIsActive( stream ) ) {
                        case BASSActive.BASS_ACTIVE_PLAYING:
                            status  =   PlayStatus.Play;
                            break;
                        case BASSActive.BASS_ACTIVE_PAUSED:
                            status  =   PlayStatus.Pause;
                            break;
                        case BASSActive.BASS_ACTIVE_STOPPED:
                            status  =   PlayStatus.Stop;
                            break;
                    }
                }
            }

            return status;
        }

        #endregion Player
        // ######################################################################
        //  xxxx     xxx     xxxx   xxxxx   xxxxx   xxxxx    xxx    x   x
        //  x   x   x   x   x         x       x       x     x   x   xx  x
        //  xxxx    x   x    xxx      x       x       x     x   x   x x x
        //  x       x   x       x     x       x       x     x   x   x  xx
        //  x        xxx    xxxx    xxxxx     x     xxxxx    xxx    x   x
        // ######################################################################
        #region Position
        public static long GetLength() {
            long    length  =   0;

            if ( IsInitialized() ) {
                if ( IsActivated() && stream != 0 ) {
                    length  =   Bass.BASS_ChannelGetLength( stream );
                }
            }

            return length;
        }

        // ----------------------------------------------------------------------
        public static long GetPosition() {
            long    position    =   0;

            if ( IsInitialized() ) {
                if ( IsActivated() && stream != 0 ) {
                    position    =   Bass.BASS_ChannelGetPosition( stream );
                }
            }

            return position;
        }

        // ----------------------------------------------------------------------
        public static void SetPosition( long position ) {
            if ( IsInitialized() ) {
                if ( IsActivated() && stream != 0 ) {
                    Bass.BASS_ChannelSetPosition( stream, position );
                }
            }
        }

        #endregion Position
        // ######################################################################
        //  xxxxx   xxxxx   x   x   xxxxx
        //    x       x     xx xx   x    
        //    x       x     x x x   xxxx 
        //    x       x     x   x   x    
        //    x     xxxxx   x   x   xxxxx
        // ######################################################################
        #region Time
        public static int[] GetFullTime() {
            int[]       result      =   new int[3] { 0, 0, 0 };
            double      totaltime   =   Bass.BASS_ChannelBytes2Seconds( stream, GetLength() );
            TimeSpan    time        =   TimeSpan.FromSeconds( totaltime );
            
            result[0]   =   time.Hours;
            result[1]   =   time.Minutes;
            result[2]   =   time.Seconds;
            return result;
        }

        // ----------------------------------------------------------------------
        public static int[] GetCurrentTime() {
            int[]       result      =   new int[3] { 0, 0, 0 };
            double      elapsedtime =   Bass.BASS_ChannelBytes2Seconds( stream, GetPosition() );
            TimeSpan    time        =   TimeSpan.FromSeconds( elapsedtime );
            
            result[0]   =   time.Hours;
            result[1]   =   time.Minutes;
            result[2]   =   time.Seconds;
            return result;
        }

        // ----------------------------------------------------------------------
        public static int[] GetReverseTime() {
            int[]       result      =   new int[3] { 0, 0, 0 };
            double      totaltime   =   Bass.BASS_ChannelBytes2Seconds( stream, GetLength() );
            double      elapsedtime =   Bass.BASS_ChannelBytes2Seconds( stream, GetPosition() );
            TimeSpan    time        =   TimeSpan.FromSeconds( totaltime - elapsedtime );

            result[0]   =   time.Hours;
            result[1]   =   time.Minutes;
            result[2]   =   time.Seconds;
            return result;
        }

        #endregion Time
        // ######################################################################
        //  xxxxx   x   x   xxxx    xxxxx   xxxx    xxxxx   x   x   xxxx    xxxxx   x   x   xxxxx
        //    x     xx  x    x  x   x       x   x   x       xx  x    x  x   x       xx  x     x  
        //    x     x x x    x  x   xxxx    xxxx    xxxx    x x x    x  x   xxxx    x x x     x  
        //    x     x  xx    x  x   x       x       x       x  xx    x  x   x       x  xx     x  
        //  xxxxx   x   x   xxxx    xxxxx   x       xxxxx   x   x   xxxx    xxxxx   x   x     x  
        //
        //  xxxxx   xxxxx   x   x   xxxxx
        //    x       x     xx xx   x    
        //    x       x     x x x   xxxx 
        //    x       x     x   x   x    
        //    x     xxxxx   x   x   xxxxx
        // ######################################################################
        #region IndependentTime
        public static string GetFullTime( string path, FormAnthraX mainWindow ) {
            string      result      =   "N/A";
            bool        tempInit    =   false;

            if ( !initialized ) {
                tempInit    =   Bass.BASS_Init( 0, 44100, BASSInit.BASS_DEVICE_DEFAULT, mainWindow.Handle);
                if ( !tempInit ) { return result; }
            }

            int         tempStream  =   Bass.BASS_StreamCreateFile( path, 0, 0, BASSFlag.BASS_DEFAULT );
            if ( tempStream != 0 ) {
                long        length      =   Bass.BASS_ChannelGetLength( tempStream );
                double      totaltime   =   Bass.BASS_ChannelBytes2Seconds( tempStream, length );
                TimeSpan    time        =   TimeSpan.FromSeconds( totaltime );
                int[]       values      =   new int[] { time.Hours, time.Minutes, time.Seconds };

                result      =   ((values[0] < 10) ? "0" + values[0].ToString() : values[0].ToString())
                    + ":" + ((values[1] < 10) ? "0" + values[1].ToString() : values[1].ToString())
                    + ":" + ((values[2] < 10) ? "0" + values[2].ToString() : values[2].ToString());
            }

            Bass.BASS_StreamFree( tempStream );
            if ( tempInit ) { Bass.BASS_Free(); }

            return result;
        }

        #endregion IndependentTime
        // ######################################################################
        //   xxxx   xxxx    xxxxx    xxx    xxxxx   xxxx    x   x   x   x
        //  x       x   x   x       x   x     x     x   x   x   x   xx xx
        //   xxx    xxxx    xxxx    x         x     xxxx    x   x   x x x
        //      x   x       x       x   x     x     x   x   x   x   x   x
        //  xxxx    x       xxxxx    xxx      x     x   x    xxx    x   x
        // ######################################################################
        #region Spectrum
        public static float[] GetSpectrumData( int size, int length ) {
            if ( IsActivated() ) {
                float[] FFTData     =   new float[ length ];
                Bass.BASS_ChannelGetData( stream, FFTData, size );
                return FFTData;
            }

            return null;
        }

        // ----------------------------------------------------------------------
        private static void CreateChannelMeters() {
            if ( !activated ) { return; }

            if ( channelMeter != null ) {
                channelMeter.Notification -= new EventHandler( SetChannelMeterLeft );
                channelsMeter   =   new int[] { 0, 0 };
            }

            channelMeter                =   new DSP_PeakLevelMeter( stream, -2000 );
            channelMeter.CalcRMS        =   true;
            channelMeter.Notification   +=  new EventHandler( SetChannelMeterLeft );
        }

        // ----------------------------------------------------------------------
        private static void SetChannelMeterLeft(object sender, EventArgs e) {
			try {
                channelsMeter[0] = channelMeter.LevelL;     // 65535
                channelsMeter[1] = channelMeter.LevelR;     // 65535
            } catch ( Exception exc ) {
                System.Console.WriteLine( exc.ToString() );
                channelsMeter   =   new int[] { 0, 0 };
            }
		}

        // ----------------------------------------------------------------------
        public static int[] GetChannelMeters() {
            int[]   result  =   new int[] { 0, 0 };
            if ( activated && GetPlayStatus() == PlayStatus.Play ) { 
                if ( channelMeter != null ) { result = channelsMeter; }
            }
            return result;
        }

        #endregion Spectrum
        // ######################################################################
        //  xxxxx    xxx    x   x    xxx    x       xxxxx   xxxxx   xxxxx   xxxx 
        //  x       x   x   x   x   x   x   x         x        x    x       x   x
        //  xxxx    x x x   x   x   xxxxx   x         x       x     xxxx    xxxx 
        //  x       x  xx   x   x   x   x   x         x      x      x       x   x
        //  xxxxx    xxx     xxx    x   x   xxxxx   xxxxx   xxxxx   xxxxx   x   x
        // ######################################################################
        #region Equalizer
        private static void EqualizerInit() {
            if ( !activated ) { return; }
            BASS_DX8_PARAMEQ    equalizer   =   new BASS_DX8_PARAMEQ();
            equalizer.fGain                 =   0f;
            equalizer.fBandwidth            =   18f;

            for ( int i = 0; i < presetData.Length; i++ ) {
                presetData[i]       =   Bass.BASS_ChannelSetFX( stream, BASSFXType.BASS_FX_DX8_PARAMEQ, 0 );
                equalizer.fCenter   =   Tools.equalizerFCenter[i];
                equalizer.fGain     =   0;
                Bass.BASS_FXSetParameters( presetData[i], equalizer );
            }
        }

        // ----------------------------------------------------------------------
        public static void SetEqualizer( int[] data ) {
            if ( !activated ) { return; }
            BASS_DX8_PARAMEQ    equalizer   =   new BASS_DX8_PARAMEQ();

            for ( int i = 0; i < presetData.Length; i++ ) {
                if ( Bass.BASS_FXGetParameters( presetData[i], equalizer ) ) {
                    equalizer.fGain     =   data[i];
                    Bass.BASS_FXSetParameters( presetData[i], equalizer );
                }
            }
        }

        // ----------------------------------------------------------------------
        public static void SetEqualizer( int band, int value ) {
            if ( !activated ) { return; }
            BASS_DX8_PARAMEQ    equalizer   =   new BASS_DX8_PARAMEQ();

            if (Bass.BASS_FXGetParameters(presetData[band], equalizer) ) {
                equalizer.fGain = value;
                Bass.BASS_FXSetParameters(presetData[band], equalizer);
            }
        }

        #endregion Equalizer
        // ######################################################################
        //  xxxxx   xxxxx   xxxxx   xxxxx    xxx    xxxxx    xxxx
        //  x       x       x       x       x   x     x     x    
        //  xxxx    xxxx    xxxx    xxxx    x         x      xxx 
        //  x       x       x       x       x   x     x         x
        //  xxxxx   x       x       xxxxx    xxx      x     xxxx 
        // ######################################################################
        #region Effects
        // ----------------------------------------------------------------------
        //  ECHO EFFECT
        // ----------------------------------------------------------------------
        #region EffectEcho
        private static void EchoCreate() {
            float   wetDryMix   =   90f;
            float   feedback    =   50f;
            float   leftDelay   =   500f;
            float   rightDelay  =   500f;
            bool    panDelay    =   false;
            echoData    =   new BASS_DX8_ECHO( wetDryMix, feedback, leftDelay, rightDelay, panDelay );
        }

        // ----------------------------------------------------------------------
        private static void EchoInit() {
            if ( !activated ) { return; }

            echoHandle              =   Bass.BASS_ChannelSetFX( stream, BASSFXType.BASS_FX_DX8_ECHO, 2 );
            echoData.fWetDryMix     =   0f;
            Bass.BASS_FXSetParameters( echoHandle, echoData );
        }

        // ----------------------------------------------------------------------
        public static void SetEcho( bool active, int value ) {
            if ( !activated ) { return; }
            int data    =   active ? value : 0;
            echoData.fWetDryMix     =   (float) data;
			Bass.BASS_FXSetParameters( echoHandle, echoData );
        }

        #endregion EffectEcho
        // ----------------------------------------------------------------------
        //  REVERB EFFECT
        // ----------------------------------------------------------------------
        #region EffectReverb
        private static void ReverbCreate() {
            float   inGain      =   0f;
            float   reverbMix   =   -96f;
            float   reverbTime  =   1500f;
            float   hfRation    =   0.1f;
            reverbData          =   new BASS_DX8_REVERB( inGain, reverbMix, reverbTime, hfRation );
        }

        // ----------------------------------------------------------------------
        private static void ReverbInit() {
            if ( !activated ) { return; }

            reverbHandle            =   Bass.BASS_ChannelSetFX( stream, BASSFXType.BASS_FX_DX8_REVERB, 2 );
            reverbData.fReverbMix   =   -96f;
            Bass.BASS_FXSetParameters( reverbHandle, reverbData );
        }

        // ----------------------------------------------------------------------
        public static void SetReverb( bool active, int value ) {
            if ( !activated ) { return; }

            if ( active ) {
                int muliply             =  20 - value;
                reverbData.fReverbMix   =  -0.012f * (float) Math.Pow( muliply, 3 );
                //reverbData.fReverbMix   =   value;
            } else {
                reverbData.fReverbMix   =   -96f;
            }
			Bass.BASS_FXSetParameters( reverbHandle, reverbData );
        }

        #endregion EffectReverb
        // ----------------------------------------------------------------------
        //  CHORUS EFFECT
        // ----------------------------------------------------------------------
        #region EffectChorus
        private static void ChorusCreate() {
            BASSFXPhase phrase      =   BASSFXPhase.BASS_FX_PHASE_NEG_90;
            float       wetDryMix   =   0f;
            float       depth       =   25f;
            float       feedback    =   90f;
            float       frequency   =   5f;
            int         waveForm    =   1;
            float       delay       =   0f;

            chorusData  =   new BASS_DX8_CHORUS(
                wetDryMix, depth, feedback, frequency, waveForm, delay, phrase );
        }

        // ----------------------------------------------------------------------
        private static void ChorusInit() {
            if ( !activated ) { return; }

            chorusHandle            =   Bass.BASS_ChannelSetFX( stream, BASSFXType.BASS_FX_DX8_CHORUS, 1 );
            chorusData.fWetDryMix   =   0f;
            Bass.BASS_FXSetParameters( chorusHandle, chorusData );
        }

        // ----------------------------------------------------------------------
        public static void SetChorus( bool active, int value ) {
            if ( !activated ) { return; }
            int data    =   active ? value : 0;
            chorusData.fWetDryMix   =   (float) data;
            Bass.BASS_FXSetParameters( chorusHandle, chorusData );
        }

        #endregion EffectChorus
        // ----------------------------------------------------------------------
        //  AMPLIFICATION
        // ----------------------------------------------------------------------
        #region EffectAmplification
        private static void AmplificationInit() {
            if ( !activated ) { return; }
            amplification   =   new DSP_Gain( stream, 0 );
        }

        // ----------------------------------------------------------------------
        public static void SetAmplification( bool active, int value ) {
            if ( !activated ) { return; }
            int data    =   active ? value : 0;

            if ( amplification != null ) {
                try {
					double gainDB   =   (double) data;
					if ( gainDB == 0.0 ) {
                        amplification.SetBypass( true );
					} else {
                        amplification.SetBypass( false );
                        amplification.Gain_dBV  =   gainDB;
					}
				}
				catch { }
            }
        }

        #endregion EffectAmplification
        // ----------------------------------------------------------------------
        //  SOFT SATURATION
        // ----------------------------------------------------------------------
        #region SoftSaturation
        private static void SoftSaturationInit() {
            if ( !activated ) { return; }
            softSaturation  =   new DSP_SoftSaturation( stream, 0 );
        }

        // ----------------------------------------------------------------------
        public static void SetSoftSaturation( bool active, int saturation, int depth ) {
            if ( !activated ) { return; }
            
            if ( softSaturation != null ) {
                softSaturation.SetBypass( !active );
                softSaturation.Factor   =   saturation / 100d;
                softSaturation.Depth    =   depth / 100d;
            }
        }

        #endregion SoftSaturation
        // ----------------------------------------------------------------------
        //  STEREO ENHANCER
        // ----------------------------------------------------------------------
        #region StereoEnhancer
        private static void StereoEnhancerInit() {
            if ( !activated ) { return; }
            stereoEnhancer  =   new DSP_StereoEnhancer( stream, 0 );
        }

        // ----------------------------------------------------------------------
        public static void SetStereoEnhancer( bool active, int wide, int wetdry ) {
            if ( !activated ) { return; }

            if ( stereoEnhancer != null ) {
                stereoEnhancer.SetBypass( !active );
                stereoEnhancer.WideCoeff    =   wide / 100d;
                stereoEnhancer.WetDry       =   wetdry / 100d;
            }
        }

        #endregion StereoEnhancer
        // ----------------------------------------------------------------------
        //  IRR DELAY
        // ----------------------------------------------------------------------
        #region IRRDelay
        private static void IRRDelayInit() {
            if ( !activated ) { return; }
            iRRDelay    =   new DSP_IIRDelay( stream, 0, 2f );
        }

        // ----------------------------------------------------------------------
        public static void SetIRRDelay( bool active, int delay, int wetdry, int feedback ) {
            if ( !activated ) { return; }

            if ( iRRDelay != null ) {
                iRRDelay.SetBypass( !active );
                iRRDelay.Delay      =   delay;
                iRRDelay.WetDry     =   wetdry / 100d;
                iRRDelay.Feedback   =   feedback / 100d;
            }
        }

        #endregion IRRDelay
        #endregion Effects
        // ######################################################################

    }

    // ################################################################################

}
