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
    public partial class W1 : UserControl
    {
        public W1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            try
            {
                std.change(textBox4.Text, textBox3.Text, textBox1.Text, int.Parse(textBox2.Text), "未评价", "std", 0, 0, 0, 0, 0, 0, 0, 0);

                if (GlobalData.students.add(std))
                {
                    MessageBox.Show("添加成功！", "提示");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("输入错误！", "提示");
            }
        }
    }
}
