namespace winformLab
{
    partial class FormDataGridViewGrouper
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mSSODataSet = new winformLab.SSODataSet();
            this.mSAOSAORDRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSAO_SA_ORDRTableAdapter = new winformLab.SSODataSetTableAdapters.SAO_SA_ORDRTableAdapter();
            this.sAOORDRTYPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAODLVRRCVROFSECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAOSTCKSTLMNTDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAOTXNREFNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAOSAORDRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAOSAORDRSTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAOSCAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAOSECIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAOQTYOFSECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAOSNDRRCVRINFOINDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSSODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSAOSAORDRBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sAOORDRTYPDataGridViewTextBoxColumn,
            this.sAODLVRRCVROFSECDataGridViewTextBoxColumn,
            this.sAOSTCKSTLMNTDTDataGridViewTextBoxColumn,
            this.sAOTXNREFNUMDataGridViewTextBoxColumn,
            this.sAOSAORDRIDDataGridViewTextBoxColumn,
            this.sAOSAORDRSTADataGridViewTextBoxColumn,
            this.sAOSCAIDDataGridViewTextBoxColumn,
            this.sAOSECIDDataGridViewTextBoxColumn,
            this.sAOQTYOFSECDataGridViewTextBoxColumn,
            this.sAOSNDRRCVRINFOINDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mSAOSAORDRBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // mSSODataSet
            // 
            this.mSSODataSet.DataSetName = "SSODataSet";
            this.mSSODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mSAOSAORDRBindingSource
            // 
            this.mSAOSAORDRBindingSource.DataMember = "SAO_SA_ORDR";
            this.mSAOSAORDRBindingSource.DataSource = this.mSSODataSet;
            // 
            // mSAO_SA_ORDRTableAdapter
            // 
            this.mSAO_SA_ORDRTableAdapter.ClearBeforeFill = true;
            // 
            // sAOORDRTYPDataGridViewTextBoxColumn
            // 
            this.sAOORDRTYPDataGridViewTextBoxColumn.DataPropertyName = "SAO_ORDR_TYP";
            this.sAOORDRTYPDataGridViewTextBoxColumn.HeaderText = "SAO_ORDR_TYP";
            this.sAOORDRTYPDataGridViewTextBoxColumn.Name = "sAOORDRTYPDataGridViewTextBoxColumn";
            // 
            // sAODLVRRCVROFSECDataGridViewTextBoxColumn
            // 
            this.sAODLVRRCVROFSECDataGridViewTextBoxColumn.DataPropertyName = "SAO_DLVR_RCVR_OF_SEC";
            this.sAODLVRRCVROFSECDataGridViewTextBoxColumn.HeaderText = "SAO_DLVR_RCVR_OF_SEC";
            this.sAODLVRRCVROFSECDataGridViewTextBoxColumn.Name = "sAODLVRRCVROFSECDataGridViewTextBoxColumn";
            // 
            // sAOSTCKSTLMNTDTDataGridViewTextBoxColumn
            // 
            this.sAOSTCKSTLMNTDTDataGridViewTextBoxColumn.DataPropertyName = "SAO_STCK_STLMNT_DT";
            this.sAOSTCKSTLMNTDTDataGridViewTextBoxColumn.HeaderText = "SAO_STCK_STLMNT_DT";
            this.sAOSTCKSTLMNTDTDataGridViewTextBoxColumn.Name = "sAOSTCKSTLMNTDTDataGridViewTextBoxColumn";
            // 
            // sAOTXNREFNUMDataGridViewTextBoxColumn
            // 
            this.sAOTXNREFNUMDataGridViewTextBoxColumn.DataPropertyName = "SAO_TXN_REF_NUM";
            this.sAOTXNREFNUMDataGridViewTextBoxColumn.HeaderText = "SAO_TXN_REF_NUM";
            this.sAOTXNREFNUMDataGridViewTextBoxColumn.Name = "sAOTXNREFNUMDataGridViewTextBoxColumn";
            // 
            // sAOSAORDRIDDataGridViewTextBoxColumn
            // 
            this.sAOSAORDRIDDataGridViewTextBoxColumn.DataPropertyName = "SAO_SA_ORDR_ID";
            this.sAOSAORDRIDDataGridViewTextBoxColumn.HeaderText = "SAO_SA_ORDR_ID";
            this.sAOSAORDRIDDataGridViewTextBoxColumn.Name = "sAOSAORDRIDDataGridViewTextBoxColumn";
            // 
            // sAOSAORDRSTADataGridViewTextBoxColumn
            // 
            this.sAOSAORDRSTADataGridViewTextBoxColumn.DataPropertyName = "SAO_SA_ORDR_STA";
            this.sAOSAORDRSTADataGridViewTextBoxColumn.HeaderText = "SAO_SA_ORDR_STA";
            this.sAOSAORDRSTADataGridViewTextBoxColumn.Name = "sAOSAORDRSTADataGridViewTextBoxColumn";
            // 
            // sAOSCAIDDataGridViewTextBoxColumn
            // 
            this.sAOSCAIDDataGridViewTextBoxColumn.DataPropertyName = "SAO_SCA_ID";
            this.sAOSCAIDDataGridViewTextBoxColumn.HeaderText = "SAO_SCA_ID";
            this.sAOSCAIDDataGridViewTextBoxColumn.Name = "sAOSCAIDDataGridViewTextBoxColumn";
            // 
            // sAOSECIDDataGridViewTextBoxColumn
            // 
            this.sAOSECIDDataGridViewTextBoxColumn.DataPropertyName = "SAO_SEC_ID";
            this.sAOSECIDDataGridViewTextBoxColumn.HeaderText = "SAO_SEC_ID";
            this.sAOSECIDDataGridViewTextBoxColumn.Name = "sAOSECIDDataGridViewTextBoxColumn";
            // 
            // sAOQTYOFSECDataGridViewTextBoxColumn
            // 
            this.sAOQTYOFSECDataGridViewTextBoxColumn.DataPropertyName = "SAO_QTY_OF_SEC";
            this.sAOQTYOFSECDataGridViewTextBoxColumn.HeaderText = "SAO_QTY_OF_SEC";
            this.sAOQTYOFSECDataGridViewTextBoxColumn.Name = "sAOQTYOFSECDataGridViewTextBoxColumn";
            // 
            // sAOSNDRRCVRINFOINDDataGridViewTextBoxColumn
            // 
            this.sAOSNDRRCVRINFOINDDataGridViewTextBoxColumn.DataPropertyName = "SAO_SNDR_RCVR_INFO_IND";
            this.sAOSNDRRCVRINFOINDDataGridViewTextBoxColumn.HeaderText = "SAO_SNDR_RCVR_INFO_IND";
            this.sAOSNDRRCVRINFOINDDataGridViewTextBoxColumn.Name = "sAOSNDRRCVRINFOINDDataGridViewTextBoxColumn";
            // 
            // FormDataGridViewGrouper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 312);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDataGridViewGrouper";
            this.Text = "FormDataGridViewGrouper";
            this.Load += new System.EventHandler(this.FormDataGridViewGrouper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSSODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSAOSAORDRBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SSODataSet mSSODataSet;
        private System.Windows.Forms.BindingSource mSAOSAORDRBindingSource;
        private SSODataSetTableAdapters.SAO_SA_ORDRTableAdapter mSAO_SA_ORDRTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAOORDRTYPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAODLVRRCVROFSECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAOSTCKSTLMNTDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAOTXNREFNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAOSAORDRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAOSAORDRSTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAOSCAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAOSECIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAOQTYOFSECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAOSNDRRCVRINFOINDDataGridViewTextBoxColumn;
    }
}