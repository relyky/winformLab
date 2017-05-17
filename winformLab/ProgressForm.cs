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
    public partial class ProgressForm : Form
    {


        public ProgressForm()
        {
            InitializeComponent();
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {

        }

        #region Biz

        private static ProgressForm _singleton = null;

        public static void DoInitialize(int maximum, int minimum, int step, Form owner)
        {
            if (_singleton == null)
            {
                _singleton = new ProgressForm();
            }

            _singleton.Owner = owner;
            //_singleton.Text = caption;

            // 置中
            Point owner_pos = owner.PointToScreen(owner.Location);
            _singleton.Left = owner_pos.X + (owner.Width - _singleton.Width) / 2;
            _singleton.Top = owner_pos.Y + (owner.Height - _singleton.Height) / 2;

            //
            var ind = _singleton.Indicator;
            ind.Minimum = minimum;
            ind.Maximum = maximum;
            ind.Step = step;
            ind.Value = minimum;
        }

        public static void DoShowProgress(int value)
        {
            Debug.Assert(_singleton != null);            
            var ind = _singleton.Indicator;
            ind.Value = value;

            // progress percent
            int percent = (ind.Value - ind.Minimum) * 100 / (ind.Maximum - ind.Minimum);
            ind.Text = Convert.ToString(percent);

            if(!_singleton.Visible)
                _singleton.Show();
        }

        public static void DoStep()
        {
            Debug.Assert(_singleton != null);
            var ind = _singleton.Indicator;
            ind.PerformStep();

            // progress percent
            int percent = (ind.Value - ind.Minimum) * 100 / (ind.Maximum - ind.Minimum);
            ind.Text = Convert.ToString(percent);

            if (!_singleton.Visible)
                _singleton.Show();
        }

        public static void DoClose()
        {
            Debug.Assert(_singleton != null);
            _singleton.Hide();
        }

        #endregion


    }
}
