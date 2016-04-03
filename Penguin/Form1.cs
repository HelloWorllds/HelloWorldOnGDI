using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Microsoft.DirectX.AudioVideoPlayback;

namespace Penguin
{
    public partial class Form1 : Form
    {
        private int _hour;
        private int _min;
        private int _sec;

        Pen pHour;
        Pen pMin;
        Pen pSec;
        Pen z;
        Pen Numbers;

        Font f1;

        Graphics numbers;
        Graphics hour;
        Graphics min;
        Graphics sec;

        Matrix _Hour;
        Matrix _Min;
        Matrix _Sec;

        private int angle;

        private DateTime alarmTime;
        private bool isAlarmEnabled;

        Audio audio;

        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            pictureBox3.BackColor = Color.Transparent;

            pHour = new Pen(Color.Black, 5);
            pMin = new Pen(Color.Black, 4);
            pSec = new Pen(Color.Red, 3);
            z = new Pen(Color.White);
            Numbers = new Pen(Color.Black, 6);

            f1 = new Font("SketchFlow Print", 12, FontStyle.Bold);

            numbers = pictureBox3.CreateGraphics();
            hour = pictureBox3.CreateGraphics();
            min = pictureBox3.CreateGraphics();
            sec = pictureBox3.CreateGraphics();

            _Hour = new Matrix();
            _Min = new Matrix();
            _Sec = new Matrix();

            _hour = _min = _sec = 0;
            angle = 6;

            isAlarmEnabled = false;

            audio = new Audio("2. Morning_birds.mp3", false);
        }

