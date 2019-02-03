using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnthraX {

    // ################################################################################
    //  xxxx     xxx     xxxx   xxxxx    xxxx
    //  x   x   x   x   x       x       x    
    //  xxxx    xxxxx   x  xx   xxxx     xxx 
    //  x       x   x   x   x   x           x
    //  x       x   x    xxxx   xxxxx   xxxx 
    //
    //  x   x    xxx    x   x    xxx     xxxx   xxxxx   xxxx 
    //  xx xx   x   x   xx  x   x   x   x       x       x   x
    //  x x x   xxxxx   x x x   xxxxx   x  xx   xxxx    xxxx 
    //  x   x   x   x   x  xx   x   x   x   x   x       x   x
    //  x   x   x   x   x   x   x   x    xxxx   xxxxx   x   x
    // ################################################################################
    public class PagesManager {

        private List<object>    pages;

        // ######################################################################
        //  xxxxx   x   x   xxxxx   xxxxx
        //    x     xx  x     x       x  
        //    x     x x x     x       x  
        //    x     x  xx     x       x  
        //  xxxxx   x   x   xxxxx     x  
        // ######################################################################
        public PagesManager() {
            pages   =   new List<object>();
        }

        // ######################################################################
        //   xxx    xxxx    xxxx 
        //  x   x    x  x    x  x
        //  xxxxx    x  x    x  x
        //  x   x    x  x    x  x
        //  x   x   xxxx    xxxx 
        // ######################################################################
        public void Add( Panel panel ) {
            if ( IfPageExists( panel ) ) { return; }
            pages.Add( panel );
        }

        // ----------------------------------------------------------------------
        public void Add( FlowLayoutPanel fLPanel ) {
            if ( IfPageExists( fLPanel ) ) { return; }
            pages.Add( fLPanel );
        }

        // ----------------------------------------------------------------------
        public void Add( TableLayoutPanel tLPanel ) {
            if ( IfPageExists( tLPanel ) ) { return; }
            pages.Add( tLPanel );
        }

        // ######################################################################
        //  xxxxx   x   x   xxxxx    xxxx   xxxxx    xxxx
        //  x        x x      x     x         x     x    
        //  xxxx      x       x      xxx      x      xxx 
        //  x        x x      x         x     x         x
        //  xxxxx   x   x   xxxxx   xxxx      x     xxxx 
        // ######################################################################
        public bool IfPageExists( Panel panel ) {
            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(Panel) ) {
                    if ( (Panel) obj == panel ) { return true; }
                }
            }
            return false;
        }

        // ----------------------------------------------------------------------
        public bool IfPageExists( FlowLayoutPanel fLPanel ) {
            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(FlowLayoutPanel) ) {
                    if ( (FlowLayoutPanel) obj == fLPanel ) { return true; }
                }
            }
            return false;
        }

        // ----------------------------------------------------------------------
        public bool IfPageExists( TableLayoutPanel tLPanel ) {
            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(TableLayoutPanel) ) {
                    if ( (TableLayoutPanel) obj == tLPanel ) { return true; }
                }
            }
            return false;
        }

        // ----------------------------------------------------------------------
        public bool IfPageExists( string name ) {
            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(Panel) ) {
                    if ( ((Panel) obj).Name == name ) { return true; }
                } else if ( obj.GetType() == typeof(FlowLayoutPanel) ) {
                    if ( ((FlowLayoutPanel) obj).Name == name ) { return true; }
                } else if ( obj.GetType() == typeof(TableLayoutPanel) ) {
                    if ( ((TableLayoutPanel) obj).Name == name ) { return true; }
                }
            }
            return false;
        }

        // ######################################################################
        //  x   x   xxxxx   xxxx    xxxxx
        //  x   x     x      x  x   x    
        //  xxxxx     x      x  x   xxxx 
        //  x   x     x      x  x   x    
        //  x   x   xxxxx   xxxx    xxxxx
        // ######################################################################
        public void HideAll() {
            foreach ( object obj in pages ) {
                if ( obj.GetType() == typeof(Panel) ) { ((Panel) obj).Visible = false; }
                else if ( obj.GetType() == typeof(FlowLayoutPanel) ) { ((FlowLayoutPanel) obj).Visible = false; }
                else if ( obj.GetType() == typeof(TableLayoutPanel) ) { ((TableLayoutPanel) obj).Visible = false; }
            }
        }

        // ----------------------------------------------------------------------
        public void HidePanel( Panel panel ) {
            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(Panel) ) {
                    if ( (Panel) obj == panel ) { ((Panel)obj).Visible = false; }
                }
            }
        }

        // ----------------------------------------------------------------------
        public void HidePanel( FlowLayoutPanel fLPanel ) {
            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(FlowLayoutPanel) ) {
                    if ( (FlowLayoutPanel) obj == fLPanel ) { ((FlowLayoutPanel)obj).Visible = false; }
                }
            }
        }

        // ----------------------------------------------------------------------
        public void HidePanel( TableLayoutPanel tLPanel ) {
            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(TableLayoutPanel) ) {
                    if ( (TableLayoutPanel) obj == tLPanel ) { ((TableLayoutPanel)obj).Visible = false; }
                }
            }
        }

        // ----------------------------------------------------------------------
        public void HidePanel( string name ) {
            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(Panel) ) {
                    if ( ((Panel) obj).Name == name ) { ((Panel)obj).Visible = false; }
                } else if ( obj.GetType() == typeof(FlowLayoutPanel) ) {
                    if ( ((FlowLayoutPanel) obj).Name == name ) { ((FlowLayoutPanel)obj).Visible = false; }
                } else if ( obj.GetType() == typeof(TableLayoutPanel) ) {
                    if ( ((TableLayoutPanel) obj).Name == name ) { ((TableLayoutPanel)obj).Visible = false; }
                }
            }
        }

        // ######################################################################
        //   xxxx   x   x    xxx    x   x
        //  x       x   x   x   x   x   x
        //   xxx    xxxxx   x   x   x x x
        //      x   x   x   x   x   xx xx
        //  xxxx    x   x    xxx    x   x
        // ######################################################################
        public void ShowPanel( Panel panel ) {
            HideAll();

            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(Panel) ) {
                    if ( (Panel) obj == panel ) { ((Panel)obj).Visible = true; }
                }
            }
        }

        // ----------------------------------------------------------------------
        public void ShowPanel( FlowLayoutPanel fLPanel ) {
            HideAll();

            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(FlowLayoutPanel) ) {
                    if ( (FlowLayoutPanel) obj == fLPanel ) { ((FlowLayoutPanel)obj).Visible = true; }
                }
            }
        }

        // ----------------------------------------------------------------------
        public void ShowPanel( TableLayoutPanel tLPanel ) {
            HideAll();

            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(TableLayoutPanel) ) {
                    if ( (TableLayoutPanel) obj == tLPanel ) { ((TableLayoutPanel)obj).Visible = true; }
                }
            }
        }

        // ----------------------------------------------------------------------
        public void ShowPanel( string name ) {
            HideAll();

            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(Panel) ) {
                    if ( ((Panel) obj).Name == name ) { ((Panel)obj).Visible = true; }
                } else if ( obj.GetType() == typeof(FlowLayoutPanel) ) {
                    if ( ((FlowLayoutPanel) obj).Name == name ) { ((FlowLayoutPanel)obj).Visible = true; }
                } else if ( obj.GetType() == typeof(TableLayoutPanel) ) {
                    if ( ((TableLayoutPanel) obj).Name == name ) { ((TableLayoutPanel)obj).Visible = true; }
                }
            }
        }

        // ######################################################################
        //  xxxx    xxxxx   x   x    xxx    x   x   xxxxx
        //  x   x   x       xx xx   x   x   x   x   x    
        //  xxxx    xxxx    x x x   x   x   x   x   xxxx 
        //  x   x   x       x   x   x   x    x x    x    
        //  x   x   xxxxx   x   x    xxx      x     xxxxx
        // ######################################################################
        public void RemovePanel( Panel panel ) {
            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(Panel) ) {
                    if ( (Panel) obj == panel ) { pages.Remove( obj ); }
                }
            }
        }

        // ----------------------------------------------------------------------
        public void RemovePanel( FlowLayoutPanel fLPanel ) {
            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(FlowLayoutPanel) ) {
                    if ( (FlowLayoutPanel) obj == fLPanel ) { pages.Remove( obj ); }
                }
            }
        }

        // ----------------------------------------------------------------------
        public void RemovePanel( TableLayoutPanel tLPanel ) {
            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(TableLayoutPanel) ) {
                    if ( (TableLayoutPanel) obj == tLPanel ) { pages.Remove( obj ); }
                }
            }
        }

        // ----------------------------------------------------------------------
        public void RemovePanel( string name ) {
            foreach( object obj in pages ) {
                if ( obj.GetType() == typeof(Panel) ) {
                    if ( ((Panel) obj).Name == name ) { pages.Remove( obj ); }
                } else if ( obj.GetType() == typeof(FlowLayoutPanel) ) {
                    if ( ((FlowLayoutPanel) obj).Name == name ) { pages.Remove( obj ); }
                } else if ( obj.GetType() == typeof(TableLayoutPanel) ) {
                    if ( ((TableLayoutPanel) obj).Name == name ) { pages.Remove( obj ); }
                }
            }
        }

        // ######################################################################
    }

    // ################################################################################
}
