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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
		private void button1_Click(object sender, EventArgs e)
        {
			if (textBox1.Text == "")
			{
				MessageBox.Show("กรุณากรอก  Username");
				textBox1.Focus();
			}
			else if (textBox2.Text == "")
			{
				MessageBox.Show("กรุณากรอก Password");
				textBox2.Focus();
			}

			else if (textBox1.Text != "Test" || textBox2.Text != "1111")
			{
				MessageBox.Show("กรุณาใส่ Username และ Password ให้ถูกต้อง");
				textBox2.Focus();
				textBox2.SelectAll();
			}
			else
			{
				Visible = false;
				App form2 = new App();
				form2.Visible = true;
			}
		}
		private void button2_Click(object sender, EventArgs e)
        {
			this.Dispose();
		}

		private void button1_KeyDown(object sender, KeyEventArgs e)
		{
			
		}

		private void textBox2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				button1_Click(sender, e);
		}
	}
}
