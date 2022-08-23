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

namespace Assh
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }


//        string text = System.IO.File.ReadAllText(@"%userprofile%\.config\Assh\ssh_list");

        private void sshBtn_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"ssh_list.txt");
            MessageBox.Show("test" + lines);

            System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
            proc.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            proc.Arguments = "/c ssh " + lines;
            System.Diagnostics.Process.Start(proc);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            if (File.Exists("ssh_list.txt")) {
            }
            else
            {
                MessageBox.Show(("It seems as if you're running Assh for the first time, please read the check the SSH file and put your info in using the wiki."));
            }
        }
    }
}
