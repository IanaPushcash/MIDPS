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
    public partial class Calc : Form
    {
        public float buf1 = float.NaN;
        public float buf2 = float.NaN;
        public float result = float.NaN;
        public int opt;
        public Boolean tb_null = false, eq = false;
        public Calc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_num("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_num("8");
        }

        private void but_0_Click(object sender, EventArgs e)
        {
            if (!tb_null)
            {
                if (tb.Text.Length < 10)
                    if (tb.Text.Length != 1 && tb.Text != "0" && tb.Text != "-0") tb.Text += "0";
            }
            else tb.Text = "0";
            tb_null = false;
        }

        private void Add_num(String n)
        {
            if (!tb_null)
            {
                if (tb.Text.Length < 10)
                {
                    if (tb.Text == "0") tb.Text = "";
                    else if (tb.Text == "-0") tb.Text = "-";
                    tb.Text += n;
                }
            }
            else tb.Text = n;
            tb_null = false;
        }

        private void but_1_Click(object sender, EventArgs e)
        {
            Add_num("1");
        }

        private void but_2_Click(object sender, EventArgs e)
        {
            Add_num("2");
        }

        private void but_3_Click(object sender, EventArgs e)
        {
            Add_num("3");
        }

        private void but_4_Click(object sender, EventArgs e)
        {
            Add_num("4");
        }

        private void but_5_Click(object sender, EventArgs e)
        {
            Add_num("5");
        }

        private void but_6_Click(object sender, EventArgs e)
        {
            Add_num("6");
        }

        private void but_9_Click(object sender, EventArgs e)
        {
            Add_num("9");
        }

        private void but_dot_Click(object sender, EventArgs e)
        {
            if (!tb_null)
            {
                if (!tb.Text.Contains(',')) tb.Text += ",";
            }
            else tb.Text = "0,";
            tb_null = false;
        }

        private void but_C_Click(object sender, EventArgs e)
        {
            buf1 = buf2 = result = float.NaN;
            tb.Text = "0";
            opt = 0;
        }

        private void but_CE_Click(object sender, EventArgs e)
        {
            tb.Text = "0";
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (tb.Text.Length > 1) tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
            else tb.Text = "0";
            tb_null = false;
        }

        private void but_inv_Click(object sender, EventArgs e)
        {

            if (tb.Text[0] != '-') tb.Text = "-" + tb.Text;
            else tb.Text = tb.Text.Substring(1, tb.Text.Length-1);

            tb_null = false;
        }

        public void Remember(int opt)
        {
            if (eq) buf2 = buf1 = float.NaN;
            if (float.IsNaN(buf1)) buf1 = System.Convert.ToSingle(tb.Text);
            else 
            {
                buf2 = System.Convert.ToSingle(tb.Text);
                Calculation(opt);
                buf1 = result;
                tb.Text = result + "";
            }
            eq = false;
        }

        public void Calculation(int opt)
        {            
            switch (opt)
            {
                case 1:
                    result = buf1 + buf2;
                    break;
                case 2:
                    result = buf1 - buf2;
                    break;
                case 3:
                    result = buf1 * buf2;
                    break;
                case 4:
                    if (buf2 != 0) result = buf1 / buf2;
                    else
                    {
                        tb.Text = "Division by zero";
                        tb_null = true;
                    }
                    break;
                case 5:
                    result = System.Convert.ToSingle(Math.Pow(buf1, buf2));
                    break;
            }
        }

        private void but_plus_Click(object sender, EventArgs e)
        {
            Remember(opt);
            opt = 1;
            tb_null = true;
        }

        private void but_min_Click(object sender, EventArgs e)
        {
            Remember(opt);
            opt = 2;
            tb_null = true;
        }

        private void but_mult_Click(object sender, EventArgs e)
        {
            Remember(opt);
            opt = 3;
            tb_null = true;
        }

        private void but_div_Click(object sender, EventArgs e)
        {
            Remember(opt);
            opt = 4;
            tb_null = true;
        }

        private void but_pow_Click(object sender, EventArgs e)
        {
            Remember(opt);
            opt = 5;
            tb_null = true;
        }

        private void but_sqrt_Click(object sender, EventArgs e)
        {
            buf1 = System.Convert.ToSingle(tb.Text);
            if (buf1 < 0) tb.Text = "Operand is negative";
            else
            {
                buf1 = System.Convert.ToSingle(Math.Sqrt(buf1));
                tb.Text = buf1 + "";
            }
            tb_null = true;
        }

        private void but_eq_Click(object sender, EventArgs e)
        {
            if (float.IsNaN(buf2)) buf2 = System.Convert.ToSingle(tb.Text);
            Calculation(opt);
            buf1 = result;
            result = float.NaN;
            tb.Text = buf1 + "";
            tb_null = true;
            eq = true;
        }
    }
}
