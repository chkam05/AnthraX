namespace AnthraX.MessageBoxes
{
    partial class CustomMessageDualInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageDualInput));
            this.tLPanelBackground = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.labelMessage1 = new System.Windows.Forms.Label();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.labelMessage2 = new System.Windows.Forms.Label();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.tLPanelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPanelBackground
            // 
            this.tLPanelBackground.ColumnCount = 4;
            this.tLPanelBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tLPanelBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPanelBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPanelBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tLPanelBackground.Controls.Add(this.textBoxInput2, 1, 5);
            this.tLPanelBackground.Controls.Add(this.labelMessage2, 1, 4);
            this.tLPanelBackground.Controls.Add(this.buttonNo, 2, 8);
            this.tLPanelBackground.Controls.Add(this.buttonYes, 1, 8);
            this.tLPanelBackground.Controls.Add(this.labelMessage1, 1, 1);
            this.tLPanelBackground.Controls.Add(this.textBoxInput1, 1, 3);
            this.tLPanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanelBackground.Location = new System.Drawing.Point(0, 0);
            this.tLPanelBackground.Margin = new System.Windows.Forms.Padding(0);
            this.tLPanelBackground.Name = "tLPanelBackground";
            this.tLPanelBackground.RowCount = 10;
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelBackground.Size = new System.Drawing.Size(368, 201);
            this.tLPanelBackground.TabIndex = 0;
            // 
            // buttonNo
            // 
            this.buttonNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNo.Location = new System.Drawing.Point(200, 156);
            this.buttonNo.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(136, 28);
            this.buttonNo.TabIndex = 3;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonYes.Location = new System.Drawing.Point(32, 156);
            this.buttonYes.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(136, 28);
            this.buttonYes.TabIndex = 2;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // labelMessage1
            // 
            this.labelMessage1.AutoSize = true;
            this.tLPanelBackground.SetColumnSpan(this.labelMessage1, 2);
            this.labelMessage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMessage1.Location = new System.Drawing.Point(16, 16);
            this.labelMessage1.Margin = new System.Windows.Forms.Padding(0);
            this.labelMessage1.Name = "labelMessage1";
            this.labelMessage1.Size = new System.Drawing.Size(336, 27);
            this.labelMessage1.TabIndex = 0;
            this.labelMessage1.Text = "This is custom message!";
            this.labelMessage1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxInput1
            // 
            this.tLPanelBackground.SetColumnSpan(this.textBoxInput1, 2);
            this.textBoxInput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput1.Location = new System.Drawing.Point(16, 51);
            this.textBoxInput1.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(336, 27);
            this.textBoxInput1.TabIndex = 4;
            // 
            // labelMessage2
            // 
            this.labelMessage2.AutoSize = true;
            this.tLPanelBackground.SetColumnSpan(this.labelMessage2, 2);
            this.labelMessage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMessage2.Location = new System.Drawing.Point(16, 78);
            this.labelMessage2.Margin = new System.Windows.Forms.Padding(0);
            this.labelMessage2.Name = "labelMessage2";
            this.labelMessage2.Size = new System.Drawing.Size(336, 27);
            this.labelMessage2.TabIndex = 5;
            this.labelMessage2.Text = "This is custom message!";
            this.labelMessage2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxInput2
            // 
            this.tLPanelBackground.SetColumnSpan(this.textBoxInput2, 2);
            this.textBoxInput2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput2.Location = new System.Drawing.Point(16, 105);
            this.textBoxInput2.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(336, 27);
            this.textBoxInput2.TabIndex = 6;
            // 
            // CustomMessageDualInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 201);
            this.Controls.Add(this.tLPanelBackground);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageDualInput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageComboBox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CustomMessageInputBox_Load);
            this.tLPanelBackground.ResumeLayout(false);
            this.tLPanelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPanelBackground;
        private System.Windows.Forms.Label labelMessage1;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.Label labelMessage2;
    }
}