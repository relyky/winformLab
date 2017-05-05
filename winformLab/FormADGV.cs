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
    public partial class FormADGV : Form
    {
        public FormADGV()
        {
            InitializeComponent();
        }

        private void FormADGV_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'sSODataSet.SAO_SA_ORDR' 資料表。您可以視需要進行移動或移除。
            this.mSAO_SA_ORDRTableAdapter.Fill(this.mSSODataSet.SAO_SA_ORDR);

            //
            ToolStripComboBox columnComboBox = (ToolStripComboBox)searchToolBar1.Items["columnComboBox"];
            foreach(DataGridViewColumn col in advancedDataGridView1.Columns)
            {
                //columnComboBox.Items.Add(col.HeaderText);
                columnComboBox.Items.Add(col.Name);
            }
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.mSAOSAORDRBindingSource.Sort = this.advancedDataGridView1.SortString;
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.mSAOSAORDRBindingSource.Filter = this.advancedDataGridView1.FilterString;
        }

        private void mSAOSAORDRBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTotal.Text = String.Format("Total rows: {0}", this.mSAOSAORDRBindingSource.List.Count);
        }

        private void searchToolBar1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Debug.WriteLine("ON : searchToolBar1_ItemClicked");


            if (e.ClickedItem.Name == "searchButton")
            {
                // To prepare search arguments
                string valueToFind = searchToolBar1.Items["searchTextBox"].Text;

                string searchColumnName = null;
                ToolStripComboBox columnComboBox = (ToolStripComboBox)searchToolBar1.Items["columnComboBox"];
                if(columnComboBox.Text != "(All columns)")
                {
                    searchColumnName = columnComboBox.Text;
                }

                bool isFromBegin = ((ToolStripButton)searchToolBar1.Items["fromBeginButton"]).Checked;
                bool isWholeWordSearch = ((ToolStripButton)searchToolBar1.Items["wholeWordButton"]).Checked;
                bool isCaseSensitive = ((ToolStripButton)searchToolBar1.Items["caseSensButton"]).Checked;

                int searchRowIndex = 0;
                int searchColumnIndex = 0;
                if (advancedDataGridView1.CurrentCell != null && !isFromBegin)
                {
                    searchRowIndex = advancedDataGridView1.CurrentCell.RowIndex;
                    searchColumnIndex = advancedDataGridView1.CurrentCell.ColumnIndex + 1;
                }

                // to find cell
                var foundCell = advancedDataGridView1.FindCell(valueToFind, searchColumnName, searchRowIndex, searchColumnIndex, isWholeWordSearch, isCaseSensitive);
                if (foundCell != null)
                    advancedDataGridView1.CurrentCell = foundCell; // focus the found cell.
                else
                    MessageBox.Show("Not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
