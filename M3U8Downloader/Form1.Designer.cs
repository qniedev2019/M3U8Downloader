namespace M3U8Downloader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.bgDownload = new System.ComponentModel.BackgroundWorker();
            this.cbbSource = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.lblProcess = new System.Windows.Forms.Label();
            this.txtM3U8 = new System.Windows.Forms.TextBox();
            this.lblM3U8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL Link:";
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.Color.White;
            this.txtURL.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtURL.Location = new System.Drawing.Point(27, 138);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(444, 23);
            this.txtURL.TabIndex = 1;
            this.txtURL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtURL_MouseClick);
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.Transparent;
            this.btnDownload.Location = new System.Drawing.Point(27, 255);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(216, 33);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "DOWNLOAD";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(255, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(216, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "M3U8 DOWNLOADER";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(203, 42);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(102, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "(VNExprees, IONE, ...)";
            // 
            // bgDownload
            // 
            this.bgDownload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgDownload_DoWork);
            this.bgDownload.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgDownload_RunWorkerCompleted);
            // 
            // cbbSource
            // 
            this.cbbSource.BackColor = System.Drawing.Color.White;
            this.cbbSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSource.FormattingEnabled = true;
            this.cbbSource.Items.AddRange(new object[] {
            "VTV.VN",
            "KENH14.VN",
            "VNEXPRESS.VN",
            "IONE.VNEXPRESS.VN",
            "SHOPEE",
            "CUSTOM"});
            this.cbbSource.Location = new System.Drawing.Point(27, 83);
            this.cbbSource.Name = "cbbSource";
            this.cbbSource.Size = new System.Drawing.Size(444, 25);
            this.cbbSource.TabIndex = 0;
            this.cbbSource.TextChanged += new System.EventHandler(this.cbbSource_TextChanged);
            this.cbbSource.Click += new System.EventHandler(this.cbbSource_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select source:";
            // 
            // rtb1
            // 
            this.rtb1.BackColor = System.Drawing.Color.White;
            this.rtb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb1.ForeColor = System.Drawing.Color.DimGray;
            this.rtb1.Location = new System.Drawing.Point(455, 2);
            this.rtb1.Name = "rtb1";
            this.rtb1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb1.Size = new System.Drawing.Size(45, 23);
            this.rtb1.TabIndex = 3;
            this.rtb1.Text = "rtb";
            this.rtb1.Visible = false;
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProcess.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.ForeColor = System.Drawing.Color.Blue;
            this.lblProcess.Location = new System.Drawing.Point(26, 235);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(69, 17);
            this.lblProcess.TabIndex = 11;
            this.lblProcess.Text = "Processing:";
            this.lblProcess.Visible = false;
            this.lblProcess.Click += new System.EventHandler(this.lblProcess_Click);
            // 
            // txtM3U8
            // 
            this.txtM3U8.BackColor = System.Drawing.Color.White;
            this.txtM3U8.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM3U8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtM3U8.Location = new System.Drawing.Point(29, 191);
            this.txtM3U8.Name = "txtM3U8";
            this.txtM3U8.Size = new System.Drawing.Size(444, 23);
            this.txtM3U8.TabIndex = 13;
            // 
            // lblM3U8
            // 
            this.lblM3U8.AutoSize = true;
            this.lblM3U8.Location = new System.Drawing.Point(26, 171);
            this.lblM3U8.Name = "lblM3U8";
            this.lblM3U8.Size = new System.Drawing.Size(72, 17);
            this.lblM3U8.TabIndex = 12;
            this.lblM3U8.Text = "M3U8 Link:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 310);
            this.Controls.Add(this.txtM3U8);
            this.Controls.Add(this.lblM3U8);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbSource);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(519, 349);
            this.MinimumSize = new System.Drawing.Size(519, 349);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "U3M8 Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.ComponentModel.BackgroundWorker bgDownload;
        private System.Windows.Forms.ComboBox cbbSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.TextBox txtM3U8;
        private System.Windows.Forms.Label lblM3U8;
    }
}

