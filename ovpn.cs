using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storm
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (MethodScroll.Text == "Your Text") 
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"C:\Program Files\OpenVPN Connect\OpenVPNConnect.exe";
                startInfo.Arguments = "--config server.ovpn";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show("You are now protected");
            }
                
            
        }

        private void AttackBox_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void disconnect()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "taskkill",
                Arguments = $"/f /in OpenVPNConnect.exe",
                CreateNoWindow = true,
                UseShellExecute = false
            }).WaitForExit();

        }

        private void MethodScroll_MouseHover(object sender, EventArgs e)
        {
            guna2HtmlToolTip1.Show("Your Text", MethodScroll);
            int r, g, b;
            r = 20;
            g = 20;
            b = 20;
            guna2HtmlToolTip1.BackColor = Color.FromArgb(r, g, b);
        }
    }
}