using AnthraX.Libraries;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AnthraX {

    // ################################################################################
    //   xxx             x      x                            
    //  x   x            x      x                            
    //  xxxxx   x xx    xxx     x xx    x xx     xx     x x  
    //  x   x   xx  x    x      xx  x   xx      x  x     x   
    //  x   x   x   x     xx    x   x   x        xx x   x x  
    // ################################################################################
    static class Program {

        private const   string      mutexName           =   "AnthraX";

        private static  bool        mutexNew            =   true;
        private static  Mutex       mutex;
        private static  bool        existingProcess     =   false;
        private static  string      windowName          =   "";
        private static  string      arguments           =   "";

        // ######################################################################
        //  xxxxx   x   x   xxxx     xxx    xxxx    xxxxx
        //    x     xx xx   x   x   x   x   x   x     x  
        //    x     x x x   xxxx    x   x   xxxx      x  
        //    x     x   x   x       x   x   x   x     x  
        //  xxxxx   x   x   x        xxx    x   x     x  
        // ######################################################################

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        // ######################################################################
        //  xxxxx   x   x   xxxxx   xxxxx
        //    x     xx  x     x       x  
        //    x     x x x     x       x  
        //    x     x  xx     x       x  
        //  xxxxx   x   x   xxxxx     x  
        // ######################################################################
        /// <summary> Funkcja inicjująca działanie aplikacji i okna głównego. </summary>
        /// <param name="args"> Argumenty przekazywane do aplikacji (np. z konsoli). </param>
        [STAThread]
        static void Main( string[] args ) {
            int[]   osVersion   =   Tools.GetSystemVersion();
                    mutex       =   CreateMutex( mutexName, out mutexNew );
            foreach (string s in args) { arguments += s + "\n"; }

            // --- Check if Windows Version is correct ---
            if ( osVersion[0] < 6 || ( osVersion[0] <= 6 && osVersion[1] < 1 ) ) {
                string  title   =   "Incompatible Windows Version";
                string  version =   osVersion[0].ToString() + "." + osVersion[1].ToString() + "." + osVersion[2].ToString();
                string  message =   "Current Windows " + version + " version, is not supported by application.";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Stop );

                Application.Exit();
                return;
            }

            // --- Check if Application is running ---
            if ( !mutexNew ) {
                existingProcess     =   ManageExistingProcess( Process.GetCurrentProcess(), out windowName );
                if ( existingProcess ) {

                    if ( arguments.Length > 0 ) {
                        SendMessageProcess( windowName, arguments );
                    } else {
                        string  title   =   "Initialization Stopped";
                        string  message =   "Application is alredy running." + Environment.NewLine + "More than 1 instances are forbidden!";
                        MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                    }
                    
                    Application.Exit();
                    return;
                }
            }

            // --- Check if library BASS.NET.DLL exists ---
            if ( !SoundModule.CheckLibrary( "bass.net.dll" ) ) {
                string  title   =   "Initialization Error";
                string  message =   "Library Bass.Net.dll has not been found!";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Error );
                Application.Exit();
                return;
            }

            // --- Check if library BASS.DLL exists ---
            if ( !SoundModule.CheckLibrary( "bass.dll" ) ) {
                string  title   =   "Initialization Error";
                string  message =   "Library Bass.dll has not been found!";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Error );
                Application.Exit();
                return;
            }

            // --- Check if library BASS_FX.DLL exists ---
            if ( !SoundModule.CheckLibrary( "Bass_fx.dll" ) ) {
                string  title   =   "Initialization Error";
                string  message =   "Library Bass_fx.dll has not been found!";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Error );
                Application.Exit();
                return;
            }

            // --- Check if library taglib-sharp.DLL exists ---
            if ( !SoundModule.CheckLibrary( "taglib-sharp.dll" ) ) {
                string  title   =   "Initialization Error";
                string  message =   "Library Bass_fx.dll has not been found!";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Error );
                Application.Exit();
                return;
            }

            // --- Check if library BASS.DLL version is correct ---
            if ( !SoundModule.CheckVersion( 2, 4 ) ) {
                string  title   =   "Initialization Error";
                string  message =   "Bass library Version outdated!";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Error );
                Application.Exit();
                return;
            }

            // --- Initial Config ---
            CreateDirectories();

            // --- Run application with arguments ---
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run(new FormAnthraX( arguments ));
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja tworząca obiekt w systemie, informujący o tym że aplikacja jest już uruchomiona. </summary>
        /// <param name="name"> Nazwa aplikacji. </param>
        /// <param name="exist"> Informacja zwrotna, dotycząca istniejącej już instancji aplikacji. </param>
        /// <returns></returns>
        private static Mutex CreateMutex( string name, out bool exist ) {
            return new Mutex( true, name, out exist );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja tworząca foldery (jeżeli nie istnieją) które będą przechowywać ustawienia aplikacji. </summary>
        private static void CreateDirectories() {
            string  configDir   =   Tools.GetDirectoryAppData() + "\\AnthraX";
            string  libraryDir  =   configDir + "\\Library";
            string  presetsDir  =   configDir + "\\Presets";
            string  effectsDir  =   configDir + "\\Effects";
            string  karaokeDir  =   configDir + "\\Karaoke";

            if ( !Directory.Exists( configDir ) ) { Directory.CreateDirectory( configDir ); }
            if ( !Directory.Exists( libraryDir ) ) { Directory.CreateDirectory( libraryDir ); }
            if ( !Directory.Exists( presetsDir ) ) { Directory.CreateDirectory( presetsDir ); }
            if ( !Directory.Exists( effectsDir ) ) { Directory.CreateDirectory( effectsDir ); }
            if ( !Directory.Exists( karaokeDir ) ) { Directory.CreateDirectory( karaokeDir ); }
        }

        // ######################################################################
        //  x   x    xxx    x   x    xxx     xxxx   xxxxx
        //  xx xx   x   x   xx  x   x   x   x       x    
        //  x x x   xxxxx   x x x   xxxxx   x  xx   xxxx 
        //  x   x   x   x   x  xx   x   x   x   x   x    
        //  x   x   x   x   x   x   x   x    xxxx   xxxxx
        //
        //  xxxx    xxxx     xxx     xxx    xxxxx    xxxx    xxxx
        //  x   x   x   x   x   x   x   x   x       x       x    
        //  xxxx    xxxx    x   x   x       xxxx     xxx     xxx 
        //  x       x   x   x   x   x   x   x           x       x
        //  x       x   x    xxx     xxx    xxxxx   xxxx    xxxx 
        // ######################################################################
        /// <summary> Funkcja sprawdzająca czy proces aplikacji jest już uruchomiony. </summary>
        /// <param name="current"> Aktualny proces uruchamianej aplikacji. </param>
        /// <param name="windowName"> Nazwa okna aplikacji. </param>
        /// <returns></returns>
        private static bool ManageExistingProcess( Process current, out string windowName ) {
            foreach ( Process process in Process.GetProcessesByName(current.ProcessName) ) {
                if ( process.Id != current.Id ) {
                    SetForegroundWindow( process.MainWindowHandle );
                    windowName = process.MainWindowTitle;
                    return true;
                }
            }

            windowName = "";
            return false;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wysyłająca argumenty do aktywnej aplikacji. </summary>
        /// <param name="windowTitle"> Nazwa okna aplikacji. </param>
        /// <param name="message"> Dane które mają zostać wysłane. </param>
        /// <returns></returns>
        private static bool SendMessageProcess( string windowTitle, string message ) {
            // --- Finding the Existing Application Window ---
            IntPtr  ptrWnd  =   ProcessMessages.FindWindow( null, windowTitle );
            
            if ( ptrWnd == IntPtr.Zero ) {
                System.Console.WriteLine( String.Format("No window found with the title {0}.", windowTitle) );
                MessageBox.Show( "Not found window" );
                return false;

            } else {
                IntPtr  ptrCopyData     =   IntPtr.Zero;
                try {
                    // --- Create message data structure ---
                    ProcessMessages.COPYDATASTRUCT copyData     =   new ProcessMessages.COPYDATASTRUCT();
                    copyData.dwData                             =   new IntPtr(2);          // Identification dataType
                    copyData.cbData                             =   message.Length + 1;     // Message dataLength + '\0'
                    copyData.lpData                             =   Marshal.StringToHGlobalAnsi( message );

                    // --- Memory allocation for Data copy ---
                    ptrCopyData                                 =   Marshal.AllocCoTaskMem( Marshal.SizeOf(copyData) );
                    Marshal.StructureToPtr( copyData, ptrCopyData, false );

                    // --- Sending Data ---
                    ProcessMessages.SendMessage( ptrWnd, ProcessMessages.WM_COPYDATA, IntPtr.Zero, ptrCopyData );
                
                } catch ( Exception ex ) {
                    System.Console.WriteLine( ex.ToString() );
                    MessageBox.Show( ex.ToString() );
                    return false;

                } finally {
                    // --- Empty allocated memory ---
                    if ( ptrCopyData != IntPtr.Zero ) { Marshal.FreeCoTaskMem( ptrCopyData ); }
                }

                return true;
            }
        }

        // ######################################################################
    }

    // ################################################################################
}
