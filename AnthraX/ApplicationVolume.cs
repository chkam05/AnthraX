using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AnthraX {

    // ################################################################################
    //  x   x    xxx    x       x   x   x   x   xxxxx
    //  x   x   x   x   x       x   x   xx xx   x    
    //  x   x   x   x   x       x   x   x x x   xxxx 
    //   x x    x   x   x       x   x   x   x   x    
    //    x      xxx    xxxxx    xxx    x   x   xxxxx
    // ################################################################################
    public static class ApplicationVolume {

        [DllImport("winmm.dll", EntryPoint = "waveOutSetVolume")]
        public static extern int WaveOutSetVolume(IntPtr hwo, uint dwVolume);

        [DllImport("winmm.dll", EntryPoint = "waveOutGetVolume")]
        public static extern int WaveOutGetVolume(IntPtr hwo, out uint dwVolume);

        private static  uint    currentVolume   =   System.Convert.ToUInt32( ushort.MaxValue );

        // ######################################################################
        //   xxxx   xxxxx   xxxxx
        //  x       x         x  
        //   xxx    xxxx      x  
        //      x   x         x  
        //  xxxx    xxxxx     x  
        // ######################################################################
        public static void SetVolume( int volume ) {
            currentVolume   =   System.Convert.ToUInt32( (ushort.MaxValue / (double)100) * volume );
            WaveOutSetVolume( IntPtr.Zero, System.Convert.ToUInt32((currentVolume & 0xFFFF) | (currentVolume << 16)) );
        }

        // ----------------------------------------------------------------------
        public static void Mute( bool mute, int volume ) {
            int newVolume   =   mute ? 0 : volume;
            currentVolume   =   System.Convert.ToUInt32( (ushort.MaxValue / (double)100) * newVolume );
            WaveOutSetVolume( IntPtr.Zero, System.Convert.ToUInt32((currentVolume & 0xFFFF) | (currentVolume << 16)) );
        }

        // ######################################################################
        //   xxxx   xxxxx   xxxxx
        //  x       x         x  
        //  x  xx   xxxx      x  
        //  x   x   x         x  
        //   xxxx   xxxxx     x  
        // ######################################################################
        public static int GetVolume() {
            WaveOutGetVolume( IntPtr.Zero, out currentVolume );
            return System.Convert.ToInt32((currentVolume & 0xFFFF) / (ushort.MaxValue / (double)100));
        }

        // ######################################################################
    }

    // ################################################################################
}
