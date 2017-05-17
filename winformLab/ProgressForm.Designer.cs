namespace winformLab
{
    partial class ProgressForm
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
            this.Indicator = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // Indicator
            // 
            this.Indicator.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Indicator.AnimationSpeed = 500;
            this.Indicator.BackColor = System.Drawing.Color.Transparent;
            this.Indicator.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Bold);
            this.Indicator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Indicator.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Indicator.InnerMargin = 2;
            this.Indicator.InnerWidth = -1;
            this.Indicator.Location = new System.Drawing.Point(12, 12);
            this.Indicator.MarqueeAnimationSpeed = 2000;
            this.Indicator.Name = "Indicator";
            this.Indicator.OuterColor = System.Drawing.Color.Gray;
            this.Indicator.OuterMargin = -25;
            this.Indicator.OuterWidth = 26;
            this.Indicator.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Indicator.ProgressWidth = 25;
            this.Indicator.SecondaryFont = new System.Drawing.Font("新細明體", 36F);
            this.Indicator.Size = new System.Drawing.Size(320, 320);
            this.Indicator.StartAngle = 270;
            this.Indicator.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Indicator.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Indicator.SubscriptText = "";
            this.Indicator.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Indicator.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Indicator.SuperscriptText = "%";
            this.Indicator.TabIndex = 0;
            this.Indicator.Text = "68";
            this.Indicator.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Indicator.Value = 68;
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 344);
            this.Controls.Add(this.Indicator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ProgressForm";
            this.Load += new System.EventHandler(this.ProgressForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar Indicator;

    }
}