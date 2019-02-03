using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnthraX.DataStructures {

    // ################################################################################
    //   xxx    x   x    xxxx   xxxxx    xxx    x   x
    //  x   x   x   x   x         x     x   x   xx xx
    //  x       x   x    xxx      x     x   x   x x x
    //  x   x   x   x       x     x     x   x   x   x
    //   xxx     xxx    xxxx      x      xxx    x   x
    //
    //  xxxx    x        xxx    x   x     x       xxxxx    xxxx   xxxxx
    //  x   x   x       x   x   x   x     x         x     x         x  
    //  xxxx    x       xxxxx    xxx      x         x      xxx      x  
    //  x       x       x   x     x       x         x         x     x  
    //  x       xxxxx   x   x     x       xxxxx   xxxxx   xxxx      x  
    // ################################################################################
    public class CustomPlayList : ICloneable {

        private List<CustomFile>    customFileList;
        private string[]            allowedFileTypes;

        // ######################################################################
        //  xxxxx   x   x   xxxxx   xxxxx
        //    x     xx  x     x       x  
        //    x     x x x     x       x  
        //    x     x  xx     x       x  
        //  xxxxx   x   x   xxxxx     x  
        // ######################################################################
        public CustomPlayList( string[] allowedFileTypes ) {
            this.customFileList     =   new List<CustomFile>();
            this.allowedFileTypes   =   allowedFileTypes;
        }

        // ######################################################################
        //  xxxxx   x   x   xxxxx   xxxxx   xxxx    xxxxx    xxx     xxx    xxxxx
        //    x     xx  x     x     x       x   x   x       x   x   x   x   x    
        //    x     x x x     x     xxxx    xxxx    xxxx    xxxxx   x       xxxx 
        //    x     x  xx     x     x       x   x   x       x   x   x   x   x    
        //  xxxxx   x   x     x     xxxxx   x   x   x       x   x    xxx    xxxxx
        // ######################################################################
        public object Clone() {
            return this.MemberwiseClone();
        }

        // ----------------------------------------------------------------------
        public CustomPlayList CloneObject() {
            return (CustomPlayList) this.Clone();
        }

        // ######################################################################
        //   xxx    xxxx    xxxx    xxxxx   x   x    xxxx
        //  x   x    x  x    x  x     x     xx  x   x    
        //  xxxxx    x  x    x  x     x     x x x   x  xx
        //  x   x    x  x    x  x     x     x  xx   x   x
        //  x   x   xxxx    xxxx    xxxxx   x   x    xxxx
        // ######################################################################
        //  Adding Single File
        // ----------------------------------------------------------------------
        public bool Add( CustomFile file ) {
            if ( allowedFileTypes.Contains<string>( file.GetFileExtension() ) ) {
                customFileList.Add( file );
                return true;
            } else {
                return false;
            }
        }

        // ----------------------------------------------------------------------
        public bool Add( string fullPath ) {
            CustomFile  file    =   new CustomFile( fullPath );
            return Add( file );
        }

        // ----------------------------------------------------------------------
        //  Adding Multiple Array Files
        // ----------------------------------------------------------------------
        public bool[] Add( CustomFile[] files ) {
            bool[]  result      =   new bool[files.Length];
            int     counter     =   0;
            foreach( CustomFile cf in files ) {
                result[counter] =   Add( cf );
                counter++;
            }
            return result;
        }

        // ----------------------------------------------------------------------
        public bool[] Add( string[] fullPaths ) {
            bool[]  result      =   new bool[fullPaths.Length];
            int     counter     =   0;
            foreach( string fp in fullPaths ) {
                CustomFile  file    =   new CustomFile( fp );
                result[counter]     =   Add( file );
                counter++;
            }
            return result;
        }

        // ----------------------------------------------------------------------
        //  Adding Multiple List Files
        // ----------------------------------------------------------------------
        public List<bool> Add( List<CustomFile> files ) {
            List<bool>  result      =   new List<bool>();
            foreach( CustomFile cf in files ) {
                result.Add( Add( cf ) );
            }
            return result;
        }

        // ----------------------------------------------------------------------
        public List<bool> Add( List<string> fullPaths ) {
            List<bool>  result      =   new List<bool>();
            foreach( string fp in fullPaths ) {
                CustomFile  file    =   new CustomFile( fp );
                result.Add( Add( file ) );
            }
            return result;
        }

        // ----------------------------------------------------------------------
        //  Adding Multiple String of Files
        // ----------------------------------------------------------------------
        public List<bool> Add( string fullPaths, char separation ) {
            List<bool>  result      =   new List<bool>();
            string      filePath    =   "";
            foreach( char c in fullPaths ) {
                if ( c != separation ) { filePath += c; }
                else {
                    CustomFile  file    =   new CustomFile( filePath );
                    result.Add( Add( file ) );
                }
            }
            return result;
        }

        // ######################################################################
        //  x   x    xxx    x   x    xxx     xxxx   xxxxx
        //  xx xx   x   x   xx  x   x   x   x       x    
        //  x x x   xxxxx   x x x   xxxxx   x  xx   xxxx 
        //  x   x   x   x   x  xx   x   x   x   x   x    
        //  x   x   x   x   x   x   x   x    xxxx   xxxxx
        // ######################################################################
        public bool MovePosition( int position, int newPosition ) {
            if ( position < 0 || position >= customFileList.Count ) { return false; }
            if ( newPosition < 0 || newPosition >= customFileList.Count ) { return false; }

            // --- Equal position of items ---
            if ( position == newPosition ) { return true; }
            // --- Higher new position of item ---
            else if ( position < newPosition ) {
                var temp = (CustomFile) customFileList[position];
                for ( int p = position; p < newPosition; p++ ) {
                    customFileList[p] = customFileList[p+1];
                }
                customFileList[newPosition] = temp;
                return true;
            // --- Lower new position of item ---
            } else if ( position > newPosition ) {
                var temp = (CustomFile) customFileList[position];
                for ( int p = position; p > newPosition; p-- ) {
                    customFileList[p] = customFileList[p-1];
                }
                customFileList[newPosition] = temp;
                return true;

            }

            return false;
        }

        // ######################################################################
        //   xxxx    xxx    xxxx    xxxxx
        //  x       x   x   x   x     x  
        //   xxx    x   x   xxxx      x  
        //      x   x   x   x   x     x  
        //  xxxx     xxx    x   x     x  
        // ######################################################################
        public void SortByFileName() {
            try {
                customFileList.Sort( (a, b) => a.GetFileName().CompareTo(b.GetFileName()) );
            } catch ( Exception exc ) {
                System.Console.WriteLine( exc.ToString() );
            }
        }

        // ----------------------------------------------------------------------
        public void SortByFilePath() {
            try {
                customFileList.Sort( (a, b) => a.GetFilePath().CompareTo(b.GetFilePath()) );
            } catch ( Exception exc ) {
                System.Console.WriteLine( exc.ToString() );
            }
        }

        // ----------------------------------------------------------------------
        public void SortByAudioTitle() {
            try {
                customFileList.Sort( (a, b) => CustomFileMetadata.GetMusicTitle(a).CompareTo( CustomFileMetadata.GetMusicTitle(b)) );
            } catch ( Exception exc ) {
                System.Console.WriteLine( exc.ToString() );
                SortByFileName();
            }
        }

        // ----------------------------------------------------------------------
        public void SortByAudioArtist() {
            try {
                customFileList.Sort( (a, b) => CustomFileMetadata.GetMusicArtist(a).CompareTo( CustomFileMetadata.GetMusicArtist(b)) );
            } catch ( Exception exc ) {
                System.Console.WriteLine( exc.ToString() );
                SortByFileName();
            }
        }

        // ----------------------------------------------------------------------
        public void SortByAudioAlbum() {
            try {
                customFileList.Sort( (a, b) => CustomFileMetadata.GetMusicAlbum(a).CompareTo( CustomFileMetadata.GetMusicAlbum(b)) );
            } catch ( Exception exc ) {
                System.Console.WriteLine( exc.ToString() );
                SortByFileName();
            }
        }

        // ######################################################################
        //  xxxx    xxxxx   x   x    xxx    x   x   xxxxx
        //  x   x   x       xx xx   x   x   x   x   x    
        //  xxxx    xxxx    x x x   x   x   x   x   xxxx 
        //  x   x   x       x   x   x   x    x x    x    
        //  x   x   xxxxx   x   x    xxx      x     xxxxx
        // ######################################################################
        //  Remove Single File
        // ----------------------------------------------------------------------
        public bool Remove( int index ) {
            if ( index >= 0 && index < customFileList.Count ) {
                customFileList.RemoveAt( index );
                return true;
            } else {
                return false;
            }
        }

        // ----------------------------------------------------------------------
        //  Remove Multiple Array Files
        // ----------------------------------------------------------------------
        public bool[] Remove( int[] indexes ) {
            bool[]  result      =   new bool[indexes.Length];
            int     counter     =   indexes.Length - 1;
            Array.Sort<int>( indexes, (a, b) => -1*a.CompareTo(b) );
            foreach ( int i in indexes ) {
                result[counter] =   Remove(i);
                counter--;
            }
            return result;
        }

        // ----------------------------------------------------------------------
        //  Remove Multiple List Files
        // ----------------------------------------------------------------------
        public List<bool> Remove( List<int> indexes ) {
            List<bool>  result  =   new List<bool>();
            indexes.Sort( (a, b) => -1*a.CompareTo(b) );
            foreach ( int i in indexes ) {
                result.Add( Remove(i) );
            }
            return result;
        }

        // ----------------------------------------------------------------------
        //  Remove All Files, Clear List
        // ----------------------------------------------------------------------
        public bool Clear() {
            if ( customFileList.Count <= 0 ) {
                return false;
            } else {
                customFileList.Clear();
                return true;
            }
        }

        // ######################################################################
        //   xxxx   xxxxx   xxxxx   xxxxx   xxxxx   xxxx     xxxx
        //  x       x         x       x     x       x   x   x    
        //  x  xx   xxxx      x       x     xxxx    xxxx     xxx 
        //  x   x   x         x       x     x       x   x       x
        //   xxxx   xxxxx     x       x     xxxxx   x   x   xxxx 
        // ######################################################################
        //  Getting additional Data
        // ----------------------------------------------------------------------
        public int GetCount() {
            return customFileList.Count;
        }

        // ----------------------------------------------------------------------
        public bool IfContains( CustomFile file ) {
            return customFileList.Contains( file );
        }

        // ----------------------------------------------------------------------
        public bool IfContains( string fullPath ) {
            foreach ( CustomFile f in customFileList ) {
                if ( f.GetFilePath() == fullPath ) { return true; }
            }
            return false;
        }

        // ----------------------------------------------------------------------
        public int IndexOf( CustomFile file ) {
            if ( !customFileList.Contains( file ) ) { return -1; }
            return customFileList.IndexOf(file);
        }

        // ----------------------------------------------------------------------
        public int IndexOf( string fullPath ) {
            foreach ( CustomFile f in customFileList ) {
                if ( f.GetFilePath() == fullPath ) { return customFileList.IndexOf(f); }
            }
            return -1;
        }

        // ----------------------------------------------------------------------
        //  Gettings Single Data of File
        // ----------------------------------------------------------------------
        public CustomFile GetFile( int index ) {
            if ( index >= 0 && index < customFileList.Count ) { return customFileList[ index ]; }
            return null;
        }

        // ----------------------------------------------------------------------
        //  Gettings Multpile Array Data of Files
        // ----------------------------------------------------------------------
        public CustomFile[] GetFiles( int[] indexes ) {
            CustomFile[]    result      =   new CustomFile[indexes.Length];
            int             counter     =   0;
            foreach( int i in indexes ) {
                result[counter]     =   GetFile( i );
                counter++;
            }
            return result;
        }

        // ----------------------------------------------------------------------
        //  Getting Multiple Data List of Files
        // ----------------------------------------------------------------------
        public List<CustomFile> GetFiles( List<int> indexes ) {
            List<CustomFile>    result  =   new List<CustomFile>();
            foreach( int i in indexes ) {
                result.Add( GetFile( i ) );
            }
            return result;
        }

        // ######################################################################
    }

    // ################################################################################
}
