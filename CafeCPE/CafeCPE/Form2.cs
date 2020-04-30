using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeCPE
{
    public partial class App : Form
    {
        Form1 f2 = new Form1();
        Form4 f3 = new Form4();
        public App()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Order_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        double Co1, Co2, Co3, Co4, Co5, Te1, Te2, Te3, Te4, Te5, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, alltotal;

        private void Order_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                f2.Show();
                f3.Show();
                f2.textBox5.Text = textBox16.Text;
                f2.textBox4.Text = CtextBox1.Text + "\r\n\n" + CtextBox2.Text + "\r\n\n" + CtextBox3.Text + "\r\n\n" + CtextBox4.Text + "\r\n\n" + CtextBox5.Text + "\r\n\n" + CtextBox6.Text
                    + "\r\n\n" + CtextBox7.Text + "\r\n\n" + CtextBox8.Text + "\r\n\n" + CtextBox9.Text + "\r\n\n" + CtextBox10.Text + "\r\n\n";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void B4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void T4_CheckedChanged(object sender, EventArgs e)
        {
            if (T4.Checked)
            {
                numericUpDown9.Enabled = true;
                CtextBox9.Text = "9. Black Tea";
                numericUpDown9.Value = 1;
            }
            else
            {
                numericUpDown9.Enabled = false;
                numericUpDown9.Value = 0;
                CtextBox9.Text = " ";
            }
        }

        private void T3_CheckedChanged(object sender, EventArgs e)
        {
            if (T3.Checked)
            {
                numericUpDown8.Enabled = true;
                CtextBox8.Text = "8. Lemon Tea";
                numericUpDown8.Value = 1;
            }
            else
            {
                numericUpDown8.Enabled = false;
                numericUpDown8.Value = 0;
                CtextBox8.Text = " ";
            }
        }

        private void T2_CheckedChanged(object sender, EventArgs e)
        {
            if (T2.Checked)
            {
                numericUpDown7.Enabled = true;
                CtextBox7.Text = "7. Milk Tea";
                numericUpDown7.Value = 1;
            }
            else
            {
                numericUpDown7.Enabled = false;
                numericUpDown7.Value = 0;
                CtextBox7.Text = " ";
            }
        }

        private void T1_CheckedChanged(object sender, EventArgs e)
        {
            if (T1.Checked)
            {
                numericUpDown6.Enabled = true;
                CtextBox6.Text = "6. Green Tea";
                numericUpDown6.Value = 1;
            }
            else
            {
                numericUpDown6.Enabled = false;
                numericUpDown6.Value = 0;
                CtextBox6.Text = " ";
            }
        }

        private void C4_CheckedChanged(object sender, EventArgs e)
        {
            if (C4.Checked)
            {
                numericUpDown4.Enabled = true;
                CtextBox4.Text = "4. Mocha";
                numericUpDown4.Value = 1;
            }
            else
            {
                numericUpDown4.Enabled = false;
                numericUpDown4.Value = 0;
                CtextBox4.Text = " ";
            }
        }

        private void C5_CheckedChanged(object sender, EventArgs e)
        {
            if (C5.Checked)
            {
                numericUpDown5.Enabled = true;
                CtextBox5.Text = "5. Latte";
                numericUpDown5.Value = 1;
            }
            else
            {
                numericUpDown5.Enabled = false;
                numericUpDown5.Value = 0;
                CtextBox5.Text = " ";
            }
        }

        private void C3_CheckedChanged(object sender, EventArgs e)
        {
            if (C3.Checked)
            {
                numericUpDown3.Enabled = true;
                CtextBox3.Text = "3. Espresso";
                numericUpDown3.Value = 1;
            }
            else
            {
                numericUpDown3.Enabled = false;
                numericUpDown3.Value = 0;
                CtextBox3.Text = " ";
            }
        }

        private void C2_CheckedChanged(object sender, EventArgs e)
        {
            if (C2.Checked)
            {
                numericUpDown2.Enabled = true;
                CtextBox2.Text = "2. Cappuccino";
                numericUpDown2.Value = 1;
            }
            else
            {
                numericUpDown2.Enabled = false;
                numericUpDown2.Value = 0;
                CtextBox2.Text = " ";
            }
        }

        private void Sum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Co1 = 0;
            Co2 = 0;
            Co3 = 0;
            Co4 = 0;
            Co5 = 0;
            Te1 = 0;
            Te2 = 0;
            Te3 = 0;
            Te4 = 0;
            Te5 = 0;

            textBox2.Text = numericUpDown1.Value.ToString();
            textBox3.Text = numericUpDown2.Value.ToString();
            textBox4.Text = numericUpDown3.Value.ToString();
            textBox5.Text = numericUpDown4.Value.ToString();
            textBox6.Text = numericUpDown5.Value.ToString();
            textBox7.Text = numericUpDown6.Value.ToString();
            textBox8.Text = numericUpDown7.Value.ToString();
            textBox9.Text = numericUpDown8.Value.ToString();
            textBox10.Text = numericUpDown9.Value.ToString();
            textBox11.Text = numericUpDown10.Value.ToString();

            if (C1.Checked)
            {
                b1 = double.Parse(textBox2.Text);
                Co1 = 35;
                num1 = b1 * Co1;
            }
            else
            {
                b1 = double.Parse(textBox2.Text);
                Co1 = 35;
                num1 = b1 * Co1;
            }

            if (C2.Checked)
            {
                b2 = double.Parse(textBox3.Text);
                Co2 = 45;
                num2 = b2 * Co2;
            }
            else
            {
                b2 = double.Parse(textBox3.Text);
                Co2 = 45;
                num2 = b2 * Co2;
            }

            if (C3.Checked)
            {
                b3 = double.Parse(textBox4.Text);
                Co3 = 35;
                num3 = b3 * Co3;
            }
            else
            {
                b3 = double.Parse(textBox4.Text);
                Co3 = 35;
                num3 = b3 * Co3;
            }

            if (C4.Checked)
            {
                b4 = double.Parse(textBox5.Text);
                Co4 = 50;
                num4 = b4 * Co4;
            }
            else
            {
                b4 = double.Parse(textBox5.Text);
                Co4 = 50;
                num4 = b4 * Co4;
            }

            if (C5.Checked)
            {
                b5 = double.Parse(textBox6.Text);
                Co5 = 50;
                num5 = b5 * Co5;
            }
            else
            {
                b5 = double.Parse(textBox6.Text);
                Co5 = 50;
                num5 = b5 * Co5;
            }

            if (T1.Checked)
            {
                b6 = double.Parse(textBox7.Text);
                Te1 = 45;
                num6 = b6 * Te1;
            }
            else
            {
                b6 = double.Parse(textBox7.Text);
                Te1 = 45;
                num6 = b6 * Te1;
            }

            if (T2.Checked)
            {
                b7 = double.Parse(textBox8.Text);
                Te2 = 40;
                num7 = b7 * Te2;
            }
            else
            {
                b7 = double.Parse(textBox8.Text);
                Te2 = 40;
                num7 = b7 * Te2;
            }

            if (T3.Checked)
            {
                b8 = double.Parse(textBox9.Text);
                Te3 = 45;
                num8 = b8 * Te3;
            }
            else
            {
                b8 = double.Parse(textBox9.Text);
                Te3 = 45;
                num8 = b8 * Te3;
            }

            if (T4.Checked)
            {
                b9 = double.Parse(textBox10.Text);
                Te4 = 35;
                num9 = b9 * Te4;
            }
            else
            {
                b9 = double.Parse(textBox10.Text);
                Te4 = 35;
                num9 = b9 * Te4;
            }

            if (T5.Checked)
            {
                b10 = double.Parse(textBox11.Text);
                Te5 = 40;
                num10 = b10 * Te5;
            }
            else
            {
                b10 = double.Parse(textBox11.Text);
                Te5 = 40;
                num10 = b10 * Te5;
            }

            
            alltotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;
            textBox16.Text = (alltotal + "");

            //////////////////////////////////////////////////////////////////////////////////


            String str1;
            str1 = "";

            if (C1.Checked)
            {
                b1 = double.Parse(textBox2.Text);
                Co1 = 35;
                num1 = b1 * Co1;
                str1 += " \r\n\n1. Black Coffee";
            }
            else
            {
                b1 = double.Parse(textBox2.Text);
                Co1 = 35;
                num1 = b1 * Co1;
            }
            if (C2.Checked)
            {
                b2 = double.Parse(textBox3.Text);
                Co2 = 45;
                num2 = b2 * Co2;
                str1 += " \r\n\n2. Cappuccino";
            }
            else
            {
                b2 = double.Parse(textBox3.Text);
                Co1 = 45;
                num2 = b2 * Co2;
            }
            if (C3.Checked)
            {
                b3 = double.Parse(textBox4.Text);
                Co3 = 35;
                num3 = b3 * Co3;
                str1 += " \r\n\n3. Espresso";
            }
            else
            {
                b3 = double.Parse(textBox4.Text);
                Co3 = 35;
                num3 = b3 * Co3;
            }
            if (C4.Checked)
            {
                b4 = double.Parse(textBox5.Text);
                Co4 = 50;
                num4 = b4 * Co4;
                str1 += " \r\n\n4. Mocha";
            }
            else
            {
                b4 = double.Parse(textBox5.Text);
                Co4 = 50;
                num4 = b4 * Co4;
            }
            if (C5.Checked)
            {
                b5 = double.Parse(textBox6.Text);
                Co5 = 50;
                num5 = b5 * Co5;
                str1 += " \r\n\n5. Latte";
            }
            else
            {
                b5 = double.Parse(textBox6.Text);
                Co5 = 50;
                num5 = b5 * Co5;
            }
            if (T1.Checked)
            {
                b6 = double.Parse(textBox7.Text);
                Te1 = 45;
                num6 = b6 * Te1;
                str1 += " \r\n\n6. Green Tea";
            }
            else
            {
                b6 = double.Parse(textBox7.Text);
                Te1 = 45;
                num6 = b6 * Te1;
            }
            if (T2.Checked)
            {
                b7 = double.Parse(textBox8.Text);
                Te2 = 40;
                num7 = b7 * Te2;
                str1 += " \r\n\n7. Milk Tea";
            }
            else
            {
                b7 = double.Parse(textBox8.Text);
                Te2 = 40;
                num7 = b7 * Te2;
            }
            if (T3.Checked)
            {
                b8 = double.Parse(textBox9.Text);
                Te3 = 45;
                num8 = b8 * Te3;
                str1 += " \r\n\n8. Lemon Tea";
            }
            else
            {
                b8 = double.Parse(textBox9.Text);
                Te3 = 45;
                num8 = b8 * Te3;
            }
            if (T4.Checked)
            {
                b9 = double.Parse(textBox10.Text);
                Te4 = 35;
                num9 = b9 * Te4;
                str1 += " \r\n\n9. Black Tea";
            }
            else
            {
                b9 = double.Parse(textBox10.Text);
                Te4 = 35;
                num9 = b9 * Te4;
            }
            if (T5.Checked)
            {
                b10 = double.Parse(textBox11.Text);
                Te5 = 40;
                num10 = b10 * Te5;
                str1 += " \r\n\n10. Tea";
            }
            else
            {
                b10 = double.Parse(textBox11.Text);
                Te5 = 40;
                num10 = b10 * Te5;
            }

            Order.Text = "ID  List Menu"+str1;
        }

        private void Clear_Click_2(object sender, EventArgs e)
        {
            Order.Clear();
            textBox16.Clear();
            C1.Checked = false;
            C2.Checked = false;
            C3.Checked = false;
            C4.Checked = false;
            C5.Checked = false;
            T1.Checked = false;
            T2.Checked = false;
            T3.Checked = false;
            T4.Checked = false;
            T5.Checked = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("See you next time at CPE Cafe", "CPE Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void C1_CheckedChanged(object sender, EventArgs e)
        {
            if (C1.Checked)
            {
                numericUpDown1.Enabled = true;
                CtextBox1.Text = "1. Black Coffee";
                numericUpDown1.Value = 1;

            }
            else
            {
                CtextBox1.Text = " ";
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void T5_CheckedChanged(object sender, EventArgs e)
        {
            if (T5.Checked)
            {
                numericUpDown10.Enabled = true;
                CtextBox10.Text = "10. Tea";
                numericUpDown10.Value = 1;
            }
            else
            {
                numericUpDown10.Enabled = false;
                numericUpDown10.Value = 0;
                CtextBox10.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
