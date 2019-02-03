using AnthraX.DataStructures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Un4seen.Bass;

namespace AnthraX {

    // ################################################################################
    //  xxxxx   x   x   x   x   x   x   xxxxx   xxxx     xxx    xxxxx    xxx    xxxx     xxxx
    //  x       xx  x   x   x   xx xx   x       x   x   x   x     x     x   x   x   x   x    
    //  xxxx    x x x   x   x   x x x   xxxx    xxxx    xxxxx     x     x   x   xxxx     xxx 
    //  x       x  xx   x   x   x   x   x       x   x   x   x     x     x   x   x   x       x
    //  xxxxx   x   x    xxx    x   x   xxxxx   x   x   x   x     x      xxx    x   x   xxxx 
    // ################################################################################
    /// <summary> Typ określający rodzaj wizualizacji graficznej. </summary>
    public enum SpectrumType {
        None                    =   0,
        LineNormal              =   1,
        PeakNormal              =   2,
        LineReverse             =   3,
        PeakReverse             =   4,
        LineCenter              =   5,
        PeakCenter              =   6,
        LineFloaters            =   7,
        PeakFloaters            =   8,
        LineCircle              =   9
        //LineReverseCircle       =   10
    }

    // --------------------------------------------------------------------------------
    /// <summary> Typ określający rodzaj koloru wizualizacji graficznej. </summary>
    public enum SpectrumFillType {
        Color               =   0,
        CustomColor         =   1,
        RainbowHorizontal   =   2,
        RainbowVertical     =   3
    }

    // --------------------------------------------------------------------------------
    /// <summary> Typ określąsjacy rodzaj wypełnienia kolorem (styl rysowania) wizualizacji graficznej. </summary>
    public enum SpectrumFillStyle {
        All     =   0,
        Border  =   1,
        Fill    =   2
    }

    // --------------------------------------------------------------------------------
    /// <summary> Typ określający rodzaj wyświetlanego logo aplikacji pod wizualizacją graficzną. </summary>
    public enum SpectrumLogo {
        None    =   0,
        Dark    =   1,
        Light   =   2,
    }

    // ################################################################################
    //   xxxx   xxxx    xxxxx    xxx    xxxxx   xxxx    x   x   x   x
    //  x       x   x   x       x   x     x     x   x   x   x   xx xx
    //   xxx    xxxx    xxxx    x         x     xxxx    x   x   x x x
    //      x   x       x       x   x     x     x   x   x   x   x   x
    //  xxxx    x       xxxxx    xxx      x     x   x    xxx    x   x
    // ################################################################################
    /// <summary> Moduł obliczający i renderujący wizualizację graficzną odtwarzanego utworu dźwiękowego. </summary>
    public class Spectrum {

        private const int           logoRadius      =   101;

        private Image               imageBackground;
        private Image               imageWorker;
        private Rectangle           size;

        // --- Spectrum Fundametnals ---
        public  SpectrumType        type            =   SpectrumType.LineNormal;
        private int[]               peaksArray      =   new int[128];
        private int[]               floatsArray     =   new int[128];
        private int                 peaksAmount     =   128;
        public  bool                debug           =   false;
        private int                 peakSpace       =   2;

        // --- Spectrum Data ---
        private int                 peakFallOff     =   4;
        private int                 floatFallOff    =   2;
        public  int                 sensitivity     =   512;
        public  SpectrumFillType    fillType        =   SpectrumFillType.Color;
        public  SpectrumFillStyle   fillStyle       =   SpectrumFillStyle.All;
        public  Color               borderColor     =   Color.Gray;
        public  Color               fillColor       =   Color.White;
        public  int                 alphaColor      =   224;
        public  float               rainbowTime     =   0.10f;
        public  int                 rainbowColor    =   2;

        // --- Spectrum Logo ---
        public  SpectrumLogo        logo            =   SpectrumLogo.Dark;
        private int                 logoR           =   64;

        // --- Spectrum Informations ---
        public  int                 infoAlpha       =   128;
        public  Color               infoBackColor   =   Color.Black;
        public  Color               infoFontColor   =   Color.White;
        public  int                 infoTimeOut     =   16;
        private bool                infoTimeActive  =   false;
        private TimeSpan            infoTimeStart;
        public  Image               infoCover       =   IconsControl._64_White_Stereo;
        private string[]            infoString      =   new string[3] { "No title", "No artist", "No album" };

        // --- Spectrum Animations ---
        public  bool                animSpecEnabled     =   true;
        private bool                animSpecShow        =   false;
        private int                 animSpecCounter     =   0;

        // --- Spectrum Karaoke ---
        private string              karaokeText         =   "";
        private bool                karaokeChange       =   false;
        private int                 karaokeAlphaMin     =   0;
        private int                 karaokeAlphaMax     =   192;

