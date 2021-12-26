using System;

namespace ConsoleApplication1
{
    public class UsingLambdas
    {
        delegate void Operation(int num);

        public static void DeployDouble(int num)
        {
            Operation op = DoubleNum;
            op(num);
        }
        
        //Create method that our Delegate is pointing too
        static void DoubleNum(int num)
        {
            Console.WriteLine($"{num} * 2 = {num*2}");
            
        }

    }
}