using AnthraX.DataStructures;
using AnthraX.Libraries;
using AnthraX.MessageBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Un4seen.Bass;

namespace AnthraX {

    // ################################################################################
    //   xxxx   xxxxx   xxxx    x   x    xxx    xxxxx    xxxx
    //  x         x     x   x   x   x   x   x     x     x    
    //   xxx      x     xxxx    x   x   x         x      xxx 
    //      x     x     x   x   x   x   x   x     x         x
    //  xxxx      x     x   x    xxx     xxx      x     xxxx 
    // ################################################################################
    /// <summary>  </summary>
    public struct KaraokeData {
        public long time;
        public string text;
    }

    // ################################################################################
    //  xxxxx   x   x   x   x   x   x   xxxxx   xxxx     xxx    xxxxx    xxx    xxxx     xxxx
    //  x       xx  x   x   x   xx xx   x       x   x   x   x     x     x   x   x   x   x    
    //  xxxx    x x x   x   x   x x x   xxxx    xxxx    xxxxx     x     x   x   xxxx     xxx 
    //  x       x  xx   x   x   x   x   x       x   x   x   x     x     x   x   x   x       x
    //  xxxxx   x   x    xxx    x   x   xxxxx   x   x   x   x     x      xxx    x   x   xxxx 
    // ################################################################################
    /// <summary>  </summary>
    public enum ThemeType {
        None            =   0,
        Color           =   1,
        CustomColor     =   2,
        SystemColor     =   3
    }

    // --------------------------------------------------------------------------------
    /// <summary>  </summary>
    public enum WallpaperType {
        None            =   0,
        Color           =   1,
        CustomColor     =   2,
        Picture         =   3,
        Wallpaper       =   4
    }

    // --------------------------------------------------------------------------------
    /// <summary>  </summary>
    public enum WallpaperDrawType {
        Normal          =   0,
        Center          =   1,
        Resized         =   2,
        Stretched       =   3,
        AdjustMax       =   4,
        AdjustMin       =   5
    }

    // ################################################################################
    //  xxxxx    xxx    xxxx    x   x     x   x    xxx    xxxxx   x   x
    //  x       x   x   x   x   xx xx     xx xx   x   x     x     xx  x
    //  xxxx    x   x   xxxx    x x x     x x x   xxxxx     x     x x x
    //  x       x   x   x   x   x   x     x   x   x   x     x     x  xx
    //  x        xxx    x   x   x   x     x   x   x   x   xxxxx   x   x
    // ################################################################################
    /// <summary> Klasa główna okna aplikacji AnthraX </summary>
    public partial class FormAnthraX : Form {

        private const       int     playListMinWidth        =   300;
        public  delegate    void    InvokeInterface();

        // --- Form Properties ---
        private bool            resizePlayListActive    =   false;
        private Rectangle       panelVisRect            =   new Rectangle( 0, 0, 0, 0 );
        private int             playListTileSizeHeight  =   40;
        private int             playListWidth           =   300;

        // --- Application Data ---
        private PagesManager    pages                   =   null;
        private PagesManager    pagesEffects            =   null;
        private PagesManager    pagesSettings           =   null;

        // --- Music position slider ---
        private CustomSlider    sliderMusic;
        private bool            sliderMusicActive       =   false;

        // --- Volume position slider ---
        private CustomSlider    sliderVolume;
        private bool            sliderVolumeActive      =   false;
        private int             mutePosition            =   0;

        // --- Player Data ---
        private Thread          playerThread            =   null;
        private bool            playerThreadEnabled     =   false;
        private int             playerThreadSleep       =   5;
        private CustomPlayList  playList;
        private int             playingIndex            =   -1;

        private bool            playListDragDrop        =   false;
        private int             playListDragIndex       =   -1;
        private int[]           playListDragArray       =   null;

        private int             statusPlay              =   0;
        private int             statusMute              =   0;
        private int             statusRepeat            =   0;
        private int             statusShuffle           =   0;
        private bool            statusAutoPlay          =   false;
        private bool            statusAutoBack          =   false;
        private bool            statusAutoSave          =   true;

        // --- Theme settings ---
        private bool            darkMode                =   false;
        private string[]        colors                  =   null;
        private int             wallpaperIndex          =   0;
        private string          wallpaperPath           =   "";

        // --- Spectrum Data ---
        private Spectrum        spectrum                =   null;

        // --- Files Manager Data ---
        private FilesManager    filesManager            =   null;

        // --- Library Manager Data ---
        private CustomPlayList  libraryPlayList         =   null;
        private int             libraryOpenedIndex      =   0;
        private string          libraryOpened           =   "";

        private bool            libraryDragDrop         =   false;
        private int             libraryDragIndex        =   -1;
        private int[]           libraryDragArray        =   null;

        // --- Karaoke Data ---
        private bool                statusKaraoke       =   false;
        private List<KaraokeData>   karaokeData         =   null;
        private int                 temp_index          =   -1;
        private int                 karaokeIndex        =   0;

        // --- Euqlizer Manager Data ---
        private int[]           equalizerPresetData     =   new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int             equalizerPresetIndex    =   0;
        private string          equalizerPresetName     =   "Default";
        private int[]           equalizerEffectsData    =   new int[17] { 0, 0, 50, 50, 0, 300, 70, 0, 24576, 50, 70, 0, 0, 0, 0, 0, 0 };
        private int             equalizerEffectsIndex   =   0;
        private string          equalizerEffectsName    =   "Default";

