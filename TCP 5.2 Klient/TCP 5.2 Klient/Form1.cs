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

namespace TCP_5._2_Klient
{
    public partial class klientForm : Form
    {
        TcpClient klient = new TcpClient();
        int port = 12345;

        public klientForm()
        {
            InitializeComponent();
            klient.NoDelay = true;
        }

        private void btnAnslut_click(object sender, EventArgs e)
        {
            if (!klient.Connected) StartaAnslutning();
            }

        public async void StartaAnslutning()
        { try
            {
                IPAddress adress = IPAddress.Parse(tbxIP.Text);
                await klient.ConnectAsync(adress, port);
            }
            catch ( Exception error ) { MessageBox.Show(error.Message, Text); return; }

            btnSänd.Enabled = true;
            btnAnslut.Enabled = false;
        }

        private void btnSänd_click( object sender, EventArgs e )
        {
            StartaSändning("Hej");
        }

        public async void StartaSändning ( string message )
        {
            byte[] utData = Encoding.Unicode.GetBytes("Hej!");

            try
            {
                await klient.GetStream().WriteAsync(utData, 0, utData.Length);
            }
            catch ( Exception error ) { MessageBox.Show(error.Message, Text); return; }
        }
    }
}
