using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorPurba
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(ResultBox.Text);
            ResultBox2.Text = "+";
            ResultBox.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void Min_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(ResultBox.Text);
            ResultBox2.Text = "-";
            ResultBox.Text = " ";
            opr = 2;
            opr_selesai = true;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(ResultBox.Text);
            ResultBox2.Text = "*";
            ResultBox.Text = " ";
            opr = 3;
            opr_selesai = true;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(ResultBox.Text);
            ResultBox2.Text = "/";
            ResultBox.Text = " ";
            opr = 4;
            opr_selesai = true;
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (!ResultBox.Text.Contains('.'))
            {
                ResultBox.Text += ".";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
            bil1 = 0;
            bil2 = 0;
            ResultBox2.Text = " ";
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text != "0")
            {
                ResultBox.Text += "0";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "1";
            }
            else
            {
                ResultBox.Text += "1";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "2";
            }
            else
            {
                ResultBox.Text += "2";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "3";
            }
            else
            {
                ResultBox.Text += "3";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "4";
            }
            else
            {
                ResultBox.Text += "4";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "5";
            }
            else
            {
                ResultBox.Text += "5";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "6";
            }
            else
            {
                ResultBox.Text += "6";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "7";
            }
            else
            {
                ResultBox.Text += "7";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "8";
            }
            else
            {
                ResultBox.Text += "8";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "9";
            }
            else
            {
                ResultBox.Text += "9";
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (opr_selesai == true)
                bil2 = Convert.ToDecimal(ResultBox.Text);
            {
                switch (opr)
                {
                    case 1:
                        ResultBox.Text = Convert.ToString(bil1 + bil2);
                        break;
                    case 2:
                        ResultBox.Text = Convert.ToString(bil1 - bil2);
                        break;
                    case 3:
                        ResultBox.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 4:
                        ResultBox.Text = Convert.ToString(bil1 / bil2);
                        break;
                }
                opr_selesai = false;
            }
        }
    }
}