using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformLab
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void menuDGVGrouper_Click(object sender, EventArgs e)
        {
            // create new form
            Form frm = new FormDataGridViewGrouper();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.Activate();
        }

        private void menuADGV_Click(object sender, EventArgs e)
        {
            // create new form
            Form frm = new FormADGV();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.Activate();
        }

        private void menuLstViewGroup_Click(object sender, EventArgs e)
        {
            // create new form
            Form frm = new FormListViewGroup();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.Activate();
        }

        private void menuDGVExt_Click(object sender, EventArgs e)
        {
            // create new form
            Form frm = new FormDataGridViewExt();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.Activate();
        }

        private void menuDataRepeater_Click(object sender, EventArgs e)
        {
            // create new form
            Form frm = new FormDataRepeater();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.Activate();
        }
    }
}
