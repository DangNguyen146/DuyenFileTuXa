using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuyetFileTuXa
{
    public partial class XuliFile : Form
    {
        string tempR;
        public XuliFile(string url)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            FileStream fs = new FileStream(url, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            tempR = content;
            fs.Close();
            this.Text = fs.Name;
            txtLink.Text = url;
            txtSoDoan.Text = richTextBox1.Lines.Count().ToString();
            txtSoDong.Text = txtSoDoan.Text;

            content = content.Replace("\r\n", "\r");
            content = content.Replace('\r', ' ');
            string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            txtSoTu.Text = source.Count().ToString();
            txtKiTu.Text = richTextBox1.Text.Count().ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(txtLink.Text, FileMode.Create);
            StreamWriter fw = new StreamWriter(fs, Encoding.UTF8);
            richTextBox1.Text = richTextBox1.Text.ToUpper();
            fw.WriteLine(richTextBox1.Text.Trim());
            fw.Flush();
            fw.Close();
            MessageBox.Show("Success");
        }

        private void cbAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            cbAutoSave.Enabled = false;
            Thread thread = new Thread(() =>
            {
                FileStream fs = new FileStream(txtLink.Text, FileMode.Create);
                StreamWriter fw = new StreamWriter(fs, Encoding.UTF8);
                
                fw.WriteLine(richTextBox1.Text.Trim());
                fw.Flush();
                fw.Close();
                for (int i = 60; i >= 0; i--)
                {
                    cbAutoSave.Text = "Auto save in " + i + " s";
                    Thread.Sleep(1000);
                }
            });
            thread.Start();
        }

        private void cbAutoSave_CheckStateChanged(object sender, EventArgs e)
        {
            
        }
        bool isCheckbox1=false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isCheckbox1 = !isCheckbox1;
            if (isCheckbox1)
                richTextBox1.Text = richTextBox1.Text.ToUpper();
            else
                richTextBox1.Text = richTextBox1.Text.ToLower();
        }
        bool isCheckbox2 = false;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            isCheckbox2 = !isCheckbox2;
            if (isCheckbox2)
                richTextBox1.Text = richTextBox1.Text.ToLower();
            else
                richTextBox1.Text = richTextBox1.Text.ToUpper();
        }

    }
}
