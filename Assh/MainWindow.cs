using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Management;

namespace Assh
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        #region API Functions

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     
            int nTopRect,      
            int nRightRect,    
            int nBottomRect,   
            int nWidthEllipse, 
            int nHeightEllipse 
        );

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        #endregion

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void sshBtn_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(@"ssh_1.txt"))
            {
                string ssh_h = String.Empty;
                while ((ssh_h = sr.ReadLine()) != null)
                {
                    //do what you have to here
                    System.Diagnostics.ProcessStartInfo proc1 = new System.Diagnostics.ProcessStartInfo();
                    proc1.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
                    proc1.Arguments = "/c ssh " + ssh_h;
                    System.Diagnostics.Process.Start(proc1);
                }
            }
         }

        private void sshBtn_2_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(@"ssh_2.txt"))
            {
                string ssh_h2 = String.Empty;
                while ((ssh_h2 = sr.ReadLine()) != null)
                {
                    //do what you have to here
                    System.Diagnostics.ProcessStartInfo proc2 = new System.Diagnostics.ProcessStartInfo();
                    proc2.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
                    proc2.Arguments = "/c ssh " + ssh_h2;
                    System.Diagnostics.Process.Start(proc2);
                }
            }
        }

        private void sshBtn_3_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(@"ssh_3.txt"))
            {
                string ssh_h3 = String.Empty;
                while ((ssh_h3 = sr.ReadLine()) != null)
                {
                    //do what you have to here
                    System.Diagnostics.ProcessStartInfo proc3 = new System.Diagnostics.ProcessStartInfo();
                    proc3.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
                    proc3.Arguments = "/c ssh " + ssh_h3;
                    System.Diagnostics.Process.Start(proc3);
                }
            }
        }

        private void sshBtn_4_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(@"ssh_4.txt"))
            {
                string ssh_h4 = String.Empty;
                while ((ssh_h4 = sr.ReadLine()) != null)
                {
                    //do what you have to here
                    System.Diagnostics.ProcessStartInfo proc4 = new System.Diagnostics.ProcessStartInfo();
                    proc4.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
                    proc4.Arguments = "/c ssh " + ssh_h4;
                    System.Diagnostics.Process.Start(proc4);
                }
            }
        }

        private void sshBtn_5_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(@"ssh_5.txt"))
            {
                string ssh_h5 = String.Empty;
                while ((ssh_h5 = sr.ReadLine()) != null)
                {
                    //do what you have to here
                    System.Diagnostics.ProcessStartInfo proc5 = new System.Diagnostics.ProcessStartInfo();
                    proc5.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
                    proc5.Arguments = "/c ssh " + ssh_h5;
                    System.Diagnostics.Process.Start(proc5);
                }
            }
        }

        private void sshBtn_6_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(@"ssh_6.txt"))
            {
                string ssh_h6 = String.Empty;
                while ((ssh_h6 = sr.ReadLine()) != null)
                {
                    //do what you have to here
                    System.Diagnostics.ProcessStartInfo proc6 = new System.Diagnostics.ProcessStartInfo();
                    proc6.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
                    proc6.Arguments = "/c ssh " + ssh_h6;
                    System.Diagnostics.Process.Start(proc6);
                }
            }
        }

        private void sshBtn_7_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(@"ssh_7.txt"))
            {
                string ssh_h7 = String.Empty;
                while ((ssh_h7 = sr.ReadLine()) != null)
                {
                    //do what you have to here
                    System.Diagnostics.ProcessStartInfo proc7 = new System.Diagnostics.ProcessStartInfo();
                    proc7.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
                    proc7.Arguments = "/c ssh " + ssh_h7;
                    System.Diagnostics.Process.Start(proc7);
                }
            }
        }



        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (File.Exists("ssh_1.txt")) {
            }
            else
            {
                File.Create("ssh_1.txt");
                File.Create("ssh_1_name.txt");
                MessageBox.Show(("It seems as if you're running Assh for the first time, please read the check the SSH file (ssh_1.txt) and put your info in using the wiki."));
            }

            if (File.Exists("ssh_2.txt"))
            {
            }
            else
            {
                File.Create("ssh_2.txt");
                File.Create("ssh_2_name.txt");
                MessageBox.Show(("It seems as if you're running Assh for the first time, please read the check the SSH file (ssh_2.txt) and put your info in using the wiki."));
            }

            if (File.Exists("ssh_3.txt"))
            {
            }
            else
            {
                File.Create("ssh_3.txt");
                File.Create("ssh_3_name.txt");
                MessageBox.Show(("It seems as if you're running Assh for the first time, please read the check the SSH file (ssh_3.txt) and put your info in using the wiki."));
            }

            if (File.Exists("ssh_4.txt"))
            {
            }
            else
            {
                File.Create("ssh_4.txt");
                File.Create("ssh_4_name.txt");
                MessageBox.Show(("It seems as if you're running Assh for the first time, please read the check the SSH file (ssh_4.txt) and put your info in using the wiki."));
            }

            if (File.Exists("ssh_5.txt"))
            {
            }
            else
            {
                File.Create("ssh_5.txt");
                File.Create("ssh_5_name.txt");
                MessageBox.Show(("It seems as if you're running Assh for the first time, please read the check the SSH file (ssh_5.txt) and put your info in using the wiki."));
            }

            if (File.Exists("ssh_6.txt"))
            {
            }
            else
            {
                File.Create("ssh_6.txt");
                File.Create("ssh_6_name.txt");
                MessageBox.Show(("It seems as if you're running Assh for the first time, please read the check the SSH file (ssh_6.txt) and put your info in using the wiki."));
            }

            if (File.Exists("ssh_7.txt"))
            {
            }
            else
            {
                File.Create("ssh_7.txt");
                File.Create("ssh_7_name.txt");
                MessageBox.Show(("It seems as if you're running Assh for the first time, please read the check the SSH file (ssh_6.txt) and put your info in using the wiki."));
            }


            using (StreamReader sr = File.OpenText(@"ssh_1_name.txt"))
            {
                string ssh_h1_name = String.Empty;
                while ((ssh_h1_name = sr.ReadLine()) != null)
                {
                    host1Label.Text = ssh_h1_name;
                }
            }


            using (StreamReader sr = File.OpenText(@"ssh_2_name.txt"))
            {
                string ssh_h2_name = String.Empty;
                while ((ssh_h2_name = sr.ReadLine()) != null)
                {
                    host2Label.Text = ssh_h2_name;
                }
            }

            using (StreamReader sr = File.OpenText(@"ssh_3_name.txt"))
            {
                string ssh_h3_name = String.Empty;
                while ((ssh_h3_name = sr.ReadLine()) != null)
                {
                    host3Label.Text = ssh_h3_name;
                }
            }

            using (StreamReader sr = File.OpenText(@"ssh_4_name.txt"))
            {
                string ssh_h4_name = String.Empty;
                while ((ssh_h4_name = sr.ReadLine()) != null)
                {
                    host4Label.Text = ssh_h4_name;
                }
            }

            using (StreamReader sr = File.OpenText(@"ssh_5_name.txt"))
            {
                string ssh_h5_name = String.Empty;
                while ((ssh_h5_name = sr.ReadLine()) != null)
                {
                    host5Label.Text = ssh_h5_name;
                }
            }

            using (StreamReader sr = File.OpenText(@"ssh_6_name.txt"))
            {
                string ssh_h6_name = String.Empty;
                while ((ssh_h6_name = sr.ReadLine()) != null)
                {
                    host6Label.Text = ssh_h6_name;
                }
            }

            using (StreamReader sr = File.OpenText(@"ssh_7_name.txt"))
            {
                string ssh_h7_name = String.Empty;
                while ((ssh_h7_name = sr.ReadLine()) != null)
                {
                    host7Label.Text = ssh_h7_name;
                }
            }
        }
        private void MoveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
