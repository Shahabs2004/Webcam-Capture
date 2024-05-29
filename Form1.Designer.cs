namespace Webcam_Capture_1
{
    partial class MainForm
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
            this.WebcamsList = new System.Windows.Forms.ComboBox();
            this.WebcamView = new System.Windows.Forms.PictureBox();
            this.Capture02 = new System.Windows.Forms.Button();
            this.Capture03 = new System.Windows.Forms.Button();
            this.Capture01 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WebcamView)).BeginInit();
            this.SuspendLayout();
            // 
            // WebcamsList
            // 
            this.WebcamsList.FormattingEnabled = true;
            this.WebcamsList.Location = new System.Drawing.Point(12, 12);
            this.WebcamsList.Name = "WebcamsList";
            this.WebcamsList.Size = new System.Drawing.Size(229, 21);
            this.WebcamsList.TabIndex = 0;
            this.WebcamsList.SelectedIndexChanged += new System.EventHandler(this.WebcamsList_SelectedIndexChanged);
            // 
            // WebcamView
            // 
            this.WebcamView.Location = new System.Drawing.Point(13, 40);
            this.WebcamView.Name = "WebcamView";
            this.WebcamView.Size = new System.Drawing.Size(228, 131);
            this.WebcamView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WebcamView.TabIndex = 1;
            this.WebcamView.TabStop = false;
            // 
            // Capture02
            // 
            this.Capture02.Location = new System.Drawing.Point(12, 206);
            this.Capture02.Name = "Capture02";
            this.Capture02.Size = new System.Drawing.Size(228, 23);
            this.Capture02.TabIndex = 2;
            this.Capture02.Text = "Capture 640*480";
            this.Capture02.UseVisualStyleBackColor = true;
            this.Capture02.Click += new System.EventHandler(this.Capture02_Click);
            // 
            // Capture03
            // 
            this.Capture03.Location = new System.Drawing.Point(13, 235);
            this.Capture03.Name = "Capture03";
            this.Capture03.Size = new System.Drawing.Size(229, 23);
            this.Capture03.TabIndex = 3;
            this.Capture03.Text = "Capture 800*600";
            this.Capture03.UseVisualStyleBackColor = true;
            this.Capture03.Click += new System.EventHandler(this.Capture03_Click);
            // 
            // Capture01
            // 
            this.Capture01.Location = new System.Drawing.Point(13, 177);
            this.Capture01.Name = "Capture01";
            this.Capture01.Size = new System.Drawing.Size(229, 23);
            this.Capture01.TabIndex = 4;
            this.Capture01.Text = "Capture 320*240";
            this.Capture01.UseVisualStyleBackColor = true;
            this.Capture01.Click += new System.EventHandler(this.Capture01_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "برنامه نویس: شهاب صادقی";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Capture01);
            this.Controls.Add(this.Capture03);
            this.Controls.Add(this.Capture02);
            this.Controls.Add(this.WebcamView);
            this.Controls.Add(this.WebcamsList);
            this.Name = "MainForm";
            this.Text = "WebCam Capture 1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.WebcamView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox WebcamsList;
        private System.Windows.Forms.PictureBox WebcamView;
        private System.Windows.Forms.Button Capture02;
        private System.Windows.Forms.Button Capture03;
        private System.Windows.Forms.Button Capture01;
        private System.Windows.Forms.Label label1;
    }
}