        // ######################################################################
        //  xxxxx   x   x   xxxxx   xxxxx
        //    x     xx  x     x       x  
        //    x     x x x     x       x  
        //    x     x  xx     x       x  
        //  xxxxx   x   x   xxxxx     x  
        // ######################################################################
        #region SpectrumInit
        // ----------------------------------------------------------------------
        /// <summary> Funkcja inicjująca moduł wizualizacji graficznej utworów dźwiękowych. </summary>
        /// <param name="size"> Rozmiar obszaru na jakim wizualizacja ma być rysowana. </param>
        public Spectrum( Rectangle size ) {
            this.size               =   size;
            this.imageBackground    =   new Bitmap( size.Width, size.Height );
            this.imageWorker        =   new Bitmap( size.Width, size.Height );
            this.peaksArray         =   new int[ peaksAmount ];
            this.floatsArray        =   new int[ peaksAmount ];
            RainbowColor.resetColor();
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja renderująca tło obszaru wizualizacji graficznej. </summary>
        /// <param name="clientSize"> Rozmiar obszaru na jakim wizualizacja ma być rysowana. </param>
        /// <param name="background"> Obraz który ma być rysowany w tle. </param>
        public void RenderBackground( Rectangle clientSize, Image background ) {
            this.size           =   clientSize;
            imageBackground     =   ImageTools.CutImage( background, size );
            imageWorker         =   new Bitmap( imageBackground );
            logoR               =   CalculateLogoRadius();
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja aktualizująca zakres spektrum rysowanej wizualizacji graficznej. </summary>
        /// <param name="newSize"> Zakres spektrum dźwiękowego. </param>
        public void UpdateSpectrumSize( int newSize ) {
            this.peaksAmount    =   newSize;
            this.peaksArray     =   new int[ peaksAmount ];
            this.floatsArray    =   new int[ peaksAmount ];
        }

        #endregion SpectrumInit
        // ######################################################################
        //  xxxxx   x   x   xxxxx    xxx 
        //    x     xx  x   x       x   x
        //    x     x x x   xxxx    x   x
        //    x     x  xx   x       x   x
        //  xxxxx   x   x   x        xxx 
        // ######################################################################
        #region SpectrumInfo
        // ----------------------------------------------------------------------
        /// <summary> Funkcja wyświetlająca informacje o aktualnie odtwarzanym utworze nad wizualizacją graficzną. </summary>
        /// <param name="cover"> Okładka odtwarzanego utworu dźwiękowego. </param>
        /// <param name="data"> Tablica zawierająca informacje o odtwarzanym utwrze dźwiękowym. </param>
        public void InfoStartShow( Image cover, string[] data ) {
            infoCover       =   cover;
            infoString      =   data;

            if ( infoTimeOut <= 0 ) { return; }
            infoTimeActive  =   true;
            DateTime    dt  =   DateTime.Now;
            infoTimeStart   =   new TimeSpan( dt.Hour, dt.Minute, dt.Second );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja odliczająca czas wyświetlania się informacji o aktualnie granym utworze. </summary>
        private void InfoWorkShow() {
            DateTime    dt  =   DateTime.Now;
            TimeSpan    tn  =   new TimeSpan( dt.Hour, dt.Minute, dt.Second ) - infoTimeStart;
            if ( tn.TotalSeconds > infoTimeOut ) {
                InfoStopShow();
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wyłączająca wyświetlanie się informacji o aktualnie granym utworze. </summary>
        private void InfoStopShow() {
            infoTimeActive  =   false;
        }

        #endregion SpectrumInfo
        // ######################################################################
        //  xxxx    xxxx     xxx    x   x   xxxxx   xxxx 
        //   x  x   x   x   x   x   x   x   x       x   x
        //   x  x   xxxx    xxxxx   x x x   xxxx    xxxx 
        //   x  x   x   x   x   x   xx xx   x       x   x
        //  xxxx    x   x   x   x   x   x   xxxxx   x   x
        // ######################################################################
        #region SpectrumDrawer
        // ----------------------------------------------------------------------
        /// <summary> Funkcja kopiująca obraz tła do tła klatki wizualizacji graficznej. </summary>
        public void DrawBackground() {
            imageWorker         =   new Bitmap( imageBackground );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja rysująca logo aplikacji w tle klatki wizualizacji graficznej. </summary>
        public void DrawLogo() {
            Image   logoImage           =   null;
            var     destSize            =   new Rectangle( 0, 0, size.Width, size.Height );
            var     graphics            =   Graphics.FromImage( imageWorker );
            int     transparency        =   224;
            var     imageAttributes     =   ImageTools.SetTransparency( (transparency * 1.0f) / 255 );

            switch ( logo ) {
                case SpectrumLogo.None:
                    return;
                
                case SpectrumLogo.Dark:
                    //if ((int)type >= (int)SpectrumType.LineCircle) {
                    //    logoImage   =   Logos.AnthraX_dark_theme_624;
                    //    break;
                    //}
                    logoImage   =   Logos.AnthraX_dark_full_theme_624;
                    break;

                case SpectrumLogo.Light:
                    //if ((int)type >= (int)SpectrumType.LineCircle) {
                    //    logoImage   =   Logos.AnthraX_light_theme_624;
                    //    break;
                    //}
                    logoImage   =   Logos.AnthraX_light_full_theme_624;
                    break;

            }

            if ( logoImage != null ) {
                if ( logoImage.Width > size.Width || logoImage.Height > size.Height ) {
                    graphics.DrawImage(
                        ImageTools.DrawAdjustedMinImage( logoImage, size ),
                        destSize, 0, 0, size.Width, size.Height, GraphicsUnit.Pixel, imageAttributes );
                } else {
                    graphics.DrawImage(
                        ImageTools.DrawCenterImage( logoImage, size ),
                        destSize, 0, 0, size.Width, size.Height, GraphicsUnit.Pixel, imageAttributes );
                }
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja rysująca informacje o aktualnie granym utworze w klatce wizualizacji graficznej. </summary>
        /// <param name="time"></param>
        public void DrawInformations( string time ) {
            if ( infoTimeActive ) {
                if ( infoTimeOut <= 0 ) { return; }
                if ( infoTimeOut < 16 ) {
                    InfoWorkShow();
                }

                int         infoHeight  =   104;
                Image       info        =   new Bitmap( size.Width, infoHeight );
                Graphics    graphInfo   =   Graphics.FromImage( info );
                Graphics    graphWork   =   Graphics.FromImage( imageWorker );
                Brush       brushFill   =   new SolidBrush( Color.FromArgb( infoAlpha, infoBackColor ) );
                Brush       brushFont   =   new SolidBrush( infoFontColor );
                Rectangle   rectFill    =   new Rectangle( 0, 0, size.Width, infoHeight );
                Rectangle   rectCover   =   new Rectangle( 0, 0, 72, 72 );
                Font        fontTitle   =   new Font( "Calibri", 18, FontStyle.Bold );
                Font        fontMeta    =   new Font( "Calibri", 12, FontStyle.Bold );
                Font        fontTime    =   new Font( "Consolas", 12, FontStyle.Regular );
                SizeF       sizeTitle   =   graphInfo.MeasureString( infoString[0], fontTitle );
                SizeF       sizeMeta    =   graphInfo.MeasureString( infoString[1], fontMeta );
                SizeF       sizeTime    =   graphInfo.MeasureString( time, fontTime );
                
                graphInfo.FillRectangle( brushFill, rectFill );
                graphInfo.DrawImage( ImageTools.DrawResizedImage( infoCover, rectCover ), 16, 16 );
                
                graphWork.DrawImage( info, 0, 0 );
                graphWork.DrawString( infoString[0], fontTitle, brushFont, 104, 10 );
                graphWork.DrawString( infoString[1], fontMeta, brushFont, 104, 12 + sizeTitle.Height );
                graphWork.DrawString( infoString[2], fontMeta, brushFont, 104, infoHeight - sizeMeta.Height - 10 );
                graphWork.DrawString( time, fontTime, brushFont, size.Width - sizeTime.Width - 10, infoHeight - sizeTime.Height - 10 );
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja rysująca tekst karaoke aktualnie granego utworu w klatce wizualizacji graficznej. </summary>
        /// <param name="text"> Tekst karaoke. </param>
        public void DrawLyrics( string text ) {
            if ( text != null ) {
                if ( karaokeText != text ) {
                    karaokeText = text;
                    karaokeChange = true;
                } else { karaokeChange = false; }
                Console.WriteLine( text );
            }
            
            if ( karaokeText == "" ) { return; }

            int         karaokeHeight   =   128;
            int         draw_point      =   size.Height / 2 - karaokeHeight / 2;
            Image       karaoke         =   new Bitmap( size.Width, karaokeHeight );
            Graphics    graphKaraoke    =   Graphics.FromImage( karaoke );
            Graphics    graphWork       =   Graphics.FromImage( imageWorker );

            Brush       brushFont       =   new SolidBrush( infoFontColor );
            Rectangle   rectFillL       =   new Rectangle( 0, 0, size.Width/2, karaokeHeight );
            Rectangle   rectFillR       =   new Rectangle( size.Width/2, 0, size.Width, karaokeHeight );
            Font        fontText        =   new Font( "Calibri", 28, FontStyle.Bold );
            SizeF       sizeText        =   graphKaraoke.MeasureString( karaokeText, fontText );

            Brush       brushLeft       =   new LinearGradientBrush(
                rectFillL, Color.FromArgb( karaokeAlphaMin, infoBackColor ), Color.FromArgb( karaokeAlphaMax, infoBackColor ), 0f );
            Brush       brushRight      =   new LinearGradientBrush(
                rectFillL, Color.FromArgb( karaokeAlphaMax, infoBackColor ), Color.FromArgb( karaokeAlphaMin, infoBackColor ), 0f );

            graphKaraoke.FillRectangle( brushLeft, rectFillL );
            graphKaraoke.FillRectangle( brushRight, rectFillR );

            graphWork.DrawImage( karaoke, 0, draw_point );
            graphWork.DrawString( karaokeText, fontText, brushFont,
                (size.Width/2 - sizeText.Width/2), (size.Height/2 - sizeText.Height/2) );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wybierająca algorytm rysujący klatkę wizualizacji graficznej. </summary>
        /// <param name="FFTData"> Tablica FFT zawierająca poziomy natężenia dźwięku
        /// na określonych częstotliwoścach dźwięku. </param>
        /// <param name="length"> Długość tablicy FFT </param>
        public void DrawSpectrum( float[] FFTData, int length ) {
            peakFallOff     =   size.Width / 100;
            floatFallOff    =   size.Width / 250;

            switch ( type ) {
                case SpectrumType.None:
                    break;

                case SpectrumType.LineNormal:
                    DrawSpectrumLine( FFTData, length );
                    break;

                case SpectrumType.PeakNormal:
                    DrawSpectrumPeak( FFTData, length );
                    break;

                case SpectrumType.LineReverse:
                    DrawSpectrumReverseLine( FFTData, length );
                    break;

                case SpectrumType.PeakReverse:
                    DrawSpectrumReversePeak( FFTData, length );
                    break;
                
                case SpectrumType.LineCenter:
                    DrawSpectrumCenterLine( FFTData, length );
                    break;

                case SpectrumType.PeakCenter:
                    DrawSpectrumCenterPeak( FFTData, length );
                    break;

                case SpectrumType.LineFloaters:
                    DrawSpectrumFloatLine( FFTData, length );
                    break;

                case SpectrumType.PeakFloaters:
                    DrawSpectrumFloatPeak( FFTData, length );
                    break;

                case SpectrumType.LineCircle:
                    DrawSpectrumCircle( FFTData, length );
                    break;

            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja nie generująca klatek wizualizacji graficznych. </summary>
        public void DrawNoSpectrum() {
            DrawSpectrum( null, 0 );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja pobierania klatki wizualizacji graficznej. </summary>
        /// <returns> Obraz zawierający wizualizację graficzną. </returns>
        public Image GetDrawnSpectrum() { return imageWorker; }

        #endregion SpectrumDrawer
        // ######################################################################
        //  xxxxx    xxx     xxx    x        xxxx
        //    x     x   x   x   x   x       x    
        //    x     x   x   x   x   x        xxx 
        //    x     x   x   x   x   x           x
        //    x      xxx     xxx    xxxxx   xxxx 
        // ######################################################################
        #region SpectrumTools
        // ----------------------------------------------------------------------
        /// <summary> Odczytywanie częśtotliwości z podanego indeksu FFT
        /// i zastosowanie go do normalizacji natężenia dźwięku dla wizualizacji graficznej. </summary>
        /// <param name="index"> Indeks częstotliwości. </param>
        /// <param name="FFTData"> Tablica FFT zawierająca poziomy natężenia dźwięku
        /// na określonych częstotliwoścach dźwięku. </param>
        /// <param name="length"> Długość tablicy FFT </param>
        /// <returns> Wartość dla wizualizacji graficznej, po normalizacji natężenia dźwięku w określonej częstotliwości. </returns>
        private float CalculatePeakFrequency( int index, float[] FTTData, int length ) {
            if ( FTTData == null ) { return 0; }
            if ( index >= FTTData.Length ) { return 0; }
            float   frequency   =   Utils.FFTIndex2Frequency( index, length, 44100 );

            return  FTTData[ index ] * frequency;
        }

        // ----------------------------------------------------------------------
        /// <summary> Obliczenie wrażliwości wizualizacji graficznej na natężenie dźwięku. </summary>
        /// <param name="index"> Indeks częstotliwości. </param>
        /// <param name="FFTData"> Tablica FFT zawierająca poziomy natężenia dźwięku
        /// na określonych częstotliwoścach dźwięku. </param>
        /// <param name="length"> Długość tablicy FFT </param>
        /// <returns> Wartość dla wizualizacji graficznej, po normalizacji natężenia dźwięku w określonej częstotliwości. </returns>
        private float CalculatePeakSensitivity( int index, float[] FTTData, int length ) {
            if ( FTTData == null ) { return 0; }
            if ( index >= FTTData.Length ) { return 0; }

            return  FTTData[ index ] * sensitivity;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja sprawdzająca czy w efekcie opadających belek, wszystkie już opadły. </summary>
        /// <returns> Logiczna wartość informująca o tym że belki znajdują się poza ekranem. </returns>
        private bool IsFloatersOut() {
            foreach( int floater in floatsArray ) {
                if ( floater < this.size.Height ) { return false; }
            }
            return true;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja przywracająca efekt opadania belek do wizualizacji graficznej. </summary>
        /// <param name="FFTData"> Tablica FFT zawierająca poziomy natężenia dźwięku
        /// na określonych częstotliwoścach dźwięku. </param>
        /// <param name="length"> Długość tablicy FFT </param>
        /// <param name="maxHeight"> Maksymalna wysokość w której mogą się pojawić opadające belki. </param>
        private void RestoreFloaters( float[] FFTData, int length, int maxHeight ) {
            for ( int iX = 0; iX < this.peaksAmount; iX++ ) {
                int peakData = (int) CalculatePeakSensitivity( iX, FFTData, length );
                if ( peakData > maxHeight ) { peakData = maxHeight; }
                floatsArray[iX] = peakData;
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja obliczająca średnicę grafiki logo. </summary>
        /// <returns> Średnica grafiki logo. </returns>
        private int CalculateLogoRadius() {
            Image   image       =   Logos.AnthraX_dark_theme_624;
            int     result      =   64;
            if ( image.Width > size.Width || image.Height > size.Height ) {
                // --- Adjust Minimal ---
                float       zoom        =   Math.Min(
                    (float) size.Width  / image.Width,
                    (float) size.Height / image.Height
                );
                result  =   (int) (logoRadius * zoom);
            } else {
                // --- Center Image ---
                result  =   logoRadius;
            }
            return result;
        }

        #endregion SpectrumTools
        // ######################################################################
        //   xxx    x   x   xxxxx   x   x    xxx    xxxxx   xxxxx    xxx    x   x    xxxx
        //  x   x   xx  x     x     xx xx   x   x     x       x     x   x   xx  x   x    
        //  xxxxx   x x x     x     x x x   xxxxx     x       x     x   x   x x x    xxx 
        //  x   x   x  xx     x     x   x   x   x     x       x     x   x   x  xx       x
        //  x   x   x   x   xxxxx   x   x   x   x     x     xxxxx    xxx    x   x   xxxx
        // ######################################################################
        #region Animations
        // ----------------------------------------------------------------------
        /// <summary> Funkcja uruchamiająca animację wyświetlania się wizualizacji graficznej,
        /// element po elemencie. </summary>
        /// <param name="spectrumType"> Typ wyświetlanej wizualizacji. </param>
        public void AnimSpecShowInit( SpectrumType spectrumType ) {
            this.type   =   spectrumType;
            if ( this.type == SpectrumType.None ) {
                AnimSpecShowFinish();
                return;
            }
            animSpecShow        =   true;
            animSpecCounter     =   0;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja aktualizująca wartości dla następnych klatek animacji wizualizacji graficznej. </summary>
        /// <param name="i"> Kolejny krok animacji. </param>
        /// <param name="amount"> Maskymalny krok który ma zostać wykonany. </param>
        /// <returns></returns>
        public bool AnimSpecShowWork( int i, int amount ) {
            if ( animSpecShow ) {
                if ( i > animSpecCounter ) {
                    if ( i >= amount ) {
                        AnimSpecShowFinish();
                        return false;
                    }
                    animSpecCounter++;
                    return true;
                }
            }
            return false;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja kończąca generowanie animacji. </summary>
        public void AnimSpecShowFinish() {
            animSpecShow        =   false;
            animSpecCounter     =   0;
        }

        #endregion Animations
        // ######################################################################
        //   xxxx   xxxx    xxxxx    xxx    xxxxx   xxxx    x   x   x   x    xxxx
        //  x       x   x   x       x   x     x     x   x   x   x   xx xx   x    
        //   xxx    xxxx    xxxx    x         x     xxxx    x   x   x x x    xxx 
        //      x   x       x       x   x     x     x   x   x   x   x   x       x
        //  xxxx    x       xxxxx    xxx      x     x   x    xxx    x   x   xxxx 
        // ######################################################################
        #region Spectrums
        // ----------------------------------------------------------------------
        //  DRAW SPECTRUM LINES
        // ----------------------------------------------------------------------
        /// <summary> Funkcja generująca wizualizację graficzną na danych FFT,
        /// wyświetlająca skaczące linie, reprezentujące natężenie dźwięku na określonych częstotliwościach. </summary>
        /// <param name="FFTData"> Tablica FFT zawierająca poziomy natężenia dźwięku
        /// na określonych częstotliwoścach dźwięku. </param>
        /// <param name="length"> Długość tablicy FFT </param>
        public void DrawSpectrumLine( float[] FFTData, int length ) {

            // -----------------------------------------------------
            // --- Konfiguracja renderowanej klatki wizualizacji ---
            // -----------------------------------------------------
            Graphics    graphics    =   Graphics.FromImage( imageWorker );
            int         maxWidth    =   this.size.Width;
            int         peakWidth   =   (maxWidth/this.peaksAmount) - (this.peakSpace*1);
            int         peakHeight  =   (int) Math.Ceiling( peakWidth / 2f );
            int         maxHeight   =   this.size.Height - this.peakSpace*2 - peakHeight*2;
            int         startX      =   (maxWidth - (peakWidth + (this.peakSpace * 1)) * this.peaksAmount) / 2;

            // -------------------------------------------------
            // --- Konfiguracja wstępna kolorów wizualizacji ---
            // -------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeBackup();
            }

            for ( int iX = 0; iX < this.peaksAmount; iX++ ) {

                // -------------------------------------------------
                // --- Sprawdzenie poprawności aktualnych danych ---
                // -------------------------------------------------
                if ( peaksArray == null || floatsArray == null ) { break; }
                if ( iX >= peaksArray.Length || iX > floatsArray.Length ) { break; }

                // ----------------------------------------------------------------
                // --- Ustawienie wartości maksymalnej i przypisanie do tablicy ---
                // ----------------------------------------------------------------
                int     peakData    =   (int) CalculatePeakSensitivity( iX, FFTData, length );
                if ( peakData > maxHeight ) { peakData = maxHeight; }

                if ( peaksArray[iX] < peakData && peakData > 0 ) {
                    peaksArray[iX] = peakData;
                } else {
                    peaksArray[iX] -= peakFallOff;
                    if ( peaksArray[iX] < 0 ) { peaksArray[iX] = 0; }
                }

                if ( floatsArray[iX] < peakData && peakData > 0 ) {
                    floatsArray[iX] = peakData;
                } else {
                    floatsArray[iX] -= floatFallOff;
                    if ( floatsArray[iX] < 0 ) { floatsArray[iX] = 0; }
                }

                // ---------------------------------------------------------
                // --- Pobieranie kolorów wizualizacji i dokonanie zmian ---
                // ---------------------------------------------------------
                if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                    fillColor       =   RainbowColor.getColor();
                    borderColor     =   RainbowColor.getColor();
                    RainbowColor.nextColor( rainbowColor );
                }

                // -----------------------------------------------------
                // --- Przygotowanie konfiguracji rysowania spektrum ---
                // -----------------------------------------------------
                int         peak        =   peaksArray[iX];
                int         floater     =   floatsArray[iX];
                Brush       brush       =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                Pen         pen         =   new Pen( Color.FromArgb( alphaColor, borderColor ), 1 );
                
                Rectangle   peakRect    =   new Rectangle(
                    startX + iX*peakSpace + iX*peakWidth,
                    this.size.Height - peak,
                    peakWidth,
                    peak
                );
                
                Rectangle   fallowRect  =   new Rectangle(
                    startX + iX * peakSpace + iX * peakWidth,
                    this.size.Height - floater - this.peakSpace - peakHeight,
                    peakWidth,
                    peakHeight
                );

                // -------------------------------------------------------------
                // --- Praca Animacji Show Hide ---
                // -------------------------------------------------------------
                if ( AnimSpecShowWork( iX, this.peaksAmount ) ) { break; }

                // -------------------------------------------------------------
                // --- Rysowanie spektrum graficznego na obszarze wyjściowym ---
                // -------------------------------------------------------------
                if ( peak > 0 ) {
                    switch ( fillStyle ) {
                        case SpectrumFillStyle.All:
                            graphics.FillRectangle( brush, peakRect );
                            graphics.DrawRectangle( pen, peakRect );
                            break;

                        case SpectrumFillStyle.Border:
                            graphics.DrawRectangle( pen, peakRect );
                            break;

                        case SpectrumFillStyle.Fill:
                            graphics.FillRectangle( brush, peakRect );
                            break;
                    }
                }

                if ( floater > 0 ) {
                    switch ( fillStyle ) {
                        case SpectrumFillStyle.All:
                            graphics.FillRectangle( brush, fallowRect );
                            graphics.DrawRectangle( pen, fallowRect );
                            break;

                        case SpectrumFillStyle.Border:
                            graphics.DrawRectangle( pen, fallowRect );
                            break;

                        case SpectrumFillStyle.Fill:
                            graphics.FillRectangle( brush, fallowRect );
                            break;
                    }
                }

                // ------------------------------------------------------------
                // --- Debugowanie wartości spektrum na obszarze wyjściowym ---
                // ------------------------------------------------------------
                if ( debug ) {
                    graphics.DrawString( peakData.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 5, iX*12 );
                    graphics.DrawString( "Size -> " + size.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 24, 0 );
                }
            }

            // -------------------------------------------------------------------
            // --- Konfiguracja końcowa kolorów wizualizacji i dokonanie zmian ---
            // -------------------------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeRecover();
                RainbowColor.nextColor( rainbowColor, rainbowTime );
            }
        }

        // ----------------------------------------------------------------------
        //  DRAW SPECTRUM PEAKS
        // ----------------------------------------------------------------------
        /// <summary> Funkcja generująca wizualizację graficzną na danych FFT,
        /// wyświetlająca skaczące linie belek, reprezentujące natężenie dźwięku na określonych częstotliwościach. </summary>
        /// <param name="FFTData"> Tablica FFT zawierająca poziomy natężenia dźwięku
        /// na określonych częstotliwoścach dźwięku. </param>
        /// <param name="length"> Długość tablicy FFT </param>
        public void DrawSpectrumPeak( float[] FFTData, int length ) {

            // -----------------------------------------------------
            // --- Konfiguracja renderowanej klatki wizualizacji ---
            // -----------------------------------------------------
            Graphics    graphics    =   Graphics.FromImage( imageWorker );
            int         maxWidth    =   this.size.Width;
            int         peakWidth   =   (maxWidth/this.peaksAmount) - (this.peakSpace*1);
            int         peakHeight  =   (int) Math.Ceiling( peakWidth / 2f );
            int         maxHeight   =   this.size.Height - this.peakSpace*2 - peakHeight*2;
            int         startX      =   (maxWidth - (peakWidth + (this.peakSpace * 1)) * this.peaksAmount) / 2;

            // -------------------------------------------------
            // --- Konfiguracja wstępna kolorów wizualizacji ---
            // -------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeBackup();
            }

            for ( int iX = 0; iX < this.peaksAmount; iX++ ) {

                // -------------------------------------------------
                // --- Sprawdzenie poprawności aktualnych danych ---
                // -------------------------------------------------
                if ( peaksArray == null || floatsArray == null ) { break; }
                if ( iX >= peaksArray.Length || iX > floatsArray.Length ) { break; }

                // ----------------------------------------------------------------
                // --- Ustawienie wartości maksymalnej i przypisanie do tablicy ---
                // ----------------------------------------------------------------
                int     peakData    =   (int) CalculatePeakSensitivity( iX, FFTData, length );
                if ( peakData > maxHeight ) { peakData = maxHeight; }

                if ( peaksArray[iX] < peakData && peakData > 0 ) {
                    peaksArray[iX] = peakData;
                } else {
                    peaksArray[iX] -= peakFallOff;
                    if ( peaksArray[iX] < 0 ) { peaksArray[iX] = 0; }
                }

                if ( floatsArray[iX] < peakData && peakData > 0 ) {
                    floatsArray[iX] = peakData;
                } else {
                    floatsArray[iX] -= floatFallOff;
                    if ( floatsArray[iX] < 0 ) { floatsArray[iX] = 0; }
                }
                
                // -----------------------------------------------------------
                // --- Pobieranie kolorów wizualizacji i dokonanie zmian 1 ---
                // -----------------------------------------------------------
                switch ( fillType ) {
                    case SpectrumFillType.RainbowHorizontal:
                        fillColor       =   RainbowColor.getColor();
                        borderColor     =   RainbowColor.getColor();
                        RainbowColor.nextColor( rainbowColor );
                        break;
                    case SpectrumFillType.RainbowVertical:
                        RainbowColor.makeRecover();
                        break;
                }

                // -----------------------------------------------------
                // --- Przygotowanie konfiguracji rysowania spektrum ---
                // -----------------------------------------------------
                int         peak        =   peaksArray[iX];
                int         floater     =   floatsArray[iX];
                Brush       brush       =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                Pen         pen         =   new Pen( Color.FromArgb( alphaColor, borderColor ), 1 );

                Rectangle   fallowRect  =   new Rectangle(
                    startX + iX * peakSpace + iX * peakWidth,
                    this.size.Height - floater - this.peakSpace - peakHeight,
                    peakWidth,
                    peakHeight
                );

                // -------------------------------------------------------------
                // --- Praca Animacji Show Hide ---
                // -------------------------------------------------------------
                if ( AnimSpecShowWork( iX, this.peaksAmount ) ) { break; }

                for ( int iY = this.size.Height - peakHeight; iY > this.size.Height - peak; iY -= (peakHeight + this.peakSpace) ) {

                    // --------------------------------------------------
                    // --- Generowanie bloku wizualizacji elementowej ---
                    // --------------------------------------------------
                    Rectangle peakRect    =   new Rectangle(
                        startX + iX*peakSpace + iX*peakWidth,
                        iY,
                        peakWidth,
                        peakHeight
                    );

                    // -----------------------------------------------------------
                    // --- Pobieranie kolorów wizualizacji i dokonanie zmian 2 ---
                    // -----------------------------------------------------------
                    switch ( fillType ) {
                        case SpectrumFillType.RainbowHorizontal:
                            //
                            break;
                        case SpectrumFillType.RainbowVertical:
                            fillColor       =   RainbowColor.getColor();
                            borderColor     =   RainbowColor.getColor();
                            brush           =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                            pen             =   new Pen( Color.FromArgb( alphaColor, borderColor ), 1 );
                            RainbowColor.nextColor( rainbowColor );
                            break;
                    }

                    // -------------------------------------------------------------
                    // --- Rysowanie spektrum graficznego na obszarze wyjściowym ---
                    // -------------------------------------------------------------
                    if ( peak > 0 ) {
                        switch ( fillStyle ) {
                            case SpectrumFillStyle.All:
                                graphics.FillRectangle( brush, peakRect );
                                graphics.DrawRectangle( pen, peakRect );
                                break;

                            case SpectrumFillStyle.Border:
                                graphics.DrawRectangle( pen, peakRect );
                                break;

                            case SpectrumFillStyle.Fill:
                                graphics.FillRectangle( brush, peakRect );
                                break;
                        }
                    }
                }

                // ----------------------------------------------------------------------
                // --- Rysowanie floatera spektrum graficznego na obszarze wyjściowym ---
                // ----------------------------------------------------------------------
                if ( floater > 0 ) {
                    switch ( fillStyle ) {
                        case SpectrumFillStyle.All:
                            graphics.FillRectangle( brush, fallowRect );
                            graphics.DrawRectangle( pen, fallowRect );
                            break;

                        case SpectrumFillStyle.Border:
                            graphics.DrawRectangle( pen, fallowRect );
                            break;

                        case SpectrumFillStyle.Fill:
                            graphics.FillRectangle( brush, fallowRect );
                            break;
                    }
                }

                // ------------------------------------------------------------
                // --- Debugowanie wartości spektrum na obszarze wyjściowym ---
                // ------------------------------------------------------------
                if ( debug ) {
                    graphics.DrawString( peakData.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 5, iX*12 );
                    graphics.DrawString( "Size -> " + size.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 24, 0 );
                }
            }

            // -------------------------------------------------------------------
            // --- Konfiguracja końcowa kolorów wizualizacji i dokonanie zmian ---
            // -------------------------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeRecover();
                RainbowColor.nextColor( rainbowColor, rainbowTime );
            }
        }

        // ----------------------------------------------------------------------
        //  DRAW SPECTRUM REVERSE LINES
        // ----------------------------------------------------------------------
        /// <summary> Funkcja generująca wizualizację graficzną na danych FFT,
        /// wyświetlająca skaczące odwrócone linie z opadającymi belkami, reprezentujące natężenie dźwięku na określonych częstotliwościach. </summary>
        /// <param name="FFTData"> Tablica FFT zawierająca poziomy natężenia dźwięku
        /// na określonych częstotliwoścach dźwięku. </param>
        /// <param name="length"> Długość tablicy FFT </param>
        public void DrawSpectrumReverseLine( float[] FFTData, int length ) {

            // -----------------------------------------------------
            // --- Konfiguracja renderowanej klatki wizualizacji ---
            // -----------------------------------------------------
            Graphics    graphics    =   Graphics.FromImage( imageWorker );
            int         maxWidth    =   this.size.Width;
            int         peakWidth   =   (maxWidth/this.peaksAmount) - (this.peakSpace*1);
            int         peakHeight  =   (int) Math.Ceiling( peakWidth / 2f );
            int         maxHeight   =   this.size.Height - this.peakSpace*2 - peakHeight*2;
            int         startX      =   (maxWidth - (peakWidth + (this.peakSpace * 1)) * this.peaksAmount) / 2;

            // -------------------------------------------------
            // --- Konfiguracja wstępna kolorów wizualizacji ---
            // -------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeBackup();
            }

            for ( int iX = 0; iX < this.peaksAmount; iX++ ) {

                // -------------------------------------------------
                // --- Sprawdzenie poprawności aktualnych danych ---
                // -------------------------------------------------
                if ( peaksArray == null || floatsArray == null ) { break; }
                if ( iX >= peaksArray.Length || iX > floatsArray.Length ) { break; }

                // ----------------------------------------------------------------
                // --- Ustawienie wartości maksymalnej i przypisanie do tablicy ---
                // ----------------------------------------------------------------
                int     peakData    =   (int) CalculatePeakSensitivity( iX, FFTData, length );
                if ( peakData > maxHeight ) { peakData = maxHeight; }

                if ( peaksArray[iX] < peakData && peakData > 0 ) {
                    peaksArray[iX] = peakData;
                } else {
                    peaksArray[iX] -= peakFallOff;
                    if ( peaksArray[iX] < 0 ) { peaksArray[iX] = 0; }
                }

                if ( floatsArray[iX] < peakData && peakData > 0 ) {
                    floatsArray[iX] = peakData;
                } else if ( floatsArray[iX] <= this.size.Height ) {
                    floatsArray[iX] += floatFallOff;
                }

                if ( IsFloatersOut() ) { RestoreFloaters( FFTData, length, maxHeight ); }

                // ---------------------------------------------------------
                // --- Pobieranie kolorów wizualizacji i dokonanie zmian ---
                // ---------------------------------------------------------
                if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                    fillColor       =   RainbowColor.getColor();
                    borderColor     =   RainbowColor.getColor();
                    RainbowColor.nextColor( rainbowColor );
                }

                // -----------------------------------------------------
                // --- Przygotowanie konfiguracji rysowania spektrum ---
                // -----------------------------------------------------
                int         peak        =   peaksArray[iX];
                int         floater     =   floatsArray[iX];
                Brush       brush       =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                Pen         pen         =   new Pen( Color.FromArgb( alphaColor, borderColor ), 1 );
                
                Rectangle   peakRect    =   new Rectangle(
                    startX + iX*peakSpace + iX*peakWidth,
                    0,
                    peakWidth,
                    peak
                );
                
                Rectangle   fallowRect  =   new Rectangle(
                    startX + iX * peakSpace + iX * peakWidth,
                    floater + this.peakSpace,
                    peakWidth,
                    peakHeight
                );

                // -------------------------------------------------------------
                // --- Praca Animacji Show Hide ---
                // -------------------------------------------------------------
                if ( AnimSpecShowWork( iX, this.peaksAmount ) ) { break; }

                // -------------------------------------------------------------
                // --- Rysowanie spektrum graficznego na obszarze wyjściowym ---
                // -------------------------------------------------------------
                if ( peak > 0 ) {
                    switch ( fillStyle ) {
                        case SpectrumFillStyle.All:
                            graphics.FillRectangle( brush, peakRect );
                            graphics.DrawRectangle( pen, peakRect );
                            break;

                        case SpectrumFillStyle.Border:
                            graphics.DrawRectangle( pen, peakRect );
                            break;

                        case SpectrumFillStyle.Fill:
                            graphics.FillRectangle( brush, peakRect );
                            break;
                    }
                }

                if ( floater > 0 ) {
                    switch ( fillStyle ) {
                        case SpectrumFillStyle.All:
                            graphics.FillRectangle( brush, fallowRect );
                            graphics.DrawRectangle( pen, fallowRect );
                            break;

                        case SpectrumFillStyle.Border:
                            graphics.DrawRectangle( pen, fallowRect );
                            break;

                        case SpectrumFillStyle.Fill:
                            graphics.FillRectangle( brush, fallowRect );
                            break;
                    }
                }

                // ------------------------------------------------------------
                // --- Debugowanie wartości spektrum na obszarze wyjściowym ---
                // ------------------------------------------------------------
                if ( debug ) {
                    graphics.DrawString( peakData.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 5, iX*12 );
                    graphics.DrawString( "Size -> " + size.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 24, 0 );
                }
            }

            // -------------------------------------------------------------------
            // --- Konfiguracja końcowa kolorów wizualizacji i dokonanie zmian ---
            // -------------------------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeRecover();
                RainbowColor.nextColor( rainbowColor, rainbowTime );
            }
        }

        // ----------------------------------------------------------------------
        //  DRAW SPECTRUM REVERSE PEAKS
        // ----------------------------------------------------------------------
        /// <summary> Funkcja generująca wizualizację graficzną na danych FFT,
        /// wyświetlająca skaczące odwrócone linie belek z opadającymi belkami, reprezentujące natężenie dźwięku na określonych częstotliwościach. </summary>
        /// <param name="FFTData"> Tablica FFT zawierająca poziomy natężenia dźwięku
        /// na określonych częstotliwoścach dźwięku. </param>
        /// <param name="length"> Długość tablicy FFT </param>
        public void DrawSpectrumReversePeak( float[] FFTData, int length ) {

            // -----------------------------------------------------
            // --- Konfiguracja renderowanej klatki wizualizacji ---
            // -----------------------------------------------------
            Graphics    graphics    =   Graphics.FromImage( imageWorker );
            int         maxWidth    =   this.size.Width;
            int         peakWidth   =   (maxWidth/this.peaksAmount) - (this.peakSpace*1);
            int         peakHeight  =   (int) Math.Ceiling( peakWidth / 2f );
            int         maxHeight   =   this.size.Height - this.peakSpace*2 - peakHeight*2;
            int         startX      =   (maxWidth - (peakWidth + (this.peakSpace * 1)) * this.peaksAmount) / 2;

            // -------------------------------------------------
            // --- Konfiguracja wstępna kolorów wizualizacji ---
            // -------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeBackup();
            }

            for ( int iX = 0; iX < this.peaksAmount; iX++ ) {

                // -------------------------------------------------
                // --- Sprawdzenie poprawności aktualnych danych ---
                // -------------------------------------------------
                if ( peaksArray == null || floatsArray == null ) { break; }
                if ( iX >= peaksArray.Length || iX > floatsArray.Length ) { break; }

                // ----------------------------------------------------------------
                // --- Ustawienie wartości maksymalnej i przypisanie do tablicy ---
                // ----------------------------------------------------------------
                int     peakData    =   (int) CalculatePeakSensitivity( iX, FFTData, length );
                if ( peakData > maxHeight ) { peakData = maxHeight; }

                if ( peaksArray[iX] < peakData && peakData > 0 ) {
                    peaksArray[iX] = peakData;
                } else {
                    peaksArray[iX] -= peakFallOff;
                    if ( peaksArray[iX] < 0 ) { peaksArray[iX] = 0; }
                }

                if ( floatsArray[iX] < peakData && peakData > 0 ) {
                    floatsArray[iX] = peakData;
                } else if ( floatsArray[iX] <= this.size.Height ) {
                    floatsArray[iX] += floatFallOff;
                }

                if ( IsFloatersOut() ) { RestoreFloaters( FFTData, length, maxHeight ); }
                
                // -----------------------------------------------------------
                // --- Pobieranie kolorów wizualizacji i dokonanie zmian 1 ---
                // -----------------------------------------------------------
                switch ( fillType ) {
                    case SpectrumFillType.RainbowHorizontal:
                        fillColor       =   RainbowColor.getColor();
                        borderColor     =   RainbowColor.getColor();
                        RainbowColor.nextColor( rainbowColor );
                        break;
                    case SpectrumFillType.RainbowVertical:
                        RainbowColor.makeRecover();
                        break;
                }

                // -----------------------------------------------------
                // --- Przygotowanie konfiguracji rysowania spektrum ---
                // -----------------------------------------------------
                int         peak        =   peaksArray[iX];
                int         floater     =   floatsArray[iX];
                Brush       brush       =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                Pen         pen         =   new Pen( Color.FromArgb( alphaColor, borderColor ), 1 );

                Rectangle   fallowRect  =   new Rectangle(
                    startX + iX * peakSpace + iX * peakWidth,
                    floater + this.peakSpace,
                    peakWidth,
                    peakHeight
                );

                // -------------------------------------------------------------
                // --- Praca Animacji Show Hide ---
                // -------------------------------------------------------------
                if ( AnimSpecShowWork( iX, this.peaksAmount ) ) { break; }

                for ( int iY = this.size.Height - peakHeight; iY > this.size.Height - peak; iY -= (peakHeight + this.peakSpace) ) {

                    // --------------------------------------------------
                    // --- Generowanie bloku wizualizacji elementowej ---
                    // --------------------------------------------------
                    Rectangle peakRect    =   new Rectangle(
                        startX + iX*peakSpace + iX*peakWidth,
                        this.size.Height - iY,
                        peakWidth,
                        peakHeight
                    );

                    // -----------------------------------------------------------
                    // --- Pobieranie kolorów wizualizacji i dokonanie zmian 2 ---
                    // -----------------------------------------------------------
                    switch ( fillType ) {
                        case SpectrumFillType.RainbowHorizontal:
                            //
                            break;
                        case SpectrumFillType.RainbowVertical:
                            fillColor       =   RainbowColor.getColor();
                            borderColor     =   RainbowColor.getColor();
                            brush           =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                            pen             =   new Pen( Color.FromArgb( alphaColor, borderColor ), 1 );
                            RainbowColor.nextColor( rainbowColor );
                            break;
                    }

                    // -------------------------------------------------------------
                    // --- Rysowanie spektrum graficznego na obszarze wyjściowym ---
                    // -------------------------------------------------------------
                    if ( peak > 0 ) {
                        switch ( fillStyle ) {
                            case SpectrumFillStyle.All:
                                graphics.FillRectangle( brush, peakRect );
                                graphics.DrawRectangle( pen, peakRect );
                                break;

                            case SpectrumFillStyle.Border:
                                graphics.DrawRectangle( pen, peakRect );
                                break;

                            case SpectrumFillStyle.Fill:
                                graphics.FillRectangle( brush, peakRect );
                                break;
                        }
                    }
                }

                // ----------------------------------------------------------------------
                // --- Rysowanie floatera spektrum graficznego na obszarze wyjściowym ---
                // ----------------------------------------------------------------------
                if ( floater > 0 ) {
                    switch ( fillStyle ) {
                        case SpectrumFillStyle.All:
                            graphics.FillRectangle( brush, fallowRect );
                            graphics.DrawRectangle( pen, fallowRect );
                            break;

                        case SpectrumFillStyle.Border:
                            graphics.DrawRectangle( pen, fallowRect );
                            break;

                        case SpectrumFillStyle.Fill:
                            graphics.FillRectangle( brush, fallowRect );
                            break;
                    }
                }

                // ------------------------------------------------------------
                // --- Debugowanie wartości spektrum na obszarze wyjściowym ---
                // ------------------------------------------------------------
                if ( debug ) {
                    graphics.DrawString( peakData.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 5, iX*12 );
                    graphics.DrawString( "Size -> " + size.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 24, 0 );
                }
            }

            // -------------------------------------------------------------------
            // --- Konfiguracja końcowa kolorów wizualizacji i dokonanie zmian ---
            // -------------------------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeRecover();
                RainbowColor.nextColor( rainbowColor, rainbowTime );
            }
        }

        // ----------------------------------------------------------------------
        //  DRAW SPECTRUM CENTER LINES
        // ----------------------------------------------------------------------
        /// <summary> Funkcja generująca wizualizację graficzną na danych FFT,
        /// wyświetlająca skaczące linie w górę i dół, reprezentujące natężenie dźwięku na określonych częstotliwościach. </summary>
        /// <param name="FFTData"> Tablica FFT zawierająca poziomy natężenia dźwięku
        /// na określonych częstotliwoścach dźwięku. </param>
        /// <param name="length"> Długość tablicy FFT </param>
        public void DrawSpectrumCenterLine( float[] FFTData, int length ) {

            // -----------------------------------------------------
            // --- Konfiguracja renderowanej klatki wizualizacji ---
            // -----------------------------------------------------
            Graphics    graphics    =   Graphics.FromImage( imageWorker );
            int         maxWidth    =   this.size.Width;
            int         peakWidth   =   (maxWidth/this.peaksAmount) - (this.peakSpace*1);
            int         peakHeight  =   (int) Math.Ceiling( peakWidth / 2f );
            int         maxHeight   =   (this.size.Height/2) - this.peakSpace*2 - peakHeight*2;
            int         startX      =   (maxWidth - (peakWidth + (this.peakSpace * 1)) * this.peaksAmount) / 2;

            // -------------------------------------------------
            // --- Konfiguracja wstępna kolorów wizualizacji ---
            // -------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeBackup();
            }

            for ( int iX = 0; iX < this.peaksAmount; iX++ ) {

                // -------------------------------------------------
                // --- Sprawdzenie poprawności aktualnych danych ---
                // -------------------------------------------------
                if ( peaksArray == null || floatsArray == null ) { break; }
                if ( iX >= peaksArray.Length || iX > floatsArray.Length ) { break; }

                // ----------------------------------------------------------------
                // --- Ustawienie wartości maksymalnej i przypisanie do tablicy ---
                // ----------------------------------------------------------------
                int     peakData    =   (int) CalculatePeakSensitivity( iX, FFTData, length );
                if ( peakData > maxHeight ) { peakData = maxHeight; }

                if ( peaksArray[iX] < peakData && peakData > 0 ) {
                    peaksArray[iX] = peakData;
                } else {
                    peaksArray[iX] -= peakFallOff;
                    if ( peaksArray[iX] < 0 ) { peaksArray[iX] = 0; }
                }

                if ( floatsArray[iX] < peakData && peakData > 0 ) {
                    floatsArray[iX] = peakData;
                } else {
                    floatsArray[iX] -= floatFallOff;
                    if ( floatsArray[iX] < 0 ) { floatsArray[iX] = 0; }
                }

                // ---------------------------------------------------------
                // --- Pobieranie kolorów wizualizacji i dokonanie zmian ---
                // ---------------------------------------------------------
                if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                    fillColor       =   RainbowColor.getColor();
                    borderColor     =   RainbowColor.getColor();
                    RainbowColor.nextColor( rainbowColor );
                }

                // -----------------------------------------------------
                // --- Przygotowanie konfiguracji rysowania spektrum ---
                // -----------------------------------------------------
                int         peak        =   peaksArray[iX];
                int         floater     =   floatsArray[iX];
                Brush       brush       =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                Pen         pen         =   new Pen( Color.FromArgb( alphaColor, borderColor ), 1 );
                
                Rectangle   peakRect    =   new Rectangle(
                    startX + iX*peakSpace + iX*peakWidth,
                    this.size.Height/2 - peak,
                    peakWidth,
                    peak*2
                );
                
                Rectangle   fallowRect  =   new Rectangle(
                    startX + iX * peakSpace + iX * peakWidth,
                    this.size.Height/2 - floater - this.peakSpace - peakHeight,
                    peakWidth,
                    peakHeight
                );

                Rectangle   fallowRRect     =   new Rectangle(
                    startX + iX * peakSpace + iX * peakWidth,
                    this.size.Height/2 + floater + this.peakSpace,
                    peakWidth,
                    peakHeight
                );

                // -------------------------------------------------------------
                // --- Praca Animacji Show Hide ---
                // -------------------------------------------------------------
                if ( AnimSpecShowWork( iX, this.peaksAmount ) ) { break; }

                // -------------------------------------------------------------
                // --- Rysowanie spektrum graficznego na obszarze wyjściowym ---
                // -------------------------------------------------------------
                if ( peak > 0 ) {
                    switch ( fillStyle ) {
                        case SpectrumFillStyle.All:
                            graphics.FillRectangle( brush, peakRect );
                            graphics.DrawRectangle( pen, peakRect );
                            break;

                        case SpectrumFillStyle.Border:
                            graphics.DrawRectangle( pen, peakRect );
                            break;

                        case SpectrumFillStyle.Fill:
                            graphics.FillRectangle( brush, peakRect );
                            break;
                    }
                }

                if ( floater > 0 ) {
                    switch ( fillStyle ) {
                        case SpectrumFillStyle.All:
                            graphics.FillRectangle( brush, fallowRect );
                            graphics.DrawRectangle( pen, fallowRect );
                            graphics.FillRectangle( brush, fallowRRect );
                            graphics.DrawRectangle( pen, fallowRRect );
                            break;

                        case SpectrumFillStyle.Border:
                            graphics.DrawRectangle( pen, fallowRect );
                            graphics.DrawRectangle( pen, fallowRRect );
                            break;

                        case SpectrumFillStyle.Fill:
                            graphics.FillRectangle( brush, fallowRect );
                            graphics.FillRectangle( brush, fallowRRect );
                            break;
                    }
                }

                // ------------------------------------------------------------
                // --- Debugowanie wartości spektrum na obszarze wyjściowym ---
                // ------------------------------------------------------------
                if ( debug ) {
                    graphics.DrawString( peakData.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 5, iX*12 );
                    graphics.DrawString( "Size -> " + size.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 24, 0 );
                }
            }

            // -------------------------------------------------------------------
            // --- Konfiguracja końcowa kolorów wizualizacji i dokonanie zmian ---
            // -------------------------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeRecover();
                RainbowColor.nextColor( rainbowColor, rainbowTime );
            }
        }

        // ----------------------------------------------------------------------
        //  DRAW SPECTRUM CENTER PEAKS
        // ----------------------------------------------------------------------
        /// <summary> Funkcja generująca wizualizację graficzną na danych FFT,
        /// wyświetlająca skaczące linie belek w górę i dół, reprezentujące natężenie dźwięku na określonych częstotliwościach. </summary>
        /// <param name="FFTData"> Tablica FFT zawierająca poziomy natężenia dźwięku
        /// na określonych częstotliwoścach dźwięku. </param>
        /// <param name="length"> Długość tablicy FFT </param>
        public void DrawSpectrumCenterPeak( float[] FFTData, int length ) {

            // -----------------------------------------------------
            // --- Konfiguracja renderowanej klatki wizualizacji ---
            // -----------------------------------------------------
            Graphics    graphics    =   Graphics.FromImage( imageWorker );
            int         maxWidth    =   this.size.Width;
            int         peakWidth   =   (maxWidth/this.peaksAmount) - (this.peakSpace*1);
            int         peakHeight  =   (int) Math.Ceiling( peakWidth / 2f );
            int         maxHeight   =   (this.size.Height/2) - this.peakSpace*2 - peakHeight*2;
            int         startX      =   (maxWidth - (peakWidth + (this.peakSpace * 1)) * this.peaksAmount) / 2;

            // -------------------------------------------------
            // --- Konfiguracja wstępna kolorów wizualizacji ---
            // -------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeBackup();
            }

            for ( int iX = 0; iX < this.peaksAmount; iX++ ) {

                // -------------------------------------------------
                // --- Sprawdzenie poprawności aktualnych danych ---
                // -------------------------------------------------
                if ( peaksArray == null || floatsArray == null ) { break; }
                if ( iX >= peaksArray.Length || iX > floatsArray.Length ) { break; }

                // ----------------------------------------------------------------
                // --- Ustawienie wartości maksymalnej i przypisanie do tablicy ---
                // ----------------------------------------------------------------
                int     peakData    =   (int) CalculatePeakSensitivity( iX, FFTData, length );
                if ( peakData > maxHeight ) { peakData = maxHeight; }

                if ( peaksArray[iX] < peakData && peakData > 0 ) {
                    peaksArray[iX] = peakData;
                } else {
                    peaksArray[iX] -= peakFallOff;
                    if ( peaksArray[iX] < 0 ) { peaksArray[iX] = 0; }
                }

                if ( floatsArray[iX] < peakData && peakData > 0 ) {
                    floatsArray[iX] = peakData;
                } else {
                    floatsArray[iX] -= floatFallOff;
                    if ( floatsArray[iX] < 0 ) { floatsArray[iX] = 0; }
                }
                
                // -----------------------------------------------------------
                // --- Pobieranie kolorów wizualizacji i dokonanie zmian 1 ---
                // -----------------------------------------------------------
                switch ( fillType ) {
                    case SpectrumFillType.RainbowHorizontal:
                        fillColor       =   RainbowColor.getColor();
                        borderColor     =   RainbowColor.getColor();
                        break;
                    case SpectrumFillType.RainbowVertical:
                        RainbowColor.makeRecover();
                        break;
                }

                // -----------------------------------------------------
                // --- Przygotowanie konfiguracji rysowania spektrum ---
                // -----------------------------------------------------
                int         peak        =   peaksArray[iX];
                int         floater     =   floatsArray[iX];
                Brush       brush       =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                Pen         pen         =   new Pen( Color.FromArgb( alphaColor, borderColor ), 1 );

                Rectangle   fallowRect  =   new Rectangle(
                    startX + iX * peakSpace + iX * peakWidth,
                    (this.size.Height/2) - floater - this.peakSpace - peakHeight,
                    peakWidth,
                    peakHeight
                );

                Rectangle   fallowRRect     =   new Rectangle(
                    startX + iX * peakSpace + iX * peakWidth,
                    (this.size.Height/2) + floater + this.peakSpace + peakHeight,
                    peakWidth,
                    peakHeight
                );

                // -------------------------------------------------------------
                // --- Praca Animacji Show Hide ---
                // -------------------------------------------------------------
                if ( AnimSpecShowWork( iX, this.peaksAmount ) ) { break; }

                for ( int iY = (this.size.Height/2) - peakHeight; iY > (this.size.Height/2) - peak; iY -= (peakHeight + this.peakSpace) ) {

                    // --------------------------------------------------
                    // --- Generowanie bloku wizualizacji elementowej ---
                    // --------------------------------------------------
                    Rectangle peakRect    =   new Rectangle(
                        startX + iX*peakSpace + iX*peakWidth,
                        iY,
                        peakWidth,
                        peakHeight
                    );

                    // -----------------------------------------------------------
                    // --- Pobieranie kolorów wizualizacji i dokonanie zmian 2 ---
                    // -----------------------------------------------------------
                    switch ( fillType ) {
                        case SpectrumFillType.RainbowHorizontal:
                            //
                            break;
                        case SpectrumFillType.RainbowVertical:
                            fillColor       =   RainbowColor.getColor();
                            borderColor     =   RainbowColor.getColor();
                            brush           =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                            pen             =   new Pen( Color.FromArgb( alphaColor, borderColor ), 1 );
                            RainbowColor.nextColor( rainbowColor );
                            break;
                    }

                    // -------------------------------------------------------------
                    // --- Rysowanie spektrum graficznego na obszarze wyjściowym ---
                    // -------------------------------------------------------------
                    if ( peak > 0 ) {
                        switch ( fillStyle ) {
                            case SpectrumFillStyle.All:
                                graphics.FillRectangle( brush, peakRect );
                                graphics.DrawRectangle( pen, peakRect );
                                break;

                            case SpectrumFillStyle.Border:
                                graphics.DrawRectangle( pen, peakRect );
                                break;

                            case SpectrumFillStyle.Fill:
                                graphics.FillRectangle( brush, peakRect );
                                break;
                        }
                    }
                }

                // -----------------------------------------------------------
                // --- Przywracanie zmian kolorów wizualizacji dla odbicia ---
                // -----------------------------------------------------------
                switch ( fillType ) {
                    case SpectrumFillType.RainbowHorizontal:
                        RainbowColor.nextColor( rainbowColor );
                        break;
                    case SpectrumFillType.RainbowVertical:
                        RainbowColor.makeRecover();
                        break;
                }

                for ( int iY = (this.size.Height/2) + this.peakSpace; iY < (this.size.Height/2) + peak; iY += (peakHeight + this.peakSpace) ) {

                    // --------------------------------------------------
                    // --- Generowanie bloku wizualizacji elementowej ---
                    // --------------------------------------------------
                    Rectangle peakRect    =   new Rectangle(
                        startX + iX*peakSpace + iX*peakWidth,
                        iY,
                        peakWidth,
                        peakHeight
                    );

                    // -----------------------------------------------------------
                    // --- Pobieranie kolorów wizualizacji i dokonanie zmian 2 ---
                    // -----------------------------------------------------------
                    switch ( fillType ) {
                        case SpectrumFillType.RainbowHorizontal:
                            //
                            break;
                        case SpectrumFillType.RainbowVertical:
                            fillColor       =   RainbowColor.getColor();
                            borderColor     =   RainbowColor.getColor();
                            brush           =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                            pen             =   new Pen( Color.FromArgb( alphaColor, borderColor ), 1 );
                            RainbowColor.nextColor( rainbowColor );
                            break;
                    }

                    // -------------------------------------------------------------
                    // --- Rysowanie spektrum graficznego na obszarze wyjściowym ---
                    // -------------------------------------------------------------
                    if ( peak > 0 ) {
                        switch ( fillStyle ) {
                            case SpectrumFillStyle.All:
                                graphics.FillRectangle( brush, peakRect );
                                graphics.DrawRectangle( pen, peakRect );
                                break;

                            case SpectrumFillStyle.Border:
                                graphics.DrawRectangle( pen, peakRect );
                                break;

                            case SpectrumFillStyle.Fill:
                                graphics.FillRectangle( brush, peakRect );
                                break;
                        }
                    }
                }

                // ----------------------------------------------------------------------
                // --- Rysowanie floatera spektrum graficznego na obszarze wyjściowym ---
                // ----------------------------------------------------------------------
                if ( floater > 0 ) {
                    switch ( fillStyle ) {
                        case SpectrumFillStyle.All:
                            graphics.FillRectangle( brush, fallowRect );
                            graphics.DrawRectangle( pen, fallowRect );
                            graphics.FillRectangle( brush, fallowRRect );
                            graphics.DrawRectangle( pen, fallowRRect );
                            break;

                        case SpectrumFillStyle.Border:
                            graphics.DrawRectangle( pen, fallowRect );
                            graphics.DrawRectangle( pen, fallowRRect );
                            break;

                        case SpectrumFillStyle.Fill:
                            graphics.FillRectangle( brush, fallowRect );
                            graphics.FillRectangle( brush, fallowRRect );
                            break;
                    }
                }

                // ------------------------------------------------------------
                // --- Debugowanie wartości spektrum na obszarze wyjściowym ---
                // ------------------------------------------------------------
                if ( debug ) {
                    graphics.DrawString( peakData.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 5, iX*12 );
                    graphics.DrawString( "Size -> " + size.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 24, 0 );
                }
            }

            // -------------------------------------------------------------------
            // --- Konfiguracja końcowa kolorów wizualizacji i dokonanie zmian ---
            // -------------------------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeRecover();
                RainbowColor.nextColor( rainbowColor, rainbowTime );
            }
        }

        // ----------------------------------------------------------------------
        //  DRAW SPECTRUM FLOAT LINES
        // ----------------------------------------------------------------------
        /// <summary> Funkcja generująca wizualizację graficzną na danych FFT,
        /// wyświetlająca skaczące belki, reprezentujące natężenie dźwięku na określonych częstotliwościach. </summary>
        /// <param name="FFTData"> Tablica FFT zawierająca poziomy natężenia dźwięku
        /// na określonych częstotliwoścach dźwięku. </param>
        /// <param name="length"> Długość tablicy FFT </param>
        public void DrawSpectrumFloatLine( float[] FFTData, int length ) {

            // -----------------------------------------------------
            // --- Konfiguracja renderowanej klatki wizualizacji ---
            // -----------------------------------------------------
            Graphics    graphics    =   Graphics.FromImage( imageWorker );
            int         maxWidth    =   this.size.Width;
            int         peakWidth   =   (maxWidth/this.peaksAmount) - (this.peakSpace*1);
            int         peakHeight  =   (int) Math.Ceiling( peakWidth / 2f );
            int         maxHeight   =   (this.size.Height/2) - this.peakSpace*2 - peakHeight*2;
            int         startX      =   (maxWidth - (peakWidth + (this.peakSpace * 1)) * this.peaksAmount) / 2;

            // -------------------------------------------------
            // --- Konfiguracja wstępna kolorów wizualizacji ---
            // -------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeBackup();
            }

            for ( int iX = 0; iX < this.peaksAmount; iX++ ) {

                // -------------------------------------------------
                // --- Sprawdzenie poprawności aktualnych danych ---
                // -------------------------------------------------
                if ( peaksArray == null || floatsArray == null ) { break; }
                if ( iX >= peaksArray.Length || iX > floatsArray.Length ) { break; }

                // ----------------------------------------------------------------
                // --- Ustawienie wartości maksymalnej i przypisanie do tablicy ---
                // ----------------------------------------------------------------
                int     peakData    =   (int) CalculatePeakSensitivity( iX, FFTData, length );
                if ( peakData > maxHeight ) { peakData = maxHeight; }

                if ( peaksArray[iX] < peakData && peakData > 0 ) {
                    peaksArray[iX] = peakData;
                } else {
                    peaksArray[iX] -= peakFallOff;
                    if ( peaksArray[iX] < 0 ) { peaksArray[iX] = 0; }
                }

                if ( floatsArray[iX] < peakData && peakData > 0 ) {
                    floatsArray[iX] = peakData;
                } else {
                    floatsArray[iX] -= floatFallOff;
                    if ( floatsArray[iX] < 0 ) { floatsArray[iX] = 0; }
                }

                // ---------------------------------------------------------
                // --- Pobieranie kolorów wizualizacji i dokonanie zmian ---
                // ---------------------------------------------------------
                if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                    fillColor       =   RainbowColor.getColor();
                    borderColor     =   RainbowColor.getColor();
                    RainbowColor.nextColor( rainbowColor );
                }

                // -----------------------------------------------------
                // --- Przygotowanie konfiguracji rysowania spektrum ---
                // -----------------------------------------------------
                int         peak        =   peaksArray[iX];
                int         floater     =   floatsArray[iX];
                Brush       brush       =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                Pen         pen         =   new Pen( Color.FromArgb( alphaColor, borderColor ), 1 );
                
                Rectangle   fallowRect  =   new Rectangle(
                    startX + iX * peakSpace + iX * peakWidth,
                    this.size.Height/2 - floater - this.peakSpace - peakHeight,
                    peakWidth,
                    floater - peak
                );

                Rectangle   fallowRRect     =   new Rectangle(
                    startX + iX * peakSpace + iX * peakWidth,
                    this.size.Height/2 + floater + this.peakSpace,
                    peakWidth,
                    floater - peak
                );

                // -------------------------------------------------------------
                // --- Praca Animacji Show Hide ---
                // -------------------------------------------------------------
                if ( AnimSpecShowWork( iX, this.peaksAmount ) ) { break; }

                // -------------------------------------------------------------
                // --- Rysowanie spektrum graficznego na obszarze wyjściowym ---
                // -------------------------------------------------------------
                if ( (floater - peak) >= peakHeight ) {
                    switch ( fillStyle ) {
                        case SpectrumFillStyle.All:
                            graphics.FillRectangle( brush, fallowRect );
                            graphics.DrawRectangle( pen, fallowRect );
                            graphics.FillRectangle( brush, fallowRRect );
                            graphics.DrawRectangle( pen, fallowRRect );
                            break;

                        case SpectrumFillStyle.Border:
                            graphics.DrawRectangle( pen, fallowRect );
                            graphics.DrawRectangle( pen, fallowRRect );
                            break;

                        case SpectrumFillStyle.Fill:
                            graphics.FillRectangle( brush, fallowRect );
                            graphics.FillRectangle( brush, fallowRRect );
                            break;
                    }
                }

                // ------------------------------------------------------------
                // --- Debugowanie wartości spektrum na obszarze wyjściowym ---
                // ------------------------------------------------------------
                if ( debug ) {
                    graphics.DrawString( peakData.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 5, iX*12 );
                    graphics.DrawString( "Size -> " + size.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 24, 0 );
                }
            }

            // -------------------------------------------------------------------
            // --- Konfiguracja końcowa kolorów wizualizacji i dokonanie zmian ---
            // -------------------------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeRecover();
                RainbowColor.nextColor( rainbowColor, rainbowTime );
            }
        }

        // ----------------------------------------------------------------------
        //  DRAW SPECTRUM FLOAT PEAKS
        // ----------------------------------------------------------------------
        /// <summary> Funkcja generująca wizualizację graficzną na danych FFT,
        /// wyświetlająca opadające linie belek z góry i z dołu, reprezentujące natężenie dźwięku na określonych częstotliwościach. </summary>
        /// <param name="FFTData"> Tablica FFT zawierająca poziomy natężenia dźwięku
        /// na określonych częstotliwoścach dźwięku. </param>
        /// <param name="length"> Długość tablicy FFT </param>
        public void DrawSpectrumFloatPeak( float[] FFTData, int length ) {

            // -----------------------------------------------------
            // --- Konfiguracja renderowanej klatki wizualizacji ---
            // -----------------------------------------------------
            Graphics    graphics    =   Graphics.FromImage( imageWorker );
            int         maxWidth    =   this.size.Width;
            int         peakWidth   =   (maxWidth/this.peaksAmount) - (this.peakSpace*1);
            int         peakHeight  =   (int) Math.Ceiling( peakWidth / 2f );
            int         maxHeight   =   (this.size.Height/2) - this.peakSpace*2 - peakHeight*2;
            int         startX      =   (maxWidth - (peakWidth + (this.peakSpace * 1)) * this.peaksAmount) / 2;

            // -------------------------------------------------
            // --- Konfiguracja wstępna kolorów wizualizacji ---
            // -------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeBackup();
            }

            for ( int iX = 0; iX < this.peaksAmount; iX++ ) {

                // -------------------------------------------------
                // --- Sprawdzenie poprawności aktualnych danych ---
                // -------------------------------------------------
                if ( peaksArray == null || floatsArray == null ) { break; }
                if ( iX >= peaksArray.Length || iX > floatsArray.Length ) { break; }

                // ----------------------------------------------------------------
                // --- Ustawienie wartości maksymalnej i przypisanie do tablicy ---
                // ----------------------------------------------------------------
                int     peakData    =   (int) CalculatePeakSensitivity( iX, FFTData, length );
                if ( peakData > maxHeight ) { peakData = maxHeight; }

                if ( peaksArray[iX] < peakData && peakData > 0 ) {
                    peaksArray[iX] = peakData;
                } else {
                    peaksArray[iX] -= peakFallOff;
                    if ( peaksArray[iX] < 0 ) { peaksArray[iX] = 0; }
                }

                if ( floatsArray[iX] < peakData && peakData > 0 ) {
                    floatsArray[iX] = peakData;
                } else {
                    floatsArray[iX] -= floatFallOff;
                    if ( floatsArray[iX] < 0 ) { floatsArray[iX] = 0; }
                }
                
                // -----------------------------------------------------------
                // --- Pobieranie kolorów wizualizacji i dokonanie zmian 1 ---
                // -----------------------------------------------------------
                switch ( fillType ) {
                    case SpectrumFillType.RainbowHorizontal:
                        fillColor       =   RainbowColor.getColor();
                        borderColor     =   RainbowColor.getColor();
                        break;
                    case SpectrumFillType.RainbowVertical:
                        RainbowColor.makeRecover();
                        break;
                }

                // -----------------------------------------------------
                // --- Przygotowanie konfiguracji rysowania spektrum ---
                // -----------------------------------------------------
                int         peak        =   peaksArray[iX];
                int         floater     =   floatsArray[iX];
                Brush       brush       =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                Pen         pen         =   new Pen( Color.FromArgb( alphaColor, borderColor ), 1 );

                // -------------------------------------------------------------
                // --- Praca Animacji Show Hide ---
                // -------------------------------------------------------------
                if ( AnimSpecShowWork( iX, this.peaksAmount ) ) { break; }

                for ( int iY = (this.size.Height / 2) - peakHeight; iY > (this.size.Height/2) - floater - this.peakSpace - peakHeight; iY -= (peakHeight + this.peakSpace) ) {
                    
                    if ( iY > (this.size.Height/2) - peak ) { continue; }

                    // --------------------------------------------------
                    // --- Generowanie bloku wizualizacji elementowej ---
                    // --------------------------------------------------
                    Rectangle peakRect    =   new Rectangle(
                        startX + iX*peakSpace + iX*peakWidth,
                        iY,
                        peakWidth,
                        peakHeight
                    );

                    // -----------------------------------------------------------
                    // --- Pobieranie kolorów wizualizacji i dokonanie zmian 2 ---
                    // -----------------------------------------------------------
                    switch ( fillType ) {
                        case SpectrumFillType.RainbowHorizontal:
                            //
                            break;
                        case SpectrumFillType.RainbowVertical:
                            fillColor       =   RainbowColor.getColor();
                            borderColor     =   RainbowColor.getColor();
                            brush           =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                            pen             =   new Pen( Color.FromArgb( alphaColor, borderColor ), 1 );
                            RainbowColor.nextColor( rainbowColor );
                            break;
                    }

                    // -------------------------------------------------------------
                    // --- Rysowanie spektrum graficznego na obszarze wyjściowym ---
                    // -------------------------------------------------------------
                    if ( (floater - peak) >= peakHeight ) {
                        switch ( fillStyle ) {
                            case SpectrumFillStyle.All:
                                graphics.FillRectangle( brush, peakRect );
                                graphics.DrawRectangle( pen, peakRect );
                                break;

                            case SpectrumFillStyle.Border:
                                graphics.DrawRectangle( pen, peakRect );
                                break;

                            case SpectrumFillStyle.Fill:
                                graphics.FillRectangle( brush, peakRect );
                                break;
                        }
                    }
                }

                // -----------------------------------------------------------
                // --- Przywracanie zmian kolorów wizualizacji dla odbicia ---
                // -----------------------------------------------------------
                switch ( fillType ) {
                    case SpectrumFillType.RainbowHorizontal:
                        RainbowColor.nextColor( rainbowColor );
                        break;
                    case SpectrumFillType.RainbowVertical:
                        RainbowColor.makeRecover();
                        break;
                }

                for ( int iY = (this.size.Height/2) + this.peakSpace; iY < (this.size.Height/2) + floater + this.peakSpace + peakHeight; iY += (peakHeight + this.peakSpace) ) {

                    if ( iY < (this.size.Height/2) + peak ) { continue; }

                    // --------------------------------------------------
                    // --- Generowanie bloku wizualizacji elementowej ---
                    // --------------------------------------------------
                    Rectangle peakRect    =   new Rectangle(
                        startX + iX*peakSpace + iX*peakWidth,
                        iY,
                        peakWidth,
                        peakHeight
                    );

                    // -----------------------------------------------------------
                    // --- Pobieranie kolorów wizualizacji i dokonanie zmian 2 ---
                    // -----------------------------------------------------------
                    switch ( fillType ) {
                        case SpectrumFillType.RainbowHorizontal:
                            //
                            break;
                        case SpectrumFillType.RainbowVertical:
                            fillColor       =   RainbowColor.getColor();
                            borderColor     =   RainbowColor.getColor();
                            brush           =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                            pen             =   new Pen( Color.FromArgb( alphaColor, borderColor ), 1 );
                            RainbowColor.nextColor( rainbowColor );
                            break;
                    }

                    // -------------------------------------------------------------
                    // --- Rysowanie spektrum graficznego na obszarze wyjściowym ---
                    // -------------------------------------------------------------
                    if ( (floater - peak) >= peakHeight ) {
                        switch ( fillStyle ) {
                            case SpectrumFillStyle.All:
                                graphics.FillRectangle( brush, peakRect );
                                graphics.DrawRectangle( pen, peakRect );
                                break;

                            case SpectrumFillStyle.Border:
                                graphics.DrawRectangle( pen, peakRect );
                                break;

                            case SpectrumFillStyle.Fill:
                                graphics.FillRectangle( brush, peakRect );
                                break;
                        }
                    }
                }

                // ------------------------------------------------------------
                // --- Debugowanie wartości spektrum na obszarze wyjściowym ---
                // ------------------------------------------------------------
                if ( debug ) {
                    graphics.DrawString( peakData.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 5, iX*12 );
                    graphics.DrawString( "Size -> " + size.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 24, 0 );
                }
            }

            // -------------------------------------------------------------------
            // --- Konfiguracja końcowa kolorów wizualizacji i dokonanie zmian ---
            // -------------------------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeRecover();
                RainbowColor.nextColor( rainbowColor, rainbowTime );
            }
        }

