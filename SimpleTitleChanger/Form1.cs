using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTitleChanger
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        private static extern bool SetWindowText(IntPtr hWnd, string text);
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string processName = textBox1.Text;
            string nameToChangeTo = textBox2.Text;

            foreach (Process process in Process.GetProcessesByName(processName))
            {
                SetWindowText(process.MainWindowHandle, nameToChangeTo);
                MessageBox.Show("Title/Name of the application is changed!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
