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
    public partial class W9 : UserControl
    {
        private Teacher t = null;
        public W9()
        {
            InitializeComponent();
        }

        private void W9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = GlobalData.teachers.getByName(textBox1.Text);
            if (t != null)
            {
                label2.Text = "检索结果：" + t.Name;
            }
            else
            {
                label2.Text = "检索结果：" + "未找到！";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t == null)
            {
                MessageBox.Show("请先搜索教师！", "提示");
            }
            else
            {
                t.Leaveword = textBox2.Text;
                GlobalData.teachers.change(t);
                MessageBox.Show("留言成功！", "提示");
            }
        }
    }
}