        // ----------------------------------------------------------------------
        //  DRAW SPECTRUM CIRCLE LINES
        // ----------------------------------------------------------------------
        /// <summary> Funkcja generująca wizualizację graficzną na danych FFT,
        /// wyświetlająca skaczące linie promieniście na kole, reprezentujące natężenie dźwięku na określonych częstotliwościach. </summary>
        /// <param name="FFTData"> Tablica FFT zawierająca poziomy natężenia dźwięku
        /// na określonych częstotliwoścach dźwięku. </param>
        /// <param name="length"> Długość tablicy FFT </param>
        public void DrawSpectrumCircle( float[] FFTData, int length ) {

            // -----------------------------------------------------
            // --- Konfiguracja renderowanej klatki wizualizacji ---
            // -----------------------------------------------------
            Graphics    graphics        =   Graphics.FromImage( imageWorker );
            Point       centerPoint     =   new Point( (int) (size.Width/2), (int) (size.Height/2) );
            int         internalRing    =   logoR;
            int         externalRing    =   Math.Min( size.Height, size.Width ) / 2 - internalRing;
            int         maxHeight       =   externalRing - internalRing - this.peakSpace * 2;       
            float       stepAngle       =   (360f / this.peaksAmount) * (float) Math.PI / 180;
            int         colorChange     =   1538 / this.peaksAmount;

            int         brushThickness  =   3;

            // -------------------------------------------------
            // --- Konfiguracja wstępna kolorów wizualizacji ---
            // -------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeBackup();
            }

