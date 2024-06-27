using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide Form1
            this.Hide();

            // Show Quiz1 as a dialog
            Quiz1 quiz1 = new Quiz1();
            quiz1.FormClosed += Quiz1_FormClosed; // Subscribe to FormClosed event
            quiz1.ShowDialog();
        }

        private void Quiz1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show Form1 again when Quiz1 is closed
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show Quiz1 as a dialog
            Quiz2 quiz2 = new Quiz2();
            quiz2.FormClosed += Quiz1_FormClosed; // Subscribe to FormClosed event
            quiz2.ShowDialog();
        }
    }
}
