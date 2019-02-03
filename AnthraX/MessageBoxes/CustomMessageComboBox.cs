using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnthraX.MessageBoxes {

    // ################################################################################
    //   xxx    x   x    xxxx   xxxxx    xxx    x   x
    //  x   x   x   x   x         x     x   x   xx xx
    //  x       x   x    xxx      x     x   x   x x x
    //  x   x   x   x       x     x     x   x   x   x
    //   xxx     xxx    xxxx      x      xxx    x   x
    //
    //  x   x   xxxxx    xxxx    xxxx    xxx     xxxx   xxxxx   xxx      xxx    x   x
    //  xx xx   x       x       x       x   x   x       x       x  x    x   x    x x 
    //  x x x   xxxx     xxx     xxx    xxxxx   x  xx   xxxx    xxxx    x   x     x  
    //  x   x   x           x       x   x   x   x   x   x       x   x   x   x    x x 
    //  x   x   xxxxx   xxxx    xxxx    x   x    xxxx   xxxxx   xxxx     xxx    x   x
    //
    //   xxx     xxx    x   x   xxx      xxx    xxx      xxx    x   x
    //  x   x   x   x   xx xx   x  x    x   x   x  x    x   x    x x 
    //  x       x   x   x x x   xxxx    x   x   xxxx    x   x     x  
    //  x   x   x   x   x   x   x   x   x   x   x   x   x   x    x x 
    //   xxx     xxx    x   x   xxxx     xxx    xxxx     xxx    x   x
    // ################################################################################
    public partial class CustomMessageComboBox : Form {

        private Tools.MsgBoxFunction    okFunction;
        private string                  message;
        private string[]                options;

        // ######################################################################
        //  xxxxx   x   x   xxxxx   xxxxx
        //    x     xx  x     x       x  
        //    x     x x x     x       x  
        //    x     x  xx     x       x  
        //  xxxxx   x   x   xxxxx     x  
        // ######################################################################
        public CustomMessageComboBox( string title, string message, string[] data, Tools.MsgBoxFunction okFunc ) {
            this.Text           =   title;
            this.message        =   message;
            this.okFunction     =   okFunc;
            this.options        =   data;

            InitializeComponent();
        }

        // ----------------------------------------------------------------------
        private void CustomMessageComboBox_Load(object sender, EventArgs e) {
            labelMessage.Text   =   message;
            FillComboBox( comboBoxChoice, this.options );
        }

        // ----------------------------------------------------------------------
        private void FillComboBox( ComboBox cb, string[] data ) {
            cb.Items.Clear();
            foreach( string d in data ) { cb.Items.Add( d ); }
            if ( cb.Items.Count > 0 ) {
                cb.SelectedItem = cb.Items[0];
            }
        }

        // ######################################################################
        //  xxx     x   x   xxxxx   xxxxx    xxx    x   x    xxxx
        //  x  x    x   x     x       x     x   x   xx  x   x    
        //  xxxx    x   x     x       x     x   x   x x x    xxx 
        //  x   x   x   x     x       x     x   x   x  xx       x
        //  xxxx     xxx      x       x      xxx    x   x   xxxx 
        // ######################################################################
        private void buttonYes_Click(object sender, EventArgs e) {
            object[]    args    =   new object[] {
                comboBoxChoice.SelectedIndex,
                comboBoxChoice.SelectedItem
            };

            if ( okFunction( args ) ) {
                this.DialogResult   =   DialogResult.Yes;
                this.Close();
            }
        }

        // ----------------------------------------------------------------------
        private void buttonNo_Click(object sender, EventArgs e) {
            this.DialogResult   =   DialogResult.No;
            this.Close();
        }

        // ######################################################################
    }

    // ################################################################################
}
