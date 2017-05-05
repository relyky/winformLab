using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformLab
{
    public partial class FormDataRepeater : Form
    {
        public FormDataRepeater()
        {
            InitializeComponent();
        }

        private void FormDataRepeater_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'myTestDataSet.FooTable' 資料表。您可以視需要進行移動或移除。
            this.fooTableTableAdapter.Fill(this.myTestDataSet.FooTable);

        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // save to DB
            this.Validate();
            this.fooTableBindingSource.EndEdit();
            this.fooTableTableAdapter.Update(myTestDataSet.FooTable);
        }

        private void dataRepeater1_DrawItem(object sender, Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs e)
        {
            //# alternative row color
            if (e.DataRepeaterItem.ItemIndex % 2 == 0)
                e.DataRepeaterItem.BackColor = Color.White;
            else
                e.DataRepeaterItem.BackColor = Color.Cyan;
        }

        private void fooTableBindingSource_PositionChanged(object sender, EventArgs e)
        {
            // access item here
            var dataRow = (MyTestDataSet.FooTableRow)((DataRowView)fooTableBindingSource.Current).Row;
            Debug.WriteLine("IdName:{0}, Value:{1}", dataRow.IdName, dataRow.Value);
        }
    }
}
