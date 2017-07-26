using System;

namespace tostringmethod
{
    class Program
    {
        static void Main(string[] args)
        {
           money cash1 = new money();
           cash1.Amount=40M;
           Console.WriteLine("cash1.ToString() returns:" +cash1.ToString());
           Console.ReadLine();
        }
    }
        public class money
        {
            private decimal amount;
            public decimal Amount
            {
                get
                {
                    return amount;
                }
                set
                {
                    amount = value;
                }
            }
        
        public override string ToString()
            {
                return "$" +Amount.ToString();
            }
        
        }
}
    


