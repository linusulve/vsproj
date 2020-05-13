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

namespace TCP_5._2
{
    public partial class ServerForm : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        int port = 12345;

        public ServerForm()

          {
            InitializeComponent();
    }

        private void btnServer_Click(object sender, EventArgs e)
        {
            lyssnare = new TcpListener(IPAddress.Any, port);
            lyssnare.Start();
          
            //Väntar på connect i klienten:
            klient = lyssnare.AcceptTcpClient();



            byte[] inData = new byte[256];
            //Väntar på send i klienten:
            int antalByte = klient.GetStream().Read(inData, 0, inData.Length);

            tbxInkorg.Text = Encoding.Unicode.GetString(inData, 0, antalByte);
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
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }

            tbxInkorg.AppendText(Encoding.Unicode.GetString(buffert, 0, n));

            StartaLäsning(k);


        }
}
}