        ~Form1()
        {
            hour.Dispose();
            min.Dispose();
            sec.Dispose();
            pHour.Dispose();
            pMin.Dispose();
            pSec.Dispose();
            _Hour.Dispose();
            _Min.Dispose();
            _Sec.Dispose();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics gEye1 = pictureBox1.CreateGraphics();
            Graphics gEye2 = pictureBox2.CreateGraphics();
            SolidBrush sb1 = new SolidBrush(Color.Black);
            Matrix Eye1 = new Matrix();
            Matrix Eye2 = new Matrix();

            int angle1 = 0;
            int angle2 = 0;
            
            angle1 = e.X + e.Y;
            angle2 = e.X + e.Y;

            Eye1.Translate(13, 9);
            Eye1.Rotate(angle1);
            gEye1.Transform = Eye1;

            Eye2.Translate(17, 15);
            Eye2.Rotate(angle2);
            gEye2.Transform = Eye2;

            gEye1.Clear(Color.White);
            gEye1.FillEllipse(sb1, new Rectangle(new Point(0, 0), new Size(8, 8)));

            gEye2.Clear(Color.White);
            gEye2.FillEllipse(sb1, new Rectangle(new Point(0, 0), new Size(12, 12)));

            sb1.Dispose();
            gEye1.Dispose();
            gEye2.Dispose();
            Eye1.Dispose();
            Eye2.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            int h = dt.Hour;
            int m = dt.Minute;
            int s = dt.Second;

            _sec = angle * s;
            _min = angle * m;
            if (_hour < 12)
                _hour = h * 30 + m / 2;
            else
                _hour = (h - 12) * 30 + m / 2;

            sec.DrawLine(z, 0, 0, 0, -30);
            hour.DrawLine(z, 0, 0, 0, -20);
            min.DrawLine(z, 0, 0, 0, -30);

            pictureBox3.Refresh();

            _Sec.Reset();
            _Sec.Translate(80, 60);
            _Sec.Rotate(_sec);
            sec.Transform = _Sec;
            sec.DrawLine(pSec, 0, 0, 0, -30);

            _Min.Reset();
            _Min.Translate(80, 60);
            _Min.Rotate(_min);
            min.Transform = _Min;
            min.DrawLine(pMin, 0, 0, 0, -30);

            _Hour.Reset();
            _Hour.Translate(80, 60);
            _Hour.Rotate(_hour);
            hour.Transform = _Hour;
            hour.DrawLine(pHour, 0, 0, 0, -20);

            numbers.DrawString("12", f1, Brushes.Black, 70, 5);
            //numbers.DrawString("11", f1, Brushes.Black, 5, 5);
            //numbers.DrawString("10", f1, Brushes.Black, 5, 20);
            numbers.DrawString("9", f1, Brushes.Black, 5, 55);
            //numbers.DrawString("8", f1, Brushes.Black, 5, 45);
            //numbers.DrawString("7", f1, Brushes.Black, 5, 50);
            numbers.DrawString("6", f1, Brushes.Black, 73, 107);
            //numbers.DrawString("5", f1, Brushes.Black, 145, 50);
            //numbers.DrawString("4", f1, Brushes.Black, 145, 45);
            numbers.DrawString("3", f1, Brushes.Black, 145, 55);
            //numbers.DrawString("2", f1, Brushes.Black, 145, 20);
            //numbers.DrawString("1", f1, Brushes.Black, 145, 5);

            if (isAlarmEnabled == true)
            {
                Alarm();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            int h = dt.Hour;
            int m = dt.Minute;
            int s = dt.Second;

            _sec = angle * s;
            _min = angle * m;
            if (_hour < 12)
                _hour = h * 30 + m / 2;
            else
                _hour = (h - 12) * 30 + m / 2;

            sec.DrawLine(z, 0, 0, 0, -30);
            hour.DrawLine(z, 0, 0, 0, -20);
            min.DrawLine(z, 0, 0, 0, -30);

            _Sec.Translate(80, 60);
            _Sec.Rotate(_sec);
            sec.Transform = _Sec;
            sec.DrawLine(pSec, 0, 0, 0, -30);

            _Min.Translate(80, 60);
            _Min.Rotate(_min);
            min.Transform = _Min;
            min.DrawLine(pMin, 0, 0, 0, -30);

            _Hour.Translate(80, 60);
            _Hour.Rotate(_hour);
            hour.Transform = _Hour;
            hour.DrawLine(pHour, 0, 0, 0, -20);

            timer1.Start();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Лысюк Владимир Александрович \nГруппа: в15пз2", "Об авторе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пингвин-Будильник.\nФункции:\n - Установка времени,\n - Сброс времени, \n - Изминение мелодии будильника \n\nВерсия 1.0.0.1", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void установитьВремяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            if (f2.ShowDialog() == DialogResult.OK)
            {
                alarmTime = DateTime.Today + new TimeSpan(Convert.ToInt32(f2.SendNum1), Convert.ToInt32(f2.SendNum2), Convert.ToInt32(f2.SendNum3));

                string str = string.Format("Время для будильника выставлено на \n{0:HH:mm:ss}", alarmTime);
                MessageBox.Show(str, "Будильник", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isAlarmEnabled = true;
            }       
        }

        private void изменитьМелодиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            if (f3.ShowDialog() == DialogResult.OK)
            {
                if (f3.IsCheked1) { audio = new Audio(f3.SendText1, false); }
                if (f3.IsCheked2) { audio = new Audio(f3.SendText2, false); }
                if (f3.IsCheked3) { audio = new Audio(f3.SendText3, false); }
                if (f3.IsCheked4) { audio = new Audio(f3.SendText4, false); }
                if (f3.IsCheked5) { audio = new Audio(f3.SendText5, false); }
                if (f3.IsCheked6) { audio = new Audio(f3.SendText6, false); }
                if (f3.IsCheked7) { audio = new Audio(f3.SendText7, false); }
            }
        }

        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            isAlarmEnabled = false;
            audio.Stop();
        }

        private void Alarm()
        {
            if (isAlarmEnabled && DateTime.Now >= alarmTime)
            {
                isAlarmEnabled = false;
                //MessageBox.Show("Оно работает!!!!", "Урааааааа");
                audio.Play();
            }
        }
    }
}
