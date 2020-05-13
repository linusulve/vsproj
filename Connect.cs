using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Connect
{
    public partial class ServerForms : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        int port = 12345;



        public ServerForms()
        {
            InitializeComponent();
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!klient.Connected) StartaAnslutning();
            
        }
        public async void StartaAnslutning()
        { try
            {
                IPAddress adress = IPAddress.Parse(tbxIP.Text);
                await klient.ConnectAsync(adress, port);
            }
            catch ( Exception error) { MessageBox.Show(error.Message, Text); return;}

            btnConnect.Enabled = true;
                }

        public async void StartaSänding (string message)
        {
            byte[] utData = Encoding.Unicode.GetBytes("HEJ!");

            try
            {
                await klient.GetStream().WriteAsync(utData, 0, utData.Length);
            }
            catch ( Exception error ) { MessageBox.Show(error.Message, Text); return;  }
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            lyssnare = new TcpListener(IPAddress.Any, port);
            lyssnare.Start();

            klient = lyssnare.AcceptTcpClient();


            byte[] indata = new byte[256];

            int antalByte = klient.GetStream().Read(indata, 0, indata.Length);

            tbx1.Text = Encoding.Unicode.GetString(indata, 0, antalByte);
            tbx2.Text = Encoding.Unicode.GetString(indata, 1, antalByte);
            tbx3.Text = Encoding.Unicode.GetString(indata, 2, antalByte);
            tbx4.Text = Encoding.Unicode.GetString(indata, 3, antalByte);
            klient.Close();
            lyssnare.Stop();
            
        }
        public async void StartaMottagning()
        {
            try
            {
                klient = await lyssnare.AcceptTcpClientAsync();
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }

            StartaLäsning(klient);
        }

        public async void StartaLäsning ( TcpClient k)
        {
            byte[] buffert = new byte[1024];

            int n = 0;
            try
            {
                n = await k.GetStream().ReadAsync(buffert, 0, buffert.Length);
            }
            catch (Exception error ){ MessageBox.Show(error.Message, Text); return; }

            tbx1.AppendText(Encoding.Unicode.GetString(buffert, 1, n));
            tbx2.AppendText(Encoding.Unicode.GetString(buffert, 2, n));
            tbx3.AppendText(Encoding.Unicode.GetString(buffert, 3, n));
            tbx4.AppendText(Encoding.Unicode.GetString(buffert, 4, n));

            StartaLäsning(k);
        }

        private void rbnV1_CheckedChanged(object sender, EventArgs e)
        {
            tbx1.Enabled = false;
        }

        private void rbnV2_CheckedChanged(object sender, EventArgs e)
        {
            tbx2.Enabled = false;
        }

        private void rbnV3_CheckedChanged(object sender, EventArgs e)
        {
            tbx3.Enabled = false;
        }

        private void rbnV4_CheckedChanged(object sender, EventArgs e)
        {
            tbx4.Enabled = false;
        }
    }
}

public partial class KlientForms : Form
{
    TcpClient klient = new TcpClient();
    int port = 12345;
    
}