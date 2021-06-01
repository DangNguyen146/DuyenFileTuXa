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

namespace DuyetFileTuXa
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.DragEnter += new DragEventHandler(dropBox_DragEnter);
            this.DragDrop += new DragEventHandler(dropBox_DragDrop);
            Connect();
        }
        FileInfo fileInfo;
        public static string path="Desktop/";
        public static string MessageCurrent = "Stopped";
        private void dropBox_DragEnter(object sender, DragEventArgs e)
        {
            dropBox.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            
        }

        private void dropBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            
            foreach (string file in files)
            {
                dropBox.Items.Add(file);
                fileInfo = new FileInfo(file);
            }
            
            dropBox.Enabled = false;
            btnOpenFile.Enabled = false;
            this.AllowDrop = false;
        }
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        void Connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 8080);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);

                        Thread receive = new Thread(Receive);
                        
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 8080);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }
        void Close()
        {
            server.Close();
        }
        string datas;
        string name;
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            while (true)
            {
                try
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = Deserialize(data).ToString();

                    switch (message.Substring(0, 3))
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
                    clientList.Remove(client);
                    client.Close();
                }
            }
        }
        
        void AddMessage(string s)
        {
            listMess.Text += s+"\n";
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

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(fileInfo.ToString(), FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string name = fileInfo.Name.ToString();
            string content = sr.ReadToEnd().ToString();
            foreach(Socket client in clientList)
            {
                if (client != null)
                {
                    AddMessage(name);
                    client.Send(Serialize("01:" + name));
                    Thread.Sleep(100);
                    AddMessage(content);
                    client.Send(Serialize("02:"+ content));
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            dropBox.Visible = true;
            fs.Close();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSendMess_Click(object sender, EventArgs e)
        {
            AddMessage(txtMess.Text);
            foreach (Socket item in clientList)
            {
                item.Send(Serialize("00:" + txtMess.Text));
            }
        }
    }
}
