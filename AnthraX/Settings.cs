using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnthraX {

    // ################################################################################
    //   xxxx   xxxxx   xxxxx   xxxxx   xxxxx   x   x    xxxx    xxxx
    //  x       x         x       x       x     xx  x   x       x    
    //   xxx    xxxx      x       x       x     x x x   x  xx    xxx 
    //      x   x         x       x       x     x  xx   x   x       x
    //  xxxx    xxxxx     x       x     xxxxx   x   x    xxxx   xxxx 
    // ################################################################################
    public static class Settings {

        public  delegate    void UseCustomThemeColor( bool check, string colorName, Color color );

        // ######################################################################
        //   xxxx   xxxxx   xxxxx      xxx    xxx     xxxxx   xxxxx    xxx    xxxxx
        //  x       x         x       x   x   x  x       x    x       x   x     x  
        //   xxx    xxxx      x       x   x   xxxx       x    xxxx    x         x  
        //      x   x         x       x   x   x   x   x  x    x       x   x     x  
        //  xxxx    xxxxx     x        xxx    xxxx     xx     xxxxx    xxx      x  
        // ######################################################################

        // ----------------------------------------------------------------------
        //  xxxxx   x   x   xxxxx   x   x   xxxxx
        //    x     x   x   x       xx xx   x    
        //    x     xxxxx   xxxx    x x x   xxxx 
        //    x     x   x   x       x   x   x    
        //    x     x   x   xxxxx   x   x   xxxxx
        // ----------------------------------------------------------------------
        public static void SetObjThemeType( ComboBox cb, int index ) {
            if ( index < 0 || index >= cb.Items.Count ) {
                cb.SelectedItem =   cb.Items[ 0 ];
                return;
            }
            cb.SelectedItem     =   cb.Items[ index ];
        }

        // ----------------------------------------------------------------------
        public static void SetObjThemeColor( ComboBox cb, string colorName ) {
            if ( cb.Items.Contains( colorName ) ) {
                int index           =   cb.Items.IndexOf( colorName );
                cb.SelectedItem     =   cb.Items[ index ];
            } else if ( cb.Items.Count > 0 ) {
                cb.SelectedItem     =   cb.Items[ 8 ];
            }
        }

        // ----------------------------------------------------------------------
        public static void SetObjUseCustomThemeColor( CheckBox cb, bool check ) {
            cb.Checked = check;
        }

        // ----------------------------------------------------------------------
        public static void SetObjCustomThemeColor( FlowLayoutPanel panel, Color color ) {
            panel.BackColor = color;
        }

        // ----------------------------------------------------------------------
        public static void SetObjThemeWallpaper( ComboBox cb, int index ) {
            if ( index < 0 || index >= cb.Items.Count ) {
                cb.SelectedItem =   cb.Items[ 3 ];
                return;
            }
            cb.SelectedItem     =   cb.Items[ index ];
        }

        // ----------------------------------------------------------------------
        public static void SetObjThemeWallpaperCustomImage( PictureBox pb, string path ) {
            if ( File.Exists( path ) ) {
                try {
                    pb.Image    =   new Bitmap( path );
                } catch ( Exception exc ) {
                    System.Console.WriteLine( exc.ToString() );
                }
            }
        }

        // ----------------------------------------------------------------------
        public static void SetObjThemeWallpaperPosition( ComboBox cb, int index ) {
            if ( index < 0 || index >= cb.Items.Count ) {
                cb.SelectedItem =   cb.Items[ 4 ];
                return;
            }
            cb.SelectedItem     =   cb.Items[ index ];
        }

        // ----------------------------------------------------------------------
        public static void SetObjThemeTransparency( TrackBar tb, int value ) {
            if ( value >= tb.Minimum && value <= tb.Maximum ) {
                tb.Value    =   value;
            }
        }

        // ----------------------------------------------------------------------
        //   xxxx   xxxx    xxxxx    xxx    xxxxx   xxxx    x   x   x   x
        //  x       x   x   x       x   x     x     x   x   x   x   xx xx
        //   xxx    xxxx    xxxx    x         x     xxxx    x   x   x x x
        //      x   x       x       x   x     x     x   x   x   x   x   x
        //  xxxx    x       xxxxx    xxx      x     x   x    xxx    x   x
        // ----------------------------------------------------------------------
        public static void SetObjectVisualisationType( ComboBox cb, int index ) {
            if ( index < 0 || index >= cb.Items.Count ) {
                cb.SelectedItem =   cb.Items[ 2 ];
                return;
            }
            cb.SelectedItem     =   cb.Items[ index ];
        }

        // ----------------------------------------------------------------------
        public static void SetObjectVisualisationSize( TrackBar tb, int index ) {
            if ( index >= tb.Minimum && index <= tb.Maximum ) {
                tb.Value    =   index;
            }
        }

        // ----------------------------------------------------------------------
        public static void SetObjectVisualisationLogo( ComboBox cb, int index ) {
            if ( index < 0 || index >= cb.Items.Count ) {
                cb.SelectedItem =   cb.Items[ 1 ];
                return;
            }
            cb.SelectedItem     =   cb.Items[ index ];
        }

        // ----------------------------------------------------------------------
        public static void SetObjectVisualisationColorScheme( ComboBox cb, int index ) {
            if ( index < 0 || index >= cb.Items.Count ) {
                cb.SelectedItem =   cb.Items[ 0 ];
                return;
            }
            cb.SelectedItem     =   cb.Items[ index ];
        }

        // ----------------------------------------------------------------------
        public static void SetObjectVisualisationColor( ComboBox cb, string colorName ) {
            if ( cb.Items.Contains( colorName ) ) {
                int index           =   cb.Items.IndexOf( colorName );
                cb.SelectedItem     =   cb.Items[ index ];
            } else if ( cb.Items.Count > 0 ) {
                cb.SelectedItem     =   cb.Items[ 8 ];
            }
        }

        // ----------------------------------------------------------------------
        public static void SetObjectCustomVisualisationColor( FlowLayoutPanel panel, Color color ) {
            panel.BackColor = color;
        }

        // ----------------------------------------------------------------------
        public static void SetObjectVisualisationRainbowSpeed( TrackBar tb, int speed ) {
            if ( speed >= tb.Minimum && speed <= tb.Maximum ) {
                tb.Value    =   speed;
            }
        }

        // ----------------------------------------------------------------------
        public static void SetObjectVisualisationRainbowColor( TrackBar tb, int color ) {
            if ( color >= tb.Minimum && color <= tb.Maximum ) {
                tb.Value    =   color;
            }
        }

        // ----------------------------------------------------------------------
        public static void SetObjectVisualisationTransparency( TrackBar tb, int value ) {
            if ( value >= tb.Minimum && value <= tb.Maximum ) {
                tb.Value    =   value;
            }
        }

        // ----------------------------------------------------------------------
        public static void SetObjectVisualisationFill( ComboBox cb, int index ) {
            if ( index < 0 || index >= cb.Items.Count ) {
                cb.SelectedItem =   cb.Items[ 0 ];
                return;
            }
            cb.SelectedItem     =   cb.Items[ index ];
        }

        // ----------------------------------------------------------------------
        public static void SetObjectVisualisationSensitivity( TrackBar tb, int index ) {
            if ( index >= tb.Minimum && index <= tb.Maximum ) {
                tb.Value    =   index;
            }
        }

        // ----------------------------------------------------------------------
        //  xxxx    x        xxx    x   x   xxxxx   xxxx 
        //  x   x   x       x   x   x   x   x       x   x
        //  xxxx    x       xxxxx    xxx    xxxx    xxxx 
        //  x       x       x   x     x     x       x   x
        //  x       xxxxx   x   x     x     xxxxx   x   x
        // ----------------------------------------------------------------------
        public static void SetObjectPlayerInformationTimeout( TrackBar tb, int value ) {
            if ( value >= tb.Minimum && value <= tb.Maximum ) {
                tb.Value    =   value;
            }
        }

        // ----------------------------------------------------------------------
        //  xxxxx   xxxxx   x       xxxxx     x   x    xxx    x   x    xxx     xxxx   xxxxx   xxxx 
        //  x         x     x       x         xx xx   x   x   xx  x   x   x   x       x       x   x
        //  xxxx      x     x       xxxx      x x x   xxxxx   x x x   xxxxx   x  xx   xxxx    xxxx 
        //  x         x     x       x         x   x   x   x   x  xx   x   x   x   x   x       x   x
        //  x       xxxxx   xxxxx   xxxxx     x   x   x   x   x   x   x   x    xxxx   xxxxx   x   x
        // ----------------------------------------------------------------------
        public static void SetObjectExplorerView( TrackBar tb, int value ) {
            if ( value >= tb.Minimum && value <= tb.Maximum ) {
                tb.Value    =   value;
            }
        }

        // ----------------------------------------------------------------------
        //  xxxxx    xxx    x   x    xxx    x       xxxxx   xxxxx   xxxxx   xxxx 
        //  x       x   x   x   x   x   x   x         x        x    x       x   x
        //  xxxx    x x x   x   x   xxxxx   x         x       x     xxxx    xxxx 
        //  x       x  xx   x   x   x   x   x         x      x      x       x   x
        //  xxxxx    xxx     xxx    x   x   xxxxx   xxxxx   xxxxx   xxxxx   x   x
        // ----------------------------------------------------------------------
        public static object[] SetObjectEqualizerPreset( TreeView tv, int value ) {
            string  result  =   Tools.equalizerPresetsName[0];
            int     index   =   0;

            if ( tv.Nodes.Count > 0 ) {
                TreeNode ptn = tv.Nodes[0];
                if ( value <= 11 ) {
                    result  =   Tools.equalizerPresetsName[value];
                    index   =   value;
                } else if ( value < ptn.Nodes.Count ) {
                    result  =   ptn.Nodes[value].Text;
                    index   =   value;
                }
            }

            return new object[] { index, result };
        }

        // ----------------------------------------------------------------------
        public static object[] SetObjectEqualizerEffect( TreeView tv, int value ) {
            string  result  =   Tools.equalizerEffectsName[0];
            int     index   =   0;

            if ( tv.Nodes.Count > 1 ) {
                TreeNode ptn = tv.Nodes[1];
                if ( value <= 0 ) {
                    result  =   Tools.equalizerEffectsName[value];
                    index   =   value;
                } else if ( value < ptn.Nodes.Count ) {
                    result  =   ptn.Nodes[value].Text;
                    index   =   value;
                }
            }

            return new object[] { index, result };
        }

        // ######################################################################
        //   xxxx   xxxxx   xxxxx     xxxx     xxx    xxxxx    xxx 
        //  x       x         x        x  x   x   x     x     x   x
        //   xxx    xxxx      x        x  x   xxxxx     x     xxxxx
        //      x   x         x        x  x   x   x     x     x   x
        //  xxxx    xxxxx     x       xxxx    x   x     x     x   x
        // ######################################################################

        // ----------------------------------------------------------------------
        //  xxxxx   x   x   xxxxx   x   x   xxxxx
        //    x     x   x   x       xx xx   x    
        //    x     xxxxx   xxxx    x x x   xxxx 
        //    x     x   x   x       x   x   x    
        //    x     x   x   xxxxx   x   x   xxxxx
        // ----------------------------------------------------------------------
        public static void SetDataThemeType( ThemeType type ) {
            InterfaceDrawer.themeType   =   type;
        }

        // ----------------------------------------------------------------------
        public static void SetDataThemeColor( string colorName ) {
            try {
                Color   color                   =   Color.FromName( colorName );
                InterfaceDrawer.controlsColor   =   color;
            } catch ( Exception exc ) {
                System.Console.WriteLine( exc.ToString() );
                InterfaceDrawer.controlsColor   =   Color.Black;
            }
        }

        // ----------------------------------------------------------------------
        public static void SetDataThemeColor( Color color ) {
            InterfaceDrawer.controlsColor   =   color;
        }

        // ----------------------------------------------------------------------
        public static void SetDataThemeCustomColor( Color color ) {
            Color   newColor    =   Tools.ColorSelector( color );
            SetDataThemeColor( newColor );
        }

        // ----------------------------------------------------------------------
        public static void SetDataThemeWallpaper( WallpaperType type ) {
            InterfaceDrawer.backgroundType  =   type;
        }

        // ----------------------------------------------------------------------
        public static void SetDataThemeWallpaperColor( string colorName ) {
            try {
                Color   color                       =   Color.FromName( colorName );
                InterfaceDrawer.backgroundColor     =   color;
            } catch ( Exception exc ) {
                System.Console.WriteLine( exc.ToString() );
                InterfaceDrawer.backgroundColor     =   Color.Black;
            }
        }

        // ----------------------------------------------------------------------
        public static void SetDataThemeWallpaperColor( Color color ) {
            InterfaceDrawer.backgroundColor     =   color;
        }

        // ----------------------------------------------------------------------
        public static void SetDataThemeWallpaperCustomColor( Color color ) {
            Color   newColor    =   Tools.ColorSelector( color );
            SetDataThemeWallpaperColor( newColor );
        }

        // ----------------------------------------------------------------------
        public static void SetDataThemeWallpaperImage( int index, string path ) {
            switch ( index ) {
                case 2:
                    InterfaceDrawer.background  =   new Bitmap( Properties.Resources._105358_darkness_2560x1600_LicUnknown );
                    break;
                case 3:
                    InterfaceDrawer.background  =   new Bitmap( Properties.Resources._411175_miroha_2880x1800_LicUnknown );
                    break;
                case 4:
                    InterfaceDrawer.background  =   new Bitmap( Properties.Resources._70937_AlphaSystem_1920x1200_LicUnknown );
                    break;
                case 5:
                    InterfaceDrawer.background  =   new Bitmap( Properties.Resources._87577_7rev_Random_1920x1080_LicUnknown );
                    break;
                case 6:
                    SetDataThemeWallpaperCustomImage( path );
                    break;
                default:
                    InterfaceDrawer.background  =   new Bitmap( Properties.Resources._284301_TorinoGT_FantasyAndSciFi_1948x1096_LicUnknown );
                    break;
            }
        }

        // ----------------------------------------------------------------------
        public static void SetDataThemeWallpaperCustomImage( PictureBox pb, string initPath, out string path ) {
            string  filePath    =   Tools.PictureSelector( initPath );

            try {
                pb.Image    =   Image.FromFile( filePath );
                path        =   filePath;
            } catch ( Exception exc ) {
                System.Console.WriteLine( exc.ToString() );
                path        =   "";
            }
        }

        // ----------------------------------------------------------------------
        public static void SetDataThemeWallpaperCustomImage( string path ) {
            try {
                InterfaceDrawer.background  =   new Bitmap( path );
            } catch ( Exception exc ) {
                System.Console.WriteLine( exc.ToString() );
            }
        }

        // ----------------------------------------------------------------------
        public static void SetDataThemeWallpaperSystem() {
            InterfaceDrawer.background      =   Tools.GetSystemWallpaper();
        }

        // ----------------------------------------------------------------------
        public static void SetDataThemeWallpaperPosition( WallpaperDrawType position ) {
            InterfaceDrawer.backgroundDrawType  =   position;
        }

        // ----------------------------------------------------------------------
        public static void SetDataThemeTransparency( int alpha ) {
            InterfaceDrawer.controlAlpha    =   alpha;
        }

        // ----------------------------------------------------------------------
        //   xxxx   xxxx    xxxxx    xxx    xxxxx   xxxx    x   x   x   x
        //  x       x   x   x       x   x     x     x   x   x   x   xx xx
        //   xxx    xxxx    xxxx    x         x     xxxx    x   x   x x x
        //      x   x       x       x   x     x     x   x   x   x   x   x
        //  xxxx    x       xxxxx    xxx      x     x   x    xxx    x   x
        // ----------------------------------------------------------------------
        public static void SetDataVisualisationType( Spectrum spec, SpectrumType type ) {
            if ( spec.animSpecEnabled ) {
                spec.AnimSpecShowInit( type );
            } else {
                spec.type   =   type;
            }
        }

        // ----------------------------------------------------------------------
        public static void SetDataVisualisationSize( Spectrum spec, int value ) {
            spec.UpdateSpectrumSize( value );
        }

        // ----------------------------------------------------------------------
        public static void SetDataVisualisationLogo( Spectrum spec, SpectrumLogo logo ) {
            spec.logo   =   logo;
        }

        // ----------------------------------------------------------------------
        public static void SetDataVisualisationColorScheme( Spectrum spec, SpectrumFillType type ) {
            spec.fillType   =   type;
            DataStructures.RainbowColor.resetColor();
        }

        // ----------------------------------------------------------------------
        public static void SetDataVisualisationColor( Spectrum spec, string colorName ) {
            Color   color   =   Color.Black;
            try {
                color   =   Color.FromName( colorName );
            } catch ( Exception exc ) {
                System.Console.WriteLine( exc.ToString() );
            }
            spec.borderColor    =   color;
            spec.fillColor      =   color;
        }

        // ----------------------------------------------------------------------
        public static void SetDataVisualisationColor( Spectrum spec, Color color ) {
            spec.borderColor    =   color;
            spec.fillColor      =   color;
        }

        // ----------------------------------------------------------------------
        public static void SetDataCustomVisualisationColor( Spectrum spec, Color color ) {
            Color   newColor    =   Tools.ColorSelector( color );
            SetDataVisualisationColor( spec, newColor );
        }

        // ----------------------------------------------------------------------
        public static void SetDataVisualisationRainbowSpeed( Spectrum spec, int speed ) {
            spec.rainbowTime    =   speed / 100f;
        }

        // ----------------------------------------------------------------------
        public static void SetDataVisualisationRainbowColor( Spectrum spec, int color ) {
            spec.rainbowColor   =   color;
        }

        // ----------------------------------------------------------------------
        public static void SetDataVisualisationTransparency( Spectrum spec, int value ) {
            spec.alphaColor     =   value;
        }

        // ----------------------------------------------------------------------
        public static void SetDataVisualisationFill( Spectrum spec, SpectrumFillStyle fill ) {
            spec.fillStyle      =   fill;
        }

        // ----------------------------------------------------------------------
        public static void SetDataVisualisationSensitivity( Spectrum spec, int value ) {
            spec.sensitivity    =   value;
        }

        // ----------------------------------------------------------------------
        //  xxxx    x        xxx    x   x   xxxxx   xxxx 
        //  x   x   x       x   x   x   x   x       x   x
        //  xxxx    x       xxxxx    xxx    xxxx    xxxx 
        //  x       x       x   x     x     x       x   x
        //  x       xxxxx   x   x     x     xxxxx   x   x
        // ----------------------------------------------------------------------
        public static void SetDataPlayerInformationTimeout( Spectrum spec, int time ) {
            spec.infoTimeOut    =   time;
        }

        // ----------------------------------------------------------------------
        public static void SetDataPlayerNotification( NotifyIcon ni, bool enabled ) {
            ni.Visible  =   enabled;
        }

        // ----------------------------------------------------------------------
        //   xxxx   xxxxx   x   x   xxxxx   xxxx     xxx    x    
        //  x       x       xx  x   x       x   x   x   x   x    
        //  x  xx   xxxx    x x x   xxxx    xxxx    xxxxx   x    
        //  x   x   x       x  xx   x       x   x   x   x   x    
        //   xxxx   xxxxx   x   x   xxxxx   x   x   x   x   xxxxx
        // ----------------------------------------------------------------------
        public static void SetDataGeneralAnimSpec( Spectrum spec, bool enabled ) {
            spec.animSpecEnabled    =   enabled;
        }

        // ----------------------------------------------------------------------
        //  xxxxx   xxxxx   x       xxxxx     x   x    xxx    x   x    xxx     xxxx   xxxxx   xxxx 
        //  x         x     x       x         xx xx   x   x   xx  x   x   x   x       x       x   x
        //  xxxx      x     x       xxxx      x x x   xxxxx   x x x   xxxxx   x  xx   xxxx    xxxx 
        //  x         x     x       x         x   x   x   x   x  xx   x   x   x   x   x       x   x
        //  x       xxxxx   xxxxx   xxxxx     x   x   x   x   x   x   x   x    xxxx   xxxxx   x   x
        // ----------------------------------------------------------------------
        public static void SetDataExplorerView( ListView lv, int index ) {
            switch( index ) {
                case 0: lv.View     =   View.SmallIcon;     break;
                case 1: lv.View     =   View.List;          break;
                case 2: lv.View     =   View.Tile;          break;
                case 3: lv.View     =   View.LargeIcon;     break;
            }
        }

        // ######################################################################
    }

    // ################################################################################
}
