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

namespace Windows_Activator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MessageBox.Show("First of all disable your internet connection and run this program as Administrator");
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string key = "cd '\"c:/Program Files (x86)/Microsoft Office Office16/\" && cscript ospp.vbs /sethst:ug-kms.uni-goettingen.de && cscript ospp.vbs /act";
            System.Diagnostics.ProcessStartInfo p = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " + key);
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.StartInfo = p;
            proc.Start();
            proc.WaitForExit();
            proc.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://www.youtube.com/ak1r4yuk1");
            Process.Start("chrome.exe", "https://github.com/Akira96kill");
        }
    }
}
