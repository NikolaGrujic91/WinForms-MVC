using System;

namespace WindowsFormsMVC.Views
{
    public interface IView
    {
        event EventHandler IncrementChanged;

        void SetIncrementLabel(string value);
    }
}
