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
    //  xxxx    x   x    xxx    x       xxxxx   x   x   xxxx    x   x   xxxxx
    //   x  x   x   x   x   x   x         x     xx  x   x   x   x   x     x  
    //   x  x   x   x   xxxxx   x         x     x x x   xxxx    x   x     x  
    //   x  x   x   x   x   x   x         x     x  xx   x       x   x     x  
    //  xxxx     xxx    x   x   xxxxx   xxxxx   x   x   x        xxx      x  
    // ################################################################################
    public partial class CustomMessageDualInput : Form {

        private Tools.MsgBoxFunction    okFunction;
        private int                     index;
        private string[]                message;
        private string[]                defaultInput;

        // ######################################################################
        //  xxxxx   x   x   xxxxx   xxxxx
        //    x     xx  x     x       x  
        //    x     x x x     x       x  
        //    x     x  xx     x       x  
        //  xxxxx   x   x   xxxxx     x  
        // ######################################################################
        public CustomMessageDualInput( string title, string[] message, string[] defaultInput, Tools.MsgBoxFunction okFunc ) {
            this.Text           =   title;
            this.message        =   message;
            this.defaultInput   =   defaultInput;
            this.okFunction     =   okFunc;

            InitializeComponent();
        }

        // ----------------------------------------------------------------------
        private void CustomMessageInputBox_Load(object sender, EventArgs e) {
            labelMessage1.Text   =   message[0];
            labelMessage2.Text   =   message[1];
            textBoxInput1.Text   =   defaultInput[0];
            textBoxInput2.Text   =   defaultInput[1];
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
                textBoxInput1.Text,
                textBoxInput2.Text
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
