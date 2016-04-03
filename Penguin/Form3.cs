using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using WMPLib;

namespace Penguin
{
    public partial class Form3 : Form
    {
        Audio audio1;
        Audio audio2;
        Audio audio3;
        Audio audio4;
        Audio audio5;
        Audio audio6;
        Audio audio7;

        public string SendText1 { get { return textBox1.Text; } }
        public string SendText2 { get { return textBox2.Text; } }
        public string SendText3 { get { return textBox3.Text; } }
        public string SendText4 { get { return textBox4.Text; } }
        public string SendText5 { get { return textBox5.Text; } }
        public string SendText6 { get { return textBox6.Text; } }
        public string SendText7 { get { return textBox7.Text; } }

        public bool IsCheked1 { get { return radioButton1.Checked; } }
        public bool IsCheked2 { get { return radioButton2.Checked; } }
        public bool IsCheked3 { get { return radioButton3.Checked; } }
        public bool IsCheked4 { get { return radioButton4.Checked; } }
        public bool IsCheked5 { get { return radioButton5.Checked; } }
        public bool IsCheked6 { get { return radioButton6.Checked; } }
        public bool IsCheked7 { get { return radioButton7.Checked; } }

        public Form3()
        {
            InitializeComponent();

            audio1 = new Audio("1. Limp_Bizkit-Break_Stuff.mp3", false);
            audio2 = new Audio("2. Morning_birds.mp3", false);
            audio3 = new Audio("3. Вставай, штанишки одевай.mp3", false);
            audio4 = new Audio("4. Radio_SSSR.mp3", false);
            audio5 = new Audio("5. Snap-Got_To_Power.mp3", false);
            audio6 = new Audio("6. Sviridov-Vremya_vpered.mp3", false);
            audio7 = new Audio("7. старый будильник.mp3", false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            audio1.Stop();
            audio2.Stop();
            audio3.Stop();
            audio4.Stop();
            audio5.Stop();
            audio6.Stop();
            audio7.Stop();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            audio1.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            audio2.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            audio3.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            audio4.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            audio5.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            audio6.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            audio7.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            audio1.Stop();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            audio2.Stop();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            audio3.Stop();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            audio4.Stop();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            audio5.Stop();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            audio6.Stop();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            audio7.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            audio1.Stop();
            audio2.Stop();
            audio3.Stop();
            audio4.Stop();
            audio5.Stop();
            audio6.Stop();
            audio7.Stop();

            this.DialogResult = DialogResult.OK;
        }
    }
}
