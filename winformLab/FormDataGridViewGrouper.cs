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
    public partial class FormDataGridViewGrouper : Form
    {
        public FormDataGridViewGrouper()
        {
            InitializeComponent();
        }

        private void FormDataGridViewGrouper_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'sSODataSet.SAO_SA_ORDR' 資料表。您可以視需要進行移動或移除。
            this.mSAO_SA_ORDRTableAdapter.Fill(this.mSSODataSet.SAO_SA_ORDR);

            //the component can be added in designer, or as done here on the fly
            var grouper = new Subro.Controls.DataGridViewGrouper(dataGridView1);
            grouper.SetGroupOn("SAO_ORDR_TYP");

            //to customize the grouping display, you can attach to the DisplayGroup event:
            grouper.DisplayGroup += grouper_DisplayGroup;
        }

        void grouper_DisplayGroup(object sender, Subro.Controls.GroupDisplayEventArgs e)
        {
            e.BackColor = (e.Group.GroupIndex % 2) == 0 ? Color.Orange : Color.LightBlue;
            e.Header = "[" + e.Header + "], grp: " + e.Group.GroupIndex;
            e.DisplayValue = "Value is " + e.DisplayValue;
            e.Summary = "contains " + e.Group.Count + " rows";
        }
    }
}
