using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnthraX.DataStructures {

    // ################################################################################
    //  XXXX     XXX    XXXXX   X   X   XXX      XXX    X   X
    //  X   X   X   X     X     XX  X   X  X    X   X   X   X
    //  XXXX    XXXXX     X     X X X   XXXX    X   X   X X X
    //  X   X   X   X     X     X  XX   X   X   X   X   XX XX
    //  X   X   X   X   XXXXX   X   X   XXXX     XXX    X   X
    //
    //   xxx     xxx    x        xxx    xxxx 
    //  x   x   x   x   x       x   x   x   x
    //  x       x   x   x       x   x   xxxx 
    //  x   x   x   x   x       x   x   x   x
    //   xxx     xxx    xxxxx    xxx    x   x
    // ################################################################################
    public static class RainbowColor {

        private static  Color   rainbow         =   Color.Red;
        private static  int     position        =   0;
        private static  float   localFrequency  =   0f;

        private static  Color   bRainbow        =   Color.Red;
        private static  int     bPosition       =   0;

        // ######################################################################
        //  xxxxx   x   x   xxxxx   xxxxx
        //    X     XX  X     X       X  
        //    X     X X X     X       X  
        //    X     X  XX     X       X  
        //  XXXXX   X   X   XXXXX     X  
        // ######################################################################
        public static void resetColor() {
            rainbow     =   Color.Red;
            bRainbow    =   Color.Red;
        }

        // ----------------------------------------------------------------------
        public static Color getColor() { return rainbow; }

        // ######################################################################
        //  XXXXX    XXX     XXX    X        XXXX
        //    X     X   X   X   X   X       X    
        //    X     X   X   X   X   X        XXX 
        //    X     X   X   X   X   X           X
        //    X      XXX     XXX    XXXXX   XXXX 
        // ######################################################################
        public static void makeBackup() { bRainbow = Color.FromArgb( 255, rainbow ); bPosition = position; }
        public static void makeRecover() { rainbow = Color.FromArgb( 255, bRainbow ); position = bPosition; }

        // ######################################################################
        //  X   X    XXX    XXXX    X   X
        //  X   X   X   X   X   X   X  X 
        //  X X X   X   X   XXXX    XXX  
        //  XX XX   X   X   X   X   X  X 
        //  X   X    XXX    X   X   X   X
        // ######################################################################
        public static void nextColor( int colorJump, float frequency ) {
            localFrequency  +=  frequency;
            if ( localFrequency >= 1 ) {
                localFrequency  =   0;
                nextColor( colorJump );
            }
        }

        // ----------------------------------------------------------------------
        public static void nextColor( int colorJump ) {
            if ( localFrequency >= 1 ) { localFrequency = 0; }

            switch ( position ) {
                case 0:
                    // 255, 255, 0, 0 -> 255, 255, 255, 0
                    if ( rainbow.G+colorJump <= 255 ) { rainbow = Color.FromArgb( 255, rainbow.R, rainbow.G+colorJump, rainbow.B ); }
                    else { rainbow = Color.FromArgb( 255, 255, 255, 0 ); position = 1; }
                    break;

                case 1:
                    // 255, 255, 255, 0 -> 255, 0, 255, 0
                    if ( rainbow.R-colorJump >= 0 ) { rainbow = Color.FromArgb( 255, rainbow.R-colorJump, rainbow.G, rainbow.B ); }
                    else { rainbow = Color.FromArgb( 255, 0, 255, 0 ); position = 2; }
                    break;

                case 2:
                    // 255, 0, 255, 0 -> 255, 0, 255, 255
                    if ( rainbow.B+colorJump <= 255 ) { rainbow = Color.FromArgb( 255, rainbow.R, rainbow.G, rainbow.B+colorJump ); }
                    else { rainbow = Color.FromArgb( 255, 0, 255, 255 ); position = 3; }
                    break;
                
                case 3:
                    // 255, 0, 255, 255 -> 255, 0, 0, 255
                    if ( rainbow.G-colorJump >= 0 ) { rainbow = Color.FromArgb( 255, rainbow.R, rainbow.G-colorJump, rainbow.B ); }
                    else { rainbow = Color.FromArgb( 255, 0, 0, 255 ); position = 4; }
                    break;
                
                case 4:
                    // 255, 0, 0, 255 -> 255, 255, 0, 255
                    if ( rainbow.R+colorJump <= 255 ) { rainbow = Color.FromArgb( 255, rainbow.R+colorJump, rainbow.G, rainbow.B ); }
                    else { rainbow = Color.FromArgb( 255, 255, 0, 255 ); position = 5; }
                    break;
                
                case 5:
                    // 255, 255, 0, 255 -> 255, 255, 0, 0
                    if ( rainbow.B-colorJump >= 0 ) { rainbow = Color.FromArgb( 255, rainbow.R, rainbow.G, rainbow.B-colorJump ); }
                    else { rainbow = Color.FromArgb( 255, 255, 0, 0 ); position = 0; }
                    break;
            }
        }

        // ######################################################################
    }

    // ################################################################################

}
