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
    public partial class Form3 : Form
    {
        public W1 w1;
        public W2 w2;
        public W3 w3;
        public w4 w4;
        public w5 w5;
        public W6 w6;
        public W7 w7;
        public Form3()
        {
            InitializeComponent();
            string name = "admin";
            if(GlobalData.who == 2)
            {
                name = GlobalData.t.Name;
            }
            label1.Text = label1.Text + name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 学生信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 添加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w1 = new W1();
            w1.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(w1);
        }

        private void 删除学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w2 = new W2();
            w2.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(w2);
        }

        private void 查看所有学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w3 = new W3();
            w3.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(w3);
        }

        private void 评价学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w4 = new w4();
            w4.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(w4);
        }

        private void 学生成绩管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 录入成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w5 = new w5();
            w5.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(w5);
        }

        private void 修改成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w5 = new w5();
            w5.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(w5);
        }

        private void 学生成绩统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 各科平均成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w6 = new W6();
            w6.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(w6);
        }

        private void 成绩统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w7 = new W7();
            w7.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(w7);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalData.save();
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalData.save();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalData.save();
            Application.Exit();
        }
    }
}