            int position    =   2;
            for ( int iX = 0; iX < this.peaksAmount; iX++ ) {

                // -------------------------------------------------
                // --- Sprawdzenie poprawności aktualnych danych ---
                // -------------------------------------------------
                if ( peaksArray == null || floatsArray == null ) { break; }
                if ( iX >= peaksArray.Length || iX > floatsArray.Length ) { break; }

                // ----------------------------------------------------------------
                // --- Ustawienie wartości maksymalnej i przypisanie do tablicy ---
                // ----------------------------------------------------------------
                int     peakData    =   (int) CalculatePeakSensitivity( position, FFTData, length );
                if ( peakData > maxHeight ) { peakData = maxHeight; }

                if ( peaksArray[iX] < peakData && peakData > 0 ) {
                    peaksArray[iX] = peakData;
                } else {
                    peaksArray[iX] -= peakFallOff;
                    if ( peaksArray[iX] < 0 ) { peaksArray[iX] = 0; }
                }

                // ---------------------------------------------------------
                // --- Pobieranie kolorów wizualizacji i dokonanie zmian ---
                // ---------------------------------------------------------
                if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                    fillColor       =   RainbowColor.getColor();
                    borderColor     =   RainbowColor.getColor();
                    RainbowColor.nextColor( colorChange );
                }

