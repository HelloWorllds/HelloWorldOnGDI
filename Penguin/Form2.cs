using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penguin
{
    public partial class Form2 : Form
    {
        public decimal SendNum1
        {
            get { return numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        public decimal SendNum2
        {
            get { return numericUpDown2.Value; }
        }

        public decimal SendNum3
        {
            get { return numericUpDown3.Value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
