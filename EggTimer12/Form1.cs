using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggTimer12
{
    public partial class Form1 : Form
    {
        int h;
        int m;
        int s;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "00";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "00";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "00";
            }
            h = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
            s = Convert.ToInt32(textBox3.Text);
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
  
            if (s == -1)
            {
                m -= 1;
                s = 59;
            }
            if (m == -1)
            {
                h -= 1;
                m = 59;
            }
            if (h == 0 && m == 0 && s == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time is up!", "Time Alert");
            }
            string hh = Convert.ToString(h);
            string mm = Convert.ToString(m);
            string ss = Convert.ToString(s);
            label1.Text = hh;
            label2.Text = mm;
            label3.Text = ss;
            

        }
    }
}
