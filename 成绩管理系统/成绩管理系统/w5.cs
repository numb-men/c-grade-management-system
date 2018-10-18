using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 成绩管理系统
{
    public partial class w5 : UserControl
    {
        private Student s;
        public w5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = GlobalData.students.get(textBox1.Text);
            if (s != null)
            {
                s.setScore(int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text));
                GlobalData.students.change(s);
                MessageBox.Show("成绩保存成功！", "提示");
            }
            else
            {
                MessageBox.Show("该学号不存在！", "提示");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            s = GlobalData.students.get(textBox1.Text);
            if (s != null)
            {
                string []ss = s.getScore();
                textBox2.Text = ss[0];
                textBox3.Text = ss[1];
                textBox4.Text = ss[2];
                textBox5.Text = ss[3];
                textBox6.Text = ss[4];
            }
            else
            {
                MessageBox.Show("该学号不存在！", "提示");
            }
        }

        private void w5_Load(object sender, EventArgs e)
        {

        }
    }
}
