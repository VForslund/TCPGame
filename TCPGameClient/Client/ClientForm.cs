using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        TcpClient c = new TcpClient();
        int port = 1337;

        bool mRight, mLeft, mUp, mDown;
        int speed = 10;
        int lastX, lastY;
        string serverPos = "";

        public ClientForm()
        {
            InitializeComponent();
            c.NoDelay = true;
            Connect();
        }
         private async void Connect()
        {
            try
            {
                IPAddress ip = IPAddress.Parse(GetLocalIPAddress());
                await c.ConnectAsync(ip, port);
                StatusTextBox.Text = "Connected";
                ConnectionIcon.BackColor = Color.Green;
                startReciving(c);
            }
            catch(Exception e)
            {
                StatusTextBox.Text = e.Message;
                ConnectionIcon.BackColor = Color.Red;
                Thread.Sleep(100);
                Connect();
            }
        }
        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private async void send(string msg)
        {
            byte[] sendData = Encoding.Unicode.GetBytes(msg);

            try
            {
                await c.GetStream().WriteAsync(sendData, 0, sendData.Length);
            }catch(Exception e)
            {
                StatusTextBox.Text = e.Message;
            }
        }

        private async void startReciving(TcpClient client)
        {
            if (client.Connected)
            {
                byte[] buffer = new byte[1024];
                int n = 0;
                try
                {
                    n = await client.GetStream().ReadAsync(buffer, 0, buffer.Length);
                    serverPos = Encoding.Unicode.GetString(buffer, 0, n);

                }
                catch (Exception e)
                {
                    StatusTextBox.Text = e.Message;
                    startReciving(client);
                }
                startReciving(client);
            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                mLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                mRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                mUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                mDown = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                mLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                mRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                mUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                mDown = false;
            }
        }



        private void frameUpdate(object sender, EventArgs e)
        {
            
            if (mLeft == true && Player.Left > 0)
            {
                Player.Left -= speed;
            }
            if (mRight == true && Player.Right < 700)
            {
                Player.Left += speed;
            }
            if (mUp == true && Player.Top > 0)
            {
                Player.Top -= speed;
            }
            if (mDown == true && Player.Top < 430)
            {
                Player.Top += speed;
             
            }
            if (lastX != Player.Left || lastY != Player.Top)
            {
                
                string msg = "Top:" + Player.Top.ToString() + ":Left:" + Player.Left.ToString();
                send(msg);
                lastX = Player.Left;
                lastY = Player.Top;
                updateAI();
            }


        }
        private void updateAI()
        {
            try {
                string[] positions = serverPos.Split(':');
                AI.Top = Int32.Parse(positions[0]);
                AI.Left = Int32.Parse(positions[1]);
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }

        }
    }
}
