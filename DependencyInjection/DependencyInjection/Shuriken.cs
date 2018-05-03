using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Shuriken : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Pierced {0}'s armor", target);
        }
    }
}
