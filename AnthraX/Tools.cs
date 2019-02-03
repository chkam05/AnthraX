using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnthraX {

    /*
     * Informacje dotyczące kolorów
     * System Hover : 229; 243; 255
     * System Press : 204; 232; 255
     * System Checked : 217; 217; 217
     * System Border : 153; 209; 255
    */

    // ################################################################################
    //  xxxxx    xxx     xxx    x        xxxx
    //    x     x   x   x   x   x       x    
    //    x     x   x   x   x   x        xxx 
    //    x     x   x   x   x   x           x
    //    x      xxx     xxx    xxxxx   xxxx 
    // ################################################################################

    public static class Tools {

        public  delegate            bool        MsgBoxFunction( object[] obj );

        public  static  readonly    string[]    fileTypeMusic       =   { ".mp3", ".ogg", ".wav" };
        public  static  readonly    string[]    fileTypeImage       =   { ".bmp", ".gif", ".jpeg", ".jpg", "png" };
        public  static  readonly    string[]    fileTypeVideo       =   { ".avi", ".mp4", ".wmv" };
        public  static  readonly    string[]    fileTypeText        =   { ".txt" };
        public  static  readonly    string[]    fileTypeKaraoke     =   { ".txt" };
        public  static  readonly    string[]    fileTypePlaylist    =   { ".apl" };
        //public  static  readonly    string[]    fileTypePreset      =   { ".aep" };
        //public  static  readonly    string[]    fileTypeEffects     =   { ".aef" };

        public  static  readonly    string[]    equalizerPresetInfo     =   {
            "50Hz", "2kHz", "4kHz", "6kHz", "8kHz", "10kHz", "12kHz", "14kHz", "16kHz", "18kHz", "20kHz"
        };
        public  static  readonly    string[]    equalizerPresetsName    =   {
            "Default", "Bass", "Dance", "Live", "Pop", "Power", "Rock", "Treble", "Vocal", "Xplode 1", "Xplode 2", "Xplode 3"
        };
        public  static  readonly    int[]       equalizerFCenter        =   {
            80, 170, 310, 600, 1000, 3000, 7000, 12000, 14000, 16000
        };
        public  static  readonly    int[,]      equalizerPresets        =   {
            { 0, 0,  0, 0,  0,  0, 0, 0, 0, 0 },    // default
            { 5, 5,  5, 4,  4,  3, 2, 1, 0, 0 },    // bass
            { 4, 4,  3, 2,  2,  1, 0, 0, 1, 2 },    // dance
            { 0, 0,  1, 2,  3,  3, 2, 1, 0, 0 },    // live
            { 1, 1,  3, 4,  5,  4, 3, 1, 0, 0 },    // pop
            { 3, 4,  4, 2, -2, -1, 0, 1, 2, 2 },    // power
            { 3, 3,  2, 1,  0,  1, 2, 3, 3, 3 },    // rock
            { 0, 0,  0, 1,  2,  3, 4, 4, 5, 5 },    // treble
            { 2, 2,  4, 4,  4,  2, 0, 0, 0, 0 },    // vocal
            { 5, 5,  5, 4,  3,  2, 3, 4, 5, 5 },    // xplode 1
            { 4, 4,  4, 6,  4,  2, 2, 4, 4, 2 },    // xplode 2
            { 6, 8, 10, 3,  1,  3, 4, 5, 4, 1 }     // xplode 3
        };

        public  static  readonly    string[]    equalizerEffectsName    =   {
            "Default",
        };
        public  static  readonly    int[,]      equalizerEffects        =   {
            { 0, 0, 50, 50, 0, 300, 70, 0, 24576, 50, 70, 0, 0, 0, 0, 0, 0 },     // no effect
        };

        // ######################################################################
        //   xxxx   x   x    xxxx   xxxxx   xxxxx   x   x
        //  x       x   x   x         x     x       xx xx
        //   xxx     xxx     xxx      x     xxxx    x x x
        //      x     x         x     x     x       x   x
        //  xxxx      x     xxxx      x     xxxxx   x   x
        //
        //  x   x   xxxxx   xxxx     xxxx   xxxxx    xxx    x   x
        //  x   x   x       x   x   x         x     x   x   xx  x
        //  x   x   xxxx    xxxx     xxx      x     x   x   x x x
        //   x x    x       x   x       x     x     x   x   x  xx
        //    x     xxxxx   x   x   xxxx    xxxxx    xxx    x   x
        // ######################################################################
        /// <summary> Funkcja zwracająca informację o tym, w jakiej wersji systemu Windows uruchomiona jest aplikacja. </summary>
        /// <returns> Tablica z numerami wersji (major, minor, build, revision). </returns>
        public static int[] GetSystemVersion() {
            OperatingSystem os  =   Environment.OSVersion;
            int major       =   os.Version.Major;
            int minor       =   os.Version.Minor;
            int build       =   os.Version.Build;
            int revision    =   os.Version.Revision;
            string  ver     =   os.VersionString;

            return new int[] { major, minor, build, revision };
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zwracająca informację o tym, w jakiej wersji systemu Windows uruchomiona jest aplikacja. </summary>
        /// <returns> Nazwa wersji systemu Windows. </returns>
        public static string GetSystemVersionName() {
            int[]   osVersion   =   GetSystemVersion();

            switch( osVersion[0] ) {
                case 4:
                    switch ( osVersion[1] ) {
                        case 0:
                            return "Windows 95";
                        case 10:
                            return "Windows 98";
                        case 90:
                            return "Windows Me";
                        default:
                            return "Unknown Windows Version";
                    }
                case 5:
                    switch ( osVersion[1] ) {
                        case 0:
                            return "Windows 2000";
                        case 1:
                            return "Windows XP";
                        case 2:
                            return "Windows XP Professional x64";
                        default:
                            return "Unknown Windows Version";
                    }
                case 6:
                    switch ( osVersion[1] ) {
                        case 0:
                            return "Windows Vista";
                        case 1:
                            return "Windows 7";
                        case 2:
                            return "Windows 8";
                        case 3:
                            return "Windows 8.1";
                        default:
                            return "Unknown Windows Version";
                    }
                case 10:
                    return "Windows 10";
                default:
                    return "Unknown Windows Version";
            }
        }

        // ######################################################################
        //   xxx    xxxx    xxxxx   xxxx     xxx    xxxxx   xxxxx   x   x    xxxx
        //  x   x   x   x   x       x   x   x   x     x       x     xx  x   x    
        //  x   x   xxxx    xxxx    xxxx    xxxxx     x       x     x x x   x  xx
        //  x   x   x       x       x   x   x   x     x       x     x  xx   x   x
        //   xxx    x       xxxxx   x   x   x   x     x     xxxxx   x   x    xxxx
        //
        //   xxxx   x   x    xxxx   xxxxx   xxxxx   x   x
        //  x       x   x   x         x     x       xx xx
        //   xxx     xxx     xxx      x     xxxx    x x x
        //      x     x         x     x     x       x   x
        //  xxxx      x     xxxx      x     xxxxx   x   x
        // ######################################################################
        /// <summary> Funkcja wczytująca aktualnie ustawioną tapetę systemu Windows. </summary>
        /// <returns> Obraz - Tapeta systemu Windows. </returns>
        public static Image GetSystemWallpaper() {
            var     registry    =   Registry.CurrentUser.OpenSubKey( "Software\\Microsoft\\Internet Explorer\\Desktop\\General\\", false );
            string  wallpaper   =   registry.GetValue( "WallpaperSource" ).ToString();
            registry.Close();
            
            return  Image.FromFile( wallpaper );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zwracająca aktualnie ustawiony kolor motywu systemu Windows. </summary>
        /// <returns> Kolor motywu systemu Windows. </returns>
        public static Color GetSystemThemeColor() {
            Color   color       =   Color.Black;
            int[]   osVersion   =   GetSystemVersion();
            string  registry    =   "";
            string  key         =   "";

            try {
                if ( osVersion[0] == 6 && osVersion[1] > 1 ) {
                    // Windows 7, 8, 8.1 DWM
                    registry    =   "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\DWM";
                    key         =   "ColorizationColor";

                } else if ( osVersion[0] == 10 ) {
                    // Windows 10
                    registry    =   "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Accent";
                    key         =   "AccentColorMenu";
                }

                Int32   argbColor   =   Convert.ToInt32( Registry.GetValue( registry, key , 0 ) );
                        color       =   ImageTools.ConvertFromABGR( Color.FromArgb( argbColor ) );
            } catch ( Exception exc ) {
                Console.WriteLine( exc.ToString() );
            }

            return color;
        }

        // ######################################################################
        //  xxxx    xxxxx    xxx    x        xxx     xxxx
        //   x  x     x     x   x   x       x   x   x    
        //   x  x     x     xxxxx   x       x   x   x  xx
        //   x  x     x     x   x   x       x   x   x   x
        //  xxxx    xxxxx   x   x   xxxxx    xxx     xxxx
        //
        //  xxx      xxx    x   x   xxxxx    xxxx
        //  x  x    x   x    x x    x       x    
        //  xxxx    x   x     x     xxxx     xxx 
        //  x   x   x   x    x x    x           x
        //  xxxx     xxx    x   x   xxxxx   xxxx 
        // ######################################################################
        /// <summary> Funkcja uruchamiająca okno wyboru koloru przez użytkownika.  </summary>
        /// <param name="currentColor"> Kolor który ma być wybrany domyślnie. </param>
        /// <returns> Kolor wybrany przez użytkownika. </returns>
        public static Color ColorSelector( Color currentColor ) {
            ColorDialog colorSelector   =   new ColorDialog();
            Color       newColor        =   currentColor;
            colorSelector.AllowFullOpen =   true;
            colorSelector.ShowHelp      =   false;
            colorSelector.Color         =   currentColor;

            if ( colorSelector.ShowDialog() == DialogResult.OK ) { newColor = colorSelector.Color; }
            return newColor;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja uruchamiająca okno wyboru obrazu przez użytkownika. </summary>
        /// <param name="initPath"> Ścieżka, która ma być załadowana po uruchomieniu okna wyboru. </param>
        /// <returns> Ścieżka do załadowanego pliku obrazu. </returns>
        public static string PictureSelector( string initPath ) {
            string  filePath    =   "";
            string  filter      =   "All images(*.BMP;*.GIF;*.JPEG;*.JPG;*.PNG)|*.BMP;*.GIF;*.JPEG;*.JPG;*.PNG"
                                +   "|Bitmap(*.BMP)|*BMP"
                                +   "|Graphics Interchange Format(*GIF)|*GIF"
                                +   "|Picture(*JPG;*JPEG)|*.JPG;*.JPEG"
                                +   "|Portable Network Graphics(*.PNG)|*.PNG"
                                +   "|All Files(*.*)|*.*";

            OpenFileDialog  openFileDialog      =   new OpenFileDialog();
            openFileDialog.InitialDirectory     =   initPath;
            openFileDialog.Filter               =   filter;
            openFileDialog.FilterIndex          =   0;
            openFileDialog.RestoreDirectory     =   true;

            if ( openFileDialog.ShowDialog() == DialogResult.OK ) { filePath = openFileDialog.FileName; }
            return filePath;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja uruchamiająca okno wyboru listy odtwarzania użytkownika. </summary>
        /// <param name="initPath"> Ścieżka, która ma być załadowana po uruchomieniu okna wyboru. </param>
        /// <returns> Ścieżka do załadowanego pliku listy odtwarzania. </returns>
        public static string PlayListSelector( string initPath ) {
            string  filePath    =   "";
            string  filter      =   "All playlists(*.APL)|*.APL"
                                +   "|AnthraX PlayList(*.APL)|*APL";

            //string  filter      =   "All playlists(*.APL;*.VPL)|*.APL;*.VPL"
            //                    +   "|AnthraX PlayList(*.APL)|*APL"
            //                    +   "|VertillIGo Media Player(*.VPL)|*.VPL";

            OpenFileDialog  openFileDialog      =   new OpenFileDialog();
            openFileDialog.InitialDirectory     =   initPath;
            openFileDialog.Filter               =   filter;
            openFileDialog.FilterIndex          =   0;
            openFileDialog.RestoreDirectory     =   true;

            if ( openFileDialog.ShowDialog() == DialogResult.OK ) { filePath = openFileDialog.FileName; }
            return filePath;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja uruchamiająca okno wyboru pliku z tekstem karaoke przez użytkownika. </summary>
        /// <param name="initPath"> Ścieżka, która ma być załadowana po uruchomieniu okna wyboru. </param>
        /// <returns> Ścieżka do załadowanego pliku tekstowego karaoke. </returns>
        public static string KaraokeSelector( string initPath ) {
            string  filePath    =   "";
            string  filter      =   "All playlists(*.TXT)|*.TXT"
                                +   "|AnthraX PlayList(*.TXT)|*TXT";

            OpenFileDialog  openFileDialog      =   new OpenFileDialog();
            openFileDialog.InitialDirectory     =   initPath;
            openFileDialog.Filter               =   filter;
            openFileDialog.FilterIndex          =   0;
            openFileDialog.RestoreDirectory     =   true;

            if ( openFileDialog.ShowDialog() == DialogResult.OK ) { filePath = openFileDialog.FileName; }
            return filePath;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja uruchamiająca okno zapisu przez użytkownika pliku listy odtwarzania. </summary>
        /// <param name="initPath"> Ścieżka, która ma być załadowana po uruchomieniu okna wyboru. </param>
        /// <returns> Ścieżka wraz z nazwą pliku który ma być zapisany jako lista odtwarzania. </returns>
        public static string PlayListSaver( string initPath ) {
            string  filePath    =   "";
            string  filter      =   "AnthraX PlayList(*.APL)|*APL";

            SaveFileDialog  saveFileDialog      =   new SaveFileDialog();
            saveFileDialog.InitialDirectory     =   initPath;
            saveFileDialog.Filter               =   filter;
            saveFileDialog.FilterIndex          =   0;
            saveFileDialog.RestoreDirectory     =   true;

            if ( saveFileDialog.ShowDialog() == DialogResult.OK ) { filePath = saveFileDialog.FileName; }
            return filePath;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja uruchamiająca okno zapisu przez użytkownika pliku tekstowego karaoke. </summary>
        /// <param name="initPath"> Ścieżka, która ma być załadowana po uruchomieniu okna wyboru. </param>
        /// <returns> Ścieżka wraz z nazwą pliku który ma być zapisany jako plik tekstowy karaoke. </returns>
        public static string KaraokeSaver( string initPath ) {
            string  filePath    =   "";
            string  filter      =   "Karaoke File(*.TXT)|*TXT";

            SaveFileDialog  saveFileDialog      =   new SaveFileDialog();
            saveFileDialog.InitialDirectory     =   initPath;
            saveFileDialog.Filter               =   filter;
            saveFileDialog.FilterIndex          =   0;
            saveFileDialog.RestoreDirectory     =   true;

            if ( saveFileDialog.ShowDialog() == DialogResult.OK ) { filePath = saveFileDialog.FileName; }
            return filePath;
        }

        // ######################################################################
        //  xxxx    xxxxx   xxxx    xxxxx    xxx    xxxxx    xxx    xxxx    xxxxx   xxxxx    xxxx
        //   x  x     x     x   x   x       x   x     x     x   x   x   x     x     x       x    
        //   x  x     x     xxxx    xxxx    x         x     x   x   xxxx      x     xxxx     xxx 
        //   x  x     x     x   x   x       x   x     x     x   x   x   x     x     x           x
        //  xxxx    xxxxx   x   x   xxxxx    xxx      x      xxx    x   x   xxxxx   xxxxx   xxxx 
        // ######################################################################
        /// <summary> Funkcja zwracająca ścieżkę w której znajduje się konfiguracja aplikacji, inna niż rejestr systemowy. </summary>
        /// <returns> Ścieżka z plikami konfiguracji. </returns>
        public static string GetDirectoryApplicationConfig() {
            string  directory   =   GetDirectoryAppData() + "\\AnthraX";
            if ( !Directory.Exists( directory ) ) { Directory.CreateDirectory( directory ); }
            return directory;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zwracająca ścieżkę w której znajdują się konfiguracje efektów dźwiękowych. </summary>
        /// <returns> Ścieżka z plikami konfiguracji efektów dźwiękowych. </returns>
        public static string GetDirectoryApplicationEffects() {
            string  directory   =   GetDirectoryApplicationConfig() + "\\Effects";
            if ( !Directory.Exists( directory ) ) { Directory.CreateDirectory( directory ); }
            return directory;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zwracająca ścieżkę w której znajdują się listy odtwarzania biblioteki. </summary>
        /// <returns> Ścieżka z plikami list odtwarzania biblioteki. </returns>
        public static string GetDirectoryApplicationLibrary() {
            string  directory   =   GetDirectoryApplicationConfig() + "\\Library";
            if ( !Directory.Exists( directory ) ) { Directory.CreateDirectory( directory ); }
            return directory;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zwracająca ścieżkę w której znajdują się konfiguracje korektora graficznego. </summary>
        /// <returns> Ścieżka z plikami konfiguracji korektora graficznego. </returns>
        public static string GetDirectoryApplicationPresets() {
            string  directory   =   GetDirectoryApplicationConfig() + "\\Presets";
            if ( !Directory.Exists( directory ) ) { Directory.CreateDirectory( directory ); }
            return directory;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zwracająca ścieżkę w której znajdują się teksty karaoke. </summary>
        /// <returns> Ścieżka z plikami tekstów karaoke. </returns>
        public static string GetDirectoryApplicationKaraoke() {
            string  directory   =   GetDirectoryApplicationConfig() + "\\Karaoke";
            if ( !Directory.Exists( directory ) ) { Directory.CreateDirectory( directory ); }
            return directory;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zwracająca ścieżkę katalogu domowego użytkownika. </summary>
        /// <returns> Ścieżka katalogu domowego użytkownika. </returns>
        public static string GetDirectoryHome() {
            return System.Environment.GetEnvironmentVariable( "USERPROFILE" );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zwracająca ścieżkę katalogu ustawień użytkownika. </summary>
        /// <returns> Ścieżka katalogu ustawień użytkownika. </returns>
        public static string GetDirectoryAppData() {
            return System.Environment.GetEnvironmentVariable( "APPDATA" );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zwracająca ścieżkę katalogu obrazów użytkownika. </summary>
        /// <returns> Ścieżka katalogu obrazów użytkownika. </returns>
        public static string GetDirectoryPictures() {
            return System.Environment.GetEnvironmentVariable( "USERPROFILE" ) + "\\Pictures";
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zwracająca ścieżkę katalogu muzyki użytkownika. </summary>
        /// <returns> Ścieżka katalogu muzyki użytkownika. </returns>
        public static string GetDirectoryMusic() {
            return System.Environment.GetEnvironmentVariable( "USERPROFILE" ) + "\\Music";
        }

        // ######################################################################
    }

    // ################################################################################
}