        // ######################################################################
        //  x   x   xxxxx    xxxx    xxxx    xxx     xxxx   xxxxx    xxxx
        //  xx xx   x       x       x       x   x   x       x       x    
        //  x x x   xxxx     xxx     xxx    xxxxx   x  xx   xxxx     xxx 
        //  x   x   x           x       x   x   x   x   x   x           x
        //  x   x   xxxxx   xxxx    xxxx    x   x    xxxx   xxxxx   xxxx 
        // ######################################################################
        #region Messages
        // ----------------------------------------------------------------------
        /// <summary> Zezwolenie na odbieranie danych z innych aplikacji (procesów). </summary>
        private void AllowSendMessages() {
            ProcessMessages.CHANGEFILTERSTRUCT changeFilter     =   new ProcessMessages.CHANGEFILTERSTRUCT();
            changeFilter.size   =   (uint) Marshal.SizeOf( changeFilter );
            changeFilter.info   =   0;
            if ( !ProcessMessages.ChangeWindowMessageFilterEx(
                this.Handle, ProcessMessages.WM_COPYDATA, ProcessMessages.ChangeWindowMessageFilterExAction.Allow, ref changeFilter ) ) {
                int error       =   Marshal.GetLastWin32Error();
                System.Console.WriteLine( String.Format("The error {0} occurred.", error) );
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja odbierająca wiadomość z innych aplikacji (procesów). </summary>
        /// <param name="m"> Wiadomość. </param>
        protected override void WndProc( ref Message m ) {
            if ( m.Msg == ProcessMessages.WM_COPYDATA) {
                // --- Extract message Data ---
                ProcessMessages.COPYDATASTRUCT copyData     =   (ProcessMessages.COPYDATASTRUCT) Marshal.PtrToStructure(
                    m.LParam, typeof( ProcessMessages.COPYDATASTRUCT ) );
                int dataType    =   (int)copyData.dwData;

                if (dataType == 2) {
                    string arguments    =   Marshal.PtrToStringAnsi(copyData.lpData);
                    ReadArguments( arguments );

                } else {
                    System.Console.WriteLine( String.Format("Unrecognized data type = {0}.", dataType) );
                }
            } else {
                base.WndProc( ref m );
            }
        }

        #endregion Messages
        // ######################################################################
        //  xxxx    xxxx     xxx     xxxx     xxxx    xxxx     xxx    xxxx 
        //   x  x   x   x   x   x   x          x  x   x   x   x   x   x   x
        //   x  x   xxxx    xxxxx   x  xx      x  x   xxxx    x   x   xxxx 
        //   x  x   x   x   x   x   x   x      x  x   x   x   x   x   x    
        //  xxxx    x   x   x   x    xxxx     xxxx    x   x    xxx    x    
        // ######################################################################
        #region DragDrop
        // ----------------------------------------------------------------------
        /// <summary> Zezwolenie na wrzucanie do aplikacji (przeciąganie) plików. </summary>
        /// <param name="sender"> Okno programu. </param>
        /// <param name="e"> Parametry (przeciągnięte elementy). </param>
        private void FormAnthraX_DragEnter(object sender, DragEventArgs e) {
            if ( e.Data.GetDataPresent( DataFormats.FileDrop, false ) == true ) {
                e.Effect = DragDropEffects.All;
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja odczytująca wrzucone do aplikacji (przeciągnięte) elementy. </summary>
        /// <param name="sender"> Okno programu. </param>
        /// <param name="e"> Parametry (przeciągnięte elementy). </param>
        private void FormAnthraX_DragDrop(object sender, DragEventArgs e) {
            var dropped     =   ( (string[]) e.Data.GetData( DataFormats.FileDrop ) );
            var files       =   dropped.ToArray();

            CustomFile  playingFile     =   playList.GetFile( this.playingIndex );
            int         firstNewItem    =   playList.GetCount();
            bool        musicAdded      =   false;

            foreach ( string file in files ) {
                playList.Add( file );
                musicAdded  =   true;
            }

            UpdateNowPlaying();
            if ( libraryOpenedIndex == 0 && libraryPlayList != null ) {
                UpdateLibraryPlayList();
            }

            // --- AUTOPLAY ---
            if ( statusAutoPlay && musicAdded ) {
                if ( playingFile != null ) { DiselectNowPlaying(); }
                SelectNowPlaying( firstNewItem );
                SoundMoudleLoadFile( playList.GetFile( this.playingIndex ) );
            }
        }

        #endregion DragDrop
        // ######################################################################
        //  xxxxx    xxx     xxx    x        xxxx
        //    x     x   x   x   x   x       x    
        //    x     x   x   x   x   x        xxx 
        //    x     x   x   x   x   x           x
        //    x      xxx     xxx    xxxxx   xxxx 
        // ######################################################################
        #region Tools
        // ----------------------------------------------------------------------
        /// <summary> Pobranie rozmiarów obramowania i paska tytułowego okna. </summary>
        /// <returns> Rozmiary jako kwadrat. </returns>
        private Rectangle GetBorder() {
            Rectangle   rectangle       =   RectangleToScreen( this.ClientRectangle );
            int         borderWidth     =   rectangle.Left - this.Left;
            int         borderHeight    =   rectangle.Top - this.Top;
            return new Rectangle( 0, 0, borderWidth, borderHeight );
        }

        // ----------------------------------------------------------------------
        /// <summary> Zmiana rozmiaru obszaru listy odtwarzania na ekranie głównym. </summary>
        /// <param name="size"> Nowy rozmiar (szerokości) listy odtwarzania. </param>
        private void ResizePlayList( int size ) {
            if ( listViewNowPlaying.TileSize.Height > 0 ) {
                playListTileSizeHeight  =   listViewNowPlaying.TileSize.Height;
            }
            if ( panelVis.Width > 0 ) {
                playListWidth   =   panelVis.Width;
            }

            if ( size <= playListMinWidth ) {
                listViewNowPlaying.TileSize     =   new Size(playListMinWidth - 32, playListTileSizeHeight);
                tlPanelPlayList.Width           =   playListMinWidth;

            } else if ( size >= playListWidth ) {
                listViewNowPlaying.TileSize     =   new Size(playListWidth - 32, playListTileSizeHeight);
                tlPanelPlayList.Width           =   panelVis.Width;

            } else {
                listViewNowPlaying.TileSize     =   new Size(size - 32, playListTileSizeHeight);
                tlPanelPlayList.Width           =   size;
            }

            panelPlayListMenuOffset.Width       =   (tlPanelPlayList.Width - playListMinWidth) / 2;
            //InterfaceDrawer.DrawPlayList( Properties.Resources.temp_bckg, panelVis, listViewNowPlaying );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja odczytująca argumenty wiadomości i danych z rozruchu programu. </summary>
        /// <param name="arguments"> Argumenty i wiadomość. </param>
        private void ReadArguments( string arguments ) {
            CustomFile  playingFile     =   playList.GetFile( this.playingIndex );
            int         firstNewItem    =   playList.GetCount();
            List<bool>  musicAdded      =   new List<bool>();

            musicAdded  =   playList.Add( arguments, '\n' );
            UpdateNowPlaying();
            
            // --- AUTOPLAY ---
            if ( statusAutoPlay && musicAdded.Count > 0 ) {
                if ( playingFile != null ) { DiselectNowPlaying(); }
                SelectNowPlaying( firstNewItem );
                SoundMoudleLoadFile( playList.GetFile( this.playingIndex ) );
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja uzupełniająca tablicę, nazwami kolorów których nazewnictwo obsługuje system. </summary>
        /// <returns> Tablica z nazwami kolorów. </returns>
        private string[] FillColors() {
            Type            colorType       =   typeof( System.Drawing.Color );
            PropertyInfo[]  propInfoList    =   colorType.GetProperties(
                BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public );

            string[]        colors          =   new string[propInfoList.Length];
            for ( int i = 0; i < propInfoList.Length; i++ ) { colors[i] = propInfoList[i].Name; }
            return colors;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja uzupełniająca komponent combobox, listą kolorów (kolor i nazwa). </summary>
        /// <param name="combobox"> Komponent Combobox który ma zostać uzupełniony. </param>
        private void FillComboBoxColors( ComboBox combobox ) {
            combobox.Items.Clear();
            combobox.DrawItem       +=  new DrawItemEventHandler( DrawItem );

            foreach ( string c in colors ) { combobox.Items.Add( c );  }

            void DrawItem( object sender, DrawItemEventArgs e ) {
                Graphics    g       =   e.Graphics;
                Rectangle   rect    =   e.Bounds;

                if ( true ) {
                    string      name    =   ((ComboBox)sender).Items[e.Index].ToString();
                    Font        font    =   new Font("Calibri", 12, FontStyle.Regular);
                    Color       color   =   Color.FromName( name );
                    Brush       brush   =   new SolidBrush( color );
                    Rectangle   fill    =   new Rectangle( rect.Width-80, rect.Y+4, rect.Width-32, rect.Height-4 );

                    //if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) {
                    //    fill = new Rectangle( 0, 0, rect.Width, rect.Height );
                    //}

                    g.DrawString(name, font, Brushes.Black, rect.X, rect.Top);
                    g.FillRectangle( brush, fill );
                }
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Pobiera relatywny rozmiar okna, wraz z elementami systemowymi (pasek tytułowy). </summary>
        /// <returns> Położenie okna i jego rozmiary w reprezentacji obiektu typu Rectangle. </returns>
        private Rectangle GetWindowSize() {
            return new Rectangle(
                this.Left, this.Top, this.ClientSize.Width, this.ClientSize.Height
            );
        }

        #endregion Tools
        // ######################################################################
        //  xxxxx    xxx    xxxx    x   x
        //  x       x   x   x   x   xx xx
        //  xxxx    x   x   xxxx    x x x
        //  x       x   x   x   x   x   x
        //  x        xxx    x   x   x   x
        // ######################################################################
        #region Form
        // ----------------------------------------------------------------------
        /// <summary> Funkcja inicjująca klasę okna głównego aplikacji AnthraX. </summary>
        /// <param name="arguments"> Argumenty (np konsolowe) które zostają przekazane do aplikacji podczas uruochomienia. </param>
        public FormAnthraX( string arguments ) {
            // --- Initialize Components ---
            karaokeData     =   new List<KaraokeData>();
            pages           =   new PagesManager();
            pagesEffects    =   new PagesManager();
            pagesSettings   =   new PagesManager();
            playList        =   new CustomPlayList( Tools.fileTypeMusic );
            filesManager    =   new FilesManager( Tools.GetDirectoryHome() );
            playerThread    =   new Thread( UpdatePlayerThread );
            colors          =   FillColors();

            // --- Initialize Application ---
            InitializeComponent();
            ReadArguments( arguments );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas tworzenia (window designer) okna aplikacji. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (okno). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void FormMain_Load(object sender, EventArgs e) {
            // --- System Configuration ---
            AllowSendMessages();
            ConfigureMainPages();
            ConfigureEffectsPages();
            ConfigureSettingsPages();
            ConfigureInterfaceDrawer();
            InitSettings();
            SoundMoudeInit();

            // --- Application Configuration ---
            sliderMusic     =   new CustomSlider( 32, 12, 96, 6 );
            sliderVolume    =   new CustomSlider( 32, 12, 6, 6 );
            spectrum        =   new Spectrum( panelVis.ClientRectangle );
            InterfaceDrawer.borderSize  =   GetBorder();
            filesManager.GetDiskList( comboBoxExplorerDisks );
            UpdateExplorer();
            UpdateEqualizer();

            // --- Load Configuration ---
            AdditionalSettingsLoad();
            SettingsLoad();
            PlayingListLoad();

            // --- Appication Data Update ---
            sliderMusic.Update( panelSlider.Width, panelSlider.Height );
            sliderVolume.Update( panelVolume.Width, panelVolume.Height );
            RenderInterface();
            UpdateInterface();
            UpdateIconsTheme( darkMode );
            UpdateControlsTheme( darkMode );

            // --- Threads ---
            StartPlayerThread();
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas inicjowania wyświetlania okna aplikacji na ekrnaie. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (okno). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void FormMain_Shown(object sender, EventArgs e) {
            //
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas inicjacji zamykania głównego okna aplikacji. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (okno). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            AdditionalSettingsSave();
            PlayingListSave();
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana po zamknięciu okna głównego aplikacji (tzw. destruktor okna). </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (okno). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e) {
            StopPlayerThread();
            SoundModule.Unload();
        }

        // ----------------------------------------------------------------------
        //   xxxx   xxxxx    xxx    xxxxx   xxxxx    xxxx
        //  x         x     x   x     x     x       x    
        //   xxx      x     xxxxx     x     xxxx     xxx 
        //      x     x     x   x     x     x           x
        //  xxxx      x     x   x     x     xxxxx   xxxx 
        // ----------------------------------------------------------------------
        /// <summary> Funkcja zwracająca informację o stanie okna (czy jest zminimalizowane). </summary>
        /// <returns> Wartość logiczna informująca czy okno jest zminimalizowane. </returns>
        public bool isMinimalized() {
            return ( this.WindowState == FormWindowState.Minimized );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja minimalizująca okno główne aplikacji. </summary>
        public void Minimalize() {
            if ( !isMinimalized() ) { this.WindowState = FormWindowState.Minimized; }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja przywracająca okno główne aplikacji na ekran po jego minimalizacji. </summary>
        public void Maximalize() {
            if ( isMinimalized() ) { this.WindowState = FormWindowState.Normal; }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonująca ustawienie okna głównego aplikacji w tryb pełno ekranowy, bądź normalny. </summary>
        /// <param name="fullscreen"> Parametr którego wartość true, oznacza że okno główne aplikacji zostanie ustawione w tryb pełnoekranowy. </param>
        public void FullScreen( bool fullscreen ) {
            //
        }

        #endregion Form
        // ######################################################################
        //  xxxxx   x   x   xxxxx   xxxxx
        //    x     xx  x     x       x  
        //    x     x x x     x       x  
        //    x     x  xx     x       x  
        //  xxxxx   x   x   xxxxx     x  
        // ######################################################################
        #region Init
        // ----------------------------------------------------------------------
        /// <summary> Funkcja konfigurująca wszystkie zakładki które może wyświetlić aplikacja. </summary>
        private void ConfigureMainPages() {
            pages.Add( panelVis );
            pages.Add( panelLibrary );
            pages.Add( panelExplorer );
            pages.Add( panelKaraoke );
            pages.Add( panelEqualizer );
            pages.Add( panelSettings );
            pages.ShowPanel( panelVis );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja konfigurująca wszystkie zakładki ustawień. </summary>
        private void ConfigureSettingsPages() {
            pagesSettings.Add( fLPanelSettingsGeneral );
            pagesSettings.Add( fLPanelSettingsInfo );
            pagesSettings.Add( fLPanelSettingsPlayer );
            pagesSettings.Add( fLPanelSettingsSound );
            pagesSettings.Add( fLPanelSettingsTheme );
            pagesSettings.Add( fLPanelSettingsVisualisation );
            pagesSettings.ShowPanel( fLPanelSettingsInfo );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja konfigurująca wszystkie zakładki efektów dźwiękowych. </summary>
        private void ConfigureEffectsPages() {
            pagesEffects.Add( tLPanelEqualizer );
            pagesEffects.Add( fLPanelEffects );
            pagesEffects.ShowPanel( tLPanelEqualizer );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja konfigurująca funkcje rysujące interfejsu aplikacji. </summary>
        private void ConfigureInterfaceDrawer() {
            //panelVis.Paint            +=  InterfaceDrawer.PaintVisualisationBack;
            fLPanelMenu.Paint           +=  InterfaceDrawer.PaintMenuBack;
            panelControl.Paint          +=  InterfaceDrawer.PaintControlBack;
            tlPanelPlayList.Paint       +=  new PaintEventHandler( (sender,e) => { InterfaceDrawer.PaintPlayList(sender, e, panelVis); } );
            panelPlayListSplit.Paint    +=  InterfaceDrawer.PaintPlayListSplit;
            panelSlider.Paint           +=  new PaintEventHandler( (sender,e) => { InterfaceDrawer.PaintMusicSlider(sender, e, panelControl, sliderMusic); } );
            panelVolume.Paint           +=  new PaintEventHandler( (sender,e) => { InterfaceDrawer.PaintVolumeSlider(sender, e, sliderVolume); } );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja konfigurująca aplikację (ładując domyślne ustawienia). </summary>
        private void InitSettings() {
            UpdateSoundDevices();
            FillComboBoxColors( comboBoxThemeColor );
            FillComboBoxColors( comboBoxThemeWallpaperColor );
            FillComboBoxColors( comboBoxVisualisationColor );
        }

        #endregion Init
        // ######################################################################
        //   xxxx   xxxxx   xxxxx   xxxxx   xxxxx   x   x    xxxx    xxxx
        //  x       x         x       x       x     xx  x   x       x    
        //   xxx    xxxx      x       x       x     x x x   x  xx    xxx 
        //      x   x         x       x       x     x  xx   x   x       x
        //  xxxx    xxxxx     x       x     xxxxx   x   x    xxxx   xxxx 
        // ######################################################################
        #region Settings
        // ----------------------------------------------------------------------
        /// <summary> Funkcja przycisku zapisującego ustawienia aplikacji. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void buttonSettingsSave_Click(object sender, EventArgs e) {
            SettingsSave();
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zapisująca główne zmiany w aplikacji (jak np. położenie na ekranie) podczas jej zamykania. </summary>
        private void AdditionalSettingsSave() {
            if ( this.WindowState == FormWindowState.Normal ) {
                Properties.Settings.Default.FormPosition        =   this.Location;
                Properties.Settings.Default.FormSize            =   this.Size;
            }

            Properties.Settings.Default.NowPlayingWidth         =   tlPanelPlayList.Width;
            Properties.Settings.Default.ExplorerView            =   trackBarExplorerView.Value;
            Properties.Settings.Default.EqualizerPresetIndex    =   equalizerPresetIndex;
            Properties.Settings.Default.EqualizerEffectIndex    =   equalizerEffectsIndex;
            Properties.Settings.Default.SoundVolume             =   (sliderVolume.GetPosition()-16) * 100 / sliderVolume.GetSpaceWidth();
            Properties.Settings.Default.KaraokeEnabled          =   statusKaraoke;
            Properties.Settings.Default.Save();
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zapisująca zmiany wprowadzone przez użytkownia w aplikacji do rejestru systemu. </summary>
        private void SettingsSave() {
            if ( fLPanelSettingsTheme.Visible ) {
                Properties.Settings.Default.ThemeType                   =   comboBoxThemeType.SelectedIndex;
                Properties.Settings.Default.ThemeColorName              =   comboBoxThemeColor.SelectedItem.ToString();
                Properties.Settings.Default.ThemeCustomColor            =   fLPanelThemeCustomColor.BackColor;
                Properties.Settings.Default.ThemeWallpaperType          =   comboBoxThemeWallpaper.SelectedIndex;
                Properties.Settings.Default.ThemeWallpaperColor         =   comboBoxThemeWallpaperColor.SelectedItem.ToString();
                Properties.Settings.Default.ThemeWallpaperCustomColor   =   fLPanelThemeWallpaperCustomColor.BackColor;
                Properties.Settings.Default.ThemeWallpaperImage         =   wallpaperIndex;
                Properties.Settings.Default.ThemeWallpaperCustomImage   =   wallpaperPath;
                Properties.Settings.Default.ThemeWallpaperDrawType      =   comboBoxThemeWallpaperPosition.SelectedIndex;
                Properties.Settings.Default.ThemeDarkMode               =   darkMode;
                Properties.Settings.Default.ThemeTransparency           =   trackBarThemeTransparency.Value;
                Properties.Settings.Default.ThemeEnabledTransparency    =   checkBoxThemeTransparency.Checked;
                Properties.Settings.Default.Save();

            } else if ( fLPanelSettingsGeneral.Visible ) {
                Properties.Settings.Default.AnimationSpec               =   checkBoxGeneralAnimSpec.Checked;
                Properties.Settings.Default.Save();

            } else if ( fLPanelSettingsVisualisation.Visible ) {
                Properties.Settings.Default.SpectrumType                =   comboBoxVisualisationType.SelectedIndex;
                Properties.Settings.Default.SpectrumSize                =   trackBarVisualisationSize.Value;
                Properties.Settings.Default.SpectrumLogo                =   comboBoxVisualisationLogo.SelectedIndex;
                Properties.Settings.Default.SpectrumColor               =   comboBoxVisualisationColor.SelectedItem.ToString();
                Properties.Settings.Default.SpectrumCustomColor         =   fLPanelVisualisationCustomColor.BackColor;
                Properties.Settings.Default.SpectrumFillType            =   comboBoxVisualisationColorType.SelectedIndex;
                Properties.Settings.Default.SpectrumRainbowSpeed        =   trackBarVisualisationColorSpeed.Value;
                Properties.Settings.Default.SpectrumRainbowColor        =   trackBarVisualisationColorRainbow.Value;
                Properties.Settings.Default.SpectrumFillStyle           =   comboBoxVisualisationFill.SelectedIndex;
                Properties.Settings.Default.SpectrumTransparency        =   trackBarVisualisationTransparency.Value;
                Properties.Settings.Default.SpectrumEnableTransparency  =   checkBoxVisualisationTransparency.Checked;
                Properties.Settings.Default.SpectrumSensitivity         =   trackBarVisualisationSensitivity.Value;
                Properties.Settings.Default.Save();

            } else if ( fLPanelSettingsPlayer.Visible ) {
                Properties.Settings.Default.PlayerInformationTimeout    =   trackBarPlayerInfo.Value;
                Properties.Settings.Default.PlayerNotification          =   checkBoxPlayerNotification.Checked;
                Properties.Settings.Default.PlayerAutoStart             =   statusAutoPlay;
                Properties.Settings.Default.PlayerAutoBack              =   statusAutoBack;
                Properties.Settings.Default.PlayerAutoSave              =   statusAutoSave;
                Properties.Settings.Default.Save();

            } else if ( fLPanelSettingsSound.Visible ) {
                Properties.Settings.Default.Save();

            }

            string  title   =   "Settings Manager";
            string  message =   "Current page settings has been succesfully saved!";
            MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zapisująca akutalną listę odtwarzania, aby móc ją otworzyć ponownie podczas następengo uruchomienia aplikacji. </summary>
        private void PlayingListSave() {
            string  SaveLocation    =   Tools.GetDirectoryApplicationConfig();
            string  SaveFilePath    =   SaveLocation + "\\lastplaying.apl";

            if ( File.Exists( SaveFilePath ) ) {
                try {
                    File.Delete( SaveFilePath );
                } catch ( Exception exc ) {
                    System.Console.WriteLine( exc.ToString() );
                }
            }
            if ( playList == null ) { return; }
            if ( playList.GetCount() <= 0 ) { return; }
            if ( statusAutoSave ) {
                SaveLibrary( playList, SaveFilePath );
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja ładująca główne elementy programu z rejestru systemu, (takie jak np. położenie okna na ekranie). </summary>
        private void AdditionalSettingsLoad() {
            this.Location   =   Properties.Settings.Default.FormPosition;
            this.Size       =   Properties.Settings.Default.FormSize;
            ResizePlayList( Properties.Settings.Default.NowPlayingWidth );
            sliderVolume.SetPosition( 100, Properties.Settings.Default.SoundVolume );
            statusKaraoke   =   Properties.Settings.Default.KaraokeEnabled;
            checkBoxKaraokeEnable.Checked   =   statusKaraoke;
            ApplicationVolume.SetVolume( Properties.Settings.Default.SoundVolume );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja ładująca ustawienia aplikacji wprowadzone przez użytkownika z rejestru systemu. </summary>
        private void SettingsLoad() {
            // Theme Settings
            Settings.SetObjThemeType( comboBoxThemeType, Properties.Settings.Default.ThemeType );
            Settings.SetObjThemeColor( comboBoxThemeColor, Properties.Settings.Default.ThemeColorName );
            Settings.SetObjCustomThemeColor( fLPanelThemeCustomColor, Properties.Settings.Default.ThemeCustomColor );
            UpdateSettings_ThemeType( Properties.Settings.Default.ThemeType );
            Settings.SetObjThemeWallpaper( comboBoxThemeWallpaper, Properties.Settings.Default.ThemeWallpaperType );
            Settings.SetObjThemeColor( comboBoxThemeWallpaperColor, Properties.Settings.Default.ThemeWallpaperColor );
            Settings.SetObjCustomThemeColor( fLPanelThemeWallpaperCustomColor, Properties.Settings.Default.ThemeWallpaperCustomColor );
            wallpaperIndex  =   Properties.Settings.Default.ThemeWallpaperImage;
            wallpaperPath   =   Properties.Settings.Default.ThemeWallpaperCustomImage;
            Settings.SetObjThemeWallpaperCustomImage( pictureBoxThemeWallpaper06, wallpaperPath );
            Settings.SetDataThemeWallpaperImage( wallpaperIndex, wallpaperPath );
            Settings.SetObjThemeWallpaperPosition( comboBoxThemeWallpaperPosition, Properties.Settings.Default.ThemeWallpaperDrawType );
            Settings.SetDataThemeWallpaperPosition( (WallpaperDrawType) Properties.Settings.Default.ThemeWallpaperDrawType );
            checkBoxThemeDarkTheme.Checked      =   Properties.Settings.Default.ThemeDarkMode;
            darkMode                            =   Properties.Settings.Default.ThemeDarkMode;
            Settings.SetObjThemeTransparency( trackBarThemeTransparency, Properties.Settings.Default.ThemeTransparency );
            checkBoxThemeTransparency.Checked   =   Properties.Settings.Default.ThemeEnabledTransparency;
            UpdateSettings_UseTransparency( Properties.Settings.Default.ThemeEnabledTransparency );
            UpdateSettings_WallpaperType( Properties.Settings.Default.ThemeWallpaperType );
            
            // General
            checkBoxGeneralAnimSpec.Checked     =   Properties.Settings.Default.AnimationSpec;
            Settings.SetDataGeneralAnimSpec( spectrum, Properties.Settings.Default.AnimationSpec );
            
            // Visualisation Settings
            Settings.SetObjectVisualisationType( comboBoxVisualisationType, Properties.Settings.Default.SpectrumType );
            Settings.SetDataVisualisationType( spectrum, (SpectrumType) Properties.Settings.Default.SpectrumType );
            Settings.SetObjectVisualisationSize( trackBarVisualisationSize, Properties.Settings.Default.SpectrumSize );
            Settings.SetDataVisualisationSize( spectrum, Properties.Settings.Default.SpectrumSize );
            Settings.SetObjectVisualisationLogo( comboBoxVisualisationLogo, Properties.Settings.Default.SpectrumLogo );
            Settings.SetDataVisualisationLogo( spectrum, (SpectrumLogo) Properties.Settings.Default.SpectrumLogo );
            Settings.SetObjectVisualisationColor( comboBoxVisualisationColor, Properties.Settings.Default.SpectrumColor );
            Settings.SetObjectCustomVisualisationColor( fLPanelVisualisationCustomColor, Properties.Settings.Default.SpectrumCustomColor );
            Settings.SetObjectVisualisationColorScheme( comboBoxVisualisationColorType, Properties.Settings.Default.SpectrumFillType );
            Settings.SetDataVisualisationColorScheme( spectrum, (SpectrumFillType) Properties.Settings.Default.SpectrumFillType );
            Settings.SetObjectVisualisationRainbowSpeed( trackBarVisualisationColorSpeed, Properties.Settings.Default.SpectrumRainbowSpeed );
            Settings.SetDataVisualisationRainbowSpeed( spectrum, Properties.Settings.Default.SpectrumRainbowSpeed );
            Settings.SetObjectVisualisationRainbowColor( trackBarVisualisationColorRainbow, Properties.Settings.Default.SpectrumRainbowColor );
            Settings.SetDataVisualisationRainbowColor( spectrum, Properties.Settings.Default.SpectrumRainbowColor );
            UpdateSettings_VisualisationColorScheme( Properties.Settings.Default.SpectrumFillType );
            Settings.SetObjectVisualisationFill( comboBoxVisualisationFill, Properties.Settings.Default.SpectrumFillStyle );
            Settings.SetDataVisualisationFill( spectrum, (SpectrumFillStyle) Properties.Settings.Default.SpectrumFillStyle );
            Settings.SetObjectVisualisationTransparency( trackBarVisualisationTransparency, Properties.Settings.Default.SpectrumTransparency );
            checkBoxVisualisationTransparency.Checked   =   Properties.Settings.Default.SpectrumEnableTransparency;
            UpdateSettings_UseVisualisationTransparency( Properties.Settings.Default.SpectrumEnableTransparency );
            Settings.SetObjectVisualisationSensitivity( trackBarVisualisationSensitivity, Properties.Settings.Default.SpectrumSensitivity );
            Settings.SetDataVisualisationSensitivity( spectrum, Properties.Settings.Default.SpectrumSensitivity );
            
            // Player Settings
            Settings.SetObjectPlayerInformationTimeout( trackBarPlayerInfo, Properties.Settings.Default.PlayerInformationTimeout );
            Settings.SetDataPlayerInformationTimeout( spectrum, Properties.Settings.Default.PlayerInformationTimeout );
            checkBoxPlayerNotification.Checked  =   Properties.Settings.Default.PlayerNotification;
            Settings.SetDataPlayerNotification( notifyIcon, Properties.Settings.Default.PlayerNotification );
            statusAutoPlay                      =   Properties.Settings.Default.PlayerAutoStart;
            checkBoxPlayerAutoPlay.Checked      =   Properties.Settings.Default.PlayerAutoStart;
            statusAutoBack                      =   Properties.Settings.Default.PlayerAutoBack;
            checkBoxPlayerAutoComeback.Checked  =   Properties.Settings.Default.PlayerAutoBack;
            statusAutoSave                      =   Properties.Settings.Default.PlayerAutoSave;
            checkBoxPlayerAutoSave.Checked      =   Properties.Settings.Default.PlayerAutoSave;
            // Explorer
            Settings.SetObjectExplorerView( trackBarExplorerView, Properties.Settings.Default.ExplorerView );
            Settings.SetDataExplorerView( listViewExplorerFiles, Properties.Settings.Default.ExplorerView );
            // Equalizer
            object[]    resultPreset    =   Settings.SetObjectEqualizerPreset( treeViewEqualizerMenu, Properties.Settings.Default.EqualizerPresetIndex );
            object[]    resultEffect    =   Settings.SetObjectEqualizerEffect( treeViewEqualizerMenu, Properties.Settings.Default.EqualizerEffectIndex );
            EqualizerOpenPreset( (string) resultPreset[1], (int) resultPreset[0] );
            EqualizerOpenEffect( (string) resultEffect[1], (int) resultEffect[0] );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja ładująca ostatnio odtwarzaną listę odtwarzania. </summary>
        private void PlayingListLoad() {
            string  SaveLocation    =   Tools.GetDirectoryApplicationConfig();
            string  SaveFilePath    =   SaveLocation + "\\lastplaying.apl";

            if ( statusAutoSave ) {
                if ( File.Exists( SaveFilePath ) ) {
                    
                    Encoding    encode  =   Encoding.GetEncoding( "Windows-1250" );
                    foreach ( string filePath in File.ReadAllLines( SaveFilePath, encode ) ) {
                        if ( File.Exists( filePath ) ) {
                            CustomFile  file    =   new CustomFile( filePath );
                            playList.Add( file );
                        }
                    }

                    UpdateNowPlaying();
                    // --- AUTOPLAY ---
                    if ( statusAutoPlay && playList.GetCount() > 0 ) {
                        SelectNowPlaying( 0 );
                        SoundMoudleLoadFile( playList.GetFile( this.playingIndex ) );
                    }
                }
            }
        }

        #endregion Settings
        // ######################################################################
        //  xxxx    xxxxx   x   x   xxxx    xxxxx   xxxx    xxxxx   x   x    xxxx
        //  x   x   x       xx  x    x  x   x       x   x     x     xx  x   x    
        //  xxxx    xxxx    x x x    x  x   xxxx    xxxx      x     x x x   x  xx
        //  x   x   x       x  xx    x  x   x       x   x     x     x  xx   x   x
        //  x   x   xxxxx   x   x   xxxx    xxxxx   x   x   xxxxx   x   x    xxxx
        // ######################################################################
        #region Rendering
        // ----------------------------------------------------------------------
        /// <summary> Funkcja renderująca główne elementy interfejsu które poddawane są ciągłym zmianom. </summary>
        public void RenderInterface() {
            if ( this.WindowState == FormWindowState.Minimized ) { return; }
            Rectangle   panelVisRect    =   new Rectangle( panelVis.Left, panelVis.Top, panelVis.Width, panelVis.Height );
            if ( panelVisRect.Width == 0 || panelVisRect.Height == 0 ) { panelVisRect = this.panelVisRect; }

            InterfaceDrawer.RenderBackground( GetWindowSize() );
            spectrum.RenderBackground( panelVisRect, InterfaceDrawer.renderedBackground );
            spectrum.DrawBackground();
            if ( panelVisRect.Width != 0 && panelVisRect.Height != 0 ) { this.panelVisRect = panelVisRect; }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja przeładowania interfejsu (inicjuje jego ponowne renderowanie). </summary>
        public void UpdateInterface() {
            if ( this.WindowState == FormWindowState.Minimized ) { return; }

            if ( tlPanelPlayList.Visible ) {
                ResizePlayList( tlPanelPlayList.Width );
                //InterfaceDrawer.DrawPlayList( Properties.Resources.temp_bckg, panelVis, listViewNowPlaying );
            }

            //panelVis.Invalidate();
            DrawVisualisation();
            fLPanelMenu.Invalidate();
            panelControl.Invalidate();
            tlPanelPlayList.Invalidate();
            panelSlider.Invalidate();
            panelVolume.Invalidate();
            panelPlayListSplit.Invalidate();
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas zmiany rozmiaru głównego okna aplikacji. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (okno). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void FormMain_Resize(object sender, EventArgs e) {
            if ( this.WindowState == FormWindowState.Minimized ) { return; }

            RenderInterface();
            sliderMusic.Update( panelSlider.Width, panelSlider.Height );
            UpdateInterface();
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas zmiany położenia głównego okna aplikacji na ekranie. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (okno). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void FormMain_Move(object sender, EventArgs e) {
            if ( this.WindowState == FormWindowState.Minimized ) { return; }

            if ( InterfaceDrawer.backgroundType == WallpaperType.Wallpaper ) {
                RenderInterface();
                UpdateInterface();
            }
        }

        #endregion Rendering
        // ######################################################################
        //  xxx     x   x   xxxxx   xxxxx    xxx    x   x    xxxx
        //  x  x    x   x     x       x     x   x   xx  x   x    
        //  xxxx    x   x     x       x     x   x   x x x    xxx 
        //  x   x   x   x     x       x     x   x   x  xx       x
        //  xxxx     xxx      x       x      xxx    x   x   xxxx 
        // ######################################################################
        #region Buttons
        // ----------------------------------------------------------------------
        //  Buttons Main Menu [48]64
        // ----------------------------------------------------------------------
        /// <summary> Funkcja wywołania renderowania wykonywana podczas najechania kursorem na przycisk menu głównego. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void ButtonMenuHover(object sender, EventArgs e) {
            int option  =   tlPanelPlayList.Visible || !panelVis.Visible ? 0 : 1;
            InterfaceDrawer.MenuButtonHover( (Button) sender, darkMode, option );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wywołania renderowania wykonywana podczas zjechania kursora z przycisku menu głównego. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void ButtonMenuLeave(object sender, EventArgs e) {
            int option = tlPanelPlayList.Visible || !panelVis.Visible ? 0 : 1;
            InterfaceDrawer.MenuButtonDraw( (Button) sender, darkMode, option );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wywołania renderowania wykonywana podczas naciśnięcia przycisku menu głównego. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void ButtonMenuPress(object sender, MouseEventArgs e) {
            int option = tlPanelPlayList.Visible || !panelVis.Visible ? 0 : 1;
            InterfaceDrawer.MenuButtonPress( (Button) sender, darkMode, option );
        }

        // ----------------------------------------------------------------------
        //  Buttons Control Menu [32]48
        // ----------------------------------------------------------------------
        /// <summary> Funkcja wywołania renderowania wykonywana podczas naciśnięcia przycisku menu kontroli. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void ButtonControlPress(object sender, MouseEventArgs e) {
            int[]   options     =   new int[4] { statusPlay, statusMute, statusRepeat, statusShuffle };
            InterfaceDrawer.ControlButtonPress( (Button) sender, darkMode, options );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wywołania renderowania wykonywana podczas najechania kursorem na przycisk menu kontroli. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void ButtonControlHover(object sender, EventArgs e) {
            int[]   options     =   new int[4] { statusPlay, statusMute, statusRepeat, statusShuffle };
            InterfaceDrawer.ControlButtonHover( (Button) sender, darkMode, options );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wywołania renderowania wykonywana podczas zjechania kursora z przycisku menu kontroli. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void ButtonControlLeave(object sender, EventArgs e) {
            int[]   options     =   new int[4] { statusPlay, statusMute, statusRepeat, statusShuffle };
            InterfaceDrawer.ControlButtonDraw( (Button) sender, darkMode, options );
        }

        // ----------------------------------------------------------------------
        //  Buttons PlayList Menu [32]40
        // ----------------------------------------------------------------------
        /// <summary> Funkcja wywołania renderowania wykonywana podczas naciśnięcia przycisku menu listy odtwarzania. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void ButtonPLayListPress(object sender, MouseEventArgs e) {
            InterfaceDrawer.PlayListButtonPress( (Button) sender );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wywołania renderowania wykonywana podczas najechania kursorem na przycisk menu listy odtwarzania. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void ButtonPlayListHover(object sender, EventArgs e) {
            InterfaceDrawer.PlayListButtonHover( (Button) sender );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wywołania renderowania wykonywana podczas zjechania kursora z przycisku menu listy odtwarzania. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void ButtonPlayListLeave(object sender, EventArgs e) {
            InterfaceDrawer.PlayListButtonDraw( (Button) sender );
        }

        // ----------------------------------------------------------------------
        //  PictureBox Button Wallpaper Custom Image [32]40
        // ----------------------------------------------------------------------
        private void pictureBoxThemeWallpaper06_Paint(object sender, PaintEventArgs e) {
            //InterfaceDrawer.PictureBoxWallpaperDraw( (PictureBox) sender, wallpaperPath );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wywołania renderowania wykonywana podczas najechania kursorem na obrazek z ustawień wybierania tła aplikacji. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (obrazek). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void pictureBoxThemeWallpaper06_MouseHover(object sender, EventArgs e) {
            InterfaceDrawer.PictureBoxWallpaperHover( (PictureBox) sender, wallpaperPath );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wywołania renderowania wykonywana podczas zjechania kursorem na obrazek z ustawień wybierania tła aplikacji. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (obrazek). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void pictureBoxThemeWallpaper06_MouseLeave(object sender, EventArgs e) {
            InterfaceDrawer.PictureBoxWallpaperDraw( (PictureBox) sender, wallpaperPath );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wywołania renderowania wykonywana podczas naciśnięcia przycisku myszy na obrazku z ustawień wybierania tła aplikacji. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (obrazek). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void pictureBoxThemeWallpaper06_MouseDown(object sender, MouseEventArgs e) {
            InterfaceDrawer.PictureBoxWallpaperPress( (PictureBox) sender, wallpaperPath );
        }

        #endregion Buttons
        // ######################################################################
        //   xxxx   x       xxxxx   xxxx    xxxxx   xxxx     xxxx
        //  x       x         x      x  x   x       x   x   x    
        //   xxx    x         x      x  x   xxxx    xxxx     xxx 
        //      x   x         x      x  x   x       x   x       x
        //  xxxx    xxxxx   xxxxx   xxxx    xxxxx   x   x   xxxx 
        // ######################################################################
        #region Sliders
        // ----------------------------------------------------------------------
        //  Application Music Position Control
        // ----------------------------------------------------------------------
        /// <summary> Funckja wykonywana podczas wciśnięcia przycisku myszy, podczas gdy kursor
        /// znajduje się nad obiektiem, który ma za zadanie wyświetlać i kontrolować suwak odtwarzania.
        /// Wynikiem tego działania ma być zmiana pozycji suwaka na tą wskazywaną przez kursor. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (element interfejsu). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void panelSlider_MouseDown(object sender, MouseEventArgs e) {
            if ( sender.GetType() == typeof(Panel) ) {
                if ( e.X > sliderMusic.GetLeftSpace() && e.X < sliderMusic.GetRightSpace() ) {
                    sliderMusicActive   =   true;
                    panelSlider_MouseMove( sender, e );
                }
            } else if ( sender.GetType() == typeof(PictureBox) ) {
                Point   c   =   Cursor.Position;
                Point   p   =   panelSlider.PointToClient( c );

                if ( p.X > sliderMusic.GetLeftSpace() && p.X < sliderMusic.GetRightSpace() ) {
                    sliderMusicActive   =   true;
                    panelSlider_MouseMove( sender, e );
                }
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas gdy kursor z wciśniętym klawiszem myszy, porusza się
        /// po obiekcie którey ma zadanie wyświetlać i kontrolować suwak odtwarzania. 
        /// Wynik tego działa powoduje zmianę położenia suwaka odtwarzania w czasie rzeczywistym. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (element interfejsu). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void panelSlider_MouseMove(object sender, MouseEventArgs e) {
            if ( sliderMusicActive ) {
                if ( sender.GetType() == typeof(Panel) ) {
                    sliderMusic.UpdatePosition( e.X );
                } else if ( sender.GetType() == typeof(PictureBox) ) {
                    Point   c   =   Cursor.Position;
                    Point   p   =   panelSlider.PointToClient( c );
                    sliderMusic.UpdatePosition( p.X );
                }
                panelSlider.Invalidate();
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funckja wykonywana podczas puszczenia przycisku myszy, podczas gdy kursor
        /// znajduje się nad obiektiem, który ma za zadanie wyświetlać i kontrolować suwak odtwarzania.
        /// Wynikiem tego działania ma być zakończenie możliwości kontrolowania suwaka. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (element interfejsu). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void panelSlider_MouseUp(object sender, MouseEventArgs e) {
            sliderMusicActive   =   false;
            SoundModuleSetPosition();
            FixPosition();
        }

        // ----------------------------------------------------------------------
        //  Application Volume Control
        // ----------------------------------------------------------------------
        /// <summary> Funckja wykonywana podczas wciśnięcia przycisku myszy, podczas gdy kursor
        /// znajduje się nad obiektiem, który ma za zadanie wyświetlać i kontrolować suwak poziomu głośności.
        /// Wynikiem tego działania ma być zmiana pozycji suwaka na tą wskazywaną przez kursor. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (element interfejsu). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void panelVolume_MouseDown(object sender, MouseEventArgs e) {
            if ( statusMute == 1 ) { return; }
            if ( e.X > sliderVolume.GetLeftSpace() && e.X < sliderVolume.GetRightSpace() ) {
                sliderVolumeActive   =   true;
                panelVolume_MouseMove( sender, e );
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas gdy kursor z wciśniętym klawiszem myszy, porusza się
        /// po obiekcie którey ma zadanie wyświetlać i kontrolować suwak poziomu głośności. 
        /// Wynik tego działa powoduje zmianę położenia suwaka odtwarzania w czasie rzeczywistym. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (element interfejsu). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void panelVolume_MouseMove(object sender, MouseEventArgs e) {
            if ( sliderVolumeActive ) {
                sliderVolume.UpdatePosition( e.X );
                panelVolume.Invalidate();
                SetVolumePosition();
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funckja wykonywana podczas puszczenia przycisku myszy, podczas gdy kursor
        /// znajduje się nad obiektiem, który ma za zadanie wyświetlać i kontrolować suwak poziomu głośności.
        /// Wynikiem tego działania ma być zakończenie możliwości kontrolowania suwaka. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (element interfejsu). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void panelVolume_MouseUp(object sender, MouseEventArgs e) {
            sliderVolumeActive   =   false;
            SetVolumePosition();
        }

        // ----------------------------------------------------------------------
        //  Application PlayList Size
        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas wciśnięcia przycisku myszy, podczas gdy kursor
        /// znajduje się nad obiektem, który ma imitować panel do rozszerzania panelu z listą odtwarzania.
        /// Wynik tego działania powoduje aktywaję zmiany rozmiaru przez poruszanie kursorem po ekranie. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (element interfejsu). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void panelPlayListSplit_MouseDown(object sender, MouseEventArgs e) {
            resizePlayListActive    =   true;
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas gdy kursor z wciśniętym klawiszem myszy, porusza się
        /// po obiekcie który ma imitować panel do rozszerzania panelu z listą odtwarzania.
        /// Wynik tego działa powoduje zmianę rozmiaru listy odtwarzania. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (element interfejsu). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void panelPlayListSplit_MouseMove(object sender, MouseEventArgs e) {
            Point   curosr  =   panelVis.PointToClient( Cursor.Position );
            if ( resizePlayListActive ) {
                ResizePlayList( curosr.X + panelPlayListSplit.Width / 2 );
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas puszczenia przycisku myszy, podczas gdy kursor
        /// znajduje się nad obiektem, który ma imitować panel do rozszerzania panelu z listą odtwarzania.
        /// Wynik tego działania powoduje dezaktywaję możliwości zmiany rozmiaru listy odtwarzania. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (element interfejsu). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void panelPlayListSplit_MouseUp(object sender, MouseEventArgs e) {
            resizePlayListActive    =   false;
        }

        #endregion Sliders
        // ######################################################################
        //  x   x   xxxxx   x   x   x   x
        //  xx xx   x       xx  x   x   x
        //  x x x   xxxx    x x x   x   x
        //  x   x   x       x  xx   x   x
        //  x   x   xxxxx   x   x    xxx 
        // ######################################################################
        #region MainMenu
        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana po wciśnięciu przycisku "Home",
        /// powoduje otwarcie zakładki wyświetlającej wizualizację, bądź otwarcie/zamknięcie listy odtwarzania. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void buttonHome_Click(object sender, EventArgs e) {
            if ( !panelVis.Visible ) {
                pages.ShowPanel( panelVis );
                ResizePlayList( tlPanelPlayList.Width );
                RenderInterface();
                UpdateInterface();
            } else {
                if ( !tlPanelPlayList.Visible ) { tlPanelPlayList.Visible = true; }
                else { tlPanelPlayList.Visible = false; }
            }

            ButtonMenuHover( sender, e );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana po wciśnięciu przycisku "Library",
        /// powoduje otwarcie zakładki wyświetlającej bibliotekę (listę list odtwarzania). </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void buttonLibrary_Click(object sender, EventArgs e) {
            tlPanelPlayList.Visible = false;

            if ( !panelLibrary.Visible ) {
                pages.ShowPanel( panelLibrary );
                UpdateLibraryList();
                OpenLibrary( libraryOpened, libraryOpenedIndex );
            }

            ButtonMenuLeave( (object) buttonHome, e );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana po wciśnięciu przycisku "Explorer",
        /// powoduje otwarcie zakładki wyświetlającej przeglądarkę plików dźwiękowych. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void buttonFileExplorer_Click(object sender, EventArgs e) {
            tlPanelPlayList.Visible = false;

            if ( !panelExplorer.Visible ) {
                pages.ShowPanel( panelExplorer );
                filesManager.GetDiskList( comboBoxExplorerDisks );
                UpdateExplorer();
            }

            ButtonMenuLeave( (object) buttonHome, e );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana po wciśnięciu przycisku "Karaoke",
        /// powoduje otwarcie zakładki wyświetlającej listę z tekstem danej piosenki
        /// i możliwością jej modyfikacji. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void buttonKaraoke_Click(object sender, EventArgs e) {
            tlPanelPlayList.Visible = false;

            if ( !panelKaraoke.Visible ) {
                pages.ShowPanel( panelKaraoke );
                UpdateKaraokeInterface( karaokeData );
            }

            ButtonMenuLeave( (object) buttonHome, e );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana po wciśnięciu przycisku "Equalizer",
        /// powoduje otwarcie zakładki korektora graficznego i efektów dźwiękowych. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void buttonEqualizer_Click(object sender, EventArgs e) {
            tlPanelPlayList.Visible = false;

            if ( !panelEqualizer.Visible ) {
                pages.ShowPanel( panelEqualizer );
                UpdateEqualizer();
                EqualizerOpenPreset();
            }

            ButtonMenuLeave( (object) buttonHome, e );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana po wciśnięciu przycisku "Settings",
        /// powoduje otwarcie zakładki umożliwiającą skonfigurowanie programu. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void buttonSettings_Click(object sender, EventArgs e) {
            tlPanelPlayList.Visible = false;

            if ( !panelSettings.Visible ) {
                pages.ShowPanel( panelSettings );
            }

            ButtonMenuLeave( (object) buttonHome, e );
        }

        #endregion MainMenu
        // ######################################################################
        //  xxxx    x        xxx    x   x   xxxxx   xxxx 
        //  x   x   x       x   x   x   x   x       x   x
        //  xxxx    x       xxxxx    xxx    xxxx    xxxx 
        //  x       x       x   x     x     x       x   x
        //  x       xxxxx   x   x     x     xxxxx   x   x
        //
        //   xxx     xxx    x   x   xxxxx   xxxx     xxx    x    
        //  x   x   x   x   xx  x     x     x   x   x   x   x    
        //  x       x   x   x x x     x     xxxx    x   x   x    
        //  x   x   x   x   x  xx     x     x   x   x   x   x    
        //   xxx     xxx    x   x     x     x   x    xxx    xxxxx
        // ######################################################################
        #region PlayerControl
        // ----------------------------------------------------------------------
        /// <summary> Funkcja inicjująca moduł odtwarzacza muzyki. </summary>
        public void SoundMoudeInit() {
            UpdateSoundDevices();
            SoundModule.Init( this );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja ładująca plik dźwiękowy i konfigurująca interfejs
        /// do wyświetlenia informacji o danym utworze. </summary>
        /// <param name="file"> Obiekt z zapisanymi informacjami o pliku dźwiękowym, ścieżce, etc. </param>
        public void SoundMoudleLoadFile( CustomFile file ) {
            if ( SoundModule.IsActivated() ) { SoundModule.UnloadStream(); }
            if ( SoundModule.IsInitialized() ) {
                if ( SoundModule.LoadStream( file.GetFilePath() ) ) {

                    SoundModule.SetEqualizer( equalizerPresetData );
                    SoundModule.SetAmplification( true, equalizerEffectsData[0] );
                    SoundModule.SetSoftSaturation( equalizerEffectsData[1] > 0 ? true : false, equalizerEffectsData[2], equalizerEffectsData[3] );
                    SoundModule.SetStereoEnhancer( equalizerEffectsData[4] > 0 ? true : false, equalizerEffectsData[5], equalizerEffectsData[6] );
                    SoundModule.SetIRRDelay( equalizerEffectsData[7] > 0 ? true : false, equalizerEffectsData[8], equalizerEffectsData[9], equalizerEffectsData[10] );
                    SoundModule.SetEcho( equalizerEffectsData[11] > 0 ? true : false, equalizerEffectsData[12] );
                    SoundModule.SetReverb( equalizerEffectsData[13] > 0 ? true : false, equalizerEffectsData[14] );
                    SoundModule.SetChorus( equalizerEffectsData[15] > 0 ? true : false, equalizerEffectsData[16] );

                    string      title   =   CustomFileMetadata.GetMusicTitle( file );
                    string      artist  =   CustomFileMetadata.GetMusicArtist( file );
                    string      album   =   CustomFileMetadata.GetMusicAlbum( file );
                    Image[]     cover   =   CustomFileMetadata.GetMusicImage( file );

                    labelTitle.Text     =   title != null && title.Length > 0 ? title : file.GetFileName();
                    labelArtist.Text    =   artist != null && artist.Length > 0 ? "Artist: " + artist : "No artist";
                    labelAlbum.Text     =   album != null && album.Length > 0 ? "Album: " + album : "No album";
                    
                    if ( cover != null && cover.Length > 0 ) {
                        pictureBoxCover.Image       =   cover[0];
                        pictureBoxCover.SizeMode    =   PictureBoxSizeMode.StretchImage;
                    } else {
                        if ( darkMode ) { pictureBoxCover.Image = IconsControl._64_Stereo; }
                        else { pictureBoxCover.Image = IconsControl._64_White_Stereo; }
                    }
                    
                    SoundModulePlayPause();
                    karaokeIndex    =   0;
                    LoadKaraokeFile( file.GetFileName() );
                    labelKaraokeName.Text   =   file.GetFileName();
                }
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja przełączająca w module dźwiękowym stany Odtwarzanie/Wstrzymanie odtwarzania. </summary>
        public void SoundModulePlayPause() {
            if ( SoundModule.IsInitialized() ) {
                switch ( SoundModule.GetPlayStatus() ) {
                    case PlayStatus.Play:
                        SoundModule.Pause();
                        statusPlay  =   0;
                        break;
                    case PlayStatus.Pause:
                        SoundModule.Play();
                        statusPlay  =   1;
                        spectrum.InfoStartShow(
                            pictureBoxCover.Image,
                            new string[] { labelTitle.Text, labelArtist.Text, labelAlbum.Text }
                        );
                        // --- Notification ---
                        spectrum.InfoStartShow(
                            pictureBoxCover.Image,
                            new string[] { labelTitle.Text, labelArtist.Text, labelAlbum.Text }
                        );
                        break;
                    case PlayStatus.Stop:
                        SoundModule.Play();
                        statusPlay  =   1;
                        // --- Notification ---
                        ShowNotyfication( labelTitle.Text );
                        spectrum.InfoStartShow(
                            pictureBoxCover.Image,
                            new string[] { labelTitle.Text, labelArtist.Text, labelAlbum.Text }
                        );
                        break;
                }

                int[] options = new int[4] { statusPlay, statusMute, statusRepeat, statusShuffle };
                InterfaceDrawer.ControlButtonDraw( buttonPlay, darkMode, options );
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zatrzymująca odtwarzanie muzyki. </summary>
        public void SoundModuleStop() {
            if ( SoundModule.IsInitialized() ) {
                SoundModule.Stop();
                statusPlay  =   0;
            }

            int[] options = new int[4] { statusPlay, statusMute, statusRepeat, statusShuffle };
            InterfaceDrawer.ControlButtonDraw( buttonPlay, darkMode, options );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wybierająca z listy odtwarzania, kolejne określone przez ustawienia i kolejność
        /// nagranie (plik dźwiękowy) i uruchamiająca jego odtwarzanie. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (obiekt). </param>
        public void SoundModuleNext(object sender) {
            if ( sender == null ) {
                if ( statusRepeat == 1 ) {
                    DiselectNowPlaying();
                    SetNowPlaying( playingIndex );
                    return;
                }
            }

            if ( statusShuffle == 1 ) {
                Random  random  =   new Random();
                DiselectNowPlaying();
                playingIndex    =   random.Next( 0, playList.GetCount()-1 );
                SetNowPlaying( playingIndex );
                return;
            }

            if ( playingIndex < playList.GetCount()-1 ) {
                DiselectNowPlaying();
                playingIndex++;
                SetNowPlaying( playingIndex );

            } else if ( playList.GetCount() > 0 ) {
                if ( statusAutoBack && statusAutoPlay ) {
                    SelectNowPlaying( 0 );
                    SoundMoudleLoadFile( playList.GetFile( this.playingIndex ) );
                }
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wybierająca z listy odtwarzania, poprzednie nagranie (plik dźwiękowy). </summary>
        public void SoundModulePrevious() {
            if ( playingIndex > 0 ) {
                DiselectNowPlaying();
                playingIndex--;
                SetNowPlaying( playingIndex );
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja aktualizująca pozycję odtwrzania w module dźwiękowym
        /// na bazie aktualnej pozycji suwaka odtwarzania. </summary>
        public void SoundModuleSetPosition() {
            if ( SoundModule.IsActivated() ) {
                long new_position = sliderMusic.GetPosition() * SoundModule.GetLength() / sliderMusic.GetSpaceWidth();
                SoundModule.SetPosition( new_position );
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja aktualizująca ikony przycisków w interfejsie głównym,
        /// na bazie informacji pobranych z modułu dźwiękowego, (czy muzyka jest aktualnie odtwrzania). </summary>
        public void UpdateIcons() {
            if ( SoundModule.GetPlayStatus() == PlayStatus.Play ) { statusPlay = 1; }
            else { statusPlay = 0; }

            int[] options = new int[4] { statusPlay, statusMute, statusRepeat, statusShuffle };
            InterfaceDrawer.ControlButtonDraw( buttonPlay, darkMode, options );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja aktualizująca pozycję suwaka odtwarzania
        /// na bazie pozycji odtwarzania nagrania w module dźwiękowym. </summary>
        public void UpdatePosition() {
            if ( sliderMusicActive ) { return; }
            sliderMusic.SetPosition( SoundModule.GetLength(), SoundModule.GetPosition() );
            panelSlider.Invalidate();
        }

        // ----------------------------------------------------------------------
        /// <summary> Funckcja pobierająca czas z modułu odtwarzania i aktualizująca go w interfejsie aplikacji. </summary>
        public void UpdateTime() {
            int[]   time    =   SoundModule.GetCurrentTime();
            int[]   reverse =   SoundModule.GetReverseTime();

            labelTime.Text  =   (time[0]<10 ? "0"+time[0].ToString() : time[0].ToString()) + ":"
                +   (time[1]<10 ? "0"+time[1].ToString() : time[1].ToString()) + ":"
                +   (time[2]<10 ? "0"+time[2].ToString() : time[2].ToString());

            labelTimeLeft.Text  =   (reverse[0]<10 ? "0"+ reverse[0].ToString() : reverse[0].ToString()) + ":"
                +   (reverse[1]<10 ? "0"+ reverse[1].ToString() : reverse[1].ToString()) + ":"
                +   (reverse[2]<10 ? "0"+ reverse[2].ToString() : reverse[2].ToString());
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wyświetlająca wygenerowaną klatkę wizualizacji w interfejsie aplikacji. </summary>
        public void DrawVisualisation() {
            Image   visualisation   =   spectrum.GetDrawnSpectrum();
            if ( visualisation != null ) { panelVis.BackgroundImage = visualisation; }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja aktualizująca pozycję poziomu dźwięku aplikacji w module głośności
        /// na bazie aktualnej pozycji suwaka poziomu głośności. </summary>
        public void SetVolumePosition() {
            int new_position    =   (sliderVolume.GetPosition()-16) * 100 / sliderVolume.GetSpaceWidth();
            ApplicationVolume.SetVolume( new_position );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wyciszająca dźwięk aplikacji w module głośności. </summary>
        public void MuteVolumePosition() {
            int new_position    =   (sliderVolume.GetPosition()-16) * 100 / sliderVolume.GetSpaceWidth();
            if ( statusMute > 0 ) { mutePosition = new_position; }
            else { new_position = mutePosition; }
            ApplicationVolume.Mute( statusMute > 0 ? true : false, new_position );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja aktualizująca pozycję suwaka głośności
        /// na bazie poziomu głośności w module głośności. </summary>
        public void UpdateVolumePosition() {
            sliderVolume.SetPosition( 100, ApplicationVolume.GetVolume() );
            panelVolume.Invalidate();
        }

        #endregion PlayerControl
        // ######################################################################
        //   xxx     xxx    x   x   xxxxx   xxxx     xxx    x    
        //  x   x   x   x   xx  x     x     x   x   x   x   x    
        //  x       x   x   x x x     x     xxxx    x   x   x    
        //  x   x   x   x   x  xx     x     x   x   x   x   x    
        //   xxx     xxx    x   x     x     x   x    xxx    xxxxx
        //
        //  x   x   xxxxx   x   x   x   x
        //  xx xx   x       xx  x   x   x
        //  x x x   xxxx    x x x   x   x
        //  x   x   x       x  xx   x   x
        //  x   x   xxxxx   x   x    xxx 
        // ######################################################################
        #region ControlMenu
        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonująca się po wciśnięciu przycisku "Shuffle" w części kontrolnej,
        /// powoduje aktywację bądź dezaktywajcę opcji odtwarzania losowego, nagrań z listy odtwarzania. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void buttonShuffle_Click(object sender, EventArgs e) {
            if ( statusShuffle == 0 ) { statusShuffle = 1; } else { statusShuffle = 0; }
            //int[] options = new int[4] { statusPlay, statusMute, statusRepeat, statusShuffle };
            //InterfaceDrawer.ControlButtonDraw( buttonShuffle, darkMode, options );
            ButtonControlLeave( (object) sender, e );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonująca się po wciśnięciu przycisku "Repeat" w części kontrolnej,
        /// powoduje aktywację bądź dezaktywajcę opcji powtarzania konkretnego nagrania z listy odtwarzania. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void buttonRepeat_Click(object sender, EventArgs e) {
            if ( statusRepeat == 0 ) { statusRepeat = 1; } else { statusRepeat = 0; }
            //int[] options = new int[4] { statusPlay, statusMute, statusRepeat, statusShuffle };
            //InterfaceDrawer.ControlButtonDraw( buttonRepeat, darkMode, options );
            ButtonControlLeave( (object) sender, e );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonująca się po wciśnięciu przycisku "Previous" w części kontrolnej,
        /// powoduje wykonanie funkcji wybrania poprzedniego nagrania z listy odtwarzania. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void buttonPrevious_Click(object sender, EventArgs e) {
            SoundModulePrevious();
            ButtonControlLeave( (object) sender, e );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonująca się po wciśnięciu przycisku "Play" w części kontrolnej,
        /// powoduje wykonanie funkcji uruchomienia odtwarzania bądź pauzy. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void buttonPlay_Click(object sender, EventArgs e) {
            SoundModulePlayPause();
            ButtonControlLeave( (object) sender, e );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonująca się po wciśnięciu przycisku "Forward" w części kontrolnej,
        /// powoduje wykonanie funkcji wybrania następnego nagrania z listy odtwarzania. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void buttonForward_Click(object sender, EventArgs e) {
            SoundModuleNext( sender );
            ButtonControlLeave( (object) sender, e );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonująca się po wciśnięciu przycisku "Stop" w części kontrolnej,
        /// powoduje wykonanie funkcji zatrzymania odtwarzania. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void buttonStop_Click(object sender, EventArgs e) {
            SoundModuleStop();
            ButtonControlLeave( (object) sender, e );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonująca się po wciśnięciu przycisku "Volume" w części kontrolnej,
        /// pwzoduje wykonanie funkcji wyciszenia dźięku aplikacji. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (przycisk). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void buttonVolume_Click(object sender, EventArgs e) {
            if ( statusMute == 0 ) { statusMute = 1; } else { statusMute = 0; }
            int[] options = new int[4] { statusPlay, statusMute, statusRepeat, statusShuffle };
            InterfaceDrawer.ControlButtonDraw( buttonVolume, darkMode, options );
            ButtonControlLeave( (object) sender, e );
            MuteVolumePosition();
        }

        #endregion ControlMenu
        // ######################################################################
        //  xxxxx   xxxx     xxx    x   x
        //    x     x   x   x   x   x   x
        //    x     xxxx    xxxxx    xxx 
        //    x     x   x   x   x     x  
        //    x     x   x   x   x     x  
        //
        //  x   x    xxx    xxxxx   xxxxx   xxxxx   x   x
        //  xx  x   x   x     x       x     x       x   x
        //  x x x   x   x     x       x     xxxx     xxx 
        //  x  xx   x   x     x       x     x         x  
        //  x   x    xxx      x     xxxxx   x         x  
        // ######################################################################
        #region Notification
        // ----------------------------------------------------------------------
        /// <summary> Funkcja inicjująca wyświetlenie się powiadomienia na pulpicie w systemie Windows,
        /// jeżeli aktywna jest ikona aplikacji w menu zasobnika systemu. </summary>
        /// <param name="title"> Tytuł powiadomienia. </param>
        public void ShowNotyfication( string title ) {
            if ( notifyIcon.Visible && (title != null && title != "") ) {
                notifyIcon.BalloonTipTitle  =   "Now Playing";
                notifyIcon.BalloonTipText   =   title;
                notifyIcon.ShowBalloonTip( 100 );
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas kliknięcia ikony aplikacji w menu zasobnika systemowego,
        /// powoduje minimalizację, bądź maskymalizację aplikacji. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (trayIcon). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void notifyIcon_DoubleClick(object sender, EventArgs e) {
            if ( isMinimalized() ) { Maximalize(); }
            else { Minimalize(); }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas klinięcia elementu "toolStripMenuItemAnthraX" menu ikony aplikacji
        /// z zasobnika systemowego, powoduje minimalizację, bądź maksymalizację aplikacji. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (toolStripMenuItem). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void toolStripMenuItemAnthraX_Click(object sender, EventArgs e) {
            if ( isMinimalized() ) { Maximalize(); }
            else { Minimalize(); }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas klinięcia elementu "toolStripMenuItemPlay" menu ikony aplikacji
        /// z zasobnika systemowego, powoduje wykonanie funkcji odpowiadającej uruchomieniu odtwarzania muzyki,
        /// bądź jej wstrzymanie. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (toolStripMenuItem). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void toolStripMenuItemPlay_Click(object sender, EventArgs e) {
            SoundModulePlayPause();
        }

        // ----------------------------------------------------------------------
        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas klinięcia elementu "toolStripMenuItemPrevious" menu ikony aplikacji
        /// z zasobnika systemowego, powoduje wykonanie funkcji wybrania poprzedniego nagrania z listy odtwarzania. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (toolStripMenuItem). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void toolStripMenuItemPrevious_Click(object sender, EventArgs e) {
            SoundModulePrevious();
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas klinięcia elementu "toolStripMenuItemNext" menu ikony aplikacji
        /// z zasobnika systemowego, powoduje wykonanie funkcji wybrania następnego nagrania z listy odtwarzania. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (toolStripMenuItem). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void toolStripMenuItemNext_Click(object sender, EventArgs e) {
            SoundModuleNext( sender );
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas klinięcia elementu "toolStripMenuItemStop" menu ikony aplikacji
        /// z zasobnika systemowego, powoduje wykonanie funkcji wybrania zatrzymania odtwarzania. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (toolStripMenuItem). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void toolStripMenuItemStop_Click(object sender, EventArgs e) {
            SoundModuleStop();
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas klinięcia elementu "toolStripMenuItemExit" menu ikony aplikacji
        /// z zasobnika systemowego, powoduje wykonanie funkcji zamknięcia aplikacji. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (toolStripMenuItem). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void toolStripMenuItemExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        #endregion Notification
        // ######################################################################
        //  xxxx    x        xxx    x   x     x       xxxxx    xxxx   xxxxx
        //  x   x   x       x   x   x   x     x         x     x         x  
        //  xxxx    x       xxxxx    xxx      x         x      xxx      x  
        //  x       x       x   x     x       x         x         x     x  
        //  x       xxxxx   x   x     x       xxxxx   xxxxx   xxxx      x  
        //
        //  x       xxxxx    xxxx   xxxxx     x   x   xxxxx   xxxxx   x   x
        //  x         x     x         x       x   x     x     x       x   x
        //  x         x      xxx      x       x   x     x     xxxx    x x x
        //  x         x         x     x        x x      x     x       xx xx
        //  xxxxx   xxxxx   xxxx      x         x     xxxxx   xxxxx   x   x
        // ######################################################################
        #region PlayListView
        // ----------------------------------------------------------------------
        //  Component Configuration and Actions
        // ----------------------------------------------------------------------
        /// <summary> Funkcja aktualizująca listę w komponencie listy odtwarzania interfejsu aplikacji. </summary>
        private void UpdateNowPlaying() {
            listViewNowPlaying.Items.Clear();

            for ( int i = 0; i < playList.GetCount(); i++ ) {
                var item    =   new ListViewItem( playList.GetFile(i).GetFileName() );
                int offset  =   darkMode ? 6 : 0;

                if ( i == playingIndex ) { item.ImageIndex = (0 + offset); }
                else { SetIconNowPlaying( playList.GetFile(i), item ); }
                listViewNowPlaying.Items.Add( item );
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja przypisująca ikonę do konkretnego elementu
        /// komponentu listy odtwarznia interfejsu apliakcji. </summary>
        /// <param name="file"> Obiekt z zapisanymi informacjami o pliku dźwiękowym, ścieżce, etc. </param>
        /// <param name="item"> Element listy odtwarzania. </param>
        private void SetIconNowPlaying( CustomFile file, ListViewItem item ) {
            if ( file == null ) { return; }
            switch ( file.GetFileType() ) {
                case FileType.Unknown:  item.ImageIndex = (1); break;
                case FileType.Music:    item.ImageIndex = (2); break;
                case FileType.Picture:  item.ImageIndex = (3); break;
                case FileType.Video:    item.ImageIndex = (4); break;
                case FileType.Text:     item.ImageIndex = (5); break;
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zaznaczająca i przypisująca ikonę aktywnemu elementowi,
        /// odpowiadającemu plikowi dźwięku odtwarzanego przez moduł dźwiękowy, interfejsu aplikacji. </summary>
        private void SelectNowPlaying() {
            int index   =   playingIndex;

            if ( index >= 0 && index < listViewNowPlaying.Items.Count ) {
                CustomFile  file    =   playList.GetFile( index );
                int         offset  =   darkMode ? 6 : 0;

                listViewNowPlaying.Items[index].ImageIndex  =   (0 + offset);
                playingIndex                                =   index;
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zaznaczająca i przypisująca ikonę elementowi o określonym indeksie,
        /// interfejsu aplikacji. </summary>
        /// <param name="index"> Indeks aktywnego elementu który ma zostać zaznaczony. </param>
        private void SelectNowPlaying( int index ) {
            if ( index >= 0 && index < listViewNowPlaying.Items.Count ) {
                CustomFile  file    =   playList.GetFile( index );
                int         offset  =   darkMode ? 6 : 0;

                listViewNowPlaying.Items[index].ImageIndex  =   (0 + offset);
                playingIndex                                =   index;
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja odznaczająca i przypisująca domyślą ikonę poprzedniemu aktywnemu elementowi,
        /// odpowiadającemu plikowi dźwięku odtwarzanego przez moduł dźwiękowy, interfejsu aplikacji. </summary>
        private void DiselectNowPlaying() {
            CustomFile  file    =   playList.GetFile( playingIndex );
            int         index   =   playingIndex;
            int         offset  =   darkMode ? 6 : 0;

            if ( index >= 0 && index < listViewNowPlaying.Items.Count ) {
                SetIconNowPlaying( file, listViewNowPlaying.Items[index] );
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja zaznaczająca i przypisująca ikonę elementowi o określonym indeksie,
        /// interfejsu aplikacji. </summary>
        /// <param name="index"> Indeks aktywnego elementu który ma zostać zaznaczony. </param>
        private void DiselectNowPlaying( int index ) {
            if ( index >= 0 && index < listViewNowPlaying.Items.Count ) {
                CustomFile  file    =   playList.GetFile( index );
                int         offset  =   darkMode ? 6 : 0;
                SetIconNowPlaying( file, listViewNowPlaying.Items[index] );
            }
        }

        // ----------------------------------------------------------------------
        //  Component User Actions
        // ----------------------------------------------------------------------
        /// <summary> Funkcja zaznaczająca, przypisują ikonę danemu elementowi listy odtwarzania interfejsu aplikacji
        /// i wybierająca do odtwarzania plik o określonym indeksie </summary>
        /// <param name="index"> Indeks aktywnego elementu który ma zostać zaznaczony. </param>
        private void SetNowPlaying( int index ) {
            if ( index >= 0 && index < listViewNowPlaying.Items.Count ) {
                CustomFile  file    =   playList.GetFile( index );
                int         offset  =   darkMode ? 6 : 0;

                listViewNowPlaying.Items[index].ImageIndex  =   (0 + offset);
                playingIndex                                =   index;
                SoundMoudleLoadFile( file );
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja aktywująca wybrany przez użytkownika utwór do odtwarzania z listy odtwarzania. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (listViewItem). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void listViewNowPlaying_DoubleClick(object sender, EventArgs e) {
            if ( listViewNowPlaying.SelectedItems.Count > 0 ) {
                DiselectNowPlaying( this.playingIndex );
                SetNowPlaying( listViewNowPlaying.SelectedItems[0].Index );
            }

            listViewNowPlaying.SelectedItems.Clear();
        }

        // ----------------------------------------------------------------------
        //  Component Manage Items
        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas kliknięcia przyciskiem myszy na element
        /// z listy odtwarzania interfejsu aplikacji, kiedy kursor się na nim znajdował,
        /// w celu uruchomienia opcji przeniesienia danego elementu na inną pozycję w liście. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (listViewItem). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void listViewNowPlaying_MouseDown(object sender, MouseEventArgs e) {
            ListViewItem    itemDrag    =   listViewNowPlaying.GetItemAt( e.X, e.Y );
            if ( itemDrag == null ) { return; }

            playListDragDrop    =   true;
            playListDragIndex   =   itemDrag.Index;

            if ( listViewNowPlaying.SelectedItems.Count > 0 ) {
                playListDragArray   =   new int[ listViewNowPlaying.SelectedItems.Count ];
                for ( int i = 0; i < listViewNowPlaying.SelectedItems.Count; i++ ) {
                    playListDragArray[i] = listViewNowPlaying.SelectedItems[i].Index;
                }

            } else {
                playListDragArray       =   new int[1];
                playListDragArray[0]    =   playListDragIndex;
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja wykonywana podczas puszczenia przycisku myszy na element
        /// z listy odtwarzania interfejsu aplikacji, kiedy kursor się na nim znajdował,
        /// w celu dezaktywacji opcji przeniesienia danego elementu na inną pozycję w liście
        /// i pozostawienia go go tam. </summary>
        /// <param name="sender"> Obiekt przekazywany funkcji (listViewItem). </param>
        /// <param name="e"> Paramentry wykonywanej funkcji. </param>
        private void listViewNowPlaying_MouseUp(object sender, MouseEventArgs e) {
            if ( !playListDragDrop ) { return; }

            ListViewItem    itemDrag    =   listViewNowPlaying.GetItemAt( e.X, e.Y );
            if ( itemDrag == null ) { return; }
            if ( playListDragIndex == -1 ) { return; }
            if ( itemDrag.Index == playListDragIndex ) { return; }

            int         dropPosition    =   itemDrag.Index;
            CustomFile  playingIndex    =   playList.GetFile( this.playingIndex );
            Array.Sort( playListDragArray );

            if ( playListDragArray.Length == 1 ) {
                // --- Move one selected item ---
                playList.MovePosition( playListDragArray[0], dropPosition );
                System.Console.WriteLine( listViewNowPlaying.Items[ playListDragArray[0] ].ToString() );

            } else if ( playListDragArray.Length > 1 ) {
                // --- Move multiple selected items ---
                int middlePoint     =   0;
                int selectedLength  =   playListDragArray.Length - 1;
                
                if ( dropPosition < playListDragArray[0] ) { middlePoint = 0; }
                else if ( dropPosition > playListDragArray[selectedLength] ) { middlePoint = selectedLength; }
                else {
                    // --- Searching middle drop point of selected items ---
                    for ( int mp = 0; mp <= selectedLength; mp++ ) {
                        if ( dropPosition >= playListDragArray[mp] && dropPosition < playListDragArray[mp+1] ) {
                            middlePoint = mp;
                            break;
                        }
                    }
                }

                // --- Inserting lower items than dropPosition ---
                dropPosition    =   itemDrag.Index-1;
                for ( int i = middlePoint; i >= 0; i-- ) {
                    System.Console.WriteLine( listViewNowPlaying.Items[ playListDragArray[i] ].ToString() );
                    playList.MovePosition( playListDragArray[i], dropPosition );
                    dropPosition--;
                }

                // --- Inserting higher items than dropPosition ---
                dropPosition    =   itemDrag.Index;
                for ( int i = middlePoint+1; i <= selectedLength; i++ ) {
                    System.Console.WriteLine( listViewNowPlaying.Items[ playListDragArray[i] ].ToString() );
                    playList.MovePosition( playListDragArray[i], dropPosition );
                    dropPosition++;
                }
            }

            playListDragDrop    =   false;
            playListDragIndex   =   -1;
            playListDragArray   =   null;
            UpdateNowPlaying();
            DiselectNowPlaying( this.playingIndex );
            SelectNowPlaying( playList.IndexOf( playingIndex ) );
        }

        #endregion PlayListView
        // ######################################################################
        //  xxxx    x        xxx    x   x     x       xxxxx    xxxx   xxxxx
        //  x   x   x       x   x   x   x     x         x     x         x  
        //  xxxx    x       xxxxx    xxx      x         x      xxx      x  
        //  x       x       x   x     x       x         x         x     x  
        //  x       xxxxx   x   x     x       xxxxx   xxxxx   xxxx      x  
        //
        //  x   x   xxxxx   x   x   x   x
        //  xx xx   x       xx  x   x   x
        //  x x x   xxxx    x x x   x   x
        //  x   x   x       x  xx   x   x
        //  x   x   xxxxx   x   x    xxx 
        // ######################################################################
        #region PlayListMenu
        // ----------------------------------------------------------------------
        private void buttonPlayListOpen_Click(object sender, EventArgs e) {
            string  initPath        =   Tools.GetDirectoryHome();
            string  playlistPath    =   Tools.PlayListSelector( initPath );

            if ( File.Exists( playlistPath ) ) {
                CustomFile  playingIndex    =   playList.GetFile( this.playingIndex );
                DiselectNowPlaying();
                playList.Clear();

                Encoding    encode  =   Encoding.GetEncoding( "Windows-1250" );
                foreach ( string filePath in File.ReadAllLines( playlistPath, encode ) ) {
                    if ( File.Exists( filePath ) ) {
                        CustomFile  file    =   new CustomFile( filePath );
                        playList.Add( file );
                    }
                }

                UpdateNowPlaying();
                // --- AUTOPLAY ---
                if ( statusAutoPlay && playList.GetCount() > 0 ) {
                    SelectNowPlaying( 0 );
                    SoundMoudleLoadFile( playList.GetFile( this.playingIndex ) );
                }
            }
        }

        // ----------------------------------------------------------------------
        private void buttonPlayListSave_Click(object sender, EventArgs e) {
            string  initPath    =   Tools.GetDirectoryHome();
            string  filePath    =   Tools.PlayListSaver( initPath );
            
            if ( filePath == "" ) { return; }
            string  fileName    =   Path.GetFileNameWithoutExtension( filePath );

            if ( File.Exists( filePath ) ) {
                string  title           =   "Library manager";
                string  message         =   "Do you want to overwrite \"" + fileName + "\" playlist file?";
                DialogResult    result  =   MessageBox.Show( message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation );
                if ( result == DialogResult.No ) { return; }
            }

            SaveLibraryDialog( playList );
        }

        // ----------------------------------------------------------------------
        private void buttonPlayListClear_Click(object sender, EventArgs e) {
            if ( listViewNowPlaying.SelectedItems.Count <= 0 ) { return; }
            if ( playList == null ) { return; }

            CustomFile  playingFile     =   playList.GetFile( this.playingIndex );
            int         count           =   listViewNowPlaying.SelectedItems.Count;
            int[]       itemsIndexes    =   new int[ listViewNowPlaying.SelectedItems.Count ];

            for ( int i = 0; i < count; i++ ) { itemsIndexes[i] = listViewNowPlaying.SelectedItems[i].Index; }
            itemsIndexes    =   itemsIndexes.OrderByDescending(i => i).ToArray();

            foreach( int index in itemsIndexes ) { playList.Remove( index ); }
            DiselectNowPlaying( this.playingIndex );
            this.playingIndex   =   playList.IndexOf( playingFile );
            UpdateNowPlaying();
        }

        // ----------------------------------------------------------------------
        private void buttonPlayListMoveUp_Click(object sender, EventArgs e) {
            CustomFile  playingIndex    =   playList.GetFile( this.playingIndex );
            int         itemsCount      =   listViewNowPlaying.SelectedItems.Count;

            for ( int i = 0; i < itemsCount; i++ ) {
                int index   =   listViewNowPlaying.SelectedItems[i].Index;
                if ( index <= 0 ) { continue; }
                playList.MovePosition( index, index-1 );
            }

            UpdateNowPlaying();
            DiselectNowPlaying( this.playingIndex );
            SelectNowPlaying( playList.IndexOf( playingIndex ) );
        }

        // ----------------------------------------------------------------------
        private void buttonPlayListMoveDown_Click(object sender, EventArgs e) {
            CustomFile  playingIndex    =   playList.GetFile( this.playingIndex );
            int         itemsCount      =   listViewNowPlaying.SelectedItems.Count;

            for ( int i = itemsCount-1; i >= 0; i-- ) {
                int index   =   listViewNowPlaying.SelectedItems[i].Index;
                if ( index >= listViewNowPlaying.Items.Count - 1 ) { continue; }
                playList.MovePosition( index, index+1 );
            }

            UpdateNowPlaying();
            DiselectNowPlaying( this.playingIndex );
            SelectNowPlaying( playList.IndexOf( playingIndex ) );
        }

        // ----------------------------------------------------------------------
        private void buttonPlayListSort_Click(object sender, EventArgs e) {
            CustomFile  playingIndex    =   playList.GetFile( this.playingIndex );
            
            playList.SortByFileName();
            
            UpdateNowPlaying();
            DiselectNowPlaying( this.playingIndex );
            SelectNowPlaying( playList.IndexOf( playingIndex ) );
        }

        #endregion PlayListMenu
        // ######################################################################
        //  xxxx    x        xxx    x   x   xxxxx   xxxx 
        //  x   x   x       x   x   x   x   x       x   x
        //  xxxx    x       xxxxx    xxx    xxxx    xxxx 
        //  x       x       x   x     x     x       x   x
        //  x       xxxxx   x   x     x     xxxxx   x   x
        //
        //  xxxxx   x   x   xxxx    xxxxx    xxx    xxxx 
        //    x     x   x   x   x   x       x   x    x  x
        //    x     xxxxx   xxxx    xxxx    xxxxx    x  x
        //    x     x   x   x   x   x       x   x    x  x
        //    x     x   x   x   x   xxxxx   x   x   xxxx 
        // ######################################################################
        #region PlayerThread
        // ----------------------------------------------------------------------
        private void StartPlayerThread() {
            if ( playerThread == null ) { playerThread = new Thread( UpdatePlayerThread ); }
            else if ( !playerThread.IsAlive ) {
                if ( playerThread.ThreadState == ThreadState.Aborted || playerThread.ThreadState == ThreadState.Stopped ) {
                    playerThread = new Thread( UpdatePlayerThread );
                }
            }

            playerThreadEnabled = true;
            playerThread.Start();
        }

        // ----------------------------------------------------------------------
        private void StopPlayerThread() {
            playerThreadEnabled = false;

            if ( playerThread == null ) { return; }
            if ( playerThread.IsAlive ) {
                if ( playerThread.ThreadState == ThreadState.Suspended ) { playerThread.Resume(); }
                playerThread.Abort();
            }

            playerThread = null;
        }

        // ----------------------------------------------------------------------
        private void UpdatePlayerThread() {
            while ( playerThreadEnabled ) {

                // --- Update Visualisation Elements ---
                try { 
                    spectrum.DrawBackground();
                    spectrum.DrawLogo();
                } catch ( Exception exc ) { System.Console.WriteLine( exc.ToString() ); }

                if (  SoundModule.IsActivated() ) {
                    if ( SoundModule.GetPlayStatus() == PlayStatus.Play ) {
                        // --- Update Player Data ---
                        try {
                            this.Invoke( new InvokeInterface( () => { labelKaraokeTime.Text = "Variable Time:" + Environment.NewLine + SoundModule.GetPosition().ToString(); } ));
                            this.Invoke( new InvokeInterface( () => { UpdatePosition(); } ));
                            this.Invoke( new InvokeInterface( () => { UpdateTime(); } ));
                        } catch ( Exception exc ) { System.Console.WriteLine( exc.ToString() ); }
                        // --- Update Visualisation Data ---
                        try {
                            int size    =   (int) BASSData.BASS_DATA_FFT2048;
                            int length  =   1024;
                            spectrum.DrawSpectrum( SoundModule.GetSpectrumData( size, length ), length );
                            if ( statusKaraoke ) {
                                spectrum.DrawLyrics( GetKaraoke( karaokeIndex, SoundModule.GetPosition() ) );
                            }
                        } catch ( Exception exc ) { System.Console.WriteLine( exc.ToString() ); }
                        
                    } else if ( SoundModule.GetPlayStatus() == PlayStatus.Stop ) {
                        // --- Play next play list track ---
                        if ( SoundModule.GetPosition() >= SoundModule.GetLength()-1 ) {
                            SoundModule.SetPosition( 0 );
                            try {
                                this.Invoke( new InvokeInterface( () => { SoundModuleNext(null); } ));
                                this.Invoke( new InvokeInterface( () => { UpdateIcons(); } ));
                            } catch ( Exception exc ) { System.Console.WriteLine( exc.ToString() ); }
                        }
                        // --- Update No Visualisation ---
                        try {
                            spectrum.DrawNoSpectrum();
                        } catch ( Exception exc ) { System.Console.WriteLine( exc.ToString() ); }
                    }

                    // --- Update Infrmations ---
                    try {
                        spectrum.DrawInformations( labelTime.Text );
                    } catch ( Exception exc ) { System.Console.WriteLine( exc.ToString() ); }
                } else {
                    // --- Update No Visualisation ---
                    try {
                        spectrum.DrawNoSpectrum();
                    } catch ( Exception exc ) { System.Console.WriteLine( exc.ToString() ); }
                }

                try { 
                    // --- Update Channel Meters ---
                    int[]   channelMeters   =   SoundModule.GetChannelMeters();
                    if ( panelSettings.Visible && fLPanelSettingsSound.Visible ) {
                        try {
                            this.Invoke( new InvokeInterface( () => {
                                progressBarSoundLeft.Value      =   channelMeters[0];
                                progressBarSoundRight.Value     =   channelMeters[1];
                            } ));
                        } catch { }
                    }

                    // --- Draw Visualisation ---
                    if ( this.WindowState != FormWindowState.Minimized && panelVis.Visible ) {
                        panelVis.Invoke( new InvokeInterface( () => {
                            Image   visualisation   =   spectrum.GetDrawnSpectrum();
                            if ( visualisation != null ) { panelVis.BackgroundImage = visualisation; }
                        } ));
                    }

                    // --- Update Volume Position ---
                    if ( this.WindowState != FormWindowState.Minimized ) {
                        panelVolume.Invoke( new InvokeInterface( () => { 
                            if ( !sliderVolumeActive ) { UpdateVolumePosition(); }
                        } ));
                    }

                } catch ( Exception exc ) { System.Console.WriteLine( exc.ToString() ); }

                Thread.Sleep( playerThreadSleep );
            }
        }

        #endregion PlayerThread
        // ######################################################################
        //  xxxxx   xxxxx   x       xxxxx
        //  x         x     x       x    
        //  xxxx      x     x       xxxx 
        //  x         x     x       x    
        //  x       xxxxx   xxxxx   xxxxx
        //
        //  x   x    xxx    x   x    xxx      xxxx   xxxxx   xxxx 
        //  xx xx   x   x   xx  x   x   x    x       x       x   x
        //  x x x   xxxxx   x x x   xxxxx    x  xx   xxxx    xxxx 
        //  x   x   x   x   x  xx   x   x    x   x   x       x   x
        //  x   x   x   x   x   x   x   x     xxxx   xxxxx   x   x
        // ######################################################################
        #region FileManager
        // ----------------------------------------------------------------------
        private void buttonExplorerBack_Click(object sender, EventArgs e) {
            filesManager.GoBack();
            UpdateExplorer();
        }

        // ----------------------------------------------------------------------
        private void buttonExplorerNext_Click(object sender, EventArgs e) {
            filesManager.GoForward();
            UpdateExplorer();
        }

        // ----------------------------------------------------------------------
        private void buttonExplorerGo_Click(object sender, EventArgs e) {
            filesManager.GoTo( textBoxExplorerPath.Text );
            UpdateExplorer();
        }

        // ----------------------------------------------------------------------
        private void textBoxExplorerPath_KeyPress(object sender, KeyPressEventArgs e) {
            if ( e.KeyChar == (char)13 ) { buttonExplorerGo_Click(sender, null); }
        }

        // ----------------------------------------------------------------------
        private void buttonSearch_Click(object sender, EventArgs e) {
            filesManager.SetSearchPhrase( textBoxExplorerSearch.Text );
            UpdateExplorer();
        }

        // ----------------------------------------------------------------------
        private void textBoxExplorerSearch_Enter(object sender, EventArgs e) {
            ((TextBox)sender).Text  =   "";
        }

        // ----------------------------------------------------------------------
        private void textBoxExplorerSearch_Leave(object sender, EventArgs e) {
            ((TextBox)sender).Text  =   "Search";
        }

        // ----------------------------------------------------------------------
        private void textBoxExplorerSearch_KeyPress(object sender, KeyPressEventArgs e) {
            if ( e.KeyChar == (char)13 ) { buttonSearch_Click(sender, null); }
        }

        // ----------------------------------------------------------------------
        private void buttonExplorerFilter_Click(object sender, EventArgs e) {
            int         index       =   comboBoxExplorerFilter.SelectedIndex;
            FilterType  filterType  =   (FilterType) index;
            filesManager.SetFilter( filterType );
            UpdateExplorer();
        }

        // ----------------------------------------------------------------------
        private void comboBoxExplorerFilter_SelectionChangeCommitted(object sender, EventArgs e) {
            int         index       =   ((ComboBox)sender).SelectedIndex;
            FilterType  filterType  =   (FilterType) index;
            filesManager.SetFilter( filterType );
            UpdateExplorer();
        }

        // ----------------------------------------------------------------------
        private void comboBoxExplorerDisks_SelectionChangeCommitted(object sender, EventArgs e) {
            int index   =   ((ComboBox)sender).SelectedIndex;
            filesManager.SelectDisk( index );
            UpdateExplorer();
        }

        // ----------------------------------------------------------------------
        private void treeViewExplorerDirectories_DoubleClick(object sender, EventArgs e) {
            TreeNode    node    =   ((TreeView)sender).SelectedNode;
            int         index   =   comboBoxExplorerDisks.SelectedIndex;
            filesManager.SelectDirectory( node, index );
            UpdateExplorer();
        }

        // ----------------------------------------------------------------------
        private void listViewExplorerFiles_DoubleClick(object sender, EventArgs e) {
            if ( listViewExplorerFiles.SelectedItems.Count <= 0 ) { return; }
            int     count       =   listViewExplorerFiles.SelectedItems.Count;
            int     index       =   listViewExplorerFiles.SelectedItems[0].Index;
            
            CustomFile  playingFile     =   playList.GetFile( this.playingIndex );
            int         playingIndex    =   this.playingIndex;
            bool        musicAdded      =   false;

            foreach ( ListViewItem lvi in listViewExplorerFiles.SelectedItems ) {

                if ( filesManager.GetCurrentPath() == "" ) {
                    if ( count > 1 ) {
                        string  title       =   "Filed to open Disc";
                        string  message     =   "Opening more then one disk at once is not supported.";
                        MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                        continue;
                    }
                    filesManager.SelectDisk( index );
                    UpdateExplorer();
                    return;

                } else if ( index < filesManager.GetDirectoryCount() ) {
                    if ( count > 1 ) {
                        string  title       =   "Filed to open Directory";
                        string  message     =   "Opening more then one directory at once is not supported.";
                        MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                        continue;
                    }
                    filesManager.OpenFolder( index );
                    UpdateExplorer();
                    return;

                } else {
                    index                   =   index - filesManager.GetDirectoryCount();
                    string      filePath    =   filesManager.OpenFile( index );
                    CustomFile  file        =   new CustomFile( filePath );

                    if ( file.GetFileType() == FileType.Music ) {
                        playList.Add( filePath );
                        musicAdded      =   true;

                    } else if ( file.GetFileType() == FileType.Playlist ) {
                        if ( count > 1 ) {
                            string  title       =   "Failed to open PlayList";
                            string  message     =   "Opening more then one PlayList at the time is not supported.";
                            MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                            continue;
                        }
                        // OPEN PLAYLIST

                    }  else {
                        string  title       =   "Failed file open";
                        string  message     =   "File \"" + file.GetFileName() + "\" is not supported by the application.";
                        MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                    }
                }
            }

            if ( musicAdded ) {
                if ( playingFile != null ) { DiselectNowPlaying(); }
                SelectNowPlaying( playingIndex + 1 );
                SoundMoudleLoadFile( playList.GetFile( this.playingIndex ) );
            }
            UpdateNowPlaying();
        }

        // ----------------------------------------------------------------------
        private void listViewExplorerFiles_KeyPress(object sender, KeyPressEventArgs e) {
            if ( e.KeyChar == (char)13 ) { listViewExplorerFiles_DoubleClick(sender, null); }
        }

        // ----------------------------------------------------------------------
        private void trackBarExplorerView_Scroll(object sender, EventArgs e) {
            int     value   =   ((TrackBar)sender).Value;
            Settings.SetDataExplorerView( listViewExplorerFiles, value );
        }

        // ----------------------------------------------------------------------
        private void UpdateExplorer() {
            textBoxExplorerPath.Text    =   filesManager.GetCurrentPath();
            listViewExplorerFiles.Items.Clear();
            filesManager.GetDiskList( comboBoxExplorerDisks );
            filesManager.GetDirectoryList( listViewExplorerFiles );
            filesManager.GetFileList( listViewExplorerFiles );
            filesManager.GetDirectoryList( treeViewExplorerDirectories );
        }

        #endregion FileManager
        // ######################################################################
        //  x       xxxxx   xxx     xxxx     xxx    xxxx    x   x
        //  x         x     x  x    x   x   x   x   x   x   x   x
        //  x         x     xxxx    xxxx    xxxxx   xxxx     xxx 
        //  x         x     x   x   x   x   x   x   x   x     x  
        //  xxxxx   xxxxx   xxxx    x   x   x   x   x   x     x  
        // ######################################################################
        #region Library
        // ----------------------------------------------------------------------
        private void buttonLibraryNew_Click(object sender, EventArgs e) {
            libraryPlayList         =   new CustomPlayList( Tools.fileTypeMusic );
            libraryOpenedIndex      =   -1;
            libraryOpened           =   "";
            labelLibraryName.Text   =   libraryOpened;
        }

        // ----------------------------------------------------------------------
        private void buttonLibraryOpen_Click(object sender, EventArgs e) {
            OpenLibraryDialog();
        }

        // ----------------------------------------------------------------------
        private void buttonLibrarySave_Click(object sender, EventArgs e) {
            SaveLibrary( libraryOpened, libraryOpenedIndex );
        }

        // ----------------------------------------------------------------------
        /// <summary> Otwiera okno dialogowe do zapisu listy odtwarzania jako plik. </summary>
        /// <param name="sender"> Przycisk interfejsu. </param>
        /// <param name="e"> Działanie przycisku interfejsu. </param>
        private void buttonLibrarySaveAs_Click(object sender, EventArgs e) {
            SaveLibraryDialog( libraryPlayList );
        }

        // ----------------------------------------------------------------------
        /// <summary> Ustawia otwartą listę odtwarzania jako główną. </summary>
        /// <param name="sender"> Przycisk interfejsu. </param>
        /// <param name="e"> Działanie przycisku interfejsu. </param>
        private void buttonLibraryNowPlay_Click(object sender, EventArgs e) {
            CustomFile  playingFile     =   playList.GetFile( this.playingIndex );
            if ( playingFile != null ) { DiselectNowPlaying(); }
            SoundModuleStop();

            CopyLibraryToNowPlaying();
            if ( statusAutoPlay && playList.GetCount() > 0 ) {
                if ( playingFile != null ) { DiselectNowPlaying(); }
                SelectNowPlaying( 0 );
                SoundMoudleLoadFile( playList.GetFile( this.playingIndex ) );
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Czyści otwrtą listę odtwarzania. </summary>
        /// <param name="sender"> Przycisk interfejsu. </param>
        /// <param name="e"> Działanie przycisku interfejsu. </param>
        private void buttonLibraryClear_Click(object sender, EventArgs e) {
            if ( libraryPlayList != null ) {
                libraryPlayList.Clear();
                listViewLibrary.Items.Clear();
            }

            if ( libraryOpenedIndex == 0 && playList != null ) {
                playList.Clear();
                listViewNowPlaying.Items.Clear();
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Usuwa wybrane pliki z otwartej listy odtwarzania </summary>
        /// <param name="sender"> Przycisk interfejsu. </param>
        /// <param name="e"> Działanie przycisku interfejsu. </param>
        private void buttonLibraryRemove_Click(object sender, EventArgs e) {
            if ( listViewLibrary.SelectedItems.Count <= 0 ) {
                string      title       =   "Playlist manager (Remove Items)";
                string      message     =   "There are nothing to remove.";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return;
            }

            RemoveLibraryItems();
        }

        // ----------------------------------------------------------------------
        /// <summary> Przenosi zaznaczone pliki do innej wybranej listy odtwarzania. </summary>
        /// <param name="sender"> Przycisk interfejsu. </param>
        /// <param name="e"> Działanie przycisku interfejsu. </param>
        private void buttonLibraryMoveTo_Click(object sender, EventArgs e) {
            MoveLibrary();
        }

        // ----------------------------------------------------------------------
        /// <summary> Sortuje pliki w otwartej liście odtwarzania, według
        /// schematu wybranego w comboBox. </summary>
        /// <param name="sender"> Przycisk interfejsu. </param>
        /// <param name="e"> Działanie przycisku interfejsu. </param>
        private void buttonLibrarySort_Click(object sender, EventArgs e) {
            if ( comboBoxLibrarySort.SelectedItem == null ) { return; }

            int index   =   comboBoxLibrarySort.SelectedIndex;
            switch ( index ) {
                case 0:
                    libraryPlayList.SortByFileName();
                    break;
                case 1:
                    libraryPlayList.SortByFilePath();
                    break;
                case 2:
                    libraryPlayList.SortByAudioTitle();
                    break;
                case 3:
                    libraryPlayList.SortByAudioAlbum();
                    break;
                case 4:
                    libraryPlayList.SortByAudioArtist();
                    break;
            }
            
            if ( libraryOpenedIndex == 0 && playList != null ) {
                CustomFile  playingIndex    =   playList.GetFile( this.playingIndex );
                playList    =   libraryPlayList.CloneObject();

                UpdateNowPlaying();
                DiselectNowPlaying( this.playingIndex );
                SelectNowPlaying( playList.IndexOf( playingIndex ) );
            }

            UpdateLibraryPlayList();
        }

        // ----------------------------------------------------------------------
        private void buttonLibraryAddPlaylist_Click(object sender, EventArgs e) {
            AddLibrary();
        }

        // ----------------------------------------------------------------------
        /// <summary> Usuwa wybraną listę odtwarzania z AnthraX\Libraries </summary>
        /// <param name="sender"> Przycisk interfejsu. </param>
        /// <param name="e"> Działanie przycisku interfejsu. </param>
        private void buttonLibraryRemovePlaylist_Click(object sender, EventArgs e) {
            RemoveLibrary();
        }

        #endregion Library
        // ######################################################################
        //  x       xxxxx   xxx     xxxx     xxx    xxxx    x   x
        //  x         x     x  x    x   x   x   x   x   x   x   x
        //  x         x     xxxx    xxxx    xxxxx   xxxx     xxx 
        //  x         x     x   x   x   x   x   x   x   x     x  
        //  xxxxx   xxxxx   xxxx    x   x   x   x   x   x     x  
        //
        //  x   x    xxx    x   x    xxx     xxxx   xxxxx   xxxx 
        //  xx xx   x   x   xx  x   x   x   x       x       x   x
        //  x x x   xxxxx   x x x   xxxxx   x  xx   xxxx    xxxx 
        //  x   x   x   x   x  xx   x   x   x   x   x       x   x
        //  x   x   x   x   x   x   x   x    xxxx   xxxxx   x   x
        // ######################################################################
        #region LibraryManager
        // ----------------------------------------------------------------------
        private void AddLibrary() {
            string  title       =   "Playlist manager (Add)";
            string  message     =   "Enter name of new playlist, you wanna create.";
            string  defName     =   "New playlist";

            CustomMessageInputBox cmib = new CustomMessageInputBox( title, message, defName, AddLibrary );
            var dialogResult    =   cmib.ShowDialog();
        }

        private bool AddLibrary( object[] obj ) {
            string  libraryPath     =   Tools.GetDirectoryApplicationLibrary();
            string  libraryName     =   (string) obj[0];
            string  filePath        =   libraryPath + "\\" + libraryName + Tools.fileTypePlaylist[0];

            if ( File.Exists( filePath ) ) {
                string  title           =   "Library manager";
                string  message         =   "Playlist name \"" + libraryName + "\" is alredy taken, choose other name.";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return false;
            }

            var fileWorker  =   File.Create( filePath );
            fileWorker.Close();
            UpdateLibraryList();
            return true;
        }

        // ----------------------------------------------------------------------
        private void OpenLibraryDialog() {
            string  initPath    =   Tools.GetDirectoryHome();
            string  filePath    =   Tools.PlayListSelector( initPath );
            
            if ( File.Exists( filePath ) ) {
                libraryOpenedIndex      =   -1;
                libraryOpened           =   "";
                labelLibraryName.Text   =   Path.GetFileNameWithoutExtension( filePath );
                OpenLibrary( filePath );
                UpdateLibraryPlayList();
            }
        }

        // ----------------------------------------------------------------------
        private void OpenLibrary( string fileName, int fileIndex ) {
            string  libraryPath     =   Tools.GetDirectoryApplicationLibrary();
            string  filePath        =   libraryPath + "\\" + fileName + Tools.fileTypePlaylist[0];

            if ( fileIndex == 0 ) {
                CopyNowPlayingToLibrary();
                UpdateLibraryPlayList();
            } else {
                if ( File.Exists( filePath ) ) {
                    libraryOpenedIndex      =   fileIndex;
                    libraryOpened           =   fileName;
                    labelLibraryName.Text   =   libraryOpened;
                    OpenLibrary( filePath );
                }
            }
        }

        // ----------------------------------------------------------------------
        private void OpenLibrary( string filePath ) {
            if ( File.Exists( filePath ) ) {
                Encoding    encode  =   Encoding.GetEncoding( "Windows-1250" );
                libraryPlayList     =   new CustomPlayList( Tools.fileTypeMusic );
                
                foreach ( string item in File.ReadAllLines( filePath, encode ) ) {
                    if ( File.Exists( item ) ) {
                        CustomFile  newFile     =   new CustomFile( item );
                        libraryPlayList.Add(newFile);
                    }
                }

                UpdateLibraryPlayList();
            }
        }

        // ----------------------------------------------------------------------
        private void SaveLibrary( string fileName, int fileIndex ) {
            if ( (fileName == "" && playList != null) || fileIndex == 0 ) {
                string  title       =   "Playlist manager (Save)";
                string  message     =   "Enter name of new playlist to save it.";
                string  defName     =   "New playlist";

                CustomMessageInputBox cmib = new CustomMessageInputBox( title, message, defName, SaveLibrary );
                var dialogResult    =   cmib.ShowDialog();

            } else if ( fileName != "" ) {
                string      libraryPath     =   Tools.GetDirectoryApplicationLibrary();
                string      filePath        =   libraryPath + "\\" + fileName + Tools.fileTypePlaylist[0];
                
                if ( File.Exists( filePath ) ) {
                    string  title           =   "Library manager";
                    string  message         =   "Do you want to overwrite \"" + fileName + "\" playlist?";
                    DialogResult    result  =   MessageBox.Show( message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation );
                    if ( result == DialogResult.No ) { return; }
                }

                SaveLibrary( libraryPlayList, filePath );
            }
        }

        private bool SaveLibrary( object[] obj ) {
            string      libraryPath     =   Tools.GetDirectoryApplicationLibrary();
            string      libraryName     =   (string) obj[0];
            string      filePath        =   libraryPath + "\\" + libraryName + Tools.fileTypePlaylist[0];

            if ( File.Exists( filePath ) ) {
                string  title           =   "Library manager";
                string  message         =   "Playlist name \"" + libraryName + "\" is alredy taken, choose other name.";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return false;
            }

            AddLibrary( new object[] { libraryName } );
            SaveLibrary( libraryPlayList, filePath );
            return true;
        }

        // ----------------------------------------------------------------------
        private void SaveLibraryDialog( CustomPlayList playList ) {
            string  initPath    =   Tools.GetDirectoryHome();
            string  filePath    =   Tools.PlayListSaver( initPath );
            
            if ( filePath == "" ) {
                string  title           =   "Library manager";
                string  message         =   "Selected invalid file or filename. Save can not be proceed.";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return;
            }

            if ( File.Exists( filePath ) ) {
                string  fileName        =   Path.GetFileNameWithoutExtension( filePath );
                string  title           =   "Library manager";
                string  message         =   "Do you want to overwrite \"" + fileName + "\" playlist file?";
                DialogResult    result  =   MessageBox.Show( message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation );
                if ( result == DialogResult.No ) { return; }
            }

            SaveLibrary( playList, filePath );
        }

        // ----------------------------------------------------------------------
        private void SaveLibrary( CustomPlayList playList, string filePath ) {
            try {
                string[]    lines   =   new string[ playList.GetCount() ];
                Encoding    encode  =   Encoding.GetEncoding( "Windows-1250" );

                for ( int i = 0; i < playList.GetCount(); i++ ) {
                    System.Console.WriteLine( playList.GetFile( i ).GetFilePath() );
                    lines[i] = playList.GetFile( i ).GetFilePath();
                }

                File.WriteAllLines( filePath, lines, encode );

            } catch ( Exception exc ) {
                System.Console.WriteLine( exc.ToString() );
                string  title   =   "Playlist manager internal error.";
                string  message =   "Save playlist, cannot be performed." +
                    Environment.NewLine + "There are more informations below." +
                    Environment.NewLine + Environment.NewLine + exc.ToString();
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Stop );
            }
        }

        // ----------------------------------------------------------------------
        private void MoveLibrary() {
            string      title       =   "Playlist manager (Move Items)";
            string      message     =   "Select playlist where the files will be moved.";
            string[]    data        =   new string[ treeViewLibraryPlaylists.Nodes.Count ];

            if ( listViewLibrary.SelectedItems.Count <= 0 ) {
                message     =   "There are nothing to move.";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return;
            }

            foreach( TreeNode treeNode in treeViewLibraryPlaylists.Nodes ) {
                data[ treeNode.Index ] = treeNode.Text;
            }

            CustomMessageComboBox cmcb = new CustomMessageComboBox( title, message, data, MoveLibrary );
            var dialogResult    =   cmcb.ShowDialog();
        }

        private bool MoveLibrary( object[] obj ) {
            int     itemIndex       =   (int) obj[0];
            string  itemName        =   (string) obj[1];
            int     count           =   listViewLibrary.SelectedItems.Count;
            int[]   itemsIndexes    =   new int[count];

            if ( itemIndex == libraryOpenedIndex || itemName == libraryOpened ) {
                string  title           =   "Library manager (Move Items)";
                string  message         =   "You cannot move files to the same playList.";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return false;
            }

            // --- Copy indexes selected items ---
            for ( int i = 0; i < count; i++ ) { itemsIndexes[i] = listViewLibrary.SelectedItems[i].Index; }
            itemsIndexes    =   itemsIndexes.OrderBy(i => i).ToArray();

            // --- Move items to NowPlaying ---
            if ( itemIndex == 0 ) {
                foreach( int index in itemsIndexes ) {
                    playList.Add( libraryPlayList.GetFile( index ).CloneObject() );
                }

                RemoveLibraryItems();
                UpdateLibraryList();
                UpdateNowPlaying();
            
            // --- Move items to other PlayList ---
            } else {
                string      libraryPath     =   Tools.GetDirectoryApplicationLibrary();
                string      libraryName     =   (string) obj[1];
                string      filePath        =   libraryPath + "\\" + libraryName + Tools.fileTypePlaylist[0];
                Encoding    encode          =   Encoding.GetEncoding( "Windows-1250" );

                if ( File.Exists( filePath ) ) {
                    string[]    playListItems   =   File.ReadAllLines( filePath );
                    string[]    playListNew     =   new string[ playListItems.Length + count ];
                    int         position        =   playListItems.Length;

                    Array.Copy( playListItems, playListNew, playListItems.Length );
                    foreach( int index in itemsIndexes) {
                        playListNew[ position ] = libraryPlayList.GetFile( index ).GetFilePath();
                        position++;
                    }

                    RemoveLibraryItems();
                    File.WriteAllLines( filePath, playListNew, encode );
                    UpdateLibraryList();
                }
            }

            return true;
        }

        // ----------------------------------------------------------------------
        private void RemoveLibraryItems() {
            if ( listViewLibrary.SelectedItems.Count <= 0 ) { return; }
            if ( libraryPlayList == null ) { return; }

            CustomFile  playingFile     =   playList.GetFile( this.playingIndex );
            int         count           =   listViewLibrary.SelectedItems.Count;
            int[]       itemsIndexes    =   new int[ listViewLibrary.SelectedItems.Count ];

            for ( int i = 0; i < count; i++ ) { itemsIndexes[i] = listViewLibrary.SelectedItems[i].Index; }
            itemsIndexes    =   itemsIndexes.OrderByDescending(i => i).ToArray();

            if ( libraryOpenedIndex == 0 && playList != null ) { DiselectNowPlaying(this.playingIndex); }
            foreach( int index in itemsIndexes ) { libraryPlayList.Remove( index ); }
            if ( libraryOpenedIndex == 0 && playList != null ) {
                CopyLibraryToNowPlaying();
                UpdateNowPlaying();
                SelectNowPlaying( playList.IndexOf( playingFile ) );
            }

            UpdateLibraryPlayList();
        }

        // ----------------------------------------------------------------------
        private void RemoveLibrary() {
            if ( treeViewLibraryPlaylists.SelectedNode == null ) { return; }
            if ( treeViewLibraryPlaylists.SelectedNode.Index == 0 ) {
                string  title   =   "Playlist removal tool";
                string  message =   "Cannot remove main \"Now Playing\" playlist.";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return;
            }

            TreeNode    treeNode        =   treeViewLibraryPlaylists.SelectedNode;
            int         libraryIndex    =   treeNode.Index;
            string      libraryPath     =   Tools.GetDirectoryApplicationLibrary();
            string      libraryName     =   treeNode.Text;
            string      filePath        =   libraryPath + "\\" + libraryName + Tools.fileTypePlaylist[0];
            
            if ( File.Exists( filePath ) ) {
                string          title       =   "Playlist removel tool";
                string          message     =   "Do you want to delete \"" + libraryName + "\" playlist?";
                DialogResult    result      =   MessageBox.Show( message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                
                if ( result == DialogResult.Yes ) {
                    File.Delete( filePath );
                    UpdateLibraryList();

                    if ( libraryOpened == libraryName ) {
                        libraryOpenedIndex      =   -1;
                        libraryOpened           =   "";
                        labelLibraryName.Text   =   libraryOpened;

                    } else if ( libraryIndex < libraryOpenedIndex ) {
                        libraryOpenedIndex--;
                        libraryOpened           =   treeViewLibraryPlaylists.Nodes[ libraryOpenedIndex ].Text;
                        labelLibraryName.Text   =   libraryOpened;
                    }
                }
            }
        }

        // ----------------------------------------------------------------------
        private void CopyLibraryToNowPlaying() {
            if ( libraryOpenedIndex == 0 ) { return; }
            if ( libraryPlayList != null ) {
                DiselectNowPlaying();
                playList                    =   libraryPlayList.CloneObject();
                UpdateNowPlaying();
            }
        }

        private void CopyNowPlayingToLibrary() {
            libraryPlayList         =   playList.CloneObject();
            libraryOpenedIndex      =   0;
            libraryOpened           =   "";
            labelLibraryName.Text   =   "Now Playing";
            UpdateLibraryPlayList();
        }

        // ----------------------------------------------------------------------
        private void UpdateLibraryPlayList() {
            listViewLibrary.Items.Clear();
            if ( libraryPlayList == null ) { return; }
            if ( libraryPlayList.GetCount() <= 0 ) { return; }

            for ( int i = 0; i < libraryPlayList.GetCount(); i++ ) {
                CustomFile      file        =   libraryPlayList.GetFile( i );
                ListViewItem    newItem     =   new ListViewItem( file.GetFileName() );
                newItem.ImageIndex          =   8;
                newItem.SubItems.Add( CustomFileMetadata.GetMusicTitle( file ) );
                newItem.SubItems.Add( CustomFileMetadata.GetMusicArtist( file ) );
                newItem.SubItems.Add( CustomFileMetadata.GetMusicAlbum( file ) );
                newItem.SubItems.Add( SoundModule.GetFullTime( file.GetFilePath(), this ) );
                listViewLibrary.Items.Add( newItem );
            }
        }

        // ----------------------------------------------------------------------
        private void UpdateLibraryList() {
            treeViewLibraryPlaylists.Nodes.Clear();

            treeViewLibraryPlaylists.Nodes.Add( new TreeNode( "Now Playing", 1, 1 ) );
            string  libraryPath     =   Tools.GetDirectoryApplicationLibrary();
            foreach ( FileInfo fileInfo in new DirectoryInfo( libraryPath ).GetFiles() ) {
                string  filePath    =   fileInfo.FullName;
                string  fileName    =   Path.GetFileNameWithoutExtension( filePath );
                string  fileExt     =   Path.GetExtension( filePath );
                if ( Tools.fileTypePlaylist.Contains<string>( fileExt ) ) {
                    treeViewLibraryPlaylists.Nodes.Add( new TreeNode( fileName, 2, 2 ) );
                }
            }
        }

        #endregion LibraryManager
        // ######################################################################
        //  x       xxxxx   xxx     xxxx     xxx    xxxx    x   x
        //  x         x     x  x    x   x   x   x   x   x   x   x
        //  x         x     xxxx    xxxx    xxxxx   xxxx     xxx 
        //  x         x     x   x   x   x   x   x   x   x     x  
        //  xxxxx   xxxxx   xxxx    x   x   x   x   x   x     x  
        //
        //   xxxx   x   x    xxxx   xxxxx   xxxxx   x   x
        //  x       x   x   x         x     x       xx xx
        //   xxx     xxx     xxx      x     xxxx    x x x
        //      x     x         x     x     x       x   x
        //  xxxx      x     xxxx      x     xxxxx   x   x
        // ######################################################################
        #region LibrarySystem
        // ----------------------------------------------------------------------
        /// <summary> Funkcja zezwalająca na wrzucanie plików metodą Drag and Drop. </summary>
        /// <param name="sender"> Komponent do którego są wrzucane pliki. </param>
        /// <param name="e"> Działanie Drag and Drop. </param>
        private void listViewLibrary_DragEnter(object sender, DragEventArgs e) {
            if ( e.Data.GetDataPresent( DataFormats.FileDrop, false ) == true ) {
                e.Effect = DragDropEffects.All;
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Dodanie plików do listy odtwarzania metodą Drag and Drop. </summary>
        /// <param name="sender"> Komponent do którego są wrzucane pliki. </param>
        /// <param name="e"> Działanie Drag and Drop. </param>
        private void listViewLibrary_DragDrop(object sender, DragEventArgs e) {
            var dropped     =   ( (string[]) e.Data.GetData( DataFormats.FileDrop ) );
            var files       =   dropped.ToArray();
            if ( libraryPlayList == null ) { return; }

            foreach ( string file in files ) { libraryPlayList.Add( file ); }
            UpdateLibraryPlayList();

            if ( libraryOpenedIndex == 0 ) {
                CustomFile  playingFile     =   playList.GetFile( this.playingIndex );
                int         firstNewItem    =   this.playingIndex;

                CopyLibraryToNowPlaying();
                UpdateNowPlaying();
                // --- AUTOPLAY ---
                if ( statusAutoPlay && firstNewItem < playList.GetCount() ) {
                    if ( playingFile != null ) { DiselectNowPlaying(); }
                    SelectNowPlaying( firstNewItem );
                    SoundMoudleLoadFile( playList.GetFile( this.playingIndex ) );
                }
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Funkcja rozpoczęcia przeniesienia zaznaczonych elementów na liście odtwarzania w inne jej miejsce. </summary>
        /// <param name="sender"> Komponent interfejsu ListView. </param>
        /// <param name="e"> Działanie kurosra i myszy na komponenice. </param>
        private void listViewLibrary_MouseDown(object sender, MouseEventArgs e) {
            ListViewItem    itemDrag    =   ((ListView)sender).GetItemAt( e.X, e.Y );
            if ( itemDrag == null ) { return; }

            libraryDragDrop     =   true;
            libraryDragIndex    =   itemDrag.Index;

            if ( ((ListView)sender).SelectedItems.Count > 0 ) {
                int count           =   ((ListView)sender).SelectedItems.Count;
                libraryDragArray    =   new int[ count ];
                for ( int i = 0; i < count; i++ ) {
                    libraryDragArray[i] = ((ListView)sender).SelectedItems[i].Index;
                }

            } else {
                libraryDragArray        =   new int[1];
                libraryDragArray[0]     =   libraryDragIndex;
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Przeniesienia zaznaczonych elementów na liście odtwarzania w inne jej miejsce. </summary>
        /// <param name="sender"> Komponent interfejsu ListView. </param>
        /// <param name="e"> Działanie kurosra i myszy na komponenice. </param>
        private void listViewLibrary_MouseUp(object sender, MouseEventArgs e) {
            if ( !libraryDragDrop ) { return; }

            ListViewItem    itemDrag    =   ((ListView)sender).GetItemAt( e.X, e.Y );
            if ( itemDrag == null ) { return; }
            if ( libraryDragIndex == -1 ) { return; }
            if ( itemDrag.Index == libraryDragIndex ) { return; }

            int         dropPosition    =   itemDrag.Index;
            Array.Sort( libraryDragArray );

            if ( libraryDragArray.Length == 1 ) {
                // --- Move one selected item ---
                libraryPlayList.MovePosition( libraryDragArray[0], dropPosition );
                System.Console.WriteLine( ((ListView)sender).Items[ libraryDragArray[0] ].ToString() );

            } else if ( libraryDragArray.Length > 1 ) {
                // --- Move multiple selected items ---
                int middlePoint     =   0;
                int selectedLength  =   libraryDragArray.Length - 1;
                
                if ( dropPosition < libraryDragArray[0] ) { middlePoint = 0; }
                else if ( dropPosition > libraryDragArray[selectedLength] ) { middlePoint = selectedLength; }
                else {

                    // --- Searching middle drop point of selected items ---
                    for ( int mp = 0; mp <= selectedLength; mp++ ) {
                        if ( dropPosition >= libraryDragArray[mp] && dropPosition < libraryDragArray[mp+1] ) {
                            middlePoint = mp;
                            break;
                        }
                    }
                }

                // --- Inserting lower items than dropPosition ---
                dropPosition    =   itemDrag.Index-1;
                for ( int i = middlePoint; i >= 0; i-- ) {
                    System.Console.WriteLine( ((ListView)sender).Items[ libraryDragArray[i] ].ToString() );
                    libraryPlayList.MovePosition( libraryDragArray[i], dropPosition );
                    dropPosition--;
                }

                // --- Inserting higher items than dropPosition ---
                dropPosition    =   itemDrag.Index;
                for ( int i = middlePoint+1; i <= selectedLength; i++ ) {
                    System.Console.WriteLine( ((ListView)sender).Items[ libraryDragArray[i] ].ToString() );
                    libraryPlayList.MovePosition( libraryDragArray[i], dropPosition );
                    dropPosition++;
                }
            }

            libraryDragDrop     =   false;
            libraryDragIndex    =   -1;
            libraryDragArray    =   null;
            UpdateLibraryPlayList();

            if ( libraryOpenedIndex == 0 && playList != null ) {
                CustomFile  playingIndex    =   playList.GetFile( this.playingIndex );
                DiselectNowPlaying( this.playingIndex );
                UpdateNowPlaying();
                SelectNowPlaying( playList.IndexOf( playingIndex ) );
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Wybranie pliku z otwartej listy odtwarzania i uruchomienie go. </summary>
        /// <param name="sender"> Komponent interfejsu ListView. </param>
        /// <param name="e"> Działanie kurosra i myszy na komponenice. </param>
        private void listViewLibrary_DoubleClick(object sender, EventArgs e) {
            int count   =   listViewLibrary.SelectedItems.Count;
            if ( count <= 0 ) { return; }

            if ( libraryOpenedIndex == 0 && playList != null ) {
                DiselectNowPlaying( this.playingIndex );
                SetNowPlaying( listViewLibrary.SelectedItems[0].Index );
                listViewLibrary.SelectedItems.Clear();

            } else if ( libraryPlayList != null ) {
                CustomFile  playingFile     =   playList.GetFile( this.playingIndex );
                int         firstNewItem    =   playList.GetCount();
                List<bool>  musicAdded      =   new List<bool>();

                foreach( ListViewItem listView in listViewLibrary.SelectedItems ) {
                    playList.Add( libraryPlayList.GetFile( listView.Index ).CloneObject() );
                }
                listViewLibrary.SelectedItems.Clear();
                UpdateNowPlaying();

                // --- AUTOPLAY ---
                if ( statusAutoPlay && firstNewItem < playList.GetCount() ) {
                    if ( playingFile != null ) { DiselectNowPlaying(); }
                    SelectNowPlaying( firstNewItem );
                    SoundMoudleLoadFile( playList.GetFile( this.playingIndex ) );
                }
            }
        }

        // ----------------------------------------------------------------------
        /// <summary> Działanie przycisków klawiszy na komponencie listy odtwarzania. </summary>
        /// <param name="sender"> Komponent interfejsu ListView. </param>
        /// <param name="e"> Działanie klawisza na komponenice. </param>
        private void listViewLibrary_KeyPress(object sender, KeyPressEventArgs e) {
            if ( e.KeyChar == (char)13 ) { listViewLibrary_DoubleClick( sender, null ); }
        }

        // ----------------------------------------------------------------------
        private void treeViewLibraryPlaylists_DoubleClick(object sender, EventArgs e) {
            TreeNode    treeNode    =   ((TreeView)sender).SelectedNode;

            if ( treeNode != null ) {
                int indexNode   =   treeNode.Index;
                if ( !CheckLibraryPlayListIntegrity( libraryPlayList, libraryOpened, libraryOpenedIndex ) ) {
                    string  title           =   "Library manager";
                    string  message         =   "There are some changes in playlist, do you want lose it and continue?";
                    DialogResult    result  =   MessageBox.Show( message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation );
                    if ( result == DialogResult.No ) { return; }
                }
                OpenLibrary( treeNode.Text, treeNode.Index );
            }

            ((TreeView)sender).SelectedNode     =   null;
        }

        // ----------------------------------------------------------------------
        private bool CheckLibraryPlayListIntegrity( CustomPlayList playlist, string fileName, int fileIndex ) {
            string  libraryPath     =   Tools.GetDirectoryApplicationLibrary();
            string  playlistPath    =   libraryPath + "\\" + fileName + Tools.fileTypePlaylist[0];
            
            if ( fileName == "" || fileIndex == 0 ) { return true; }
            if ( playList == null ) { return true; }
            if ( File.Exists( playlistPath ) ) {
                Encoding    encode      =   Encoding.GetEncoding("Windows-1250");
                string[]    filesPaths  =   File.ReadAllLines( playlistPath, encode );
                int         diffrence   =   Math.Min( filesPaths.Length, playlist.GetCount() );

                if ( filesPaths.Length != playlist.GetCount() ) { MessageBox.Show("XD"); return false; }
                else if ( playlist.GetCount() == 0 ) { return true; }
                for( int i = 0; i < diffrence; i++ ) {
                    if ( filesPaths[i] != playlist.GetFile(i).GetFilePath() ) { return false; }
                }

                return true;
            }

            return false;
        }

        #endregion LibrarySystem
        // ######################################################################
        //  x   x    xxx    xxxx     xxx     xxx    x   x   xxxxx
        //  x  x    x   x   x   x   x   x   x   x   x  x    x    
        //  xxx     xxxxx   xxxx    xxxxx   x   x   xxx     xxxx 
        //  x  x    x   x   x   x   x   x   x   x   x  x    x    
        //  x   x   x   x   x   x   x   x    xxx    x   x   xxxxx
        // ######################################################################
        #region Karaoke
        // ----------------------------------------------------------------------
        //  KARAOKE USER INTERFACE FUNCTIONS
        // ----------------------------------------------------------------------
        private void buttonKaraokeNew_Click( object sender, EventArgs e ) {
            NewKaraokeFile();
        }

        // ----------------------------------------------------------------------
        private void buttonOpen_Click( object sender, EventArgs e ) {
            OpenKaraokeFile();
        }

        // ----------------------------------------------------------------------
        private void buttonKaraokeSave_Click( object sender, EventArgs e ) {
            CustomFile  customFile  =   playList.GetFile( playingIndex );
            if ( customFile != null ) {
                SaveKaraokeFile( customFile.GetFileName() );
            }
        }

        // ----------------------------------------------------------------------
        private void buttonKaraokeSaveAs_Click( object sender, EventArgs e ) {
            SaveKaraokeFileAs();
        }

        // ----------------------------------------------------------------------
        private void checkBoxKaraokeEnable_CheckedChanged( object sender, EventArgs e ) {
            bool    check   =   ((CheckBox)sender).Checked;
            statusKaraoke   =   check;
        }

        // ----------------------------------------------------------------------
        private void buttonKaraokeAddLine_Click(object sender, EventArgs e) {
            if ( karaokeData == null ) { NewKaraokeFile(); }
            string      title       =   "Adding Karaoke Line";
            string[]    messages    =   { "Time in miliseconds", "Text" };
            string[]    defInputs   =   { SoundModule.GetPosition().ToString(), "" };

            CustomMessageDualInput cmdi = new CustomMessageDualInput( title, messages, defInputs, AddKaraokeItem );
            cmdi.ShowDialog();
        }

        private bool AddKaraokeItem( object[] obj ) {
            long    time_data   =   0;
            string  text_data   =   "";
            int     index       =   karaokeData.Count;

            if ( obj.Length >= 2 ) {
                if ( long.TryParse( (string) obj[0], out time_data ) ) {
                    text_data = (string) obj[1];

                    KaraokeData data = new KaraokeData { time = time_data, text = text_data };
                    ListViewItem item = new ListViewItem( new string[] {time_data.ToString(), text_data} );
                    karaokeData.Add( data );
                    listViewKaraoke.Items.Add( item );
                    return true;
                }
            }

            return false;
        }

        // ----------------------------------------------------------------------
        private void buttonKaraokeRemoveLine_Click(object sender, EventArgs e) {
            if ( listViewKaraoke.SelectedItems.Count > 0 ) {
                int index = listViewKaraoke.SelectedItems[0].Index;
                listViewKaraoke.SelectedItems.Clear();
                listViewKaraoke.Items.RemoveAt( index );

                if ( karaokeData.Count < index || index >= 0 ) {
                    karaokeData.RemoveAt( index );
                }
            }
        }

        // ----------------------------------------------------------------------
        private void listViewKaraoke_ItemActivate(object sender, EventArgs e) {
            int         index       =   listViewKaraoke.SelectedItems[0].Index;
            string      title       =   "Edit Karaoke Line";
            string[]    messages    =   { "Time in miliseconds", "Text" };
            string[]    defInputs   =   { karaokeData[index].time.ToString(), karaokeData[index].text };

            temp_index  =   index;
            CustomMessageDualInput cmdi = new CustomMessageDualInput( title, messages, defInputs, EditKaraokeItem );
            cmdi.ShowDialog();
        }

        private bool EditKaraokeItem( object[] obj ) {
            int     item_index  =   temp_index;
            long    time_data   =   0;
            string  text_data   =   "";

            temp_index  =   -1;
            if ( obj.Length >= 2 ) {
                if ( long.TryParse( (string) obj[0], out time_data ) ) {
                    text_data = (string) obj[1];

                    KaraokeData data = new KaraokeData { time = time_data, text = text_data };
                    UpdateKaraokeDataItem( item_index, data );
                    UpdateKaraokeInterfaceItem( item_index, data );
                    return true;
                }
            }

            return false;
        }

        // ----------------------------------------------------------------------
        //  KARAOKE MANAGER FUNCTIONS
        // ----------------------------------------------------------------------
        private string GetKaraoke( int index, long time ) {
            string  result  =   null;
            if ( karaokeData == null ) { return ""; }
            if ( karaokeData.Count <= 0 ) { return ""; }

            if ( index >= 0 || index < karaokeData.Count ) {
                long karoke_time    =   karaokeData[index].time;
                if ( time >= karoke_time ) {
                    result = karaokeData[index].text;
                    karaokeIndex++;
                }
            }

            return result;
        }

        // ----------------------------------------------------------------------
        private void FixPosition() {
            long time = SoundModule.GetPosition();
            karaokeIndex = 0;

            if ( karaokeData == null ) { return; }
            if ( karaokeData.Count <= 0 ) { return; }
            foreach ( KaraokeData data in karaokeData ) {
                if ( time < data.time ) {
                    karaokeIndex = (karaokeIndex>0 ? karaokeIndex-1 : 0);
                    return;
                }
                karaokeIndex++;
            }
        }

        // ----------------------------------------------------------------------
        private void NewKaraokeFile() {
            karaokeData = new List<KaraokeData>();
            UpdateKaraokeInterface( karaokeData );
        }

        // ----------------------------------------------------------------------
        private void ClearKaraokeFile() {
            karaokeData = null;
            UpdateKaraokeInterface( karaokeData );
        }

        // ----------------------------------------------------------------------
        private void OpenKaraokeFile() {
            string  initPath    =   Tools.GetDirectoryHome();
            string  filePath    =   Tools.KaraokeSelector( initPath );
            karaokeData         =   null;

            if ( File.Exists( filePath ) ) {
                try {
                    string[] text =  File.ReadAllLines( filePath );
                    karaokeData = LoadKaraokeParser( text );

                } catch (Exception exc) {
                    System.Console.WriteLine( exc.ToString() );
                }
            }

            UpdateKaraokeInterface( karaokeData );
        }

        // ----------------------------------------------------------------------
        private void LoadKaraokeFile( string fileName_withoutExtension ) {
            string  initPath    =   Tools.GetDirectoryApplicationKaraoke();
            string  filePath    =   initPath + "\\" + fileName_withoutExtension + ".txt";
            karaokeData         =   null;

            if ( File.Exists( filePath ) ) {
                try {
                    string[] text =  File.ReadAllLines( filePath );
                    karaokeData = LoadKaraokeParser( text );

                } catch (Exception exc) {
                    System.Console.WriteLine( exc.ToString() );
                }
            }

            UpdateKaraokeInterface( karaokeData );
        }

        // ----------------------------------------------------------------------
        private void SaveKaraokeFile( string fileName_withoutExtension ) {
            string      initPath    =   Tools.GetDirectoryApplicationKaraoke();
            string      filePath    =   initPath + "\\" + fileName_withoutExtension + ".txt";
            string[]    data        =   SaveKaraokeParser( karaokeData );

            File.WriteAllLines( filePath, data );
        }

        // ----------------------------------------------------------------------
        private void SaveKaraokeFileAs() {
            string      initPath    =   Tools.GetDirectoryHome();
            string      filePath    =   Tools.KaraokeSaver( initPath ) + ".txt";
            string[]    data        =   SaveKaraokeParser( karaokeData );

            File.WriteAllLines( filePath, data );
        }

        // ----------------------------------------------------------------------
        //  KARAOKE PARSER FUNCTIONS
        // ----------------------------------------------------------------------
        private List<KaraokeData> LoadKaraokeParser( string[] lines ) {
            var new_karaokeData     =   new List<KaraokeData>();

            foreach ( string line in lines ) {
                string[] divides = line.Split('=');
                long time_data = 0;
                string text_data = "";

                if ( divides.Length >= 2 ) {
                    if ( long.TryParse( divides[0], out time_data ) ) {
                        text_data = divides[1];
                        new_karaokeData.Add( new KaraokeData() { time = time_data, text = text_data } );
                    }
                }
            }

            return new_karaokeData;
        }

        // ----------------------------------------------------------------------
        private string[] SaveKaraokeParser( List<KaraokeData> data ) {
            string[]    result  =   null;
            int         index   =   0;
            
            if ( data != null ) {
                result  =   new string[data.Count];

                foreach( KaraokeData karaoke_data in data ) {
                    string time_data = karaoke_data.time.ToString();
                    string text_data = karaoke_data.text;

                    result[index] = ( time_data+ "=" + text_data );
                    index++;
                }
            }

            return result;
        }

        // ----------------------------------------------------------------------
        //  KARAOKE COMPLEMENTARY FUNCTIONS
        // ----------------------------------------------------------------------
        private void UpdateKaraokeInterface( List<KaraokeData> data ) {
            listViewKaraoke.Items.Clear();

            if ( data != null ) {
                foreach( KaraokeData karaoke_data in data ) {
                    string time_data = karaoke_data.time.ToString();
                    string text_data = karaoke_data.text;
                    ListViewItem item = new ListViewItem( new string[] { time_data, text_data } );
                    listViewKaraoke.Items.Add( item );
                }
            }
        }

        // ----------------------------------------------------------------------
        private void UpdateKaraokeInterfaceItem( int index, KaraokeData data ) {
            if ( index < 0 || index >= listViewKaraoke.Items.Count ) { return; }
            listViewKaraoke.Items[index]    =   new ListViewItem( new string[] { data.time.ToString(), data.text } );
        }

        // ----------------------------------------------------------------------
        private void UpdateKaraokeData() {
            var new_karaokeData     =   new List<KaraokeData>();

            foreach( ListViewItem item in listViewKaraoke.Items ) {
                long time_data = 0;
                string text_data = "";

                if ( long.TryParse( item.Text, out time_data ) ) {
                    text_data = item.SubItems[0].Text;
                    new_karaokeData.Add( new KaraokeData() { time = time_data, text = text_data } );
                }
            }

            karaokeData = new_karaokeData;
        }

        // ----------------------------------------------------------------------
        private void UpdateKaraokeDataItem( int index, KaraokeData data ) {
            if ( karaokeData == null ) { return; }
            if ( index < 0 || index >= karaokeData.Count ) { return; }
            karaokeData[index] = data;
        }

        #endregion Karaoke
        // ######################################################################
        //  xxxxx    xxx    x   x    xxx    x       xxxxx   xxxxx   xxxxx   xxxx 
        //  x       x   x   x   x   x   x   x         x        x    x       x   x
        //  xxxx    x x x   x   x   xxxxx   x         x       x     xxxx    xxxx 
        //  x       x  xx   x   x   x   x   x         x      x      x       x   x
        //  xxxxx    xxx     xxx    x   x   xxxxx   xxxxx   xxxxx   xxxxx   x   x
        // ######################################################################
        #region Equalizer
        // ----------------------------------------------------------------------
        private void buttonEqualizerSave_Click(object sender, EventArgs e) {
            if ( tLPanelEqualizer.Visible ) { EqualizerSavePreset( equalizerPresetName, equalizerPresetIndex ); }
            if ( fLPanelEffects.Visible ) { EqualizerSaveEffect( equalizerEffectsName, equalizerEffectsIndex ); }
        }

        // ----------------------------------------------------------------------
        private void buttonEqualizerReset_Click(object sender, EventArgs e) {
            if ( tLPanelEqualizer.Visible ) { EqualizerResetPreset(); }
            if ( fLPanelEffects.Visible ) { EqualizerResetEffect(); }
        }

        // ----------------------------------------------------------------------
        private void buttonEqualizerSaveto_Click(object sender, EventArgs e) {
            if ( tLPanelEqualizer.Visible ) { EqualizerSaveAsPreset(); }
            if ( fLPanelEffects.Visible ) { EqualizerSaveAsEffect(); }
        }

        // ----------------------------------------------------------------------
        private void buttonEqualizerPresetAdd_Click(object sender, EventArgs e) {
            EqualizerAddElement();
        }

        // ----------------------------------------------------------------------
        private void buttonEqualizerPresetRemove_Click(object sender, EventArgs e) {
            if ( treeViewEqualizerMenu.SelectedNode == null ) { return; }
            TreeNode    treeNode    =   treeViewEqualizerMenu.SelectedNode;
            TreeNode    parent      =   ( treeNode.Parent != null ) ? treeNode.Parent : null;
            int         option      =   ( parent == null ) ? treeNode.Index : parent.Index;
            int         preset      =   ( parent == null ) ? -1 : treeNode.Index;

            switch ( option ) {
                case 0:
                    if ( preset > 11 ) {
                        EqualizerRemovePreset( treeNode.Text, preset );
                    } else {
                        string  title           =   "Equalizer manager (Remove)";
                        string  message         =   "Built-in preset \"" + treeNode.Text + "\" can not be removed.";
                        MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                        return;
                    }
                    break;
                    
                case 1:
                    if ( preset > 1 ) {
                        EqualizerRemoveEffect(treeNode.Text, preset);
                    } else {
                        string  title           =   "Equalizer manager (Remove)";
                        string  message         =   "Built-in effect \"" + treeNode.Text + "\" can not be removed.";
                        MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                        return;
                    }
                    break;
            }
        }

        #endregion Equalizer
        // ######################################################################
        //  xxxxx    xxx    x   x    xxx    x       xxxxx   xxxxx   xxxxx   xxxx 
        //  x       x   x   x   x   x   x   x         x        x    x       x   x
        //  xxxx    x x x   x   x   xxxxx   x         x       x     xxxx    xxxx 
        //  x       x  xx   x   x   x   x   x         x      x      x       x   x
        //  xxxxx    xxx     xxx    x   x   xxxxx   xxxxx   xxxxx   xxxxx   x   x
        //
        //  x   x    xxx    x   x    xxx     xxxx   xxxxx   xxxx 
        //  xx xx   x   x   xx  x   x   x   x       x       x   x
        //  x x x   xxxxx   x x x   xxxxx   x  xx   xxxx    xxxx 
        //  x   x   x   x   x  xx   x   x   x   x   x       x   x
        //  x   x   x   x   x   x   x   x    xxxx   xxxxx   x   x
        // ######################################################################
        #region EqualizerManger
        // ----------------------------------------------------------------------
        private void treeViewEqualizerMenu_DoubleClick(object sender, EventArgs e) {
            if ( ((TreeView)sender).SelectedNode == null ) { return; }
            TreeNode    treeNode    =   ((TreeView)sender).SelectedNode;
            TreeNode    parent      =   ( treeNode.Parent != null ) ? treeNode.Parent : null;
            int         option      =   ( parent == null ) ? treeNode.Index : parent.Index;
            int         preset      =   ( parent == null ) ? -1 : treeNode.Index;

            switch ( option ) {
                case 0:
                    if ( preset < 0 ) { EqualizerOpenPreset(); }
                    else { EqualizerOpenPreset( treeNode.Text, treeNode.Index ); }
                    break;
                    
                case 1:
                    if ( preset < 0 ) { EqualizerOpenEffect(); }
                    else { EqualizerOpenEffect( treeNode.Text, treeNode.Index ); }
                    break;
            }
        }

        // ----------------------------------------------------------------------
        private void EqualizerOpenPreset() {
            pagesEffects.ShowPanel( tLPanelEqualizer );
            labelEqualizerPresetName.Text   =   equalizerPresetName;
            SoundModule.SetEqualizer( equalizerPresetData );

            for( int v = 0; v < equalizerPresetData.Length; v++ ) {
                string      trackbarName    =   "trackBarEqualizer" + Tools.equalizerPresetInfo[v];
                string      labelValueName  =   "labelEqualizer" + Tools.equalizerPresetInfo[v] + "Value";
                Control[]   trackbar        =   tLPanelEqualizer.Controls.Find( trackbarName, true );
                Control[]   labelValue      =   tLPanelEqualizer.Controls.Find( labelValueName, true );

                if ( trackbar.Length > 0 ) {
                    ((TrackBar)trackbar[0]).Value  =   equalizerPresetData[v];
                }

                if ( labelValue.Length > 0 ) {
                    ((Label)labelValue[0]).Text    =   "+" + equalizerPresetData[v].ToString();
                }
            }
        }

        // ----------------------------------------------------------------------
        private void EqualizerOpenPreset( string fileName, int fileIndex ) {
            string  presetsPath     =   Tools.GetDirectoryApplicationPresets();
            string  presetName      =   fileName;
            string  presetFullPath  =   presetsPath + "\\" + presetName + ".aep";

            if ( fileIndex <= 11 ) {
                for ( int v = 0; v < equalizerPresetData.Length; v++ ) {
                    equalizerPresetData[ v ] = Tools.equalizerPresets[ fileIndex, v ];
                }
                equalizerPresetIndex    =   fileIndex;
                equalizerPresetName     =   fileName;
                EqualizerOpenPreset();
            }

            if ( File.Exists( presetFullPath ) ) {
                Encoding    encode          =   Encoding.GetEncoding( "Windows-1250" );
                string[]    presetString    =   File.ReadAllLines( presetFullPath, encode );
                int         count           =   Math.Min( presetString.Length, equalizerPresetData.Length );
                equalizerPresetData         =   new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                for ( int s = 0; s < count; s++ ) {
                    int     value   =   0;
                    int.TryParse( presetString[s], out value );
                    equalizerPresetData[ s ]    =   value;
                }
                equalizerPresetIndex    =   fileIndex;
                equalizerPresetName     =   fileName;
                EqualizerOpenPreset();
            }
        }

        // ----------------------------------------------------------------------
        private void EqualizerAddPreset() {
            string  title       =   "Equalizer manager (Add)";
            string  message     =   "Enter name of new preset, you wanna create.";
            string  defName     =   "New Preset";

            CustomMessageInputBox cmib = new CustomMessageInputBox( title, message, defName, EqualizerAddPreset );
            var dialogResult    =   cmib.ShowDialog();
        }

        private bool EqualizerAddPreset( object[] obj ) {
            string  presetsPath     =   Tools.GetDirectoryApplicationPresets();
            string  fileName        =   (string) obj[0];
            string  filePath        =   presetsPath + "\\" + fileName + ".aep";

            if ( File.Exists( filePath ) ) {
                string  title           =   "Equalizer manager";
                string  message         =   "Preset name \"" + fileName + "\" is alredy taken, choose other name.";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return false;
            }

            var fileWorker  =   File.Create( filePath );
            fileWorker.Close();
            UpdateEqualizer();
            return true;
        }

        // ----------------------------------------------------------------------
        private void EqualizerSavePreset( string fileName, int fileIndex ) {
            if ( fileIndex <= 11 ) {
                string  title       =   "Equalizer manager (Save)";
                string  message     =   "Built-in preset \"" + fileName + "\" can not be changed. Try save it as new preset.";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return;
            }

            if ( fileIndex > 11 ) {
                string  presetsPath     =   Tools.GetDirectoryApplicationPresets();
                string  presetName      =   fileName;
                string  presetFullPath  =   presetsPath + "\\" + presetName + ".aep";

                if ( File.Exists( presetFullPath ) ) {
                    int         count           =   equalizerPresetData.Length;
                    string[]    presetString    =   new string[ count ];
                    Encoding    encode          =   Encoding.GetEncoding( "Windows-1250" );
                    for ( int i = 0; i < count; i++ ) {
                        presetString[i]     =   equalizerPresetData[i].ToString();
                    }
                    File.WriteAllLines( presetFullPath, presetString, encode );
                }
            }
        }

        // ----------------------------------------------------------------------
        private void EqualizerSaveAsPreset() {
            string  title       =   "Equalizer manager (Add)";
            string  message     =   "Enter name of new preset, you wanna save.";
            string  defName     =   "New Preset";

            CustomMessageInputBox cmib = new CustomMessageInputBox( title, message, defName, EqualizerSavePreset );
            var dialogResult    =   cmib.ShowDialog();
        }

        private bool EqualizerSavePreset( object[] obj ) {
            string  presetsPath     =   Tools.GetDirectoryApplicationPresets();
            string  fileName        =   (string) obj[0];
            string  filePath        =   presetsPath + "\\" + fileName + ".aep";

            if ( File.Exists( filePath ) ) {
                string  title           =   "Equalizer manager";
                string  message         =   "Preset name \"" + fileName + "\" is alredy taken, choose other name.";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return false;
            }

            var fileWorker  =   File.Create( filePath );
            fileWorker.Close();
            UpdateEqualizer();

            equalizerPresetName     =   fileName;
            TreeNode[]  search      =   treeViewEqualizerMenu.Nodes[0].Nodes.Find( fileName, false );
            TreeNode    treeNode    =   ( search.Length > 0 ) ? search[ search.Length-1] : null;
            equalizerPresetIndex    =   ( treeNode != null ) ? treeNode.Index : 12;
            EqualizerSavePreset( equalizerPresetName, equalizerPresetIndex );
            return true;
        }

        // ----------------------------------------------------------------------
        private void EqualizerResetPreset() {
            equalizerPresetData     =   new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            EqualizerOpenPreset();
        }

        // ----------------------------------------------------------------------
        private void EqualizerRemovePreset( string fileName, int fileIndex ) {
            string  presetsPath     =   Tools.GetDirectoryApplicationPresets();
            string  filePath        =   presetsPath + "\\" + fileName + ".aep";

            if ( File.Exists( filePath ) ) {
                string          title       =   "Equalizer manager (Remove)";
                string          message     =   "Do you want to remove \"" + fileName + "\" preset?";
                DialogResult    result      =   MessageBox.Show( message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                if ( result == DialogResult.No ) { return; }

                File.Delete( filePath );
                UpdateEqualizer();
            }
        }

        // ----------------------------------------------------------------------
        private void EqualizerOpenEffect() {
            pagesEffects.ShowPanel( fLPanelEffects );
            labelEqualizerPresetName.Text   =   equalizerEffectsName;
            SoundModule.SetAmplification( true, equalizerEffectsData[0] );
            SoundModule.SetSoftSaturation( equalizerEffectsData[1] > 0 ? true : false, equalizerEffectsData[2], equalizerEffectsData[3] );
            SoundModule.SetStereoEnhancer( equalizerEffectsData[4] > 0 ? true : false, equalizerEffectsData[5], equalizerEffectsData[6] );
            SoundModule.SetIRRDelay( equalizerEffectsData[7] > 0 ? true : false, equalizerEffectsData[8], equalizerEffectsData[9], equalizerEffectsData[10] );
            SoundModule.SetEcho( equalizerEffectsData[11] > 0 ? true : false, equalizerEffectsData[12] );
            SoundModule.SetReverb( equalizerEffectsData[13] > 0 ? true : false, equalizerEffectsData[14] );
            SoundModule.SetChorus( equalizerEffectsData[15] > 0 ? true : false, equalizerEffectsData[16] );

            trackBarEffectsAmplification.Value          =   equalizerEffectsData[0];
            checkBoxEffectsSoftSaturation.Checked       =   equalizerEffectsData[1] > 0 ? true : false;
            trackBarEffectsSaturation.Enabled           =   checkBoxEffectsSoftSaturation.Checked;
            trackBarEffectsSaturationDepth.Enabled      =   checkBoxEffectsSoftSaturation.Checked;
            trackBarEffectsSaturation.Value             =   equalizerEffectsData[2];
            trackBarEffectsSaturationDepth.Value        =   equalizerEffectsData[3];
            checkBoxEffectsStereoEnhancer.Checked       =   equalizerEffectsData[4] > 0 ? true : false;
            trackBarEffectsStereoEnhancerWide.Enabled   =   checkBoxEffectsStereoEnhancer.Checked;
            trackBarEffectsStereoEnhancerDryWet.Enabled =   checkBoxEffectsStereoEnhancer.Checked;
            trackBarEffectsStereoEnhancerWide.Value     =   equalizerEffectsData[5];
            trackBarEffectsStereoEnhancerDryWet.Value   =   equalizerEffectsData[6];
            checkBoxEffectsIIRDelay.Checked             =   equalizerEffectsData[7] > 0 ? true : false;
            trackBarEffectsIIRDelay.Enabled             =   checkBoxEffectsIIRDelay.Checked;
            trackBarEffectsIIRDelayDryWet.Enabled       =   checkBoxEffectsIIRDelay.Checked;
            trackBarEffectsIIRDelayFeedback.Enabled     =   checkBoxEffectsIIRDelay.Checked;
            trackBarEffectsIIRDelay.Value               =   equalizerEffectsData[8];
            trackBarEffectsIIRDelayDryWet.Value         =   equalizerEffectsData[9];
            trackBarEffectsIIRDelayFeedback.Value       =   equalizerEffectsData[10];
            checkBoxEffectsEcho.Checked                 =   equalizerEffectsData[11] > 0 ? true : false;
            trackBarEffectsEcho.Enabled                 =   checkBoxEffectsEcho.Checked;
            trackBarEffectsEcho.Value                   =   equalizerEffectsData[12];
            checkBoxEffectsReverb.Checked               =   equalizerEffectsData[13] > 0 ? true : false;
            trackBarEffectsReverb.Enabled               =   checkBoxEffectsChorus.Checked;
            trackBarEffectsReverb.Value                 =   equalizerEffectsData[14];
            checkBoxEffectsChorus.Checked               =   equalizerEffectsData[15] > 0 ? true : false;
            trackBarEffectsChorus.Enabled               =   checkBoxEffectsChorus.Checked;
            trackBarEffectsChorus.Value                 =   equalizerEffectsData[16];
        }

        // ----------------------------------------------------------------------
        private void EqualizerOpenEffect( string fileName, int fileIndex ) {
            string  effectPath      =   Tools.GetDirectoryApplicationEffects();
            string  effectName      =   fileName;
            string  effectFullPath  =   effectPath + "\\" + effectName + ".aef";

            if ( fileIndex < Tools.equalizerEffectsName.Length ) {
                for ( int v = 0; v < equalizerEffectsData.Length; v++ ) {
                    equalizerEffectsData[ v ] = Tools.equalizerEffects[ fileIndex, v ];
                }
                equalizerEffectsIndex   =   fileIndex;
                equalizerEffectsName    =   fileName;
                EqualizerOpenEffect();
            }

            if ( File.Exists( effectFullPath ) ) {
                Encoding    encode          =   Encoding.GetEncoding( "Windows-1250" );
                string[]    effectString    =   File.ReadAllLines( effectFullPath, encode );
                int         count           =   Math.Min( effectString.Length, equalizerEffectsData.Length );
                equalizerEffectsData        = new int[17] { 0, 0, 50, 50, 0, 300, 70, 0, 24576, 50, 70, 0, 0, 0, 0, 0, 0 };

                for ( int s = 0; s < count; s++ ) {
                    int     value   =   0;
                    int.TryParse( effectString[s], out value );
                    equalizerEffectsData[ s ]   =   value;
                }
                equalizerEffectsIndex   =   fileIndex;
                equalizerEffectsName    =   fileName;
                EqualizerOpenEffect();
            }
        }

        // ----------------------------------------------------------------------
        private void EqualizerAddEffect() {
            string  title       =   "Effects manager (Add)";
            string  message     =   "Enter name of new effect, you wanna create.";
            string  defName     =   "New Effect";

            CustomMessageInputBox cmib = new CustomMessageInputBox( title, message, defName, EqualizerAddEffect );
            var dialogResult    =   cmib.ShowDialog();
        }

        private bool EqualizerAddEffect( object[] obj ) {
            string  effectPath      =   Tools.GetDirectoryApplicationEffects();
            string  effectName      =   (string) obj[0];
            string  effectFullPath  =   effectPath + "\\" + effectName + ".aef";

            if ( File.Exists( effectFullPath ) ) {
                string  title           =   "Effects manager";
                string  message         =   "Effect name \"" + effectName + "\" is alredy taken, choose other name.";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return false;
            }

            var fileWorker  =   File.Create( effectFullPath );
            fileWorker.Close();
            UpdateEqualizer();
            return true;
        }

        // ----------------------------------------------------------------------
        private void EqualizerSaveEffect( string fileName, int fileIndex ) {
            if ( fileIndex < Tools.equalizerEffectsName.Length ) {
                string  title       =   "Effects manager (Save)";
                string  message     =   "Built-in effect \"" + fileName + "\" can not be changed. Try save it as new preset.";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return;
            }

            if ( fileIndex >= Tools.equalizerEffectsName.Length ) {
                string  effectPath      =   Tools.GetDirectoryApplicationEffects();
                string  effectName      =   fileName;
                string  effectFullPath  =   effectPath + "\\" + effectName + ".aef";

                if ( File.Exists( effectFullPath ) ) {
                    int         count           =   equalizerEffectsData.Length;
                    string[]    effectsString   =   new string[ count ];
                    Encoding    encode          =   Encoding.GetEncoding( "Windows-1250" );
                    for ( int i = 0; i < count; i++ ) {
                        effectsString[i]    =   equalizerEffectsData[i].ToString();
                    }
                    File.WriteAllLines( effectFullPath, effectsString, encode );
                }
            }
        }

        // ----------------------------------------------------------------------
        private void EqualizerSaveAsEffect() {
            string  title       =   "Effects manager (Add)";
            string  message     =   "Enter name of new effect, you wanna save.";
            string  defName     =   "New Effect";

            CustomMessageInputBox cmib = new CustomMessageInputBox( title, message, defName, EqualizerSaveEffect );
            var dialogResult    =   cmib.ShowDialog();
        }

        private bool EqualizerSaveEffect( object[] obj ) {
            string  effectPath      =   Tools.GetDirectoryApplicationEffects();
            string  effectName      =   (string) obj[0];
            string  effectFullPath  =   effectPath + "\\" + effectName + ".aef";

            if ( File.Exists( effectFullPath ) ) {
                string  title           =   "Effects manager";
                string  message         =   "Effect name \"" + effectName + "\" is alredy taken, choose other name.";
                MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return false;
            }

            var fileWorker  =   File.Create( effectFullPath );
            fileWorker.Close();
            UpdateEqualizer();

            equalizerEffectsName    =   effectName;
            TreeNode[]  search      =   treeViewEqualizerMenu.Nodes[1].Nodes.Find( effectName, false );
            TreeNode    treeNode    =   ( search.Length > 0 ) ? search[ search.Length-1] : null;
            equalizerEffectsIndex   =   ( treeNode != null ) ? treeNode.Index : 12;
            EqualizerSaveEffect( equalizerEffectsName, equalizerEffectsIndex );
            return true;
        }

        // ----------------------------------------------------------------------
        private void EqualizerResetEffect() {
            equalizerEffectsData    =   new int[17] { 0, 0, 50, 50, 0, 300, 70, 0, 24576, 50, 70, 0, 0, 0, 0, 0, 0 };
            EqualizerOpenEffect();
        }

        // ----------------------------------------------------------------------
        private void EqualizerRemoveEffect( string fileName, int fileIndex ) {
            string  effectPath      =   Tools.GetDirectoryApplicationEffects();
            string  effectFullPath  =   effectPath + "\\" + fileName + ".aef";

            if ( File.Exists( effectFullPath ) ) {
                string          title       =   "Effects manager (Remove)";
                string          message     =   "Do you want to remove \"" + fileName + "\" effect?";
                DialogResult    result      =   MessageBox.Show( message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                if ( result == DialogResult.No ) { return; }

                File.Delete( effectFullPath );
                UpdateEqualizer();
            }
        }

        // ----------------------------------------------------------------------
        private void EqualizerAddElement() {
            string      title       =   "Equalizer & Effects manager";
            string      message     =   "Enter name of new preset or effect, you wanna create.";
            string      defName     =   "New equalizer data";
            string[]    data        =   new string[] { "Equalizer Preset", "Equalizer Effect" };

            CustomMessageDualBox cmdb   =   new CustomMessageDualBox( title, message, data, defName, EqualizerAddElement );
            var dialogResult    =   cmdb.ShowDialog();
        }

        private bool EqualizerAddElement( object[] obj ) {
            int         optionIndex     =   (int) obj[0];
            string      optionName      =   (string) obj[1];
            object[]    objects         =   new object[] { obj[2] };

            switch( optionIndex ) {
                case 0:
                    return EqualizerAddPreset( objects );
                case 1:
                    return EqualizerAddEffect( objects );
            }

            return false;
        }

        // ----------------------------------------------------------------------
        private void UpdateEqualizer() {
            treeViewEqualizerMenu.Nodes.Clear();
            TreeNode    presetNode      =   new TreeNode( "Equalizer Presets", 2, 2 );
            TreeNode    effectNode      =   new TreeNode( "Effect Presets", 1, 1 );
            string      presetsPath     =   Tools.GetDirectoryApplicationPresets();
            string      effectsPath     =   Tools.GetDirectoryApplicationEffects();

            // --- Fill Equalizer presets ---
            foreach( string name in Tools.equalizerPresetsName ) {
                presetNode.Nodes.Add( new TreeNode( name, 0, 0 ) );
            }

            foreach( FileInfo fileInfo in new DirectoryInfo( presetsPath ).GetFiles() ) {
                if ( File.Exists( fileInfo.FullName ) ) {
                    string  fileName    =   Path.GetFileNameWithoutExtension( fileInfo.FullName );
                    presetNode.Nodes.Add( new TreeNode( fileName, 0, 0 ) );
                }
            }

            // --- Fill Effects presets ---
            foreach( string name in Tools.equalizerEffectsName ) {
                effectNode.Nodes.Add( new TreeNode( name, 0, 0 ) );
            }

            foreach( FileInfo fileInfo in new DirectoryInfo( effectsPath ).GetFiles() ) {
                if ( File.Exists( fileInfo.FullName ) ) {
                    string  fileName    =   Path.GetFileNameWithoutExtension( fileInfo.FullName );
                    effectNode.Nodes.Add( new TreeNode( fileName, 0, 0 ) );
                }
            }

            treeViewEqualizerMenu.Nodes.Add( presetNode );
            treeViewEqualizerMenu.Nodes.Add( effectNode );
            effectNode.ExpandAll();
            presetNode.ExpandAll();
        }

        #endregion EqualizerManger
        // ######################################################################
        //  xxxxx    xxx    x   x    xxx    x       xxxxx   xxxxx   xxxxx   xxxx 
        //  x       x   x   x   x   x   x   x         x        x    x       x   x
        //  xxxx    x x x   x   x   xxxxx   x         x       x     xxxx    xxxx 
        //  x       x  xx   x   x   x   x   x         x      x      x       x   x
        //  xxxxx    xxx     xxx    x   x   xxxxx   xxxxx   xxxxx   xxxxx   x   x
        //
        //   xxxx   xxxxx   xxxx    xxxxx   xxxx     xxxx
        //  x         x      x  x   x       x   x   x    
        //   xxx      x      x  x   xxxx    xxxx     xxx 
        //      x     x      x  x   x       x   x       x
        //  xxxx    xxxxx   xxxx    xxxxx   x   x   xxxx 
        // ######################################################################
        #region EqualizerSound
        // ----------------------------------------------------------------------
        private void trackBarEqualizer50Hz_Scroll(object sender, EventArgs e) {
            string  trackBarName    =   ((TrackBar)sender).Name;
            string  cutOutPhrase    =   "trackBarEqualizer";
            int     cutOutStart     =   cutOutPhrase.Length;
            int     cutOutLength    =   cutOutPhrase.Length;
            string  trackBarInfo    =   trackBarName.Substring( cutOutStart, trackBarName.Length - cutOutLength);
            int     indexOf         =   Array.IndexOf( Tools.equalizerPresetInfo, trackBarInfo );
            string  labelValueName  =   "labelEqualizer" + Tools.equalizerPresetInfo[ indexOf ] + "Value";

            equalizerPresetData[ indexOf ]  =   ((TrackBar)sender).Value;
            Control[]   labelValue          =   tLPanelEqualizer.Controls.Find( labelValueName, true );
            if ( labelValue.Length > 0 ) { ((Label)labelValue[0]).Text = "+" + ((TrackBar)sender).Value.ToString(); }
            SoundModule.SetEqualizer( indexOf, ((TrackBar)sender).Value );
        }

        // ----------------------------------------------------------------------
        private void trackBarEffectsAmplification_Scroll(object sender, EventArgs e) {
            equalizerEffectsData[ 0 ]   =   ((TrackBar)sender).Value;
            SoundModule.SetAmplification( true, equalizerEffectsData[0] );
        }

        // ----------------------------------------------------------------------
        private void checkBoxEffectsSoftSaturation_CheckedChanged(object sender, EventArgs e) {
            bool    check               =   ((CheckBox)sender).Checked;
            equalizerEffectsData[ 1 ]   =   check ? 1 : 0;

            trackBarEffectsSaturation.Enabled           =   check;
            trackBarEffectsSaturationDepth.Enabled      =   check;
            SoundModule.SetSoftSaturation( equalizerEffectsData[1] > 0 ? true : false, equalizerEffectsData[2], equalizerEffectsData[3] );
        }

        // ----------------------------------------------------------------------
        private void trackBarEffectsSaturation_Scroll(object sender, EventArgs e) {
            equalizerEffectsData[ 2 ]   =   ((TrackBar)sender).Value;
            SoundModule.SetSoftSaturation( equalizerEffectsData[1] > 0 ? true : false, equalizerEffectsData[2], equalizerEffectsData[3] );
        }

        // ----------------------------------------------------------------------
        private void trackBarEffectsSaturationDepth_Scroll(object sender, EventArgs e) {
            equalizerEffectsData[ 3 ]   =   ((TrackBar)sender).Value;
            SoundModule.SetSoftSaturation( equalizerEffectsData[1] > 0 ? true : false, equalizerEffectsData[2], equalizerEffectsData[3] );
        }

        // ----------------------------------------------------------------------
        private void checkBoxEffectsStereoEnhancer_CheckedChanged(object sender, EventArgs e) {
            bool    check               =   ((CheckBox)sender).Checked;
            equalizerEffectsData[ 4 ]   =   check ? 1 : 0;

            trackBarEffectsStereoEnhancerWide.Enabled       =   check;
            trackBarEffectsStereoEnhancerDryWet.Enabled     =   check;
            SoundModule.SetStereoEnhancer( equalizerEffectsData[4] > 0 ? true : false, equalizerEffectsData[5], equalizerEffectsData[6] );
        }

        // ----------------------------------------------------------------------
        private void trackBarEffectsStereoEnhancerWide_Scroll(object sender, EventArgs e) {
            equalizerEffectsData[ 5 ]   =   ((TrackBar)sender).Value;
            SoundModule.SetStereoEnhancer( equalizerEffectsData[4] > 0 ? true : false, equalizerEffectsData[5], equalizerEffectsData[6] );
        }

        // ----------------------------------------------------------------------
        private void trackBarEffectsStereoEnhancerDryWet_Scroll(object sender, EventArgs e) {
            equalizerEffectsData[ 6 ]   =   ((TrackBar)sender).Value;
            SoundModule.SetStereoEnhancer( equalizerEffectsData[4] > 0 ? true : false, equalizerEffectsData[5], equalizerEffectsData[6] );
        }

        // ----------------------------------------------------------------------
        private void checkBoxEffectsIIRDelay_CheckedChanged(object sender, EventArgs e) {
            bool    check               =   ((CheckBox)sender).Checked;
            equalizerEffectsData[ 7 ]   =   check ? 1 : 0;

            trackBarEffectsIIRDelay.Enabled             =   check;
            trackBarEffectsIIRDelayDryWet.Enabled       =   check;
            trackBarEffectsIIRDelayFeedback.Enabled     =   check;
            SoundModule.SetIRRDelay( equalizerEffectsData[7] > 0 ? true : false, equalizerEffectsData[8], equalizerEffectsData[9], equalizerEffectsData[10] );
        }

        // ----------------------------------------------------------------------
        private void trackBarEffectsIIRDelay_Scroll(object sender, EventArgs e) {
            equalizerEffectsData[ 8 ]   =   ((TrackBar)sender).Value;
            SoundModule.SetIRRDelay( equalizerEffectsData[7] > 0 ? true : false, equalizerEffectsData[8], equalizerEffectsData[9], equalizerEffectsData[10] );
        }

        // ----------------------------------------------------------------------
        private void trackBarEffectsIIRDelayDryWet_Scroll(object sender, EventArgs e) {
            equalizerEffectsData[ 9 ]   =   ((TrackBar)sender).Value;
            SoundModule.SetIRRDelay( equalizerEffectsData[7] > 0 ? true : false, equalizerEffectsData[8], equalizerEffectsData[9], equalizerEffectsData[10] );
        }

        // ----------------------------------------------------------------------
        private void trackBarEffectsIIRDelayFeedback_Scroll(object sender, EventArgs e) {
            equalizerEffectsData[ 10 ]  =   ((TrackBar)sender).Value;
            SoundModule.SetIRRDelay( equalizerEffectsData[7] > 0 ? true : false, equalizerEffectsData[8], equalizerEffectsData[9], equalizerEffectsData[10] );
        }

        // ----------------------------------------------------------------------
        private void checkBoxEffectsEcho_CheckedChanged(object sender, EventArgs e) {
            bool    check               =   ((CheckBox)sender).Checked;
            equalizerEffectsData[ 11 ]  =   check ? 1 : 0;

            trackBarEffectsEcho.Enabled     =   check;
            SoundModule.SetEcho( equalizerEffectsData[11] > 0 ? true : false, equalizerEffectsData[12] );
        }

        // ----------------------------------------------------------------------
        private void trackBarEffectsEcho_Scroll(object sender, EventArgs e) {
            equalizerEffectsData[ 12 ]  =   ((TrackBar)sender).Value;
            SoundModule.SetEcho( equalizerEffectsData[11] > 0 ? true : false, equalizerEffectsData[12] );
        }

        // ----------------------------------------------------------------------
        private void checkBoxEffectsReverb_CheckedChanged(object sender, EventArgs e) {
            bool    check               =   ((CheckBox)sender).Checked;
            equalizerEffectsData[ 13 ]  =   check ? 1 : 0;

            trackBarEffectsReverb.Enabled   =   check;
            SoundModule.SetReverb( equalizerEffectsData[13] > 0 ? true : false, equalizerEffectsData[14] );
        }

        // ----------------------------------------------------------------------
        private void trackBarEffectsReverb_Scroll(object sender, EventArgs e) {
            equalizerEffectsData[ 14 ]  =   ((TrackBar)sender).Value;
            SoundModule.SetReverb( equalizerEffectsData[13] > 0 ? true : false, equalizerEffectsData[14] );
        }

        // ----------------------------------------------------------------------
        private void checkBoxEffectsChorus_CheckedChanged(object sender, EventArgs e) {
            bool    check               =   ((CheckBox)sender).Checked;
            equalizerEffectsData[ 15 ]  =   check ? 1 : 0;

            trackBarEffectsChorus.Enabled   =   check;
            SoundModule.SetChorus( equalizerEffectsData[15] > 0 ? true : false, equalizerEffectsData[16] );
        }

        // ----------------------------------------------------------------------
        private void trackBarEffectsChorus_Scroll(object sender, EventArgs e) {
            equalizerEffectsData[ 16 ]  =   ((TrackBar)sender).Value;
            SoundModule.SetChorus( equalizerEffectsData[15] > 0 ? true : false, equalizerEffectsData[16] );
        }

        #endregion EqualizerSound
        // ######################################################################
        //  xxxxx   x   x   xxxxx   x   x   xxxxx    xxxx
        //    x     x   x   x       xx xx   x       x    
        //    x     xxxxx   xxxx    x x x   xxxx     xxx 
        //    x     x   x   x       x   x   x           x
        //    x     x   x   xxxxx   x   x   xxxxx   xxxx 
        // ######################################################################
        #region Theme
        // ----------------------------------------------------------------------
        private void UpdateIconsTheme( bool darkMode ) {
            int     optionMenu      =   tlPanelPlayList.Visible || !panelVis.Visible ? 0 : 1;
            int[]   optionControls  =   new int[4] { statusPlay, statusMute, statusRepeat, statusShuffle };

            InterfaceDrawer.MenuButtonDraw( buttonHome, darkMode, optionMenu );
            InterfaceDrawer.MenuButtonDraw( buttonLibrary, darkMode, optionMenu );
            InterfaceDrawer.MenuButtonDraw( buttonFileExplorer, darkMode, optionMenu );
            InterfaceDrawer.MenuButtonDraw( buttonEqualizer, darkMode, optionMenu );
            InterfaceDrawer.MenuButtonDraw( buttonSettings, darkMode, optionMenu );
            InterfaceDrawer.ControlButtonDraw( buttonShuffle, darkMode, optionControls );
            InterfaceDrawer.ControlButtonDraw( buttonRepeat, darkMode, optionControls );
            InterfaceDrawer.ControlButtonDraw( buttonPrevious, darkMode, optionControls );
            InterfaceDrawer.ControlButtonDraw( buttonPlay, darkMode, optionControls );
            InterfaceDrawer.ControlButtonDraw( buttonForward, darkMode, optionControls );
            InterfaceDrawer.ControlButtonDraw( buttonStop, darkMode, optionControls );
            InterfaceDrawer.ControlButtonDraw( buttonVolume, darkMode, optionControls );

            if ( playingIndex >= 0 && playingIndex < playList.GetCount() ) {
                CustomFile  file    =   playList.GetFile( playingIndex );
                if ( CustomFileMetadata.GetMusicImage( file ).Length > 0 ) { return; }
            }

            if ( darkMode ) {
                pictureBoxCover.Image   =   IconsControl._64_Stereo;
                spectrum.infoCover      =   IconsControl._64_Stereo;
            } else {
                pictureBoxCover.Image   =   IconsControl._64_White_Stereo;
                spectrum.infoCover      =   IconsControl._64_White_Stereo;
            }
        }

        // ----------------------------------------------------------------------
        private void UpdateControlsTheme( bool darkMode ) {
            Color   color   =   Color.White;
            Color   rColor  =   Color.Black;

            if ( darkMode ) {
                color   =   Color.Black;
                rColor  =   Color.White;
            }

            labelPlayListTitle.ForeColor    =   color;
            labelTime.ForeColor             =   color;
            labelTimeLeft.ForeColor         =   color;
            labelTitle.ForeColor            =   color;
            labelArtist.ForeColor           =   color;
            labelAlbum.ForeColor            =   color;
            InterfaceDrawer.sliderColor     =   color;
            spectrum.infoFontColor          =   color;
            spectrum.infoBackColor          =   rColor;
        }

        #endregion Theme
        // ######################################################################
        //   xxxx   xxxxx   xxxxx   xxxxx   xxxxx   x   x    xxxx    xxxx
        //  x       x         x       x       x     xx  x   x       x    
        //   xxx    xxxx      x       x       x     x x x   x  xx    xxx 
        //      x   x         x       x       x     x  xx   x   x       x
        //  xxxx    xxxxx     x       x     xxxxx   x   x    xxxx   xxxx 
        //
        //  x   x    xxx    x   x    xxx     xxxx   x   x   xxxxx   x   x   xxxxx
        //  xx xx   x   x   xx  x   x   x   x       xx xx   x       xx  x     x  
        //  x x x   xxxxx   x x x   xxxxx   x  xx   x x x   xxxx    x x x     x  
        //  x   x   x   x   x  xx   x   x   x   x   x   x   x       x  xx     x  
        //  x   x   x   x   x   x   x   x    xxxx   x   x   xxxxx   x   x     x  
        // ######################################################################
        #region SettingsManagment
        // ----------------------------------------------------------------------
        //  x   x   xxxxx   x   x   x   x
        //  xx xx   x       xx  x   x   x
        //  x x x   xxxx    x x x   x   x
        //  x   x   x       x  xx   x   x
        //  x   x   xxxxx   x   x    xxx 
        // ----------------------------------------------------------------------
        private void treeViewSettingsMenu_AfterSelect(object sender, TreeViewEventArgs e) {
            TreeNode    node    =   treeViewSettingsMenu.SelectedNode;

            // --- Open selected Settings page ---
            if ( node == null ) { return; }
            if ( node.Name == "nodeGeneral") {
                pagesSettings.ShowPanel( fLPanelSettingsGeneral );
                UpdateSettings( fLPanelSettingsGeneral );

            } else if ( node.Name == "nodeInformations") {
                pagesSettings.ShowPanel( fLPanelSettingsInfo );
                UpdateSettings( fLPanelSettingsInfo );

            } else if ( node.Name == "nodePlayer") {
                pagesSettings.ShowPanel( fLPanelSettingsPlayer );
                UpdateSettings( fLPanelSettingsPlayer );

            } else if (node.Name == "nodeSound") {
                pagesSettings.ShowPanel( fLPanelSettingsSound );
                UpdateSettings( fLPanelSettingsSound );

            } else if (node.Name == "nodeTheme") {
                pagesSettings.ShowPanel( fLPanelSettingsTheme );
                UpdateSettings( fLPanelSettingsTheme );

            } else if (node.Name == "nodeVisualisation") {
                pagesSettings.ShowPanel( fLPanelSettingsVisualisation );
                UpdateSettings( fLPanelSettingsVisualisation );
            }

            treeViewSettingsMenu.SelectedNode   =   null;
        }

        // ----------------------------------------------------------------------
        private void UpdateSettings(FlowLayoutPanel sender) {
            // --- Settings Information ---
            if (sender == fLPanelSettingsInfo) {
            
            // --- Settings Player ---
            } else if (sender == fLPanelSettingsPlayer) {

            // --- Settings Sound ---
            } else if (sender == fLPanelSettingsSound) {
                UpdateSoundDevices();

            // --- Settings Theme ---
            } else if (sender == fLPanelSettingsTheme) {
                InterfaceDrawer.PictureBoxWallpaperDraw( pictureBoxThemeWallpaper06, wallpaperPath );

            // --- Settings Visualisation ---
            } else if (sender == fLPanelSettingsVisualisation) {

            } 
        }

        // ----------------------------------------------------------------------
        private void CopyInfoToClipboard(object sender, EventArgs e) {
            Clipboard.Clear();
            Clipboard.SetText( ((Label)sender).Text );
            string  title   =   "Copy to clipboard";
            string  data    =   "This information has been copied to clipboard." + Environment.NewLine +
                                "You can now paste it in to notepad and use it contained webpage addres.";

            MessageBox.Show( data, title, MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        // ----------------------------------------------------------------------
        //  xxxxx   x   x   xxxxx   x   x   xxxxx
        //    x     x   x   x       xx xx   x    
        //    x     xxxxx   xxxx    x x x   xxxx 
        //    x     x   x   x       x   x   x    
        //    x     x   x   xxxxx   x   x   xxxxx
        // ----------------------------------------------------------------------
        private void UpdateSettings_ThemeType( int index ) {
            ThemeType   type        =   (ThemeType) index;
            string      colorName   =   comboBoxThemeColor.SelectedItem.ToString();
            Color       color       =   fLPanelThemeCustomColor.BackColor;
            Color       system      =   Tools.GetSystemThemeColor();

            labelThemeColor.Visible             =   false;
            comboBoxThemeColor.Visible          =   false;
            labelThemeCustomColor.Visible       =   false;
            fLPanelThemeCustomColor.Visible     =   false;

            switch ( type ) {
                case ThemeType.None:
                    Settings.SetDataThemeColor( Color.Black );
                    break;

                case ThemeType.Color:
                    labelThemeColor.Visible         =   true;
                    comboBoxThemeColor.Visible      =   true;
                    Settings.SetDataThemeColor( colorName );
                    break;

                case ThemeType.CustomColor:
                    labelThemeCustomColor.Visible   =   true;
                    fLPanelThemeCustomColor.Visible =   true;
                    Settings.SetDataThemeColor( color );
                    break;

                case ThemeType.SystemColor:
                    Settings.SetDataThemeColor( system );
                    break;
            }

        }

        // ----------------------------------------------------------------------
        private void UpdateSettings_WallpaperType( int index ) {
            WallpaperType   type        =   (WallpaperType) index;
            string          colorName   =   comboBoxThemeWallpaperColor.SelectedItem.ToString();
            Color           color       =   fLPanelThemeWallpaperCustomColor.BackColor;

            labelThemeWallpaperColor.Visible            =   false;
            comboBoxThemeWallpaperColor.Visible         =   false;
            fLPanelThemeWallpaperCustomColor.Visible    =   false;
            fLPanelThemeWallpaper.Visible               =   false;
            labelThemeWallpaperPosition.Visible         =   false;
            comboBoxThemeWallpaperPosition.Visible      =   false;
            Settings.SetDataThemeWallpaper( type );

            switch ( type ) {
                case WallpaperType.None:
                    break;

                case WallpaperType.Color:
                    labelThemeWallpaperColor.Visible            =   true;
                    comboBoxThemeWallpaperColor.Visible         =   true;
                    Settings.SetDataThemeWallpaperColor( colorName );
                    break;

                case WallpaperType.CustomColor:
                    labelThemeWallpaperCustomColor.Visible      =   true;
                    fLPanelThemeWallpaperCustomColor.Visible    =   true;
                    Settings.SetDataThemeWallpaperColor( color );
                    break;

                case WallpaperType.Picture:
                    fLPanelThemeWallpaper.Visible               =   true;
                    labelThemeWallpaperPosition.Visible         =   true;
                    comboBoxThemeWallpaperPosition.Visible      =   true;
                    break;

                case WallpaperType.Wallpaper:
                    Settings.SetDataThemeWallpaperSystem();
                    break;
            }
        }

        // ----------------------------------------------------------------------
        private void UpdateSettings_UseTransparency( bool use ) {
            int     alpha       =   trackBarThemeTransparency.Value;

            if ( use ) {
                trackBarThemeTransparency.Enabled   =   true;
                Settings.SetDataThemeTransparency( alpha );
            } else {
                trackBarThemeTransparency.Enabled   =   false;
                Settings.SetDataThemeTransparency( 255 );
            }
        }

        // ----------------------------------------------------------------------
        //   xxxx   xxxx    xxxxx    xxx    xxxxx   xxxx    x   x   x   x
        //  x       x   x   x       x   x     x     x   x   x   x   xx xx
        //   xxx    xxxx    xxxx    x         x     xxxx    x   x   x x x
        //      x   x       x       x   x     x     x   x   x   x   x   x
        //  xxxx    x       xxxxx    xxx      x     x   x    xxx    x   x
        // ----------------------------------------------------------------------
        private void UpdateSettings_VisualisationColorScheme( int index ) {
            SpectrumFillType    type        =   (SpectrumFillType) index;
            string              colorName   =   comboBoxVisualisationColor.SelectedItem.ToString();
            Color               color       =   fLPanelVisualisationCustomColor.BackColor;

            labelVisualisationColor.Visible             =   false;
            comboBoxVisualisationColor.Visible          =   false;
            labelVisualisationCustomColor.Visible       =   false;
            fLPanelVisualisationCustomColor.Visible     =   false;
            labelVisualisationColorSpeed.Visible        =   false;
            trackBarVisualisationColorSpeed.Visible     =   false;
            labelVisualisationColorRainbow.Visible      =   false;
            trackBarVisualisationColorRainbow.Visible   =   false;

            switch ( type ) {
                case SpectrumFillType.Color:
                    labelVisualisationColor.Visible     =   true;
                    comboBoxVisualisationColor.Visible  =   true;
                    Settings.SetDataVisualisationColor( spectrum, colorName );
                    break;

                case SpectrumFillType.CustomColor:
                    labelVisualisationCustomColor.Visible       =   true;
                    fLPanelVisualisationCustomColor.Visible     =   true;
                    Settings.SetDataVisualisationColor( spectrum, color );
                    break;

                case SpectrumFillType.RainbowHorizontal:
                    labelVisualisationColorSpeed.Visible        =   true;
                    trackBarVisualisationColorSpeed.Visible     =   true;
                    labelVisualisationColorRainbow.Visible      =   true;
                    trackBarVisualisationColorRainbow.Visible   =   true;
                    break;

                case SpectrumFillType.RainbowVertical:
                    labelVisualisationColorSpeed.Visible        =   true;
                    trackBarVisualisationColorSpeed.Visible     =   true;
                    labelVisualisationColorRainbow.Visible      =   true;
                    trackBarVisualisationColorRainbow.Visible   =   true;
                    break;
            }

        }

        // ----------------------------------------------------------------------
        private void UpdateSettings_UseVisualisationTransparency( bool use ) {
            int     alpha       =   trackBarVisualisationTransparency.Value;

            if ( use ) {
                trackBarVisualisationTransparency.Enabled   =   true;
                Settings.SetDataVisualisationTransparency( spectrum, alpha );
            } else {
                trackBarVisualisationTransparency.Enabled   =   false;
                Settings.SetDataVisualisationTransparency( spectrum, 255 );
            }
        }

        // ----------------------------------------------------------------------
        //   xxxx    xxx    x   x   x   x   xxxx 
        //  x       x   x   x   x   xx  x    x  x
        //   xxx    x   x   x   x   x x x    x  x
        //      x   x   x   x   x   x  xx    x  x
        //  xxxx     xxx     xxx    x   x   xxxx 
        // ----------------------------------------------------------------------
        public void UpdateSoundDevices() {
            comboBoxSoundDevices.Items.Clear();

            foreach( string device in SoundModule.GetDevices() ) {
                comboBoxSoundDevices.Items.Add( device );
            }

            int selectedDevice                  =   SoundModule.GetSelectedDevice();
            comboBoxSoundDevices.SelectedItem   =   comboBoxSoundDevices.Items[ selectedDevice ];
        }

        // ----------------------------------------------------------------------
        public void SelectSoundDevice( int index ) {
            try {
                SoundModule.SelectDevice( index );
                if ( SoundModule.IsActivated() ) { SoundModule.ReinitWithStream( this ); }
                else if ( SoundModule.IsInitialized() ) { SoundModule.Reinit( this ); }
                else { SoundModule.Init( this ); }
            } catch ( Exception exc ) {
                System.Console.WriteLine( exc.ToString() );
                SoundModule.SelectDefaultDevice();
                try {
                    SoundModule.SelectDefaultDevice();
                    if ( SoundModule.IsActivated() ) { SoundModule.ReinitWithStream( this ); }
                    else if ( SoundModule.IsInitialized() ) { SoundModule.Reinit( this ); }
                    else { SoundModule.Init( this ); }
                } catch ( Exception exc2 ) { System.Console.WriteLine( exc.ToString() ); }
            }
        }

        #endregion SettingsManagment
        // ######################################################################
        //   xxxx   xxxxx   xxxxx   xxxxx   xxxxx   x   x    xxxx    xxxx
        //  x       x         x       x       x     xx  x   x       x    
        //   xxx    xxxx      x       x       x     x x x   x  xx    xxx 
        //      x   x         x       x       x     x  xx   x   x       x
        //  xxxx    xxxxx     x       x     xxxxx   x   x    xxxx   xxxx 
        //
        //   xxx    x   x    xxx    x   x    xxxx   xxxxx
        //  x   x   x   x   x   x   xx  x   x       x    
        //  x       xxxxx   xxxxx   x x x   x  xx   xxxx 
        //  x   x   x   x   x   x   x  xx   x   x   x    
        //   xxx    x   x   x   x   x   x    xxxx   xxxxx
        // ######################################################################
        #region #SettingsChange
        // ----------------------------------------------------------------------
        //  xxxxx   x   x   xxxxx   x   x   xxxxx
        //    x     x   x   x       xx xx   x    
        //    x     xxxxx   xxxx    x x x   xxxx 
        //    x     x   x   x       x   x   x    
        //    x     x   x   xxxxx   x   x   xxxxx
        // ----------------------------------------------------------------------
        private void comboBoxThemeType_SelectionChangeCommitted(object sender, EventArgs e) {
            int     index       =   ((ComboBox)sender).SelectedIndex;
            UpdateSettings_ThemeType( index );
            UpdateInterface();
        }

        // ----------------------------------------------------------------------
        private void comboBoxThemeColor_SelectionChangeCommitted(object sender, EventArgs e) {
            string  colorName   =   ((ComboBox)sender).SelectedItem.ToString();
            Settings.SetDataThemeColor( colorName );
            UpdateInterface();
        }

        // ----------------------------------------------------------------------
        private void buttonThemeCustomColor_Click(object sender, EventArgs e) {
            Color   color       =   fLPanelThemeCustomColor.BackColor;
            Settings.SetDataThemeCustomColor( color );
            Settings.SetObjCustomThemeColor( fLPanelThemeCustomColor, InterfaceDrawer.controlsColor );
            UpdateInterface();
        }

        // ----------------------------------------------------------------------
        private void comboBoxThemeWallpaper_SelectionChangeCommitted(object sender, EventArgs e) {
            int     index       =   ((ComboBox)sender).SelectedIndex;
            UpdateSettings_WallpaperType( index );

            RenderInterface();
            UpdateInterface();
        }

        // ----------------------------------------------------------------------
        private void comboBoxThemeWallpaperColor_SelectionChangeCommitted(object sender, EventArgs e) {
            string  colorName   =   ((ComboBox)sender).SelectedItem.ToString();
            Settings.SetDataThemeWallpaperColor( colorName );

            RenderInterface();
            UpdateInterface();
        }

        // ----------------------------------------------------------------------
        private void buttonThemeWallpaperCustomColor_Click(object sender, EventArgs e) {
            Color   color   =   fLPanelThemeWallpaperCustomColor.BackColor;
            Settings.SetDataThemeWallpaperCustomColor( color );
            Settings.SetObjCustomThemeColor( fLPanelThemeWallpaperCustomColor, InterfaceDrawer.backgroundColor );

            RenderInterface();
            UpdateInterface();
        }

        // ----------------------------------------------------------------------
        private void pictureBoxThemeWallpaper_DoubleClick(object sender, EventArgs e) {
            string  name            =   ((PictureBox)sender).Name;
            string  stringIndex     =   name.Substring( name.Length - 2 );
            int     index           =   1;

            int.TryParse( stringIndex, out index );
            Settings.SetDataThemeWallpaperImage( index, wallpaperPath );
            wallpaperIndex          =   index;

            RenderInterface();
            UpdateInterface();
        }

        // ----------------------------------------------------------------------
        private void pictureBoxThemeWallpaperCustom_Click(object sender, EventArgs e) {
            Point   cursorPosition  =   Cursor.Position;
                    cursorPosition  =   ((PictureBox)sender).PointToClient( cursorPosition );

            if ( cursorPosition.X > ((PictureBox)sender).Width - 48 && cursorPosition.Y > ((PictureBox)sender).Height - 48 ) {
                string  initPath    =   Tools.GetDirectoryPictures();
                Settings.SetDataThemeWallpaperCustomImage( (PictureBox)sender, initPath, out wallpaperPath );

                RenderInterface();
                UpdateInterface();
            }
        }

        // ----------------------------------------------------------------------
        private void pictureBoxThemeWallpaperCustom_DoubleClick(object sender, EventArgs e) {
            Point   cursorPosition  =   Cursor.Position;
            cursorPosition          =   ((PictureBox)sender).PointToClient( cursorPosition );

            if ( cursorPosition.X < ((PictureBox)sender).Width - 48 || cursorPosition.Y < ((PictureBox)sender).Height - 48 ) {
                Settings.SetDataThemeWallpaperCustomImage( wallpaperPath );

                RenderInterface();
                UpdateInterface();
            }
        }

        // ----------------------------------------------------------------------
        private void comboBoxThemeWallpaperPosition_SelectionChangeCommitted(object sender, EventArgs e) {
            int                 index   =   ((ComboBox)sender).SelectedIndex;
            WallpaperDrawType   type    =   (WallpaperDrawType) index;
            Settings.SetDataThemeWallpaperPosition( type );

            RenderInterface();
            UpdateInterface();
        }

        // ----------------------------------------------------------------------
        private void checkBoxThemeDarkTheme_CheckedChanged(object sender, EventArgs e) {
            bool    check       =   ((CheckBox)sender).Checked;
                    darkMode    =   check;

            UpdateIconsTheme( darkMode );
            UpdateControlsTheme( darkMode );
            panelSlider.Invalidate();
            panelVolume.Invalidate();
        }

        // ----------------------------------------------------------------------
        private void checkBoxThemeTransparency_CheckedChanged(object sender, EventArgs e) {
            bool    check   =   ((CheckBox)sender).Checked;
            UpdateSettings_UseTransparency( check );

            RenderInterface();
            UpdateInterface();
        }

        // ----------------------------------------------------------------------
        private void trackBarThemeTransparency_Scroll(object sender, EventArgs e) {
            int     alpha   =   ((TrackBar)sender).Value;
            Settings.SetDataThemeTransparency( alpha );

            RenderInterface();
            UpdateInterface();
        }

        // ----------------------------------------------------------------------
        //   xxxx   xxxx    xxxxx    xxx    xxxxx   xxxx    x   x   x   x
        //  x       x   x   x       x   x     x     x   x   x   x   xx xx
        //   xxx    xxxx    xxxx    x         x     xxxx    x   x   x x x
        //      x   x       x       x   x     x     x   x   x   x   x   x
        //  xxxx    x       xxxxx    xxx      x     x   x    xxx    x   x
        // ----------------------------------------------------------------------
        private void comboBoxVisualisationType_SelectionChangeCommitted(object sender, EventArgs e) {
            int             index   =   ((ComboBox)sender).SelectedIndex;
            SpectrumType    type    =   (SpectrumType) index;
            Settings.SetDataVisualisationType( spectrum, type );
        }

        // ----------------------------------------------------------------------
        private void trackBarVisualisationSize_Scroll(object sender, EventArgs e) {
            int     value   =   ((TrackBar)sender).Value;
            Settings.SetDataVisualisationSize( spectrum, value );
        }

        // ----------------------------------------------------------------------
        private void comboBoxVisualisationLogo_SelectionChangeCommitted(object sender, EventArgs e) {
            int             index   =   ((ComboBox)sender).SelectedIndex;
            SpectrumLogo    logo    =   (SpectrumLogo) index;
            Settings.SetDataVisualisationLogo( spectrum, logo );
        }

        // ----------------------------------------------------------------------
        private void comboBoxVisualisationColorType_SelectionChangeCommitted(object sender, EventArgs e) {
            int                 index   =   ((ComboBox)sender).SelectedIndex;
            SpectrumFillType    type    =   (SpectrumFillType) index;
            Settings.SetDataVisualisationColorScheme( spectrum, type );
            UpdateSettings_VisualisationColorScheme( index );
        }

        // ----------------------------------------------------------------------
        private void comboBoxVisualisationColor_SelectionChangeCommitted(object sender, EventArgs e) {
            string  colorName   =   ((ComboBox)sender).SelectedItem.ToString();
            Settings.SetDataVisualisationColor( spectrum, colorName );
        }

        // ----------------------------------------------------------------------
        private void buttonVisualisationCustomColor_Click(object sender, EventArgs e) {
            Color   color   =   fLPanelVisualisationCustomColor.BackColor;
            Settings.SetDataCustomVisualisationColor( spectrum, color );
            Settings.SetObjectCustomVisualisationColor( fLPanelVisualisationCustomColor, spectrum.fillColor );
        }

        // ----------------------------------------------------------------------
        private void trackBarVisualisationColorSpeed_Scroll(object sender, EventArgs e) {
            int     value   =   ((TrackBar)sender).Value;
            Settings.SetDataVisualisationRainbowSpeed( spectrum, value );
        }

        // ----------------------------------------------------------------------
        private void trackBarVisualisationColorRainbow_Scroll(object sender, EventArgs e) {
            int     value   =   ((TrackBar)sender).Value;
            Settings.SetDataVisualisationRainbowColor( spectrum, value );
        }

        // ----------------------------------------------------------------------
        private void checkBoxVisualisationTransparency_CheckedChanged(object sender, EventArgs e) {
            bool    check   =   ((CheckBox)sender).Checked;
            UpdateSettings_UseVisualisationTransparency( check );
        }

        // ----------------------------------------------------------------------
        private void trackBarVisualisationTransparency_Scroll(object sender, EventArgs e) {
            int     value   =   ((TrackBar)sender).Value;
            Settings.SetDataVisualisationTransparency( spectrum, value );
        }

        // ----------------------------------------------------------------------
        private void comboBoxVisualisationFill_SelectionChangeCommitted(object sender, EventArgs e) {
            int                 index   =   ((ComboBox)sender).SelectedIndex;
            SpectrumFillStyle   fill    =   (SpectrumFillStyle) index;
            Settings.SetDataVisualisationFill( spectrum, fill );
        }

        // ----------------------------------------------------------------------
        private void trackBarVisualisationSensitivity_Scroll(object sender, EventArgs e) {
            int     value   =   ((TrackBar)sender).Value;
            Settings.SetDataVisualisationSensitivity( spectrum, value );
        }

        // ----------------------------------------------------------------------
        //  xxxx    x        xxx    x   x   xxxxx   xxxx 
        //  x   x   x       x   x   x   x   x       x   x
        //  xxxx    x       xxxxx    xxx    xxxx    xxxx 
        //  x       x       x   x     x     x       x   x
        //  x       xxxxx   x   x     x     xxxxx   x   x
        // ----------------------------------------------------------------------
        private void trackBarPlayerInfo_Scroll(object sender, EventArgs e) {
            int     value   =   ((TrackBar)sender).Value;
            Settings.SetDataPlayerInformationTimeout( spectrum, value );
        }

        // ----------------------------------------------------------------------
        private void checkBoxPlayerNotification_CheckedChanged(object sender, EventArgs e) {
            bool    check   =   ((CheckBox)sender).Checked;
            Settings.SetDataPlayerNotification( notifyIcon, check );
        }

        // ----------------------------------------------------------------------
        private void checkBoxAutoPlay_CheckedChanged(object sender, EventArgs e) {
            bool    check   =   ((CheckBox)sender).Checked;
            statusAutoPlay  =   check;
        }

        // ----------------------------------------------------------------------
        private void checkBoxAutoComeback_CheckedChanged(object sender, EventArgs e) {
            bool    check   =   ((CheckBox)sender).Checked;
            statusAutoBack  =   check;
        }

        // ----------------------------------------------------------------------
        private void checkBoxPlayerAutoSave_CheckedChanged(object sender, EventArgs e) {
            bool    check   =   ((CheckBox)sender).Checked;
            statusAutoSave  =   check;
        }

        // ----------------------------------------------------------------------
        //   xxxx   xxxxx   x   x   xxxxx   xxxx     xxx    x    
        //  x       x       xx  x   x       x   x   x   x   x    
        //  x  xx   xxxx    x x x   xxxx    xxxx    xxxxx   x    
        //  x   x   x       x  xx   x       x   x   x   x   x    
        //   xxxx   xxxxx   x   x   xxxxx   x   x   x   x   xxxxx
        // ----------------------------------------------------------------------
        private void checkBoxGeneralAnimSpec_CheckedChanged(object sender, EventArgs e) {
            bool    check   =   ((CheckBox)sender).Checked;
            Settings.SetDataGeneralAnimSpec( spectrum, check );
        }

        // ----------------------------------------------------------------------
        //   xxxx    xxx    x   x   x   x   xxxx 
        //  x       x   x   x   x   xx  x    x  x
        //   xxx    x   x   x   x   x x x    x  x
        //      x   x   x   x   x   x  xx    x  x
        //  xxxx     xxx     xxx    x   x   xxxx 
        // ----------------------------------------------------------------------
        private void buttonSoundDevicesRefresh_Click(object sender, EventArgs e) {
            UpdateSoundDevices();
        }

        // ----------------------------------------------------------------------
        private void comboBoxSoundDevices_SelectedIndexChanged(object sender, EventArgs e) {
            int index   =   ((ComboBox)sender).SelectedIndex;
            if ( index >= 0 && index < ((ComboBox)sender).Items.Count ) {
                SelectSoundDevice( index );
            }
        }

        #endregion SettingsChange
        // ######################################################################
    }

    // ################################################################################
}
