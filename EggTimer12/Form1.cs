using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Basic Timer; Written after watching a YouTube tutorial and modified with additional basic logic and buttons.
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
        private void button4_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            buttonExex();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Button m = (Button)sender;
            buttonExexTwo();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Button h = (Button)sender;
            buttonExexThree();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
        
  
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            resetButton();
        }

        private void buttonExex(){

            s = s += 1;
            string ss = Convert.ToString(s);
            if (s > 9)
            {
                label3.Text = ss;
            }
            else
            {
                label3.Text = "0" + ss;
            }
        }

        private void buttonExexTwo(){
            m = m += 1;
            string mm = Convert.ToString(m);
            if (m > 9)
            {
                label2.Text = mm;
            }
            else
            {
                label2.Text = "0" + mm; 
            }
        }

        private void buttonExexThree()
        {
            h = h += 1;
            string hh = Convert.ToString(h);

            label1.Text = hh;
            if (h > 9)
            {
                label1.Text = hh;
            }
            else
            {
                label1.Text = "0" + hh;
            }
        }
        private void resetButton(){
            h = 0;
            s = 0;
            m = 0;

            string hh = Convert.ToString("0" + h);
            string ss = Convert.ToString("0" + s);
            string mm = Convert.ToString("0" + m);

            label2.Text = mm;
            label3.Text = ss;
            label1.Text = hh;


 
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
            label2.Text = mm;
            label3.Text = ss;
            if (h < 10)
            {
                label1.Text = "0" + hh;
            }
            else
            {
                label1.Text = hh;
            }
            if (s < 10)
            {
                label3.Text = "0" + ss;
            }
            else
            {
                label3.Text = ss;
            }
            if (m < 10)
            {
                label2.Text = "0" + mm;
            }
            else
            {
                label2.Text = mm;
            }  
        }
        private void beaCon(object sender, EventArgs e)
        {
         button1 = new Button();
         if (h == 0 && m == 0 && s == 0){
             
             button1.Enabled = true;
         }else{
             button1.Enabled = false;
         }
        
        }

    }  
}

