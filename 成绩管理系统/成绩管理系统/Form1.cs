using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 成绩管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string password = textBox2.Text;
            int w = GlobalData.check(id, password);
            if(w == 2)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Close();
            }
            else if(w == 3 || w == 1)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("账号或密码错误，请校对后重新输入！点击右下角可以查看帮助。", "提示");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", @"README.txt");
        }
    }
}
