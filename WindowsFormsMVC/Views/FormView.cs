using System;
using System.Windows.Forms;

namespace WindowsFormsMVC.Views
{
    public partial class Form1 : Form, IView
    {
        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region IView

        public event EventHandler IncrementChanged;

        public void SetIncrementLabel(string value)
        {
            this.labelIncrement.Text = value;
        }

        #endregion

        #region Events

        private void buttonIncrement_Click(object sender, EventArgs e)
        {
            this.IncrementChanged?.Invoke(this, EventArgs.Empty);
        }

        #endregion
    }
}
