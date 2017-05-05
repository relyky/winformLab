using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformLab
{
    public partial class MyDGVESubForm : Extensions.DataGridViewSubForm // UserControl
    {
        public MyDGVESubForm(object DataBoundItem, Extensions.DataGridViewSubformCell Cell)
            : base(DataBoundItem, Cell)
        {
            InitializeComponent();
        }

        private void MyDGVESubForm_Load(object sender, EventArgs e)
        {
            DataRowView cdrv = this.DataBoundItem as DataRowView;
            if (cdrv == null) return;
            label1.Text = string.Format("IdName:{0}", cdrv["IdName"]);
            label2.Text = string.Format(" Value:{0}", cdrv["Value"]);
        }
    }

}
