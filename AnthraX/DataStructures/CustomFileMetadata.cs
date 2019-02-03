using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace AnthraX.DataStructures {

    // ################################################################################
    //  xxxxx   xxxxx   x       xxxxx    xxxx
    //  x         x     x       x       x    
    //  xxxx      x     x       xxxx     xxx 
    //  x         x     x       x           x
    //  x       xxxxx   xxxxx   xxxxx   xxxx 
    //
    //  x   x   xxxxx   xxxxx    xxx    xxxx     xxx    xxxxx    xxx 
    //  xx xx   x         x     x   x    x  x   x   x     x     x   x
    //  x x x   xxxx      x     xxxxx    x  x   xxxxx     x     xxxxx
    //  x   x   x         x     x   x    x  x   x   x     x     x   x
    //  x   x   xxxxx     x     x   x   xxxx    x   x     x     x   x
    // ################################################################################
    public static class CustomFileMetadata {

        // ######################################################################
        //  x   x   x   x    xxxx   xxxxx    xxx 
        //  xx xx   x   x   x         x     x   x
        //  x x x   x   x    xxx      x     x    
        //  x   x   x   x       x     x     x   x
        //  x   x    xxx    xxxx    xxxxx    xxx 
        // ######################################################################
        public static string GetMusicAlbum( CustomFile file ) {
            TagLib.File     metadata    =   null;
            string          result      =   "";
            
            if ( file != null ) {
                metadata    =   TagLib.File.Create( file.GetFilePath() );
                if ( metadata != null ) {
                    if ( metadata.Tag.Album != null ) {
                        result = metadata.Tag.Album;
                    }
                }
            }
            return result;
        }

        // ----------------------------------------------------------------------
        public static string GetMusicArtist( CustomFile file ) {
            TagLib.File     metadata    =   null;
            string          result      =   "";
            
            if ( file != null ) {
                metadata    =   TagLib.File.Create( file.GetFilePath() );
                if ( metadata != null ) {
                    if ( metadata.Tag.FirstPerformer != null ) {
                        result  =   metadata.Tag.FirstPerformer;
                    }
                    foreach ( string s in metadata.Tag.Performers ) {
                        if ( result != s ) { result += (", " + s); }
                    }
                }
            }
            return result;
        }

        // ----------------------------------------------------------------------
        public static string GetMusicTitle( CustomFile file ) {
            TagLib.File     metadata    =   null;
            string          result      =   "";
            
            if ( file != null ) {
                metadata    =   TagLib.File.Create( file.GetFilePath() );
                if ( metadata != null ) {
                    if ( metadata.Tag.Title != null ) {
                        result = metadata.Tag.Title;
                    }
                }
            }
            return result;
        }

        // ----------------------------------------------------------------------
        public static string GetMusicGenre( CustomFile file ) {
            TagLib.File     metadata    =   null;
            string          result      =   "";
            
            if ( file != null ) {
                metadata    =   TagLib.File.Create( file.GetFilePath() );
                if ( metadata != null ) {
                    if ( metadata.Tag.FirstGenre != null ) {
                        result  =   metadata.Tag.FirstGenre;
                    }
                    foreach ( string s in metadata.Tag.Genres ) {
                        if ( result != s ) { result += (", " + s); }
                    }
                }
            }
            return result;
        }

        // ----------------------------------------------------------------------
        public static string GetMusicYear( CustomFile file ) {
            TagLib.File     metadata    =   null;
            string          result      =   "";
            
            if ( file != null ) {
                metadata    =   TagLib.File.Create( file.GetFilePath() );
                if ( metadata != null ) {
                    if ( metadata.Tag.Year.ToString() != null ) {
                        result = metadata.Tag.Year.ToString();
                    }
                }
            }
            return result;
        }

        // ----------------------------------------------------------------------
        public static string GetMusicComment( CustomFile file ) {
            TagLib.File     metadata    =   null;
            string          result      =   "";
            
            if ( file != null ) {
                metadata    =   TagLib.File.Create( file.GetFilePath() );
                if ( metadata != null ) {
                    if ( metadata.Tag.Comment != null ) {
                        result = metadata.Tag.Comment;
                    }
                }
            }
            return result;
        }

        // ----------------------------------------------------------------------
        public static string GetMusicTrack( CustomFile file ) {
            TagLib.File     metadata    =   null;
            string          result      =   "";
            
            if ( file != null ) {
                metadata    =   TagLib.File.Create( file.GetFilePath() );
                if ( metadata != null ) {
                    if ( metadata.Tag.Track.ToString() != null ) {
                        result = metadata.Tag.Track.ToString();
                    }
                }
            }
            return result;
        }

        // ----------------------------------------------------------------------
        public static Image[] GetMusicImage( CustomFile file ) {
            TagLib.File         metadata    =   null;
            TagLib.IPicture[]   covers      =   null;
            Image[]             images      =   null;
            int                 index       =   0;

            if ( file != null ) {
                metadata    =   TagLib.File.Create( file.GetFilePath() );
                if ( metadata != null ) {
                    covers  =   metadata.Tag.Pictures;
                    images  =   new Image[covers.Length];
                    foreach( TagLib.IPicture p in covers ) {
                        MemoryStream ms     =   new MemoryStream( p.Data.Data );
                        images[index]       =   Image.FromStream( ms );
                        index++;
                    }
                }
            }
            return images;
        }

        // ######################################################################
    }

    // ################################################################################
}