                // -----------------------------------------------------
                // --- Przygotowanie konfiguracji rysowania spektrum ---
                // -----------------------------------------------------
                int         peak        =   peaksArray[iX];
                Brush       brush       =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                Pen         pen         =   new Pen( Color.FromArgb( alphaColor, borderColor ), brushThickness+2 );
                pen.StartCap            =   System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap              =   System.Drawing.Drawing2D.LineCap.Round;

                double      spSin       =   (internalRing * Math.Sin(iX * stepAngle));
                double      spCos       =   (internalRing * Math.Cos(iX * stepAngle));
                Point       startPoint  =   new Point(
                    (int) (centerPoint.X + (spCos - spSin)),
                    (int) (centerPoint.Y + (spSin + spCos))
                );

                double      epSin       =   (internalRing + peak) * Math.Sin(iX * stepAngle);
                double      epCos       =   (internalRing + peak) * Math.Cos(iX * stepAngle);
                Point       endPoint    =   new Point(
                    (int) (centerPoint.X + (epCos - epSin)),
                    (int) (centerPoint.Y + (epSin + epCos))
                );

                // -------------------------------------------------------------
                // --- Praca Animacji Show Hide ---
                // -------------------------------------------------------------
                if ( AnimSpecShowWork( iX, this.peaksAmount ) ) { break; }

