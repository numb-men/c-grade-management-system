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
    public partial class W3 : UserControl
    {
        public W3()
        {
            InitializeComponent();
            GlobalData.students.reset_rank();
            foreach (KeyValuePair<string, Student> s in GlobalData.students.all())
            {
                ListViewItem lvi = new ListViewItem();
                foreach(string ss in s.Value.allAsArr())
                {
                    lvi.SubItems.Add(ss);
                }
                this.listView1.Items.Add(lvi);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
