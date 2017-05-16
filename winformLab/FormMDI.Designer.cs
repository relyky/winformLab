namespace winformLab
{
    partial class FormMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuLstViewGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuADGV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDGVGrouper = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDGVExt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataRepeater = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCircularProg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLstViewGroup,
            this.menuADGV,
            this.menuDGVGrouper,
            this.menuDGVExt,
            this.menuDataRepeater,
            this.menuCircularProg});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuLstViewGroup
            // 
            this.menuLstViewGroup.Name = "menuLstViewGroup";
            this.menuLstViewGroup.Size = new System.Drawing.Size(100, 20);
            this.menuLstViewGroup.Text = "ListViewGroup";
            this.menuLstViewGroup.Click += new System.EventHandler(this.menuLstViewGroup_Click);
            // 
            // menuADGV
            // 
            this.menuADGV.Name = "menuADGV";
            this.menuADGV.Size = new System.Drawing.Size(53, 20);
            this.menuADGV.Text = "ADGV";
            this.menuADGV.Click += new System.EventHandler(this.menuADGV_Click);
            // 
            // menuDGVGrouper
            // 
            this.menuDGVGrouper.Name = "menuDGVGrouper";
            this.menuDGVGrouper.Size = new System.Drawing.Size(92, 20);
            this.menuDGVGrouper.Text = "DGVGrouper";
            this.menuDGVGrouper.Click += new System.EventHandler(this.menuDGVGrouper_Click);
            // 
            // menuDGVExt
            // 
            this.menuDGVExt.Name = "menuDGVExt";
            this.menuDGVExt.Size = new System.Drawing.Size(65, 20);
            this.menuDGVExt.Text = "DGVExt.";
            this.menuDGVExt.Click += new System.EventHandler(this.menuDGVExt_Click);
            // 
            // menuDataRepeater
            // 
            this.menuDataRepeater.Name = "menuDataRepeater";
            this.menuDataRepeater.Size = new System.Drawing.Size(98, 20);
            this.menuDataRepeater.Text = "DataRepeater";
            this.menuDataRepeater.Click += new System.EventHandler(this.menuDataRepeater_Click);
            // 
            // menuCircularProg
            // 
            this.menuCircularProg.Name = "menuCircularProg";
            this.menuCircularProg.Size = new System.Drawing.Size(94, 20);
            this.menuCircularProg.Text = "Circular Prog.";
            this.menuCircularProg.Click += new System.EventHandler(this.menuCircularProg_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 389);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMDI";
            this.Text = "FormMDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuLstViewGroup;
        private System.Windows.Forms.ToolStripMenuItem menuADGV;
        private System.Windows.Forms.ToolStripMenuItem menuDGVGrouper;
        private System.Windows.Forms.ToolStripMenuItem menuDGVExt;
        private System.Windows.Forms.ToolStripMenuItem menuDataRepeater;
        private System.Windows.Forms.ToolStripMenuItem menuCircularProg;
    }
}