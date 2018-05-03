using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //var warrior = new Samurai();
            //warrior.Attack("the evildoers");
            var warrior1 = new Samurai(new Shuriken());
            var warrior2 = new Samurai(new Sword());
            warrior1.Attack("the evildoers");
            warrior2.Attack("the evildoers");
            Console.WriteLine("Debugger Attached: {0}", Debugger.IsAttached);//Pressing start debuggging/wo debugging
            Console.ReadLine();
        }
    }
}
