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
    public partial class W2 : UserControl
    {
        public W2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GlobalData.students.del(textBox1.Text))
            {
                MessageBox.Show("删除成功。", "提示");
            }
            else
            {
                MessageBox.Show("该学号不存在！删除失败！", "提示");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void W2_Load(object sender, EventArgs e)
        {

        }

    }
}
