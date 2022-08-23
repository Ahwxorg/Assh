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
            using (StreamReader sr = File.OpenText(@"ssh_list.txt"))
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
