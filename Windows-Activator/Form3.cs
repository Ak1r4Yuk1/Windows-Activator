using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Activator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = "slmgr /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
            System.Diagnostics.ProcessStartInfo p = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " + key);
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.StartInfo = p;
            proc.Start();
            proc.WaitForExit();
            proc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string key = "slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX";
            System.Diagnostics.ProcessStartInfo p = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " + key);
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.StartInfo = p;
            proc.Start();
            proc.WaitForExit();
            proc.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string key = "slmgr /ipk NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
            System.Diagnostics.ProcessStartInfo p = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " + key);
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.StartInfo = p;
            proc.Start();
            proc.WaitForExit();
            proc.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string key = "slmgr /ipk NPPR9-FWDCX-D2C8J-H872K-2YT43";
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
            this.Close();
        }
    }
}
