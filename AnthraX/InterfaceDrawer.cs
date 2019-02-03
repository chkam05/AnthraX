using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnthraX {

    // ################################################################################
    //  xxxxx   x   x   xxxxx   xxxxx   xxxx    xxxxx    xxx     xxx    xxxxx
    //    x     xx  x     x     x       x   x   x       x   x   x   x   x    
    //    x     x x x     x     xxxx    xxxx    xxxx    xxxxx   x       xxxx 
    //    x     x  xx     x     x       x   x   x       x   x   x   x   x    
    //  xxxxx   x   x     x     xxxxx   x   x   x       x   x    xxx    xxxxx
    //
    //  xxxx    xxxx     xxx    x   x   xxxxx   xxxx 
    //   x  x   x   x   x   x   x   x   x       x   x
    //   x  x   xxxx    xxxxx   x x x   xxxx    xxxx 
    //   x  x   x   x   x   x   xx xx   x       x   x
    //  xxxx    x   x   x   x   x   x   xxxxx   x   x
    // ################################################################################
    public static class InterfaceDrawer {

        private const   int     sliderConstAlpha    =   64;

        // --- Background Data ---
        public  static  Rectangle           borderSize;
        public  static  ThemeType           themeType               =   ThemeType.None;
        public  static  WallpaperType       backgroundType          =   WallpaperType.None;
        public  static  WallpaperDrawType   backgroundDrawType      =   WallpaperDrawType.AdjustMax;
        public  static  Image               background              =   new Bitmap( Properties.Resources.temp_bckg );
        public  static  Image               renderedBackground      =   null;
        public  static  Image               renderedVisualisation   =   null;
        public  static  Color               backgroundColor         =   Color.Black;

        // --- Components Data ---
        public  static  Color   controlsColor       =   Color.Black;
        public  static  Color   sliderColor         =   Color.White;
        public  static  int     controlAlpha        =   128;
        public  static  int     sliderAlpha         =   192;

        // ######################################################################
        //  xxx      xxx     xxx    x   x    xxxx   xxxx     xxx    x   x   x   x   xxxx 
        //  x  x    x   x   x   x   x  x    x       x   x   x   x   x   x   xx  x    x  x
        //  xxxx    xxxxx   x       xxx     x  xx   xxxx    x   x   x   x   x x x    x  x
        //  x   x   x   x   x   x   x  x    x   x   x   x   x   x   x   x   x  xx    x  x
        //  xxxx    x   x    xxx    x   x    xxxx   x   x    xxx     xxx    x   x   xxxx 
        // ######################################################################
        #region DrawBackground
        // ----------------------------------------------------------------------
        public static void RenderBackground( Rectangle windowClientSize ) {
            renderedBackground      =   new Bitmap( windowClientSize.Width, windowClientSize.Height );
            Graphics    graphics    =   Graphics.FromImage( renderedBackground );
            Rectangle   dest        =   new Rectangle( 0, 0, renderedBackground.Width, renderedBackground.Height );

            switch ( backgroundType ) {
                case WallpaperType.None:
                    graphics.FillRectangle( new SolidBrush( Color.Black ), dest );
                    break;
                
                case WallpaperType.Color:
                    graphics.FillRectangle( new SolidBrush( backgroundColor ), dest );
                    break;

                case WallpaperType.CustomColor:
                    graphics.FillRectangle( new SolidBrush( backgroundColor ), dest );
                    break;

                case WallpaperType.Picture:
                    switch ( backgroundDrawType ) {
                        case WallpaperDrawType.Normal:
                            renderedBackground  =   ImageTools.DrawImage( background, dest );
                            break;
                        case WallpaperDrawType.Center:
                            renderedBackground  =   ImageTools.DrawCenterImage( background, dest );
                            break;
                        case WallpaperDrawType.Resized:
                            renderedBackground  =   ImageTools.DrawResizedImage( background, dest );
                            break;
                        case WallpaperDrawType.Stretched:
                            renderedBackground  =   ImageTools.DrawStrechetImage( background, dest );
                            break;
                        case WallpaperDrawType.AdjustMax:
                            renderedBackground  =   ImageTools.DrawAdjustedMaxImage( background, dest );
                            break;
                        case WallpaperDrawType.AdjustMin:
                            renderedBackground  =   ImageTools.DrawAdjustedMinImage( background, dest );
                            break;
                    }
                    break;

                case WallpaperType.Wallpaper:
                    Rectangle   wallDest    =   new Rectangle(
                        windowClientSize.X + borderSize.Width, windowClientSize.Y + borderSize.Height,
                        dest.Width, dest.Height
                    );

                    renderedBackground      =   ImageTools.DrawWallpaper( background, wallDest );
                    break;
            }
        }

        // ----------------------------------------------------------------------
        //  Paint Components Interface Background
        // ----------------------------------------------------------------------
        public static void PaintVisualisationBack(object sender, PaintEventArgs e) {
            var         panel   =   (Panel) sender;
            Rectangle   src     =   new Rectangle( panel.Left, panel.Top, panel.Width, panel.Height );
            Rectangle   dest    =   new Rectangle( 0, 0, panel.Width, panel.Height );

            e.Graphics.DrawImage( renderedBackground, dest, src, GraphicsUnit.Pixel );
        }
        

        // ----------------------------------------------------------------------
        public static void PaintMenuBack(object sender, PaintEventArgs e) {
            var         panel   =   (FlowLayoutPanel) sender;
            Rectangle   src     =   new Rectangle( panel.Left, panel.Top, panel.Width, panel.Height );
            Rectangle   dest    =   new Rectangle( 0, 0, panel.Width, panel.Height );
            Brush       back    =   new SolidBrush( Color.FromArgb( controlAlpha, controlsColor ) );

            e.Graphics.DrawImage( renderedBackground, dest, src, GraphicsUnit.Pixel );
            e.Graphics.FillRectangle( back, dest );
        }

        // ----------------------------------------------------------------------
        public static void PaintControlBack(object sender, PaintEventArgs e) {
            var         panel   =   (Panel) sender;
            Rectangle   src     =   new Rectangle( panel.Left, panel.Top, panel.Width, panel.Height );
            Rectangle   dest    =   new Rectangle( 0, 0, panel.Width, panel.Height );
            Brush       back    =   new SolidBrush( Color.FromArgb( controlAlpha, controlsColor ) );

            e.Graphics.DrawImage( renderedBackground, dest, src, GraphicsUnit.Pixel );
            e.Graphics.FillRectangle( back, dest );
        }

        // ----------------------------------------------------------------------
        public static void PaintPlayList(object sender, PaintEventArgs e, Panel parent) {
            var         panel   =   (TableLayoutPanel) sender;
            Rectangle   src     =   new Rectangle( parent.Left, parent.Top, panel.Width, panel.Height );
            Rectangle   dest    =   new Rectangle( 0, 0, panel.Width, panel.Height );
            Brush       back    =   new SolidBrush( Color.FromArgb( controlAlpha, controlsColor ) );

            e.Graphics.DrawImage( renderedBackground, dest, src, GraphicsUnit.Pixel );
            e.Graphics.FillRectangle( back, dest );
        }

        // ----------------------------------------------------------------------
        public static void PaintMusicSlider(object sender, PaintEventArgs e, Panel parent, CustomSlider sliderMusic) {
            var         panel   =   (Panel) sender;
            Rectangle   src     =   new Rectangle( parent.Left, parent.Top, panel.Width, panel.Height );
            Rectangle   dest    =   new Rectangle( 0, 0, panel.Width, panel.Height );
            Brush       back    =   new SolidBrush( Color.FromArgb( controlAlpha, controlsColor ) );
            Brush       slider  =   new SolidBrush( Color.FromArgb( sliderAlpha, sliderColor ) );
            Image       proc    =   new Bitmap( panel.Width, panel.Height );
            Graphics    graph   =   Graphics.FromImage( proc );

            graph.DrawImage( renderedBackground, dest, src, GraphicsUnit.Pixel );
            graph.FillRectangle( back, dest );
            graph.FillRectangle( new SolidBrush( Color.FromArgb( sliderConstAlpha, Color.Black ) ), dest );
            graph.FillRectangle( slider, sliderMusic.GetDrawBar() );
            e.Graphics.DrawImage( proc, 0, 0 );
        }

        // ----------------------------------------------------------------------
        public static void PaintVolumeSlider(object sender, PaintEventArgs e, CustomSlider sliderVolume) {
            var         panel   =   (Panel) sender;
            Rectangle   dest    =   new Rectangle( 0, 0, panel.Width, panel.Height );
            Brush       slider  =   new SolidBrush( Color.FromArgb( sliderAlpha, sliderColor ) );

            e.Graphics.FillRectangle( new SolidBrush( Color.FromArgb( sliderConstAlpha+32, Color.Black ) ), dest );
            e.Graphics.FillRectangle( slider, sliderVolume.GetDrawBar() );
        }

        // ----------------------------------------------------------------------
        public static void PaintPlayListSplit(object sender, PaintEventArgs e) {
            var         panel   =   (Panel) sender;
            Rectangle   dest    =   new Rectangle( 0, 0, panel.Width, panel.Height );
            e.Graphics.FillRectangle( new SolidBrush( Color.FromArgb( sliderConstAlpha, Color.Black ) ), dest );
        }

        // ----------------------------------------------------------------------
        public static void DrawPlayList( Image bckgImage, Panel parent, ListView listView ) {
            Rectangle   src     =   new Rectangle( parent.Left, listView.Top, listView.Size.Width, listView.Size.Height );
            Rectangle   dest    =   new Rectangle( 0, 0, listView.Size.Width, listView.Size.Height );
            Image       image   =   new Bitmap( dest.Width, dest.Height );
            Graphics    graph   =   Graphics.FromImage( image );
            Brush       back    =   new SolidBrush( Color.FromArgb( controlAlpha, controlsColor ) );

            graph.DrawImage( bckgImage, dest, src, GraphicsUnit.Pixel );
            graph.FillRectangle( back, dest );
            listView.BackgroundImage    =   image;
        }

        #endregion DrawBackground
        // ######################################################################
        //  xxx     x   x   xxxxx   xxxxx    xxx    x   x    xxxx
        //  x  x    x   x     x       x     x   x   xx  x   x    
        //  xxxx    x   x     x       x     x   x   x x x    xxx 
        //  x   x   x   x     x       x     x   x   x  xx       x
        //  xxxx     xxx      x       x      xxx    x   x   xxxx 
        //
        //  x   x   xxxxx   x   x   x   x
        //  xx xx   x       xx  x   x   x
        //  x x x   xxxx    x x x   x   x
        //  x   x   x       x  xx   x   x
        //  x   x   xxxxx   x   x    xxx 
        // ######################################################################
        #region DrawMenuButtons
        // ----------------------------------------------------------------------
        public static void MenuButtonDraw( Button button, bool darkMode, int options ) {
            
            // --- Icon Home ---
            if ( button.Name == "buttonHome" ) {
                switch ( options ) {
                    case 0:
                        if ( darkMode ) { button.Image = IconsMenu._32_Black_Main; }
                        else { button.Image = IconsMenu._32_White_Main; }
                        break;
                    case 1:
                        if ( darkMode ) { button.Image = IconsMenu._32_Black_PlayList; }
                        else { button.Image = IconsMenu._32_White_PlayList; }
                        break;
                }
            }
            // --- Icon Library ---
            else if ( button.Name == "buttonLibrary" ) {
                if ( darkMode ) { button.Image = IconsMenu._32_Black_Library; }
                else { button.Image = IconsMenu._32_White_Library; }
            }
            // --- Icon File Explorer ---
            else if ( button.Name == "buttonFileExplorer" ) {
                if ( darkMode ) { button.Image = IconsMenu._32_Black_Explorer; }
                else { button.Image = IconsMenu._32_White_Explorer; }
            }
            // --- Icon Karaoke ---
            else if ( button.Name == "buttonKaraoke" ) {
                if ( darkMode ) { button.Image = IconsMenu._32_Black_Karaoke; }
                else { button.Image = IconsMenu._32_White_Karaoke; }
            }
            // --- Icon Equalizer ---
            else if ( button.Name == "buttonEqualizer" ) {
                if ( darkMode ) { button.Image = IconsMenu._32_Black_Equalizer; }
                else { button.Image = IconsMenu._32_White_Equalizer; }
            }
            // --- Icon Settings ---
            else if ( button.Name == "buttonSettings" ) {
                if ( darkMode ) { button.Image = IconsMenu._32_Black_Settings; }
                else { button.Image = IconsMenu._32_White_Settings; }
            }

        }

        // ----------------------------------------------------------------------
        public static void MenuButtonHover( Button button, bool darkMode, int options ) {
            Image       icon        =   new Bitmap( button.Width, button.Height );
            Graphics    graphics    =   Graphics.FromImage( icon );
            Rectangle   src         =   new Rectangle( 0, 0, IconsMenu._32_Black_Home.Width, IconsMenu._32_Black_Home.Height );
            Rectangle   dest        =   new Rectangle(
                (icon.Width - IconsMenu._32_Black_Home.Width) / 2,
                (icon.Height - IconsMenu._32_Black_Home.Height) / 2,
                IconsMenu._32_Black_Home.Width, IconsMenu._32_Black_Home.Height
            );

            graphics        =   Graphics.FromImage( icon );
            graphics.DrawImage( IconsMenu._48_Hover, 0, 0, icon.Width, icon.Height );

            // --- Icon Home ---
            if ( button.Name == "buttonHome" ) {
                switch ( options ) {
                    case 0:
                        if ( darkMode ) { graphics.DrawImage( IconsMenu._32_Black_Main, dest, src, GraphicsUnit.Pixel ); }
                        else { graphics.DrawImage( IconsMenu._32_White_Main, dest, src, GraphicsUnit.Pixel ); }
                        break;
                    case 1:
                        if ( darkMode ) { graphics.DrawImage( IconsMenu._32_Black_PlayList, dest, src, GraphicsUnit.Pixel ); }
                        else { graphics.DrawImage( IconsMenu._32_White_PlayList, dest, src, GraphicsUnit.Pixel ); }
                        break;
                }
                
                button.Image    =   icon;
            }
            // --- Icon Library ---
            else if ( button.Name == "buttonLibrary" ) {
                if ( darkMode ) { graphics.DrawImage( IconsMenu._32_Black_Library, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsMenu._32_White_Library, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon File Explorer ---
            else if ( button.Name == "buttonFileExplorer" ) {
                if ( darkMode ) { graphics.DrawImage( IconsMenu._32_Black_Explorer, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsMenu._32_White_Explorer, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Karaoke ---
            else if ( button.Name == "buttonKaraoke" ) {
                if ( darkMode ) { graphics.DrawImage( IconsMenu._32_Black_Karaoke, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsMenu._32_White_Karaoke, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Equalizer ---
            else if ( button.Name == "buttonEqualizer" ) {
                if ( darkMode ) { graphics.DrawImage( IconsMenu._32_Black_Equalizer, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsMenu._32_White_Equalizer, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Settings ---
            else if ( button.Name == "buttonSettings" ) {
                if ( darkMode ) { graphics.DrawImage( IconsMenu._32_Black_Settings, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsMenu._32_White_Settings, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }

        }

        // ----------------------------------------------------------------------
        public static void MenuButtonPress( Button button, bool darkMode, int options ) {
            Image       icon        =   new Bitmap( button.Width, button.Height );
            Graphics    graphics    =   Graphics.FromImage( icon );
            Rectangle   src         =   new Rectangle( 0, 0, IconsMenu._32_Black_Home.Width, IconsMenu._32_Black_Home.Height );
            Rectangle   dest        =   new Rectangle(
                (icon.Width - IconsMenu._32_Black_Home.Width) / 2,
                (icon.Height - IconsMenu._32_Black_Home.Height) / 2,
                IconsMenu._32_Black_Home.Width, IconsMenu._32_Black_Home.Height
            );

            graphics        =   Graphics.FromImage( icon );
            graphics.DrawImage( IconsMenu._48_Press, 0, 0, icon.Width, icon.Height );
            button.Image    =   icon;

            // --- Icon Home ---
            if ( button.Name == "buttonHome" ) {
                switch ( options ) {
                    case 0:
                        if ( darkMode ) { graphics.DrawImage( IconsMenu._32_Black_Main, dest, src, GraphicsUnit.Pixel ); }
                        else { graphics.DrawImage( IconsMenu._32_White_Main, dest, src, GraphicsUnit.Pixel ); }
                        break;
                    case 1:
                        if ( darkMode ) { graphics.DrawImage( IconsMenu._32_Black_PlayList, dest, src, GraphicsUnit.Pixel ); }
                        else { graphics.DrawImage( IconsMenu._32_White_PlayList, dest, src, GraphicsUnit.Pixel ); }
                        break;
                }
                button.Image    =   icon;
            }
            // --- Icon Library ---
            else if ( button.Name == "buttonLibrary" ) {
                if ( darkMode ) { graphics.DrawImage( IconsMenu._32_Black_Library, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsMenu._32_White_Library, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon File Explorer ---
            else if ( button.Name == "buttonFileExplorer" ) {
                if ( darkMode ) { graphics.DrawImage( IconsMenu._32_Black_Explorer, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsMenu._32_White_Explorer, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Karaoke ---
            else if ( button.Name == "buttonKaraoke" ) {
                if ( darkMode ) { graphics.DrawImage( IconsMenu._32_Black_Karaoke, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsMenu._32_White_Karaoke, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Equalizer ---
            else if ( button.Name == "buttonEqualizer" ) {
                if ( darkMode ) { graphics.DrawImage( IconsMenu._32_Black_Equalizer, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsMenu._32_White_Equalizer, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Settings ---
            else if ( button.Name == "buttonSettings" ) {
                if ( darkMode ) { graphics.DrawImage( IconsMenu._32_Black_Settings, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsMenu._32_White_Settings, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }

        }

        #endregion DrawMenuButtons
        // ######################################################################
        //  xxx     x   x   xxxxx   xxxxx    xxx    x   x    xxxx
        //  x  x    x   x     x       x     x   x   xx  x   x    
        //  xxxx    x   x     x       x     x   x   x x x    xxx 
        //  x   x   x   x     x       x     x   x   x  xx       x
        //  xxxx     xxx      x       x      xxx    x   x   xxxx 
        //
        //   xxx     xxx    x   x   xxxxx   xxxx     xxx    x    
        //  x   x   x   x   xx  x     x     x   x   x   x   x    
        //  x       x   x   x x x     x     xxxx    x   x   x    
        //  x   x   x   x   x  xx     x     x   x   x   x   x    
        //   xxx     xxx    x   x     x     x   x    xxx    xxxxx
        // ######################################################################
        #region DrawButtonsControl
        // ----------------------------------------------------------------------
        public static void ControlButtonDraw( Button button, bool darkMode, int[] options ) {
            Image       icon        =   new Bitmap( button.Width, button.Height );
            Graphics    graphics    =   Graphics.FromImage( icon );
            Rectangle   src         =   new Rectangle( 0, 0, IconsControl._32_Black_Play.Width, IconsControl._32_Black_Play.Height );
            Rectangle   dest        =   new Rectangle(
                (icon.Width - IconsControl._32_Black_Play.Width) / 2,
                (icon.Height - IconsControl._32_Black_Play.Height) / 2,
                IconsMenu._32_Black_Home.Width, IconsMenu._32_Black_Home.Height
            );

            graphics        =   Graphics.FromImage( icon );
            graphics.DrawImage( IconsControl._48_Active, 0, 0, icon.Width, icon.Height );
            button.Image    =   icon;

            // --- Icon Shuffle ---
            if ( button.Name == "buttonShuffle") {
                switch( options[3] ) {
                    case 0:
                        if ( darkMode ) { button.Image = IconsControl._32_Black_Shuffle; }
                        else { button.Image = IconsControl._32_White_Shuffle; }
                        break;
                    case 1:
                        if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Shuffle, dest, src, GraphicsUnit.Pixel ); }
                        else { graphics.DrawImage( IconsControl._32_White_Shuffle, dest, src, GraphicsUnit.Pixel ); }
                        button.Image    =   icon;
                        break;
                }
            }
            // --- Icon Repeat ---
            else if ( button.Name == "buttonRepeat") {
                switch( options[2] ) {
                    case 0:
                        if ( darkMode ) { button.Image = IconsControl._32_Black_Repeat; }
                        else { button.Image = IconsControl._32_White_Repeat; }
                        break;
                    case 1:
                        if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Repeat, dest, src, GraphicsUnit.Pixel ); }
                        else { graphics.DrawImage( IconsControl._32_White_Repeat, dest, src, GraphicsUnit.Pixel ); }
                        button.Image    =   icon;
                        break;
                }
            }
            // --- Icon Previous Track ---
            else if ( button.Name == "buttonPrevious") {
                if ( darkMode ) { button.Image = IconsControl._32_Black_Backward; }
                else { button.Image = IconsControl._32_White_Backward; }
            }
            // --- Icon Play/Pause ---
            else if ( button.Name == "buttonPlay") {
                switch( options[0] ) {
                    case 0:
                        if ( darkMode ) { button.Image = IconsControl._32_Black_Play; }
                        else { button.Image = IconsControl._32_White_Play; }
                        break;
                    case 1:
                        if ( darkMode ) { button.Image = IconsControl._32_Black_Pause; }
                        else { button.Image = IconsControl._32_White_Pause; }
                        break;
                }
            }
            // --- Icon Next Track ---
            else if ( button.Name == "buttonForward") {
                if ( darkMode ) { button.Image = IconsControl._32_Black_Forward; }
                else { button.Image = IconsControl._32_White_Forward; }
            }
            // --- Icon Stop ---
            else if ( button.Name == "buttonStop") {
                if ( darkMode ) { button.Image = IconsControl._32_Black_Stop; }
                else { button.Image = IconsControl._32_White_Stop; }
            }
            // --- Icon Volume Control ---
            else if ( button.Name == "buttonVolume") {
                switch( options[1] ) {
                    case 0:
                        if ( darkMode ) { button.Image = IconsControl._32_Black_Volume; }
                        else { button.Image = IconsControl._32_White_Volume; }
                        break;
                    case 1:
                        if ( darkMode ) { button.Image = IconsControl._32_Black_Mute; }
                        else { button.Image = IconsControl._32_White_Mute; }
                        break;
                }
            }

        }

        // ----------------------------------------------------------------------
        public static void ControlButtonHover( Button button, bool darkMode, int[] options ) {
            Image       icon        =   new Bitmap( button.Width, button.Height );
            Graphics    graphics    =   Graphics.FromImage( icon );
            Rectangle   src         =   new Rectangle( 0, 0, IconsControl._32_Black_Play.Width, IconsControl._32_Black_Play.Height );
            Rectangle   dest        =   new Rectangle(
                (icon.Width - IconsControl._32_Black_Play.Width) / 2,
                (icon.Height - IconsControl._32_Black_Play.Height) / 2,
                IconsControl._32_Black_Play.Width, IconsControl._32_Black_Play.Height
            );

            graphics        =   Graphics.FromImage( icon );
            graphics.DrawImage( IconsControl._48_Hover, 0, 0, icon.Width, icon.Height );

            // --- Icon Shuffle ---
            if ( button.Name == "buttonShuffle") {
                if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Shuffle, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsControl._32_White_Shuffle, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Repeat ---
            else if ( button.Name == "buttonRepeat") {
                if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Repeat, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsControl._32_White_Repeat, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Previous Track ---
            else if ( button.Name == "buttonPrevious") {
                if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Backward, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsControl._32_White_Backward, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Play/Pause ---
            else if ( button.Name == "buttonPlay") {
                switch( options[0] ) {
                    case 0:
                        if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Play, dest, src, GraphicsUnit.Pixel ); }
                        else { graphics.DrawImage( IconsControl._32_White_Play, dest, src, GraphicsUnit.Pixel ); }
                        break;
                    case 1:
                        if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Pause, dest, src, GraphicsUnit.Pixel ); }
                        else { graphics.DrawImage( IconsControl._32_White_Pause, dest, src, GraphicsUnit.Pixel ); }
                        break;
                }
                
                button.Image    =   icon;
            }
            // --- Icon Next Track ---
            else if ( button.Name == "buttonForward") {
                if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Forward, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsControl._32_White_Forward, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Stop ---
            else if ( button.Name == "buttonStop") {
                if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Stop, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsControl._32_White_Stop, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Volume Control ---
            else if ( button.Name == "buttonVolume") {
                switch( options[1] ) {
                    case 0:
                        if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Volume, dest, src, GraphicsUnit.Pixel ); }
                        else { graphics.DrawImage( IconsControl._32_White_Volume, dest, src, GraphicsUnit.Pixel ); }
                        break;
                    case 1:
                        if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Mute, dest, src, GraphicsUnit.Pixel ); }
                        else { graphics.DrawImage( IconsControl._32_White_Mute, dest, src, GraphicsUnit.Pixel ); }
                        break;
                }
                
                button.Image    =   icon;
            }

        }

        // ----------------------------------------------------------------------
        public static void ControlButtonPress( Button button, bool darkMode, int[] options ) {
            Image       icon        =   new Bitmap( button.Width, button.Height );
            Graphics    graphics    =   Graphics.FromImage( icon );
            Rectangle   src         =   new Rectangle( 0, 0, IconsControl._32_Black_Play.Width, IconsControl._32_Black_Play.Height );
            Rectangle   dest        =   new Rectangle(
                (icon.Width - IconsControl._32_Black_Play.Width) / 2,
                (icon.Height - IconsControl._32_Black_Play.Height) / 2,
                IconsControl._32_Black_Play.Width, IconsControl._32_Black_Play.Height
            );

            graphics        =   Graphics.FromImage( icon );
            graphics.DrawImage( IconsControl._48_Press, 0, 0, icon.Width, icon.Height );

            // --- Icon Shuffle ---
            if ( button.Name == "buttonShuffle") {
                if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Shuffle, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsControl._32_White_Shuffle, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Repeat ---
            else if ( button.Name == "buttonRepeat") {
                if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Repeat, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsControl._32_White_Repeat, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Previous Track ---
            else if ( button.Name == "buttonPrevious") {
                if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Backward, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsControl._32_White_Backward, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Play/Pause ---
            else if ( button.Name == "buttonPlay") {
                switch( options[0] ) {
                    case 0:
                        if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Play, dest, src, GraphicsUnit.Pixel ); }
                        else { graphics.DrawImage( IconsControl._32_White_Play, dest, src, GraphicsUnit.Pixel ); }
                        break;
                    case 1:
                        if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Pause, dest, src, GraphicsUnit.Pixel ); }
                        else { graphics.DrawImage( IconsControl._32_White_Pause, dest, src, GraphicsUnit.Pixel ); }
                        break;
                }
                
                button.Image    =   icon;
            }
            // --- Icon Next Track ---
            else if ( button.Name == "buttonForward") {
                if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Forward, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsControl._32_White_Forward, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Stop ---
            else if ( button.Name == "buttonStop") {
                if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Stop, dest, src, GraphicsUnit.Pixel ); }
                else { graphics.DrawImage( IconsControl._32_White_Stop, dest, src, GraphicsUnit.Pixel ); }
                button.Image    =   icon;
            }
            // --- Icon Volume Control ---
            else if ( button.Name == "buttonVolume") {
                switch( options[1] ) {
                    case 0:
                        if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Volume, dest, src, GraphicsUnit.Pixel ); }
                        else { graphics.DrawImage( IconsControl._32_White_Volume, dest, src, GraphicsUnit.Pixel ); }
                        break;
                    case 1:
                        if ( darkMode ) { graphics.DrawImage( IconsControl._32_Black_Mute, dest, src, GraphicsUnit.Pixel ); }
                        else { graphics.DrawImage( IconsControl._32_White_Mute, dest, src, GraphicsUnit.Pixel ); }
                        break;
                }
                
                button.Image    =   icon;
            }

        }

        #endregion DrawButtonsControl
        // ######################################################################
        //  xxx     x   x   xxxxx   xxxxx    xxx    x   x    xxxx
        //  x  x    x   x     x       x     x   x   xx  x   x    
        //  xxxx    x   x     x       x     x   x   x x x    xxx 
        //  x   x   x   x     x       x     x   x   x  xx       x
        //  xxxx     xxx      x       x      xxx    x   x   xxxx 
        //
        //  xxxx    x        xxx    x   x     x       xxxxx    xxxx   xxxxx
        //  x   x   x       x   x   x   x     x         x     x         x  
        //  xxxx    x       xxxxx    xxx      x         x      xxx      x  
        //  x       x       x   x     x       x         x         x     x  
        //  x       xxxxx   x   x     x       xxxxx   xxxxx   xxxx      x  
        // ######################################################################
        #region DrawButtonsPlayList
        // ----------------------------------------------------------------------
        public static void PlayListButtonDraw( Button button ) {
            
            // --- Icon PlayList Open ---
            if ( button.Name == "buttonPlayListOpen") {
                button.Image = IconsNavigation._32_Open;
            }
            // --- Icon PLayList Save ---
            else if ( button.Name == "buttonPlayListSave") {
                button.Image = IconsNavigation._32_Save;
            }
            // --- Icon PlayList Clear ---
            else if ( button.Name == "buttonPlayListDelete") {
                button.Image = IconsNavigation._32_Delete;
            }
            // --- Icon PlayList MoveUp ---
            else if ( button.Name == "buttonPlayListMoveUp") {
                button.Image = IconsNavigation._32_ArrowUp;
            }
            // --- Icon PlayList MoveDown ---
            else if ( button.Name == "buttonPlayListMoveDown") {
                button.Image = IconsNavigation._32_ArrowDown;
            }
            // --- Icon PlayList Sort ---
            else if ( button.Name == "buttonPlayListSort") {
                button.Image = IconsNavigation._32_Sort;
            }

        }

        // ----------------------------------------------------------------------
        public static void PlayListButtonHover( Button button ) {
            Image       icon        =   new Bitmap( button.Width, button.Height );
            Graphics    graphics    =   Graphics.FromImage( icon );
            Rectangle   src         =   new Rectangle( 0, 0, IconsNavigation._32_Home.Width, IconsNavigation._32_Home.Height );
            Rectangle   dest        =   new Rectangle(
                (icon.Width - IconsNavigation._32_Home.Width) / 2,
                (icon.Height - IconsNavigation._32_Home.Height) / 2,
                IconsNavigation._32_Home.Width, IconsNavigation._32_Home.Height
            );

            graphics        =   Graphics.FromImage( icon );

            // --- Icon PlayList Open ---
            if ( button.Name == "buttonPlayListOpen") {
                graphics.DrawImage( IconsNavigation._48_Hover, 0, 0, icon.Width, icon.Height );
                graphics.DrawImage( IconsNavigation._32_Open, dest, src, GraphicsUnit.Pixel );
                button.Image    =   icon;
            }
            // --- Icon PLayList Save ---
            else if ( button.Name == "buttonPlayListSave") {
                graphics.DrawImage( IconsNavigation._48_Hover, 0, 0, icon.Width, icon.Height );
                graphics.DrawImage( IconsNavigation._32_Save, dest, src, GraphicsUnit.Pixel );
                button.Image    =   icon;
            }
            // --- Icon PlayList Clear ---
            else if ( button.Name == "buttonPlayListDelete") {
                graphics.DrawImage( IconsNavigation._48_Hover, 0, 0, icon.Width, icon.Height );
                graphics.DrawImage( IconsNavigation._32_Delete, dest, src, GraphicsUnit.Pixel );
                button.Image    =   icon;
            }
            // --- Icon PlayList MoveUp ---
            else if ( button.Name == "buttonPlayListMoveUp") {
                graphics.DrawImage( IconsNavigation._48_Hover, 0, 0, icon.Width, icon.Height );
                graphics.DrawImage( IconsNavigation._32_ArrowUp, dest, src, GraphicsUnit.Pixel );
                button.Image    =   icon;
            }
            // --- Icon PlayList MoveDown ---
            else if ( button.Name == "buttonPlayListMoveDown") {
                graphics.DrawImage( IconsNavigation._48_Hover, 0, 0, icon.Width, icon.Height );
                graphics.DrawImage( IconsNavigation._32_ArrowDown, dest, src, GraphicsUnit.Pixel );
                button.Image    =   icon;
            }
            // --- Icon PlayList Sort ---
            else if ( button.Name == "buttonPlayListSort") {
                graphics.DrawImage( IconsNavigation._48_Hover, 0, 0, icon.Width, icon.Height );
                graphics.DrawImage( IconsNavigation._32_Sort, dest, src, GraphicsUnit.Pixel );
                button.Image    =   icon;
            }

        }

        // ----------------------------------------------------------------------
        public static void PlayListButtonPress( Button button ) {
            Image       icon        =   new Bitmap( button.Width, button.Height );
            Graphics    graphics    =   Graphics.FromImage( icon );
            Rectangle   src         =   new Rectangle( 0, 0, IconsNavigation._32_Home.Width, IconsNavigation._32_Home.Height );
            Rectangle   dest        =   new Rectangle(
                (icon.Width - IconsNavigation._32_Home.Width) / 2,
                (icon.Height - IconsNavigation._32_Home.Height) / 2,
                IconsNavigation._32_Home.Width, IconsNavigation._32_Home.Height
            );

            graphics        =   Graphics.FromImage( icon );

            // --- Icon PlayList Open ---
            if ( button.Name == "buttonPlayListOpen") {
                graphics.DrawImage( IconsNavigation._48_Press, 0, 0, icon.Width, icon.Height );
                graphics.DrawImage( IconsNavigation._32_Open, dest, src, GraphicsUnit.Pixel );
                button.Image    =   icon;
            }
            // --- Icon PLayList Save ---
            else if ( button.Name == "buttonPlayListSave") {
                graphics.DrawImage( IconsNavigation._48_Press, 0, 0, icon.Width, icon.Height );
                graphics.DrawImage( IconsNavigation._32_Save, dest, src, GraphicsUnit.Pixel );
                button.Image    =   icon;
            }
            // --- Icon PlayList Clear ---
            else if ( button.Name == "buttonPlayListDelete") {
                graphics.DrawImage( IconsNavigation._48_Press, 0, 0, icon.Width, icon.Height );
                graphics.DrawImage( IconsNavigation._32_Delete, dest, src, GraphicsUnit.Pixel );
                button.Image    =   icon;
            }
            // --- Icon PlayList MoveUp ---
            else if ( button.Name == "buttonPlayListMoveUp") {
                graphics.DrawImage( IconsNavigation._48_Press, 0, 0, icon.Width, icon.Height );
                graphics.DrawImage( IconsNavigation._32_ArrowUp, dest, src, GraphicsUnit.Pixel );
                button.Image    =   icon;
            }
            // --- Icon PlayList MoveDown ---
            else if ( button.Name == "buttonPlayListMoveDown") {
                graphics.DrawImage( IconsNavigation._48_Press, 0, 0, icon.Width, icon.Height );
                graphics.DrawImage( IconsNavigation._32_ArrowDown, dest, src, GraphicsUnit.Pixel );
                button.Image    =   icon;
            }
            // --- Icon PlayList Sort ---
            else if ( button.Name == "buttonPlayListSort") {
                graphics.DrawImage( IconsNavigation._48_Press, 0, 0, icon.Width, icon.Height );
                graphics.DrawImage( IconsNavigation._32_Sort, dest, src, GraphicsUnit.Pixel );
                button.Image    =   icon;
            }

        }

        #endregion DrawButtonsPlayList
        // ######################################################################
        //  xxx     x   x   xxxxx   xxxxx    xxx    x   x    xxxx
        //  x  x    x   x     x       x     x   x   xx  x   x    
        //  xxxx    x   x     x       x     x   x   x x x    xxx 
        //  x   x   x   x     x       x     x   x   x  xx       x
        //  xxxx     xxx      x       x      xxx    x   x   xxxx 
        //
        //  xxxx    xxxxx    xxx    xxxxx   x   x   xxxx    xxxxx     xxx      xxx    x   x
        //  x   x     x     x   x     x     x   x   x   x   x         x  x    x   x    x x 
        //  xxxx      x     x         x     x   x   xxxx    xxxx      xxxx    x   x     x  
        //  x         x     x   x     x     x   x   x   x   x         x   x   x   x    x x 
        //  x       xxxxx    xxx      x      xxx    x   x   xxxxx     xxxx     xxx    x   x
        // ######################################################################
        #region DrawButtonsPictureBox
        // ----------------------------------------------------------------------
        private static void PictureBoxWallaperDrawBack( PictureBox pb, string imagePath ) {
            Image       image       =   new Bitmap( pb.Width, pb.Height );
            Graphics    graphics    =   Graphics.FromImage( image );
            Rectangle   imageDest   =   new Rectangle( 0, 0, pb.Width, pb.Height );
            graphics.FillRectangle( new SolidBrush( Color.Black ), imageDest );

            try {
                Image       wallpaper       =   new Bitmap( imagePath );
                Rectangle   wallpaperSrc    =   new Rectangle( 0, 0, wallpaper.Width, wallpaper.Height );
                graphics.DrawImage( wallpaper, imageDest, wallpaperSrc, GraphicsUnit.Pixel );
            } catch ( Exception exc ) {
                System.Console.WriteLine( exc.ToString() );
            }

            pb.Image    =   image;
        }

        // ----------------------------------------------------------------------
        private static void PictureBoxWallpaperDrawIcon( PictureBox pb ) {
            Graphics    graphics    =   Graphics.FromImage( pb.Image );
            Rectangle   src         =   new Rectangle( 0, 0, IconsNavigation._32_Open.Width, IconsNavigation._32_Open.Height );
            Rectangle   dest        =   new Rectangle(
                pb.Width - 40, pb.Height - 40,
                IconsNavigation._32_Open.Width, IconsNavigation._32_Open.Height
            );
            graphics.DrawImage( IconsNavigation._32_Open, dest, src, GraphicsUnit.Pixel );
        }

        // ----------------------------------------------------------------------
        private static void PictureBoxWallpaperDrawHover( PictureBox pb ) {
            Graphics    graphics    =   Graphics.FromImage( pb.Image );
            Rectangle   src         =   new Rectangle( 0, 0, IconsNavigation._48_Hover.Width, IconsNavigation._48_Hover.Height );
            Rectangle   dest        =   new Rectangle(
                pb.Width - 48, pb.Height - 48,
                IconsNavigation._48_Hover.Width, IconsNavigation._48_Hover.Height
            );
            graphics.DrawImage( IconsNavigation._48_Hover, dest, src, GraphicsUnit.Pixel );
        }

        // ----------------------------------------------------------------------
        private static void PictureBoxWallpaperDrawPress( PictureBox pb ) {
            Graphics    graphics    =   Graphics.FromImage( pb.Image );
            Rectangle   src         =   new Rectangle( 0, 0, IconsNavigation._48_Press.Width, IconsNavigation._48_Press.Height );
            Rectangle   dest        =   new Rectangle(
                pb.Width - 48, pb.Height - 48,
                IconsNavigation._48_Press.Width, IconsNavigation._48_Press.Height
            );
            graphics.DrawImage( IconsNavigation._48_Press, dest, src, GraphicsUnit.Pixel );
        }

        // ----------------------------------------------------------------------
        public static void PictureBoxWallpaperDraw( PictureBox pb, string imagePath ) {
            PictureBoxWallaperDrawBack( pb, imagePath );
            PictureBoxWallpaperDrawIcon( pb );
        }

        // ----------------------------------------------------------------------
        public static void PictureBoxWallpaperHover( PictureBox pb, string imagePath ) {
            PictureBoxWallpaperDraw( pb, imagePath );
            PictureBoxWallpaperDrawIcon( pb );
            PictureBoxWallpaperDrawHover( pb );
        }

        // ----------------------------------------------------------------------
        public static void PictureBoxWallpaperPress( PictureBox pb, string imagePath ) {
            PictureBoxWallpaperDraw( pb, imagePath );
            PictureBoxWallpaperDrawIcon( pb );
            PictureBoxWallpaperDrawPress( pb );
        }

        #endregion DrawButtonsPictureBox
        // ######################################################################
    }

    // ################################################################################
}
