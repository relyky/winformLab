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
    public partial class FormListViewGroup : Form
    {
        public FormListViewGroup()
        {
            InitializeComponent();
        }

        private void FormListViewGroup_Load(object sender, EventArgs e)
        {
            cboViewType.SelectedIndex = 0;

            FillData();
        }

        private void FillData()
        {
            // out two listview groups
            ListViewGroup mannedSpacecrafts = new ListViewGroup("Manned Spacecrafts", HorizontalAlignment.Left);
            ListViewGroup unmannedSpacecrafts = new ListViewGroup("UnManned Spacecrafts", HorizontalAlignment.Left);

            // add manned group itmes            
            listView1.Items.Add(new ListViewItem("Appllo 15", mannedSpacecrafts));
            listView1.Items.Add(new ListViewItem("Appllo 17", mannedSpacecrafts));
            listView1.Items.Add(new ListViewItem("Columbia", mannedSpacecrafts));
            listView1.Items.Add(new ListViewItem("Challenger", mannedSpacecrafts));
            listView1.Items.Add(new ListViewItem("Enterprise", mannedSpacecrafts)); 
            listView1.Items.Add(new ListViewItem("Atlantis", mannedSpacecrafts));

            // add unmanned group items
            listView1.Items.Add(new ListViewItem("Pioneer", unmannedSpacecrafts));
            listView1.Items.Add(new ListViewItem("Voyager", unmannedSpacecrafts));
            listView1.Items.Add(new ListViewItem("Hubble", unmannedSpacecrafts));
            listView1.Items.Add(new ListViewItem("Juno", unmannedSpacecrafts));
            listView1.Items.Add(new ListViewItem("Spitzer", unmannedSpacecrafts));
            listView1.Items.Add(new ListViewItem("WMAP", unmannedSpacecrafts));
            listView1.Items.Add(new ListViewItem("Kepler", unmannedSpacecrafts));
            listView1.Items.Add(new ListViewItem("Rosetter", unmannedSpacecrafts));

            // add groups
            listView1.Groups.Add(mannedSpacecrafts);
            listView1.Groups.Add(unmannedSpacecrafts);

            // ------
            ListViewItem newItem = new ListViewItem("AAAA");
            newItem.SubItems.Add("aaaa");
            newItem.SubItems.Add("bbbb");
            newItem.SubItems.Add("cccc");
            listView1.Items.Add(newItem);
            newItem.BackColor = Color.Red;

            // ------
            ListViewItem newItm2 = new ListViewItem("BBBB");
            newItm2.SubItems.Add("aaaa");
            newItm2.SubItems.Add("bbbb");
            newItm2.SubItems.Add("cccc");
            listView1.Items.Add(newItm2);
            newItm2.SubItems[1].BackColor = Color.Blue;
            newItm2.SubItems[1].ForeColor = Color.Blue;        

        }

        private void cboViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cboViewType.Text)
            {
                case "Tile":
                    listView1.View = View.Tile;
                    break;
                case "List":
                    listView1.View = View.List;
                    break;
                case "Details":
                    listView1.View = View.Details;
                    break;
                case "SmallIcon":
                    listView1.View = View.SmallIcon;
                    break;
                case "LargeIcon":
                    listView1.View = View.LargeIcon;
                    break;
            }
        }

        private void chkCheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                listView1.CheckBoxes = chkCheckBoxes.Checked;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
        }
    }
}
