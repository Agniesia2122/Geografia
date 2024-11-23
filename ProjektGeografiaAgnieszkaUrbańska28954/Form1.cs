using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ProjektGeografiaAgnieszkaUrbańska28954
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 openForm = new Form3();
            openForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 openForm = new Form4();
            openForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 openForm = new Form5();
            openForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 openForm = new Form6();
            openForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form7 openForm = new Form7();
            openForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form8 openForm = new Form8();
            openForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form9 openForm = new Form9();
            openForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form10 openForm = new Form10();
            openForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 openForm = new Form11();
            openForm.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if (radioButton1.Checked)
            {
                sp.Stop();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if (radioButton2.Checked)
            {
                sp.SoundLocation = @"C:\Users\dell\source\repos\ProjektGeografiaAgnieszkaUrbańska28954\zasoby\morning_birds.wav";
                sp.PlayLooping();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if (radioButton3.Checked)
            {
                sp.SoundLocation = @"C:\Users\dell\source\repos\ProjektGeografiaAgnieszkaUrbańska28954\zasoby\ocean_waves_sound.wav";
                sp.PlayLooping();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if (radioButton4.Checked)
            {
                sp.SoundLocation = @"C:\Users\dell\source\repos\ProjektGeografiaAgnieszkaUrbańska28954\zasoby\rain_thunder_sound.wav";
                sp.PlayLooping();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if (radioButton5.Checked)
            {
                sp.SoundLocation = @"C:\Users\dell\source\repos\ProjektGeografiaAgnieszkaUrbańska28954\zasoby\airplane_cabin_sound.wav";
                sp.PlayLooping();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if (radioButton6.Checked)
            {
                sp.SoundLocation = @"C:\Users\dell\source\repos\ProjektGeografiaAgnieszkaUrbańska28954\zasoby\spaceship_cabin_sound.wav";
                sp.PlayLooping();
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if (radioButton7.Checked)
            {
                sp.SoundLocation = @"C:\Users\dell\source\repos\ProjektGeografiaAgnieszkaUrbańska28954\zasoby\relaxing_music.wav";
                sp.PlayLooping();
            }
        }

        private void białyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void niebieskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void zielonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void ankietaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autorka wybrała niniejszy temat, ponieważ kocha podróżować i poznawać prawdziwy świat.");
        }

        private void àproposŚwiataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 openForm = new Form13();
            openForm.Show();
        }

        private void ankietaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 openForm = new Form14();
            openForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = openFileDialog1.FileName;

            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            label5.Text = comboBox1.Items[index].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mamy nadzieję, że podzielisz się swoimi wrażeniami :)");
        }
    }
}
