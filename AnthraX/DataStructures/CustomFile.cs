using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnthraX.DataStructures {

    // ################################################################################
    //  xxxxx   xxxxx   x       xxxxx     xxxxx   x   x   xxxx    xxxxx
    //  x         x     x       x           x     x   x   x   x   x    
    //  xxxx      x     x       xxxx        x      xxx    xxxx    xxxx 
    //  x         x     x       x           x       x     x       x    
    //  x       xxxxx   xxxxx   xxxxx       x       x     x       xxxxx
    // ################################################################################
    public enum FileType {
        Unknown     =   0,
        Music       =   1,
        Picture     =   2,
        Video       =   3,
        Text        =   4,
        Playlist    =   5
    }

    // ################################################################################
    //   xxx    x   x    xxxx   xxxxx    xxx    x   x
    //  x   x   x   x   x         x     x   x   xx xx
    //  x       x   x    xxx      x     x   x   x x x
    //  x   x   x   x       x     x     x   x   x   x
    //   xxx     xxx    xxxx      x      xxx    x   x
    //
    //  xxxxx   xxxxx   x       xxxxx    xxxx
    //  x         x     x       x       x    
    //  xxxx      x     x       xxxx     xxx 
    //  x         x     x       x           x
    //  x       xxxxx   xxxxx   xxxxx   xxxx 
    // ################################################################################
    public class CustomFile : ICloneable {

        private string      fileName            =   "";
        private string      fullPath            =   "";
        private string      fileExtension       =   "";
        private FileType    fileType            =   FileType.Unknown;

        // ######################################################################
        //  xxxxx   x   x   xxxxx   xxxxx
        //    x     xx  x     x       x  
        //    x     x x x     x       x  
        //    x     x  xx     x       x  
        //  xxxxx   x   x   xxxxx     x  
        // ######################################################################
        public CustomFile( string fullPath ) {
            this.fileName           =   ExtractFileName( fullPath );
            this.fullPath           =   fullPath;
            this.fileExtension      =   ExtractFileExtension( fullPath );
            this.fileType           =   GenerateFileType( this.fileExtension );
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
        public CustomFile CloneObject() {
            return (CustomFile) this.Clone();
        }

        // ######################################################################
        //  xxxxx    xxx     xxx    x        xxxx
        //    x     x   x   x   x   x       x    
        //    x     x   x   x   x   x        xxx 
        //    x     x   x   x   x   x           x
        //    x      xxx     xxx    xxxxx   xxxx 
        // ######################################################################
        public string ExtractPureFileName( string fullPath ) { return Path.GetFileNameWithoutExtension( fullPath ); }
        public string ExtractFileName( string fullPath ) { return Path.GetFileName( fullPath ); }
        public string ExtractFileExtension( string fullPath ) { return Path.GetExtension( fullPath ); }

        // ----------------------------------------------------------------------
        private FileType GenerateFileType( string extension ) {

            // --- Music File Types ---
            if ( Tools.fileTypeMusic.Contains<string>( extension.ToLower() ) ) { return FileType.Music; }
            // --- Image File Types ---
            else if ( Tools.fileTypeImage.Contains<string>( extension.ToLower() ) ) { return FileType.Picture; }
            // --- Video File Types ---
            else if ( Tools.fileTypeVideo.Contains<string>( extension.ToLower() ) ) { return FileType.Video; }
            // --- Text File Types ---
            else if ( Tools.fileTypeText.Contains<string>( extension.ToLower() ) ) { return FileType.Text; }
            // --- PlayList File Types ---
            else if ( Tools.fileTypePlaylist.Contains<string>( extension.ToLower() ) ) { return FileType.Playlist; }
            // --- Unknown File Types ---
            else { return FileType.Unknown; }
        }

        // ######################################################################
        //   xxxx   xxxxx   xxxxx   xxxxx   xxxxx   xxxx     xxxx
        //  x       x         x       x     x       x   x   x    
        //  x  xx   xxxx      x       x     xxxx    xxxx     xxx 
        //  x   x   x         x       x     x       x   x       x
        //   xxxx   xxxxx     x       x     xxxxx   x   x   xxxx 
        // ######################################################################
        public string GetFileName() { return this.fileName; }
        public string GetPureFileName() { return ExtractPureFileName( this.fullPath ); }
        public string GetFilePath() { return this.fullPath; }
        public string GetFileExtension() { return this.fileExtension; }
        public FileType GetFileType() { return this.fileType; }
        public int GetFileIntType() { return (int) this.fileType; }

        // ######################################################################
    }

    // ################################################################################
}
