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
    public partial class FormCircularProgressBar2 : Form
    {
        public FormCircularProgressBar2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // save
            Task task = BatchDataProcessAsync();
            Debug.WriteLine(DateTime.Now);
            button1.Enabled = false;

            await task;
            Debug.WriteLine(DateTime.Now);
            button1.Enabled = true;
        }

        /// <summary>
        /// longterm 計算
        /// </summary>
        private async Task BatchDataProcessAsync() // async method 非同步函式
        {
            circularProgressBar1.AnimationSpeed = 0; // 等稍會兒，讓重設動畫跑完。
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 20;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Text = "0";
            // 置中
            circularProgressBar1.Left = this.Left + (this.Width - circularProgressBar1.Width) / 2;
            circularProgressBar1.Top = this.Top + (this.Height - circularProgressBar1.Height) / 2;
            // reado to show
            circularProgressBar1.Visible = true;
            this.UpdateZOrder();
            await Task.Delay(100); // 等稍會兒，讓重設動畫跑完。
            circularProgressBar1.AnimationSpeed = 500;

            for (int i = 1; i <= 20; i++)
            {
                // do stuff
                await Task.Delay(200); // 等稍會兒

                // update progress
                circularProgressBar1.Value = i;
                circularProgressBar1.Text = i.ToString();
            }

            // done
            await Task.Delay(circularProgressBar1.AnimationSpeed); // 等稍會兒，讓動畫跑完。
            circularProgressBar1.Visible = false;
        }

    }
}
