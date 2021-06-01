using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DuyetFileTuXa
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
            this.DragEnter += new DragEventHandler(dropBox_DragEnter);
            this.DragDrop += new DragEventHandler(dropBox_DragDrop);
        }
        private void dropBox_DragEnter(object sender, DragEventArgs e)
        {
            dropBox.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }

        }
        FileInfo fileInfo;
        private void dropBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                dropBox.Items.Add(file);
                fileInfo = new FileInfo(file);
            }

            dropBox.Enabled = false;
            this.AllowDrop = false;
        }
        IPEndPoint IP;
        Socket client;
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            client.Connect(IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {

            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        //đống kết nối
        void Close()
        {
            client.Close();
        }
        //gởi tin
        void Send()
        {
            if ((txtMess.Text != string.Empty) && (txtName.Text != string.Empty))
            {
                string temp = (txtName.Text + ": " + txtMess.Text).ToString();
                client.Send(Serialize(temp));
            }
        }
        //nhận tin
        string datas;
        string name;
        void Receive()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = Deserialize(data).ToString();
                    switch (message.Substring(0,3))
                    {
                        case "00:":
                            {
                                AddMessage(message.Substring(3));
                                break;
                            }
                        case "01:":
                            {
                                name = message.Substring(3);
                                AddMessage(name);
                                break;
                            }
                        case "02:":
                            {
                                datas = message.Substring(3);

                                this.BeginInvoke((MethodInvoker)delegate            //How do I update the GUI from another thread?
                                {
                                    FolderBrowserDialog ofd = new FolderBrowserDialog();      // chọn đường dẫn để lưu file
                                    ofd.ShowDialog();
                                    FileStream fs = new FileStream(ofd.SelectedPath + @"\" + name, FileMode.Create);
                                    StreamWriter rd = new StreamWriter(fs, Encoding.UTF8);
                                    rd.WriteLine(datas.Trim().ToString());
                                    rd.Flush();
                                    rd.Close();
                                });
                                client.Send(Serialize("03:"));
                                break;
                            }
                        case "03:":
                            {
                                this.BeginInvoke((MethodInvoker)delegate            //How do I update the GUI from another thread?
                                {
                                    dropBox.Items.Clear();
                                    dropBox.Enabled = true;
                                });
                            break;
                            }
                        default:
                            {
                                AddMessage(message);
                                break;
                            }
                    }
                }
                catch
                {
                    Close();
                }
            }

        }
        
        void AddMessage(string s)
        {
            richTextBox1.Text += s + "\n";
        }
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage((txtName.Text + ": " + txtMess.Text).ToString());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(fileInfo.ToString(), FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string name = fileInfo.Name.ToString();
            string content = sr.ReadToEnd().ToString();
            AddMessage(name);
            client.Send(Serialize("01:" + name));
            Thread.Sleep(100);
            AddMessage(content);
            client.Send(Serialize("02:" + content));
        }
    }
}
