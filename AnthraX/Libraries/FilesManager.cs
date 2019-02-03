using AnthraX.DataStructures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnthraX.Libraries {

    // ################################################################################
    //  xxxxx   x   x   x   x   x   x   xxxxx   xxxx     xxx    xxxxx    xxx    xxxx     xxxx
    //  x       xx  x   x   x   xx xx   x       x   x   x   x     x     x   x   x   x   x    
    //  xxxx    x x x   x   x   x x x   xxxx    xxxx    xxxxx     x     x   x   xxxx     xxx 
    //  x       x  xx   x   x   x   x   x       x   x   x   x     x     x   x   x   x       x
    //  xxxxx   x   x    xxx    x   x   xxxxx   x   x   x   x     x      xxx    x   x   xxxx 
    // ################################################################################
    public enum FilterType {
        All         =   0,
        Music       =   1,
        Picture     =   2,
        Video       =   3,
        Text        =   4,
    }

    // ----------------------------------------------------------------------
    public struct DiskData {
        public  string      path;
        public  string      name;
        public  DriveType   driveType;
    }

    // ################################################################################
    //  xxxxx   xxxxx   x       xxxxx    xxxx
    //  x         x     x       x       x    
    //  xxxx      x     x       xxxx     xxx 
    //  x         x     x       x           x
    //  x       xxxxx   xxxxx   xxxxx   xxxx 
    //
    //  x   x    xxx    x   x    xxx     xxxx   xxxxx   xxxx 
    //  xx xx   x   x   xx  x   x   x   x       x       x   x
    //  x x x   xxxxx   x x x   xxxxx   x  xx   xxxx    xxxx 
    //  x   x   x   x   x  xx   x   x   x   x   x       x   x
    //  x   x   x   x   x   x   x   x    xxxx   xxxxx   x   x
    // ################################################################################

    public class FilesManager {

        private string              path            =   Tools.GetDirectoryHome();
        private List<string>        history;
        private List<DiskData>      disks;
        private List<string>        directories;
        private List<string>        files;

        private string              searchPhrase    =   "";
        private FilterType          filterPhrase    =   FilterType.All;
        private bool                hiddenFiles     =   false;
        private bool                systemFiles     =   false;
        private bool                showFolders     =   true;

        // ######################################################################
        //  xxxxx   x   x   xxxxx   xxxxx
        //    x     xx  x     x       x  
        //    x     x x x     x       x  
        //    x     x  xx     x       x  
        //  xxxxx   x   x   xxxxx     x  
        // ######################################################################
        public FilesManager( string startDirectory ) {
            this.history        =   new List<string>();
            this.disks          =   new List<DiskData>();
            this.directories    =   new List<string>();
            this.files          =   new List<string>();
            if ( IfDirectoryExists( startDirectory ) ) {
                this.path   =   startDirectory;
            }

            UpdateDiskList( 1 );
            UpdateDirectoryList();
            UpdateFileList();
        }

        // ######################################################################
        //  xxxxx    xxx     xxx    x        xxxx
        //    x     x   x   x   x   x       x    
        //    x     x   x   x   x   x        xxx 
        //    x     x   x   x   x   x           x
        //    x      xxx     xxx    xxxxx   xxxx 
        // ######################################################################
        public bool IfDirectoryExists( string directory ) {
            return Directory.Exists( directory );
        }

        // ----------------------------------------------------------------------
        public bool IfFileExists( string fileDirectory ) {
            return File.Exists( fileDirectory );
        }

        // ######################################################################
        //   xxxx   xxxxx   xxxxx   xxxxx   xxxxx   x   x    xxxx    xxxx
        //  x       x         x       x       x     xx  x   x       x    
        //   xxx    xxxx      x       x       x     x x x   x  xx    xxx 
        //      x   x         x       x       x     x  xx   x   x       x
        //  xxxx    xxxxx     x       x     xxxxx   x   x    xxxx   xxxx 
        // ######################################################################
        public void SetFilter( FilterType filterType ) {
            this.filterPhrase   =   filterType;
            UpdateDirectoryList();
            UpdateFileList();
        }

        // ----------------------------------------------------------------------
        public void SetSearchPhrase( string phrase ) {
            this.searchPhrase   =   phrase;
            UpdateDirectoryList();
            UpdateFileList();
            this.searchPhrase   =   "";
        }


        // ######################################################################
        //  x   x   xxxx    xxxx     xxx    xxxxx   xxxxx
        //  x   x   x   x    x  x   x   x     x     x    
        //  x   x   xxxx     x  x   xxxxx     x     xxxx 
        //  x   x   x        x  x   x   x     x     x    
        //   xxx    x       xxxx    x   x     x     xxxxx
        //
        //  x       xxxxx    xxxx   xxxxx    xxxx
        //  x         x     x         x     x    
        //  x         x      xxx      x      xxx 
        //  x         x         x     x         x
        //  xxxxx   xxxxx   xxxx      x     xxxx 
        // ######################################################################
        public void UpdateDiskList( int mode ) {
            string[]    drives  =   Directory.GetLogicalDrives();
            disks.Clear();

            switch ( mode ) {
                case 1:
                    foreach ( DriveInfo disk in DriveInfo.GetDrives() ) {
                        if ( !disk.IsReady ) { continue; }

                        System.Console.Write( disk.DriveType.ToString() );
                        System.Console.Write( " " + disk.VolumeLabel + " " );
                        System.Console.WriteLine( "( " + disk.RootDirectory.FullName + " )" );

                        DiskData    diskData    =   new DiskData();
                        diskData.name           =   disk.VolumeLabel;
                        diskData.path           =   disk.RootDirectory.FullName;
                        diskData.driveType      =   disk.DriveType;
                        disks.Add( diskData );
                    }
                    break;
                default:
                    foreach ( string drive in drives ) {
                        System.Console.WriteLine( drive );

                        DiskData    diskData    =   new DiskData();
                        diskData.path           =   drive;
                        diskData.driveType      =   DriveType.Fixed;
                        disks.Add( diskData );
                    }
                    break;
            }
        }

        // ----------------------------------------------------------------------
        public void UpdateDirectoryList() {
            this.directories.Clear();
            if ( !Directory.Exists( this.path ) ) { return; }
            DirectoryInfo[]     directories     =   new DirectoryInfo( this.path ).GetDirectories();

            foreach( DirectoryInfo directory in directories ) {
                if ( !hiddenFiles && directory.Attributes.HasFlag( FileAttributes.Hidden ) ) { continue; }
                if ( !systemFiles && directory.Attributes.HasFlag( FileAttributes.System ) ) { continue; }
                if ( !showFolders || !directory.Attributes.HasFlag( FileAttributes.Directory ) ) { continue; }

                System.Console.WriteLine( directory.FullName );
                this.directories.Add( directory.FullName );
            }
        }

        // ----------------------------------------------------------------------
        public void UpdateFileList() {
            this.files.Clear();
            if ( !Directory.Exists( this.path ) ) { return; }
            FileInfo[]  files   =   new DirectoryInfo( this.path ).GetFiles();

            foreach ( FileInfo file in files ) {
                if ( !hiddenFiles && file.Attributes.HasFlag( FileAttributes.Hidden ) ) { continue; }
                if ( !systemFiles && file.Attributes.HasFlag( FileAttributes.System ) ) { continue; }
                if ( file.Attributes.HasFlag( FileAttributes.Directory ) ) { continue; }

                if ( this.searchPhrase != "" ) {
                    if ( !Path.GetFileName( file.FullName ).Contains( this.searchPhrase ) ) { continue; }
                }

                switch ( this.filterPhrase ) {
                    case FilterType.All:
                        break;
                    case FilterType.Music:
                        if ( !Tools.fileTypeMusic.Contains<string>( Path.GetExtension( file.FullName ) ) ) { continue; }
                        break;
                    case FilterType.Picture:
                        if ( !Tools.fileTypeImage.Contains<string>( Path.GetExtension( file.FullName ) ) ) { continue; }
                        break;
                    case FilterType.Video:
                        if ( !Tools.fileTypeVideo.Contains<string>( Path.GetExtension( file.FullName ) ) ) { continue; }
                        break;
                    case FilterType.Text:
                        if ( !Tools.fileTypeText.Contains<string>( Path.GetExtension( file.FullName ) ) ) { continue; }
                        break;
                }

                System.Console.WriteLine( file.FullName );
                this.files.Add( file.FullName );
            }
        }

        // ######################################################################
        //   xxxx   xxxxx   xxxxx
        //  x       x         x  
        //  x  xx   xxxx      x  
        //  x   x   x         x  
        //   xxxx   xxxxx     x  
        //
        //  x       xxxxx    xxxx   xxxxx    xxxx
        //  x         x     x         x     x    
        //  x         x      xxx      x      xxx 
        //  x         x         x     x         x
        //  xxxxx   xxxxx   xxxx      x     xxxx 
        // ######################################################################
        public void GetDiskList( ListView listView ) {
            foreach ( DiskData disk in disks ) {
                string          title   =   ( disk.name != null ) ? disk.name + " (" + disk.path + ")" : disk.path;
                ListViewItem    item    =   new ListViewItem( title );
                
                switch ( disk.driveType ) {
                    case DriveType.CDRom:
                        item.ImageIndex         =   6;
                        break;
                    case DriveType.Fixed:
                        item.ImageIndex         =   18;
                        break;
                    case DriveType.NoRootDirectory:
                        item.ImageIndex         =   10;
                        break;
                    case DriveType.Network:
                        item.ImageIndex         =   22;
                        break;
                    default:
                        item.ImageIndex         =   18;
                        break;
                }

                listView.Items.Add( item );
            }
        }

        // ----------------------------------------------------------------------
        public void GetDiskList( ComboBox comboBox ) {
            string  currentPathRoot     =   (Directory.Exists( this.path )) ? Directory.GetDirectoryRoot(this.path) : "";
            int     currentPathDrive    =   0;
            comboBox.Items.Clear();

            foreach ( DiskData disk in disks ) {
                string          title   =   ( disk.name != null ) ? disk.name + " (" + disk.path + ")" : disk.path;
                comboBox.Items.Add( title );
                if ( currentPathRoot == disk.path ) { currentPathDrive = disks.IndexOf( disk ); }
            }

            comboBox.SelectedItem   =   comboBox.Items[ currentPathDrive ];
        }

        // ----------------------------------------------------------------------
        public void GetDirectoryList( ListView listView ) {
            if ( path == "" ) { GetDiskList( listView ); return; }

            foreach ( string directory in directories ) {
                string          title   =   Path.GetFileName( directory );
                ListViewItem    item    =   new ListViewItem( title );
                item.ImageIndex         =   10;

                listView.Items.Add( item );
            }
        }

        // ----------------------------------------------------------------------
        public void GetDirectoryList( TreeView treeView ) {
            List<string>    paths   =   new List<string>();
            string          parent  =   this.path;
            treeView.Nodes.Clear();

            // --- Zbieranie informacji o zagnieżdżeniach folderów ---
            if ( parent != "" ) {
                paths.Add( parent );
                while ( Directory.GetParent(parent) != null ) {
                    parent  =   Directory.GetParent(parent).FullName;
                    paths.Add( parent );
                }
            }

            // --- Uzupełnienie drzewa dyskami ---
            if ( paths.Count <= 0 ) {
                foreach( DiskData disk in disks ) {
                    string      discPath        =   disk.path;
                    TreeNode    newNode         =   null;

                    switch ( disk.driveType ) {
                    case DriveType.CDRom:
                        newNode     =   new TreeNode( discPath, 6, 6 );
                        break;
                    case DriveType.Fixed:
                        newNode     =   new TreeNode( discPath, 18, 18 );
                        break;
                    case DriveType.NoRootDirectory:
                        newNode     =   new TreeNode( discPath, 10, 10 );
                        break;
                    case DriveType.Network:
                        newNode     =   new TreeNode( discPath, 22, 22 );
                        break;
                    default:
                        newNode     =   new TreeNode( discPath, 18, 18 );
                        break;
                    }
                    treeView.Nodes.Add( newNode );
                }
                return;
            }

            // --- Uzupełnienie drzewa podfolderami od głębi ---
            string      previousDir     =   "";
            TreeNode    topNode         =   null;

            for ( int i = 0; i < paths.Count; i++ ) {
                string      dirName     =   Path.GetFileName( paths[i] );
                TreeNode    groupNode   =   new TreeNode( dirName, 10, 10 );
                foreach( DirectoryInfo dirinfo in new DirectoryInfo(paths[i]).GetDirectories() ) {
                    string      newDir      =   Path.GetFileName( dirinfo.FullName );
                    if ( !hiddenFiles && dirinfo.Attributes.HasFlag( FileAttributes.Hidden ) ) { continue; }
                    if ( !systemFiles && dirinfo.Attributes.HasFlag( FileAttributes.System ) ) { continue; }
                    if ( !showFolders || !dirinfo.Attributes.HasFlag( FileAttributes.Directory ) ) { continue; }

                    TreeNode    newNode     =   new TreeNode( newDir, 10, 10 );

                    if ( i == paths.Count - 1 ) {
                        if ( newDir == previousDir ) { treeView.Nodes.Add( (TreeNode) topNode.Clone() ); }
                        else { treeView.Nodes.Add( newNode ); }
                    }
                    else if ( newDir == previousDir ) { groupNode.Nodes.Add( (TreeNode) topNode.Clone() ); }
                    else { groupNode.Nodes.Add( newNode ); }
                }
                previousDir     =   dirName;
                topNode         =   groupNode;
            }

            treeView.ExpandAll();
        }

        // ----------------------------------------------------------------------
        public void GetFileList( ListView listView ) {
            foreach ( string file in files ) {
                string          title   =   Path.GetFileName( file );
                ListViewItem    item    =   new ListViewItem( title );
                CustomFile      csfile  =   new CustomFile( file );

                switch ( csfile.GetFileType() ) {
                    case FileType.Music:
                        item.ImageIndex         =   21;
                        break;
                    case FileType.Picture:
                        item.ImageIndex         =   24;
                        break;
                    case FileType.Video:
                        item.ImageIndex         =   27;
                        break;
                    case FileType.Text:
                        item.ImageIndex         =   7;
                        break;
                    case FileType.Playlist:
                        item.ImageIndex         =   23;
                        break;
                    default:
                        item.ImageIndex         =   8;
                        break;
                }

                listView.Items.Add( item );
            }
        }

        // ######################################################################
        //  x   x    xxx    x   x    xxx     xxxx   xxxxx
        //  xx xx   x   x   xx  x   x   x   x       x    
        //  x x x   xxxxx   x x x   xxxxx   x  xx   xxxx 
        //  x   x   x   x   x  xx   x   x   x   x   x    
        //  x   x   x   x   x   x   x   x    xxxx   xxxxx
        // ######################################################################
        public void SelectDisk( int index ) {
            if ( index < 0 || index >= disks.Count ) { return; }
            this.path   =   disks[ index ].path;

            UpdateDirectoryList();
            UpdateFileList();
        }

        // ----------------------------------------------------------------------
        public void SelectDirectory( TreeNode node, int diskIndex ) {
            if ( diskIndex < 0 || diskIndex >= disks.Count ) { return; }

            TreeNode    parent      =   node;
            string      newPath     =   parent.Text;
            while ( parent.Parent != null ) {
                parent      =   parent.Parent;
                newPath     =   parent.Text + "\\" + newPath;
            }

            newPath     =   disks[ diskIndex ].path + newPath;
            if ( Directory.Exists( newPath ) ) {
                this.path   =   newPath;
                history.Clear();
                UpdateDirectoryList();
                UpdateFileList();
            }
        }

        // ----------------------------------------------------------------------
        public void GoBack() {
            string  currentDirectory    =   this.path;
            string  newDirectory        =   (Directory.GetParent(currentDirectory) != null) ? Directory.GetParent( currentDirectory ).FullName : "";

            if ( Directory.Exists( newDirectory ) ) {
                this.path   =   newDirectory;
                history.Add( currentDirectory );
            } else {
                this.path   =   "";
                UpdateDiskList( 1 );
            }

            UpdateDirectoryList();
            UpdateFileList();
        }

        // ----------------------------------------------------------------------
        public void GoForward() {
            if ( history.Count <= 0 ) { return; }
            int     maxIndex        =   history.Count - 1;
            string  newDirectory    =   history[ maxIndex ];
            
            if ( Directory.Exists( newDirectory ) ) {
                this.path   =   newDirectory;
                history.RemoveAt( maxIndex );
            } else {
                history.Clear();
            }

            UpdateDirectoryList();
            UpdateFileList();
        }

        // ----------------------------------------------------------------------
        public void GoTo( string directory ) {
            if ( Directory.Exists( directory ) ) {
                this.path   =   directory;
                history.Clear();
            }

            UpdateDirectoryList();
            UpdateFileList();
        }

        // ----------------------------------------------------------------------
        public string OpenFile( int index ) {
            if ( index < 0 || index >= files.Count ) { return null; }

            string  newFile     =   files[ index ];
            if ( File.Exists( newFile ) ) { return newFile; }
            else { return null; }
        }

        // ----------------------------------------------------------------------
        public void OpenFolder( int index ) {
            if ( index < 0 || index >= directories.Count ) { return; }

            string  newPath     =   directories[ index ];
            if ( Directory.Exists( newPath ) ) { this.path = newPath; }
            UpdateDirectoryList();
            UpdateFileList();
        }

        // ######################################################################
        //   xxxx   xxxxx   xxxxx   xxxxx   xxxxx   xxxx     xxxx
        //  x       x         x       x     x       x   x   x    
        //  x  xx   xxxx      x       x     xxxx    xxxx     xxx 
        //  x   x   x         x       x     x       x   x       x
        //   xxxx   xxxxx     x       x     xxxxx   x   x   xxxx 
        // ######################################################################
        public string GetCurrentPath() { return this.path; }
        public List<DiskData> GetDiskList() { return this.disks; }
        public List<string> GetDirectoryList() { return this.directories; }
        public List<string> GetFileList() { return this.files; }
        public int GetDisksCount() { return this.disks.Count; }
        public int GetDirectoryCount() { return this.directories.Count; }
        public int GetFilesCount() { return this.files.Count; }

        // ######################################################################
    }

    // ################################################################################
}
