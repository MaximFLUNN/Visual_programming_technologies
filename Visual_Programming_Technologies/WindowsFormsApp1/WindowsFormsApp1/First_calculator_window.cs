using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class First_calculator_window : Form
    {
        string sign = " ", sign_for_sqrt = "", out_1 = "", out_2 = "", out_3 = "", string_label = "";
        double value_1 = 0, value_2 = 0, tmp = 0;
        int sqrt_number = 0, del_null = 0;
        public First_calculator_window()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            press_button(1, ref value_1, ref value_2, ref sign, sender, e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            press_button(2, ref value_1, ref value_2, ref sign, sender, e);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            press_button(3, ref value_1, ref value_2, ref sign, sender, e);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            press_button(4, ref value_1, ref value_2, ref sign, sender, e);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            press_button(5, ref value_1, ref value_2, ref sign, sender, e);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            press_button(6, ref value_1, ref value_2, ref sign, sender, e);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            press_button(7, ref value_1, ref value_2, ref sign, sender, e);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            press_button(8, ref value_1, ref value_2, ref sign, sender, e);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            press_button(9, ref value_1, ref value_2, ref sign, sender, e);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            sqrt_number_func(ref value_1, ref value_2, ref sqrt_number);
            check_sign(ref value_1, ref value_2);
            label1.Text += " + ";
            sign = "+";
            if (value_2 != 0)
            {
                value_1 += value_2;
                value_2 = 0;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            sqrt_number_func(ref value_1, ref value_2, ref sqrt_number);
            check_sign(ref value_1, ref value_2);
            label1.Text += " - ";
            sign = "-";
            if (value_2 != 0)
            {
                value_1 -= value_2;
                value_2 = 0;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            sqrt_number_func(ref value_1, ref value_2, ref sqrt_number);
            check_sign(ref value_1, ref value_2);
            label1.Text += " * ";
            sign = "*";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if ((value_1 != 0 && sign == " ") || (value_2 == 0 && sign != " " && !label1.Text.EndsWith("0")) || value_2 != 0) { label1.Text += 0; }
            add_num(ref value_1, ref value_2, sign, 0);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            sqrt_number_func(ref value_1, ref value_2, ref sqrt_number);
            if (sign == " ") {
                label3.Text = label2.Text;
                label2.Text = label1.Text + " = " + value_1.ToString();
                label1.Text = value_1.ToString();
            }
            if (sign == "+")
            {
                value_1 += value_2;
                label3.Text = label2.Text;
                label2.Text = label1.Text + " = " + value_1.ToString();
                label1.Text = value_1.ToString();
                value_2 = 0;
            }
            if (sign == "-")
            {
                value_1 -= value_2;
                label3.Text = label2.Text;
                label2.Text = label1.Text + " = " + value_1.ToString();
                label1.Text = value_1.ToString();
                value_2 = 0;
            }
            if (sign == "/")
            {
                value_1 /= value_2;
                label3.Text = label2.Text;
                label2.Text = label1.Text + " = " + value_1.ToString();
                label1.Text = value_1.ToString();
                string_label = label1.Text;
                value_2 = 0;
            }
            if (sign == "*")
            {
                value_1 *= value_2;
                label3.Text = label2.Text;
                label2.Text = label1.Text + " = " + value_1.ToString();
                label1.Text = value_1.ToString();
                value_2 = 0;
            }
            sign = " ";
        }
        private void button15_Click(object sender, EventArgs e) // ← ²
        {
            sign = " ";
            value_1 = value_2 = 0;
            label1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sqrt_number_func(ref value_1, ref value_2, ref sqrt_number);
            check_sign(ref value_1, ref value_2);
            label1.Text += " / ";
            sign = "/";
            if (value_2 != 0)
            {
                value_1 += value_2;
                value_2 = 0;
            }
        }
        private void button19_Click(object sender, EventArgs e) // ← ²
        {
            string_label = label1.Text;
            int size = label1.Text.Length;
            int size_char = 0;
            if (del_null == 1)
            {
                label1.Text = string_label.Remove(size - 1, 1);
            }
            if (sign == " " && del_null == 0) {
                value_1 = (value_1 - (value_1 % 10)) / 10;
                size_char = 1;
            }
            else if ((sign == "+" || sign == "-" || sign == "/" || sign == "*") && del_null == 0) {
                value_2 = (value_2 - (value_2 % 10)) / 10;
                sign = " ";
                if (value_2 == 0 && !label1.Text.EndsWith("0")) { size_char = 3; }
                else { size_char = 1; };
            }
            if (del_null == 0 && size != 1) { label1.Text = string_label.Remove(size - size_char, size_char); }
            else if (del_null == 0 && size_char == 1 && !label1.Text.EndsWith("0"))
            {
                label1.Text = string_label.Remove(size - 1, 1);
                label1.Text += "0";
            }
            size_char = del_null = 0;
        }
        private void button21_Click(object sender, EventArgs e) // Доделать !
        {
            del_null_back(value_1, value_2, sign, sender, e);
            label1.Text += "√";
            if (value_1 != 0 && sign == " ")
            {
                tmp = value_1;
                value_1 = 0;
                sqrt_number = 1;
            }
            else if (value_1 == 0 && sign == " ")
            {
                sqrt_number = 2;
            }
            else if (value_2 != 0 && (sign == "+" || sign == "-" || sign == "/" || sign == "*"))
            {
                tmp = value_2;
                value_2 = 0;
                sqrt_number = 3;
            }
            else if (value_2 == 0 && (sign == "+" || sign == "-" || sign == "/" || sign == "*"))
            {
                sqrt_number = 4;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
        void add_num(ref double value_1, ref double value_2, string sign, int num)
        {
            if (sign == " ")
            {
                value_1 = value_1 * 10 + num;
            }
            else if (sign == "+" || sign == "-" || sign == "/" || sign == "*")
            {
                value_2 = value_2 * 10 + num;
            }
        }
        void check_sign(ref double value_1, ref double value_2)
        {
            if (value_2 != 0)
            {
                if (sign == "+") { value_1 += value_2; }
                else if (sign == "-") { value_1 -= value_2; }
                else if (sign == "*") { value_1 *= value_2; }
                else if (sign == "/") { value_1 /= value_2; }
                value_2 = 0;
            }
        }
        void sqrt_number_func(ref double value_1, ref double value_2, ref int sqrt_number)
        {
            if (sqrt_number == 1) { value_1 = tmp * Math.Sqrt(value_1); }
            else if (sqrt_number == 2) { value_1 = Math.Sqrt(value_1); }
            else if (sqrt_number == 3) { value_2 = tmp * Math.Sqrt(value_2); }
            else if (sqrt_number == 4) { value_2 = Math.Sqrt(value_2); }
            sqrt_number = 0;
        }
        void del_null_back(double value_1, double value_2, string sign, object sender, EventArgs e)
        {
            if ((value_1 == 0 || value_1 != 0 && sign != " " && value_2 == 0) && label1.Text.EndsWith("0"))
            {
                del_null = 1;
                button19_Click(sender, e);
                //if (label1.Text.EndsWith("0"))
                //{
                //    del_null_back(value_1, value_2, sign, sender, e);
                //}
            }
        }
        void press_button(int num, ref double value_1, ref double value_2, ref string sign, object sender, EventArgs e)
        {
            del_null_back(value_1, value_2, sign, sender, e);
            label1.Text += num;
            add_num(ref value_1, ref value_2, sign, num);
        }
    }
}
