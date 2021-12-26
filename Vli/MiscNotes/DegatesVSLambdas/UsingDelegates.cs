using System;

namespace ConsoleApplication1
{
    public class UsingDelegates
    {
        delegate void Operator(int number);

         public static void DeployDouble(int number)
        {
            Operator op = DoubleNum;
            op(number);
        }

        static void DoubleNum(int num)
        {
            Console.WriteLine($"{num} * 2 = {num*2}");
        }

    }
}