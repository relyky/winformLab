namespace winformLab
{
    partial class FormADGV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.colSAO_ORDR_TYP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSAO_DLVR_RCVR_OF_SEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSAO_STCK_STLMNT_DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSAO_TXN_REF_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSAO_SA_ORDR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSAO_SA_ORDR_STA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSAO_SCA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSAO_SEC_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSAO_QTY_OF_SEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSAO_SNDR_RCVR_INFO_IND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSAOSAORDRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSSODataSet = new winformLab.SSODataSet();
            this.mSAO_SA_ORDRTableAdapter = new winformLab.SSODataSetTableAdapters.SAO_SA_ORDRTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.searchToolBar1 = new ADGV.SearchToolBar();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSAOSAORDRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSSODataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToAddRows = false;
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSAO_ORDR_TYP,
            this.colSAO_DLVR_RCVR_OF_SEC,
            this.colSAO_STCK_STLMNT_DT,
            this.colSAO_TXN_REF_NUM,
            this.colSAO_SA_ORDR_ID,
            this.colSAO_SA_ORDR_STA,
            this.colSAO_SCA_ID,
            this.colSAO_SEC_ID,
            this.colSAO_QTY_OF_SEC,
            this.colSAO_SNDR_RCVR_INFO_IND});
            this.advancedDataGridView1.DataSource = this.mSAOSAORDRBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView1.Location = new System.Drawing.Point(0, 27);
            this.advancedDataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(734, 394);
            this.advancedDataGridView1.TabIndex = 1;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            // 
            // colSAO_ORDR_TYP
            // 
            this.colSAO_ORDR_TYP.DataPropertyName = "SAO_ORDR_TYP";
            this.colSAO_ORDR_TYP.HeaderText = "SAO_ORDR_TYP";
            this.colSAO_ORDR_TYP.MinimumWidth = 22;
            this.colSAO_ORDR_TYP.Name = "colSAO_ORDR_TYP";
            this.colSAO_ORDR_TYP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colSAO_DLVR_RCVR_OF_SEC
            // 
            this.colSAO_DLVR_RCVR_OF_SEC.DataPropertyName = "SAO_DLVR_RCVR_OF_SEC";
            this.colSAO_DLVR_RCVR_OF_SEC.HeaderText = "SAO_DLVR_RCVR_OF_SEC";
            this.colSAO_DLVR_RCVR_OF_SEC.MinimumWidth = 22;
            this.colSAO_DLVR_RCVR_OF_SEC.Name = "colSAO_DLVR_RCVR_OF_SEC";
            this.colSAO_DLVR_RCVR_OF_SEC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colSAO_STCK_STLMNT_DT
            // 
            this.colSAO_STCK_STLMNT_DT.DataPropertyName = "SAO_STCK_STLMNT_DT";
            this.colSAO_STCK_STLMNT_DT.HeaderText = "SAO_STCK_STLMNT_DT";
            this.colSAO_STCK_STLMNT_DT.MinimumWidth = 22;
            this.colSAO_STCK_STLMNT_DT.Name = "colSAO_STCK_STLMNT_DT";
            this.colSAO_STCK_STLMNT_DT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colSAO_TXN_REF_NUM
            // 
            this.colSAO_TXN_REF_NUM.DataPropertyName = "SAO_TXN_REF_NUM";
            this.colSAO_TXN_REF_NUM.HeaderText = "SAO_TXN_REF_NUM";
            this.colSAO_TXN_REF_NUM.MinimumWidth = 22;
            this.colSAO_TXN_REF_NUM.Name = "colSAO_TXN_REF_NUM";
            this.colSAO_TXN_REF_NUM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colSAO_SA_ORDR_ID
            // 
            this.colSAO_SA_ORDR_ID.DataPropertyName = "SAO_SA_ORDR_ID";
            this.colSAO_SA_ORDR_ID.HeaderText = "SAO_SA_ORDR_ID";
            this.colSAO_SA_ORDR_ID.MinimumWidth = 22;
            this.colSAO_SA_ORDR_ID.Name = "colSAO_SA_ORDR_ID";
            this.colSAO_SA_ORDR_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colSAO_SA_ORDR_STA
            // 
            this.colSAO_SA_ORDR_STA.DataPropertyName = "SAO_SA_ORDR_STA";
            this.colSAO_SA_ORDR_STA.HeaderText = "SAO_SA_ORDR_STA";
            this.colSAO_SA_ORDR_STA.MinimumWidth = 22;
            this.colSAO_SA_ORDR_STA.Name = "colSAO_SA_ORDR_STA";
            this.colSAO_SA_ORDR_STA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colSAO_SCA_ID
            // 
            this.colSAO_SCA_ID.DataPropertyName = "SAO_SCA_ID";
            this.colSAO_SCA_ID.HeaderText = "SAO_SCA_ID";
            this.colSAO_SCA_ID.MinimumWidth = 22;
            this.colSAO_SCA_ID.Name = "colSAO_SCA_ID";
            this.colSAO_SCA_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colSAO_SEC_ID
            // 
            this.colSAO_SEC_ID.DataPropertyName = "SAO_SEC_ID";
            this.colSAO_SEC_ID.HeaderText = "SAO_SEC_ID";
            this.colSAO_SEC_ID.MinimumWidth = 22;
            this.colSAO_SEC_ID.Name = "colSAO_SEC_ID";
            this.colSAO_SEC_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colSAO_QTY_OF_SEC
            // 
            this.colSAO_QTY_OF_SEC.DataPropertyName = "SAO_QTY_OF_SEC";
            this.colSAO_QTY_OF_SEC.HeaderText = "SAO_QTY_OF_SEC";
            this.colSAO_QTY_OF_SEC.MinimumWidth = 22;
            this.colSAO_QTY_OF_SEC.Name = "colSAO_QTY_OF_SEC";
            this.colSAO_QTY_OF_SEC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colSAO_SNDR_RCVR_INFO_IND
            // 
            this.colSAO_SNDR_RCVR_INFO_IND.DataPropertyName = "SAO_SNDR_RCVR_INFO_IND";
            this.colSAO_SNDR_RCVR_INFO_IND.HeaderText = "SAO_SNDR_RCVR_INFO_IND";
            this.colSAO_SNDR_RCVR_INFO_IND.MinimumWidth = 22;
            this.colSAO_SNDR_RCVR_INFO_IND.Name = "colSAO_SNDR_RCVR_INFO_IND";
            this.colSAO_SNDR_RCVR_INFO_IND.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // mSAOSAORDRBindingSource
            // 
            this.mSAOSAORDRBindingSource.DataMember = "SAO_SA_ORDR";
            this.mSAOSAORDRBindingSource.DataSource = this.mSSODataSet;
            this.mSAOSAORDRBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.mSAOSAORDRBindingSource_ListChanged);
            // 
            // mSSODataSet
            // 
            this.mSSODataSet.DataSetName = "SSODataSet";
            this.mSSODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mSAO_SA_ORDRTableAdapter
            // 
            this.mSAO_SA_ORDRTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(734, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTotal
            // 
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 20);
            this.lblTotal.Text = "Total: ";
            // 
            // searchToolBar1
            // 
            this.searchToolBar1.AllowMerge = false;
            this.searchToolBar1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchToolBar1.Location = new System.Drawing.Point(0, 0);
            this.searchToolBar1.MaximumSize = new System.Drawing.Size(0, 27);
            this.searchToolBar1.MinimumSize = new System.Drawing.Size(0, 27);
            this.searchToolBar1.Name = "searchToolBar1";
            this.searchToolBar1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.searchToolBar1.Size = new System.Drawing.Size(734, 27);
            this.searchToolBar1.TabIndex = 3;
            this.searchToolBar1.Text = "searchToolBar1";
            this.searchToolBar1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.searchToolBar1_ItemClicked);
            // 
            // FormADGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 446);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.searchToolBar1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormADGV";
            this.Text = "FormADGV";
            this.Load += new System.EventHandler(this.FormADGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSAOSAORDRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSSODataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private SSODataSet mSSODataSet;
        private System.Windows.Forms.BindingSource mSAOSAORDRBindingSource;
        private SSODataSetTableAdapters.SAO_SA_ORDRTableAdapter mSAO_SA_ORDRTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotal;
        private ADGV.SearchToolBar searchToolBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSAO_ORDR_TYP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSAO_DLVR_RCVR_OF_SEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSAO_STCK_STLMNT_DT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSAO_TXN_REF_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSAO_SA_ORDR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSAO_SA_ORDR_STA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSAO_SCA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSAO_SEC_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSAO_QTY_OF_SEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSAO_SNDR_RCVR_INFO_IND;
    }
}