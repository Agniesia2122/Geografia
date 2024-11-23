using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektGeografiaAgnieszkaUrbańska28954
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 openForm = new Form12();
            openForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://poznajnieznane.pl/ciekawostki-2/ciekawostki-panstwa-3/argentyna-ciekawostki/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
