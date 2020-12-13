using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_DOTNET
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void mALOAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
                frm.Close();
            loai fr = new loai();
            fr.MdiParent = this;
            fr.Show();
        }

        private void tENLOAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
                frm.Close();
            toipham fr = new toipham();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
