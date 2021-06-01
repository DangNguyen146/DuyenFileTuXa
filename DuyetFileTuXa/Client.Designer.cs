namespace DuyetFileTuXa
{
    partial class Client
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dropBox = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openandeditfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openandeditfile)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 314);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(118, 314);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(547, 20);
            this.txtMess.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(747, 398);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dropBox
            // 
            this.dropBox.FormattingEnabled = true;
            this.dropBox.Location = new System.Drawing.Point(12, 341);
            this.dropBox.Name = "dropBox";
            this.dropBox.Size = new System.Drawing.Size(370, 95);
            this.dropBox.TabIndex = 12;
            this.dropBox.Visible = false;
            this.dropBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropBox_DragDrop);
            this.dropBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropBox_DragEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.Send;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(388, 340);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 52);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(765, 271);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.SendMess;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(671, 298);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 52);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // openandeditfile
            // 
            this.openandeditfile.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.openandeditfile;
            this.openandeditfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openandeditfile.Location = new System.Drawing.Point(511, 372);
            this.openandeditfile.Name = "openandeditfile";
            this.openandeditfile.Size = new System.Drawing.Size(211, 64);
            this.openandeditfile.TabIndex = 16;
            this.openandeditfile.TabStop = false;
            this.openandeditfile.Visible = false;
            this.openandeditfile.Click += new System.EventHandler(this.openandeditfile_Click);
            // 
            // Client
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openandeditfile);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dropBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Client";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openandeditfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.ListBox dropBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox openandeditfile;
    }
}