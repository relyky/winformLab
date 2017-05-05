namespace winformLab
{
    partial class FormListViewGroup
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboViewType = new System.Windows.Forms.ComboBox();
            this.chkCheckBoxes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(12, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(434, 325);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Text";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SubItem1";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SubItem2";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SubItem3";
            // 
            // cboViewType
            // 
            this.cboViewType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboViewType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViewType.FormattingEnabled = true;
            this.cboViewType.Items.AddRange(new object[] {
            "Tile",
            "List",
            "Details",
            "SmallIcon",
            "LargeIcon"});
            this.cboViewType.Location = new System.Drawing.Point(228, 12);
            this.cboViewType.Name = "cboViewType";
            this.cboViewType.Size = new System.Drawing.Size(121, 20);
            this.cboViewType.TabIndex = 1;
            this.cboViewType.SelectedIndexChanged += new System.EventHandler(this.cboViewType_SelectedIndexChanged);
            // 
            // chkCheckBoxes
            // 
            this.chkCheckBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCheckBoxes.AutoSize = true;
            this.chkCheckBoxes.Location = new System.Drawing.Point(355, 14);
            this.chkCheckBoxes.Name = "chkCheckBoxes";
            this.chkCheckBoxes.Size = new System.Drawing.Size(83, 16);
            this.chkCheckBoxes.TabIndex = 2;
            this.chkCheckBoxes.Text = "CheckBoxes";
            this.chkCheckBoxes.UseVisualStyleBackColor = true;
            this.chkCheckBoxes.CheckedChanged += new System.EventHandler(this.chkCheckBoxes_CheckedChanged);
            // 
            // FormListViewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 375);
            this.Controls.Add(this.chkCheckBoxes);
            this.Controls.Add(this.cboViewType);
            this.Controls.Add(this.listView1);
            this.Name = "FormListViewGroup";
            this.Text = "ListView Group Lab";
            this.Load += new System.EventHandler(this.FormListViewGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cboViewType;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckBox chkCheckBoxes;
    }
}

