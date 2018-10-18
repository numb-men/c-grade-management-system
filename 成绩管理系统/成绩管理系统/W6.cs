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
    public partial class W6 : UserControl
    {
        public W6()
        {
            InitializeComponent();
        }

        private void W6_Load(object sender, EventArgs e)
        {
            string[] avgs = GlobalData.students.avgs();
            label7.Text = avgs[0];
            label8.Text = avgs[1];
            label9.Text = avgs[2];
            label10.Text = avgs[3];
            label11.Text = avgs[4];
        }
    }
}
