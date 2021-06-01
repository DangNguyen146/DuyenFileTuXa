namespace DuyetFileTuXa
{
    partial class Server
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
            this.listMess = new System.Windows.Forms.RichTextBox();
            this.dropBox = new System.Windows.Forms.ListBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.lbLoading = new System.Windows.Forms.Label();
            this.openandeditfile = new System.Windows.Forms.PictureBox();
            this.btnSendMess = new System.Windows.Forms.PictureBox();
            this.btnOpenFile = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.openandeditfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendMess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listMess
            // 
            this.listMess.Location = new System.Drawing.Point(12, 12);
            this.listMess.Name = "listMess";
            this.listMess.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.listMess.Size = new System.Drawing.Size(776, 244);
            this.listMess.TabIndex = 1;
            this.listMess.Text = "";
            // 
            // dropBox
            // 
            this.dropBox.FormattingEnabled = true;
            this.dropBox.Location = new System.Drawing.Point(12, 300);
            this.dropBox.Name = "dropBox";
            this.dropBox.Size = new System.Drawing.Size(370, 108);
            this.dropBox.TabIndex = 2;
            this.dropBox.Visible = false;
            this.dropBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropBox_DragDrop);
            this.dropBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropBox_DragEnter);
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(12, 274);
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(644, 20);
            this.txtMess.TabIndex = 3;
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoading.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbLoading.Location = new System.Drawing.Point(511, 319);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(0, 20);
            this.lbLoading.TabIndex = 6;
            // 
            // openandeditfile
            // 
            this.openandeditfile.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.openandeditfile;
            this.openandeditfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openandeditfile.Location = new System.Drawing.Point(511, 344);
            this.openandeditfile.Name = "openandeditfile";
            this.openandeditfile.Size = new System.Drawing.Size(211, 64);
            this.openandeditfile.TabIndex = 9;
            this.openandeditfile.TabStop = false;
            this.openandeditfile.Visible = false;
            this.openandeditfile.Click += new System.EventHandler(this.pictureBox3_Click_2);
            // 
            // btnSendMess
            // 
            this.btnSendMess.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.SendMess;
            this.btnSendMess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendMess.Location = new System.Drawing.Point(662, 262);
            this.btnSendMess.Name = "btnSendMess";
            this.btnSendMess.Size = new System.Drawing.Size(117, 52);
            this.btnSendMess.TabIndex = 8;
            this.btnSendMess.TabStop = false;
            this.btnSendMess.Click += new System.EventHandler(this.btnSendMess_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.open_file;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenFile.Location = new System.Drawing.Point(388, 358);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(117, 48);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.TabStop = false;
            this.btnOpenFile.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.Send;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(388, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 52);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(747, 398);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Server
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openandeditfile);
            this.Controls.Add(this.btnSendMess);
            this.Controls.Add(this.lbLoading);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.dropBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listMess);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.openandeditfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendMess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox listMess;
        private System.Windows.Forms.ListBox dropBox;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnOpenFile;
        private System.Windows.Forms.Label lbLoading;
        private System.Windows.Forms.PictureBox btnSendMess;
        private System.Windows.Forms.PictureBox openandeditfile;
    }
}