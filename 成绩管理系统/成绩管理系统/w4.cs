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
    public partial class w4 : UserControl
    {
        private Student s;
        public w4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = GlobalData.students.get(textBox1.Text);
            if (s != null)
            {
                label2.Text = "检索结果：" + s.Name;
            }
            else
            {
                label2.Text = "检索结果：" + "未找到！";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(s == null)
            {
                MessageBox.Show("请先搜索学生！", "提示");
            }
            else
            {
                s.Appraise = textBox2.Text;
                GlobalData.students.change(s);
                MessageBox.Show("评价成功！", "提示");
            }
        }

        private void w4_Load(object sender, EventArgs e)
        {

        }
    }
}
