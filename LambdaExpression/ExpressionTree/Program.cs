using System;
using System.Linq.Expressions;

namespace ExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //buid expression from bottom up
            Expression firstArg = Expression.Constant(2);
            Expression secondArg = Expression.Constant(3);
            Expression add = Expression.Add(firstArg, secondArg);
            Func<int> compiled = Expression.Lambda<Func<int>>(add).Compile();
            Console.WriteLine(compiled());

            //Converting lambda expression to expression tree
            Expression<Func<int>> return5 = () => 5;
            Func<int> compiled1 = return5.Compile();
            Console.WriteLine(compiled1());


            //Demonstrated of a more complicated expression
            Expression<Func<string, string, bool>> expression =
                (x, y) => x.StartsWith(y);
            var compiledRes = expression.Compile();
            Console.WriteLine(compiledRes("First","Second"));
            Console.WriteLine(compiledRes("First","Fir"));


            Console.ReadLine();
        }
    }
}
