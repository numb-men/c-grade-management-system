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
    public partial class Form2 : Form
    {
        public W8 w8;
        public W9 w9;
        public Form2()
        {
            InitializeComponent();
            label1.Text = label1.Text + GlobalData.s.Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 功能ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查看成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w8 = new W8();
            w8.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(w8);
        }

        private void 老师寄语ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w9 = new W9();
            w9.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(w9);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalData.save();
            Application.Exit();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", @"ABOUT.txt");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalData.save();
            Application.Exit();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalData.save();
        }
    }
}
