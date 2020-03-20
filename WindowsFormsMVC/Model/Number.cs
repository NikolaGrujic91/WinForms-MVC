namespace WindowsFormsMVC.Model
{
    internal class Number
    {
        #region Fields

        private int number;

        #endregion

        #region Constructors

        public Number()
        {
            this.number = 0;
        }

        #endregion

        #region Methods

        public void Increment()
        {
            this.number++;
        }

        public override string ToString()
        {
            return this.number.ToString();
        }

        #endregion
    }
}
