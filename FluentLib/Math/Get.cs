namespace FluentLib.Math
{
    public class Get
    {
        public FibonacciNumbers FibonacciNumbers
        {
            get
            {
                return new FibonacciNumbers();
            }
        }

        public EvenValues EvenValues
        {
            get { return new EvenValues(); }
        }
    }
}
