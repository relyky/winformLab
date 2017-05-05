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
    public partial class FormDataGridViewExt : Form
    {
        public FormDataGridViewExt()
        {
            InitializeComponent();

            MySubFormColumn.SubformShowing += MySubFormColumn_SubformShowing;
            MySubFormColumn.SubformClosing += MySubFormColumn_SubformClosing;
            MySubFormColumn.Subform = typeof(MyDGVESubForm);
        }

        void MySubFormColumn_SubformClosing(Extensions.DataGridViewSubformCell sender, Extensions.SubformClosingEventArgs e)
        {
            Debug.WriteLine("ON : MySubFormColumn_SubformClosing");
        }

        void MySubFormColumn_SubformShowing(Extensions.DataGridViewSubformCell sender, Extensions.SubformShowingEventArgs e)
        {
            Debug.WriteLine("ON : MySubFormColumn_SubformShowing");
        }

        private void FormDataGridViewExt_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'myTestDataSet.FooTable' 資料表。您可以視需要進行移動或移除。
            this.fooTableTableAdapter.Fill(this.myTestDataSet.FooTable);

            //this.WindowState = FormWindowState.Normal;
        }

        private void FormDataGridViewExt_SizeChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("ON : FormDataGridViewExt_SizeChanged");
        }

        protected override void OnResize(EventArgs e)
        {
            Debug.WriteLine("ON : OnResize");
            base.OnResize(e);
        }

        private void dataGridViewExtension1_Resize(object sender, EventArgs e)
        {
            Debug.WriteLine("ON : dataGridViewExtension1_Resize");
        }
    }
}
