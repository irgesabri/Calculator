using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string islem = "";
        Double deger = 0;
        bool opr_press = false;

        private void button12_Click(object sender, EventArgs e)
        {
            txtSonuc.Text ="1";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0"||opr_press)
                txtSonuc.Clear();
            opr_press = false;
            Button b = (Button)sender;
            txtSonuc.Text = txtSonuc.Text +b.Text;
        }

        private void islem_click(object sender, EventArgs e)
        {
            Button b= (Button)sender;
            islem = b.Text;
            deger = Convert.ToDouble(txtSonuc.Text);
            opr_press = true;
            label1.Text = deger + "" + islem;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch (islem)
            {
                case "+":
                    txtSonuc.Text = (deger+Convert.ToDouble(txtSonuc.Text) ).ToString(); break;
                case "-":
                    txtSonuc.Text = (deger-Convert.ToDouble(txtSonuc.Text) ).ToString(); break;
                case "*":
                    txtSonuc.Text = (deger * Convert.ToDouble(txtSonuc.Text)).ToString(); break;
                case "/":
                    txtSonuc.Text = (deger/Convert.ToDouble(txtSonuc.Text) ).ToString(); break;

                default:
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtSonuc.Text," ")<0)
            {
                txtSonuc.Text = txtSonuc.Text.Substring(0, txtSonuc.Text.Length - 1 + 1);
            }
            else
            {
                txtSonuc.Text = txtSonuc.Text.Substring(0, txtSonuc.Text.Length - 1);
            }            
        }
    }
}
