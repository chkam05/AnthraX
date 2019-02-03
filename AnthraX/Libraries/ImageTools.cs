using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace AnthraX {

    // ################################################################################
    //  xxxxx   x   x    xxx     xxxx   xxxxx
    //    x     xx xx   x   x   x       x    
    //    x     x x x   xxxxx   x  xx   xxxx 
    //    x     x   x   x   x   x   x   x    
    //  xxxxx   x   x   x   x    xxxx   xxxxx
    //
    //  XXXXX    XXX     XXX    X        XXXX
    //    X     X   X   X   X   X       X    
    //    X     X   X   X   X   X        XXX 
    //    X     X   X   X   X   X           X
    //    X      XXX     XXX    XXXXX   XXXX 
    // ################################################################################
    public static class ImageTools {

        // ######################################################################
        //  XXXX    XXXXX    XXXX   XXXXX   XXXXX   XXXXX
        //  X   X   X       X         X        X    X    
        //  XXXX    XXXX     XXX      X       X     XXXX 
        //  X   X   X           X     X      X      X    
        //  X   X   XXXXX   XXXX    XXXXX   XXXXX   XXXXX
        // ######################################################################
        /// <summary> Rysuje wycinek obrazu o określonym punkcie i rozmiarach. </summary>
        /// <param name="image"> Rysowany obraz. </param>
        /// <param name="XY"> Punkt X i Y początku wycinka. </param>
        /// <param name="destSize"> Rozmair wycinka. </param>
        /// <returns> Narysowany obraz. </returns>
        public static Image CutImage( Image image, Rectangle destSize ) {
            Image       processing  =   new Bitmap( destSize.Width, destSize.Height );
            Graphics    g           =   Graphics.FromImage( processing );

            Rectangle   srcR        =   new Rectangle( destSize.X, destSize.Y, destSize.Width, destSize.Height );
            Rectangle   dstR        =   new Rectangle( 0, 0, destSize.Width, destSize.Height );
            
            // 1. Okno obszaru wychodzi poza punkt 0 obrazu
            if ( destSize.X < 0 ) {
                dstR.X = destSize.X*(-1);                       //  Obszar rysowania punkt rozpoczęcia obrazu
                srcR.X = 0;                                     //  Obszar obrazu punkt 0
                srcR.Width = destSize.Width + destSize.X;       //  Obszar obrazu - wycinany obszar
            }
            if ( destSize.Y < 0 ) {
                dstR.Y = destSize.Y*(-1);                       //  Obszar rysowania punkt rozpoczęcia obrazu
                srcR.Y = 0;                                     //  Obszar obrazu punkt 0
                srcR.Height = destSize.Height + destSize.Y;     //  Obszar obrazu - wycinany obszar
            }

            // 2. Orkno obszaru wychodzi poza rozmiary obrazu
            if ( destSize.X + destSize.Width > image.Width ) {
                if ( dstR.X > 0 ) {
                    srcR.Width = image.Width;                   // Obszar obrazu - wycinany obszar
                    dstR.Width = image.Width;                   // Obszar rysowania - zapełniany obszar
                } else {
                    srcR.Width = image.Width - destSize.X;      // Obszar obrazu - wycinany obszar
                    dstR.Width = srcR.Width;                    // Obszar rysowania - zapełniany obszar
                }
            }
            if ( destSize.Y + destSize.Height > image.Height ) {
                if ( dstR.Y > 0 ) {
                    srcR.Height = image.Height;                 // Obszar obrazu - wycinany obszar
                    dstR.Height = image.Height;                 // Obszar rysowania - zapełniany obszar
                } else {
                    srcR.Height = image.Height - destSize.Y;    // Obszar obrazu - wycinany obszar
                    dstR.Height = srcR.Height;                  // Obszar rysowania - zapełniany obszar
                }
            }

            g.DrawImage( image, dstR, srcR, GraphicsUnit.Pixel );
            return  processing;
        }

        // ----------------------------------------------------------------------
        /// <summary> Rysuje obraz na obszarze nie zmieniając swoich rozmiarów (może zostać ucięty). </summary>
        /// <param name="image"> Rysowany obraz. </param>
        /// <param name="destSize"> Rozmiar obszaru na którym obraz ma zostać narysowany. </param>
        /// <returns> Narysowany obraz. </returns>
        public static Image DrawImage( Image image, Rectangle destSize ) {
            Image       processing  =   new Bitmap( destSize.Width, destSize.Height );
            Graphics    g           =   Graphics.FromImage( processing );

            Rectangle   srcR        =   new Rectangle( 0, 0, image.Width, image.Height );
            Rectangle   dstR        =   new Rectangle( 0, 0, destSize.Width, destSize.Height );

            if ( destSize.Width < image.Width ) { srcR.Width = destSize.Width; }
            else if ( destSize.Width > image.Width ) { dstR.Width = image.Width; }
            if ( destSize.Height < image.Height ) { srcR.Height = destSize.Height; }
            else if ( destSize.Height > image.Height ) { dstR.Height = image.Height; }

            g.DrawImage( image, dstR, srcR, GraphicsUnit.Pixel );
            return  processing;
        }

        // ----------------------------------------------------------------------
        /// <summary> Rysuje obraz w centrum obszaru nie zmieniając swoich rozmiarów (może zostać ucięty). </summary>
        /// <param name="image"> Rysowany obraz. </param>
        /// <param name="destSize"> Rozmiar obszaru na którym obraz ma zostać narysowany. </param>
        /// <returns> Narysowany obraz. </returns>
        public static Image DrawCenterImage( Image image, Rectangle destSize ) {
            Image       processing  =   new Bitmap( destSize.Width, destSize.Height );
            Graphics    g           =   Graphics.FromImage( processing );
            Rectangle   srcR        =   new Rectangle( 0, 0, image.Width, image.Height );
            int         dstX        =   (destSize.Width - image.Width) / 2;
            int         dstY        =   (destSize.Height - image.Height) / 2;
            Rectangle   dstR        =   new Rectangle( dstX, dstY, image.Width, image.Height );

            g.DrawImage( image, dstR, srcR, GraphicsUnit.Pixel );
            return  processing;
        }

        // ----------------------------------------------------------------------
        /// <summary> Rysuje obraz dostosowując jego rozmiary do rozmiarów obszaru bez różnicy rozciągnięć osi X i Y. </summary>
        /// <param name="image"> Rysowany obraz. </param>
        /// <param name="destSize"> Rozmiar obszaru na którym obraz ma zostać narysowany. </param>
        /// <returns> Narysowany obraz. </returns>
        public static Image DrawResizedImage( Image image, Rectangle destSize ) {
            float       zoom        =   Math.Max(
                (float)destSize.Width/image.Width,
                (float)destSize.Height/ image.Height );
            Image       processing  =   new Bitmap(
                Convert.ToInt32(image.Width * zoom),
                Convert.ToInt32(image.Height * zoom) );
            Graphics    g           =   Graphics.FromImage( processing );
            Rectangle   dstR        =   new Rectangle( 0, 0, processing.Width, processing.Height );
            Rectangle   srcR        =   new Rectangle( 0, 0, image.Width, image.Height );

            g.DrawImage( image, dstR, srcR, GraphicsUnit.Pixel );

            Image       result      =   new Bitmap( destSize.Width, destSize.Height );
            Graphics    r           =   Graphics.FromImage( result );
            r.DrawImage( processing, 0, 0 );
            return result;
        }

        // ----------------------------------------------------------------------
        /// <summary> Rysuje obraz na obszarze rozciągając się na nim w osiach X i Y. </summary>
        /// <param name="image"> Rysowany obraz. </param>
        /// <param name="destSize"> Rozmiar obszaru na którym obraz ma zostać narysowany. </param>
        /// <returns> Narysowany obraz. </returns>
        public static Image DrawStrechetImage( Image image, Rectangle destSize ) {
            Image       processing  =   new Bitmap( destSize.Width, destSize.Height );
            Graphics    g           =   Graphics.FromImage( processing );
            Rectangle   srcR        =   new Rectangle( 0, 0, image.Width, image.Height );
            Rectangle   dstR        =   new Rectangle( 0, 0, destSize.Width, destSize.Height );

            g.DrawImage( image, dstR, srcR, GraphicsUnit.Pixel );
            return  processing;
        }

        // ----------------------------------------------------------------------
        /// <summary> Ryzuje obraz na obszarze (wypełnia go) dostosowując się minimalnie do jego rozmiarów i centrując go bez różnicy rozciągnięć osi X i Y. </summary>
        /// <param name="image"> Rysowany obraz. </param>
        /// <param name="destSize"> Rozmiar obszaru na którym obraz ma zostać narysowany. </param>
        /// <returns> Narysowany obraz. </returns>
        public static Image DrawAdjustedMinImage( Image image, Rectangle destSize ) {
            float       zoom        =   Math.Min(
                (float)destSize.Width/image.Width,
                (float)destSize.Height/ image.Height );
            Image       processing  =   new Bitmap(
                Convert.ToInt32(image.Width * zoom),
                Convert.ToInt32(image.Height * zoom) );
            Graphics    g           =   Graphics.FromImage( processing );
            Rectangle   dstR        =   new Rectangle( 0, 0, processing.Width, processing.Height );
            Rectangle   srcR        =   new Rectangle( 0, 0, image.Width, image.Height );
            Point       dstP        =   new Point( 0, 0 );

            g.DrawImage( image, dstR, srcR, GraphicsUnit.Pixel );
            if (processing.Width < destSize.Width) { dstP.X = (destSize.Width - processing.Width) / 2; }
            if (processing.Height < destSize.Height) { dstP.Y = (destSize.Height - processing.Height) / 2; }

            Image       result      =   new Bitmap( destSize.Width, destSize.Height );
            Graphics    r           =   Graphics.FromImage( result );
            r.DrawImage( processing, dstP );
            return result;
        }

        // ----------------------------------------------------------------------
        /// <summary> Rysuje obraz na obszarze (wypełnia go) dostosowując się maksymalnie do jego rozmairów i centrując go bez różnicy rozciągnięć osi X i Y (może zostać ucięty). </summary>
        /// <param name="image"> Rysowany obraz. </param>
        /// <param name="destSize"> Rozmiar obszaru na którym obraz ma zostać narysowany. </param>
        /// <returns> Narysowany obraz. </returns>
        public static Image DrawAdjustedMaxImage( Image image, Rectangle destSize ) {
            float       zoom        =   Math.Max(
                (float)destSize.Width/image.Width,
                (float)destSize.Height/ image.Height );
            Image       processing  =   new Bitmap(
                Convert.ToInt32(image.Width * zoom),
                Convert.ToInt32(image.Height * zoom) );
            Graphics    g           =   Graphics.FromImage( processing );
            Rectangle   dstR        =   new Rectangle( 0, 0, processing.Width, processing.Height );
            Rectangle   srcR        =   new Rectangle( 0, 0, image.Width, image.Height );
            Point       dstP        =   new Point( 0, 0 );

            g.DrawImage( image, dstR, srcR, GraphicsUnit.Pixel );
            if (processing.Width > destSize.Width) { dstP.X = (destSize.Width - processing.Width) / 2; }
            if (processing.Height > destSize.Height) { dstP.Y = (destSize.Height - processing.Height) / 2; }

            Image       result      =   new Bitmap( destSize.Width, destSize.Height );
            Graphics    r           =   Graphics.FromImage( result );
            r.DrawImage( processing, dstP );
            return result;
        }

        // ######################################################################
        //  XXXXX    XXX     XXX    X        XXXX
        //    X     X   X   X   X   X       X    
        //    X     X   X   X   X   X        XXX 
        //    X     X   X   X   X   X           X
        //    X      XXX     XXX    XXXXX   XXXX 
        // ######################################################################
        /// <summary> Ustaw atrybut przeźroczystości dla obrazu. </summary>
        /// <param name="transparency"> Wartość przeźroczystości. </param>
        /// <returns> Atrybut obrazu. </returns>
        public static ImageAttributes SetTransparency( float transparency ) {
            ImageAttributes imageAttributes =   new ImageAttributes();
            ColorMatrix     colormatrix     =   new ColorMatrix();

            colormatrix.Matrix33    =   transparency;
            imageAttributes.SetColorMatrix( colormatrix );
            return imageAttributes;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja rysowania wycinka tapety systemu na formie w jej pozycji. </summary>
        /// <param name="wallpaper"> Obraz tapety systemowej. </param>
        /// <param name="objPos"> Pozycja fomry na ekranie i jej rozmiary. </param>
        /// <returns></returns>
        public static Image DrawWallpaper( Image wallpaper, Rectangle objPos ) {
            Point       point       =   new Point( objPos.X, objPos.Y );
            Size        size        =   new Size( objPos.Width, objPos.Height );
            Image       processing  =   ImageTools.CutImage( wallpaper, objPos );

            return  processing;
        }

        // ----------------------------------------------------------------------
        /// <summary> Konwersja koloru z forym ABGR na ARGB (na potrzeby koloru pobranego z rejestru systemu. </summary>
        /// <param name="color"> Kolor w systemie ABGR </param>
        /// <returns> Kolor w systemie ARGB </returns>
        public static Color ConvertFromABGR( Color color ) {
            return Color.FromArgb( color.A, color.B, color.G, color.R );
        }

        // ######################################################################
    }

    // ################################################################################
}
