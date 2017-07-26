using System;

namespace sumofdigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,sum=0,r;
            Console.WriteLine("Enter the number:");
            num=int.Parse(Console.ReadLine());
            while(num!=0)
            {
                r=num%10;
                num=num/10;
                sum=sum+r;

            }
            Console.WriteLine("The sum of digits " +sum);
            Console.ReadLine();
        }
    }
}
