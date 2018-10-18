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
    public partial class W8 : UserControl
    {
        public W8()
        {
            InitializeComponent();
            GlobalData.students.reset_rank();
            ListViewItem lvi = new ListViewItem();
            foreach (string ss in GlobalData.s.allScoreAsArr())
            {
                lvi.SubItems.Add(ss);
            }
            this.listView1.Items.Add(lvi);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
