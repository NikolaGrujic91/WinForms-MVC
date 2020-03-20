using System;
using WindowsFormsMVC.Model;
using WindowsFormsMVC.Views;

namespace WindowsFormsMVC.Controller
{
    public class Controller
    {
        #region Fields

        private readonly IView view;
        private Number number;

        #endregion

        #region Constructors

        public Controller(IView view)
        {
            this.view = view;
            this.number = new Number();

            this.view.IncrementChanged += View_IncrementChanged;
        }

        #endregion

        #region Events

        private void View_IncrementChanged(object sender, EventArgs e)
        {
            this.number.Increment();
            this.view.SetIncrementLabel(number.ToString());
        }

        #endregion
    }
}