                // -------------------------------------------------------------
                // --- Rysowanie spektrum graficznego na obszarze wyjściowym ---
                // -------------------------------------------------------------
                if ( peak > 0 ) {
                    graphics.DrawLine( pen, startPoint, endPoint );
                    pen.Width       =   brushThickness;
                    graphics.DrawLine( pen, startPoint, endPoint );
                }

                // ------------------------------------------------------------
                // --- Debugowanie wartości spektrum na obszarze wyjściowym ---
                // ------------------------------------------------------------
                if ( debug ) {
                    graphics.DrawString( peakData.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 5, iX*12 );
                    graphics.DrawString( "Size -> " + size.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 24, 0 );
                }

                if ( iX >= 96 ) { position -= 4; }
                else if ( iX >= 64 ) { position += 4; }
                else if ( iX >= 32 ) { position -= 4; }
                else if ( iX >= 0 ) { position += 4; }
            }

            // -------------------------------------------------------------------
            // --- Konfiguracja końcowa kolorów wizualizacji i dokonanie zmian ---
            // -------------------------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeRecover();
                RainbowColor.nextColor( colorChange, rainbowTime );
            }
        }

        // ----------------------------------------------------------------------
        //  DRAW SPECTRUM REVERSE CIRCLE LINES
        // ----------------------------------------------------------------------
        /// <summary> Funkcja generująca wizualizację graficzną na danych FFT,
        /// wyświetlająca skaczące odwrócone linie promieniście na kole, reprezentujące natężenie dźwięku na określonych częstotliwościach. </summary>
        /// <param name="FFTData"> Tablica FFT zawierająca poziomy natężenia dźwięku
        /// na określonych częstotliwoścach dźwięku. </param>
        /// <param name="length"> Długość tablicy FFT </param>
        public void DrawSpectrumReverseCircle( float[] FFTData, int length ) {

            // -----------------------------------------------------
            // --- Konfiguracja renderowanej klatki wizualizacji ---
            // -----------------------------------------------------
            Graphics    graphics        =   Graphics.FromImage( imageWorker );
            Point       centerPoint     =   new Point( (int) (size.Width/2), (int) (size.Height/2) );
            int         internalRing    =   logoR;
            int         externalRing    =   Math.Min( size.Height, size.Width ) / 2 - internalRing;
            int         maxHeight       =   externalRing - internalRing - this.peakSpace*2;        
            float       stepAngle       =   (360f / this.peaksAmount) * (float) Math.PI / 180;
            int         colorChange     =   1538 / this.peaksAmount;
            
            int         brushThickness  =   3;

            // -------------------------------------------------
            // --- Konfiguracja wstępna kolorów wizualizacji ---
            // -------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeBackup();
            }

            for ( int iX = 0; iX < this.peaksAmount; iX++ ) {

                // -------------------------------------------------
                // --- Sprawdzenie poprawności aktualnych danych ---
                // -------------------------------------------------
                if ( peaksArray == null || floatsArray == null ) { break; }
                if ( iX >= peaksArray.Length || iX > floatsArray.Length ) { break; }

                // ----------------------------------------------------------------
                // --- Ustawienie wartości maksymalnej i przypisanie do tablicy ---
                // ----------------------------------------------------------------
                int     peakData    =   (int) CalculatePeakSensitivity( iX, FFTData, length );
                if ( peakData > maxHeight ) { peakData = maxHeight; }

                if ( peaksArray[iX] < peakData && peakData > 0 ) {
                    peaksArray[iX] = peakData;
                } else {
                    peaksArray[iX] -= peakFallOff;
                    if ( peaksArray[iX] < 0 ) { peaksArray[iX] = 0; }
                }

                if ( floatsArray[iX] < peakData && peakData > 0 ) {
                    floatsArray[iX] = peakData;
                } else {
                    floatsArray[iX] -= floatFallOff;
                    if ( floatsArray[iX] < 0 ) { floatsArray[iX] = 0; }
                }

                // ---------------------------------------------------------
                // --- Pobieranie kolorów wizualizacji i dokonanie zmian ---
                // ---------------------------------------------------------
                if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                    fillColor       =   RainbowColor.getColor();
                    borderColor     =   RainbowColor.getColor();
                    RainbowColor.nextColor( colorChange );
                }

                // -----------------------------------------------------
                // --- Przygotowanie konfiguracji rysowania spektrum ---
                // -----------------------------------------------------
                int         peak        =   peaksArray[iX];
                Brush       brush       =   new SolidBrush( Color.FromArgb( alphaColor, fillColor ) );
                Pen         pen         =   new Pen( Color.FromArgb( alphaColor, borderColor ), brushThickness );
                
                double      spSin       =   (externalRing * Math.Sin(iX * stepAngle));
                double      spCos       =   (externalRing * Math.Cos(iX * stepAngle));
                Point       startPoint  =   new Point(
                    (int) (centerPoint.X + (spCos - spSin)),
                    (int) (centerPoint.Y + (spSin + spCos))
                );

                double      epSin       =   (externalRing - peak) * Math.Sin(iX * stepAngle);
                double      epCos       =   (externalRing - peak) * Math.Cos(iX * stepAngle);
                Point       endPoint    =   new Point(
                    (int) (centerPoint.X + (epCos - epSin)),
                    (int) (centerPoint.Y + (epSin + epCos))
                );

                //double      fpSin       =   (internalRing + floater) * Math.Sin(iX * stepAngle);
                //double      fpCos       =   (internalRing + floater) * Math.Cos(iX * stepAngle);
                //Rectangle   floatRect   =   new Rectangle(
                //    (int) (centerPoint.X + (fpCos - epSin) - brushThickness / 2),
                //    (int) (centerPoint.Y + (fpSin + epCos) - brushThickness / 2),
                //    brushThickness, brushThickness
                //);

                // -------------------------------------------------------------
                // --- Praca Animacji Show Hide ---
                // -------------------------------------------------------------
                if ( AnimSpecShowWork( iX, this.peaksAmount ) ) { break; }

                // -------------------------------------------------------------
                // --- Rysowanie spektrum graficznego na obszarze wyjściowym ---
                // -------------------------------------------------------------
                if ( peak > 0 ) {
                    graphics.DrawLine( pen, startPoint, endPoint );
                }
                
                //if ( floater > 0 ) {
                //    graphics.FillEllipse( brush, floatRect );
                //}

                // ------------------------------------------------------------
                // --- Debugowanie wartości spektrum na obszarze wyjściowym ---
                // ------------------------------------------------------------
                if ( debug ) {
                    graphics.DrawString( peakData.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 4, iX*12 );
                    graphics.DrawString( "Size -> " + size.ToString(), new Font( "Calibri", 10 ), new SolidBrush( Color.Lime ), 24, 0 );
                }
            }

            // -------------------------------------------------------------------
            // --- Konfiguracja końcowa kolorów wizualizacji i dokonanie zmian ---
            // -------------------------------------------------------------------
            if ( fillType == SpectrumFillType.RainbowHorizontal || fillType == SpectrumFillType.RainbowVertical ) {
                RainbowColor.makeRecover();
                RainbowColor.nextColor( colorChange, rainbowTime );
            }
        }

        #endregion Spectrums
        // ######################################################################

    }

    // ################################################################################

}
