using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformLab
{
    public partial class FormCircularProgressBar : Form
    {
        public FormCircularProgressBar()
        {
            InitializeComponent();
        }

        private void FormCircularProgressBar_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 10;

            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountTo10Async(); // call the async method
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // reset
            circularProgressBar1.Value = 0;
            progressBar1.Value = 0;
            circularProgressBar1.Text = "0";
        }

        /// <summary>
        /// longterm 計算
        /// </summary>
        private async void CountTo10Async() // async method 非同步函式
        {
            for (int i = 1; i <= 10; i++)
            {
                circularProgressBar1.Value = i;
                progressBar1.Value = i;

                circularProgressBar1.Text = i.ToString();

                circularProgressBar1.Update();
                progressBar1.Update();

                await Task.Delay(200); // 等稍會兒
            }
        }

        //private void CountTo10() // async method 非同步函式
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        circularProgressBar1.Value = i;
        //        progressBar1.Value = i;
        //
        //        circularProgressBar1.Text = i.ToString();
        //
        //        circularProgressBar1.Update();
        //        progressBar1.Update();
        //
        //        Thread.Sleep(200); // 等稍會兒
        //    }
        //}
    }
}
