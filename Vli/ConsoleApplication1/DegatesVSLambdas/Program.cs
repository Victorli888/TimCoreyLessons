using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        delegate void Operation(int num);
        
        static void Main(string[] args)
        {
            // UsingLambdas.DeployDouble(5);
            // UsingDelegates.DeployDouble(6);
            
            // Using Anonymous Method:
            // Operation op = delegate(int num)
            // {
            //     Console.WriteLine($"{num} * 2 = {num * 2}");
            //
            // };
            // op(2);
            
            // Using a Lambda Expression
            // Operation op = num => 
            // {
            //     Console.WriteLine($"hey I'm a Lambda Expression {num} * 2 = {num * 2}");
            // };
            // op(3);
            Action<int> op = num =>
            {
                Console.WriteLine($"hey I'm Lambda Expression using Action<> {num} * 2 = {num * 2}");
            };
            op(10);
            
            Func<int, int> Double = x => {return 2 * x;};
            
            Console.WriteLine($"Lets use Func<> "+ Double(16));


        }
    }
}  


/* Our goal here is to create a Delegate that will handle Doubling a given integer. After we instantiate our delegate
and create a method that our delgate is suppose to be pointed to we should be able to call the operation.

Why use Delegates? Delegates are pointer functions that point to method, A method that that isn't known or called till runtime

*/