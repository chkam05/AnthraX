using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace AnthraX {

    // ################################################################################
    //   xxxx   x       xxxxx   xxxx    xxxxx   xxxx      x   x   x   x    xxxx   xxxxx    xxx 
    //  x       x         x      x  x   x       x   x     xx xx   x   x   x         x     x   x
    //   xxx    x         x      x  x   xxxx    xxxx      x x x   x   x    xxx      x     x    
    //      x   x         x      x  x   x       x   x     x   x   x   x       x     x     x   x
    //  xxxx    xxxxx   xxxxx   xxxx    xxxxx   x   x     x   x    xxx    xxxx    xxxxx    xxx 
    // ################################################################################
    public class CustomSlider {

        private int     leftSpace       =   0;
        private int     rightSpace      =   0;
        private int     topSpace        =   0;
        private int     height          =   0;
        private int     width           =   0;
        private int     position        =   0;

        // ######################################################################
        //  xxxxx   x   x   xxxxx   xxxxx
        //    x     xx  x     x       x  
        //    x     x x x     x       x  
        //    x     x  xx     x       x  
        //  xxxxx   x   x   xxxxx     x  
        // ######################################################################
        public CustomSlider( int width, int height, int leftSpace, int topSpace ) {
            this.width      =   width;
            this.height     =   height;
            this.leftSpace  =   leftSpace;
            this.topSpace   =   topSpace;
        }

        // ######################################################################
        //  xxxx     xxx     xxxx   xxxxx   xxxxx   xxxxx    xxx    x   x
        //  x   x   x   x   x         x       x       x     x   x   xx  x
        //  xxxx    x   x    xxx      x       x       x     x   x   x x x
        //  x       x   x       x     x       x       x     x   x   x  xx
        //  x        xxx    xxxx    xxxxx     x     xxxxx    xxx    x   x
        // ######################################################################
        public void Update( int fullWidth, int fullHeight ) {
            this.position       =   this.position * fullWidth / ( rightSpace + leftSpace );
            this.rightSpace     =   fullWidth - leftSpace;
            this.height         =   fullHeight - 2*topSpace;
            UpdatePosition( this.position );
        }

        // ----------------------------------------------------------------------
        public void UpdatePosition( int position ) {
            // --- Ograniczenie Lewe ---
            if ( position + width / 2 <= leftSpace + width ) {
                this.position = leftSpace;
            // --- Oraniczenie Prawe ---
            } else if ( position - width / 2 >= rightSpace - width ) {
                this.position = rightSpace - width;
            // --- Pozycja Środkowa ---
            } else {
                this.position = position - width / 2;
            }
        }

        // ----------------------------------------------------------------------
        public void SetPosition( long length, long position ) {
            int width       =   rightSpace - leftSpace - this.width;
            int newPosition =   (int) (width * position / length);
            this.position   =   newPosition + leftSpace;
        }

        // ######################################################################
        //   xxxx   xxxxx   xxxxx   xxxxx   xxxxx   xxxx     xxxx
        //  x       x         x       x     x       x   x   x    
        //  x  xx   xxxx      x       x     xxxx    xxxx     xxx 
        //  x   x   x         x       x     x       x   x       x
        //   xxxx   xxxxx     x       x     xxxxx   x   x   xxxx 
        // ######################################################################
        public Rectangle GetDrawBar() {
            return new Rectangle( position, topSpace, width, height );
        }
        // ----------------------------------------------------------------------
        public int GetHeight() { return this.height; }
        public int GetWidth() { return this.width; }
        public int GetLeftSpace() { return this.leftSpace; }
        public int GetRightSpace() { return this.rightSpace; }
        public int GetTopSpace() { return this.topSpace; }
        public int GetPosition() { return this.position - this.leftSpace + width/2; }
        public int GetSpaceWidth() { return this.rightSpace - this.leftSpace - width; }
        // ######################################################################
    }

    // ################################################################################
}
