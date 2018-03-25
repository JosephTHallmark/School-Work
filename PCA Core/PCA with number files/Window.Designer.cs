namespace PCA_with_number_files {
    partial class Window {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.FileDiag = new System.Windows.Forms.OpenFileDialog();
            this.BttnOpen = new System.Windows.Forms.Button();
            this.RadButRawView = new System.Windows.Forms.RadioButton();
            this.RadButCoVar = new System.Windows.Forms.RadioButton();
            this.LblFilePath = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadButUser = new System.Windows.Forms.RadioButton();
            this.RadButEigen = new System.Windows.Forms.RadioButton();
            this.TxtBoxDataDisplay = new System.Windows.Forms.TextBox();
            this.BttnUserOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FileDialogUserInput = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileDiag
            // 
            this.FileDiag.Filter = "Text Files|*.txt";
            this.FileDiag.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDiag_FileOk);
            // 
            // BttnOpen
            // 
            this.BttnOpen.Location = new System.Drawing.Point(10, 4);
            this.BttnOpen.Name = "BttnOpen";
            this.BttnOpen.Size = new System.Drawing.Size(75, 23);
            this.BttnOpen.TabIndex = 0;
            this.BttnOpen.Text = "Open";
            this.BttnOpen.UseVisualStyleBackColor = true;
            this.BttnOpen.Click += new System.EventHandler(this.BttnOpen_Click);
            // 
            // RadButRawView
            // 
            this.RadButRawView.AutoSize = true;
            this.RadButRawView.Checked = true;
            this.RadButRawView.Location = new System.Drawing.Point(15, 9);
            this.RadButRawView.Name = "RadButRawView";
            this.RadButRawView.Size = new System.Drawing.Size(47, 17);
            this.RadButRawView.TabIndex = 3;
            this.RadButRawView.TabStop = true;
            this.RadButRawView.Text = "Raw";
            this.RadButRawView.UseVisualStyleBackColor = true;
            this.RadButRawView.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // RadButCoVar
            // 
            this.RadButCoVar.AutoSize = true;
            this.RadButCoVar.Location = new System.Drawing.Point(69, 9);
            this.RadButCoVar.Name = "RadButCoVar";
            this.RadButCoVar.Size = new System.Drawing.Size(116, 17);
            this.RadButCoVar.TabIndex = 4;
            this.RadButCoVar.Text = "CoVariance Matrixs";
            this.RadButCoVar.UseVisualStyleBackColor = true;
            this.RadButCoVar.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // LblFilePath
            // 
            this.LblFilePath.AutoSize = true;
            this.LblFilePath.Location = new System.Drawing.Point(12, 40);
            this.LblFilePath.Name = "LblFilePath";
            this.LblFilePath.Size = new System.Drawing.Size(29, 13);
            this.LblFilePath.TabIndex = 3;
            this.LblFilePath.Text = "File: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadButUser);
            this.panel1.Controls.Add(this.RadButEigen);
            this.panel1.Controls.Add(this.RadButCoVar);
            this.panel1.Controls.Add(this.RadButRawView);
            this.panel1.Location = new System.Drawing.Point(111, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 35);
            this.panel1.TabIndex = 7;
            // 
            // RadButUser
            // 
            this.RadButUser.AutoSize = true;
            this.RadButUser.Location = new System.Drawing.Point(255, 9);
            this.RadButUser.Name = "RadButUser";
            this.RadButUser.Size = new System.Drawing.Size(107, 17);
            this.RadButUser.TabIndex = 6;
            this.RadButUser.TabStop = true;
            this.RadButUser.Text = "User Input Result";
            this.RadButUser.UseVisualStyleBackColor = true;
            // 
            // RadButEigen
            // 
            this.RadButEigen.AutoSize = true;
            this.RadButEigen.Location = new System.Drawing.Point(192, 9);
            this.RadButEigen.Name = "RadButEigen";
            this.RadButEigen.Size = new System.Drawing.Size(57, 17);
            this.RadButEigen.TabIndex = 5;
            this.RadButEigen.TabStop = true;
            this.RadButEigen.Text = "Eigens";
            this.RadButEigen.UseVisualStyleBackColor = true;
            this.RadButEigen.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // TxtBoxDataDisplay
            // 
            this.TxtBoxDataDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxDataDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxDataDisplay.Location = new System.Drawing.Point(10, 56);
            this.TxtBoxDataDisplay.Multiline = true;
            this.TxtBoxDataDisplay.Name = "TxtBoxDataDisplay";
            this.TxtBoxDataDisplay.Size = new System.Drawing.Size(1190, 283);
            this.TxtBoxDataDisplay.TabIndex = 4;
            // 
            // BttnUserOpen
            // 
            this.BttnUserOpen.Location = new System.Drawing.Point(675, 7);
            this.BttnUserOpen.Name = "BttnUserOpen";
            this.BttnUserOpen.Size = new System.Drawing.Size(75, 23);
            this.BttnUserOpen.TabIndex = 8;
            this.BttnUserOpen.Text = "Open";
            this.BttnUserOpen.UseVisualStyleBackColor = true;
            this.BttnUserOpen.Click += new System.EventHandler(this.BttnUserOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "User Input select";
            // 
            // FileDialogUserInput
            // 
            this.FileDialogUserInput.Filter = "Text Files|*.txt";
            this.FileDialogUserInput.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialogUserInput_FileOk);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BttnUserOpen);
            this.Controls.Add(this.TxtBoxDataDisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblFilePath);
            this.Controls.Add(this.BttnOpen);
            this.Name = "Window";
            this.Text = "Window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog FileDiag;
        private System.Windows.Forms.Button BttnOpen;
        private System.Windows.Forms.RadioButton RadButRawView;
        private System.Windows.Forms.RadioButton RadButCoVar;
        private System.Windows.Forms.Label LblFilePath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtBoxDataDisplay;
        private System.Windows.Forms.RadioButton RadButEigen;
        private System.Windows.Forms.RadioButton RadButUser;
        private System.Windows.Forms.Button BttnUserOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog FileDialogUserInput;
    }
}

