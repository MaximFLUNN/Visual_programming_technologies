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
        string sign = " ", tmp_sign = " ", sign_for_sqrt = "", out_1 = "", out_2 = "", out_3 = "", string_label = "";
        double value_1 = 0, value_2 = 0, tmp = 0, multiply = 1.0;
        int sqrt_number = 0, del_null = 0, comma = 0;
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
            comma = 0;
            sqrt_number_func(ref value_1, ref value_2, ref sqrt_number);
            replacement(ref sign, "+");
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
            comma = 0;
            sqrt_number_func(ref value_1, ref value_2, ref sqrt_number);
            replacement(ref sign, "-");
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
            comma = 0;
            sqrt_number_func(ref value_1, ref value_2, ref sqrt_number);
            replacement(ref sign, "*"); ;
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
                if ((value_1 % 1) == 0) { comma = 0; }
            }
            if (sign == "+")
            {
                value_1 += value_2;
                label3.Text = label2.Text;
                label2.Text = label1.Text + " = " + value_1.ToString();
                label1.Text = value_1.ToString();
                value_2 = 0;
                if ((value_1 % 1) == 0) { comma = 0; }
            }
            if (sign == "-")
            {
                value_1 -= value_2;
                label3.Text = label2.Text;
                label2.Text = label1.Text + " = " + value_1.ToString();
                label1.Text = value_1.ToString();
                value_2 = 0;
                if ((value_1 % 1) == 0) { comma = 0; }
            }
            if (sign == "/")
            {
                value_1 /= value_2;
                label3.Text = label2.Text;
                label2.Text = label1.Text + " = " + value_1.ToString();
                label1.Text = value_1.ToString();
                string_label = label1.Text;
                value_2 = 0;
                if ((value_1 % 1) == 0) { comma = 0; }
            }
            if (sign == "*")
            {
                value_1 *= value_2;
                label3.Text = label2.Text;
                label2.Text = label1.Text + " = " + value_1.ToString();
                label1.Text = value_1.ToString();
                value_2 = 0;
                if ((value_1 % 1) == 0) { comma = 0; }
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
            comma = 0;
            sqrt_number_func(ref value_1, ref value_2, ref sqrt_number);
            replacement(ref sign, "/");
            check_sign(ref value_1, ref value_2);
            label1.Text += " / ";
            sign = "/";
            if (value_2 != 0)
            {
                value_1 += value_2;
                value_2 = 0;
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            string_label = label1.Text;
            int size = label1.Text.Length;
            if (sign == " ") { 
                value_1 *= value_1;
                del_number_mult(ref size);
                label1.Text += value_1;
            }
            else if (sign == "+" || sign == "-" || sign == "/" || sign == "*") { 
                value_2 *= value_2;
                del_number_mult(ref size);
                label1.Text += value_2;
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            string_label = label1.Text;
            int size = label1.Text.Length;
            if (sign == " ")
            {
                value_1 = 1 /  value_1;
                del_number_mult_X(ref size);
                label1.Text += value_1;
            }
            else if (sign == "+" || sign == "-" || sign == "/" || sign == "*")
            {
                value_2 = 1 / value_2;
                del_number_mult_X(ref size);
                label1.Text += value_2;
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            string_label = label1.Text;
            int size = label1.Text.Length;
            if (sign == " ")
            {
                del_number_mult(ref size);
                value_1 = 0;
                label1.Text += 0;
            }
            else if (sign == "+" || sign == "-" || sign == "/" || sign == "*")
            {
                del_number_mult(ref size);
                value_2 = 0;
            }
        }
        private void button23_Click(object sender, EventArgs e) // ← ²
        {
            string_label = label1.Text;
            int size = label1.Text.Length;
            if ((sign == "+" || sign == "-" || sign == "/" || sign == "*") && value_2 != 0)
            {
                del_number_mult(ref size);
                value_2 /= 100;
                label1.Text += value_2;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            string_label = label1.Text;
            int size = label1.Text.Length;
            if (sign == " ")
            {
                value_1 *= -1;
                del_number_mult(ref size);
                label1.Text += value_1;
            }
            else if (sign == "+" || sign == "-")
            {
                del_number_mult(ref size);
                label1.Text = string_label.Remove(size - 3, 3);
                if (sign == "+") 
                { 
                    label1.Text += " - ";
                    sign = "-";
                }
                else if (sign == "-")
                {
                    label1.Text += " + ";
                    sign = "+";
                }
                label1.Text += value_2;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!label1.Text.EndsWith(" ") && comma != 1 && comma != 2)
            {
                label1.Text += ",";
                comma = 1;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

            string_label = label1.Text;
            int size = label1.Text.Length;
            int size_char = 0;
            if (del_null == 1)
            {
                label1.Text = string_label.Remove(size - 1, 1);
            }
            if (sign == " " && del_null == 0) {
                if (value_1 >= -9 && value_1 <= -1) { size_char = del_null = 2; }
                else { size_char = 1; }
                value_1 = (value_1 - (value_1 % 10)) / 10;
            }
            else if ((sign == "+" || sign == "-" || sign == "/" || sign == "*") && del_null == 0) {
                value_2 = (value_2 - (value_2 % 10)) / 10;
                if (value_2 == 0 && !label1.Text.EndsWith("0")) { 
                    size_char = 3;
                    sign = " ";
                }
                else { size_char = 1; };
            }
            if (del_null == 0 && size != 1) { label1.Text = string_label.Remove(size - size_char, size_char); }
            else if (del_null == 0 && size_char == 1 && !label1.Text.EndsWith("0"))
            {
                label1.Text = string_label.Remove(size - 1, 1);
                label1.Text += "0";
            }
            if (del_null == 2 && sign == " " && size_char == 2)
            {
                label1.Text = string_label.Remove(size - size_char, size_char);
                label1.Text += "0";
            }
            size_char = del_null = 0;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            comma = 0;
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
        private async void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            groupBox2.Location = new Point(0, 403);
            groupBox2.Width = 0;
            for (int i = 0; i < 400; i++)
            {
                i += i / 48;
                await Task.Delay(17);
                groupBox2.Width = i;
            }
            for (byte r = 30, g = 144, b = 255, x = 0, y = 0, z = 0; r <= 230 & g  <= 230 & b >= 230 ; r += 13, g += 6, b -= 1, x += 15, y += 15, z += 15, await Task.Delay(30))
            {
                label6.ForeColor = label5.ForeColor = groupBox2.BackColor = Color.FromArgb(r, g, b); // 30, 144, 255
                label4.ForeColor = Color.FromArgb(x, y, z);
            }
            label6.Visible = label5.Visible = groupBox2.Visible = label4.Visible = groupBox1.Visible = false;
        }
        void add_num(ref double value_1, ref double value_2, string sign, int num)
        {
            if (comma == 1 || comma == 2) { multiply *= 0.1; }
            else { multiply = 1; }
            if (sign == " " && multiply == 1) { value_1 = value_1 * 10 + num; }
            else if ((sign == "+" || sign == "-" || sign == "/" || sign == "*") && multiply == 1) { value_2 = value_2 * 10 + num; }
            
            if (sign == " " && multiply != 1) {
                if (value_1 >= 0) { value_1 += num * multiply; }
                else { value_1 -= num * multiply; }
            }
            else if ((sign == "+" || sign == "-" || sign == "/" || sign == "*") && multiply != 1) {
                if (value_2 >= 0) { value_2 += num * multiply; }
                else { value_2 -= num * multiply; }
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
            }
        }
        void press_button(int num, ref double value_1, ref double value_2, ref string sign, object sender, EventArgs e)
        {
            del_null_back(value_1, value_2, sign, sender, e);
            label1.Text += num;
            add_num(ref value_1, ref value_2, sign, num);
        }
        void del_number_mult(ref int size)
        {
            while (size > 0 && !label1.Text.EndsWith(" "))
            {
                label1.Text = string_label.Remove(size - 1, 1);
                string_label = label1.Text;
                size = label1.Text.Length;

            }
        }
        void del_number_mult_X(ref int size)
        {
            while (size > 0 && !label1.Text.EndsWith(" "))
            {
                label1.Text = string_label.Remove(size - 1, 1);
                string_label = label1.Text;
                size = label1.Text.Length;

            }
        }
        void replacement(ref string sign, string tmp_sign)
        {
            if (label1.Text.EndsWith(" ") && value_2 == 0 && sign != tmp_sign && tmp_sign != " ")
            {
                string_label = label1.Text;
                int size = label1.Text.Length;
                tmp_sign = " ";
                if (size > 3) { label1.Text = string_label.Remove(size - 3, 3); }
            }
        }
    }
}
