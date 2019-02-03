namespace AnthraX
{
    partial class FormAnthraX
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("TEST item One", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("TEST item Two", 2);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("TEST item Three", "32_White_Stereo.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnthraX));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General", 3, 3);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Informations", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Media Player", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Sound", 4, 4);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Theme", 5, 5);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Visualisation", 6, 6);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pliczek",
            "Tytulik",
            "Artyścik",
            "Albumik",
            "00:01"}, 8);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Now Playing", 1, 1);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Default");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Bass");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Dance");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Live");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Pop");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Power");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Rock");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Treble");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Vocal");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Xplode 1");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Xplode 2");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Xplode 3");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Equalizer Presets", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("No Effect");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Default");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Effect Presets", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22});
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Przykładowy tekst"}, -1);
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonRepeat = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.tLPanelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.panelVolume = new System.Windows.Forms.Panel();
            this.pictureBoxCatalystVolume = new System.Windows.Forms.PictureBox();
            this.buttonVolume = new System.Windows.Forms.Button();
            this.buttonShuffle = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.panelSlider = new System.Windows.Forms.Panel();
            this.pictureBoxCatalystSlider = new System.Windows.Forms.PictureBox();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.fLPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonLibrary = new System.Windows.Forms.Button();
            this.buttonFileExplorer = new System.Windows.Forms.Button();
            this.buttonKaraoke = new System.Windows.Forms.Button();
            this.buttonEqualizer = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelVis = new System.Windows.Forms.Panel();
            this.pictureBoxCatalystVis = new System.Windows.Forms.PictureBox();
            this.tlPanelPlayList = new System.Windows.Forms.TableLayoutPanel();
            this.panelPlayListSplit = new System.Windows.Forms.Panel();
            this.labelPlayListTitle = new System.Windows.Forms.Label();
            this.fLPanelPlayListMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelPlayListMenuOffset = new System.Windows.Forms.Panel();
            this.buttonPlayListOpen = new System.Windows.Forms.Button();
            this.buttonPlayListSave = new System.Windows.Forms.Button();
            this.buttonPlayListDelete = new System.Windows.Forms.Button();
            this.buttonPlayListMoveUp = new System.Windows.Forms.Button();
            this.buttonPlayListMoveDown = new System.Windows.Forms.Button();
            this.buttonPlayListSort = new System.Windows.Forms.Button();
            this.listViewNowPlaying = new System.Windows.Forms.ListView();
            this.imageListNowPlaying = new System.Windows.Forms.ImageList(this.components);
            this.panelClient = new System.Windows.Forms.Panel();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.fLPanelSettingsInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.labelInfoTitle = new System.Windows.Forms.Label();
            this.labelInfoSubTitleMain = new System.Windows.Forms.Label();
            this.labelInfoMain = new System.Windows.Forms.Label();
            this.labelInfoAuthor = new System.Windows.Forms.Label();
            this.labelInfoCompany = new System.Windows.Forms.Label();
            this.labelInfoCompiler = new System.Windows.Forms.Label();
            this.labelInfoPlatform = new System.Windows.Forms.Label();
            this.labelInfoVersion = new System.Windows.Forms.Label();
            this.labelInfoSubTitleCopyrights = new System.Windows.Forms.Label();
            this.labelInfoCopyrightsCode = new System.Windows.Forms.Label();
            this.labelInfoCopyrightDll = new System.Windows.Forms.Label();
            this.labelInfoCopyrightBassDll = new System.Windows.Forms.Label();
            this.labelInfoCopyrightBassNet = new System.Windows.Forms.Label();
            this.labelInfoCopyrightTagLib = new System.Windows.Forms.Label();
            this.labelInfoCopyrightIcons = new System.Windows.Forms.Label();
            this.labelInfoCopyrightIconsDevine = new System.Windows.Forms.Label();
            this.labelInfoCopyrightIconsGinux = new System.Windows.Forms.Label();
            this.labelInfoCopyrightIconsGnome = new System.Windows.Forms.Label();
            this.labelInfoCopyrightIconsWindows8 = new System.Windows.Forms.Label();
            this.labelInfoCopyrightImage = new System.Windows.Forms.Label();
            this.labelInfoCopyrightImage284301 = new System.Windows.Forms.Label();
            this.labelInfoCopyrightImage105358 = new System.Windows.Forms.Label();
            this.labelInfoCopyrightImage411175 = new System.Windows.Forms.Label();
            this.labelInfoCopyrightImage70937 = new System.Windows.Forms.Label();
            this.labelInfoCopyrightImage87577 = new System.Windows.Forms.Label();
            this.labelInfoSubTitleVersions = new System.Windows.Forms.Label();
            this.labelInfoVersionAlpha = new System.Windows.Forms.Label();
            this.labelInfoVersionBeta = new System.Windows.Forms.Label();
            this.labelInfoVersionBetaA = new System.Windows.Forms.Label();
            this.labelInfoVersionEnd = new System.Windows.Forms.Label();
            this.fLPanelSettingsGeneral = new System.Windows.Forms.FlowLayoutPanel();
            this.labelGneralTitle = new System.Windows.Forms.Label();
            this.labelGeneralSubTitleAnimations = new System.Windows.Forms.Label();
            this.checkBoxGeneralAnimSpec = new System.Windows.Forms.CheckBox();
            this.fLPanelSettingsPlayer = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSettingsPlayerTitle = new System.Windows.Forms.Label();
            this.labelPlayerSubTitleInfo = new System.Windows.Forms.Label();
            this.labelPlayerInfo = new System.Windows.Forms.Label();
            this.trackBarPlayerInfo = new System.Windows.Forms.TrackBar();
            this.checkBoxPlayerNotification = new System.Windows.Forms.CheckBox();
            this.labelPlayerSubTitlePlayer = new System.Windows.Forms.Label();
            this.checkBoxPlayerAutoPlay = new System.Windows.Forms.CheckBox();
            this.checkBoxPlayerAutoComeback = new System.Windows.Forms.CheckBox();
            this.checkBoxPlayerAutoSave = new System.Windows.Forms.CheckBox();
            this.fLPanelSettingsSound = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSoundTitle = new System.Windows.Forms.Label();
            this.labelSoundDevice = new System.Windows.Forms.Label();
            this.comboBoxSoundDevices = new System.Windows.Forms.ComboBox();
            this.fLPanelSoundDevices = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSoundDevicesRefresh = new System.Windows.Forms.Button();
            this.labelSoundPeaks = new System.Windows.Forms.Label();
            this.progressBarSoundLeft = new System.Windows.Forms.ProgressBar();
            this.progressBarSoundRight = new System.Windows.Forms.ProgressBar();
            this.fLPanelSettingsTheme = new System.Windows.Forms.FlowLayoutPanel();
            this.labelThemeTitle = new System.Windows.Forms.Label();
            this.labelThemeSubTitleColors = new System.Windows.Forms.Label();
            this.labelTheme = new System.Windows.Forms.Label();
            this.comboBoxThemeType = new System.Windows.Forms.ComboBox();
            this.labelThemeColor = new System.Windows.Forms.Label();
            this.comboBoxThemeColor = new System.Windows.Forms.ComboBox();
            this.labelThemeCustomColor = new System.Windows.Forms.Label();
            this.fLPanelThemeCustomColor = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonThemeCustomColor = new System.Windows.Forms.Button();
            this.labelThemeSubTitleWallpaper = new System.Windows.Forms.Label();
            this.labelThemeWallpaper = new System.Windows.Forms.Label();
            this.comboBoxThemeWallpaper = new System.Windows.Forms.ComboBox();
            this.labelThemeWallpaperColor = new System.Windows.Forms.Label();
            this.comboBoxThemeWallpaperColor = new System.Windows.Forms.ComboBox();
            this.labelThemeWallpaperCustomColor = new System.Windows.Forms.Label();
            this.fLPanelThemeWallpaperCustomColor = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonThemeWallpaperCustomColor = new System.Windows.Forms.Button();
            this.fLPanelThemeWallpaper = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxThemeWallpaper01 = new System.Windows.Forms.PictureBox();
            this.pictureBoxThemeWallpaper02 = new System.Windows.Forms.PictureBox();
            this.pictureBoxThemeWallpaper03 = new System.Windows.Forms.PictureBox();
            this.pictureBoxThemeWallpaper04 = new System.Windows.Forms.PictureBox();
            this.pictureBoxThemeWallpaper05 = new System.Windows.Forms.PictureBox();
            this.pictureBoxThemeWallpaper06 = new System.Windows.Forms.PictureBox();
            this.labelThemeWallpaperPosition = new System.Windows.Forms.Label();
            this.comboBoxThemeWallpaperPosition = new System.Windows.Forms.ComboBox();
            this.labelThemeSubTitleMore = new System.Windows.Forms.Label();
            this.checkBoxThemeDarkTheme = new System.Windows.Forms.CheckBox();
            this.checkBoxThemeTransparency = new System.Windows.Forms.CheckBox();
            this.trackBarThemeTransparency = new System.Windows.Forms.TrackBar();
            this.fLPanelSettingsVisualisation = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSettingsVisualisationTitle = new System.Windows.Forms.Label();
            this.labelVisualisationSubTitleType = new System.Windows.Forms.Label();
            this.labelVisualisationType = new System.Windows.Forms.Label();
            this.comboBoxVisualisationType = new System.Windows.Forms.ComboBox();
            this.labelVisualisationSize = new System.Windows.Forms.Label();
            this.trackBarVisualisationSize = new System.Windows.Forms.TrackBar();
            this.labelVisualisationSubTitleLogo = new System.Windows.Forms.Label();
            this.labelVisualisationLogo = new System.Windows.Forms.Label();
            this.comboBoxVisualisationLogo = new System.Windows.Forms.ComboBox();
            this.labelVisualisationSubTitleStyle = new System.Windows.Forms.Label();
            this.labelVisualisationColorScheme = new System.Windows.Forms.Label();
            this.comboBoxVisualisationColorType = new System.Windows.Forms.ComboBox();
            this.labelVisualisationColor = new System.Windows.Forms.Label();
            this.comboBoxVisualisationColor = new System.Windows.Forms.ComboBox();
            this.labelVisualisationCustomColor = new System.Windows.Forms.Label();
            this.fLPanelVisualisationCustomColor = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonVisualisationCustomColor = new System.Windows.Forms.Button();
            this.labelVisualisationColorSpeed = new System.Windows.Forms.Label();
            this.trackBarVisualisationColorSpeed = new System.Windows.Forms.TrackBar();
            this.labelVisualisationColorRainbow = new System.Windows.Forms.Label();
            this.trackBarVisualisationColorRainbow = new System.Windows.Forms.TrackBar();
            this.checkBoxVisualisationTransparency = new System.Windows.Forms.CheckBox();
            this.trackBarVisualisationTransparency = new System.Windows.Forms.TrackBar();
            this.labelVisualisationFill = new System.Windows.Forms.Label();
            this.comboBoxVisualisationFill = new System.Windows.Forms.ComboBox();
            this.labelVisualisationSubTitleOptions = new System.Windows.Forms.Label();
            this.labelVisualisationSensitivity = new System.Windows.Forms.Label();
            this.trackBarVisualisationSensitivity = new System.Windows.Forms.TrackBar();
            this.panelSettingsBorder = new System.Windows.Forms.Panel();
            this.tLPanelSettingsMenu = new System.Windows.Forms.TableLayoutPanel();
            this.labelSettingsMenuTitle = new System.Windows.Forms.Label();
            this.treeViewSettingsMenu = new System.Windows.Forms.TreeView();
            this.imageListSettingsMenu = new System.Windows.Forms.ImageList(this.components);
            this.buttonSettingsSave = new System.Windows.Forms.Button();
            this.panelLibrary = new System.Windows.Forms.Panel();
            this.panelLibraryFiles = new System.Windows.Forms.Panel();
            this.listViewLibrary = new System.Windows.Forms.ListView();
            this.columnHeaderFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelLibraryName = new System.Windows.Forms.Label();
            this.panelLibraryToolbar = new System.Windows.Forms.Panel();
            this.tLPanelLibraryTools = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLibraryRemovePlaylist = new System.Windows.Forms.Button();
            this.buttonLibraryAddPlaylist = new System.Windows.Forms.Button();
            this.treeViewLibraryPlaylists = new System.Windows.Forms.TreeView();
            this.imageListLibraryMenu = new System.Windows.Forms.ImageList(this.components);
            this.labelLibraryInfo = new System.Windows.Forms.Label();
            this.panelLibraryMenubar = new System.Windows.Forms.Panel();
            this.tLPanelLibraryMenu = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLibraryNowPlay = new System.Windows.Forms.Button();
            this.panelLibrarySort = new System.Windows.Forms.Panel();
            this.comboBoxLibrarySort = new System.Windows.Forms.ComboBox();
            this.buttonLibrarySort = new System.Windows.Forms.Button();
            this.buttonLibraryMoveTo = new System.Windows.Forms.Button();
            this.buttonLibraryRemove = new System.Windows.Forms.Button();
            this.buttonLibraryClear = new System.Windows.Forms.Button();
            this.buttonLibrarySaveAs = new System.Windows.Forms.Button();
            this.buttonLibrarySave = new System.Windows.Forms.Button();
            this.buttonLibraryOpen = new System.Windows.Forms.Button();
            this.buttonLibraryNew = new System.Windows.Forms.Button();
            this.labelLibraryTitle = new System.Windows.Forms.Label();
            this.panelEqualizer = new System.Windows.Forms.Panel();
            this.fLPanelEffects = new System.Windows.Forms.FlowLayoutPanel();
            this.labelEffectsTitle = new System.Windows.Forms.Label();
            this.labelEffectsAmplification = new System.Windows.Forms.Label();
            this.trackBarEffectsAmplification = new System.Windows.Forms.TrackBar();
            this.panelEffectsAmplification = new System.Windows.Forms.Panel();
            this.labelEffectsAmplificationMax = new System.Windows.Forms.Label();
            this.labelEffectsAmplificationMin = new System.Windows.Forms.Label();
            this.checkBoxEffectsSoftSaturation = new System.Windows.Forms.CheckBox();
            this.labelEffectsSaturation = new System.Windows.Forms.Label();
            this.trackBarEffectsSaturation = new System.Windows.Forms.TrackBar();
            this.labelEffectsSaturationDepth = new System.Windows.Forms.Label();
            this.trackBarEffectsSaturationDepth = new System.Windows.Forms.TrackBar();
            this.checkBoxEffectsStereoEnhancer = new System.Windows.Forms.CheckBox();
            this.labelEffectsStereoEnhancerWide = new System.Windows.Forms.Label();
            this.trackBarEffectsStereoEnhancerWide = new System.Windows.Forms.TrackBar();
            this.labelEffectsStereoEnhancerDryWet = new System.Windows.Forms.Label();
            this.trackBarEffectsStereoEnhancerDryWet = new System.Windows.Forms.TrackBar();
            this.checkBoxEffectsIIRDelay = new System.Windows.Forms.CheckBox();
            this.labelEffectsIIRDelay = new System.Windows.Forms.Label();
            this.trackBarEffectsIIRDelay = new System.Windows.Forms.TrackBar();
            this.labelEffectsIIRDelayDryWet = new System.Windows.Forms.Label();
            this.trackBarEffectsIIRDelayDryWet = new System.Windows.Forms.TrackBar();
            this.labelEffectsIIRDelayFeedback = new System.Windows.Forms.Label();
            this.trackBarEffectsIIRDelayFeedback = new System.Windows.Forms.TrackBar();
            this.checkBoxEffectsEcho = new System.Windows.Forms.CheckBox();
            this.trackBarEffectsEcho = new System.Windows.Forms.TrackBar();
            this.checkBoxEffectsReverb = new System.Windows.Forms.CheckBox();
            this.trackBarEffectsReverb = new System.Windows.Forms.TrackBar();
            this.checkBoxEffectsChorus = new System.Windows.Forms.CheckBox();
            this.trackBarEffectsChorus = new System.Windows.Forms.TrackBar();
            this.tLPanelEqualizer = new System.Windows.Forms.TableLayoutPanel();
            this.labelEqualizer18kHzValue = new System.Windows.Forms.Label();
            this.labelEqualizer50HzValue = new System.Windows.Forms.Label();
            this.labelEqualizer2kHzValue = new System.Windows.Forms.Label();
            this.labelEqualizer4kHzValue = new System.Windows.Forms.Label();
            this.labelEqualizer6kHzValue = new System.Windows.Forms.Label();
            this.labelEqualizer8kHzValue = new System.Windows.Forms.Label();
            this.labelEqualizer10kHzValue = new System.Windows.Forms.Label();
            this.labelEqualizer12kHzValue = new System.Windows.Forms.Label();
            this.labelEqualizer14kHzValue = new System.Windows.Forms.Label();
            this.labelEqualizer16kHzValue = new System.Windows.Forms.Label();
            this.labelEqualizer18kHzInfo = new System.Windows.Forms.Label();
            this.labelEqualizer16kHzInfo = new System.Windows.Forms.Label();
            this.labelEqualizer14kHzInfo = new System.Windows.Forms.Label();
            this.labelEqualizer12kHzInfo = new System.Windows.Forms.Label();
            this.labelEqualizer10kHzInfo = new System.Windows.Forms.Label();
            this.labelEqualizer8kHzInfo = new System.Windows.Forms.Label();
            this.labelEqualizer6kHzInfo = new System.Windows.Forms.Label();
            this.labelEqualizer4kHzInfo = new System.Windows.Forms.Label();
            this.labelEqualizer2kHzInfo = new System.Windows.Forms.Label();
            this.trackBarEqualizer18kHz = new System.Windows.Forms.TrackBar();
            this.trackBarEqualizer16kHz = new System.Windows.Forms.TrackBar();
            this.trackBarEqualizer14kHz = new System.Windows.Forms.TrackBar();
            this.trackBarEqualizer12kHz = new System.Windows.Forms.TrackBar();
            this.trackBarEqualizer10kHz = new System.Windows.Forms.TrackBar();
            this.trackBarEqualizer8kHz = new System.Windows.Forms.TrackBar();
            this.trackBarEqualizer6kHz = new System.Windows.Forms.TrackBar();
            this.trackBarEqualizer4kHz = new System.Windows.Forms.TrackBar();
            this.trackBarEqualizer2kHz = new System.Windows.Forms.TrackBar();
            this.trackBarEqualizer50Hz = new System.Windows.Forms.TrackBar();
            this.labelEqualizer50HzInfo = new System.Windows.Forms.Label();
            this.panelEqualizerPresetName = new System.Windows.Forms.Panel();
            this.labelEqualizerPresetName = new System.Windows.Forms.Label();
            this.tLPanelEqualizerStatusbar = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEqualizerSaveto = new System.Windows.Forms.Button();
            this.buttonEqualizerReset = new System.Windows.Forms.Button();
            this.buttonEqualizerSave = new System.Windows.Forms.Button();
            this.panelEqualizerToolbar = new System.Windows.Forms.Panel();
            this.treeViewEqualizerMenu = new System.Windows.Forms.TreeView();
            this.imageListEqualizerMenu = new System.Windows.Forms.ImageList(this.components);
            this.tLPanelEqualizerTools = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEqualizerPresetRemove = new System.Windows.Forms.Button();
            this.buttonEqualizerPresetAdd = new System.Windows.Forms.Button();
            this.labelEqualizerInfo = new System.Windows.Forms.Label();
            this.panelEqualizerTitleBar = new System.Windows.Forms.Panel();
            this.labelEqualizerTitle = new System.Windows.Forms.Label();
            this.panelExplorer = new System.Windows.Forms.Panel();
            this.listViewExplorerFiles = new System.Windows.Forms.ListView();
            this.imageListFiles = new System.Windows.Forms.ImageList(this.components);
            this.panelExplorerToolbar = new System.Windows.Forms.Panel();
            this.treeViewExplorerDirectories = new System.Windows.Forms.TreeView();
            this.comboBoxExplorerDisks = new System.Windows.Forms.ComboBox();
            this.panelExplorerMenubar = new System.Windows.Forms.Panel();
            this.tLPanelExplorerOptions = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExplorerFilter = new System.Windows.Forms.Button();
            this.panelExplorerFilter = new System.Windows.Forms.Panel();
            this.comboBoxExplorerFilter = new System.Windows.Forms.ComboBox();
            this.tLPanelExplorerNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.panelExplorerSearch = new System.Windows.Forms.Panel();
            this.textBoxExplorerSearch = new System.Windows.Forms.TextBox();
            this.buttonExplorerBack = new System.Windows.Forms.Button();
            this.buttonExplorerNext = new System.Windows.Forms.Button();
            this.buttonExplorerGo = new System.Windows.Forms.Button();
            this.buttonExplorerSearch = new System.Windows.Forms.Button();
            this.panelExplorerPath = new System.Windows.Forms.Panel();
            this.textBoxExplorerPath = new System.Windows.Forms.TextBox();
            this.labelExplorerTitle = new System.Windows.Forms.Label();
            this.tLPanelExplorerStatusbar = new System.Windows.Forms.TableLayoutPanel();
            this.trackBarExplorerView = new System.Windows.Forms.TrackBar();
            this.panelKaraoke = new System.Windows.Forms.Panel();
            this.panelKaraokeText = new System.Windows.Forms.Panel();
            this.listViewKaraoke = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelKaraokeName = new System.Windows.Forms.Label();
            this.panelKaraokeMenubar = new System.Windows.Forms.Panel();
            this.fLPanelKaraokeSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxKaraokeEnable = new System.Windows.Forms.CheckBox();
            this.tLPanelKaraokeMenu = new System.Windows.Forms.TableLayoutPanel();
            this.buttonKaraokeRemoveLine = new System.Windows.Forms.Button();
            this.buttonKaraokeAddLine = new System.Windows.Forms.Button();
            this.buttonKaraokeSaveAs = new System.Windows.Forms.Button();
            this.buttonKaraokeSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonKaraokeNew = new System.Windows.Forms.Button();
            this.labelKaraokeTime = new System.Windows.Forms.Label();
            this.labelKaraokeTitle = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAnthraX = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl.SuspendLayout();
            this.tLPanelInfo.SuspendLayout();
            this.panelVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalystVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.panelSlider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalystSlider)).BeginInit();
            this.fLPanelMenu.SuspendLayout();
            this.panelVis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalystVis)).BeginInit();
            this.tlPanelPlayList.SuspendLayout();
            this.fLPanelPlayListMenu.SuspendLayout();
            this.panelClient.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.fLPanelSettingsInfo.SuspendLayout();
            this.fLPanelSettingsGeneral.SuspendLayout();
            this.fLPanelSettingsPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlayerInfo)).BeginInit();
            this.fLPanelSettingsSound.SuspendLayout();
            this.fLPanelSoundDevices.SuspendLayout();
            this.fLPanelSettingsTheme.SuspendLayout();
            this.fLPanelThemeCustomColor.SuspendLayout();
            this.fLPanelThemeWallpaperCustomColor.SuspendLayout();
            this.fLPanelThemeWallpaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThemeWallpaper01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThemeWallpaper02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThemeWallpaper03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThemeWallpaper04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThemeWallpaper05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThemeWallpaper06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThemeTransparency)).BeginInit();
            this.fLPanelSettingsVisualisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVisualisationSize)).BeginInit();
            this.fLPanelVisualisationCustomColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVisualisationColorSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVisualisationColorRainbow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVisualisationTransparency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVisualisationSensitivity)).BeginInit();
            this.tLPanelSettingsMenu.SuspendLayout();
            this.panelLibrary.SuspendLayout();
            this.panelLibraryFiles.SuspendLayout();
            this.panelLibraryToolbar.SuspendLayout();
            this.tLPanelLibraryTools.SuspendLayout();
            this.panelLibraryMenubar.SuspendLayout();
            this.tLPanelLibraryMenu.SuspendLayout();
            this.panelLibrarySort.SuspendLayout();
            this.panelEqualizer.SuspendLayout();
            this.fLPanelEffects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsAmplification)).BeginInit();
            this.panelEffectsAmplification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsSaturationDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsStereoEnhancerWide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsStereoEnhancerDryWet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsIIRDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsIIRDelayDryWet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsIIRDelayFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsEcho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsReverb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsChorus)).BeginInit();
            this.tLPanelEqualizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer18kHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer16kHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer14kHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer12kHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer10kHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer8kHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer6kHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer4kHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer2kHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer50Hz)).BeginInit();
            this.panelEqualizerPresetName.SuspendLayout();
            this.tLPanelEqualizerStatusbar.SuspendLayout();
            this.panelEqualizerToolbar.SuspendLayout();
            this.tLPanelEqualizerTools.SuspendLayout();
            this.panelEqualizerTitleBar.SuspendLayout();
            this.panelExplorer.SuspendLayout();
            this.panelExplorerToolbar.SuspendLayout();
            this.panelExplorerMenubar.SuspendLayout();
            this.tLPanelExplorerOptions.SuspendLayout();
            this.panelExplorerFilter.SuspendLayout();
            this.tLPanelExplorerNavigation.SuspendLayout();
            this.panelExplorerSearch.SuspendLayout();
            this.panelExplorerPath.SuspendLayout();
            this.tLPanelExplorerStatusbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExplorerView)).BeginInit();
            this.panelKaraoke.SuspendLayout();
            this.panelKaraokeText.SuspendLayout();
            this.panelKaraokeMenubar.SuspendLayout();
            this.fLPanelKaraokeSettings.SuspendLayout();
            this.tLPanelKaraokeMenu.SuspendLayout();
            this.notifyIconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.AllowDrop = true;
            this.panelControl.BackColor = System.Drawing.Color.Black;
            this.panelControl.Controls.Add(this.buttonRepeat);
            this.panelControl.Controls.Add(this.buttonPrevious);
            this.panelControl.Controls.Add(this.buttonPlay);
            this.panelControl.Controls.Add(this.tLPanelInfo);
            this.panelControl.Controls.Add(this.buttonForward);
            this.panelControl.Controls.Add(this.buttonStop);
            this.panelControl.Controls.Add(this.panelVolume);
            this.panelControl.Controls.Add(this.buttonVolume);
            this.panelControl.Controls.Add(this.buttonShuffle);
            this.panelControl.Controls.Add(this.pictureBoxCover);
            this.panelControl.Controls.Add(this.panelSlider);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 457);
            this.panelControl.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(884, 104);
            this.panelControl.TabIndex = 0;
            this.panelControl.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragDrop);
            this.panelControl.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragEnter);
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRepeat.BackColor = System.Drawing.Color.Transparent;
            this.buttonRepeat.FlatAppearance.BorderSize = 0;
            this.buttonRepeat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRepeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRepeat.Image = global::AnthraX.IconsControl._32_White_Repeat;
            this.buttonRepeat.Location = new System.Drawing.Point(416, 40);
            this.buttonRepeat.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRepeat.Name = "buttonRepeat";
            this.buttonRepeat.Size = new System.Drawing.Size(48, 48);
            this.buttonRepeat.TabIndex = 11;
            this.buttonRepeat.UseVisualStyleBackColor = false;
            this.buttonRepeat.Click += new System.EventHandler(this.buttonRepeat_Click);
            this.buttonRepeat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonControlPress);
            this.buttonRepeat.MouseEnter += new System.EventHandler(this.ButtonControlHover);
            this.buttonRepeat.MouseLeave += new System.EventHandler(this.ButtonControlLeave);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrevious.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Image = global::AnthraX.IconsControl._32_White_Backward;
            this.buttonPrevious.Location = new System.Drawing.Point(472, 40);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(48, 48);
            this.buttonPrevious.TabIndex = 10;
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            this.buttonPrevious.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonControlPress);
            this.buttonPrevious.MouseEnter += new System.EventHandler(this.ButtonControlHover);
            this.buttonPrevious.MouseLeave += new System.EventHandler(this.ButtonControlLeave);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Image = global::AnthraX.IconsControl._32_White_Play;
            this.buttonPlay.Location = new System.Drawing.Point(520, 40);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(48, 48);
            this.buttonPlay.TabIndex = 9;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            this.buttonPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonControlPress);
            this.buttonPlay.MouseEnter += new System.EventHandler(this.ButtonControlHover);
            this.buttonPlay.MouseLeave += new System.EventHandler(this.ButtonControlLeave);
            // 
            // tLPanelInfo
            // 
            this.tLPanelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLPanelInfo.BackColor = System.Drawing.Color.Transparent;
            this.tLPanelInfo.ColumnCount = 1;
            this.tLPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelInfo.Controls.Add(this.labelAlbum, 0, 2);
            this.tLPanelInfo.Controls.Add(this.labelArtist, 0, 1);
            this.tLPanelInfo.Controls.Add(this.labelTitle, 0, 0);
            this.tLPanelInfo.Location = new System.Drawing.Point(76, 32);
            this.tLPanelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tLPanelInfo.Name = "tLPanelInfo";
            this.tLPanelInfo.RowCount = 3;
            this.tLPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85715F));
            this.tLPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tLPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tLPanelInfo.Size = new System.Drawing.Size(284, 64);
            this.tLPanelInfo.TabIndex = 3;
            // 
            // labelAlbum
            // 
            this.labelAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAlbum.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAlbum.ForeColor = System.Drawing.Color.White;
            this.labelAlbum.Location = new System.Drawing.Point(3, 45);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(278, 19);
            this.labelAlbum.TabIndex = 2;
            this.labelAlbum.Text = "No Album";
            this.labelAlbum.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelArtist
            // 
            this.labelArtist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelArtist.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelArtist.ForeColor = System.Drawing.Color.White;
            this.labelArtist.Location = new System.Drawing.Point(3, 27);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(278, 18);
            this.labelArtist.TabIndex = 1;
            this.labelArtist.Text = "No Artist";
            this.labelArtist.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(278, 27);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "No Name";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonForward
            // 
            this.buttonForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonForward.BackColor = System.Drawing.Color.Transparent;
            this.buttonForward.FlatAppearance.BorderSize = 0;
            this.buttonForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForward.Image = global::AnthraX.IconsControl._32_White_Forward;
            this.buttonForward.Location = new System.Drawing.Point(568, 40);
            this.buttonForward.Margin = new System.Windows.Forms.Padding(0);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(48, 48);
            this.buttonForward.TabIndex = 8;
            this.buttonForward.UseVisualStyleBackColor = false;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            this.buttonForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonControlPress);
            this.buttonForward.MouseEnter += new System.EventHandler(this.ButtonControlHover);
            this.buttonForward.MouseLeave += new System.EventHandler(this.ButtonControlLeave);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Image = global::AnthraX.IconsControl._32_White_Stop;
            this.buttonStop.Location = new System.Drawing.Point(616, 40);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(48, 48);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            this.buttonStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonControlPress);
            this.buttonStop.MouseEnter += new System.EventHandler(this.ButtonControlHover);
            this.buttonStop.MouseLeave += new System.EventHandler(this.ButtonControlLeave);
            // 
            // panelVolume
            // 
            this.panelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVolume.BackColor = System.Drawing.Color.Transparent;
            this.panelVolume.Controls.Add(this.pictureBoxCatalystVolume);
            this.panelVolume.Location = new System.Drawing.Point(732, 52);
            this.panelVolume.Name = "panelVolume";
            this.panelVolume.Size = new System.Drawing.Size(128, 24);
            this.panelVolume.TabIndex = 6;
            this.panelVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelVolume_MouseDown);
            this.panelVolume.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelVolume_MouseMove);
            this.panelVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelVolume_MouseUp);
            // 
            // pictureBoxCatalystVolume
            // 
            this.pictureBoxCatalystVolume.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCatalystVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCatalystVolume.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCatalystVolume.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxCatalystVolume.Name = "pictureBoxCatalystVolume";
            this.pictureBoxCatalystVolume.Size = new System.Drawing.Size(128, 24);
            this.pictureBoxCatalystVolume.TabIndex = 3;
            this.pictureBoxCatalystVolume.TabStop = false;
            this.pictureBoxCatalystVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelVolume_MouseDown);
            this.pictureBoxCatalystVolume.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelVolume_MouseMove);
            this.pictureBoxCatalystVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelVolume_MouseUp);
            // 
            // buttonVolume
            // 
            this.buttonVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVolume.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolume.FlatAppearance.BorderSize = 0;
            this.buttonVolume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonVolume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolume.Image = global::AnthraX.IconsControl._32_White_Volume;
            this.buttonVolume.Location = new System.Drawing.Point(672, 40);
            this.buttonVolume.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVolume.Name = "buttonVolume";
            this.buttonVolume.Size = new System.Drawing.Size(48, 48);
            this.buttonVolume.TabIndex = 4;
            this.buttonVolume.UseVisualStyleBackColor = false;
            this.buttonVolume.Click += new System.EventHandler(this.buttonVolume_Click);
            this.buttonVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonControlPress);
            this.buttonVolume.MouseEnter += new System.EventHandler(this.ButtonControlHover);
            this.buttonVolume.MouseLeave += new System.EventHandler(this.ButtonControlLeave);
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShuffle.BackColor = System.Drawing.Color.Transparent;
            this.buttonShuffle.FlatAppearance.BorderSize = 0;
            this.buttonShuffle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonShuffle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShuffle.Image = global::AnthraX.IconsControl._32_White_Shuffle;
            this.buttonShuffle.Location = new System.Drawing.Point(368, 40);
            this.buttonShuffle.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(48, 48);
            this.buttonShuffle.TabIndex = 3;
            this.buttonShuffle.UseVisualStyleBackColor = false;
            this.buttonShuffle.Click += new System.EventHandler(this.buttonShuffle_Click);
            this.buttonShuffle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonControlPress);
            this.buttonShuffle.MouseEnter += new System.EventHandler(this.ButtonControlHover);
            this.buttonShuffle.MouseLeave += new System.EventHandler(this.ButtonControlLeave);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxCover.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCover.Image = global::AnthraX.IconsControl._64_White_Stereo;
            this.pictureBoxCover.Location = new System.Drawing.Point(8, 32);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 1;
            this.pictureBoxCover.TabStop = false;
            // 
            // panelSlider
            // 
            this.panelSlider.AllowDrop = true;
            this.panelSlider.BackColor = System.Drawing.Color.Black;
            this.panelSlider.Controls.Add(this.pictureBoxCatalystSlider);
            this.panelSlider.Controls.Add(this.labelTimeLeft);
            this.panelSlider.Controls.Add(this.labelTime);
            this.panelSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSlider.Location = new System.Drawing.Point(0, 0);
            this.panelSlider.Margin = new System.Windows.Forms.Padding(0);
            this.panelSlider.Name = "panelSlider";
            this.panelSlider.Size = new System.Drawing.Size(884, 24);
            this.panelSlider.TabIndex = 0;
            this.panelSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlider_MouseDown);
            this.panelSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlider_MouseMove);
            this.panelSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlider_MouseUp);
            // 
            // pictureBoxCatalystSlider
            // 
            this.pictureBoxCatalystSlider.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCatalystSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCatalystSlider.Location = new System.Drawing.Point(96, 0);
            this.pictureBoxCatalystSlider.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxCatalystSlider.Name = "pictureBoxCatalystSlider";
            this.pictureBoxCatalystSlider.Size = new System.Drawing.Size(692, 24);
            this.pictureBoxCatalystSlider.TabIndex = 2;
            this.pictureBoxCatalystSlider.TabStop = false;
            this.pictureBoxCatalystSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlider_MouseDown);
            this.pictureBoxCatalystSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlider_MouseMove);
            this.pictureBoxCatalystSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlider_MouseUp);
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTimeLeft.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimeLeft.ForeColor = System.Drawing.Color.White;
            this.labelTimeLeft.Location = new System.Drawing.Point(788, 0);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(96, 24);
            this.labelTimeLeft.TabIndex = 1;
            this.labelTimeLeft.Text = "00:00:00";
            this.labelTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(0, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(96, 24);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fLPanelMenu
            // 
            this.fLPanelMenu.AllowDrop = true;
            this.fLPanelMenu.BackColor = System.Drawing.Color.Black;
            this.fLPanelMenu.Controls.Add(this.buttonHome);
            this.fLPanelMenu.Controls.Add(this.buttonLibrary);
            this.fLPanelMenu.Controls.Add(this.buttonFileExplorer);
            this.fLPanelMenu.Controls.Add(this.buttonKaraoke);
            this.fLPanelMenu.Controls.Add(this.buttonEqualizer);
            this.fLPanelMenu.Controls.Add(this.buttonSettings);
            this.fLPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.fLPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.fLPanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.fLPanelMenu.Name = "fLPanelMenu";
            this.fLPanelMenu.Size = new System.Drawing.Size(56, 457);
            this.fLPanelMenu.TabIndex = 0;
            this.fLPanelMenu.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragDrop);
            this.fLPanelMenu.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragEnter);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.ForeColor = System.Drawing.Color.Transparent;
            this.buttonHome.Image = global::AnthraX.IconsMenu._32_White_Main;
            this.buttonHome.Location = new System.Drawing.Point(4, 4);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(48, 48);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            this.buttonHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMenuPress);
            this.buttonHome.MouseEnter += new System.EventHandler(this.ButtonMenuHover);
            this.buttonHome.MouseLeave += new System.EventHandler(this.ButtonMenuLeave);
            // 
            // buttonLibrary
            // 
            this.buttonLibrary.BackColor = System.Drawing.Color.Transparent;
            this.buttonLibrary.FlatAppearance.BorderSize = 0;
            this.buttonLibrary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibrary.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLibrary.Image = global::AnthraX.IconsMenu._32_White_Library;
            this.buttonLibrary.Location = new System.Drawing.Point(4, 60);
            this.buttonLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLibrary.Name = "buttonLibrary";
            this.buttonLibrary.Size = new System.Drawing.Size(48, 48);
            this.buttonLibrary.TabIndex = 1;
            this.buttonLibrary.UseVisualStyleBackColor = false;
            this.buttonLibrary.Click += new System.EventHandler(this.buttonLibrary_Click);
            this.buttonLibrary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMenuPress);
            this.buttonLibrary.MouseEnter += new System.EventHandler(this.ButtonMenuHover);
            this.buttonLibrary.MouseLeave += new System.EventHandler(this.ButtonMenuLeave);
            // 
            // buttonFileExplorer
            // 
            this.buttonFileExplorer.BackColor = System.Drawing.Color.Transparent;
            this.buttonFileExplorer.FlatAppearance.BorderSize = 0;
            this.buttonFileExplorer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonFileExplorer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonFileExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileExplorer.ForeColor = System.Drawing.Color.Transparent;
            this.buttonFileExplorer.Image = global::AnthraX.IconsMenu._32_White_Explorer;
            this.buttonFileExplorer.Location = new System.Drawing.Point(4, 116);
            this.buttonFileExplorer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFileExplorer.Name = "buttonFileExplorer";
            this.buttonFileExplorer.Size = new System.Drawing.Size(48, 48);
            this.buttonFileExplorer.TabIndex = 2;
            this.buttonFileExplorer.UseVisualStyleBackColor = false;
            this.buttonFileExplorer.Click += new System.EventHandler(this.buttonFileExplorer_Click);
            this.buttonFileExplorer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMenuPress);
            this.buttonFileExplorer.MouseEnter += new System.EventHandler(this.ButtonMenuHover);
            this.buttonFileExplorer.MouseLeave += new System.EventHandler(this.ButtonMenuLeave);
            // 
            // buttonKaraoke
            // 
            this.buttonKaraoke.BackColor = System.Drawing.Color.Transparent;
            this.buttonKaraoke.FlatAppearance.BorderSize = 0;
            this.buttonKaraoke.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonKaraoke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonKaraoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKaraoke.ForeColor = System.Drawing.Color.Transparent;
            this.buttonKaraoke.Image = global::AnthraX.IconsMenu._32_White_Karaoke;
            this.buttonKaraoke.Location = new System.Drawing.Point(4, 172);
            this.buttonKaraoke.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKaraoke.Name = "buttonKaraoke";
            this.buttonKaraoke.Size = new System.Drawing.Size(48, 48);
            this.buttonKaraoke.TabIndex = 5;
            this.buttonKaraoke.UseVisualStyleBackColor = false;
            this.buttonKaraoke.Click += new System.EventHandler(this.buttonKaraoke_Click);
            this.buttonKaraoke.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMenuPress);
            this.buttonKaraoke.MouseEnter += new System.EventHandler(this.ButtonMenuHover);
            this.buttonKaraoke.MouseLeave += new System.EventHandler(this.ButtonMenuLeave);
            // 
            // buttonEqualizer
            // 
            this.buttonEqualizer.BackColor = System.Drawing.Color.Transparent;
            this.buttonEqualizer.FlatAppearance.BorderSize = 0;
            this.buttonEqualizer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEqualizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEqualizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqualizer.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEqualizer.Image = global::AnthraX.IconsMenu._32_White_Equalizer;
            this.buttonEqualizer.Location = new System.Drawing.Point(4, 228);
            this.buttonEqualizer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEqualizer.Name = "buttonEqualizer";
            this.buttonEqualizer.Size = new System.Drawing.Size(48, 48);
            this.buttonEqualizer.TabIndex = 3;
            this.buttonEqualizer.UseVisualStyleBackColor = false;
            this.buttonEqualizer.Click += new System.EventHandler(this.buttonEqualizer_Click);
            this.buttonEqualizer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMenuPress);
            this.buttonEqualizer.MouseEnter += new System.EventHandler(this.ButtonMenuHover);
            this.buttonEqualizer.MouseLeave += new System.EventHandler(this.ButtonMenuLeave);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSettings.Image = global::AnthraX.IconsMenu._32_White_Settings;
            this.buttonSettings.Location = new System.Drawing.Point(4, 284);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(48, 48);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            this.buttonSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMenuPress);
            this.buttonSettings.MouseEnter += new System.EventHandler(this.ButtonMenuHover);
            this.buttonSettings.MouseLeave += new System.EventHandler(this.ButtonMenuLeave);
            // 
            // panelVis
            // 
            this.panelVis.AllowDrop = true;
            this.panelVis.BackColor = System.Drawing.Color.Black;
            this.panelVis.Controls.Add(this.pictureBoxCatalystVis);
            this.panelVis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVis.Location = new System.Drawing.Point(56, 0);
            this.panelVis.Margin = new System.Windows.Forms.Padding(0);
            this.panelVis.Name = "panelVis";
            this.panelVis.Size = new System.Drawing.Size(828, 457);
            this.panelVis.TabIndex = 1;
            this.panelVis.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragDrop);
            this.panelVis.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragEnter);
            // 
            // pictureBoxCatalystVis
            // 
            this.pictureBoxCatalystVis.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCatalystVis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCatalystVis.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCatalystVis.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxCatalystVis.Name = "pictureBoxCatalystVis";
            this.pictureBoxCatalystVis.Size = new System.Drawing.Size(828, 457);
            this.pictureBoxCatalystVis.TabIndex = 1;
            this.pictureBoxCatalystVis.TabStop = false;
            // 
            // tlPanelPlayList
            // 
            this.tlPanelPlayList.AllowDrop = true;
            this.tlPanelPlayList.BackColor = System.Drawing.Color.Black;
            this.tlPanelPlayList.ColumnCount = 2;
            this.tlPanelPlayList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelPlayList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tlPanelPlayList.Controls.Add(this.panelPlayListSplit, 1, 0);
            this.tlPanelPlayList.Controls.Add(this.labelPlayListTitle, 0, 1);
            this.tlPanelPlayList.Controls.Add(this.fLPanelPlayListMenu, 0, 3);
            this.tlPanelPlayList.Controls.Add(this.listViewNowPlaying, 0, 4);
            this.tlPanelPlayList.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlPanelPlayList.Location = new System.Drawing.Point(56, 0);
            this.tlPanelPlayList.Margin = new System.Windows.Forms.Padding(0);
            this.tlPanelPlayList.Name = "tlPanelPlayList";
            this.tlPanelPlayList.RowCount = 5;
            this.tlPanelPlayList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlPanelPlayList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlPanelPlayList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlPanelPlayList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlPanelPlayList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanelPlayList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPanelPlayList.Size = new System.Drawing.Size(1, 457);
            this.tlPanelPlayList.TabIndex = 0;
            this.tlPanelPlayList.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragDrop);
            this.tlPanelPlayList.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragEnter);
            // 
            // panelPlayListSplit
            // 
            this.panelPlayListSplit.BackColor = System.Drawing.Color.Transparent;
            this.panelPlayListSplit.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panelPlayListSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlayListSplit.Location = new System.Drawing.Point(-3, 0);
            this.panelPlayListSplit.Margin = new System.Windows.Forms.Padding(0);
            this.panelPlayListSplit.Name = "panelPlayListSplit";
            this.tlPanelPlayList.SetRowSpan(this.panelPlayListSplit, 5);
            this.panelPlayListSplit.Size = new System.Drawing.Size(4, 457);
            this.panelPlayListSplit.TabIndex = 1;
            this.panelPlayListSplit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPlayListSplit_MouseDown);
            this.panelPlayListSplit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPlayListSplit_MouseMove);
            this.panelPlayListSplit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPlayListSplit_MouseUp);
            // 
            // labelPlayListTitle
            // 
            this.labelPlayListTitle.AutoSize = true;
            this.labelPlayListTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayListTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPlayListTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayListTitle.ForeColor = System.Drawing.Color.White;
            this.labelPlayListTitle.Location = new System.Drawing.Point(3, 16);
            this.labelPlayListTitle.Name = "labelPlayListTitle";
            this.labelPlayListTitle.Size = new System.Drawing.Size(1, 48);
            this.labelPlayListTitle.TabIndex = 2;
            this.labelPlayListTitle.Text = "Now Playing";
            this.labelPlayListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fLPanelPlayListMenu
            // 
            this.fLPanelPlayListMenu.BackColor = System.Drawing.Color.Transparent;
            this.fLPanelPlayListMenu.Controls.Add(this.panelPlayListMenuOffset);
            this.fLPanelPlayListMenu.Controls.Add(this.buttonPlayListOpen);
            this.fLPanelPlayListMenu.Controls.Add(this.buttonPlayListSave);
            this.fLPanelPlayListMenu.Controls.Add(this.buttonPlayListDelete);
            this.fLPanelPlayListMenu.Controls.Add(this.buttonPlayListMoveUp);
            this.fLPanelPlayListMenu.Controls.Add(this.buttonPlayListMoveDown);
            this.fLPanelPlayListMenu.Controls.Add(this.buttonPlayListSort);
            this.fLPanelPlayListMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPanelPlayListMenu.Location = new System.Drawing.Point(0, 80);
            this.fLPanelPlayListMenu.Margin = new System.Windows.Forms.Padding(0);
            this.fLPanelPlayListMenu.Name = "fLPanelPlayListMenu";
            this.fLPanelPlayListMenu.Size = new System.Drawing.Size(1, 48);
            this.fLPanelPlayListMenu.TabIndex = 3;
            // 
            // panelPlayListMenuOffset
            // 
            this.panelPlayListMenuOffset.Location = new System.Drawing.Point(0, 4);
            this.panelPlayListMenuOffset.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.panelPlayListMenuOffset.Name = "panelPlayListMenuOffset";
            this.panelPlayListMenuOffset.Size = new System.Drawing.Size(0, 40);
            this.panelPlayListMenuOffset.TabIndex = 6;
            // 
            // buttonPlayListOpen
            // 
            this.buttonPlayListOpen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPlayListOpen.FlatAppearance.BorderSize = 0;
            this.buttonPlayListOpen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayListOpen.Image = global::AnthraX.IconsNavigation._32_Open;
            this.buttonPlayListOpen.Location = new System.Drawing.Point(4, 48);
            this.buttonPlayListOpen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlayListOpen.Name = "buttonPlayListOpen";
            this.buttonPlayListOpen.Size = new System.Drawing.Size(40, 40);
            this.buttonPlayListOpen.TabIndex = 0;
            this.buttonPlayListOpen.UseVisualStyleBackColor = true;
            this.buttonPlayListOpen.Click += new System.EventHandler(this.buttonPlayListOpen_Click);
            this.buttonPlayListOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPLayListPress);
            this.buttonPlayListOpen.MouseEnter += new System.EventHandler(this.ButtonPlayListHover);
            this.buttonPlayListOpen.MouseLeave += new System.EventHandler(this.ButtonPlayListLeave);
            // 
            // buttonPlayListSave
            // 
            this.buttonPlayListSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPlayListSave.FlatAppearance.BorderSize = 0;
            this.buttonPlayListSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayListSave.Image = global::AnthraX.IconsNavigation._32_Save;
            this.buttonPlayListSave.Location = new System.Drawing.Point(4, 96);
            this.buttonPlayListSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlayListSave.Name = "buttonPlayListSave";
            this.buttonPlayListSave.Size = new System.Drawing.Size(40, 40);
            this.buttonPlayListSave.TabIndex = 1;
            this.buttonPlayListSave.UseVisualStyleBackColor = true;
            this.buttonPlayListSave.Click += new System.EventHandler(this.buttonPlayListSave_Click);
            this.buttonPlayListSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPLayListPress);
            this.buttonPlayListSave.MouseEnter += new System.EventHandler(this.ButtonPlayListHover);
            this.buttonPlayListSave.MouseLeave += new System.EventHandler(this.ButtonPlayListLeave);
            // 
            // buttonPlayListDelete
            // 
            this.buttonPlayListDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPlayListDelete.FlatAppearance.BorderSize = 0;
            this.buttonPlayListDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayListDelete.Image = global::AnthraX.IconsNavigation._32_Delete;
            this.buttonPlayListDelete.Location = new System.Drawing.Point(4, 144);
            this.buttonPlayListDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlayListDelete.Name = "buttonPlayListDelete";
            this.buttonPlayListDelete.Size = new System.Drawing.Size(40, 40);
            this.buttonPlayListDelete.TabIndex = 2;
            this.buttonPlayListDelete.UseVisualStyleBackColor = true;
            this.buttonPlayListDelete.Click += new System.EventHandler(this.buttonPlayListClear_Click);
            this.buttonPlayListDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPLayListPress);
            this.buttonPlayListDelete.MouseEnter += new System.EventHandler(this.ButtonPlayListHover);
            this.buttonPlayListDelete.MouseLeave += new System.EventHandler(this.ButtonPlayListLeave);
            // 
            // buttonPlayListMoveUp
            // 
            this.buttonPlayListMoveUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPlayListMoveUp.FlatAppearance.BorderSize = 0;
            this.buttonPlayListMoveUp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListMoveUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListMoveUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayListMoveUp.Image = global::AnthraX.IconsNavigation._32_ArrowUp;
            this.buttonPlayListMoveUp.Location = new System.Drawing.Point(4, 192);
            this.buttonPlayListMoveUp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlayListMoveUp.Name = "buttonPlayListMoveUp";
            this.buttonPlayListMoveUp.Size = new System.Drawing.Size(40, 40);
            this.buttonPlayListMoveUp.TabIndex = 3;
            this.buttonPlayListMoveUp.UseVisualStyleBackColor = true;
            this.buttonPlayListMoveUp.Click += new System.EventHandler(this.buttonPlayListMoveUp_Click);
            this.buttonPlayListMoveUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPLayListPress);
            this.buttonPlayListMoveUp.MouseEnter += new System.EventHandler(this.ButtonPlayListHover);
            this.buttonPlayListMoveUp.MouseLeave += new System.EventHandler(this.ButtonPlayListLeave);
            // 
            // buttonPlayListMoveDown
            // 
            this.buttonPlayListMoveDown.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPlayListMoveDown.FlatAppearance.BorderSize = 0;
            this.buttonPlayListMoveDown.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListMoveDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListMoveDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayListMoveDown.Image = global::AnthraX.IconsNavigation._32_ArrowDown;
            this.buttonPlayListMoveDown.Location = new System.Drawing.Point(4, 240);
            this.buttonPlayListMoveDown.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlayListMoveDown.Name = "buttonPlayListMoveDown";
            this.buttonPlayListMoveDown.Size = new System.Drawing.Size(40, 40);
            this.buttonPlayListMoveDown.TabIndex = 4;
            this.buttonPlayListMoveDown.UseVisualStyleBackColor = true;
            this.buttonPlayListMoveDown.Click += new System.EventHandler(this.buttonPlayListMoveDown_Click);
            this.buttonPlayListMoveDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPLayListPress);
            this.buttonPlayListMoveDown.MouseEnter += new System.EventHandler(this.ButtonPlayListHover);
            this.buttonPlayListMoveDown.MouseLeave += new System.EventHandler(this.ButtonPlayListLeave);
            // 
            // buttonPlayListSort
            // 
            this.buttonPlayListSort.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPlayListSort.FlatAppearance.BorderSize = 0;
            this.buttonPlayListSort.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListSort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListSort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayListSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayListSort.Image = global::AnthraX.IconsNavigation._32_Sort;
            this.buttonPlayListSort.Location = new System.Drawing.Point(4, 288);
            this.buttonPlayListSort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlayListSort.Name = "buttonPlayListSort";
            this.buttonPlayListSort.Size = new System.Drawing.Size(40, 40);
            this.buttonPlayListSort.TabIndex = 5;
            this.buttonPlayListSort.UseVisualStyleBackColor = true;
            this.buttonPlayListSort.Click += new System.EventHandler(this.buttonPlayListSort_Click);
            this.buttonPlayListSort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPLayListPress);
            this.buttonPlayListSort.MouseEnter += new System.EventHandler(this.ButtonPlayListHover);
            this.buttonPlayListSort.MouseLeave += new System.EventHandler(this.ButtonPlayListLeave);
            // 
            // listViewNowPlaying
            // 
            this.listViewNowPlaying.AllowDrop = true;
            this.listViewNowPlaying.BackColor = System.Drawing.Color.Black;
            this.listViewNowPlaying.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewNowPlaying.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewNowPlaying.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewNowPlaying.ForeColor = System.Drawing.Color.White;
            this.listViewNowPlaying.GridLines = true;
            this.listViewNowPlaying.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listViewNowPlaying.LargeImageList = this.imageListNowPlaying;
            this.listViewNowPlaying.Location = new System.Drawing.Point(0, 128);
            this.listViewNowPlaying.Margin = new System.Windows.Forms.Padding(0);
            this.listViewNowPlaying.Name = "listViewNowPlaying";
            this.listViewNowPlaying.Size = new System.Drawing.Size(1, 329);
            this.listViewNowPlaying.TabIndex = 4;
            this.listViewNowPlaying.TileSize = new System.Drawing.Size(252, 40);
            this.listViewNowPlaying.UseCompatibleStateImageBehavior = false;
            this.listViewNowPlaying.View = System.Windows.Forms.View.Tile;
            this.listViewNowPlaying.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragDrop);
            this.listViewNowPlaying.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragEnter);
            this.listViewNowPlaying.DoubleClick += new System.EventHandler(this.listViewNowPlaying_DoubleClick);
            this.listViewNowPlaying.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewNowPlaying_MouseDown);
            this.listViewNowPlaying.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewNowPlaying_MouseUp);
            // 
            // imageListNowPlaying
            // 
            this.imageListNowPlaying.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListNowPlaying.ImageStream")));
            this.imageListNowPlaying.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListNowPlaying.Images.SetKeyName(0, "32_White_Play.png");
            this.imageListNowPlaying.Images.SetKeyName(1, "32_White_File.png");
            this.imageListNowPlaying.Images.SetKeyName(2, "32_White_Stereo.png");
            this.imageListNowPlaying.Images.SetKeyName(3, "32_White_Picture.png");
            this.imageListNowPlaying.Images.SetKeyName(4, "32_White_Video.png");
            this.imageListNowPlaying.Images.SetKeyName(5, "32_White_Document.png");
            this.imageListNowPlaying.Images.SetKeyName(6, "32_Black_Play.png");
            this.imageListNowPlaying.Images.SetKeyName(7, "32_Black_File.png");
            this.imageListNowPlaying.Images.SetKeyName(8, "32_Black_Stereo.png");
            this.imageListNowPlaying.Images.SetKeyName(9, "32_Black_Picture.png");
            this.imageListNowPlaying.Images.SetKeyName(10, "32_Black_Video.png");
            this.imageListNowPlaying.Images.SetKeyName(11, "32_Black_Document.png");
            // 
            // panelClient
            // 
            this.panelClient.BackColor = System.Drawing.Color.Black;
            this.panelClient.Controls.Add(this.tlPanelPlayList);
            this.panelClient.Controls.Add(this.panelSettings);
            this.panelClient.Controls.Add(this.panelLibrary);
            this.panelClient.Controls.Add(this.panelEqualizer);
            this.panelClient.Controls.Add(this.panelExplorer);
            this.panelClient.Controls.Add(this.panelKaraoke);
            this.panelClient.Controls.Add(this.panelVis);
            this.panelClient.Controls.Add(this.fLPanelMenu);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClient.Location = new System.Drawing.Point(0, 0);
            this.panelClient.Margin = new System.Windows.Forms.Padding(0);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(884, 457);
            this.panelClient.TabIndex = 1;
            // 
            // panelSettings
            // 
            this.panelSettings.AllowDrop = true;
            this.panelSettings.BackColor = System.Drawing.Color.Black;
            this.panelSettings.Controls.Add(this.fLPanelSettingsInfo);
            this.panelSettings.Controls.Add(this.fLPanelSettingsGeneral);
            this.panelSettings.Controls.Add(this.fLPanelSettingsPlayer);
            this.panelSettings.Controls.Add(this.fLPanelSettingsSound);
            this.panelSettings.Controls.Add(this.fLPanelSettingsTheme);
            this.panelSettings.Controls.Add(this.fLPanelSettingsVisualisation);
            this.panelSettings.Controls.Add(this.panelSettingsBorder);
            this.panelSettings.Controls.Add(this.tLPanelSettingsMenu);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(56, 0);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(828, 457);
            this.panelSettings.TabIndex = 4;
            this.panelSettings.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragDrop);
            this.panelSettings.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragEnter);
            // 
            // fLPanelSettingsInfo
            // 
            this.fLPanelSettingsInfo.AutoScroll = true;
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoTitle);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoSubTitleMain);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoMain);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoAuthor);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCompany);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCompiler);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoPlatform);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoVersion);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoSubTitleCopyrights);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightsCode);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightDll);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightBassDll);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightBassNet);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightTagLib);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightIcons);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightIconsDevine);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightIconsGinux);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightIconsGnome);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightIconsWindows8);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightImage);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightImage284301);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightImage105358);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightImage411175);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightImage70937);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoCopyrightImage87577);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoSubTitleVersions);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoVersionAlpha);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoVersionBeta);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoVersionBetaA);
            this.fLPanelSettingsInfo.Controls.Add(this.labelInfoVersionEnd);
            this.fLPanelSettingsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPanelSettingsInfo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLPanelSettingsInfo.ForeColor = System.Drawing.Color.White;
            this.fLPanelSettingsInfo.Location = new System.Drawing.Point(257, 0);
            this.fLPanelSettingsInfo.Margin = new System.Windows.Forms.Padding(0);
            this.fLPanelSettingsInfo.Name = "fLPanelSettingsInfo";
            this.fLPanelSettingsInfo.Size = new System.Drawing.Size(571, 457);
            this.fLPanelSettingsInfo.TabIndex = 2;
            this.fLPanelSettingsInfo.WrapContents = false;
            // 
            // labelInfoTitle
            // 
            this.labelInfoTitle.AutoSize = true;
            this.labelInfoTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoTitle.Location = new System.Drawing.Point(24, 24);
            this.labelInfoTitle.Margin = new System.Windows.Forms.Padding(24, 24, 0, 0);
            this.labelInfoTitle.Name = "labelInfoTitle";
            this.labelInfoTitle.Size = new System.Drawing.Size(161, 33);
            this.labelInfoTitle.TabIndex = 0;
            this.labelInfoTitle.Text = "Informations";
            // 
            // labelInfoSubTitleMain
            // 
            this.labelInfoSubTitleMain.AutoSize = true;
            this.labelInfoSubTitleMain.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoSubTitleMain.Location = new System.Drawing.Point(24, 89);
            this.labelInfoSubTitleMain.Margin = new System.Windows.Forms.Padding(24, 32, 0, 0);
            this.labelInfoSubTitleMain.Name = "labelInfoSubTitleMain";
            this.labelInfoSubTitleMain.Size = new System.Drawing.Size(172, 26);
            this.labelInfoSubTitleMain.TabIndex = 24;
            this.labelInfoSubTitleMain.Text = "Main Informations";
            // 
            // labelInfoMain
            // 
            this.labelInfoMain.AutoSize = true;
            this.labelInfoMain.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoMain.Location = new System.Drawing.Point(32, 139);
            this.labelInfoMain.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelInfoMain.Name = "labelInfoMain";
            this.labelInfoMain.Size = new System.Drawing.Size(168, 18);
            this.labelInfoMain.TabIndex = 23;
            this.labelInfoMain.Text = "AnthraX Music Player";
            // 
            // labelInfoAuthor
            // 
            this.labelInfoAuthor.AutoSize = true;
            this.labelInfoAuthor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoAuthor.Location = new System.Drawing.Point(32, 165);
            this.labelInfoAuthor.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelInfoAuthor.Name = "labelInfoAuthor";
            this.labelInfoAuthor.Size = new System.Drawing.Size(224, 18);
            this.labelInfoAuthor.TabIndex = 29;
            this.labelInfoAuthor.Text = "author:     Kamil Karpiński";
            // 
            // labelInfoCompany
            // 
            this.labelInfoCompany.AutoSize = true;
            this.labelInfoCompany.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCompany.Location = new System.Drawing.Point(32, 191);
            this.labelInfoCompany.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelInfoCompany.Name = "labelInfoCompany";
            this.labelInfoCompany.Size = new System.Drawing.Size(200, 18);
            this.labelInfoCompany.TabIndex = 30;
            this.labelInfoCompany.Text = "company:    PDR Software";
            // 
            // labelInfoCompiler
            // 
            this.labelInfoCompiler.AutoSize = true;
            this.labelInfoCompiler.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCompiler.Location = new System.Drawing.Point(32, 217);
            this.labelInfoCompiler.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelInfoCompiler.Name = "labelInfoCompiler";
            this.labelInfoCompiler.Size = new System.Drawing.Size(232, 18);
            this.labelInfoCompiler.TabIndex = 31;
            this.labelInfoCompiler.Text = "compiler:   Visual Studio C#";
            // 
            // labelInfoPlatform
            // 
            this.labelInfoPlatform.AutoSize = true;
            this.labelInfoPlatform.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoPlatform.Location = new System.Drawing.Point(32, 243);
            this.labelInfoPlatform.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelInfoPlatform.Name = "labelInfoPlatform";
            this.labelInfoPlatform.Size = new System.Drawing.Size(272, 18);
            this.labelInfoPlatform.TabIndex = 32;
            this.labelInfoPlatform.Text = "platform:   Windows 7, 8, 8.1, 10";
            // 
            // labelInfoVersion
            // 
            this.labelInfoVersion.AutoSize = true;
            this.labelInfoVersion.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoVersion.Location = new System.Drawing.Point(32, 269);
            this.labelInfoVersion.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelInfoVersion.Name = "labelInfoVersion";
            this.labelInfoVersion.Size = new System.Drawing.Size(176, 18);
            this.labelInfoVersion.TabIndex = 33;
            this.labelInfoVersion.Text = "version:    Beta 2.10";
            // 
            // labelInfoSubTitleCopyrights
            // 
            this.labelInfoSubTitleCopyrights.AutoSize = true;
            this.labelInfoSubTitleCopyrights.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoSubTitleCopyrights.Location = new System.Drawing.Point(24, 319);
            this.labelInfoSubTitleCopyrights.Margin = new System.Windows.Forms.Padding(24, 32, 0, 0);
            this.labelInfoSubTitleCopyrights.Name = "labelInfoSubTitleCopyrights";
            this.labelInfoSubTitleCopyrights.Size = new System.Drawing.Size(103, 26);
            this.labelInfoSubTitleCopyrights.TabIndex = 26;
            this.labelInfoSubTitleCopyrights.Text = "Copyrights";
            // 
            // labelInfoCopyrightsCode
            // 
            this.labelInfoCopyrightsCode.AutoSize = true;
            this.labelInfoCopyrightsCode.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightsCode.Location = new System.Drawing.Point(32, 369);
            this.labelInfoCopyrightsCode.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelInfoCopyrightsCode.Name = "labelInfoCopyrightsCode";
            this.labelInfoCopyrightsCode.Size = new System.Drawing.Size(192, 18);
            this.labelInfoCopyrightsCode.TabIndex = 25;
            this.labelInfoCopyrightsCode.Text = "coding: Kamil Karpinski";
            // 
            // labelInfoCopyrightDll
            // 
            this.labelInfoCopyrightDll.AutoSize = true;
            this.labelInfoCopyrightDll.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightDll.Location = new System.Drawing.Point(32, 411);
            this.labelInfoCopyrightDll.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelInfoCopyrightDll.Name = "labelInfoCopyrightDll";
            this.labelInfoCopyrightDll.Size = new System.Drawing.Size(258, 23);
            this.labelInfoCopyrightDll.TabIndex = 37;
            this.labelInfoCopyrightDll.Text = "DLL\'s libraries required to work";
            // 
            // labelInfoCopyrightBassDll
            // 
            this.labelInfoCopyrightBassDll.AutoSize = true;
            this.labelInfoCopyrightBassDll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInfoCopyrightBassDll.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightBassDll.Location = new System.Drawing.Point(32, 450);
            this.labelInfoCopyrightBassDll.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.labelInfoCopyrightBassDll.Name = "labelInfoCopyrightBassDll";
            this.labelInfoCopyrightBassDll.Size = new System.Drawing.Size(312, 54);
            this.labelInfoCopyrightBassDll.TabIndex = 34;
            this.labelInfoCopyrightBassDll.Text = "BASS library [by] Un4seen Developments\r\nWebsite: http://www.un4seen.com/\r\nLicence" +
    ": Free for non commercial use.";
            this.labelInfoCopyrightBassDll.Click += new System.EventHandler(this.CopyInfoToClipboard);
            // 
            // labelInfoCopyrightBassNet
            // 
            this.labelInfoCopyrightBassNet.AutoSize = true;
            this.labelInfoCopyrightBassNet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInfoCopyrightBassNet.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightBassNet.Location = new System.Drawing.Point(32, 520);
            this.labelInfoCopyrightBassNet.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.labelInfoCopyrightBassNet.Name = "labelInfoCopyrightBassNet";
            this.labelInfoCopyrightBassNet.Size = new System.Drawing.Size(304, 54);
            this.labelInfoCopyrightBassNet.TabIndex = 35;
            this.labelInfoCopyrightBassNet.Text = "BASS.NET API wrapper [by] radio42\r\nWebsite http://bass.radio42.com/\r\nLicence: Fre" +
    "e for non commercial use.";
            this.labelInfoCopyrightBassNet.Click += new System.EventHandler(this.CopyInfoToClipboard);
            // 
            // labelInfoCopyrightTagLib
            // 
            this.labelInfoCopyrightTagLib.AutoSize = true;
            this.labelInfoCopyrightTagLib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInfoCopyrightTagLib.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightTagLib.Location = new System.Drawing.Point(32, 590);
            this.labelInfoCopyrightTagLib.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.labelInfoCopyrightTagLib.Name = "labelInfoCopyrightTagLib";
            this.labelInfoCopyrightTagLib.Size = new System.Drawing.Size(480, 54);
            this.labelInfoCopyrightTagLib.TabIndex = 51;
            this.labelInfoCopyrightTagLib.Text = "TagLib (aka taglib-sharp) [by] Gabriel Burt & Brian Nickel\r\nWebsite https://githu" +
    "b.com/mono/taglib-sharp\r\nLicence: Free/Open Source software, released under the " +
    "LGPL";
            // 
            // labelInfoCopyrightIcons
            // 
            this.labelInfoCopyrightIcons.AutoSize = true;
            this.labelInfoCopyrightIcons.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightIcons.Location = new System.Drawing.Point(32, 668);
            this.labelInfoCopyrightIcons.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelInfoCopyrightIcons.Name = "labelInfoCopyrightIcons";
            this.labelInfoCopyrightIcons.Size = new System.Drawing.Size(284, 23);
            this.labelInfoCopyrightIcons.TabIndex = 38;
            this.labelInfoCopyrightIcons.Text = "Resource Packs used in application";
            // 
            // labelInfoCopyrightIconsDevine
            // 
            this.labelInfoCopyrightIconsDevine.AutoSize = true;
            this.labelInfoCopyrightIconsDevine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInfoCopyrightIconsDevine.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightIconsDevine.Location = new System.Drawing.Point(32, 707);
            this.labelInfoCopyrightIconsDevine.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.labelInfoCopyrightIconsDevine.Name = "labelInfoCopyrightIconsDevine";
            this.labelInfoCopyrightIconsDevine.Size = new System.Drawing.Size(432, 54);
            this.labelInfoCopyrightIconsDevine.TabIndex = 36;
            this.labelInfoCopyrightIconsDevine.Text = "Devine Part 2 [by] ipapunAuthor\r\nWebsite: http://ipapun.deviantart.com/\r\nLicense:" +
    " CC Attribution Non-Commercial No Derivatives";
            this.labelInfoCopyrightIconsDevine.Click += new System.EventHandler(this.CopyInfoToClipboard);
            // 
            // labelInfoCopyrightIconsGinux
            // 
            this.labelInfoCopyrightIconsGinux.AutoSize = true;
            this.labelInfoCopyrightIconsGinux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInfoCopyrightIconsGinux.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightIconsGinux.Location = new System.Drawing.Point(32, 777);
            this.labelInfoCopyrightIconsGinux.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.labelInfoCopyrightIconsGinux.Name = "labelInfoCopyrightIconsGinux";
            this.labelInfoCopyrightIconsGinux.Size = new System.Drawing.Size(432, 54);
            this.labelInfoCopyrightIconsGinux.TabIndex = 39;
            this.labelInfoCopyrightIconsGinux.Text = "GiNUX [by] Asher Abbasi\r\nWebsite: http://kyo-tux.deviantart.com/\r\nLicense: CC Att" +
    "ribution Non-Commercial No Derivatives";
            this.labelInfoCopyrightIconsGinux.Click += new System.EventHandler(this.CopyInfoToClipboard);
            // 
            // labelInfoCopyrightIconsGnome
            // 
            this.labelInfoCopyrightIconsGnome.AutoSize = true;
            this.labelInfoCopyrightIconsGnome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInfoCopyrightIconsGnome.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightIconsGnome.Location = new System.Drawing.Point(32, 847);
            this.labelInfoCopyrightIconsGnome.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.labelInfoCopyrightIconsGnome.Name = "labelInfoCopyrightIconsGnome";
            this.labelInfoCopyrightIconsGnome.Size = new System.Drawing.Size(376, 54);
            this.labelInfoCopyrightIconsGnome.TabIndex = 40;
            this.labelInfoCopyrightIconsGnome.Text = "GNOME Desktop [by] GNOME icon artistsAuthor\r\nWebsite: http://gnome.org\r\nLicense: " +
    "GNU General Public License, version 2";
            this.labelInfoCopyrightIconsGnome.Click += new System.EventHandler(this.CopyInfoToClipboard);
            // 
            // labelInfoCopyrightIconsWindows8
            // 
            this.labelInfoCopyrightIconsWindows8.AutoSize = true;
            this.labelInfoCopyrightIconsWindows8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInfoCopyrightIconsWindows8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightIconsWindows8.Location = new System.Drawing.Point(32, 917);
            this.labelInfoCopyrightIconsWindows8.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.labelInfoCopyrightIconsWindows8.Name = "labelInfoCopyrightIconsWindows8";
            this.labelInfoCopyrightIconsWindows8.Size = new System.Drawing.Size(280, 54);
            this.labelInfoCopyrightIconsWindows8.TabIndex = 41;
            this.labelInfoCopyrightIconsWindows8.Text = "Windows 8 Vector [by] Icons8Author\r\nWebsite: http://icons8.com/\r\nLicense: CC Attr" +
    "ibution";
            this.labelInfoCopyrightIconsWindows8.Click += new System.EventHandler(this.CopyInfoToClipboard);
            // 
            // labelInfoCopyrightImage
            // 
            this.labelInfoCopyrightImage.AutoSize = true;
            this.labelInfoCopyrightImage.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightImage.Location = new System.Drawing.Point(32, 995);
            this.labelInfoCopyrightImage.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelInfoCopyrightImage.Name = "labelInfoCopyrightImage";
            this.labelInfoCopyrightImage.Size = new System.Drawing.Size(255, 23);
            this.labelInfoCopyrightImage.TabIndex = 42;
            this.labelInfoCopyrightImage.Text = "Background used in application";
            // 
            // labelInfoCopyrightImage284301
            // 
            this.labelInfoCopyrightImage284301.AutoSize = true;
            this.labelInfoCopyrightImage284301.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInfoCopyrightImage284301.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightImage284301.Location = new System.Drawing.Point(32, 1034);
            this.labelInfoCopyrightImage284301.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.labelInfoCopyrightImage284301.Name = "labelInfoCopyrightImage284301";
            this.labelInfoCopyrightImage284301.Size = new System.Drawing.Size(440, 72);
            this.labelInfoCopyrightImage284301.TabIndex = 43;
            this.labelInfoCopyrightImage284301.Text = "284301 [by] TorinoGT\r\nScience & SciFi\r\nWebsite: https://wall.alphacoders.com/big." +
    "php?i=284301\r\nLicence: Unknown";
            this.labelInfoCopyrightImage284301.Click += new System.EventHandler(this.CopyInfoToClipboard);
            // 
            // labelInfoCopyrightImage105358
            // 
            this.labelInfoCopyrightImage105358.AutoSize = true;
            this.labelInfoCopyrightImage105358.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInfoCopyrightImage105358.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightImage105358.Location = new System.Drawing.Point(32, 1122);
            this.labelInfoCopyrightImage105358.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.labelInfoCopyrightImage105358.Name = "labelInfoCopyrightImage105358";
            this.labelInfoCopyrightImage105358.Size = new System.Drawing.Size(440, 54);
            this.labelInfoCopyrightImage105358.TabIndex = 44;
            this.labelInfoCopyrightImage105358.Text = "105358 [by] darkness\r\nWebsite: https://wall.alphacoders.com/big.php?i=105358\r\nLic" +
    "ence: Unknown";
            this.labelInfoCopyrightImage105358.Click += new System.EventHandler(this.CopyInfoToClipboard);
            // 
            // labelInfoCopyrightImage411175
            // 
            this.labelInfoCopyrightImage411175.AutoSize = true;
            this.labelInfoCopyrightImage411175.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInfoCopyrightImage411175.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightImage411175.Location = new System.Drawing.Point(32, 1192);
            this.labelInfoCopyrightImage411175.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.labelInfoCopyrightImage411175.Name = "labelInfoCopyrightImage411175";
            this.labelInfoCopyrightImage411175.Size = new System.Drawing.Size(440, 54);
            this.labelInfoCopyrightImage411175.TabIndex = 45;
            this.labelInfoCopyrightImage411175.Text = "411175 [by] miroha\r\nWebsite: https://wall.alphacoders.com/big.php?i=411175\r\nLicen" +
    "ce: Unknown";
            this.labelInfoCopyrightImage411175.Click += new System.EventHandler(this.CopyInfoToClipboard);
            // 
            // labelInfoCopyrightImage70937
            // 
            this.labelInfoCopyrightImage70937.AutoSize = true;
            this.labelInfoCopyrightImage70937.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInfoCopyrightImage70937.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightImage70937.Location = new System.Drawing.Point(32, 1262);
            this.labelInfoCopyrightImage70937.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.labelInfoCopyrightImage70937.Name = "labelInfoCopyrightImage70937";
            this.labelInfoCopyrightImage70937.Size = new System.Drawing.Size(432, 54);
            this.labelInfoCopyrightImage70937.TabIndex = 46;
            this.labelInfoCopyrightImage70937.Text = "70937 [by] AlphaSystem\r\nWebsite: https://wall.alphacoders.com/big.php?i=70937\r\nLi" +
    "cence: Unknown";
            this.labelInfoCopyrightImage70937.Click += new System.EventHandler(this.CopyInfoToClipboard);
            // 
            // labelInfoCopyrightImage87577
            // 
            this.labelInfoCopyrightImage87577.AutoSize = true;
            this.labelInfoCopyrightImage87577.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInfoCopyrightImage87577.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoCopyrightImage87577.Location = new System.Drawing.Point(32, 1332);
            this.labelInfoCopyrightImage87577.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.labelInfoCopyrightImage87577.Name = "labelInfoCopyrightImage87577";
            this.labelInfoCopyrightImage87577.Size = new System.Drawing.Size(432, 54);
            this.labelInfoCopyrightImage87577.TabIndex = 47;
            this.labelInfoCopyrightImage87577.Text = "87577 [by] 7rev\r\nWebsite: https://wall.alphacoders.com/big.php?i=87577\r\nLicence: " +
    "Unknown";
            this.labelInfoCopyrightImage87577.Click += new System.EventHandler(this.CopyInfoToClipboard);
            // 
            // labelInfoSubTitleVersions
            // 
            this.labelInfoSubTitleVersions.AutoSize = true;
            this.labelInfoSubTitleVersions.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoSubTitleVersions.Location = new System.Drawing.Point(24, 1418);
            this.labelInfoSubTitleVersions.Margin = new System.Windows.Forms.Padding(24, 32, 0, 0);
            this.labelInfoSubTitleVersions.Name = "labelInfoSubTitleVersions";
            this.labelInfoSubTitleVersions.Size = new System.Drawing.Size(84, 26);
            this.labelInfoSubTitleVersions.TabIndex = 28;
            this.labelInfoSubTitleVersions.Text = "Versions";
            // 
            // labelInfoVersionAlpha
            // 
            this.labelInfoVersionAlpha.AutoSize = true;
            this.labelInfoVersionAlpha.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoVersionAlpha.Location = new System.Drawing.Point(32, 1468);
            this.labelInfoVersionAlpha.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelInfoVersionAlpha.Name = "labelInfoVersionAlpha";
            this.labelInfoVersionAlpha.Size = new System.Drawing.Size(304, 162);
            this.labelInfoVersionAlpha.TabIndex = 27;
            this.labelInfoVersionAlpha.Text = resources.GetString("labelInfoVersionAlpha.Text");
            // 
            // labelInfoVersionBeta
            // 
            this.labelInfoVersionBeta.AutoSize = true;
            this.labelInfoVersionBeta.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoVersionBeta.Location = new System.Drawing.Point(32, 1654);
            this.labelInfoVersionBeta.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelInfoVersionBeta.Name = "labelInfoVersionBeta";
            this.labelInfoVersionBeta.Size = new System.Drawing.Size(336, 162);
            this.labelInfoVersionBeta.TabIndex = 50;
            this.labelInfoVersionBeta.Text = resources.GetString("labelInfoVersionBeta.Text");
            // 
            // labelInfoVersionBetaA
            // 
            this.labelInfoVersionBetaA.AutoSize = true;
            this.labelInfoVersionBetaA.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoVersionBetaA.Location = new System.Drawing.Point(32, 1840);
            this.labelInfoVersionBetaA.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelInfoVersionBetaA.Name = "labelInfoVersionBetaA";
            this.labelInfoVersionBetaA.Size = new System.Drawing.Size(432, 252);
            this.labelInfoVersionBetaA.TabIndex = 52;
            this.labelInfoVersionBetaA.Text = resources.GetString("labelInfoVersionBetaA.Text");
            // 
            // labelInfoVersionEnd
            // 
            this.labelInfoVersionEnd.AutoSize = true;
            this.labelInfoVersionEnd.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoVersionEnd.Location = new System.Drawing.Point(32, 2108);
            this.labelInfoVersionEnd.Margin = new System.Windows.Forms.Padding(32, 16, 32, 32);
            this.labelInfoVersionEnd.Name = "labelInfoVersionEnd";
            this.labelInfoVersionEnd.Size = new System.Drawing.Size(16, 18);
            this.labelInfoVersionEnd.TabIndex = 49;
            this.labelInfoVersionEnd.Text = ".";
            // 
            // fLPanelSettingsGeneral
            // 
            this.fLPanelSettingsGeneral.Controls.Add(this.labelGneralTitle);
            this.fLPanelSettingsGeneral.Controls.Add(this.labelGeneralSubTitleAnimations);
            this.fLPanelSettingsGeneral.Controls.Add(this.checkBoxGeneralAnimSpec);
            this.fLPanelSettingsGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPanelSettingsGeneral.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLPanelSettingsGeneral.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fLPanelSettingsGeneral.ForeColor = System.Drawing.Color.White;
            this.fLPanelSettingsGeneral.Location = new System.Drawing.Point(257, 0);
            this.fLPanelSettingsGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.fLPanelSettingsGeneral.Name = "fLPanelSettingsGeneral";
            this.fLPanelSettingsGeneral.Size = new System.Drawing.Size(571, 457);
            this.fLPanelSettingsGeneral.TabIndex = 7;
            // 
            // labelGneralTitle
            // 
            this.labelGneralTitle.AutoSize = true;
            this.labelGneralTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGneralTitle.Location = new System.Drawing.Point(24, 24);
            this.labelGneralTitle.Margin = new System.Windows.Forms.Padding(24, 24, 32, 0);
            this.labelGneralTitle.Name = "labelGneralTitle";
            this.labelGneralTitle.Size = new System.Drawing.Size(103, 33);
            this.labelGneralTitle.TabIndex = 1;
            this.labelGneralTitle.Text = "General";
            // 
            // labelGeneralSubTitleAnimations
            // 
            this.labelGeneralSubTitleAnimations.AutoSize = true;
            this.labelGeneralSubTitleAnimations.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGeneralSubTitleAnimations.Location = new System.Drawing.Point(24, 89);
            this.labelGeneralSubTitleAnimations.Margin = new System.Windows.Forms.Padding(24, 32, 0, 0);
            this.labelGeneralSubTitleAnimations.Name = "labelGeneralSubTitleAnimations";
            this.labelGeneralSubTitleAnimations.Size = new System.Drawing.Size(110, 26);
            this.labelGeneralSubTitleAnimations.TabIndex = 28;
            this.labelGeneralSubTitleAnimations.Text = "Animations";
            // 
            // checkBoxGeneralAnimSpec
            // 
            this.checkBoxGeneralAnimSpec.AutoSize = true;
            this.checkBoxGeneralAnimSpec.Checked = true;
            this.checkBoxGeneralAnimSpec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGeneralAnimSpec.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkBoxGeneralAnimSpec.Location = new System.Drawing.Point(32, 131);
            this.checkBoxGeneralAnimSpec.Margin = new System.Windows.Forms.Padding(32, 16, 0, 0);
            this.checkBoxGeneralAnimSpec.Name = "checkBoxGeneralAnimSpec";
            this.checkBoxGeneralAnimSpec.Size = new System.Drawing.Size(240, 23);
            this.checkBoxGeneralAnimSpec.TabIndex = 42;
            this.checkBoxGeneralAnimSpec.Text = "Use Spectrum Change Animation";
            this.checkBoxGeneralAnimSpec.UseVisualStyleBackColor = true;
            this.checkBoxGeneralAnimSpec.CheckedChanged += new System.EventHandler(this.checkBoxGeneralAnimSpec_CheckedChanged);
            // 
            // fLPanelSettingsPlayer
            // 
            this.fLPanelSettingsPlayer.AutoScroll = true;
            this.fLPanelSettingsPlayer.Controls.Add(this.labelSettingsPlayerTitle);
            this.fLPanelSettingsPlayer.Controls.Add(this.labelPlayerSubTitleInfo);
            this.fLPanelSettingsPlayer.Controls.Add(this.labelPlayerInfo);
            this.fLPanelSettingsPlayer.Controls.Add(this.trackBarPlayerInfo);
            this.fLPanelSettingsPlayer.Controls.Add(this.checkBoxPlayerNotification);
            this.fLPanelSettingsPlayer.Controls.Add(this.labelPlayerSubTitlePlayer);
            this.fLPanelSettingsPlayer.Controls.Add(this.checkBoxPlayerAutoPlay);
            this.fLPanelSettingsPlayer.Controls.Add(this.checkBoxPlayerAutoComeback);
            this.fLPanelSettingsPlayer.Controls.Add(this.checkBoxPlayerAutoSave);
            this.fLPanelSettingsPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPanelSettingsPlayer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLPanelSettingsPlayer.ForeColor = System.Drawing.Color.White;
            this.fLPanelSettingsPlayer.Location = new System.Drawing.Point(257, 0);
            this.fLPanelSettingsPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.fLPanelSettingsPlayer.Name = "fLPanelSettingsPlayer";
            this.fLPanelSettingsPlayer.Size = new System.Drawing.Size(571, 457);
            this.fLPanelSettingsPlayer.TabIndex = 3;
            this.fLPanelSettingsPlayer.WrapContents = false;
            // 
            // labelSettingsPlayerTitle
            // 
            this.labelSettingsPlayerTitle.AutoSize = true;
            this.labelSettingsPlayerTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSettingsPlayerTitle.Location = new System.Drawing.Point(24, 24);
            this.labelSettingsPlayerTitle.Margin = new System.Windows.Forms.Padding(24, 24, 0, 0);
            this.labelSettingsPlayerTitle.Name = "labelSettingsPlayerTitle";
            this.labelSettingsPlayerTitle.Size = new System.Drawing.Size(164, 33);
            this.labelSettingsPlayerTitle.TabIndex = 1;
            this.labelSettingsPlayerTitle.Text = "Media Player";
            // 
            // labelPlayerSubTitleInfo
            // 
            this.labelPlayerSubTitleInfo.AutoSize = true;
            this.labelPlayerSubTitleInfo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayerSubTitleInfo.Location = new System.Drawing.Point(24, 89);
            this.labelPlayerSubTitleInfo.Margin = new System.Windows.Forms.Padding(24, 32, 0, 0);
            this.labelPlayerSubTitleInfo.Name = "labelPlayerSubTitleInfo";
            this.labelPlayerSubTitleInfo.Size = new System.Drawing.Size(190, 26);
            this.labelPlayerSubTitleInfo.TabIndex = 28;
            this.labelPlayerSubTitleInfo.Text = "Display Informations";
            // 
            // labelPlayerInfo
            // 
            this.labelPlayerInfo.AutoSize = true;
            this.labelPlayerInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayerInfo.Location = new System.Drawing.Point(32, 139);
            this.labelPlayerInfo.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelPlayerInfo.Name = "labelPlayerInfo";
            this.labelPlayerInfo.Size = new System.Drawing.Size(188, 19);
            this.labelPlayerInfo.TabIndex = 47;
            this.labelPlayerInfo.Text = "Information on Main Screen";
            // 
            // trackBarPlayerInfo
            // 
            this.trackBarPlayerInfo.Location = new System.Drawing.Point(32, 166);
            this.trackBarPlayerInfo.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.trackBarPlayerInfo.Maximum = 16;
            this.trackBarPlayerInfo.Name = "trackBarPlayerInfo";
            this.trackBarPlayerInfo.Size = new System.Drawing.Size(408, 45);
            this.trackBarPlayerInfo.TabIndex = 46;
            this.trackBarPlayerInfo.Value = 16;
            this.trackBarPlayerInfo.Scroll += new System.EventHandler(this.trackBarPlayerInfo_Scroll);
            // 
            // checkBoxPlayerNotification
            // 
            this.checkBoxPlayerNotification.AutoSize = true;
            this.checkBoxPlayerNotification.Checked = true;
            this.checkBoxPlayerNotification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPlayerNotification.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkBoxPlayerNotification.Location = new System.Drawing.Point(32, 219);
            this.checkBoxPlayerNotification.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.checkBoxPlayerNotification.Name = "checkBoxPlayerNotification";
            this.checkBoxPlayerNotification.Size = new System.Drawing.Size(182, 23);
            this.checkBoxPlayerNotification.TabIndex = 48;
            this.checkBoxPlayerNotification.Text = "Use System Notification";
            this.checkBoxPlayerNotification.UseVisualStyleBackColor = true;
            this.checkBoxPlayerNotification.CheckedChanged += new System.EventHandler(this.checkBoxPlayerNotification_CheckedChanged);
            // 
            // labelPlayerSubTitlePlayer
            // 
            this.labelPlayerSubTitlePlayer.AutoSize = true;
            this.labelPlayerSubTitlePlayer.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayerSubTitlePlayer.Location = new System.Drawing.Point(24, 274);
            this.labelPlayerSubTitlePlayer.Margin = new System.Windows.Forms.Padding(24, 32, 0, 0);
            this.labelPlayerSubTitlePlayer.Name = "labelPlayerSubTitlePlayer";
            this.labelPlayerSubTitlePlayer.Size = new System.Drawing.Size(188, 26);
            this.labelPlayerSubTitlePlayer.TabIndex = 49;
            this.labelPlayerSubTitlePlayer.Text = "Player Configuration";
            // 
            // checkBoxPlayerAutoPlay
            // 
            this.checkBoxPlayerAutoPlay.AutoSize = true;
            this.checkBoxPlayerAutoPlay.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkBoxPlayerAutoPlay.Location = new System.Drawing.Point(32, 324);
            this.checkBoxPlayerAutoPlay.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.checkBoxPlayerAutoPlay.Name = "checkBoxPlayerAutoPlay";
            this.checkBoxPlayerAutoPlay.Size = new System.Drawing.Size(143, 23);
            this.checkBoxPlayerAutoPlay.TabIndex = 50;
            this.checkBoxPlayerAutoPlay.Text = "Auto start playing";
            this.checkBoxPlayerAutoPlay.UseVisualStyleBackColor = true;
            this.checkBoxPlayerAutoPlay.CheckedChanged += new System.EventHandler(this.checkBoxAutoPlay_CheckedChanged);
            // 
            // checkBoxPlayerAutoComeback
            // 
            this.checkBoxPlayerAutoComeback.AutoSize = true;
            this.checkBoxPlayerAutoComeback.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkBoxPlayerAutoComeback.Location = new System.Drawing.Point(32, 355);
            this.checkBoxPlayerAutoComeback.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.checkBoxPlayerAutoComeback.Name = "checkBoxPlayerAutoComeback";
            this.checkBoxPlayerAutoComeback.Size = new System.Drawing.Size(207, 23);
            this.checkBoxPlayerAutoComeback.TabIndex = 52;
            this.checkBoxPlayerAutoComeback.Text = "Return to beginning playlist";
            this.checkBoxPlayerAutoComeback.UseVisualStyleBackColor = true;
            this.checkBoxPlayerAutoComeback.CheckedChanged += new System.EventHandler(this.checkBoxAutoComeback_CheckedChanged);
            // 
            // checkBoxPlayerAutoSave
            // 
            this.checkBoxPlayerAutoSave.AutoSize = true;
            this.checkBoxPlayerAutoSave.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkBoxPlayerAutoSave.Location = new System.Drawing.Point(32, 386);
            this.checkBoxPlayerAutoSave.Margin = new System.Windows.Forms.Padding(32, 8, 32, 32);
            this.checkBoxPlayerAutoSave.Name = "checkBoxPlayerAutoSave";
            this.checkBoxPlayerAutoSave.Size = new System.Drawing.Size(263, 23);
            this.checkBoxPlayerAutoSave.TabIndex = 53;
            this.checkBoxPlayerAutoSave.Text = "Keep last playing songs after restart";
            this.checkBoxPlayerAutoSave.UseVisualStyleBackColor = true;
            this.checkBoxPlayerAutoSave.CheckedChanged += new System.EventHandler(this.checkBoxPlayerAutoSave_CheckedChanged);
            // 
            // fLPanelSettingsSound
            // 
            this.fLPanelSettingsSound.Controls.Add(this.labelSoundTitle);
            this.fLPanelSettingsSound.Controls.Add(this.labelSoundDevice);
            this.fLPanelSettingsSound.Controls.Add(this.comboBoxSoundDevices);
            this.fLPanelSettingsSound.Controls.Add(this.fLPanelSoundDevices);
            this.fLPanelSettingsSound.Controls.Add(this.labelSoundPeaks);
            this.fLPanelSettingsSound.Controls.Add(this.progressBarSoundLeft);
            this.fLPanelSettingsSound.Controls.Add(this.progressBarSoundRight);
            this.fLPanelSettingsSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPanelSettingsSound.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLPanelSettingsSound.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fLPanelSettingsSound.ForeColor = System.Drawing.Color.White;
            this.fLPanelSettingsSound.Location = new System.Drawing.Point(257, 0);
            this.fLPanelSettingsSound.Margin = new System.Windows.Forms.Padding(0);
            this.fLPanelSettingsSound.Name = "fLPanelSettingsSound";
            this.fLPanelSettingsSound.Size = new System.Drawing.Size(571, 457);
            this.fLPanelSettingsSound.TabIndex = 4;
            // 
            // labelSoundTitle
            // 
            this.labelSoundTitle.AutoSize = true;
            this.labelSoundTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSoundTitle.Location = new System.Drawing.Point(24, 24);
            this.labelSoundTitle.Margin = new System.Windows.Forms.Padding(24, 24, 32, 0);
            this.labelSoundTitle.Name = "labelSoundTitle";
            this.labelSoundTitle.Size = new System.Drawing.Size(85, 33);
            this.labelSoundTitle.TabIndex = 1;
            this.labelSoundTitle.Text = "Sound";
            // 
            // labelSoundDevice
            // 
            this.labelSoundDevice.AutoSize = true;
            this.labelSoundDevice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSoundDevice.Location = new System.Drawing.Point(32, 81);
            this.labelSoundDevice.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelSoundDevice.Name = "labelSoundDevice";
            this.labelSoundDevice.Size = new System.Drawing.Size(102, 19);
            this.labelSoundDevice.TabIndex = 2;
            this.labelSoundDevice.Text = "Output Device";
            // 
            // comboBoxSoundDevices
            // 
            this.comboBoxSoundDevices.FormattingEnabled = true;
            this.comboBoxSoundDevices.Location = new System.Drawing.Point(32, 108);
            this.comboBoxSoundDevices.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.comboBoxSoundDevices.Name = "comboBoxSoundDevices";
            this.comboBoxSoundDevices.Size = new System.Drawing.Size(300, 27);
            this.comboBoxSoundDevices.TabIndex = 3;
            this.comboBoxSoundDevices.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSoundDevices_SelectedIndexChanged);
            // 
            // fLPanelSoundDevices
            // 
            this.fLPanelSoundDevices.Controls.Add(this.buttonSoundDevicesRefresh);
            this.fLPanelSoundDevices.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPanelSoundDevices.Location = new System.Drawing.Point(32, 143);
            this.fLPanelSoundDevices.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.fLPanelSoundDevices.Name = "fLPanelSoundDevices";
            this.fLPanelSoundDevices.Size = new System.Drawing.Size(300, 28);
            this.fLPanelSoundDevices.TabIndex = 4;
            // 
            // buttonSoundDevicesRefresh
            // 
            this.buttonSoundDevicesRefresh.ForeColor = System.Drawing.Color.Black;
            this.buttonSoundDevicesRefresh.Location = new System.Drawing.Point(172, 0);
            this.buttonSoundDevicesRefresh.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.buttonSoundDevicesRefresh.Name = "buttonSoundDevicesRefresh";
            this.buttonSoundDevicesRefresh.Size = new System.Drawing.Size(128, 28);
            this.buttonSoundDevicesRefresh.TabIndex = 0;
            this.buttonSoundDevicesRefresh.Text = "Refresh Devices";
            this.buttonSoundDevicesRefresh.UseVisualStyleBackColor = true;
            this.buttonSoundDevicesRefresh.Click += new System.EventHandler(this.buttonSoundDevicesRefresh_Click);
            // 
            // labelSoundPeaks
            // 
            this.labelSoundPeaks.AutoSize = true;
            this.labelSoundPeaks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSoundPeaks.Location = new System.Drawing.Point(32, 195);
            this.labelSoundPeaks.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelSoundPeaks.Name = "labelSoundPeaks";
            this.labelSoundPeaks.Size = new System.Drawing.Size(118, 19);
            this.labelSoundPeaks.TabIndex = 22;
            this.labelSoundPeaks.Text = "Output Spectrum";
            // 
            // progressBarSoundLeft
            // 
            this.progressBarSoundLeft.Location = new System.Drawing.Point(32, 222);
            this.progressBarSoundLeft.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.progressBarSoundLeft.Maximum = 32768;
            this.progressBarSoundLeft.Name = "progressBarSoundLeft";
            this.progressBarSoundLeft.Size = new System.Drawing.Size(300, 20);
            this.progressBarSoundLeft.Step = 1;
            this.progressBarSoundLeft.TabIndex = 21;
            // 
            // progressBarSoundRight
            // 
            this.progressBarSoundRight.Location = new System.Drawing.Point(32, 250);
            this.progressBarSoundRight.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.progressBarSoundRight.Maximum = 32768;
            this.progressBarSoundRight.Name = "progressBarSoundRight";
            this.progressBarSoundRight.Size = new System.Drawing.Size(300, 20);
            this.progressBarSoundRight.Step = 1;
            this.progressBarSoundRight.TabIndex = 23;
            // 
            // fLPanelSettingsTheme
            // 
            this.fLPanelSettingsTheme.AutoScroll = true;
            this.fLPanelSettingsTheme.Controls.Add(this.labelThemeTitle);
            this.fLPanelSettingsTheme.Controls.Add(this.labelThemeSubTitleColors);
            this.fLPanelSettingsTheme.Controls.Add(this.labelTheme);
            this.fLPanelSettingsTheme.Controls.Add(this.comboBoxThemeType);
            this.fLPanelSettingsTheme.Controls.Add(this.labelThemeColor);
            this.fLPanelSettingsTheme.Controls.Add(this.comboBoxThemeColor);
            this.fLPanelSettingsTheme.Controls.Add(this.labelThemeCustomColor);
            this.fLPanelSettingsTheme.Controls.Add(this.fLPanelThemeCustomColor);
            this.fLPanelSettingsTheme.Controls.Add(this.labelThemeSubTitleWallpaper);
            this.fLPanelSettingsTheme.Controls.Add(this.labelThemeWallpaper);
            this.fLPanelSettingsTheme.Controls.Add(this.comboBoxThemeWallpaper);
            this.fLPanelSettingsTheme.Controls.Add(this.labelThemeWallpaperColor);
            this.fLPanelSettingsTheme.Controls.Add(this.comboBoxThemeWallpaperColor);
            this.fLPanelSettingsTheme.Controls.Add(this.labelThemeWallpaperCustomColor);
            this.fLPanelSettingsTheme.Controls.Add(this.fLPanelThemeWallpaperCustomColor);
            this.fLPanelSettingsTheme.Controls.Add(this.fLPanelThemeWallpaper);
            this.fLPanelSettingsTheme.Controls.Add(this.labelThemeWallpaperPosition);
            this.fLPanelSettingsTheme.Controls.Add(this.comboBoxThemeWallpaperPosition);
            this.fLPanelSettingsTheme.Controls.Add(this.labelThemeSubTitleMore);
            this.fLPanelSettingsTheme.Controls.Add(this.checkBoxThemeDarkTheme);
            this.fLPanelSettingsTheme.Controls.Add(this.checkBoxThemeTransparency);
            this.fLPanelSettingsTheme.Controls.Add(this.trackBarThemeTransparency);
            this.fLPanelSettingsTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPanelSettingsTheme.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLPanelSettingsTheme.ForeColor = System.Drawing.Color.White;
            this.fLPanelSettingsTheme.Location = new System.Drawing.Point(257, 0);
            this.fLPanelSettingsTheme.Margin = new System.Windows.Forms.Padding(0);
            this.fLPanelSettingsTheme.Name = "fLPanelSettingsTheme";
            this.fLPanelSettingsTheme.Size = new System.Drawing.Size(571, 457);
            this.fLPanelSettingsTheme.TabIndex = 5;
            this.fLPanelSettingsTheme.WrapContents = false;
            // 
            // labelThemeTitle
            // 
            this.labelThemeTitle.AutoSize = true;
            this.labelThemeTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelThemeTitle.Location = new System.Drawing.Point(24, 24);
            this.labelThemeTitle.Margin = new System.Windows.Forms.Padding(24, 24, 0, 0);
            this.labelThemeTitle.Name = "labelThemeTitle";
            this.labelThemeTitle.Size = new System.Drawing.Size(92, 33);
            this.labelThemeTitle.TabIndex = 1;
            this.labelThemeTitle.Text = "Theme";
            // 
            // labelThemeSubTitleColors
            // 
            this.labelThemeSubTitleColors.AutoSize = true;
            this.labelThemeSubTitleColors.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelThemeSubTitleColors.Location = new System.Drawing.Point(24, 89);
            this.labelThemeSubTitleColors.Margin = new System.Windows.Forms.Padding(24, 32, 0, 0);
            this.labelThemeSubTitleColors.Name = "labelThemeSubTitleColors";
            this.labelThemeSubTitleColors.Size = new System.Drawing.Size(130, 26);
            this.labelThemeSubTitleColors.TabIndex = 22;
            this.labelThemeSubTitleColors.Text = "Theme Colors";
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTheme.Location = new System.Drawing.Point(32, 139);
            this.labelTheme.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(87, 19);
            this.labelTheme.TabIndex = 25;
            this.labelTheme.Text = "Theme Type";
            // 
            // comboBoxThemeType
            // 
            this.comboBoxThemeType.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxThemeType.FormattingEnabled = true;
            this.comboBoxThemeType.Items.AddRange(new object[] {
            "None",
            "Color",
            "Custom Color",
            "System Theme"});
            this.comboBoxThemeType.Location = new System.Drawing.Point(32, 166);
            this.comboBoxThemeType.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.comboBoxThemeType.Name = "comboBoxThemeType";
            this.comboBoxThemeType.Size = new System.Drawing.Size(408, 27);
            this.comboBoxThemeType.TabIndex = 26;
            this.comboBoxThemeType.SelectionChangeCommitted += new System.EventHandler(this.comboBoxThemeType_SelectionChangeCommitted);
            // 
            // labelThemeColor
            // 
            this.labelThemeColor.AutoSize = true;
            this.labelThemeColor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelThemeColor.Location = new System.Drawing.Point(32, 201);
            this.labelThemeColor.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelThemeColor.Name = "labelThemeColor";
            this.labelThemeColor.Size = new System.Drawing.Size(145, 19);
            this.labelThemeColor.TabIndex = 5;
            this.labelThemeColor.Text = "Theme Color Scheme";
            // 
            // comboBoxThemeColor
            // 
            this.comboBoxThemeColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxThemeColor.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxThemeColor.FormattingEnabled = true;
            this.comboBoxThemeColor.Location = new System.Drawing.Point(32, 228);
            this.comboBoxThemeColor.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.comboBoxThemeColor.Name = "comboBoxThemeColor";
            this.comboBoxThemeColor.Size = new System.Drawing.Size(408, 28);
            this.comboBoxThemeColor.TabIndex = 6;
            this.comboBoxThemeColor.SelectionChangeCommitted += new System.EventHandler(this.comboBoxThemeColor_SelectionChangeCommitted);
            // 
            // labelThemeCustomColor
            // 
            this.labelThemeCustomColor.AutoSize = true;
            this.labelThemeCustomColor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelThemeCustomColor.Location = new System.Drawing.Point(32, 264);
            this.labelThemeCustomColor.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelThemeCustomColor.Name = "labelThemeCustomColor";
            this.labelThemeCustomColor.Size = new System.Drawing.Size(144, 19);
            this.labelThemeCustomColor.TabIndex = 6;
            this.labelThemeCustomColor.Text = "Theme Custom Color";
            // 
            // fLPanelThemeCustomColor
            // 
            this.fLPanelThemeCustomColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLPanelThemeCustomColor.Controls.Add(this.buttonThemeCustomColor);
            this.fLPanelThemeCustomColor.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPanelThemeCustomColor.Location = new System.Drawing.Point(32, 291);
            this.fLPanelThemeCustomColor.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.fLPanelThemeCustomColor.Name = "fLPanelThemeCustomColor";
            this.fLPanelThemeCustomColor.Size = new System.Drawing.Size(408, 38);
            this.fLPanelThemeCustomColor.TabIndex = 7;
            // 
            // buttonThemeCustomColor
            // 
            this.buttonThemeCustomColor.ForeColor = System.Drawing.Color.Black;
            this.buttonThemeCustomColor.Location = new System.Drawing.Point(274, 4);
            this.buttonThemeCustomColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThemeCustomColor.Name = "buttonThemeCustomColor";
            this.buttonThemeCustomColor.Size = new System.Drawing.Size(128, 28);
            this.buttonThemeCustomColor.TabIndex = 0;
            this.buttonThemeCustomColor.Text = "Select Custom Color";
            this.buttonThemeCustomColor.UseVisualStyleBackColor = true;
            this.buttonThemeCustomColor.Click += new System.EventHandler(this.buttonThemeCustomColor_Click);
            // 
            // labelThemeSubTitleWallpaper
            // 
            this.labelThemeSubTitleWallpaper.AutoSize = true;
            this.labelThemeSubTitleWallpaper.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelThemeSubTitleWallpaper.Location = new System.Drawing.Point(24, 361);
            this.labelThemeSubTitleWallpaper.Margin = new System.Windows.Forms.Padding(24, 32, 0, 0);
            this.labelThemeSubTitleWallpaper.Name = "labelThemeSubTitleWallpaper";
            this.labelThemeSubTitleWallpaper.Size = new System.Drawing.Size(179, 26);
            this.labelThemeSubTitleWallpaper.TabIndex = 23;
            this.labelThemeSubTitleWallpaper.Text = "Theme Background";
            // 
            // labelThemeWallpaper
            // 
            this.labelThemeWallpaper.AutoSize = true;
            this.labelThemeWallpaper.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelThemeWallpaper.Location = new System.Drawing.Point(32, 419);
            this.labelThemeWallpaper.Margin = new System.Windows.Forms.Padding(32, 32, 32, 0);
            this.labelThemeWallpaper.Name = "labelThemeWallpaper";
            this.labelThemeWallpaper.Size = new System.Drawing.Size(155, 19);
            this.labelThemeWallpaper.TabIndex = 9;
            this.labelThemeWallpaper.Text = "Background Wallpaper";
            // 
            // comboBoxThemeWallpaper
            // 
            this.comboBoxThemeWallpaper.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxThemeWallpaper.FormattingEnabled = true;
            this.comboBoxThemeWallpaper.Items.AddRange(new object[] {
            "None",
            "Color",
            "Custom Color",
            "Picture",
            "System Wallpaper"});
            this.comboBoxThemeWallpaper.Location = new System.Drawing.Point(32, 446);
            this.comboBoxThemeWallpaper.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.comboBoxThemeWallpaper.Name = "comboBoxThemeWallpaper";
            this.comboBoxThemeWallpaper.Size = new System.Drawing.Size(408, 27);
            this.comboBoxThemeWallpaper.TabIndex = 10;
            this.comboBoxThemeWallpaper.SelectionChangeCommitted += new System.EventHandler(this.comboBoxThemeWallpaper_SelectionChangeCommitted);
            // 
            // labelThemeWallpaperColor
            // 
            this.labelThemeWallpaperColor.AutoSize = true;
            this.labelThemeWallpaperColor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelThemeWallpaperColor.Location = new System.Drawing.Point(32, 481);
            this.labelThemeWallpaperColor.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelThemeWallpaperColor.Name = "labelThemeWallpaperColor";
            this.labelThemeWallpaperColor.Size = new System.Drawing.Size(91, 19);
            this.labelThemeWallpaperColor.TabIndex = 11;
            this.labelThemeWallpaperColor.Text = "Theme Color";
            // 
            // comboBoxThemeWallpaperColor
            // 
            this.comboBoxThemeWallpaperColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxThemeWallpaperColor.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxThemeWallpaperColor.FormattingEnabled = true;
            this.comboBoxThemeWallpaperColor.Location = new System.Drawing.Point(32, 508);
            this.comboBoxThemeWallpaperColor.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.comboBoxThemeWallpaperColor.Name = "comboBoxThemeWallpaperColor";
            this.comboBoxThemeWallpaperColor.Size = new System.Drawing.Size(408, 28);
            this.comboBoxThemeWallpaperColor.TabIndex = 12;
            this.comboBoxThemeWallpaperColor.SelectionChangeCommitted += new System.EventHandler(this.comboBoxThemeWallpaperColor_SelectionChangeCommitted);
            // 
            // labelThemeWallpaperCustomColor
            // 
            this.labelThemeWallpaperCustomColor.AutoSize = true;
            this.labelThemeWallpaperCustomColor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelThemeWallpaperCustomColor.Location = new System.Drawing.Point(32, 544);
            this.labelThemeWallpaperCustomColor.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelThemeWallpaperCustomColor.Name = "labelThemeWallpaperCustomColor";
            this.labelThemeWallpaperCustomColor.Size = new System.Drawing.Size(144, 19);
            this.labelThemeWallpaperCustomColor.TabIndex = 12;
            this.labelThemeWallpaperCustomColor.Text = "Theme Custom Color";
            // 
            // fLPanelThemeWallpaperCustomColor
            // 
            this.fLPanelThemeWallpaperCustomColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLPanelThemeWallpaperCustomColor.Controls.Add(this.buttonThemeWallpaperCustomColor);
            this.fLPanelThemeWallpaperCustomColor.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPanelThemeWallpaperCustomColor.Location = new System.Drawing.Point(32, 571);
            this.fLPanelThemeWallpaperCustomColor.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.fLPanelThemeWallpaperCustomColor.Name = "fLPanelThemeWallpaperCustomColor";
            this.fLPanelThemeWallpaperCustomColor.Size = new System.Drawing.Size(408, 38);
            this.fLPanelThemeWallpaperCustomColor.TabIndex = 13;
            // 
            // buttonThemeWallpaperCustomColor
            // 
            this.buttonThemeWallpaperCustomColor.ForeColor = System.Drawing.Color.Black;
            this.buttonThemeWallpaperCustomColor.Location = new System.Drawing.Point(274, 4);
            this.buttonThemeWallpaperCustomColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThemeWallpaperCustomColor.Name = "buttonThemeWallpaperCustomColor";
            this.buttonThemeWallpaperCustomColor.Size = new System.Drawing.Size(128, 28);
            this.buttonThemeWallpaperCustomColor.TabIndex = 0;
            this.buttonThemeWallpaperCustomColor.Text = "Select Custom Color";
            this.buttonThemeWallpaperCustomColor.UseVisualStyleBackColor = true;
            this.buttonThemeWallpaperCustomColor.Click += new System.EventHandler(this.buttonThemeWallpaperCustomColor_Click);
            // 
            // fLPanelThemeWallpaper
            // 
            this.fLPanelThemeWallpaper.Controls.Add(this.pictureBoxThemeWallpaper01);
            this.fLPanelThemeWallpaper.Controls.Add(this.pictureBoxThemeWallpaper02);
            this.fLPanelThemeWallpaper.Controls.Add(this.pictureBoxThemeWallpaper03);
            this.fLPanelThemeWallpaper.Controls.Add(this.pictureBoxThemeWallpaper04);
            this.fLPanelThemeWallpaper.Controls.Add(this.pictureBoxThemeWallpaper05);
            this.fLPanelThemeWallpaper.Controls.Add(this.pictureBoxThemeWallpaper06);
            this.fLPanelThemeWallpaper.Location = new System.Drawing.Point(32, 617);
            this.fLPanelThemeWallpaper.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.fLPanelThemeWallpaper.Name = "fLPanelThemeWallpaper";
            this.fLPanelThemeWallpaper.Size = new System.Drawing.Size(408, 144);
            this.fLPanelThemeWallpaper.TabIndex = 15;
            // 
            // pictureBoxThemeWallpaper01
            // 
            this.pictureBoxThemeWallpaper01.Image = global::AnthraX.Properties.Resources._284301_TorinoGT_FantasyAndSciFi_1948x1096_LicUnknown;
            this.pictureBoxThemeWallpaper01.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxThemeWallpaper01.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxThemeWallpaper01.Name = "pictureBoxThemeWallpaper01";
            this.pictureBoxThemeWallpaper01.Size = new System.Drawing.Size(128, 64);
            this.pictureBoxThemeWallpaper01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThemeWallpaper01.TabIndex = 0;
            this.pictureBoxThemeWallpaper01.TabStop = false;
            this.pictureBoxThemeWallpaper01.DoubleClick += new System.EventHandler(this.pictureBoxThemeWallpaper_DoubleClick);
            // 
            // pictureBoxThemeWallpaper02
            // 
            this.pictureBoxThemeWallpaper02.Image = global::AnthraX.Properties.Resources._105358_darkness_2560x1600_LicUnknown;
            this.pictureBoxThemeWallpaper02.Location = new System.Drawing.Point(140, 4);
            this.pictureBoxThemeWallpaper02.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxThemeWallpaper02.Name = "pictureBoxThemeWallpaper02";
            this.pictureBoxThemeWallpaper02.Size = new System.Drawing.Size(128, 64);
            this.pictureBoxThemeWallpaper02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThemeWallpaper02.TabIndex = 1;
            this.pictureBoxThemeWallpaper02.TabStop = false;
            this.pictureBoxThemeWallpaper02.DoubleClick += new System.EventHandler(this.pictureBoxThemeWallpaper_DoubleClick);
            // 
            // pictureBoxThemeWallpaper03
            // 
            this.pictureBoxThemeWallpaper03.Image = global::AnthraX.Properties.Resources._411175_miroha_2880x1800_LicUnknown;
            this.pictureBoxThemeWallpaper03.Location = new System.Drawing.Point(276, 4);
            this.pictureBoxThemeWallpaper03.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxThemeWallpaper03.Name = "pictureBoxThemeWallpaper03";
            this.pictureBoxThemeWallpaper03.Size = new System.Drawing.Size(128, 64);
            this.pictureBoxThemeWallpaper03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThemeWallpaper03.TabIndex = 2;
            this.pictureBoxThemeWallpaper03.TabStop = false;
            this.pictureBoxThemeWallpaper03.DoubleClick += new System.EventHandler(this.pictureBoxThemeWallpaper_DoubleClick);
            // 
            // pictureBoxThemeWallpaper04
            // 
            this.pictureBoxThemeWallpaper04.Image = global::AnthraX.Properties.Resources._70937_AlphaSystem_1920x1200_LicUnknown;
            this.pictureBoxThemeWallpaper04.Location = new System.Drawing.Point(4, 76);
            this.pictureBoxThemeWallpaper04.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxThemeWallpaper04.Name = "pictureBoxThemeWallpaper04";
            this.pictureBoxThemeWallpaper04.Size = new System.Drawing.Size(128, 64);
            this.pictureBoxThemeWallpaper04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThemeWallpaper04.TabIndex = 3;
            this.pictureBoxThemeWallpaper04.TabStop = false;
            this.pictureBoxThemeWallpaper04.DoubleClick += new System.EventHandler(this.pictureBoxThemeWallpaper_DoubleClick);
            // 
            // pictureBoxThemeWallpaper05
            // 
            this.pictureBoxThemeWallpaper05.Image = global::AnthraX.Properties.Resources._87577_7rev_Random_1920x1080_LicUnknown;
            this.pictureBoxThemeWallpaper05.Location = new System.Drawing.Point(140, 76);
            this.pictureBoxThemeWallpaper05.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxThemeWallpaper05.Name = "pictureBoxThemeWallpaper05";
            this.pictureBoxThemeWallpaper05.Size = new System.Drawing.Size(128, 64);
            this.pictureBoxThemeWallpaper05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThemeWallpaper05.TabIndex = 4;
            this.pictureBoxThemeWallpaper05.TabStop = false;
            this.pictureBoxThemeWallpaper05.DoubleClick += new System.EventHandler(this.pictureBoxThemeWallpaper_DoubleClick);
            // 
            // pictureBoxThemeWallpaper06
            // 
            this.pictureBoxThemeWallpaper06.Location = new System.Drawing.Point(276, 76);
            this.pictureBoxThemeWallpaper06.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxThemeWallpaper06.Name = "pictureBoxThemeWallpaper06";
            this.pictureBoxThemeWallpaper06.Size = new System.Drawing.Size(128, 64);
            this.pictureBoxThemeWallpaper06.TabIndex = 5;
            this.pictureBoxThemeWallpaper06.TabStop = false;
            this.pictureBoxThemeWallpaper06.Click += new System.EventHandler(this.pictureBoxThemeWallpaperCustom_Click);
            this.pictureBoxThemeWallpaper06.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxThemeWallpaper06_Paint);
            this.pictureBoxThemeWallpaper06.DoubleClick += new System.EventHandler(this.pictureBoxThemeWallpaperCustom_DoubleClick);
            this.pictureBoxThemeWallpaper06.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxThemeWallpaper06_MouseDown);
            this.pictureBoxThemeWallpaper06.MouseLeave += new System.EventHandler(this.pictureBoxThemeWallpaper06_MouseLeave);
            this.pictureBoxThemeWallpaper06.MouseHover += new System.EventHandler(this.pictureBoxThemeWallpaper06_MouseHover);
            // 
            // labelThemeWallpaperPosition
            // 
            this.labelThemeWallpaperPosition.AutoSize = true;
            this.labelThemeWallpaperPosition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelThemeWallpaperPosition.Location = new System.Drawing.Point(32, 785);
            this.labelThemeWallpaperPosition.Margin = new System.Windows.Forms.Padding(32, 24, 0, 0);
            this.labelThemeWallpaperPosition.Name = "labelThemeWallpaperPosition";
            this.labelThemeWallpaperPosition.Size = new System.Drawing.Size(141, 19);
            this.labelThemeWallpaperPosition.TabIndex = 19;
            this.labelThemeWallpaperPosition.Text = "Background Position";
            // 
            // comboBoxThemeWallpaperPosition
            // 
            this.comboBoxThemeWallpaperPosition.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxThemeWallpaperPosition.FormattingEnabled = true;
            this.comboBoxThemeWallpaperPosition.Items.AddRange(new object[] {
            "Normal",
            "Center",
            "Resize",
            "Stretch",
            "Adjust Fill",
            "Adjust Center"});
            this.comboBoxThemeWallpaperPosition.Location = new System.Drawing.Point(32, 812);
            this.comboBoxThemeWallpaperPosition.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.comboBoxThemeWallpaperPosition.Name = "comboBoxThemeWallpaperPosition";
            this.comboBoxThemeWallpaperPosition.Size = new System.Drawing.Size(408, 27);
            this.comboBoxThemeWallpaperPosition.TabIndex = 20;
            this.comboBoxThemeWallpaperPosition.SelectionChangeCommitted += new System.EventHandler(this.comboBoxThemeWallpaperPosition_SelectionChangeCommitted);
            // 
            // labelThemeSubTitleMore
            // 
            this.labelThemeSubTitleMore.AutoSize = true;
            this.labelThemeSubTitleMore.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelThemeSubTitleMore.Location = new System.Drawing.Point(24, 871);
            this.labelThemeSubTitleMore.Margin = new System.Windows.Forms.Padding(24, 32, 0, 0);
            this.labelThemeSubTitleMore.Name = "labelThemeSubTitleMore";
            this.labelThemeSubTitleMore.Size = new System.Drawing.Size(238, 26);
            this.labelThemeSubTitleMore.TabIndex = 24;
            this.labelThemeSubTitleMore.Text = "Theme Additional Options";
            // 
            // checkBoxThemeDarkTheme
            // 
            this.checkBoxThemeDarkTheme.AutoSize = true;
            this.checkBoxThemeDarkTheme.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkBoxThemeDarkTheme.Location = new System.Drawing.Point(32, 921);
            this.checkBoxThemeDarkTheme.Margin = new System.Windows.Forms.Padding(32, 24, 0, 0);
            this.checkBoxThemeDarkTheme.Name = "checkBoxThemeDarkTheme";
            this.checkBoxThemeDarkTheme.Size = new System.Drawing.Size(125, 23);
            this.checkBoxThemeDarkTheme.TabIndex = 21;
            this.checkBoxThemeDarkTheme.Text = "Use Dark Icons";
            this.checkBoxThemeDarkTheme.UseVisualStyleBackColor = true;
            this.checkBoxThemeDarkTheme.CheckedChanged += new System.EventHandler(this.checkBoxThemeDarkTheme_CheckedChanged);
            // 
            // checkBoxThemeTransparency
            // 
            this.checkBoxThemeTransparency.AutoSize = true;
            this.checkBoxThemeTransparency.Checked = true;
            this.checkBoxThemeTransparency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxThemeTransparency.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkBoxThemeTransparency.Location = new System.Drawing.Point(32, 968);
            this.checkBoxThemeTransparency.Margin = new System.Windows.Forms.Padding(32, 24, 0, 0);
            this.checkBoxThemeTransparency.Name = "checkBoxThemeTransparency";
            this.checkBoxThemeTransparency.Size = new System.Drawing.Size(205, 23);
            this.checkBoxThemeTransparency.TabIndex = 17;
            this.checkBoxThemeTransparency.Text = "Use Transparency Interface";
            this.checkBoxThemeTransparency.UseVisualStyleBackColor = true;
            this.checkBoxThemeTransparency.CheckedChanged += new System.EventHandler(this.checkBoxThemeTransparency_CheckedChanged);
            // 
            // trackBarThemeTransparency
            // 
            this.trackBarThemeTransparency.Location = new System.Drawing.Point(32, 999);
            this.trackBarThemeTransparency.Margin = new System.Windows.Forms.Padding(32, 8, 0, 32);
            this.trackBarThemeTransparency.Maximum = 255;
            this.trackBarThemeTransparency.Name = "trackBarThemeTransparency";
            this.trackBarThemeTransparency.Size = new System.Drawing.Size(408, 45);
            this.trackBarThemeTransparency.TabIndex = 18;
            this.trackBarThemeTransparency.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarThemeTransparency.Scroll += new System.EventHandler(this.trackBarThemeTransparency_Scroll);
            // 
            // fLPanelSettingsVisualisation
            // 
            this.fLPanelSettingsVisualisation.AutoScroll = true;
            this.fLPanelSettingsVisualisation.Controls.Add(this.labelSettingsVisualisationTitle);
            this.fLPanelSettingsVisualisation.Controls.Add(this.labelVisualisationSubTitleType);
            this.fLPanelSettingsVisualisation.Controls.Add(this.labelVisualisationType);
            this.fLPanelSettingsVisualisation.Controls.Add(this.comboBoxVisualisationType);
            this.fLPanelSettingsVisualisation.Controls.Add(this.labelVisualisationSize);
            this.fLPanelSettingsVisualisation.Controls.Add(this.trackBarVisualisationSize);
            this.fLPanelSettingsVisualisation.Controls.Add(this.labelVisualisationSubTitleLogo);
            this.fLPanelSettingsVisualisation.Controls.Add(this.labelVisualisationLogo);
            this.fLPanelSettingsVisualisation.Controls.Add(this.comboBoxVisualisationLogo);
            this.fLPanelSettingsVisualisation.Controls.Add(this.labelVisualisationSubTitleStyle);
            this.fLPanelSettingsVisualisation.Controls.Add(this.labelVisualisationColorScheme);
            this.fLPanelSettingsVisualisation.Controls.Add(this.comboBoxVisualisationColorType);
            this.fLPanelSettingsVisualisation.Controls.Add(this.labelVisualisationColor);
            this.fLPanelSettingsVisualisation.Controls.Add(this.comboBoxVisualisationColor);
            this.fLPanelSettingsVisualisation.Controls.Add(this.labelVisualisationCustomColor);
            this.fLPanelSettingsVisualisation.Controls.Add(this.fLPanelVisualisationCustomColor);
            this.fLPanelSettingsVisualisation.Controls.Add(this.labelVisualisationColorSpeed);
            this.fLPanelSettingsVisualisation.Controls.Add(this.trackBarVisualisationColorSpeed);
            this.fLPanelSettingsVisualisation.Controls.Add(this.labelVisualisationColorRainbow);
            this.fLPanelSettingsVisualisation.Controls.Add(this.trackBarVisualisationColorRainbow);
            this.fLPanelSettingsVisualisation.Controls.Add(this.checkBoxVisualisationTransparency);
            this.fLPanelSettingsVisualisation.Controls.Add(this.trackBarVisualisationTransparency);
            this.fLPanelSettingsVisualisation.Controls.Add(this.labelVisualisationFill);
            this.fLPanelSettingsVisualisation.Controls.Add(this.comboBoxVisualisationFill);
            this.fLPanelSettingsVisualisation.Controls.Add(this.labelVisualisationSubTitleOptions);
            this.fLPanelSettingsVisualisation.Controls.Add(this.labelVisualisationSensitivity);
            this.fLPanelSettingsVisualisation.Controls.Add(this.trackBarVisualisationSensitivity);
            this.fLPanelSettingsVisualisation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPanelSettingsVisualisation.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLPanelSettingsVisualisation.ForeColor = System.Drawing.Color.White;
            this.fLPanelSettingsVisualisation.Location = new System.Drawing.Point(257, 0);
            this.fLPanelSettingsVisualisation.Margin = new System.Windows.Forms.Padding(0);
            this.fLPanelSettingsVisualisation.Name = "fLPanelSettingsVisualisation";
            this.fLPanelSettingsVisualisation.Size = new System.Drawing.Size(571, 457);
            this.fLPanelSettingsVisualisation.TabIndex = 6;
            this.fLPanelSettingsVisualisation.WrapContents = false;
            // 
            // labelSettingsVisualisationTitle
            // 
            this.labelSettingsVisualisationTitle.AutoSize = true;
            this.labelSettingsVisualisationTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSettingsVisualisationTitle.Location = new System.Drawing.Point(24, 24);
            this.labelSettingsVisualisationTitle.Margin = new System.Windows.Forms.Padding(24, 24, 0, 0);
            this.labelSettingsVisualisationTitle.Name = "labelSettingsVisualisationTitle";
            this.labelSettingsVisualisationTitle.Size = new System.Drawing.Size(159, 33);
            this.labelSettingsVisualisationTitle.TabIndex = 1;
            this.labelSettingsVisualisationTitle.Text = "Visualisation";
            // 
            // labelVisualisationSubTitleType
            // 
            this.labelVisualisationSubTitleType.AutoSize = true;
            this.labelVisualisationSubTitleType.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisualisationSubTitleType.Location = new System.Drawing.Point(24, 89);
            this.labelVisualisationSubTitleType.Margin = new System.Windows.Forms.Padding(24, 32, 0, 0);
            this.labelVisualisationSubTitleType.Name = "labelVisualisationSubTitleType";
            this.labelVisualisationSubTitleType.Size = new System.Drawing.Size(166, 26);
            this.labelVisualisationSubTitleType.TabIndex = 27;
            this.labelVisualisationSubTitleType.Text = "Visualisation Type";
            // 
            // labelVisualisationType
            // 
            this.labelVisualisationType.AutoSize = true;
            this.labelVisualisationType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisualisationType.Location = new System.Drawing.Point(32, 139);
            this.labelVisualisationType.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelVisualisationType.Name = "labelVisualisationType";
            this.labelVisualisationType.Size = new System.Drawing.Size(127, 19);
            this.labelVisualisationType.TabIndex = 28;
            this.labelVisualisationType.Text = "Visualisation Type";
            // 
            // comboBoxVisualisationType
            // 
            this.comboBoxVisualisationType.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxVisualisationType.FormattingEnabled = true;
            this.comboBoxVisualisationType.Items.AddRange(new object[] {
            "None",
            "Spectrum Lines",
            "Spectrum Peaks",
            "Spectrum Reverse Lines",
            "Spectrum Reverse Peaks",
            "Spectrum Center Lines",
            "Spectrum Center Peaks",
            "Spectrum Float Lines",
            "Spectrum Float Peaks",
            "Spectrum Circle Lines"});
            this.comboBoxVisualisationType.Location = new System.Drawing.Point(32, 166);
            this.comboBoxVisualisationType.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.comboBoxVisualisationType.Name = "comboBoxVisualisationType";
            this.comboBoxVisualisationType.Size = new System.Drawing.Size(408, 27);
            this.comboBoxVisualisationType.TabIndex = 29;
            this.comboBoxVisualisationType.SelectionChangeCommitted += new System.EventHandler(this.comboBoxVisualisationType_SelectionChangeCommitted);
            // 
            // labelVisualisationSize
            // 
            this.labelVisualisationSize.AutoSize = true;
            this.labelVisualisationSize.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisualisationSize.Location = new System.Drawing.Point(32, 201);
            this.labelVisualisationSize.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelVisualisationSize.Name = "labelVisualisationSize";
            this.labelVisualisationSize.Size = new System.Drawing.Size(122, 19);
            this.labelVisualisationSize.TabIndex = 44;
            this.labelVisualisationSize.Text = "Visualisation Size";
            // 
            // trackBarVisualisationSize
            // 
            this.trackBarVisualisationSize.Location = new System.Drawing.Point(32, 228);
            this.trackBarVisualisationSize.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.trackBarVisualisationSize.Maximum = 128;
            this.trackBarVisualisationSize.Minimum = 64;
            this.trackBarVisualisationSize.Name = "trackBarVisualisationSize";
            this.trackBarVisualisationSize.Size = new System.Drawing.Size(408, 45);
            this.trackBarVisualisationSize.TabIndex = 45;
            this.trackBarVisualisationSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVisualisationSize.Value = 128;
            this.trackBarVisualisationSize.Scroll += new System.EventHandler(this.trackBarVisualisationSize_Scroll);
            // 
            // labelVisualisationSubTitleLogo
            // 
            this.labelVisualisationSubTitleLogo.AutoSize = true;
            this.labelVisualisationSubTitleLogo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisualisationSubTitleLogo.Location = new System.Drawing.Point(24, 305);
            this.labelVisualisationSubTitleLogo.Margin = new System.Windows.Forms.Padding(24, 32, 0, 0);
            this.labelVisualisationSubTitleLogo.Name = "labelVisualisationSubTitleLogo";
            this.labelVisualisationSubTitleLogo.Size = new System.Drawing.Size(53, 26);
            this.labelVisualisationSubTitleLogo.TabIndex = 46;
            this.labelVisualisationSubTitleLogo.Text = "Logo";
            // 
            // labelVisualisationLogo
            // 
            this.labelVisualisationLogo.AutoSize = true;
            this.labelVisualisationLogo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisualisationLogo.Location = new System.Drawing.Point(32, 355);
            this.labelVisualisationLogo.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelVisualisationLogo.Name = "labelVisualisationLogo";
            this.labelVisualisationLogo.Size = new System.Drawing.Size(128, 19);
            this.labelVisualisationLogo.TabIndex = 47;
            this.labelVisualisationLogo.Text = "Visualisation Logo";
            // 
            // comboBoxVisualisationLogo
            // 
            this.comboBoxVisualisationLogo.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxVisualisationLogo.FormattingEnabled = true;
            this.comboBoxVisualisationLogo.Items.AddRange(new object[] {
            "None",
            "AnthraX Dark",
            "AnthraX Light"});
            this.comboBoxVisualisationLogo.Location = new System.Drawing.Point(32, 382);
            this.comboBoxVisualisationLogo.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.comboBoxVisualisationLogo.Name = "comboBoxVisualisationLogo";
            this.comboBoxVisualisationLogo.Size = new System.Drawing.Size(408, 27);
            this.comboBoxVisualisationLogo.TabIndex = 48;
            this.comboBoxVisualisationLogo.SelectionChangeCommitted += new System.EventHandler(this.comboBoxVisualisationLogo_SelectionChangeCommitted);
            // 
            // labelVisualisationSubTitleStyle
            // 
            this.labelVisualisationSubTitleStyle.AutoSize = true;
            this.labelVisualisationSubTitleStyle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisualisationSubTitleStyle.Location = new System.Drawing.Point(24, 441);
            this.labelVisualisationSubTitleStyle.Margin = new System.Windows.Forms.Padding(24, 32, 0, 0);
            this.labelVisualisationSubTitleStyle.Name = "labelVisualisationSubTitleStyle";
            this.labelVisualisationSubTitleStyle.Size = new System.Drawing.Size(168, 26);
            this.labelVisualisationSubTitleStyle.TabIndex = 30;
            this.labelVisualisationSubTitleStyle.Text = "Visualisation Style";
            // 
            // labelVisualisationColorScheme
            // 
            this.labelVisualisationColorScheme.AutoSize = true;
            this.labelVisualisationColorScheme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisualisationColorScheme.Location = new System.Drawing.Point(32, 491);
            this.labelVisualisationColorScheme.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelVisualisationColorScheme.Name = "labelVisualisationColorScheme";
            this.labelVisualisationColorScheme.Size = new System.Drawing.Size(185, 19);
            this.labelVisualisationColorScheme.TabIndex = 31;
            this.labelVisualisationColorScheme.Text = "Visualisation Color Scheme";
            // 
            // comboBoxVisualisationColorType
            // 
            this.comboBoxVisualisationColorType.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxVisualisationColorType.FormattingEnabled = true;
            this.comboBoxVisualisationColorType.Items.AddRange(new object[] {
            "Color",
            "Custom Color",
            "Rainbow Horizontal",
            "Rainbow Vertical"});
            this.comboBoxVisualisationColorType.Location = new System.Drawing.Point(32, 518);
            this.comboBoxVisualisationColorType.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.comboBoxVisualisationColorType.Name = "comboBoxVisualisationColorType";
            this.comboBoxVisualisationColorType.Size = new System.Drawing.Size(408, 27);
            this.comboBoxVisualisationColorType.TabIndex = 32;
            this.comboBoxVisualisationColorType.SelectionChangeCommitted += new System.EventHandler(this.comboBoxVisualisationColorType_SelectionChangeCommitted);
            // 
            // labelVisualisationColor
            // 
            this.labelVisualisationColor.AutoSize = true;
            this.labelVisualisationColor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisualisationColor.Location = new System.Drawing.Point(32, 553);
            this.labelVisualisationColor.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelVisualisationColor.Name = "labelVisualisationColor";
            this.labelVisualisationColor.Size = new System.Drawing.Size(131, 19);
            this.labelVisualisationColor.TabIndex = 33;
            this.labelVisualisationColor.Text = "Visualisation Color";
            // 
            // comboBoxVisualisationColor
            // 
            this.comboBoxVisualisationColor.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxVisualisationColor.FormattingEnabled = true;
            this.comboBoxVisualisationColor.Location = new System.Drawing.Point(32, 580);
            this.comboBoxVisualisationColor.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.comboBoxVisualisationColor.Name = "comboBoxVisualisationColor";
            this.comboBoxVisualisationColor.Size = new System.Drawing.Size(408, 27);
            this.comboBoxVisualisationColor.TabIndex = 34;
            this.comboBoxVisualisationColor.SelectionChangeCommitted += new System.EventHandler(this.comboBoxVisualisationColor_SelectionChangeCommitted);
            // 
            // labelVisualisationCustomColor
            // 
            this.labelVisualisationCustomColor.AutoSize = true;
            this.labelVisualisationCustomColor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisualisationCustomColor.Location = new System.Drawing.Point(32, 615);
            this.labelVisualisationCustomColor.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelVisualisationCustomColor.Name = "labelVisualisationCustomColor";
            this.labelVisualisationCustomColor.Size = new System.Drawing.Size(184, 19);
            this.labelVisualisationCustomColor.TabIndex = 36;
            this.labelVisualisationCustomColor.Text = "Visualisation Custom Color";
            // 
            // fLPanelVisualisationCustomColor
            // 
            this.fLPanelVisualisationCustomColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLPanelVisualisationCustomColor.Controls.Add(this.buttonVisualisationCustomColor);
            this.fLPanelVisualisationCustomColor.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPanelVisualisationCustomColor.Location = new System.Drawing.Point(32, 642);
            this.fLPanelVisualisationCustomColor.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.fLPanelVisualisationCustomColor.Name = "fLPanelVisualisationCustomColor";
            this.fLPanelVisualisationCustomColor.Size = new System.Drawing.Size(408, 38);
            this.fLPanelVisualisationCustomColor.TabIndex = 35;
            // 
            // buttonVisualisationCustomColor
            // 
            this.buttonVisualisationCustomColor.ForeColor = System.Drawing.Color.Black;
            this.buttonVisualisationCustomColor.Location = new System.Drawing.Point(274, 4);
            this.buttonVisualisationCustomColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVisualisationCustomColor.Name = "buttonVisualisationCustomColor";
            this.buttonVisualisationCustomColor.Size = new System.Drawing.Size(128, 28);
            this.buttonVisualisationCustomColor.TabIndex = 0;
            this.buttonVisualisationCustomColor.Text = "Select Custom Color";
            this.buttonVisualisationCustomColor.UseVisualStyleBackColor = true;
            this.buttonVisualisationCustomColor.Click += new System.EventHandler(this.buttonVisualisationCustomColor_Click);
            // 
            // labelVisualisationColorSpeed
            // 
            this.labelVisualisationColorSpeed.AutoSize = true;
            this.labelVisualisationColorSpeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisualisationColorSpeed.Location = new System.Drawing.Point(32, 688);
            this.labelVisualisationColorSpeed.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelVisualisationColorSpeed.Name = "labelVisualisationColorSpeed";
            this.labelVisualisationColorSpeed.Size = new System.Drawing.Size(285, 19);
            this.labelVisualisationColorSpeed.TabIndex = 49;
            this.labelVisualisationColorSpeed.Text = "Visualisation Rainbow Color change speed";
            // 
            // trackBarVisualisationColorSpeed
            // 
            this.trackBarVisualisationColorSpeed.Location = new System.Drawing.Point(32, 715);
            this.trackBarVisualisationColorSpeed.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.trackBarVisualisationColorSpeed.Maximum = 100;
            this.trackBarVisualisationColorSpeed.Name = "trackBarVisualisationColorSpeed";
            this.trackBarVisualisationColorSpeed.Size = new System.Drawing.Size(408, 45);
            this.trackBarVisualisationColorSpeed.TabIndex = 50;
            this.trackBarVisualisationColorSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVisualisationColorSpeed.Value = 10;
            this.trackBarVisualisationColorSpeed.Scroll += new System.EventHandler(this.trackBarVisualisationColorSpeed_Scroll);
            // 
            // labelVisualisationColorRainbow
            // 
            this.labelVisualisationColorRainbow.AutoSize = true;
            this.labelVisualisationColorRainbow.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisualisationColorRainbow.Location = new System.Drawing.Point(32, 768);
            this.labelVisualisationColorRainbow.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelVisualisationColorRainbow.Name = "labelVisualisationColorRainbow";
            this.labelVisualisationColorRainbow.Size = new System.Drawing.Size(259, 19);
            this.labelVisualisationColorRainbow.TabIndex = 51;
            this.labelVisualisationColorRainbow.Text = "Visualisation Rainbow Color frequency";
            // 
            // trackBarVisualisationColorRainbow
            // 
            this.trackBarVisualisationColorRainbow.Location = new System.Drawing.Point(32, 795);
            this.trackBarVisualisationColorRainbow.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.trackBarVisualisationColorRainbow.Maximum = 64;
            this.trackBarVisualisationColorRainbow.Minimum = 2;
            this.trackBarVisualisationColorRainbow.Name = "trackBarVisualisationColorRainbow";
            this.trackBarVisualisationColorRainbow.Size = new System.Drawing.Size(408, 45);
            this.trackBarVisualisationColorRainbow.TabIndex = 52;
            this.trackBarVisualisationColorRainbow.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVisualisationColorRainbow.Value = 16;
            this.trackBarVisualisationColorRainbow.Scroll += new System.EventHandler(this.trackBarVisualisationColorRainbow_Scroll);
            // 
            // checkBoxVisualisationTransparency
            // 
            this.checkBoxVisualisationTransparency.AutoSize = true;
            this.checkBoxVisualisationTransparency.Checked = true;
            this.checkBoxVisualisationTransparency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVisualisationTransparency.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkBoxVisualisationTransparency.Location = new System.Drawing.Point(32, 848);
            this.checkBoxVisualisationTransparency.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.checkBoxVisualisationTransparency.Name = "checkBoxVisualisationTransparency";
            this.checkBoxVisualisationTransparency.Size = new System.Drawing.Size(231, 23);
            this.checkBoxVisualisationTransparency.TabIndex = 41;
            this.checkBoxVisualisationTransparency.Text = "Use Transparency Visualisation";
            this.checkBoxVisualisationTransparency.UseVisualStyleBackColor = true;
            this.checkBoxVisualisationTransparency.CheckedChanged += new System.EventHandler(this.checkBoxVisualisationTransparency_CheckedChanged);
            // 
            // trackBarVisualisationTransparency
            // 
            this.trackBarVisualisationTransparency.Location = new System.Drawing.Point(32, 879);
            this.trackBarVisualisationTransparency.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.trackBarVisualisationTransparency.Maximum = 255;
            this.trackBarVisualisationTransparency.Name = "trackBarVisualisationTransparency";
            this.trackBarVisualisationTransparency.Size = new System.Drawing.Size(408, 45);
            this.trackBarVisualisationTransparency.TabIndex = 42;
            this.trackBarVisualisationTransparency.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVisualisationTransparency.Scroll += new System.EventHandler(this.trackBarVisualisationTransparency_Scroll);
            // 
            // labelVisualisationFill
            // 
            this.labelVisualisationFill.AutoSize = true;
            this.labelVisualisationFill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisualisationFill.Location = new System.Drawing.Point(32, 932);
            this.labelVisualisationFill.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelVisualisationFill.Name = "labelVisualisationFill";
            this.labelVisualisationFill.Size = new System.Drawing.Size(151, 19);
            this.labelVisualisationFill.TabIndex = 38;
            this.labelVisualisationFill.Text = "Visualisation Fill Style";
            // 
            // comboBoxVisualisationFill
            // 
            this.comboBoxVisualisationFill.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxVisualisationFill.FormattingEnabled = true;
            this.comboBoxVisualisationFill.Items.AddRange(new object[] {
            "All",
            "Border",
            "Fill"});
            this.comboBoxVisualisationFill.Location = new System.Drawing.Point(32, 959);
            this.comboBoxVisualisationFill.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.comboBoxVisualisationFill.Name = "comboBoxVisualisationFill";
            this.comboBoxVisualisationFill.Size = new System.Drawing.Size(408, 27);
            this.comboBoxVisualisationFill.TabIndex = 39;
            this.comboBoxVisualisationFill.SelectionChangeCommitted += new System.EventHandler(this.comboBoxVisualisationFill_SelectionChangeCommitted);
            // 
            // labelVisualisationSubTitleOptions
            // 
            this.labelVisualisationSubTitleOptions.AutoSize = true;
            this.labelVisualisationSubTitleOptions.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisualisationSubTitleOptions.Location = new System.Drawing.Point(24, 1018);
            this.labelVisualisationSubTitleOptions.Margin = new System.Windows.Forms.Padding(24, 32, 0, 0);
            this.labelVisualisationSubTitleOptions.Name = "labelVisualisationSubTitleOptions";
            this.labelVisualisationSubTitleOptions.Size = new System.Drawing.Size(192, 26);
            this.labelVisualisationSubTitleOptions.TabIndex = 37;
            this.labelVisualisationSubTitleOptions.Text = "Visualisation Options";
            // 
            // labelVisualisationSensitivity
            // 
            this.labelVisualisationSensitivity.AutoSize = true;
            this.labelVisualisationSensitivity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisualisationSensitivity.Location = new System.Drawing.Point(32, 1068);
            this.labelVisualisationSensitivity.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelVisualisationSensitivity.Name = "labelVisualisationSensitivity";
            this.labelVisualisationSensitivity.Size = new System.Drawing.Size(163, 19);
            this.labelVisualisationSensitivity.TabIndex = 40;
            this.labelVisualisationSensitivity.Text = "Visualisation Sensitivity";
            // 
            // trackBarVisualisationSensitivity
            // 
            this.trackBarVisualisationSensitivity.Location = new System.Drawing.Point(32, 1095);
            this.trackBarVisualisationSensitivity.Margin = new System.Windows.Forms.Padding(32, 8, 0, 32);
            this.trackBarVisualisationSensitivity.Maximum = 1024;
            this.trackBarVisualisationSensitivity.Minimum = 128;
            this.trackBarVisualisationSensitivity.Name = "trackBarVisualisationSensitivity";
            this.trackBarVisualisationSensitivity.Size = new System.Drawing.Size(408, 45);
            this.trackBarVisualisationSensitivity.TabIndex = 43;
            this.trackBarVisualisationSensitivity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVisualisationSensitivity.Value = 128;
            this.trackBarVisualisationSensitivity.Scroll += new System.EventHandler(this.trackBarVisualisationSensitivity_Scroll);
            // 
            // panelSettingsBorder
            // 
            this.panelSettingsBorder.BackColor = System.Drawing.Color.White;
            this.panelSettingsBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSettingsBorder.Location = new System.Drawing.Point(256, 0);
            this.panelSettingsBorder.Name = "panelSettingsBorder";
            this.panelSettingsBorder.Size = new System.Drawing.Size(1, 457);
            this.panelSettingsBorder.TabIndex = 0;
            // 
            // tLPanelSettingsMenu
            // 
            this.tLPanelSettingsMenu.AllowDrop = true;
            this.tLPanelSettingsMenu.BackColor = System.Drawing.Color.Black;
            this.tLPanelSettingsMenu.ColumnCount = 1;
            this.tLPanelSettingsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelSettingsMenu.Controls.Add(this.labelSettingsMenuTitle, 0, 1);
            this.tLPanelSettingsMenu.Controls.Add(this.treeViewSettingsMenu, 0, 2);
            this.tLPanelSettingsMenu.Controls.Add(this.buttonSettingsSave, 0, 3);
            this.tLPanelSettingsMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tLPanelSettingsMenu.Location = new System.Drawing.Point(0, 0);
            this.tLPanelSettingsMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tLPanelSettingsMenu.Name = "tLPanelSettingsMenu";
            this.tLPanelSettingsMenu.RowCount = 4;
            this.tLPanelSettingsMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tLPanelSettingsMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tLPanelSettingsMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelSettingsMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tLPanelSettingsMenu.Size = new System.Drawing.Size(256, 457);
            this.tLPanelSettingsMenu.TabIndex = 1;
            this.tLPanelSettingsMenu.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragDrop);
            this.tLPanelSettingsMenu.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragEnter);
            // 
            // labelSettingsMenuTitle
            // 
            this.labelSettingsMenuTitle.AutoSize = true;
            this.labelSettingsMenuTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelSettingsMenuTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSettingsMenuTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSettingsMenuTitle.ForeColor = System.Drawing.Color.White;
            this.labelSettingsMenuTitle.Location = new System.Drawing.Point(3, 16);
            this.labelSettingsMenuTitle.Name = "labelSettingsMenuTitle";
            this.labelSettingsMenuTitle.Size = new System.Drawing.Size(250, 48);
            this.labelSettingsMenuTitle.TabIndex = 2;
            this.labelSettingsMenuTitle.Text = "Settings";
            this.labelSettingsMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treeViewSettingsMenu
            // 
            this.treeViewSettingsMenu.BackColor = System.Drawing.Color.Black;
            this.treeViewSettingsMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewSettingsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewSettingsMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeViewSettingsMenu.ForeColor = System.Drawing.Color.White;
            this.treeViewSettingsMenu.ImageIndex = 0;
            this.treeViewSettingsMenu.ImageList = this.imageListSettingsMenu;
            this.treeViewSettingsMenu.Indent = 20;
            this.treeViewSettingsMenu.ItemHeight = 48;
            this.treeViewSettingsMenu.LineColor = System.Drawing.Color.White;
            this.treeViewSettingsMenu.Location = new System.Drawing.Point(0, 80);
            this.treeViewSettingsMenu.Margin = new System.Windows.Forms.Padding(0, 16, 0, 16);
            this.treeViewSettingsMenu.Name = "treeViewSettingsMenu";
            treeNode1.ImageIndex = 3;
            treeNode1.Name = "nodeGeneral";
            treeNode1.SelectedImageIndex = 3;
            treeNode1.Text = "General";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "nodeInformations";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Informations";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "nodePlayer";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Media Player";
            treeNode4.ImageIndex = 4;
            treeNode4.Name = "nodeSound";
            treeNode4.SelectedImageIndex = 4;
            treeNode4.Text = "Sound";
            treeNode5.ImageIndex = 5;
            treeNode5.Name = "nodeTheme";
            treeNode5.SelectedImageIndex = 5;
            treeNode5.Text = "Theme";
            treeNode6.ImageIndex = 6;
            treeNode6.Name = "nodeVisualisation";
            treeNode6.SelectedImageIndex = 6;
            treeNode6.Text = "Visualisation";
            this.treeViewSettingsMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeViewSettingsMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeViewSettingsMenu.SelectedImageIndex = 0;
            this.treeViewSettingsMenu.ShowRootLines = false;
            this.treeViewSettingsMenu.Size = new System.Drawing.Size(256, 313);
            this.treeViewSettingsMenu.TabIndex = 3;
            this.treeViewSettingsMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSettingsMenu_AfterSelect);
            // 
            // imageListSettingsMenu
            // 
            this.imageListSettingsMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSettingsMenu.ImageStream")));
            this.imageListSettingsMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSettingsMenu.Images.SetKeyName(0, "32_ArrowRight.png");
            this.imageListSettingsMenu.Images.SetKeyName(1, "32_Informations.png");
            this.imageListSettingsMenu.Images.SetKeyName(2, "32_Player.png");
            this.imageListSettingsMenu.Images.SetKeyName(3, "32_Settings.png");
            this.imageListSettingsMenu.Images.SetKeyName(4, "32_Sound.png");
            this.imageListSettingsMenu.Images.SetKeyName(5, "32_Theme.png");
            this.imageListSettingsMenu.Images.SetKeyName(6, "32_Visualisation.png");
            // 
            // buttonSettingsSave
            // 
            this.buttonSettingsSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSettingsSave.Location = new System.Drawing.Point(48, 419);
            this.buttonSettingsSave.Margin = new System.Windows.Forms.Padding(48, 10, 48, 10);
            this.buttonSettingsSave.Name = "buttonSettingsSave";
            this.buttonSettingsSave.Size = new System.Drawing.Size(160, 28);
            this.buttonSettingsSave.TabIndex = 4;
            this.buttonSettingsSave.Text = "Save Settings";
            this.buttonSettingsSave.UseVisualStyleBackColor = true;
            this.buttonSettingsSave.Click += new System.EventHandler(this.buttonSettingsSave_Click);
            // 
            // panelLibrary
            // 
            this.panelLibrary.Controls.Add(this.panelLibraryFiles);
            this.panelLibrary.Controls.Add(this.panelLibraryToolbar);
            this.panelLibrary.Controls.Add(this.panelLibraryMenubar);
            this.panelLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLibrary.Location = new System.Drawing.Point(56, 0);
            this.panelLibrary.Margin = new System.Windows.Forms.Padding(0);
            this.panelLibrary.Name = "panelLibrary";
            this.panelLibrary.Size = new System.Drawing.Size(828, 457);
            this.panelLibrary.TabIndex = 1;
            // 
            // panelLibraryFiles
            // 
            this.panelLibraryFiles.Controls.Add(this.listViewLibrary);
            this.panelLibraryFiles.Controls.Add(this.labelLibraryName);
            this.panelLibraryFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLibraryFiles.Location = new System.Drawing.Point(256, 96);
            this.panelLibraryFiles.Name = "panelLibraryFiles";
            this.panelLibraryFiles.Size = new System.Drawing.Size(572, 361);
            this.panelLibraryFiles.TabIndex = 9;
            // 
            // listViewLibrary
            // 
            this.listViewLibrary.AllowDrop = true;
            this.listViewLibrary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFileName,
            this.columnHeaderTitle,
            this.columnHeaderArtist,
            this.columnHeaderAlbum,
            this.columnHeaderTime});
            this.listViewLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLibrary.FullRowSelect = true;
            this.listViewLibrary.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.listViewLibrary.Location = new System.Drawing.Point(0, 32);
            this.listViewLibrary.Name = "listViewLibrary";
            this.listViewLibrary.Size = new System.Drawing.Size(572, 329);
            this.listViewLibrary.SmallImageList = this.imageListNowPlaying;
            this.listViewLibrary.TabIndex = 3;
            this.listViewLibrary.UseCompatibleStateImageBehavior = false;
            this.listViewLibrary.View = System.Windows.Forms.View.Details;
            this.listViewLibrary.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewLibrary_DragDrop);
            this.listViewLibrary.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewLibrary_DragEnter);
            this.listViewLibrary.DoubleClick += new System.EventHandler(this.listViewLibrary_DoubleClick);
            this.listViewLibrary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listViewLibrary_KeyPress);
            this.listViewLibrary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewLibrary_MouseDown);
            this.listViewLibrary.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewLibrary_MouseUp);
            // 
            // columnHeaderFileName
            // 
            this.columnHeaderFileName.Text = "File Name";
            this.columnHeaderFileName.Width = 192;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 96;
            // 
            // columnHeaderArtist
            // 
            this.columnHeaderArtist.Text = "Artist";
            this.columnHeaderArtist.Width = 96;
            // 
            // columnHeaderAlbum
            // 
            this.columnHeaderAlbum.Text = "Album";
            this.columnHeaderAlbum.Width = 96;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Time";
            this.columnHeaderTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderTime.Width = 64;
            // 
            // labelLibraryName
            // 
            this.labelLibraryName.BackColor = System.Drawing.Color.Transparent;
            this.labelLibraryName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLibraryName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLibraryName.ForeColor = System.Drawing.Color.White;
            this.labelLibraryName.Location = new System.Drawing.Point(0, 0);
            this.labelLibraryName.Margin = new System.Windows.Forms.Padding(0);
            this.labelLibraryName.Name = "labelLibraryName";
            this.labelLibraryName.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelLibraryName.Size = new System.Drawing.Size(572, 32);
            this.labelLibraryName.TabIndex = 8;
            this.labelLibraryName.Text = "Now Playing";
            this.labelLibraryName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLibraryToolbar
            // 
            this.panelLibraryToolbar.Controls.Add(this.tLPanelLibraryTools);
            this.panelLibraryToolbar.Controls.Add(this.treeViewLibraryPlaylists);
            this.panelLibraryToolbar.Controls.Add(this.labelLibraryInfo);
            this.panelLibraryToolbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLibraryToolbar.Location = new System.Drawing.Point(0, 96);
            this.panelLibraryToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelLibraryToolbar.Name = "panelLibraryToolbar";
            this.panelLibraryToolbar.Size = new System.Drawing.Size(256, 361);
            this.panelLibraryToolbar.TabIndex = 2;
            // 
            // tLPanelLibraryTools
            // 
            this.tLPanelLibraryTools.BackColor = System.Drawing.Color.Transparent;
            this.tLPanelLibraryTools.ColumnCount = 5;
            this.tLPanelLibraryTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPanelLibraryTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tLPanelLibraryTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tLPanelLibraryTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tLPanelLibraryTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPanelLibraryTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelLibraryTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelLibraryTools.Controls.Add(this.buttonLibraryRemovePlaylist, 3, 0);
            this.tLPanelLibraryTools.Controls.Add(this.buttonLibraryAddPlaylist, 1, 0);
            this.tLPanelLibraryTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tLPanelLibraryTools.Location = new System.Drawing.Point(0, 325);
            this.tLPanelLibraryTools.Margin = new System.Windows.Forms.Padding(0);
            this.tLPanelLibraryTools.Name = "tLPanelLibraryTools";
            this.tLPanelLibraryTools.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tLPanelLibraryTools.RowCount = 1;
            this.tLPanelLibraryTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelLibraryTools.Size = new System.Drawing.Size(256, 36);
            this.tLPanelLibraryTools.TabIndex = 5;
            // 
            // buttonLibraryRemovePlaylist
            // 
            this.buttonLibraryRemovePlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLibraryRemovePlaylist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonLibraryRemovePlaylist.FlatAppearance.BorderSize = 0;
            this.buttonLibraryRemovePlaylist.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonLibraryRemovePlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonLibraryRemovePlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonLibraryRemovePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibraryRemovePlaylist.ForeColor = System.Drawing.Color.White;
            this.buttonLibraryRemovePlaylist.Image = global::AnthraX.IconsNavigation._32_Remove;
            this.buttonLibraryRemovePlaylist.Location = new System.Drawing.Point(148, 2);
            this.buttonLibraryRemovePlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLibraryRemovePlaylist.Name = "buttonLibraryRemovePlaylist";
            this.buttonLibraryRemovePlaylist.Size = new System.Drawing.Size(32, 32);
            this.buttonLibraryRemovePlaylist.TabIndex = 1;
            this.buttonLibraryRemovePlaylist.UseVisualStyleBackColor = true;
            this.buttonLibraryRemovePlaylist.Click += new System.EventHandler(this.buttonLibraryRemovePlaylist_Click);
            // 
            // buttonLibraryAddPlaylist
            // 
            this.buttonLibraryAddPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLibraryAddPlaylist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonLibraryAddPlaylist.FlatAppearance.BorderSize = 0;
            this.buttonLibraryAddPlaylist.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonLibraryAddPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonLibraryAddPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonLibraryAddPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibraryAddPlaylist.ForeColor = System.Drawing.Color.White;
            this.buttonLibraryAddPlaylist.Image = global::AnthraX.IconsNavigation._32_Add;
            this.buttonLibraryAddPlaylist.Location = new System.Drawing.Point(76, 2);
            this.buttonLibraryAddPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLibraryAddPlaylist.Name = "buttonLibraryAddPlaylist";
            this.buttonLibraryAddPlaylist.Size = new System.Drawing.Size(32, 32);
            this.buttonLibraryAddPlaylist.TabIndex = 0;
            this.buttonLibraryAddPlaylist.UseVisualStyleBackColor = true;
            this.buttonLibraryAddPlaylist.Click += new System.EventHandler(this.buttonLibraryAddPlaylist_Click);
            // 
            // treeViewLibraryPlaylists
            // 
            this.treeViewLibraryPlaylists.AllowDrop = true;
            this.treeViewLibraryPlaylists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewLibraryPlaylists.ImageIndex = 0;
            this.treeViewLibraryPlaylists.ImageList = this.imageListLibraryMenu;
            this.treeViewLibraryPlaylists.Location = new System.Drawing.Point(0, 32);
            this.treeViewLibraryPlaylists.Name = "treeViewLibraryPlaylists";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "NodeNowPlaying";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Now Playing";
            this.treeViewLibraryPlaylists.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeViewLibraryPlaylists.SelectedImageIndex = 0;
            this.treeViewLibraryPlaylists.ShowLines = false;
            this.treeViewLibraryPlaylists.ShowPlusMinus = false;
            this.treeViewLibraryPlaylists.ShowRootLines = false;
            this.treeViewLibraryPlaylists.Size = new System.Drawing.Size(256, 329);
            this.treeViewLibraryPlaylists.TabIndex = 3;
            this.treeViewLibraryPlaylists.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewLibrary_DragDrop);
            this.treeViewLibraryPlaylists.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewLibrary_DragEnter);
            this.treeViewLibraryPlaylists.DoubleClick += new System.EventHandler(this.treeViewLibraryPlaylists_DoubleClick);
            // 
            // imageListLibraryMenu
            // 
            this.imageListLibraryMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLibraryMenu.ImageStream")));
            this.imageListLibraryMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLibraryMenu.Images.SetKeyName(0, "32_Black_Stereo.png");
            this.imageListLibraryMenu.Images.SetKeyName(1, "32_Black_Play.png");
            this.imageListLibraryMenu.Images.SetKeyName(2, "32_Black_List.png");
            this.imageListLibraryMenu.Images.SetKeyName(3, "32_White_Stereo.png");
            this.imageListLibraryMenu.Images.SetKeyName(4, "32_White_Play.png");
            this.imageListLibraryMenu.Images.SetKeyName(5, "32_White_List.png");
            // 
            // labelLibraryInfo
            // 
            this.labelLibraryInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelLibraryInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLibraryInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLibraryInfo.ForeColor = System.Drawing.Color.White;
            this.labelLibraryInfo.Location = new System.Drawing.Point(0, 0);
            this.labelLibraryInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelLibraryInfo.Name = "labelLibraryInfo";
            this.labelLibraryInfo.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelLibraryInfo.Size = new System.Drawing.Size(256, 32);
            this.labelLibraryInfo.TabIndex = 4;
            this.labelLibraryInfo.Text = "Playlists";
            this.labelLibraryInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLibraryMenubar
            // 
            this.panelLibraryMenubar.Controls.Add(this.tLPanelLibraryMenu);
            this.panelLibraryMenubar.Controls.Add(this.labelLibraryTitle);
            this.panelLibraryMenubar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLibraryMenubar.Location = new System.Drawing.Point(0, 0);
            this.panelLibraryMenubar.Margin = new System.Windows.Forms.Padding(0);
            this.panelLibraryMenubar.Name = "panelLibraryMenubar";
            this.panelLibraryMenubar.Size = new System.Drawing.Size(828, 96);
            this.panelLibraryMenubar.TabIndex = 1;
            // 
            // tLPanelLibraryMenu
            // 
            this.tLPanelLibraryMenu.BackColor = System.Drawing.Color.Transparent;
            this.tLPanelLibraryMenu.ColumnCount = 11;
            this.tLPanelLibraryMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelLibraryMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelLibraryMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelLibraryMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelLibraryMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelLibraryMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelLibraryMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelLibraryMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelLibraryMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelLibraryMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tLPanelLibraryMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tLPanelLibraryMenu.Controls.Add(this.buttonLibraryNowPlay, 4, 0);
            this.tLPanelLibraryMenu.Controls.Add(this.panelLibrarySort, 9, 0);
            this.tLPanelLibraryMenu.Controls.Add(this.buttonLibrarySort, 10, 0);
            this.tLPanelLibraryMenu.Controls.Add(this.buttonLibraryMoveTo, 7, 0);
            this.tLPanelLibraryMenu.Controls.Add(this.buttonLibraryRemove, 6, 0);
            this.tLPanelLibraryMenu.Controls.Add(this.buttonLibraryClear, 5, 0);
            this.tLPanelLibraryMenu.Controls.Add(this.buttonLibrarySaveAs, 3, 0);
            this.tLPanelLibraryMenu.Controls.Add(this.buttonLibrarySave, 2, 0);
            this.tLPanelLibraryMenu.Controls.Add(this.buttonLibraryOpen, 1, 0);
            this.tLPanelLibraryMenu.Controls.Add(this.buttonLibraryNew, 0, 0);
            this.tLPanelLibraryMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tLPanelLibraryMenu.Location = new System.Drawing.Point(0, 32);
            this.tLPanelLibraryMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tLPanelLibraryMenu.Name = "tLPanelLibraryMenu";
            this.tLPanelLibraryMenu.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tLPanelLibraryMenu.RowCount = 1;
            this.tLPanelLibraryMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelLibraryMenu.Size = new System.Drawing.Size(828, 64);
            this.tLPanelLibraryMenu.TabIndex = 1;
            // 
            // buttonLibraryNowPlay
            // 
            this.buttonLibraryNowPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLibraryNowPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonLibraryNowPlay.FlatAppearance.BorderSize = 0;
            this.buttonLibraryNowPlay.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonLibraryNowPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonLibraryNowPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonLibraryNowPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibraryNowPlay.ForeColor = System.Drawing.Color.White;
            this.buttonLibraryNowPlay.Image = global::AnthraX.IconsNavigation._32_Play;
            this.buttonLibraryNowPlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLibraryNowPlay.Location = new System.Drawing.Point(262, 2);
            this.buttonLibraryNowPlay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLibraryNowPlay.Name = "buttonLibraryNowPlay";
            this.buttonLibraryNowPlay.Size = new System.Drawing.Size(60, 60);
            this.buttonLibraryNowPlay.TabIndex = 9;
            this.buttonLibraryNowPlay.Text = "Play";
            this.buttonLibraryNowPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLibraryNowPlay.UseVisualStyleBackColor = true;
            this.buttonLibraryNowPlay.Click += new System.EventHandler(this.buttonLibraryNowPlay_Click);
            // 
            // panelLibrarySort
            // 
            this.panelLibrarySort.BackColor = System.Drawing.SystemColors.Window;
            this.panelLibrarySort.Controls.Add(this.comboBoxLibrarySort);
            this.panelLibrarySort.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLibrarySort.Location = new System.Drawing.Point(598, 30);
            this.panelLibrarySort.Margin = new System.Windows.Forms.Padding(2);
            this.panelLibrarySort.Name = "panelLibrarySort";
            this.panelLibrarySort.Padding = new System.Windows.Forms.Padding(2);
            this.panelLibrarySort.Size = new System.Drawing.Size(188, 32);
            this.panelLibrarySort.TabIndex = 6;
            // 
            // comboBoxLibrarySort
            // 
            this.comboBoxLibrarySort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxLibrarySort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLibrarySort.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxLibrarySort.FormattingEnabled = true;
            this.comboBoxLibrarySort.Items.AddRange(new object[] {
            "File Name",
            "File Path",
            "Title",
            "Album",
            "Artist"});
            this.comboBoxLibrarySort.Location = new System.Drawing.Point(2, 2);
            this.comboBoxLibrarySort.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxLibrarySort.Name = "comboBoxLibrarySort";
            this.comboBoxLibrarySort.Size = new System.Drawing.Size(184, 27);
            this.comboBoxLibrarySort.TabIndex = 1;
            this.comboBoxLibrarySort.Text = "File Name";
            // 
            // buttonLibrarySort
            // 
            this.buttonLibrarySort.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLibrarySort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonLibrarySort.FlatAppearance.BorderSize = 0;
            this.buttonLibrarySort.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonLibrarySort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonLibrarySort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonLibrarySort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibrarySort.ForeColor = System.Drawing.Color.White;
            this.buttonLibrarySort.Image = global::AnthraX.IconsNavigation._32_Sort;
            this.buttonLibrarySort.Location = new System.Drawing.Point(790, 30);
            this.buttonLibrarySort.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLibrarySort.Name = "buttonLibrarySort";
            this.buttonLibrarySort.Size = new System.Drawing.Size(32, 32);
            this.buttonLibrarySort.TabIndex = 5;
            this.buttonLibrarySort.UseVisualStyleBackColor = true;
            this.buttonLibrarySort.Click += new System.EventHandler(this.buttonLibrarySort_Click);
            // 
            // buttonLibraryMoveTo
            // 
            this.buttonLibraryMoveTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLibraryMoveTo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonLibraryMoveTo.FlatAppearance.BorderSize = 0;
            this.buttonLibraryMoveTo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonLibraryMoveTo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonLibraryMoveTo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonLibraryMoveTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibraryMoveTo.ForeColor = System.Drawing.Color.White;
            this.buttonLibraryMoveTo.Image = global::AnthraX.IconsNavigation._32_MoveTo;
            this.buttonLibraryMoveTo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLibraryMoveTo.Location = new System.Drawing.Point(454, 2);
            this.buttonLibraryMoveTo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLibraryMoveTo.Name = "buttonLibraryMoveTo";
            this.buttonLibraryMoveTo.Size = new System.Drawing.Size(60, 60);
            this.buttonLibraryMoveTo.TabIndex = 4;
            this.buttonLibraryMoveTo.Text = "Move to";
            this.buttonLibraryMoveTo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLibraryMoveTo.UseVisualStyleBackColor = true;
            this.buttonLibraryMoveTo.Click += new System.EventHandler(this.buttonLibraryMoveTo_Click);
            // 
            // buttonLibraryRemove
            // 
            this.buttonLibraryRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLibraryRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonLibraryRemove.FlatAppearance.BorderSize = 0;
            this.buttonLibraryRemove.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonLibraryRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonLibraryRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonLibraryRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibraryRemove.ForeColor = System.Drawing.Color.White;
            this.buttonLibraryRemove.Image = global::AnthraX.IconsNavigation._32_Delete;
            this.buttonLibraryRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLibraryRemove.Location = new System.Drawing.Point(390, 2);
            this.buttonLibraryRemove.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLibraryRemove.Name = "buttonLibraryRemove";
            this.buttonLibraryRemove.Size = new System.Drawing.Size(60, 60);
            this.buttonLibraryRemove.TabIndex = 3;
            this.buttonLibraryRemove.Text = "Delete";
            this.buttonLibraryRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLibraryRemove.UseVisualStyleBackColor = true;
            this.buttonLibraryRemove.Click += new System.EventHandler(this.buttonLibraryRemove_Click);
            // 
            // buttonLibraryClear
            // 
            this.buttonLibraryClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLibraryClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonLibraryClear.FlatAppearance.BorderSize = 0;
            this.buttonLibraryClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonLibraryClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonLibraryClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonLibraryClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibraryClear.ForeColor = System.Drawing.Color.White;
            this.buttonLibraryClear.Image = global::AnthraX.IconsNavigation._32_Clear;
            this.buttonLibraryClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLibraryClear.Location = new System.Drawing.Point(326, 2);
            this.buttonLibraryClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLibraryClear.Name = "buttonLibraryClear";
            this.buttonLibraryClear.Size = new System.Drawing.Size(60, 60);
            this.buttonLibraryClear.TabIndex = 2;
            this.buttonLibraryClear.Text = "Clear";
            this.buttonLibraryClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLibraryClear.UseVisualStyleBackColor = true;
            this.buttonLibraryClear.Click += new System.EventHandler(this.buttonLibraryClear_Click);
            // 
            // buttonLibrarySaveAs
            // 
            this.buttonLibrarySaveAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLibrarySaveAs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonLibrarySaveAs.FlatAppearance.BorderSize = 0;
            this.buttonLibrarySaveAs.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonLibrarySaveAs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonLibrarySaveAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonLibrarySaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibrarySaveAs.ForeColor = System.Drawing.Color.White;
            this.buttonLibrarySaveAs.Image = global::AnthraX.IconsNavigation._32_Save;
            this.buttonLibrarySaveAs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLibrarySaveAs.Location = new System.Drawing.Point(198, 2);
            this.buttonLibrarySaveAs.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLibrarySaveAs.Name = "buttonLibrarySaveAs";
            this.buttonLibrarySaveAs.Size = new System.Drawing.Size(60, 60);
            this.buttonLibrarySaveAs.TabIndex = 7;
            this.buttonLibrarySaveAs.Text = "Save As";
            this.buttonLibrarySaveAs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLibrarySaveAs.UseVisualStyleBackColor = true;
            this.buttonLibrarySaveAs.Click += new System.EventHandler(this.buttonLibrarySaveAs_Click);
            // 
            // buttonLibrarySave
            // 
            this.buttonLibrarySave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLibrarySave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonLibrarySave.FlatAppearance.BorderSize = 0;
            this.buttonLibrarySave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonLibrarySave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonLibrarySave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonLibrarySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibrarySave.ForeColor = System.Drawing.Color.White;
            this.buttonLibrarySave.Image = global::AnthraX.IconsNavigation._32_Save;
            this.buttonLibrarySave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLibrarySave.Location = new System.Drawing.Point(134, 2);
            this.buttonLibrarySave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLibrarySave.Name = "buttonLibrarySave";
            this.buttonLibrarySave.Size = new System.Drawing.Size(60, 60);
            this.buttonLibrarySave.TabIndex = 1;
            this.buttonLibrarySave.Text = "Save";
            this.buttonLibrarySave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLibrarySave.UseVisualStyleBackColor = true;
            this.buttonLibrarySave.Click += new System.EventHandler(this.buttonLibrarySave_Click);
            // 
            // buttonLibraryOpen
            // 
            this.buttonLibraryOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLibraryOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonLibraryOpen.FlatAppearance.BorderSize = 0;
            this.buttonLibraryOpen.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonLibraryOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonLibraryOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonLibraryOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibraryOpen.ForeColor = System.Drawing.Color.White;
            this.buttonLibraryOpen.Image = global::AnthraX.IconsNavigation._32_Open;
            this.buttonLibraryOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLibraryOpen.Location = new System.Drawing.Point(70, 2);
            this.buttonLibraryOpen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLibraryOpen.Name = "buttonLibraryOpen";
            this.buttonLibraryOpen.Size = new System.Drawing.Size(60, 60);
            this.buttonLibraryOpen.TabIndex = 0;
            this.buttonLibraryOpen.Text = "Open";
            this.buttonLibraryOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLibraryOpen.UseVisualStyleBackColor = true;
            this.buttonLibraryOpen.Click += new System.EventHandler(this.buttonLibraryOpen_Click);
            // 
            // buttonLibraryNew
            // 
            this.buttonLibraryNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLibraryNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonLibraryNew.FlatAppearance.BorderSize = 0;
            this.buttonLibraryNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonLibraryNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonLibraryNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonLibraryNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibraryNew.ForeColor = System.Drawing.Color.White;
            this.buttonLibraryNew.Image = global::AnthraX.IconsNavigation._32_NewFile;
            this.buttonLibraryNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLibraryNew.Location = new System.Drawing.Point(6, 2);
            this.buttonLibraryNew.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLibraryNew.Name = "buttonLibraryNew";
            this.buttonLibraryNew.Size = new System.Drawing.Size(60, 60);
            this.buttonLibraryNew.TabIndex = 8;
            this.buttonLibraryNew.Text = "New";
            this.buttonLibraryNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLibraryNew.UseVisualStyleBackColor = true;
            this.buttonLibraryNew.Click += new System.EventHandler(this.buttonLibraryNew_Click);
            // 
            // labelLibraryTitle
            // 
            this.labelLibraryTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelLibraryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLibraryTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLibraryTitle.ForeColor = System.Drawing.Color.White;
            this.labelLibraryTitle.Location = new System.Drawing.Point(0, 0);
            this.labelLibraryTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelLibraryTitle.Name = "labelLibraryTitle";
            this.labelLibraryTitle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelLibraryTitle.Size = new System.Drawing.Size(828, 32);
            this.labelLibraryTitle.TabIndex = 0;
            this.labelLibraryTitle.Text = "Library";
            this.labelLibraryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelEqualizer
            // 
            this.panelEqualizer.Controls.Add(this.fLPanelEffects);
            this.panelEqualizer.Controls.Add(this.tLPanelEqualizer);
            this.panelEqualizer.Controls.Add(this.panelEqualizerPresetName);
            this.panelEqualizer.Controls.Add(this.tLPanelEqualizerStatusbar);
            this.panelEqualizer.Controls.Add(this.panelEqualizerToolbar);
            this.panelEqualizer.Controls.Add(this.panelEqualizerTitleBar);
            this.panelEqualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEqualizer.Location = new System.Drawing.Point(56, 0);
            this.panelEqualizer.Margin = new System.Windows.Forms.Padding(0);
            this.panelEqualizer.Name = "panelEqualizer";
            this.panelEqualizer.Size = new System.Drawing.Size(828, 457);
            this.panelEqualizer.TabIndex = 3;
            // 
            // fLPanelEffects
            // 
            this.fLPanelEffects.AutoScroll = true;
            this.fLPanelEffects.Controls.Add(this.labelEffectsTitle);
            this.fLPanelEffects.Controls.Add(this.labelEffectsAmplification);
            this.fLPanelEffects.Controls.Add(this.trackBarEffectsAmplification);
            this.fLPanelEffects.Controls.Add(this.panelEffectsAmplification);
            this.fLPanelEffects.Controls.Add(this.checkBoxEffectsSoftSaturation);
            this.fLPanelEffects.Controls.Add(this.labelEffectsSaturation);
            this.fLPanelEffects.Controls.Add(this.trackBarEffectsSaturation);
            this.fLPanelEffects.Controls.Add(this.labelEffectsSaturationDepth);
            this.fLPanelEffects.Controls.Add(this.trackBarEffectsSaturationDepth);
            this.fLPanelEffects.Controls.Add(this.checkBoxEffectsStereoEnhancer);
            this.fLPanelEffects.Controls.Add(this.labelEffectsStereoEnhancerWide);
            this.fLPanelEffects.Controls.Add(this.trackBarEffectsStereoEnhancerWide);
            this.fLPanelEffects.Controls.Add(this.labelEffectsStereoEnhancerDryWet);
            this.fLPanelEffects.Controls.Add(this.trackBarEffectsStereoEnhancerDryWet);
            this.fLPanelEffects.Controls.Add(this.checkBoxEffectsIIRDelay);
            this.fLPanelEffects.Controls.Add(this.labelEffectsIIRDelay);
            this.fLPanelEffects.Controls.Add(this.trackBarEffectsIIRDelay);
            this.fLPanelEffects.Controls.Add(this.labelEffectsIIRDelayDryWet);
            this.fLPanelEffects.Controls.Add(this.trackBarEffectsIIRDelayDryWet);
            this.fLPanelEffects.Controls.Add(this.labelEffectsIIRDelayFeedback);
            this.fLPanelEffects.Controls.Add(this.trackBarEffectsIIRDelayFeedback);
            this.fLPanelEffects.Controls.Add(this.checkBoxEffectsEcho);
            this.fLPanelEffects.Controls.Add(this.trackBarEffectsEcho);
            this.fLPanelEffects.Controls.Add(this.checkBoxEffectsReverb);
            this.fLPanelEffects.Controls.Add(this.trackBarEffectsReverb);
            this.fLPanelEffects.Controls.Add(this.checkBoxEffectsChorus);
            this.fLPanelEffects.Controls.Add(this.trackBarEffectsChorus);
            this.fLPanelEffects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPanelEffects.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLPanelEffects.Location = new System.Drawing.Point(256, 80);
            this.fLPanelEffects.Margin = new System.Windows.Forms.Padding(0);
            this.fLPanelEffects.Name = "fLPanelEffects";
            this.fLPanelEffects.Size = new System.Drawing.Size(572, 341);
            this.fLPanelEffects.TabIndex = 6;
            this.fLPanelEffects.WrapContents = false;
            // 
            // labelEffectsTitle
            // 
            this.labelEffectsTitle.AutoSize = true;
            this.labelEffectsTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEffectsTitle.ForeColor = System.Drawing.Color.White;
            this.labelEffectsTitle.Location = new System.Drawing.Point(24, 24);
            this.labelEffectsTitle.Margin = new System.Windows.Forms.Padding(24, 24, 0, 0);
            this.labelEffectsTitle.Name = "labelEffectsTitle";
            this.labelEffectsTitle.Size = new System.Drawing.Size(164, 33);
            this.labelEffectsTitle.TabIndex = 2;
            this.labelEffectsTitle.Text = "Sound Effects";
            // 
            // labelEffectsAmplification
            // 
            this.labelEffectsAmplification.AutoSize = true;
            this.labelEffectsAmplification.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEffectsAmplification.ForeColor = System.Drawing.Color.White;
            this.labelEffectsAmplification.Location = new System.Drawing.Point(32, 81);
            this.labelEffectsAmplification.Margin = new System.Windows.Forms.Padding(32, 24, 32, 0);
            this.labelEffectsAmplification.Name = "labelEffectsAmplification";
            this.labelEffectsAmplification.Size = new System.Drawing.Size(94, 19);
            this.labelEffectsAmplification.TabIndex = 45;
            this.labelEffectsAmplification.Text = "Amplification";
            // 
            // trackBarEffectsAmplification
            // 
            this.trackBarEffectsAmplification.Location = new System.Drawing.Point(32, 108);
            this.trackBarEffectsAmplification.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.trackBarEffectsAmplification.Maximum = 16;
            this.trackBarEffectsAmplification.Minimum = -16;
            this.trackBarEffectsAmplification.Name = "trackBarEffectsAmplification";
            this.trackBarEffectsAmplification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarEffectsAmplification.Size = new System.Drawing.Size(408, 45);
            this.trackBarEffectsAmplification.TabIndex = 46;
            this.trackBarEffectsAmplification.Scroll += new System.EventHandler(this.trackBarEffectsAmplification_Scroll);
            // 
            // panelEffectsAmplification
            // 
            this.panelEffectsAmplification.Controls.Add(this.labelEffectsAmplificationMax);
            this.panelEffectsAmplification.Controls.Add(this.labelEffectsAmplificationMin);
            this.panelEffectsAmplification.Location = new System.Drawing.Point(32, 153);
            this.panelEffectsAmplification.Margin = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.panelEffectsAmplification.Name = "panelEffectsAmplification";
            this.panelEffectsAmplification.Size = new System.Drawing.Size(409, 24);
            this.panelEffectsAmplification.TabIndex = 47;
            // 
            // labelEffectsAmplificationMax
            // 
            this.labelEffectsAmplificationMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelEffectsAmplificationMax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEffectsAmplificationMax.ForeColor = System.Drawing.Color.White;
            this.labelEffectsAmplificationMax.Location = new System.Drawing.Point(345, 0);
            this.labelEffectsAmplificationMax.Margin = new System.Windows.Forms.Padding(0);
            this.labelEffectsAmplificationMax.Name = "labelEffectsAmplificationMax";
            this.labelEffectsAmplificationMax.Size = new System.Drawing.Size(64, 24);
            this.labelEffectsAmplificationMax.TabIndex = 47;
            this.labelEffectsAmplificationMax.Text = "16 dB";
            this.labelEffectsAmplificationMax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelEffectsAmplificationMin
            // 
            this.labelEffectsAmplificationMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelEffectsAmplificationMin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEffectsAmplificationMin.ForeColor = System.Drawing.Color.White;
            this.labelEffectsAmplificationMin.Location = new System.Drawing.Point(0, 0);
            this.labelEffectsAmplificationMin.Margin = new System.Windows.Forms.Padding(0);
            this.labelEffectsAmplificationMin.Name = "labelEffectsAmplificationMin";
            this.labelEffectsAmplificationMin.Size = new System.Drawing.Size(64, 24);
            this.labelEffectsAmplificationMin.TabIndex = 46;
            this.labelEffectsAmplificationMin.Text = "-16 dB";
            // 
            // checkBoxEffectsSoftSaturation
            // 
            this.checkBoxEffectsSoftSaturation.AutoSize = true;
            this.checkBoxEffectsSoftSaturation.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkBoxEffectsSoftSaturation.ForeColor = System.Drawing.Color.White;
            this.checkBoxEffectsSoftSaturation.Location = new System.Drawing.Point(32, 209);
            this.checkBoxEffectsSoftSaturation.Margin = new System.Windows.Forms.Padding(32, 32, 32, 0);
            this.checkBoxEffectsSoftSaturation.Name = "checkBoxEffectsSoftSaturation";
            this.checkBoxEffectsSoftSaturation.Size = new System.Drawing.Size(123, 23);
            this.checkBoxEffectsSoftSaturation.TabIndex = 48;
            this.checkBoxEffectsSoftSaturation.Text = "Soft Saturation";
            this.checkBoxEffectsSoftSaturation.UseVisualStyleBackColor = true;
            this.checkBoxEffectsSoftSaturation.CheckedChanged += new System.EventHandler(this.checkBoxEffectsSoftSaturation_CheckedChanged);
            // 
            // labelEffectsSaturation
            // 
            this.labelEffectsSaturation.AutoSize = true;
            this.labelEffectsSaturation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEffectsSaturation.ForeColor = System.Drawing.Color.White;
            this.labelEffectsSaturation.Location = new System.Drawing.Point(32, 240);
            this.labelEffectsSaturation.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelEffectsSaturation.Name = "labelEffectsSaturation";
            this.labelEffectsSaturation.Size = new System.Drawing.Size(75, 19);
            this.labelEffectsSaturation.TabIndex = 49;
            this.labelEffectsSaturation.Text = "Saturation";
            // 
            // trackBarEffectsSaturation
            // 
            this.trackBarEffectsSaturation.Location = new System.Drawing.Point(32, 267);
            this.trackBarEffectsSaturation.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.trackBarEffectsSaturation.Maximum = 100;
            this.trackBarEffectsSaturation.Name = "trackBarEffectsSaturation";
            this.trackBarEffectsSaturation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarEffectsSaturation.Size = new System.Drawing.Size(408, 45);
            this.trackBarEffectsSaturation.TabIndex = 50;
            this.trackBarEffectsSaturation.TickFrequency = 10;
            this.trackBarEffectsSaturation.Value = 50;
            this.trackBarEffectsSaturation.Scroll += new System.EventHandler(this.trackBarEffectsSaturation_Scroll);
            // 
            // labelEffectsSaturationDepth
            // 
            this.labelEffectsSaturationDepth.AutoSize = true;
            this.labelEffectsSaturationDepth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEffectsSaturationDepth.ForeColor = System.Drawing.Color.White;
            this.labelEffectsSaturationDepth.Location = new System.Drawing.Point(32, 312);
            this.labelEffectsSaturationDepth.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.labelEffectsSaturationDepth.Name = "labelEffectsSaturationDepth";
            this.labelEffectsSaturationDepth.Size = new System.Drawing.Size(48, 19);
            this.labelEffectsSaturationDepth.TabIndex = 51;
            this.labelEffectsSaturationDepth.Text = "Depth";
            // 
            // trackBarEffectsSaturationDepth
            // 
            this.trackBarEffectsSaturationDepth.Location = new System.Drawing.Point(32, 339);
            this.trackBarEffectsSaturationDepth.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.trackBarEffectsSaturationDepth.Maximum = 100;
            this.trackBarEffectsSaturationDepth.Name = "trackBarEffectsSaturationDepth";
            this.trackBarEffectsSaturationDepth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarEffectsSaturationDepth.Size = new System.Drawing.Size(408, 45);
            this.trackBarEffectsSaturationDepth.TabIndex = 52;
            this.trackBarEffectsSaturationDepth.TickFrequency = 10;
            this.trackBarEffectsSaturationDepth.Value = 50;
            this.trackBarEffectsSaturationDepth.Scroll += new System.EventHandler(this.trackBarEffectsSaturationDepth_Scroll);
            // 
            // checkBoxEffectsStereoEnhancer
            // 
            this.checkBoxEffectsStereoEnhancer.AutoSize = true;
            this.checkBoxEffectsStereoEnhancer.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkBoxEffectsStereoEnhancer.ForeColor = System.Drawing.Color.White;
            this.checkBoxEffectsStereoEnhancer.Location = new System.Drawing.Point(32, 400);
            this.checkBoxEffectsStereoEnhancer.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.checkBoxEffectsStereoEnhancer.Name = "checkBoxEffectsStereoEnhancer";
            this.checkBoxEffectsStereoEnhancer.Size = new System.Drawing.Size(133, 23);
            this.checkBoxEffectsStereoEnhancer.TabIndex = 53;
            this.checkBoxEffectsStereoEnhancer.Text = "Stereo Enhancer";
            this.checkBoxEffectsStereoEnhancer.UseVisualStyleBackColor = true;
            this.checkBoxEffectsStereoEnhancer.CheckedChanged += new System.EventHandler(this.checkBoxEffectsStereoEnhancer_CheckedChanged);
            // 
            // labelEffectsStereoEnhancerWide
            // 
            this.labelEffectsStereoEnhancerWide.AutoSize = true;
            this.labelEffectsStereoEnhancerWide.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEffectsStereoEnhancerWide.ForeColor = System.Drawing.Color.White;
            this.labelEffectsStereoEnhancerWide.Location = new System.Drawing.Point(32, 431);
            this.labelEffectsStereoEnhancerWide.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelEffectsStereoEnhancerWide.Name = "labelEffectsStereoEnhancerWide";
            this.labelEffectsStereoEnhancerWide.Size = new System.Drawing.Size(43, 19);
            this.labelEffectsStereoEnhancerWide.TabIndex = 54;
            this.labelEffectsStereoEnhancerWide.Text = "Wide";
            // 
            // trackBarEffectsStereoEnhancerWide
            // 
            this.trackBarEffectsStereoEnhancerWide.Location = new System.Drawing.Point(32, 458);
            this.trackBarEffectsStereoEnhancerWide.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.trackBarEffectsStereoEnhancerWide.Maximum = 900;
            this.trackBarEffectsStereoEnhancerWide.Name = "trackBarEffectsStereoEnhancerWide";
            this.trackBarEffectsStereoEnhancerWide.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarEffectsStereoEnhancerWide.Size = new System.Drawing.Size(408, 45);
            this.trackBarEffectsStereoEnhancerWide.TabIndex = 55;
            this.trackBarEffectsStereoEnhancerWide.TickFrequency = 90;
            this.trackBarEffectsStereoEnhancerWide.Value = 300;
            this.trackBarEffectsStereoEnhancerWide.Scroll += new System.EventHandler(this.trackBarEffectsStereoEnhancerWide_Scroll);
            // 
            // labelEffectsStereoEnhancerDryWet
            // 
            this.labelEffectsStereoEnhancerDryWet.AutoSize = true;
            this.labelEffectsStereoEnhancerDryWet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEffectsStereoEnhancerDryWet.ForeColor = System.Drawing.Color.White;
            this.labelEffectsStereoEnhancerDryWet.Location = new System.Drawing.Point(32, 503);
            this.labelEffectsStereoEnhancerDryWet.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.labelEffectsStereoEnhancerDryWet.Name = "labelEffectsStereoEnhancerDryWet";
            this.labelEffectsStereoEnhancerDryWet.Size = new System.Drawing.Size(71, 19);
            this.labelEffectsStereoEnhancerDryWet.TabIndex = 56;
            this.labelEffectsStereoEnhancerDryWet.Text = "Dry / Wet";
            // 
            // trackBarEffectsStereoEnhancerDryWet
            // 
            this.trackBarEffectsStereoEnhancerDryWet.Location = new System.Drawing.Point(32, 530);
            this.trackBarEffectsStereoEnhancerDryWet.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.trackBarEffectsStereoEnhancerDryWet.Maximum = 100;
            this.trackBarEffectsStereoEnhancerDryWet.Name = "trackBarEffectsStereoEnhancerDryWet";
            this.trackBarEffectsStereoEnhancerDryWet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarEffectsStereoEnhancerDryWet.Size = new System.Drawing.Size(408, 45);
            this.trackBarEffectsStereoEnhancerDryWet.TabIndex = 57;
            this.trackBarEffectsStereoEnhancerDryWet.TickFrequency = 10;
            this.trackBarEffectsStereoEnhancerDryWet.Value = 70;
            this.trackBarEffectsStereoEnhancerDryWet.Scroll += new System.EventHandler(this.trackBarEffectsStereoEnhancerDryWet_Scroll);
            // 
            // checkBoxEffectsIIRDelay
            // 
            this.checkBoxEffectsIIRDelay.AutoSize = true;
            this.checkBoxEffectsIIRDelay.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkBoxEffectsIIRDelay.ForeColor = System.Drawing.Color.White;
            this.checkBoxEffectsIIRDelay.Location = new System.Drawing.Point(32, 591);
            this.checkBoxEffectsIIRDelay.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.checkBoxEffectsIIRDelay.Name = "checkBoxEffectsIIRDelay";
            this.checkBoxEffectsIIRDelay.Size = new System.Drawing.Size(273, 23);
            this.checkBoxEffectsIIRDelay.TabIndex = 58;
            this.checkBoxEffectsIIRDelay.Text = "Infinite Impulse Response Delay Filter";
            this.checkBoxEffectsIIRDelay.UseVisualStyleBackColor = true;
            this.checkBoxEffectsIIRDelay.CheckedChanged += new System.EventHandler(this.checkBoxEffectsIIRDelay_CheckedChanged);
            // 
            // labelEffectsIIRDelay
            // 
            this.labelEffectsIIRDelay.AutoSize = true;
            this.labelEffectsIIRDelay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEffectsIIRDelay.ForeColor = System.Drawing.Color.White;
            this.labelEffectsIIRDelay.Location = new System.Drawing.Point(32, 622);
            this.labelEffectsIIRDelay.Margin = new System.Windows.Forms.Padding(32, 8, 32, 0);
            this.labelEffectsIIRDelay.Name = "labelEffectsIIRDelay";
            this.labelEffectsIIRDelay.Size = new System.Drawing.Size(46, 19);
            this.labelEffectsIIRDelay.TabIndex = 59;
            this.labelEffectsIIRDelay.Text = "Delay";
            // 
            // trackBarEffectsIIRDelay
            // 
            this.trackBarEffectsIIRDelay.Location = new System.Drawing.Point(32, 649);
            this.trackBarEffectsIIRDelay.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.trackBarEffectsIIRDelay.Maximum = 88200;
            this.trackBarEffectsIIRDelay.Name = "trackBarEffectsIIRDelay";
            this.trackBarEffectsIIRDelay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarEffectsIIRDelay.Size = new System.Drawing.Size(408, 45);
            this.trackBarEffectsIIRDelay.TabIndex = 60;
            this.trackBarEffectsIIRDelay.TickFrequency = 10000;
            this.trackBarEffectsIIRDelay.Value = 24576;
            this.trackBarEffectsIIRDelay.Scroll += new System.EventHandler(this.trackBarEffectsIIRDelay_Scroll);
            // 
            // labelEffectsIIRDelayDryWet
            // 
            this.labelEffectsIIRDelayDryWet.AutoSize = true;
            this.labelEffectsIIRDelayDryWet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEffectsIIRDelayDryWet.ForeColor = System.Drawing.Color.White;
            this.labelEffectsIIRDelayDryWet.Location = new System.Drawing.Point(32, 694);
            this.labelEffectsIIRDelayDryWet.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.labelEffectsIIRDelayDryWet.Name = "labelEffectsIIRDelayDryWet";
            this.labelEffectsIIRDelayDryWet.Size = new System.Drawing.Size(71, 19);
            this.labelEffectsIIRDelayDryWet.TabIndex = 61;
            this.labelEffectsIIRDelayDryWet.Text = "Dry / Wet";
            // 
            // trackBarEffectsIIRDelayDryWet
            // 
            this.trackBarEffectsIIRDelayDryWet.Location = new System.Drawing.Point(32, 721);
            this.trackBarEffectsIIRDelayDryWet.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.trackBarEffectsIIRDelayDryWet.Maximum = 100;
            this.trackBarEffectsIIRDelayDryWet.Name = "trackBarEffectsIIRDelayDryWet";
            this.trackBarEffectsIIRDelayDryWet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarEffectsIIRDelayDryWet.Size = new System.Drawing.Size(408, 45);
            this.trackBarEffectsIIRDelayDryWet.TabIndex = 62;
            this.trackBarEffectsIIRDelayDryWet.TickFrequency = 10;
            this.trackBarEffectsIIRDelayDryWet.Value = 50;
            this.trackBarEffectsIIRDelayDryWet.Scroll += new System.EventHandler(this.trackBarEffectsIIRDelayDryWet_Scroll);
            // 
            // labelEffectsIIRDelayFeedback
            // 
            this.labelEffectsIIRDelayFeedback.AutoSize = true;
            this.labelEffectsIIRDelayFeedback.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEffectsIIRDelayFeedback.ForeColor = System.Drawing.Color.White;
            this.labelEffectsIIRDelayFeedback.Location = new System.Drawing.Point(32, 766);
            this.labelEffectsIIRDelayFeedback.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.labelEffectsIIRDelayFeedback.Name = "labelEffectsIIRDelayFeedback";
            this.labelEffectsIIRDelayFeedback.Size = new System.Drawing.Size(70, 19);
            this.labelEffectsIIRDelayFeedback.TabIndex = 63;
            this.labelEffectsIIRDelayFeedback.Text = "Feedback";
            // 
            // trackBarEffectsIIRDelayFeedback
            // 
            this.trackBarEffectsIIRDelayFeedback.Location = new System.Drawing.Point(32, 793);
            this.trackBarEffectsIIRDelayFeedback.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.trackBarEffectsIIRDelayFeedback.Maximum = 100;
            this.trackBarEffectsIIRDelayFeedback.Name = "trackBarEffectsIIRDelayFeedback";
            this.trackBarEffectsIIRDelayFeedback.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarEffectsIIRDelayFeedback.Size = new System.Drawing.Size(408, 45);
            this.trackBarEffectsIIRDelayFeedback.TabIndex = 64;
            this.trackBarEffectsIIRDelayFeedback.TickFrequency = 10;
            this.trackBarEffectsIIRDelayFeedback.Value = 70;
            this.trackBarEffectsIIRDelayFeedback.Scroll += new System.EventHandler(this.trackBarEffectsIIRDelayFeedback_Scroll);
            // 
            // checkBoxEffectsEcho
            // 
            this.checkBoxEffectsEcho.AutoSize = true;
            this.checkBoxEffectsEcho.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkBoxEffectsEcho.ForeColor = System.Drawing.Color.White;
            this.checkBoxEffectsEcho.Location = new System.Drawing.Point(32, 854);
            this.checkBoxEffectsEcho.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.checkBoxEffectsEcho.Name = "checkBoxEffectsEcho";
            this.checkBoxEffectsEcho.Size = new System.Drawing.Size(59, 23);
            this.checkBoxEffectsEcho.TabIndex = 67;
            this.checkBoxEffectsEcho.Text = "Echo";
            this.checkBoxEffectsEcho.UseVisualStyleBackColor = true;
            this.checkBoxEffectsEcho.CheckedChanged += new System.EventHandler(this.checkBoxEffectsEcho_CheckedChanged);
            // 
            // trackBarEffectsEcho
            // 
            this.trackBarEffectsEcho.Location = new System.Drawing.Point(32, 885);
            this.trackBarEffectsEcho.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.trackBarEffectsEcho.Maximum = 100;
            this.trackBarEffectsEcho.Name = "trackBarEffectsEcho";
            this.trackBarEffectsEcho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarEffectsEcho.Size = new System.Drawing.Size(408, 45);
            this.trackBarEffectsEcho.TabIndex = 68;
            this.trackBarEffectsEcho.TickFrequency = 10;
            this.trackBarEffectsEcho.Scroll += new System.EventHandler(this.trackBarEffectsEcho_Scroll);
            // 
            // checkBoxEffectsReverb
            // 
            this.checkBoxEffectsReverb.AutoSize = true;
            this.checkBoxEffectsReverb.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkBoxEffectsReverb.ForeColor = System.Drawing.Color.White;
            this.checkBoxEffectsReverb.Location = new System.Drawing.Point(32, 946);
            this.checkBoxEffectsReverb.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.checkBoxEffectsReverb.Name = "checkBoxEffectsReverb";
            this.checkBoxEffectsReverb.Size = new System.Drawing.Size(73, 23);
            this.checkBoxEffectsReverb.TabIndex = 71;
            this.checkBoxEffectsReverb.Text = "Reverb";
            this.checkBoxEffectsReverb.UseVisualStyleBackColor = true;
            this.checkBoxEffectsReverb.CheckedChanged += new System.EventHandler(this.checkBoxEffectsReverb_CheckedChanged);
            // 
            // trackBarEffectsReverb
            // 
            this.trackBarEffectsReverb.Location = new System.Drawing.Point(32, 977);
            this.trackBarEffectsReverb.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.trackBarEffectsReverb.Maximum = 20;
            this.trackBarEffectsReverb.Name = "trackBarEffectsReverb";
            this.trackBarEffectsReverb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarEffectsReverb.Size = new System.Drawing.Size(408, 45);
            this.trackBarEffectsReverb.TabIndex = 72;
            this.trackBarEffectsReverb.TickFrequency = 2;
            this.trackBarEffectsReverb.Scroll += new System.EventHandler(this.trackBarEffectsReverb_Scroll);
            // 
            // checkBoxEffectsChorus
            // 
            this.checkBoxEffectsChorus.AutoSize = true;
            this.checkBoxEffectsChorus.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkBoxEffectsChorus.ForeColor = System.Drawing.Color.White;
            this.checkBoxEffectsChorus.Location = new System.Drawing.Point(32, 1038);
            this.checkBoxEffectsChorus.Margin = new System.Windows.Forms.Padding(32, 16, 32, 0);
            this.checkBoxEffectsChorus.Name = "checkBoxEffectsChorus";
            this.checkBoxEffectsChorus.Size = new System.Drawing.Size(73, 23);
            this.checkBoxEffectsChorus.TabIndex = 69;
            this.checkBoxEffectsChorus.Text = "Chorus";
            this.checkBoxEffectsChorus.UseVisualStyleBackColor = true;
            this.checkBoxEffectsChorus.CheckedChanged += new System.EventHandler(this.checkBoxEffectsChorus_CheckedChanged);
            // 
            // trackBarEffectsChorus
            // 
            this.trackBarEffectsChorus.Location = new System.Drawing.Point(32, 1069);
            this.trackBarEffectsChorus.Margin = new System.Windows.Forms.Padding(32, 8, 0, 32);
            this.trackBarEffectsChorus.Maximum = 100;
            this.trackBarEffectsChorus.Name = "trackBarEffectsChorus";
            this.trackBarEffectsChorus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarEffectsChorus.Size = new System.Drawing.Size(408, 45);
            this.trackBarEffectsChorus.TabIndex = 70;
            this.trackBarEffectsChorus.TickFrequency = 10;
            this.trackBarEffectsChorus.Scroll += new System.EventHandler(this.trackBarEffectsChorus_Scroll);
            // 
            // tLPanelEqualizer
            // 
            this.tLPanelEqualizer.ColumnCount = 12;
            this.tLPanelEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPanelEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tLPanelEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tLPanelEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tLPanelEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tLPanelEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tLPanelEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tLPanelEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tLPanelEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tLPanelEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tLPanelEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tLPanelEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer18kHzValue, 10, 3);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer50HzValue, 1, 3);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer2kHzValue, 2, 3);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer4kHzValue, 3, 3);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer6kHzValue, 4, 3);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer8kHzValue, 5, 3);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer10kHzValue, 6, 3);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer12kHzValue, 7, 3);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer14kHzValue, 8, 3);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer16kHzValue, 9, 3);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer18kHzInfo, 10, 1);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer16kHzInfo, 9, 1);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer14kHzInfo, 8, 1);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer12kHzInfo, 7, 1);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer10kHzInfo, 6, 1);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer8kHzInfo, 5, 1);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer6kHzInfo, 4, 1);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer4kHzInfo, 3, 1);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer2kHzInfo, 2, 1);
            this.tLPanelEqualizer.Controls.Add(this.trackBarEqualizer18kHz, 10, 2);
            this.tLPanelEqualizer.Controls.Add(this.trackBarEqualizer16kHz, 9, 2);
            this.tLPanelEqualizer.Controls.Add(this.trackBarEqualizer14kHz, 8, 2);
            this.tLPanelEqualizer.Controls.Add(this.trackBarEqualizer12kHz, 7, 2);
            this.tLPanelEqualizer.Controls.Add(this.trackBarEqualizer10kHz, 6, 2);
            this.tLPanelEqualizer.Controls.Add(this.trackBarEqualizer8kHz, 5, 2);
            this.tLPanelEqualizer.Controls.Add(this.trackBarEqualizer6kHz, 4, 2);
            this.tLPanelEqualizer.Controls.Add(this.trackBarEqualizer4kHz, 3, 2);
            this.tLPanelEqualizer.Controls.Add(this.trackBarEqualizer2kHz, 2, 2);
            this.tLPanelEqualizer.Controls.Add(this.trackBarEqualizer50Hz, 1, 2);
            this.tLPanelEqualizer.Controls.Add(this.labelEqualizer50HzInfo, 1, 1);
            this.tLPanelEqualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanelEqualizer.Location = new System.Drawing.Point(256, 80);
            this.tLPanelEqualizer.Margin = new System.Windows.Forms.Padding(0);
            this.tLPanelEqualizer.Name = "tLPanelEqualizer";
            this.tLPanelEqualizer.RowCount = 5;
            this.tLPanelEqualizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.55629F));
            this.tLPanelEqualizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tLPanelEqualizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.88742F));
            this.tLPanelEqualizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tLPanelEqualizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.55629F));
            this.tLPanelEqualizer.Size = new System.Drawing.Size(572, 341);
            this.tLPanelEqualizer.TabIndex = 6;
            // 
            // labelEqualizer18kHzValue
            // 
            this.labelEqualizer18kHzValue.AutoSize = true;
            this.labelEqualizer18kHzValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer18kHzValue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer18kHzValue.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer18kHzValue.Location = new System.Drawing.Point(466, 267);
            this.labelEqualizer18kHzValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer18kHzValue.Name = "labelEqualizer18kHzValue";
            this.labelEqualizer18kHzValue.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer18kHzValue.TabIndex = 30;
            this.labelEqualizer18kHzValue.Text = "0";
            this.labelEqualizer18kHzValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer50HzValue
            // 
            this.labelEqualizer50HzValue.AutoSize = true;
            this.labelEqualizer50HzValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer50HzValue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer50HzValue.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer50HzValue.Location = new System.Drawing.Point(61, 267);
            this.labelEqualizer50HzValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer50HzValue.Name = "labelEqualizer50HzValue";
            this.labelEqualizer50HzValue.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer50HzValue.TabIndex = 29;
            this.labelEqualizer50HzValue.Text = "0";
            this.labelEqualizer50HzValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer2kHzValue
            // 
            this.labelEqualizer2kHzValue.AutoSize = true;
            this.labelEqualizer2kHzValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer2kHzValue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer2kHzValue.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer2kHzValue.Location = new System.Drawing.Point(106, 267);
            this.labelEqualizer2kHzValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer2kHzValue.Name = "labelEqualizer2kHzValue";
            this.labelEqualizer2kHzValue.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer2kHzValue.TabIndex = 28;
            this.labelEqualizer2kHzValue.Text = "0";
            this.labelEqualizer2kHzValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer4kHzValue
            // 
            this.labelEqualizer4kHzValue.AutoSize = true;
            this.labelEqualizer4kHzValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer4kHzValue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer4kHzValue.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer4kHzValue.Location = new System.Drawing.Point(151, 267);
            this.labelEqualizer4kHzValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer4kHzValue.Name = "labelEqualizer4kHzValue";
            this.labelEqualizer4kHzValue.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer4kHzValue.TabIndex = 27;
            this.labelEqualizer4kHzValue.Text = "0";
            this.labelEqualizer4kHzValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer6kHzValue
            // 
            this.labelEqualizer6kHzValue.AutoSize = true;
            this.labelEqualizer6kHzValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer6kHzValue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer6kHzValue.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer6kHzValue.Location = new System.Drawing.Point(196, 267);
            this.labelEqualizer6kHzValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer6kHzValue.Name = "labelEqualizer6kHzValue";
            this.labelEqualizer6kHzValue.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer6kHzValue.TabIndex = 26;
            this.labelEqualizer6kHzValue.Text = "0";
            this.labelEqualizer6kHzValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer8kHzValue
            // 
            this.labelEqualizer8kHzValue.AutoSize = true;
            this.labelEqualizer8kHzValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer8kHzValue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer8kHzValue.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer8kHzValue.Location = new System.Drawing.Point(241, 267);
            this.labelEqualizer8kHzValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer8kHzValue.Name = "labelEqualizer8kHzValue";
            this.labelEqualizer8kHzValue.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer8kHzValue.TabIndex = 25;
            this.labelEqualizer8kHzValue.Text = "0";
            this.labelEqualizer8kHzValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer10kHzValue
            // 
            this.labelEqualizer10kHzValue.AutoSize = true;
            this.labelEqualizer10kHzValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer10kHzValue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer10kHzValue.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer10kHzValue.Location = new System.Drawing.Point(286, 267);
            this.labelEqualizer10kHzValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer10kHzValue.Name = "labelEqualizer10kHzValue";
            this.labelEqualizer10kHzValue.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer10kHzValue.TabIndex = 24;
            this.labelEqualizer10kHzValue.Text = "0";
            this.labelEqualizer10kHzValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer12kHzValue
            // 
            this.labelEqualizer12kHzValue.AutoSize = true;
            this.labelEqualizer12kHzValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer12kHzValue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer12kHzValue.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer12kHzValue.Location = new System.Drawing.Point(331, 267);
            this.labelEqualizer12kHzValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer12kHzValue.Name = "labelEqualizer12kHzValue";
            this.labelEqualizer12kHzValue.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer12kHzValue.TabIndex = 23;
            this.labelEqualizer12kHzValue.Text = "0";
            this.labelEqualizer12kHzValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer14kHzValue
            // 
            this.labelEqualizer14kHzValue.AutoSize = true;
            this.labelEqualizer14kHzValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer14kHzValue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer14kHzValue.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer14kHzValue.Location = new System.Drawing.Point(376, 267);
            this.labelEqualizer14kHzValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer14kHzValue.Name = "labelEqualizer14kHzValue";
            this.labelEqualizer14kHzValue.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer14kHzValue.TabIndex = 22;
            this.labelEqualizer14kHzValue.Text = "0";
            this.labelEqualizer14kHzValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer16kHzValue
            // 
            this.labelEqualizer16kHzValue.AutoSize = true;
            this.labelEqualizer16kHzValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer16kHzValue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer16kHzValue.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer16kHzValue.Location = new System.Drawing.Point(421, 267);
            this.labelEqualizer16kHzValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer16kHzValue.Name = "labelEqualizer16kHzValue";
            this.labelEqualizer16kHzValue.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer16kHzValue.TabIndex = 21;
            this.labelEqualizer16kHzValue.Text = "0";
            this.labelEqualizer16kHzValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer18kHzInfo
            // 
            this.labelEqualizer18kHzInfo.AutoSize = true;
            this.labelEqualizer18kHzInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer18kHzInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer18kHzInfo.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer18kHzInfo.Location = new System.Drawing.Point(466, 48);
            this.labelEqualizer18kHzInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer18kHzInfo.Name = "labelEqualizer18kHzInfo";
            this.labelEqualizer18kHzInfo.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer18kHzInfo.TabIndex = 20;
            this.labelEqualizer18kHzInfo.Text = "18 kHz";
            this.labelEqualizer18kHzInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer16kHzInfo
            // 
            this.labelEqualizer16kHzInfo.AutoSize = true;
            this.labelEqualizer16kHzInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer16kHzInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer16kHzInfo.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer16kHzInfo.Location = new System.Drawing.Point(421, 48);
            this.labelEqualizer16kHzInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer16kHzInfo.Name = "labelEqualizer16kHzInfo";
            this.labelEqualizer16kHzInfo.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer16kHzInfo.TabIndex = 19;
            this.labelEqualizer16kHzInfo.Text = "16 kHz";
            this.labelEqualizer16kHzInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer14kHzInfo
            // 
            this.labelEqualizer14kHzInfo.AutoSize = true;
            this.labelEqualizer14kHzInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer14kHzInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer14kHzInfo.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer14kHzInfo.Location = new System.Drawing.Point(376, 48);
            this.labelEqualizer14kHzInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer14kHzInfo.Name = "labelEqualizer14kHzInfo";
            this.labelEqualizer14kHzInfo.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer14kHzInfo.TabIndex = 18;
            this.labelEqualizer14kHzInfo.Text = "14 kHz";
            this.labelEqualizer14kHzInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer12kHzInfo
            // 
            this.labelEqualizer12kHzInfo.AutoSize = true;
            this.labelEqualizer12kHzInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer12kHzInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer12kHzInfo.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer12kHzInfo.Location = new System.Drawing.Point(331, 48);
            this.labelEqualizer12kHzInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer12kHzInfo.Name = "labelEqualizer12kHzInfo";
            this.labelEqualizer12kHzInfo.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer12kHzInfo.TabIndex = 17;
            this.labelEqualizer12kHzInfo.Text = "12 kHz";
            this.labelEqualizer12kHzInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer10kHzInfo
            // 
            this.labelEqualizer10kHzInfo.AutoSize = true;
            this.labelEqualizer10kHzInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer10kHzInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer10kHzInfo.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer10kHzInfo.Location = new System.Drawing.Point(286, 48);
            this.labelEqualizer10kHzInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer10kHzInfo.Name = "labelEqualizer10kHzInfo";
            this.labelEqualizer10kHzInfo.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer10kHzInfo.TabIndex = 16;
            this.labelEqualizer10kHzInfo.Text = "10 kHz";
            this.labelEqualizer10kHzInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer8kHzInfo
            // 
            this.labelEqualizer8kHzInfo.AutoSize = true;
            this.labelEqualizer8kHzInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer8kHzInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer8kHzInfo.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer8kHzInfo.Location = new System.Drawing.Point(241, 48);
            this.labelEqualizer8kHzInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer8kHzInfo.Name = "labelEqualizer8kHzInfo";
            this.labelEqualizer8kHzInfo.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer8kHzInfo.TabIndex = 15;
            this.labelEqualizer8kHzInfo.Text = "8 kHz";
            this.labelEqualizer8kHzInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer6kHzInfo
            // 
            this.labelEqualizer6kHzInfo.AutoSize = true;
            this.labelEqualizer6kHzInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer6kHzInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer6kHzInfo.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer6kHzInfo.Location = new System.Drawing.Point(196, 48);
            this.labelEqualizer6kHzInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer6kHzInfo.Name = "labelEqualizer6kHzInfo";
            this.labelEqualizer6kHzInfo.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer6kHzInfo.TabIndex = 14;
            this.labelEqualizer6kHzInfo.Text = "6 kHz";
            this.labelEqualizer6kHzInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer4kHzInfo
            // 
            this.labelEqualizer4kHzInfo.AutoSize = true;
            this.labelEqualizer4kHzInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer4kHzInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer4kHzInfo.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer4kHzInfo.Location = new System.Drawing.Point(151, 48);
            this.labelEqualizer4kHzInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer4kHzInfo.Name = "labelEqualizer4kHzInfo";
            this.labelEqualizer4kHzInfo.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer4kHzInfo.TabIndex = 13;
            this.labelEqualizer4kHzInfo.Text = "4 kHz";
            this.labelEqualizer4kHzInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEqualizer2kHzInfo
            // 
            this.labelEqualizer2kHzInfo.AutoSize = true;
            this.labelEqualizer2kHzInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer2kHzInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer2kHzInfo.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer2kHzInfo.Location = new System.Drawing.Point(106, 48);
            this.labelEqualizer2kHzInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer2kHzInfo.Name = "labelEqualizer2kHzInfo";
            this.labelEqualizer2kHzInfo.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer2kHzInfo.TabIndex = 12;
            this.labelEqualizer2kHzInfo.Text = "2 kHz";
            this.labelEqualizer2kHzInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarEqualizer18kHz
            // 
            this.trackBarEqualizer18kHz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarEqualizer18kHz.Location = new System.Drawing.Point(468, 74);
            this.trackBarEqualizer18kHz.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarEqualizer18kHz.Maximum = 15;
            this.trackBarEqualizer18kHz.Minimum = -15;
            this.trackBarEqualizer18kHz.Name = "trackBarEqualizer18kHz";
            this.trackBarEqualizer18kHz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEqualizer18kHz.Size = new System.Drawing.Size(41, 191);
            this.trackBarEqualizer18kHz.TabIndex = 10;
            this.trackBarEqualizer18kHz.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEqualizer18kHz.Scroll += new System.EventHandler(this.trackBarEqualizer50Hz_Scroll);
            // 
            // trackBarEqualizer16kHz
            // 
            this.trackBarEqualizer16kHz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarEqualizer16kHz.Location = new System.Drawing.Point(423, 74);
            this.trackBarEqualizer16kHz.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarEqualizer16kHz.Maximum = 15;
            this.trackBarEqualizer16kHz.Minimum = -15;
            this.trackBarEqualizer16kHz.Name = "trackBarEqualizer16kHz";
            this.trackBarEqualizer16kHz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEqualizer16kHz.Size = new System.Drawing.Size(41, 191);
            this.trackBarEqualizer16kHz.TabIndex = 9;
            this.trackBarEqualizer16kHz.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEqualizer16kHz.Scroll += new System.EventHandler(this.trackBarEqualizer50Hz_Scroll);
            // 
            // trackBarEqualizer14kHz
            // 
            this.trackBarEqualizer14kHz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarEqualizer14kHz.Location = new System.Drawing.Point(378, 74);
            this.trackBarEqualizer14kHz.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarEqualizer14kHz.Maximum = 15;
            this.trackBarEqualizer14kHz.Minimum = -15;
            this.trackBarEqualizer14kHz.Name = "trackBarEqualizer14kHz";
            this.trackBarEqualizer14kHz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEqualizer14kHz.Size = new System.Drawing.Size(41, 191);
            this.trackBarEqualizer14kHz.TabIndex = 8;
            this.trackBarEqualizer14kHz.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEqualizer14kHz.Scroll += new System.EventHandler(this.trackBarEqualizer50Hz_Scroll);
            // 
            // trackBarEqualizer12kHz
            // 
            this.trackBarEqualizer12kHz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarEqualizer12kHz.Location = new System.Drawing.Point(333, 74);
            this.trackBarEqualizer12kHz.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarEqualizer12kHz.Maximum = 15;
            this.trackBarEqualizer12kHz.Minimum = -15;
            this.trackBarEqualizer12kHz.Name = "trackBarEqualizer12kHz";
            this.trackBarEqualizer12kHz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEqualizer12kHz.Size = new System.Drawing.Size(41, 191);
            this.trackBarEqualizer12kHz.TabIndex = 7;
            this.trackBarEqualizer12kHz.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEqualizer12kHz.Scroll += new System.EventHandler(this.trackBarEqualizer50Hz_Scroll);
            // 
            // trackBarEqualizer10kHz
            // 
            this.trackBarEqualizer10kHz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarEqualizer10kHz.Location = new System.Drawing.Point(288, 74);
            this.trackBarEqualizer10kHz.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarEqualizer10kHz.Maximum = 15;
            this.trackBarEqualizer10kHz.Minimum = -15;
            this.trackBarEqualizer10kHz.Name = "trackBarEqualizer10kHz";
            this.trackBarEqualizer10kHz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEqualizer10kHz.Size = new System.Drawing.Size(41, 191);
            this.trackBarEqualizer10kHz.TabIndex = 6;
            this.trackBarEqualizer10kHz.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEqualizer10kHz.Scroll += new System.EventHandler(this.trackBarEqualizer50Hz_Scroll);
            // 
            // trackBarEqualizer8kHz
            // 
            this.trackBarEqualizer8kHz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarEqualizer8kHz.Location = new System.Drawing.Point(243, 74);
            this.trackBarEqualizer8kHz.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarEqualizer8kHz.Maximum = 15;
            this.trackBarEqualizer8kHz.Minimum = -15;
            this.trackBarEqualizer8kHz.Name = "trackBarEqualizer8kHz";
            this.trackBarEqualizer8kHz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEqualizer8kHz.Size = new System.Drawing.Size(41, 191);
            this.trackBarEqualizer8kHz.TabIndex = 5;
            this.trackBarEqualizer8kHz.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEqualizer8kHz.Scroll += new System.EventHandler(this.trackBarEqualizer50Hz_Scroll);
            // 
            // trackBarEqualizer6kHz
            // 
            this.trackBarEqualizer6kHz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarEqualizer6kHz.Location = new System.Drawing.Point(198, 74);
            this.trackBarEqualizer6kHz.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarEqualizer6kHz.Maximum = 15;
            this.trackBarEqualizer6kHz.Minimum = -15;
            this.trackBarEqualizer6kHz.Name = "trackBarEqualizer6kHz";
            this.trackBarEqualizer6kHz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEqualizer6kHz.Size = new System.Drawing.Size(41, 191);
            this.trackBarEqualizer6kHz.TabIndex = 4;
            this.trackBarEqualizer6kHz.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEqualizer6kHz.Scroll += new System.EventHandler(this.trackBarEqualizer50Hz_Scroll);
            // 
            // trackBarEqualizer4kHz
            // 
            this.trackBarEqualizer4kHz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarEqualizer4kHz.Location = new System.Drawing.Point(153, 74);
            this.trackBarEqualizer4kHz.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarEqualizer4kHz.Maximum = 15;
            this.trackBarEqualizer4kHz.Minimum = -15;
            this.trackBarEqualizer4kHz.Name = "trackBarEqualizer4kHz";
            this.trackBarEqualizer4kHz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEqualizer4kHz.Size = new System.Drawing.Size(41, 191);
            this.trackBarEqualizer4kHz.TabIndex = 3;
            this.trackBarEqualizer4kHz.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEqualizer4kHz.Scroll += new System.EventHandler(this.trackBarEqualizer50Hz_Scroll);
            // 
            // trackBarEqualizer2kHz
            // 
            this.trackBarEqualizer2kHz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarEqualizer2kHz.Location = new System.Drawing.Point(108, 74);
            this.trackBarEqualizer2kHz.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarEqualizer2kHz.Maximum = 15;
            this.trackBarEqualizer2kHz.Minimum = -15;
            this.trackBarEqualizer2kHz.Name = "trackBarEqualizer2kHz";
            this.trackBarEqualizer2kHz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEqualizer2kHz.Size = new System.Drawing.Size(41, 191);
            this.trackBarEqualizer2kHz.TabIndex = 2;
            this.trackBarEqualizer2kHz.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEqualizer2kHz.Scroll += new System.EventHandler(this.trackBarEqualizer50Hz_Scroll);
            // 
            // trackBarEqualizer50Hz
            // 
            this.trackBarEqualizer50Hz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarEqualizer50Hz.Location = new System.Drawing.Point(63, 74);
            this.trackBarEqualizer50Hz.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarEqualizer50Hz.Maximum = 15;
            this.trackBarEqualizer50Hz.Minimum = -15;
            this.trackBarEqualizer50Hz.Name = "trackBarEqualizer50Hz";
            this.trackBarEqualizer50Hz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEqualizer50Hz.Size = new System.Drawing.Size(41, 191);
            this.trackBarEqualizer50Hz.TabIndex = 1;
            this.trackBarEqualizer50Hz.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEqualizer50Hz.Scroll += new System.EventHandler(this.trackBarEqualizer50Hz_Scroll);
            // 
            // labelEqualizer50HzInfo
            // 
            this.labelEqualizer50HzInfo.AutoSize = true;
            this.labelEqualizer50HzInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizer50HzInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizer50HzInfo.ForeColor = System.Drawing.Color.White;
            this.labelEqualizer50HzInfo.Location = new System.Drawing.Point(61, 48);
            this.labelEqualizer50HzInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizer50HzInfo.Name = "labelEqualizer50HzInfo";
            this.labelEqualizer50HzInfo.Size = new System.Drawing.Size(45, 24);
            this.labelEqualizer50HzInfo.TabIndex = 11;
            this.labelEqualizer50HzInfo.Text = "50 Hz";
            this.labelEqualizer50HzInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEqualizerPresetName
            // 
            this.panelEqualizerPresetName.Controls.Add(this.labelEqualizerPresetName);
            this.panelEqualizerPresetName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEqualizerPresetName.Location = new System.Drawing.Point(256, 48);
            this.panelEqualizerPresetName.Name = "panelEqualizerPresetName";
            this.panelEqualizerPresetName.Size = new System.Drawing.Size(572, 32);
            this.panelEqualizerPresetName.TabIndex = 9;
            // 
            // labelEqualizerPresetName
            // 
            this.labelEqualizerPresetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEqualizerPresetName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizerPresetName.ForeColor = System.Drawing.Color.White;
            this.labelEqualizerPresetName.Location = new System.Drawing.Point(0, 0);
            this.labelEqualizerPresetName.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizerPresetName.Name = "labelEqualizerPresetName";
            this.labelEqualizerPresetName.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelEqualizerPresetName.Size = new System.Drawing.Size(572, 32);
            this.labelEqualizerPresetName.TabIndex = 7;
            this.labelEqualizerPresetName.Text = "Default";
            this.labelEqualizerPresetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tLPanelEqualizerStatusbar
            // 
            this.tLPanelEqualizerStatusbar.BackColor = System.Drawing.Color.Transparent;
            this.tLPanelEqualizerStatusbar.ColumnCount = 4;
            this.tLPanelEqualizerStatusbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tLPanelEqualizerStatusbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tLPanelEqualizerStatusbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tLPanelEqualizerStatusbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelEqualizerStatusbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelEqualizerStatusbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelEqualizerStatusbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelEqualizerStatusbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelEqualizerStatusbar.Controls.Add(this.buttonEqualizerSaveto, 2, 0);
            this.tLPanelEqualizerStatusbar.Controls.Add(this.buttonEqualizerReset, 1, 0);
            this.tLPanelEqualizerStatusbar.Controls.Add(this.buttonEqualizerSave, 0, 0);
            this.tLPanelEqualizerStatusbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tLPanelEqualizerStatusbar.Location = new System.Drawing.Point(256, 421);
            this.tLPanelEqualizerStatusbar.Margin = new System.Windows.Forms.Padding(0);
            this.tLPanelEqualizerStatusbar.Name = "tLPanelEqualizerStatusbar";
            this.tLPanelEqualizerStatusbar.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tLPanelEqualizerStatusbar.RowCount = 1;
            this.tLPanelEqualizerStatusbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelEqualizerStatusbar.Size = new System.Drawing.Size(572, 36);
            this.tLPanelEqualizerStatusbar.TabIndex = 5;
            // 
            // buttonEqualizerSaveto
            // 
            this.buttonEqualizerSaveto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEqualizerSaveto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonEqualizerSaveto.FlatAppearance.BorderSize = 0;
            this.buttonEqualizerSaveto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonEqualizerSaveto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonEqualizerSaveto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonEqualizerSaveto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqualizerSaveto.ForeColor = System.Drawing.Color.White;
            this.buttonEqualizerSaveto.Image = global::AnthraX.IconsNavigation._32_MoveTo;
            this.buttonEqualizerSaveto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEqualizerSaveto.Location = new System.Drawing.Point(202, 2);
            this.buttonEqualizerSaveto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEqualizerSaveto.Name = "buttonEqualizerSaveto";
            this.buttonEqualizerSaveto.Size = new System.Drawing.Size(92, 32);
            this.buttonEqualizerSaveto.TabIndex = 4;
            this.buttonEqualizerSaveto.Text = "Save to";
            this.buttonEqualizerSaveto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEqualizerSaveto.UseVisualStyleBackColor = true;
            this.buttonEqualizerSaveto.Click += new System.EventHandler(this.buttonEqualizerSaveto_Click);
            // 
            // buttonEqualizerReset
            // 
            this.buttonEqualizerReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEqualizerReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonEqualizerReset.FlatAppearance.BorderSize = 0;
            this.buttonEqualizerReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonEqualizerReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonEqualizerReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonEqualizerReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqualizerReset.ForeColor = System.Drawing.Color.White;
            this.buttonEqualizerReset.Image = global::AnthraX.IconsNavigation._32_Clear;
            this.buttonEqualizerReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEqualizerReset.Location = new System.Drawing.Point(106, 2);
            this.buttonEqualizerReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEqualizerReset.Name = "buttonEqualizerReset";
            this.buttonEqualizerReset.Size = new System.Drawing.Size(92, 32);
            this.buttonEqualizerReset.TabIndex = 2;
            this.buttonEqualizerReset.Text = "Reset";
            this.buttonEqualizerReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEqualizerReset.UseVisualStyleBackColor = true;
            this.buttonEqualizerReset.Click += new System.EventHandler(this.buttonEqualizerReset_Click);
            // 
            // buttonEqualizerSave
            // 
            this.buttonEqualizerSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEqualizerSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonEqualizerSave.FlatAppearance.BorderSize = 0;
            this.buttonEqualizerSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonEqualizerSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonEqualizerSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonEqualizerSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqualizerSave.ForeColor = System.Drawing.Color.White;
            this.buttonEqualizerSave.Image = global::AnthraX.IconsNavigation._32_Save;
            this.buttonEqualizerSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEqualizerSave.Location = new System.Drawing.Point(10, 2);
            this.buttonEqualizerSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEqualizerSave.Name = "buttonEqualizerSave";
            this.buttonEqualizerSave.Size = new System.Drawing.Size(92, 32);
            this.buttonEqualizerSave.TabIndex = 1;
            this.buttonEqualizerSave.Text = "Save";
            this.buttonEqualizerSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEqualizerSave.UseVisualStyleBackColor = true;
            this.buttonEqualizerSave.Click += new System.EventHandler(this.buttonEqualizerSave_Click);
            // 
            // panelEqualizerToolbar
            // 
            this.panelEqualizerToolbar.Controls.Add(this.treeViewEqualizerMenu);
            this.panelEqualizerToolbar.Controls.Add(this.tLPanelEqualizerTools);
            this.panelEqualizerToolbar.Controls.Add(this.labelEqualizerInfo);
            this.panelEqualizerToolbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEqualizerToolbar.Location = new System.Drawing.Point(0, 48);
            this.panelEqualizerToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelEqualizerToolbar.Name = "panelEqualizerToolbar";
            this.panelEqualizerToolbar.Size = new System.Drawing.Size(256, 409);
            this.panelEqualizerToolbar.TabIndex = 3;
            // 
            // treeViewEqualizerMenu
            // 
            this.treeViewEqualizerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewEqualizerMenu.ImageIndex = 0;
            this.treeViewEqualizerMenu.ImageList = this.imageListEqualizerMenu;
            this.treeViewEqualizerMenu.Location = new System.Drawing.Point(0, 32);
            this.treeViewEqualizerMenu.Name = "treeViewEqualizerMenu";
            treeNode8.Name = "NodeEqualizerPresetDefault";
            treeNode8.Text = "Default";
            treeNode9.Name = "NodeEqualizerPresetBass";
            treeNode9.Text = "Bass";
            treeNode10.Name = "NodeEqualizerPresetDance";
            treeNode10.Text = "Dance";
            treeNode11.Name = "NodeEqualizerPresetLive";
            treeNode11.Text = "Live";
            treeNode12.Name = "NodeEqualizerPresetPop";
            treeNode12.Text = "Pop";
            treeNode13.Name = "NodeEqualizerPresetPower";
            treeNode13.Text = "Power";
            treeNode14.Name = "NodeEqualizerPresetRock";
            treeNode14.Text = "Rock";
            treeNode15.Name = "NodeEqualizerPresetTreble";
            treeNode15.Text = "Treble";
            treeNode16.Name = "NodeEqualizerPresetVocal";
            treeNode16.Text = "Vocal";
            treeNode17.Name = "NodeEqualizerPresetXplode1";
            treeNode17.Text = "Xplode 1";
            treeNode18.Name = "NodeEqualizerPresetXplode2";
            treeNode18.Text = "Xplode 2";
            treeNode19.Name = "NodeEqualizerPresetXplode3";
            treeNode19.Text = "Xplode 3";
            treeNode20.ImageIndex = 2;
            treeNode20.Name = "NodeEqualizer";
            treeNode20.SelectedImageIndex = 2;
            treeNode20.Text = "Equalizer Presets";
            treeNode21.Name = "NodeEffectPresetNA";
            treeNode21.Text = "No Effect";
            treeNode22.Name = "NodeEffectPresetDefault";
            treeNode22.Text = "Default";
            treeNode23.ImageIndex = 1;
            treeNode23.Name = "NodeEffects";
            treeNode23.SelectedImageIndex = 1;
            treeNode23.Text = "Effect Presets";
            this.treeViewEqualizerMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode23});
            this.treeViewEqualizerMenu.SelectedImageIndex = 0;
            this.treeViewEqualizerMenu.Size = new System.Drawing.Size(256, 341);
            this.treeViewEqualizerMenu.TabIndex = 3;
            this.treeViewEqualizerMenu.DoubleClick += new System.EventHandler(this.treeViewEqualizerMenu_DoubleClick);
            // 
            // imageListEqualizerMenu
            // 
            this.imageListEqualizerMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListEqualizerMenu.ImageStream")));
            this.imageListEqualizerMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListEqualizerMenu.Images.SetKeyName(0, "32_Black_Preset.png");
            this.imageListEqualizerMenu.Images.SetKeyName(1, "32_Black_Effects.png");
            this.imageListEqualizerMenu.Images.SetKeyName(2, "32_Black_Equalizer.png");
            this.imageListEqualizerMenu.Images.SetKeyName(3, "32_White_Preset.png");
            this.imageListEqualizerMenu.Images.SetKeyName(4, "32_White_Effects.png");
            this.imageListEqualizerMenu.Images.SetKeyName(5, "32_White_Equalizer.png");
            // 
            // tLPanelEqualizerTools
            // 
            this.tLPanelEqualizerTools.BackColor = System.Drawing.Color.Transparent;
            this.tLPanelEqualizerTools.ColumnCount = 5;
            this.tLPanelEqualizerTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPanelEqualizerTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tLPanelEqualizerTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tLPanelEqualizerTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tLPanelEqualizerTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPanelEqualizerTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelEqualizerTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelEqualizerTools.Controls.Add(this.buttonEqualizerPresetRemove, 3, 0);
            this.tLPanelEqualizerTools.Controls.Add(this.buttonEqualizerPresetAdd, 1, 0);
            this.tLPanelEqualizerTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tLPanelEqualizerTools.Location = new System.Drawing.Point(0, 373);
            this.tLPanelEqualizerTools.Margin = new System.Windows.Forms.Padding(0);
            this.tLPanelEqualizerTools.Name = "tLPanelEqualizerTools";
            this.tLPanelEqualizerTools.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tLPanelEqualizerTools.RowCount = 1;
            this.tLPanelEqualizerTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelEqualizerTools.Size = new System.Drawing.Size(256, 36);
            this.tLPanelEqualizerTools.TabIndex = 5;
            // 
            // buttonEqualizerPresetRemove
            // 
            this.buttonEqualizerPresetRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEqualizerPresetRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonEqualizerPresetRemove.FlatAppearance.BorderSize = 0;
            this.buttonEqualizerPresetRemove.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonEqualizerPresetRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonEqualizerPresetRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonEqualizerPresetRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqualizerPresetRemove.ForeColor = System.Drawing.Color.White;
            this.buttonEqualizerPresetRemove.Image = global::AnthraX.IconsNavigation._32_Remove;
            this.buttonEqualizerPresetRemove.Location = new System.Drawing.Point(148, 2);
            this.buttonEqualizerPresetRemove.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEqualizerPresetRemove.Name = "buttonEqualizerPresetRemove";
            this.buttonEqualizerPresetRemove.Size = new System.Drawing.Size(32, 32);
            this.buttonEqualizerPresetRemove.TabIndex = 1;
            this.buttonEqualizerPresetRemove.UseVisualStyleBackColor = true;
            this.buttonEqualizerPresetRemove.Click += new System.EventHandler(this.buttonEqualizerPresetRemove_Click);
            // 
            // buttonEqualizerPresetAdd
            // 
            this.buttonEqualizerPresetAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEqualizerPresetAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonEqualizerPresetAdd.FlatAppearance.BorderSize = 0;
            this.buttonEqualizerPresetAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonEqualizerPresetAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonEqualizerPresetAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonEqualizerPresetAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqualizerPresetAdd.ForeColor = System.Drawing.Color.White;
            this.buttonEqualizerPresetAdd.Image = global::AnthraX.IconsNavigation._32_Add;
            this.buttonEqualizerPresetAdd.Location = new System.Drawing.Point(76, 2);
            this.buttonEqualizerPresetAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEqualizerPresetAdd.Name = "buttonEqualizerPresetAdd";
            this.buttonEqualizerPresetAdd.Size = new System.Drawing.Size(32, 32);
            this.buttonEqualizerPresetAdd.TabIndex = 0;
            this.buttonEqualizerPresetAdd.UseVisualStyleBackColor = true;
            this.buttonEqualizerPresetAdd.Click += new System.EventHandler(this.buttonEqualizerPresetAdd_Click);
            // 
            // labelEqualizerInfo
            // 
            this.labelEqualizerInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelEqualizerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEqualizerInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizerInfo.ForeColor = System.Drawing.Color.White;
            this.labelEqualizerInfo.Location = new System.Drawing.Point(0, 0);
            this.labelEqualizerInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizerInfo.Name = "labelEqualizerInfo";
            this.labelEqualizerInfo.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelEqualizerInfo.Size = new System.Drawing.Size(256, 32);
            this.labelEqualizerInfo.TabIndex = 4;
            this.labelEqualizerInfo.Text = "Presets";
            this.labelEqualizerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelEqualizerTitleBar
            // 
            this.panelEqualizerTitleBar.Controls.Add(this.labelEqualizerTitle);
            this.panelEqualizerTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEqualizerTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelEqualizerTitleBar.Name = "panelEqualizerTitleBar";
            this.panelEqualizerTitleBar.Size = new System.Drawing.Size(828, 48);
            this.panelEqualizerTitleBar.TabIndex = 8;
            // 
            // labelEqualizerTitle
            // 
            this.labelEqualizerTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelEqualizerTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEqualizerTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEqualizerTitle.ForeColor = System.Drawing.Color.White;
            this.labelEqualizerTitle.Location = new System.Drawing.Point(0, 0);
            this.labelEqualizerTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelEqualizerTitle.Name = "labelEqualizerTitle";
            this.labelEqualizerTitle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelEqualizerTitle.Size = new System.Drawing.Size(828, 48);
            this.labelEqualizerTitle.TabIndex = 4;
            this.labelEqualizerTitle.Text = "Equalizer";
            this.labelEqualizerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelExplorer
            // 
            this.panelExplorer.Controls.Add(this.listViewExplorerFiles);
            this.panelExplorer.Controls.Add(this.panelExplorerToolbar);
            this.panelExplorer.Controls.Add(this.panelExplorerMenubar);
            this.panelExplorer.Controls.Add(this.tLPanelExplorerStatusbar);
            this.panelExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExplorer.Location = new System.Drawing.Point(56, 0);
            this.panelExplorer.Margin = new System.Windows.Forms.Padding(0);
            this.panelExplorer.Name = "panelExplorer";
            this.panelExplorer.Size = new System.Drawing.Size(828, 457);
            this.panelExplorer.TabIndex = 2;
            // 
            // listViewExplorerFiles
            // 
            this.listViewExplorerFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewExplorerFiles.LargeImageList = this.imageListFiles;
            this.listViewExplorerFiles.Location = new System.Drawing.Point(256, 112);
            this.listViewExplorerFiles.MultiSelect = false;
            this.listViewExplorerFiles.Name = "listViewExplorerFiles";
            this.listViewExplorerFiles.ShowGroups = false;
            this.listViewExplorerFiles.Size = new System.Drawing.Size(572, 313);
            this.listViewExplorerFiles.SmallImageList = this.imageListFiles;
            this.listViewExplorerFiles.TabIndex = 2;
            this.listViewExplorerFiles.TileSize = new System.Drawing.Size(224, 48);
            this.listViewExplorerFiles.UseCompatibleStateImageBehavior = false;
            this.listViewExplorerFiles.DoubleClick += new System.EventHandler(this.listViewExplorerFiles_DoubleClick);
            this.listViewExplorerFiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listViewExplorerFiles_KeyPress);
            // 
            // imageListFiles
            // 
            this.imageListFiles.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFiles.ImageStream")));
            this.imageListFiles.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFiles.Images.SetKeyName(0, "32_Animation.png");
            this.imageListFiles.Images.SetKeyName(1, "32_Application.png");
            this.imageListFiles.Images.SetKeyName(2, "32_Archive.png");
            this.imageListFiles.Images.SetKeyName(3, "32_Computer.png");
            this.imageListFiles.Images.SetKeyName(4, "32_Config.png");
            this.imageListFiles.Images.SetKeyName(5, "32_Desktop.png");
            this.imageListFiles.Images.SetKeyName(6, "32_Disc.png");
            this.imageListFiles.Images.SetKeyName(7, "32_Document.png");
            this.imageListFiles.Images.SetKeyName(8, "32_File.png");
            this.imageListFiles.Images.SetKeyName(9, "32_FloppyDisc.png");
            this.imageListFiles.Images.SetKeyName(10, "32_Folder.png");
            this.imageListFiles.Images.SetKeyName(11, "32_FolderApplications.png");
            this.imageListFiles.Images.SetKeyName(12, "32_FolderDocuments.png");
            this.imageListFiles.Images.SetKeyName(13, "32_FolderMusic.png");
            this.imageListFiles.Images.SetKeyName(14, "32_FolderNetwork.png");
            this.imageListFiles.Images.SetKeyName(15, "32_FolderPictures.png");
            this.imageListFiles.Images.SetKeyName(16, "32_FolderVideo.png");
            this.imageListFiles.Images.SetKeyName(17, "32_FolderWeb.png");
            this.imageListFiles.Images.SetKeyName(18, "32_HardDisc.png");
            this.imageListFiles.Images.SetKeyName(19, "32_Home.png");
            this.imageListFiles.Images.SetKeyName(20, "32_Image.png");
            this.imageListFiles.Images.SetKeyName(21, "32_Music.png");
            this.imageListFiles.Images.SetKeyName(22, "32_NetworkDisc.png");
            this.imageListFiles.Images.SetKeyName(23, "32_PlayList.png");
            this.imageListFiles.Images.SetKeyName(24, "32_Picture.png");
            this.imageListFiles.Images.SetKeyName(25, "32_RemovableDisc.png");
            this.imageListFiles.Images.SetKeyName(26, "32_Sound.png");
            this.imageListFiles.Images.SetKeyName(27, "32_Video.png");
            this.imageListFiles.Images.SetKeyName(28, "32_Wave.png");
            this.imageListFiles.Images.SetKeyName(29, "32_Web.png");
            this.imageListFiles.Images.SetKeyName(30, "32_Word.png");
            // 
            // panelExplorerToolbar
            // 
            this.panelExplorerToolbar.Controls.Add(this.treeViewExplorerDirectories);
            this.panelExplorerToolbar.Controls.Add(this.comboBoxExplorerDisks);
            this.panelExplorerToolbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelExplorerToolbar.Location = new System.Drawing.Point(0, 112);
            this.panelExplorerToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelExplorerToolbar.Name = "panelExplorerToolbar";
            this.panelExplorerToolbar.Size = new System.Drawing.Size(256, 313);
            this.panelExplorerToolbar.TabIndex = 1;
            // 
            // treeViewExplorerDirectories
            // 
            this.treeViewExplorerDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewExplorerDirectories.ImageIndex = 10;
            this.treeViewExplorerDirectories.ImageList = this.imageListFiles;
            this.treeViewExplorerDirectories.Indent = 24;
            this.treeViewExplorerDirectories.Location = new System.Drawing.Point(0, 27);
            this.treeViewExplorerDirectories.Name = "treeViewExplorerDirectories";
            this.treeViewExplorerDirectories.SelectedImageIndex = 10;
            this.treeViewExplorerDirectories.ShowPlusMinus = false;
            this.treeViewExplorerDirectories.Size = new System.Drawing.Size(256, 286);
            this.treeViewExplorerDirectories.TabIndex = 3;
            this.treeViewExplorerDirectories.DoubleClick += new System.EventHandler(this.treeViewExplorerDirectories_DoubleClick);
            // 
            // comboBoxExplorerDisks
            // 
            this.comboBoxExplorerDisks.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxExplorerDisks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxExplorerDisks.FormattingEnabled = true;
            this.comboBoxExplorerDisks.Location = new System.Drawing.Point(0, 0);
            this.comboBoxExplorerDisks.Name = "comboBoxExplorerDisks";
            this.comboBoxExplorerDisks.Size = new System.Drawing.Size(256, 27);
            this.comboBoxExplorerDisks.TabIndex = 2;
            this.comboBoxExplorerDisks.Text = "System (C:\\)";
            this.comboBoxExplorerDisks.SelectionChangeCommitted += new System.EventHandler(this.comboBoxExplorerDisks_SelectionChangeCommitted);
            // 
            // panelExplorerMenubar
            // 
            this.panelExplorerMenubar.Controls.Add(this.tLPanelExplorerOptions);
            this.panelExplorerMenubar.Controls.Add(this.tLPanelExplorerNavigation);
            this.panelExplorerMenubar.Controls.Add(this.labelExplorerTitle);
            this.panelExplorerMenubar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExplorerMenubar.Location = new System.Drawing.Point(0, 0);
            this.panelExplorerMenubar.Margin = new System.Windows.Forms.Padding(0);
            this.panelExplorerMenubar.Name = "panelExplorerMenubar";
            this.panelExplorerMenubar.Size = new System.Drawing.Size(828, 112);
            this.panelExplorerMenubar.TabIndex = 0;
            // 
            // tLPanelExplorerOptions
            // 
            this.tLPanelExplorerOptions.BackColor = System.Drawing.Color.Transparent;
            this.tLPanelExplorerOptions.ColumnCount = 3;
            this.tLPanelExplorerOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelExplorerOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tLPanelExplorerOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tLPanelExplorerOptions.Controls.Add(this.buttonExplorerFilter, 2, 0);
            this.tLPanelExplorerOptions.Controls.Add(this.panelExplorerFilter, 1, 0);
            this.tLPanelExplorerOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tLPanelExplorerOptions.Location = new System.Drawing.Point(0, 72);
            this.tLPanelExplorerOptions.Margin = new System.Windows.Forms.Padding(0);
            this.tLPanelExplorerOptions.Name = "tLPanelExplorerOptions";
            this.tLPanelExplorerOptions.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tLPanelExplorerOptions.RowCount = 1;
            this.tLPanelExplorerOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelExplorerOptions.Size = new System.Drawing.Size(828, 40);
            this.tLPanelExplorerOptions.TabIndex = 2;
            // 
            // buttonExplorerFilter
            // 
            this.buttonExplorerFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExplorerFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExplorerFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonExplorerFilter.FlatAppearance.BorderSize = 0;
            this.buttonExplorerFilter.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonExplorerFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonExplorerFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonExplorerFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExplorerFilter.ForeColor = System.Drawing.Color.White;
            this.buttonExplorerFilter.Image = global::AnthraX.IconsNavigation._32_Filder;
            this.buttonExplorerFilter.Location = new System.Drawing.Point(790, 4);
            this.buttonExplorerFilter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExplorerFilter.Name = "buttonExplorerFilter";
            this.buttonExplorerFilter.Size = new System.Drawing.Size(32, 32);
            this.buttonExplorerFilter.TabIndex = 1;
            this.buttonExplorerFilter.UseVisualStyleBackColor = false;
            this.buttonExplorerFilter.Click += new System.EventHandler(this.buttonExplorerFilter_Click);
            // 
            // panelExplorerFilter
            // 
            this.panelExplorerFilter.BackColor = System.Drawing.SystemColors.Window;
            this.panelExplorerFilter.Controls.Add(this.comboBoxExplorerFilter);
            this.panelExplorerFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExplorerFilter.Location = new System.Drawing.Point(534, 4);
            this.panelExplorerFilter.Margin = new System.Windows.Forms.Padding(2);
            this.panelExplorerFilter.Name = "panelExplorerFilter";
            this.panelExplorerFilter.Padding = new System.Windows.Forms.Padding(2);
            this.panelExplorerFilter.Size = new System.Drawing.Size(252, 32);
            this.panelExplorerFilter.TabIndex = 2;
            // 
            // comboBoxExplorerFilter
            // 
            this.comboBoxExplorerFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxExplorerFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxExplorerFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxExplorerFilter.FormattingEnabled = true;
            this.comboBoxExplorerFilter.Items.AddRange(new object[] {
            "All Files",
            "Music",
            "Pictures",
            "Videos",
            "Documents"});
            this.comboBoxExplorerFilter.Location = new System.Drawing.Point(2, 2);
            this.comboBoxExplorerFilter.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxExplorerFilter.Name = "comboBoxExplorerFilter";
            this.comboBoxExplorerFilter.Size = new System.Drawing.Size(248, 27);
            this.comboBoxExplorerFilter.TabIndex = 1;
            this.comboBoxExplorerFilter.Text = "All Files";
            this.comboBoxExplorerFilter.SelectionChangeCommitted += new System.EventHandler(this.comboBoxExplorerFilter_SelectionChangeCommitted);
            // 
            // tLPanelExplorerNavigation
            // 
            this.tLPanelExplorerNavigation.BackColor = System.Drawing.Color.Transparent;
            this.tLPanelExplorerNavigation.ColumnCount = 6;
            this.tLPanelExplorerNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tLPanelExplorerNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tLPanelExplorerNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelExplorerNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tLPanelExplorerNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tLPanelExplorerNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tLPanelExplorerNavigation.Controls.Add(this.panelExplorerSearch, 4, 0);
            this.tLPanelExplorerNavigation.Controls.Add(this.buttonExplorerBack, 0, 0);
            this.tLPanelExplorerNavigation.Controls.Add(this.buttonExplorerNext, 1, 0);
            this.tLPanelExplorerNavigation.Controls.Add(this.buttonExplorerGo, 3, 0);
            this.tLPanelExplorerNavigation.Controls.Add(this.buttonExplorerSearch, 5, 0);
            this.tLPanelExplorerNavigation.Controls.Add(this.panelExplorerPath, 2, 0);
            this.tLPanelExplorerNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.tLPanelExplorerNavigation.Location = new System.Drawing.Point(0, 32);
            this.tLPanelExplorerNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.tLPanelExplorerNavigation.Name = "tLPanelExplorerNavigation";
            this.tLPanelExplorerNavigation.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tLPanelExplorerNavigation.RowCount = 1;
            this.tLPanelExplorerNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelExplorerNavigation.Size = new System.Drawing.Size(828, 40);
            this.tLPanelExplorerNavigation.TabIndex = 1;
            // 
            // panelExplorerSearch
            // 
            this.panelExplorerSearch.BackColor = System.Drawing.SystemColors.Window;
            this.panelExplorerSearch.Controls.Add(this.textBoxExplorerSearch);
            this.panelExplorerSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExplorerSearch.Location = new System.Drawing.Point(534, 4);
            this.panelExplorerSearch.Margin = new System.Windows.Forms.Padding(2);
            this.panelExplorerSearch.Name = "panelExplorerSearch";
            this.panelExplorerSearch.Padding = new System.Windows.Forms.Padding(6);
            this.panelExplorerSearch.Size = new System.Drawing.Size(252, 32);
            this.panelExplorerSearch.TabIndex = 7;
            // 
            // textBoxExplorerSearch
            // 
            this.textBoxExplorerSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExplorerSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExplorerSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxExplorerSearch.Location = new System.Drawing.Point(6, 6);
            this.textBoxExplorerSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxExplorerSearch.Name = "textBoxExplorerSearch";
            this.textBoxExplorerSearch.Size = new System.Drawing.Size(240, 20);
            this.textBoxExplorerSearch.TabIndex = 3;
            this.textBoxExplorerSearch.Text = "Search";
            this.textBoxExplorerSearch.WordWrap = false;
            this.textBoxExplorerSearch.Enter += new System.EventHandler(this.textBoxExplorerSearch_Enter);
            this.textBoxExplorerSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExplorerSearch_KeyPress);
            this.textBoxExplorerSearch.Leave += new System.EventHandler(this.textBoxExplorerSearch_Leave);
            // 
            // buttonExplorerBack
            // 
            this.buttonExplorerBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExplorerBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExplorerBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonExplorerBack.FlatAppearance.BorderSize = 0;
            this.buttonExplorerBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonExplorerBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonExplorerBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonExplorerBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExplorerBack.ForeColor = System.Drawing.Color.White;
            this.buttonExplorerBack.Image = global::AnthraX.IconsNavigation._32_ArrowLeft;
            this.buttonExplorerBack.Location = new System.Drawing.Point(6, 4);
            this.buttonExplorerBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExplorerBack.Name = "buttonExplorerBack";
            this.buttonExplorerBack.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonExplorerBack.Size = new System.Drawing.Size(32, 32);
            this.buttonExplorerBack.TabIndex = 0;
            this.buttonExplorerBack.UseVisualStyleBackColor = false;
            this.buttonExplorerBack.Click += new System.EventHandler(this.buttonExplorerBack_Click);
            // 
            // buttonExplorerNext
            // 
            this.buttonExplorerNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExplorerNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExplorerNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonExplorerNext.FlatAppearance.BorderSize = 0;
            this.buttonExplorerNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonExplorerNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonExplorerNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonExplorerNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExplorerNext.ForeColor = System.Drawing.Color.White;
            this.buttonExplorerNext.Image = global::AnthraX.IconsNavigation._32_ArrowRight;
            this.buttonExplorerNext.Location = new System.Drawing.Point(42, 4);
            this.buttonExplorerNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExplorerNext.Name = "buttonExplorerNext";
            this.buttonExplorerNext.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonExplorerNext.Size = new System.Drawing.Size(32, 32);
            this.buttonExplorerNext.TabIndex = 1;
            this.buttonExplorerNext.UseVisualStyleBackColor = false;
            this.buttonExplorerNext.Click += new System.EventHandler(this.buttonExplorerNext_Click);
            // 
            // buttonExplorerGo
            // 
            this.buttonExplorerGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExplorerGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExplorerGo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonExplorerGo.FlatAppearance.BorderSize = 0;
            this.buttonExplorerGo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonExplorerGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonExplorerGo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonExplorerGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExplorerGo.ForeColor = System.Drawing.Color.White;
            this.buttonExplorerGo.Image = global::AnthraX.IconsNavigation._32_ArrowRight;
            this.buttonExplorerGo.Location = new System.Drawing.Point(498, 4);
            this.buttonExplorerGo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExplorerGo.Name = "buttonExplorerGo";
            this.buttonExplorerGo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonExplorerGo.Size = new System.Drawing.Size(32, 32);
            this.buttonExplorerGo.TabIndex = 3;
            this.buttonExplorerGo.UseVisualStyleBackColor = false;
            this.buttonExplorerGo.Click += new System.EventHandler(this.buttonExplorerGo_Click);
            // 
            // buttonExplorerSearch
            // 
            this.buttonExplorerSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExplorerSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExplorerSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonExplorerSearch.FlatAppearance.BorderSize = 0;
            this.buttonExplorerSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonExplorerSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonExplorerSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonExplorerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExplorerSearch.ForeColor = System.Drawing.Color.White;
            this.buttonExplorerSearch.Image = global::AnthraX.IconsNavigation._32_Zoom;
            this.buttonExplorerSearch.Location = new System.Drawing.Point(790, 4);
            this.buttonExplorerSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExplorerSearch.Name = "buttonExplorerSearch";
            this.buttonExplorerSearch.Size = new System.Drawing.Size(32, 32);
            this.buttonExplorerSearch.TabIndex = 5;
            this.buttonExplorerSearch.UseVisualStyleBackColor = false;
            this.buttonExplorerSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panelExplorerPath
            // 
            this.panelExplorerPath.BackColor = System.Drawing.SystemColors.Window;
            this.panelExplorerPath.Controls.Add(this.textBoxExplorerPath);
            this.panelExplorerPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExplorerPath.Location = new System.Drawing.Point(78, 4);
            this.panelExplorerPath.Margin = new System.Windows.Forms.Padding(2);
            this.panelExplorerPath.Name = "panelExplorerPath";
            this.panelExplorerPath.Padding = new System.Windows.Forms.Padding(6);
            this.panelExplorerPath.Size = new System.Drawing.Size(416, 32);
            this.panelExplorerPath.TabIndex = 6;
            // 
            // textBoxExplorerPath
            // 
            this.textBoxExplorerPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExplorerPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExplorerPath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxExplorerPath.Location = new System.Drawing.Point(6, 6);
            this.textBoxExplorerPath.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxExplorerPath.Name = "textBoxExplorerPath";
            this.textBoxExplorerPath.Size = new System.Drawing.Size(404, 20);
            this.textBoxExplorerPath.TabIndex = 3;
            this.textBoxExplorerPath.Text = "C:\\Users\\Sample";
            this.textBoxExplorerPath.WordWrap = false;
            this.textBoxExplorerPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExplorerPath_KeyPress);
            // 
            // labelExplorerTitle
            // 
            this.labelExplorerTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelExplorerTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelExplorerTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExplorerTitle.ForeColor = System.Drawing.Color.White;
            this.labelExplorerTitle.Location = new System.Drawing.Point(0, 0);
            this.labelExplorerTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelExplorerTitle.Name = "labelExplorerTitle";
            this.labelExplorerTitle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelExplorerTitle.Size = new System.Drawing.Size(828, 32);
            this.labelExplorerTitle.TabIndex = 0;
            this.labelExplorerTitle.Text = "Files Explorer";
            this.labelExplorerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tLPanelExplorerStatusbar
            // 
            this.tLPanelExplorerStatusbar.ColumnCount = 3;
            this.tLPanelExplorerStatusbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelExplorerStatusbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tLPanelExplorerStatusbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tLPanelExplorerStatusbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelExplorerStatusbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelExplorerStatusbar.Controls.Add(this.trackBarExplorerView, 1, 0);
            this.tLPanelExplorerStatusbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tLPanelExplorerStatusbar.Location = new System.Drawing.Point(0, 425);
            this.tLPanelExplorerStatusbar.Name = "tLPanelExplorerStatusbar";
            this.tLPanelExplorerStatusbar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tLPanelExplorerStatusbar.RowCount = 1;
            this.tLPanelExplorerStatusbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelExplorerStatusbar.Size = new System.Drawing.Size(828, 32);
            this.tLPanelExplorerStatusbar.TabIndex = 3;
            // 
            // trackBarExplorerView
            // 
            this.trackBarExplorerView.BackColor = System.Drawing.Color.Black;
            this.trackBarExplorerView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarExplorerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarExplorerView.Location = new System.Drawing.Point(599, 3);
            this.trackBarExplorerView.Maximum = 3;
            this.trackBarExplorerView.Name = "trackBarExplorerView";
            this.trackBarExplorerView.Size = new System.Drawing.Size(186, 26);
            this.trackBarExplorerView.TabIndex = 0;
            this.trackBarExplorerView.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarExplorerView.Value = 3;
            this.trackBarExplorerView.Scroll += new System.EventHandler(this.trackBarExplorerView_Scroll);
            // 
            // panelKaraoke
            // 
            this.panelKaraoke.Controls.Add(this.panelKaraokeText);
            this.panelKaraoke.Controls.Add(this.panelKaraokeMenubar);
            this.panelKaraoke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKaraoke.Location = new System.Drawing.Point(56, 0);
            this.panelKaraoke.Margin = new System.Windows.Forms.Padding(0);
            this.panelKaraoke.Name = "panelKaraoke";
            this.panelKaraoke.Size = new System.Drawing.Size(828, 457);
            this.panelKaraoke.TabIndex = 10;
            // 
            // panelKaraokeText
            // 
            this.panelKaraokeText.Controls.Add(this.listViewKaraoke);
            this.panelKaraokeText.Controls.Add(this.labelKaraokeName);
            this.panelKaraokeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKaraokeText.Location = new System.Drawing.Point(0, 128);
            this.panelKaraokeText.Name = "panelKaraokeText";
            this.panelKaraokeText.Size = new System.Drawing.Size(828, 329);
            this.panelKaraokeText.TabIndex = 9;
            // 
            // listViewKaraoke
            // 
            this.listViewKaraoke.AutoArrange = false;
            this.listViewKaraoke.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewKaraoke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewKaraoke.FullRowSelect = true;
            this.listViewKaraoke.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.listViewKaraoke.Location = new System.Drawing.Point(0, 32);
            this.listViewKaraoke.MultiSelect = false;
            this.listViewKaraoke.Name = "listViewKaraoke";
            this.listViewKaraoke.ShowGroups = false;
            this.listViewKaraoke.Size = new System.Drawing.Size(828, 297);
            this.listViewKaraoke.TabIndex = 3;
            this.listViewKaraoke.UseCompatibleStateImageBehavior = false;
            this.listViewKaraoke.View = System.Windows.Forms.View.Details;
            this.listViewKaraoke.ItemActivate += new System.EventHandler(this.listViewKaraoke_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Text";
            this.columnHeader2.Width = 512;
            // 
            // labelKaraokeName
            // 
            this.labelKaraokeName.BackColor = System.Drawing.Color.Transparent;
            this.labelKaraokeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelKaraokeName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKaraokeName.ForeColor = System.Drawing.Color.White;
            this.labelKaraokeName.Location = new System.Drawing.Point(0, 0);
            this.labelKaraokeName.Margin = new System.Windows.Forms.Padding(0);
            this.labelKaraokeName.Name = "labelKaraokeName";
            this.labelKaraokeName.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelKaraokeName.Size = new System.Drawing.Size(828, 32);
            this.labelKaraokeName.TabIndex = 8;
            this.labelKaraokeName.Text = "Sound File Name";
            this.labelKaraokeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelKaraokeMenubar
            // 
            this.panelKaraokeMenubar.Controls.Add(this.fLPanelKaraokeSettings);
            this.panelKaraokeMenubar.Controls.Add(this.tLPanelKaraokeMenu);
            this.panelKaraokeMenubar.Controls.Add(this.labelKaraokeTitle);
            this.panelKaraokeMenubar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKaraokeMenubar.Location = new System.Drawing.Point(0, 0);
            this.panelKaraokeMenubar.Margin = new System.Windows.Forms.Padding(0);
            this.panelKaraokeMenubar.Name = "panelKaraokeMenubar";
            this.panelKaraokeMenubar.Size = new System.Drawing.Size(828, 128);
            this.panelKaraokeMenubar.TabIndex = 1;
            // 
            // fLPanelKaraokeSettings
            // 
            this.fLPanelKaraokeSettings.Controls.Add(this.checkBoxKaraokeEnable);
            this.fLPanelKaraokeSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPanelKaraokeSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fLPanelKaraokeSettings.Location = new System.Drawing.Point(0, 96);
            this.fLPanelKaraokeSettings.Margin = new System.Windows.Forms.Padding(0);
            this.fLPanelKaraokeSettings.Name = "fLPanelKaraokeSettings";
            this.fLPanelKaraokeSettings.Size = new System.Drawing.Size(828, 32);
            this.fLPanelKaraokeSettings.TabIndex = 3;
            // 
            // checkBoxKaraokeEnable
            // 
            this.checkBoxKaraokeEnable.AutoSize = true;
            this.checkBoxKaraokeEnable.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxKaraokeEnable.ForeColor = System.Drawing.Color.White;
            this.checkBoxKaraokeEnable.Location = new System.Drawing.Point(8, 5);
            this.checkBoxKaraokeEnable.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.checkBoxKaraokeEnable.Name = "checkBoxKaraokeEnable";
            this.checkBoxKaraokeEnable.Size = new System.Drawing.Size(338, 22);
            this.checkBoxKaraokeEnable.TabIndex = 0;
            this.checkBoxKaraokeEnable.Text = "Show Karaoke text if it is loaded or exists in library";
            this.checkBoxKaraokeEnable.UseVisualStyleBackColor = true;
            this.checkBoxKaraokeEnable.CheckedChanged += new System.EventHandler(this.checkBoxKaraokeEnable_CheckedChanged);
            // 
            // tLPanelKaraokeMenu
            // 
            this.tLPanelKaraokeMenu.BackColor = System.Drawing.Color.Transparent;
            this.tLPanelKaraokeMenu.ColumnCount = 8;
            this.tLPanelKaraokeMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelKaraokeMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelKaraokeMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelKaraokeMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelKaraokeMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelKaraokeMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelKaraokeMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelKaraokeMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tLPanelKaraokeMenu.Controls.Add(this.buttonKaraokeRemoveLine, 5, 0);
            this.tLPanelKaraokeMenu.Controls.Add(this.buttonKaraokeAddLine, 4, 0);
            this.tLPanelKaraokeMenu.Controls.Add(this.buttonKaraokeSaveAs, 3, 0);
            this.tLPanelKaraokeMenu.Controls.Add(this.buttonKaraokeSave, 2, 0);
            this.tLPanelKaraokeMenu.Controls.Add(this.buttonOpen, 1, 0);
            this.tLPanelKaraokeMenu.Controls.Add(this.buttonKaraokeNew, 0, 0);
            this.tLPanelKaraokeMenu.Controls.Add(this.labelKaraokeTime, 7, 0);
            this.tLPanelKaraokeMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tLPanelKaraokeMenu.Location = new System.Drawing.Point(0, 32);
            this.tLPanelKaraokeMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tLPanelKaraokeMenu.Name = "tLPanelKaraokeMenu";
            this.tLPanelKaraokeMenu.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tLPanelKaraokeMenu.RowCount = 1;
            this.tLPanelKaraokeMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelKaraokeMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelKaraokeMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelKaraokeMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelKaraokeMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelKaraokeMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelKaraokeMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelKaraokeMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tLPanelKaraokeMenu.Size = new System.Drawing.Size(828, 64);
            this.tLPanelKaraokeMenu.TabIndex = 1;
            // 
            // buttonKaraokeRemoveLine
            // 
            this.buttonKaraokeRemoveLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKaraokeRemoveLine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonKaraokeRemoveLine.FlatAppearance.BorderSize = 0;
            this.buttonKaraokeRemoveLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonKaraokeRemoveLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonKaraokeRemoveLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonKaraokeRemoveLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKaraokeRemoveLine.ForeColor = System.Drawing.Color.White;
            this.buttonKaraokeRemoveLine.Image = global::AnthraX.IconsNavigation._32_Remove;
            this.buttonKaraokeRemoveLine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonKaraokeRemoveLine.Location = new System.Drawing.Point(326, 2);
            this.buttonKaraokeRemoveLine.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKaraokeRemoveLine.Name = "buttonKaraokeRemoveLine";
            this.buttonKaraokeRemoveLine.Size = new System.Drawing.Size(60, 60);
            this.buttonKaraokeRemoveLine.TabIndex = 11;
            this.buttonKaraokeRemoveLine.Text = "Remove";
            this.buttonKaraokeRemoveLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonKaraokeRemoveLine.UseVisualStyleBackColor = true;
            this.buttonKaraokeRemoveLine.Click += new System.EventHandler(this.buttonKaraokeRemoveLine_Click);
            // 
            // buttonKaraokeAddLine
            // 
            this.buttonKaraokeAddLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKaraokeAddLine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonKaraokeAddLine.FlatAppearance.BorderSize = 0;
            this.buttonKaraokeAddLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonKaraokeAddLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonKaraokeAddLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonKaraokeAddLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKaraokeAddLine.ForeColor = System.Drawing.Color.White;
            this.buttonKaraokeAddLine.Image = global::AnthraX.IconsNavigation._32_Add;
            this.buttonKaraokeAddLine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonKaraokeAddLine.Location = new System.Drawing.Point(262, 2);
            this.buttonKaraokeAddLine.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKaraokeAddLine.Name = "buttonKaraokeAddLine";
            this.buttonKaraokeAddLine.Size = new System.Drawing.Size(60, 60);
            this.buttonKaraokeAddLine.TabIndex = 10;
            this.buttonKaraokeAddLine.Text = "Add Line";
            this.buttonKaraokeAddLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonKaraokeAddLine.UseVisualStyleBackColor = true;
            this.buttonKaraokeAddLine.Click += new System.EventHandler(this.buttonKaraokeAddLine_Click);
            // 
            // buttonKaraokeSaveAs
            // 
            this.buttonKaraokeSaveAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKaraokeSaveAs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonKaraokeSaveAs.FlatAppearance.BorderSize = 0;
            this.buttonKaraokeSaveAs.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonKaraokeSaveAs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonKaraokeSaveAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonKaraokeSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKaraokeSaveAs.ForeColor = System.Drawing.Color.White;
            this.buttonKaraokeSaveAs.Image = global::AnthraX.IconsNavigation._32_Save;
            this.buttonKaraokeSaveAs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonKaraokeSaveAs.Location = new System.Drawing.Point(198, 2);
            this.buttonKaraokeSaveAs.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKaraokeSaveAs.Name = "buttonKaraokeSaveAs";
            this.buttonKaraokeSaveAs.Size = new System.Drawing.Size(60, 60);
            this.buttonKaraokeSaveAs.TabIndex = 7;
            this.buttonKaraokeSaveAs.Text = "Save As";
            this.buttonKaraokeSaveAs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonKaraokeSaveAs.UseVisualStyleBackColor = true;
            this.buttonKaraokeSaveAs.Click += new System.EventHandler(this.buttonKaraokeSaveAs_Click);
            // 
            // buttonKaraokeSave
            // 
            this.buttonKaraokeSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKaraokeSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonKaraokeSave.FlatAppearance.BorderSize = 0;
            this.buttonKaraokeSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonKaraokeSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonKaraokeSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonKaraokeSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKaraokeSave.ForeColor = System.Drawing.Color.White;
            this.buttonKaraokeSave.Image = global::AnthraX.IconsNavigation._32_Save;
            this.buttonKaraokeSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonKaraokeSave.Location = new System.Drawing.Point(134, 2);
            this.buttonKaraokeSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKaraokeSave.Name = "buttonKaraokeSave";
            this.buttonKaraokeSave.Size = new System.Drawing.Size(60, 60);
            this.buttonKaraokeSave.TabIndex = 1;
            this.buttonKaraokeSave.Text = "Save";
            this.buttonKaraokeSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonKaraokeSave.UseVisualStyleBackColor = true;
            this.buttonKaraokeSave.Click += new System.EventHandler(this.buttonKaraokeSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonOpen.FlatAppearance.BorderSize = 0;
            this.buttonOpen.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.ForeColor = System.Drawing.Color.White;
            this.buttonOpen.Image = global::AnthraX.IconsNavigation._32_Open;
            this.buttonOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOpen.Location = new System.Drawing.Point(70, 2);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(60, 60);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonKaraokeNew
            // 
            this.buttonKaraokeNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKaraokeNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.buttonKaraokeNew.FlatAppearance.BorderSize = 0;
            this.buttonKaraokeNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonKaraokeNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.buttonKaraokeNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonKaraokeNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKaraokeNew.ForeColor = System.Drawing.Color.White;
            this.buttonKaraokeNew.Image = global::AnthraX.IconsNavigation._32_NewFile;
            this.buttonKaraokeNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonKaraokeNew.Location = new System.Drawing.Point(6, 2);
            this.buttonKaraokeNew.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKaraokeNew.Name = "buttonKaraokeNew";
            this.buttonKaraokeNew.Size = new System.Drawing.Size(60, 60);
            this.buttonKaraokeNew.TabIndex = 8;
            this.buttonKaraokeNew.Text = "New";
            this.buttonKaraokeNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonKaraokeNew.UseVisualStyleBackColor = true;
            this.buttonKaraokeNew.Click += new System.EventHandler(this.buttonKaraokeNew_Click);
            // 
            // labelKaraokeTime
            // 
            this.labelKaraokeTime.AutoSize = true;
            this.labelKaraokeTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelKaraokeTime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKaraokeTime.ForeColor = System.Drawing.Color.White;
            this.labelKaraokeTime.Location = new System.Drawing.Point(635, 0);
            this.labelKaraokeTime.Name = "labelKaraokeTime";
            this.labelKaraokeTime.Size = new System.Drawing.Size(186, 64);
            this.labelKaraokeTime.TabIndex = 9;
            this.labelKaraokeTime.Text = "Variable Time: 0";
            this.labelKaraokeTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKaraokeTitle
            // 
            this.labelKaraokeTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelKaraokeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelKaraokeTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKaraokeTitle.ForeColor = System.Drawing.Color.White;
            this.labelKaraokeTitle.Location = new System.Drawing.Point(0, 0);
            this.labelKaraokeTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelKaraokeTitle.Name = "labelKaraokeTitle";
            this.labelKaraokeTitle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelKaraokeTitle.Size = new System.Drawing.Size(828, 32);
            this.labelKaraokeTitle.TabIndex = 0;
            this.labelKaraokeTitle.Text = "Karaoke";
            this.labelKaraokeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.ContextMenuStrip = this.notifyIconContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "AnthraX";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // notifyIconContextMenu
            // 
            this.notifyIconContextMenu.BackColor = System.Drawing.SystemColors.Control;
            this.notifyIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAnthraX,
            this.toolStripSeparator1,
            this.toolStripMenuItemPlay,
            this.toolStripMenuItemPrevious,
            this.toolStripMenuItemNext,
            this.toolStripMenuItemStop,
            this.toolStripSeparator2,
            this.toolStripMenuItemExit});
            this.notifyIconContextMenu.Name = "notifyIconContextMenu";
            this.notifyIconContextMenu.Size = new System.Drawing.Size(168, 148);
            // 
            // toolStripMenuItemAnthraX
            // 
            this.toolStripMenuItemAnthraX.Name = "toolStripMenuItemAnthraX";
            this.toolStripMenuItemAnthraX.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItemAnthraX.Text = "AnthraX";
            this.toolStripMenuItemAnthraX.Click += new System.EventHandler(this.toolStripMenuItemAnthraX_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // toolStripMenuItemPlay
            // 
            this.toolStripMenuItemPlay.Image = global::AnthraX.IconsControl._32_Black_Play;
            this.toolStripMenuItemPlay.Name = "toolStripMenuItemPlay";
            this.toolStripMenuItemPlay.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItemPlay.Text = "Play / Pause";
            this.toolStripMenuItemPlay.Click += new System.EventHandler(this.toolStripMenuItemPlay_Click);
            // 
            // toolStripMenuItemPrevious
            // 
            this.toolStripMenuItemPrevious.Image = global::AnthraX.IconsControl._32_Black_Backward;
            this.toolStripMenuItemPrevious.Name = "toolStripMenuItemPrevious";
            this.toolStripMenuItemPrevious.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItemPrevious.Text = "Previous Track";
            this.toolStripMenuItemPrevious.Click += new System.EventHandler(this.toolStripMenuItemPrevious_Click);
            // 
            // toolStripMenuItemNext
            // 
            this.toolStripMenuItemNext.Image = global::AnthraX.IconsControl._32_Black_Forward;
            this.toolStripMenuItemNext.Name = "toolStripMenuItemNext";
            this.toolStripMenuItemNext.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItemNext.Text = "Next Track";
            this.toolStripMenuItemNext.Click += new System.EventHandler(this.toolStripMenuItemNext_Click);
            // 
            // toolStripMenuItemStop
            // 
            this.toolStripMenuItemStop.Image = global::AnthraX.IconsControl._32_Black_Stop;
            this.toolStripMenuItemStop.Name = "toolStripMenuItemStop";
            this.toolStripMenuItemStop.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItemStop.Text = "Stop";
            this.toolStripMenuItemStop.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItemStop.Click += new System.EventHandler(this.toolStripMenuItemStop_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItemExit.Text = "Close Application";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // FormAnthraX
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelClient);
            this.Controls.Add(this.panelControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAnthraX";
            this.Text = "AnthraX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormAnthraX_DragEnter);
            this.Move += new System.EventHandler(this.FormMain_Move);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.panelControl.ResumeLayout(false);
            this.tLPanelInfo.ResumeLayout(false);
            this.tLPanelInfo.PerformLayout();
            this.panelVolume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalystVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.panelSlider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalystSlider)).EndInit();
            this.fLPanelMenu.ResumeLayout(false);
            this.panelVis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalystVis)).EndInit();
            this.tlPanelPlayList.ResumeLayout(false);
            this.tlPanelPlayList.PerformLayout();
            this.fLPanelPlayListMenu.ResumeLayout(false);
            this.panelClient.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.fLPanelSettingsInfo.ResumeLayout(false);
            this.fLPanelSettingsInfo.PerformLayout();
            this.fLPanelSettingsGeneral.ResumeLayout(false);
            this.fLPanelSettingsGeneral.PerformLayout();
            this.fLPanelSettingsPlayer.ResumeLayout(false);
            this.fLPanelSettingsPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlayerInfo)).EndInit();
            this.fLPanelSettingsSound.ResumeLayout(false);
            this.fLPanelSettingsSound.PerformLayout();
            this.fLPanelSoundDevices.ResumeLayout(false);
            this.fLPanelSettingsTheme.ResumeLayout(false);
            this.fLPanelSettingsTheme.PerformLayout();
            this.fLPanelThemeCustomColor.ResumeLayout(false);
            this.fLPanelThemeWallpaperCustomColor.ResumeLayout(false);
            this.fLPanelThemeWallpaper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThemeWallpaper01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThemeWallpaper02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThemeWallpaper03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThemeWallpaper04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThemeWallpaper05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThemeWallpaper06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThemeTransparency)).EndInit();
            this.fLPanelSettingsVisualisation.ResumeLayout(false);
            this.fLPanelSettingsVisualisation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVisualisationSize)).EndInit();
            this.fLPanelVisualisationCustomColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVisualisationColorSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVisualisationColorRainbow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVisualisationTransparency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVisualisationSensitivity)).EndInit();
            this.tLPanelSettingsMenu.ResumeLayout(false);
            this.tLPanelSettingsMenu.PerformLayout();
            this.panelLibrary.ResumeLayout(false);
            this.panelLibraryFiles.ResumeLayout(false);
            this.panelLibraryToolbar.ResumeLayout(false);
            this.tLPanelLibraryTools.ResumeLayout(false);
            this.panelLibraryMenubar.ResumeLayout(false);
            this.tLPanelLibraryMenu.ResumeLayout(false);
            this.panelLibrarySort.ResumeLayout(false);
            this.panelEqualizer.ResumeLayout(false);
            this.fLPanelEffects.ResumeLayout(false);
            this.fLPanelEffects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsAmplification)).EndInit();
            this.panelEffectsAmplification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsSaturationDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsStereoEnhancerWide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsStereoEnhancerDryWet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsIIRDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsIIRDelayDryWet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsIIRDelayFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsEcho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsReverb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEffectsChorus)).EndInit();
            this.tLPanelEqualizer.ResumeLayout(false);
            this.tLPanelEqualizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer18kHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer16kHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer14kHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer12kHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer10kHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer8kHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer6kHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer4kHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer2kHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqualizer50Hz)).EndInit();
            this.panelEqualizerPresetName.ResumeLayout(false);
            this.tLPanelEqualizerStatusbar.ResumeLayout(false);
            this.panelEqualizerToolbar.ResumeLayout(false);
            this.tLPanelEqualizerTools.ResumeLayout(false);
            this.panelEqualizerTitleBar.ResumeLayout(false);
            this.panelExplorer.ResumeLayout(false);
            this.panelExplorerToolbar.ResumeLayout(false);
            this.panelExplorerMenubar.ResumeLayout(false);
            this.tLPanelExplorerOptions.ResumeLayout(false);
            this.panelExplorerFilter.ResumeLayout(false);
            this.tLPanelExplorerNavigation.ResumeLayout(false);
            this.panelExplorerSearch.ResumeLayout(false);
            this.panelExplorerSearch.PerformLayout();
            this.panelExplorerPath.ResumeLayout(false);
            this.panelExplorerPath.PerformLayout();
            this.tLPanelExplorerStatusbar.ResumeLayout(false);
            this.tLPanelExplorerStatusbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExplorerView)).EndInit();
            this.panelKaraoke.ResumeLayout(false);
            this.panelKaraokeText.ResumeLayout(false);
            this.panelKaraokeMenubar.ResumeLayout(false);
            this.fLPanelKaraokeSettings.ResumeLayout(false);
            this.fLPanelKaraokeSettings.PerformLayout();
            this.tLPanelKaraokeMenu.ResumeLayout(false);
            this.tLPanelKaraokeMenu.PerformLayout();
            this.notifyIconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelSlider;
        private System.Windows.Forms.FlowLayoutPanel fLPanelMenu;
        private System.Windows.Forms.Panel panelVis;
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonLibrary;
        private System.Windows.Forms.Button buttonFileExplorer;
        private System.Windows.Forms.Button buttonEqualizer;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Button buttonShuffle;
        private System.Windows.Forms.Button buttonVolume;
        private System.Windows.Forms.Panel panelVolume;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRepeat;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TableLayoutPanel tLPanelInfo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.TableLayoutPanel tlPanelPlayList;
        private System.Windows.Forms.Panel panelPlayListSplit;
        private System.Windows.Forms.Label labelPlayListTitle;
        private System.Windows.Forms.FlowLayoutPanel fLPanelPlayListMenu;
        private System.Windows.Forms.Button buttonPlayListOpen;
        private System.Windows.Forms.Button buttonPlayListSave;
        private System.Windows.Forms.Button buttonPlayListDelete;
        private System.Windows.Forms.Button buttonPlayListMoveUp;
        private System.Windows.Forms.Button buttonPlayListMoveDown;
        private System.Windows.Forms.Button buttonPlayListSort;
        private System.Windows.Forms.Panel panelPlayListMenuOffset;
        private System.Windows.Forms.ListView listViewNowPlaying;
        private System.Windows.Forms.ImageList imageListNowPlaying;
        private System.Windows.Forms.Panel panelLibrary;
        private System.Windows.Forms.Panel panelEqualizer;
        private System.Windows.Forms.Panel panelExplorer;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.TableLayoutPanel tLPanelSettingsMenu;
        private System.Windows.Forms.Label labelSettingsMenuTitle;
        private System.Windows.Forms.ImageList imageListSettingsMenu;
        private System.Windows.Forms.TreeView treeViewSettingsMenu;
        private System.Windows.Forms.FlowLayoutPanel fLPanelSettingsInfo;
        private System.Windows.Forms.Panel panelSettingsBorder;
        private System.Windows.Forms.FlowLayoutPanel fLPanelSettingsSound;
        private System.Windows.Forms.FlowLayoutPanel fLPanelSettingsPlayer;
        private System.Windows.Forms.FlowLayoutPanel fLPanelSettingsTheme;
        private System.Windows.Forms.FlowLayoutPanel fLPanelSettingsVisualisation;
        private System.Windows.Forms.Label labelInfoTitle;
        private System.Windows.Forms.Label labelSettingsPlayerTitle;
        private System.Windows.Forms.Label labelSoundTitle;
        private System.Windows.Forms.Label labelThemeTitle;
        private System.Windows.Forms.Label labelSettingsVisualisationTitle;
        private System.Windows.Forms.Label labelSoundDevice;
        private System.Windows.Forms.ComboBox comboBoxSoundDevices;
        private System.Windows.Forms.FlowLayoutPanel fLPanelSoundDevices;
        private System.Windows.Forms.Button buttonSoundDevicesRefresh;
        private System.Windows.Forms.Label labelThemeColor;
        private System.Windows.Forms.ComboBox comboBoxThemeColor;
        private System.Windows.Forms.FlowLayoutPanel fLPanelThemeCustomColor;
        private System.Windows.Forms.Button buttonThemeCustomColor;
        private System.Windows.Forms.Label labelThemeWallpaper;
        private System.Windows.Forms.ComboBox comboBoxThemeWallpaper;
        private System.Windows.Forms.Label labelThemeWallpaperColor;
        private System.Windows.Forms.ComboBox comboBoxThemeWallpaperColor;
        private System.Windows.Forms.FlowLayoutPanel fLPanelThemeWallpaperCustomColor;
        private System.Windows.Forms.Button buttonThemeWallpaperCustomColor;
        private System.Windows.Forms.FlowLayoutPanel fLPanelThemeWallpaper;
        private System.Windows.Forms.PictureBox pictureBoxThemeWallpaper01;
        private System.Windows.Forms.PictureBox pictureBoxThemeWallpaper02;
        private System.Windows.Forms.PictureBox pictureBoxThemeWallpaper03;
        private System.Windows.Forms.PictureBox pictureBoxThemeWallpaper04;
        private System.Windows.Forms.PictureBox pictureBoxThemeWallpaper05;
        private System.Windows.Forms.PictureBox pictureBoxThemeWallpaper06;
        private System.Windows.Forms.CheckBox checkBoxThemeTransparency;
        private System.Windows.Forms.TrackBar trackBarThemeTransparency;
        private System.Windows.Forms.Label labelThemeWallpaperPosition;
        private System.Windows.Forms.ComboBox comboBoxThemeWallpaperPosition;
        private System.Windows.Forms.Button buttonSettingsSave;
        private System.Windows.Forms.CheckBox checkBoxThemeDarkTheme;
        private System.Windows.Forms.Label labelThemeSubTitleColors;
        private System.Windows.Forms.Label labelThemeSubTitleWallpaper;
        private System.Windows.Forms.Label labelThemeSubTitleMore;
        private System.Windows.Forms.Label labelInfoSubTitleMain;
        private System.Windows.Forms.Label labelInfoMain;
        private System.Windows.Forms.Label labelInfoSubTitleCopyrights;
        private System.Windows.Forms.Label labelInfoCopyrightsCode;
        private System.Windows.Forms.Label labelInfoSubTitleVersions;
        private System.Windows.Forms.Label labelInfoVersionAlpha;
        private System.Windows.Forms.Label labelInfoAuthor;
        private System.Windows.Forms.Label labelInfoCompany;
        private System.Windows.Forms.Label labelInfoCompiler;
        private System.Windows.Forms.Label labelInfoPlatform;
        private System.Windows.Forms.Label labelInfoVersion;
        private System.Windows.Forms.Label labelInfoCopyrightDll;
        private System.Windows.Forms.Label labelInfoCopyrightBassDll;
        private System.Windows.Forms.Label labelInfoCopyrightBassNet;
        private System.Windows.Forms.Label labelInfoCopyrightIcons;
        private System.Windows.Forms.Label labelInfoCopyrightIconsDevine;
        private System.Windows.Forms.Label labelInfoCopyrightIconsGinux;
        private System.Windows.Forms.Label labelInfoCopyrightIconsGnome;
        private System.Windows.Forms.Label labelInfoCopyrightIconsWindows8;
        private System.Windows.Forms.Label labelInfoCopyrightImage;
        private System.Windows.Forms.Label labelInfoCopyrightImage284301;
        private System.Windows.Forms.Label labelInfoCopyrightImage105358;
        private System.Windows.Forms.Label labelInfoCopyrightImage411175;
        private System.Windows.Forms.Label labelInfoCopyrightImage70937;
        private System.Windows.Forms.Label labelInfoCopyrightImage87577;
        private System.Windows.Forms.Label labelInfoVersionEnd;
        private System.Windows.Forms.PictureBox pictureBoxCatalystVis;
        private System.Windows.Forms.PictureBox pictureBoxCatalystSlider;
        private System.Windows.Forms.PictureBox pictureBoxCatalystVolume;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.ComboBox comboBoxThemeType;
        private System.Windows.Forms.Label labelThemeCustomColor;
        private System.Windows.Forms.Label labelThemeWallpaperCustomColor;
        private System.Windows.Forms.Label labelVisualisationSubTitleType;
        private System.Windows.Forms.Label labelVisualisationType;
        private System.Windows.Forms.ComboBox comboBoxVisualisationType;
        private System.Windows.Forms.Label labelVisualisationSubTitleStyle;
        private System.Windows.Forms.Label labelVisualisationColorScheme;
        private System.Windows.Forms.ComboBox comboBoxVisualisationColorType;
        private System.Windows.Forms.Label labelVisualisationColor;
        private System.Windows.Forms.ComboBox comboBoxVisualisationColor;
        private System.Windows.Forms.FlowLayoutPanel fLPanelVisualisationCustomColor;
        private System.Windows.Forms.Button buttonVisualisationCustomColor;
        private System.Windows.Forms.Label labelVisualisationCustomColor;
        private System.Windows.Forms.Label labelVisualisationSubTitleOptions;
        private System.Windows.Forms.Label labelVisualisationFill;
        private System.Windows.Forms.ComboBox comboBoxVisualisationFill;
        private System.Windows.Forms.Label labelVisualisationSensitivity;
        private System.Windows.Forms.CheckBox checkBoxVisualisationTransparency;
        private System.Windows.Forms.TrackBar trackBarVisualisationTransparency;
        private System.Windows.Forms.TrackBar trackBarVisualisationSensitivity;
        private System.Windows.Forms.Label labelVisualisationSize;
        private System.Windows.Forms.TrackBar trackBarVisualisationSize;
        private System.Windows.Forms.Label labelPlayerSubTitleInfo;
        private System.Windows.Forms.Label labelPlayerInfo;
        private System.Windows.Forms.TrackBar trackBarPlayerInfo;
        private System.Windows.Forms.CheckBox checkBoxPlayerNotification;
        private System.Windows.Forms.Label labelPlayerSubTitlePlayer;
        private System.Windows.Forms.CheckBox checkBoxPlayerAutoPlay;
        private System.Windows.Forms.CheckBox checkBoxPlayerAutoComeback;
        private System.Windows.Forms.Label labelVisualisationSubTitleLogo;
        private System.Windows.Forms.Label labelVisualisationLogo;
        private System.Windows.Forms.ComboBox comboBoxVisualisationLogo;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAnthraX;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPlay;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPrevious;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNext;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label labelVisualisationColorSpeed;
        private System.Windows.Forms.TrackBar trackBarVisualisationColorSpeed;
        private System.Windows.Forms.Label labelVisualisationColorRainbow;
        private System.Windows.Forms.TrackBar trackBarVisualisationColorRainbow;
        private System.Windows.Forms.Panel panelExplorerToolbar;
        private System.Windows.Forms.Panel panelExplorerMenubar;
        private System.Windows.Forms.Label labelExplorerTitle;
        private System.Windows.Forms.TableLayoutPanel tLPanelExplorerOptions;
        private System.Windows.Forms.TableLayoutPanel tLPanelExplorerNavigation;
        private System.Windows.Forms.Button buttonExplorerFilter;
        private System.Windows.Forms.Button buttonExplorerBack;
        private System.Windows.Forms.Button buttonExplorerNext;
        private System.Windows.Forms.Button buttonExplorerGo;
        private System.Windows.Forms.Button buttonExplorerSearch;
        private System.Windows.Forms.Panel panelExplorerPath;
        private System.Windows.Forms.TextBox textBoxExplorerPath;
        private System.Windows.Forms.Panel panelExplorerSearch;
        private System.Windows.Forms.TextBox textBoxExplorerSearch;
        private System.Windows.Forms.Panel panelExplorerFilter;
        private System.Windows.Forms.ComboBox comboBoxExplorerFilter;
        private System.Windows.Forms.ComboBox comboBoxExplorerDisks;
        private System.Windows.Forms.TreeView treeViewExplorerDirectories;
        private System.Windows.Forms.ListView listViewExplorerFiles;
        private System.Windows.Forms.TableLayoutPanel tLPanelExplorerStatusbar;
        private System.Windows.Forms.TrackBar trackBarExplorerView;
        private System.Windows.Forms.Panel panelLibraryMenubar;
        private System.Windows.Forms.TableLayoutPanel tLPanelLibraryMenu;
        private System.Windows.Forms.Label labelLibraryTitle;
        private System.Windows.Forms.Panel panelLibraryToolbar;
        private System.Windows.Forms.Label labelLibraryInfo;
        private System.Windows.Forms.TreeView treeViewLibraryPlaylists;
        private System.Windows.Forms.ListView listViewLibrary;
        private System.Windows.Forms.TableLayoutPanel tLPanelLibraryTools;
        private System.Windows.Forms.Button buttonLibraryRemovePlaylist;
        private System.Windows.Forms.Button buttonLibraryAddPlaylist;
        private System.Windows.Forms.Button buttonLibrarySave;
        private System.Windows.Forms.Button buttonLibraryOpen;
        private System.Windows.Forms.Panel panelLibrarySort;
        private System.Windows.Forms.ComboBox comboBoxLibrarySort;
        private System.Windows.Forms.Button buttonLibrarySort;
        private System.Windows.Forms.Button buttonLibraryMoveTo;
        private System.Windows.Forms.Button buttonLibraryRemove;
        private System.Windows.Forms.Button buttonLibraryClear;
        private System.Windows.Forms.ImageList imageListLibraryMenu;
        private System.Windows.Forms.TableLayoutPanel tLPanelEqualizerStatusbar;
        private System.Windows.Forms.Button buttonEqualizerSaveto;
        private System.Windows.Forms.Button buttonEqualizerReset;
        private System.Windows.Forms.Button buttonEqualizerSave;
        private System.Windows.Forms.Panel panelEqualizerToolbar;
        private System.Windows.Forms.TableLayoutPanel tLPanelEqualizerTools;
        private System.Windows.Forms.Button buttonEqualizerPresetRemove;
        private System.Windows.Forms.Button buttonEqualizerPresetAdd;
        private System.Windows.Forms.TreeView treeViewEqualizerMenu;
        private System.Windows.Forms.Label labelEqualizerInfo;
        private System.Windows.Forms.Label labelEqualizerTitle;
        private System.Windows.Forms.TableLayoutPanel tLPanelEqualizer;
        private System.Windows.Forms.ImageList imageListEqualizerMenu;
        private System.Windows.Forms.TrackBar trackBarEqualizer18kHz;
        private System.Windows.Forms.TrackBar trackBarEqualizer16kHz;
        private System.Windows.Forms.TrackBar trackBarEqualizer14kHz;
        private System.Windows.Forms.TrackBar trackBarEqualizer12kHz;
        private System.Windows.Forms.TrackBar trackBarEqualizer10kHz;
        private System.Windows.Forms.TrackBar trackBarEqualizer8kHz;
        private System.Windows.Forms.TrackBar trackBarEqualizer6kHz;
        private System.Windows.Forms.TrackBar trackBarEqualizer4kHz;
        private System.Windows.Forms.TrackBar trackBarEqualizer2kHz;
        private System.Windows.Forms.TrackBar trackBarEqualizer50Hz;
        private System.Windows.Forms.Label labelEqualizer18kHzInfo;
        private System.Windows.Forms.Label labelEqualizer16kHzInfo;
        private System.Windows.Forms.Label labelEqualizer14kHzInfo;
        private System.Windows.Forms.Label labelEqualizer12kHzInfo;
        private System.Windows.Forms.Label labelEqualizer10kHzInfo;
        private System.Windows.Forms.Label labelEqualizer8kHzInfo;
        private System.Windows.Forms.Label labelEqualizer6kHzInfo;
        private System.Windows.Forms.Label labelEqualizer4kHzInfo;
        private System.Windows.Forms.Label labelEqualizer2kHzInfo;
        private System.Windows.Forms.Label labelEqualizer50HzInfo;
        private System.Windows.Forms.Label labelEqualizer18kHzValue;
        private System.Windows.Forms.Label labelEqualizer50HzValue;
        private System.Windows.Forms.Label labelEqualizer2kHzValue;
        private System.Windows.Forms.Label labelEqualizer4kHzValue;
        private System.Windows.Forms.Label labelEqualizer6kHzValue;
        private System.Windows.Forms.Label labelEqualizer8kHzValue;
        private System.Windows.Forms.Label labelEqualizer10kHzValue;
        private System.Windows.Forms.Label labelEqualizer12kHzValue;
        private System.Windows.Forms.Label labelEqualizer14kHzValue;
        private System.Windows.Forms.Label labelEqualizer16kHzValue;
        private System.Windows.Forms.FlowLayoutPanel fLPanelEffects;
        private System.Windows.Forms.Label labelEffectsTitle;
        private System.Windows.Forms.Label labelEffectsAmplification;
        private System.Windows.Forms.TrackBar trackBarEffectsAmplification;
        private System.Windows.Forms.Panel panelEffectsAmplification;
        private System.Windows.Forms.Label labelEffectsAmplificationMax;
        private System.Windows.Forms.Label labelEffectsAmplificationMin;
        private System.Windows.Forms.CheckBox checkBoxEffectsSoftSaturation;
        private System.Windows.Forms.Label labelEffectsSaturation;
        private System.Windows.Forms.TrackBar trackBarEffectsSaturation;
        private System.Windows.Forms.Label labelEffectsSaturationDepth;
        private System.Windows.Forms.TrackBar trackBarEffectsSaturationDepth;
        private System.Windows.Forms.CheckBox checkBoxEffectsStereoEnhancer;
        private System.Windows.Forms.Label labelEffectsStereoEnhancerWide;
        private System.Windows.Forms.TrackBar trackBarEffectsStereoEnhancerWide;
        private System.Windows.Forms.Label labelEffectsStereoEnhancerDryWet;
        private System.Windows.Forms.TrackBar trackBarEffectsStereoEnhancerDryWet;
        private System.Windows.Forms.CheckBox checkBoxEffectsIIRDelay;
        private System.Windows.Forms.Label labelEffectsIIRDelay;
        private System.Windows.Forms.TrackBar trackBarEffectsIIRDelay;
        private System.Windows.Forms.Label labelEffectsIIRDelayDryWet;
        private System.Windows.Forms.TrackBar trackBarEffectsIIRDelayDryWet;
        private System.Windows.Forms.Label labelEffectsIIRDelayFeedback;
        private System.Windows.Forms.TrackBar trackBarEffectsIIRDelayFeedback;
        private System.Windows.Forms.CheckBox checkBoxEffectsEcho;
        private System.Windows.Forms.TrackBar trackBarEffectsEcho;
        private System.Windows.Forms.CheckBox checkBoxEffectsChorus;
        private System.Windows.Forms.TrackBar trackBarEffectsChorus;
        private System.Windows.Forms.Label labelEqualizerPresetName;
        private System.Windows.Forms.Label labelLibraryName;
        private System.Windows.Forms.ImageList imageListFiles;
        private System.Windows.Forms.Button buttonLibrarySaveAs;
        private System.Windows.Forms.Button buttonLibraryNew;
        private System.Windows.Forms.ColumnHeader columnHeaderFileName;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderArtist;
        private System.Windows.Forms.ColumnHeader columnHeaderAlbum;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.Button buttonLibraryNowPlay;
        private System.Windows.Forms.CheckBox checkBoxEffectsReverb;
        private System.Windows.Forms.TrackBar trackBarEffectsReverb;
        private System.Windows.Forms.Label labelSoundPeaks;
        private System.Windows.Forms.ProgressBar progressBarSoundLeft;
        private System.Windows.Forms.ProgressBar progressBarSoundRight;
        private System.Windows.Forms.FlowLayoutPanel fLPanelSettingsGeneral;
        private System.Windows.Forms.Label labelGneralTitle;
        private System.Windows.Forms.Label labelGeneralSubTitleAnimations;
        private System.Windows.Forms.CheckBox checkBoxGeneralAnimSpec;
        private System.Windows.Forms.Label labelInfoVersionBeta;
        private System.Windows.Forms.Panel panelLibraryFiles;
        private System.Windows.Forms.Panel panelEqualizerTitleBar;
        private System.Windows.Forms.Panel panelEqualizerPresetName;
        private System.Windows.Forms.Label labelInfoCopyrightTagLib;
        private System.Windows.Forms.CheckBox checkBoxPlayerAutoSave;
        private System.Windows.Forms.Button buttonKaraoke;
        private System.Windows.Forms.Panel panelKaraoke;
        private System.Windows.Forms.Panel panelKaraokeText;
        private System.Windows.Forms.ListView listViewKaraoke;
        private System.Windows.Forms.Label labelKaraokeName;
        private System.Windows.Forms.Panel panelKaraokeMenubar;
        private System.Windows.Forms.TableLayoutPanel tLPanelKaraokeMenu;
        private System.Windows.Forms.Button buttonKaraokeSaveAs;
        private System.Windows.Forms.Button buttonKaraokeSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonKaraokeNew;
        private System.Windows.Forms.Label labelKaraokeTitle;
        private System.Windows.Forms.FlowLayoutPanel fLPanelKaraokeSettings;
        private System.Windows.Forms.CheckBox checkBoxKaraokeEnable;
        private System.Windows.Forms.Label labelKaraokeTime;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonKaraokeAddLine;
        private System.Windows.Forms.Button buttonKaraokeRemoveLine;
        private System.Windows.Forms.Label labelInfoVersionBetaA;
    }
}

