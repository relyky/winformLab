namespace winformLab
{
    partial class FormDataGridViewExt
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
            this.dataGridViewExtension1 = new Extensions.DataGridViewExtension();
            this.myTestDataSet = new winformLab.MyTestDataSet();
            this.fooTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fooTableTableAdapter = new winformLab.MyTestDataSetTableAdapters.FooTableTableAdapter();
            this.MySubFormColumn = new Extensions.DataGridViewSubformColumn();
            this.idNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExtension1
            // 
            this.dataGridViewExtension1.AlternateRowColor = System.Drawing.Color.LightGray;
            this.dataGridViewExtension1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewExtension1.AutoGenerateColumns = false;
            this.dataGridViewExtension1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExtension1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExtension1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MySubFormColumn,
            this.idNameDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewExtension1.DataSource = this.fooTableBindingSource;
            this.dataGridViewExtension1.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewExtension1.Name = "dataGridViewExtension1";
            this.dataGridViewExtension1.RowTemplate.Height = 24;
            this.dataGridViewExtension1.Size = new System.Drawing.Size(572, 384);
            this.dataGridViewExtension1.SubformsScrollHorizontally = true;
            this.dataGridViewExtension1.TabIndex = 0;
            this.dataGridViewExtension1.Resize += new System.EventHandler(this.dataGridViewExtension1_Resize);
            // 
            // myTestDataSet
            // 
            this.myTestDataSet.DataSetName = "MyTestDataSet";
            this.myTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fooTableBindingSource
            // 
            this.fooTableBindingSource.DataMember = "FooTable";
            this.fooTableBindingSource.DataSource = this.myTestDataSet;
            // 
            // fooTableTableAdapter
            // 
            this.fooTableTableAdapter.ClearBeforeFill = true;
            // 
            // MySubFormColumn
            // 
            this.MySubFormColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MySubFormColumn.HeaderText = "MySubForm";
            this.MySubFormColumn.Name = "MySubFormColumn";
            this.MySubFormColumn.Subform = null;
            this.MySubFormColumn.Width = 30;
            // 
            // idNameDataGridViewTextBoxColumn
            // 
            this.idNameDataGridViewTextBoxColumn.DataPropertyName = "IdName";
            this.idNameDataGridViewTextBoxColumn.HeaderText = "IdName";
            this.idNameDataGridViewTextBoxColumn.Name = "idNameDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // FormDataGridViewExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 408);
            this.Controls.Add(this.dataGridViewExtension1);
            this.Name = "FormDataGridViewExt";
            this.Text = "FormDataGridViewExt";
            this.Load += new System.EventHandler(this.FormDataGridViewExt_Load);
            this.SizeChanged += new System.EventHandler(this.FormDataGridViewExt_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Extensions.DataGridViewExtension dataGridViewExtension1;
        private MyTestDataSet myTestDataSet;
        private System.Windows.Forms.BindingSource fooTableBindingSource;
        private MyTestDataSetTableAdapters.FooTableTableAdapter fooTableTableAdapter;
        private Extensions.DataGridViewSubformColumn MySubFormColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;

    }
}