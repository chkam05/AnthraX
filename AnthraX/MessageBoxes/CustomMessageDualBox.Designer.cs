namespace AnthraX.MessageBoxes
{
    partial class CustomMessageDualBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageDualBox));
            this.tLPanelBackground = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.comboBoxChoice = new System.Windows.Forms.ComboBox();
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
            this.tLPanelBackground.Controls.Add(this.comboBoxChoice, 1, 3);
            this.tLPanelBackground.Controls.Add(this.buttonNo, 2, 7);
            this.tLPanelBackground.Controls.Add(this.buttonYes, 1, 7);
            this.tLPanelBackground.Controls.Add(this.labelMessage, 1, 1);
            this.tLPanelBackground.Controls.Add(this.textBoxInput, 1, 5);
            this.tLPanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanelBackground.Location = new System.Drawing.Point(0, 0);
            this.tLPanelBackground.Margin = new System.Windows.Forms.Padding(0);
            this.tLPanelBackground.Name = "tLPanelBackground";
            this.tLPanelBackground.RowCount = 9;
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelBackground.Size = new System.Drawing.Size(368, 217);
            this.tLPanelBackground.TabIndex = 0;
            // 
            // buttonNo
            // 
            this.buttonNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNo.Location = new System.Drawing.Point(200, 173);
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
            this.buttonYes.Location = new System.Drawing.Point(32, 173);
            this.buttonYes.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(136, 28);
            this.buttonYes.TabIndex = 2;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.tLPanelBackground.SetColumnSpan(this.labelMessage, 2);
            this.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMessage.Location = new System.Drawing.Point(16, 16);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(336, 71);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "This is custom message!";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxInput
            // 
            this.tLPanelBackground.SetColumnSpan(this.textBoxInput, 2);
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(16, 130);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(336, 27);
            this.textBoxInput.TabIndex = 4;
            // 
            // comboBoxChoice
            // 
            this.tLPanelBackground.SetColumnSpan(this.comboBoxChoice, 2);
            this.comboBoxChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxChoice.FormattingEnabled = true;
            this.comboBoxChoice.Location = new System.Drawing.Point(16, 95);
            this.comboBoxChoice.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxChoice.Name = "comboBoxChoice";
            this.comboBoxChoice.Size = new System.Drawing.Size(336, 27);
            this.comboBoxChoice.TabIndex = 5;
            // 
            // CustomMessageDualBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 217);
            this.Controls.Add(this.tLPanelBackground);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageDualBox";
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
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ComboBox comboBoxChoice;
    }
}