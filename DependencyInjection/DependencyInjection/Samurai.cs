using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    /*This works just fine, but what if we wanted to arm our Samurai with another weapon? 
    Since the Sword is created inside the Samurai class’s constructor, we have to modify 
    the implementation of the class in order to make this change.
    When a class is dependent on a concrete dependency, it is said to be tightly coupled 
    to that class. In this example, the Samurai class is tightly coupled to the Sword class.
    When classes are tightly coupled, they cannot be interchanged without altering their
    implementation. In order to avoid tightly coupling classes, we can use interfaces to 
    provide a level of indirection. Let’s create an interface to represent a weapon in our game.*/
    class Samurai
    {
        //readonly Sword sword;//1. Alter for the abstraction
        readonly IWeapon weapon;
        public Samurai(IWeapon weapon)//4
        {
            //this.sword = new Sword(); //2. Alter for the abstraction

            /*Now our Samurai can be armed with different weapons.But wait!The Sword is still 
            created inside the constructor of Samurai.Since we still need to alter the implementation 
            of Samurai in order to give our warrior another weapon, Samurai is still tightly coupled to Sword.
            Fortunately, there is an easy solution. Rather than creating the Sword from within the 
            constructor of Samurai, we can expose it as a parameter of the constructor instead.*/

            //this.weapon = new Sword();//3
            this.weapon = weapon;

        }

        public void Attack(string target)
        {
            //this.sword.Hit(target);
            this.weapon.Hit(target);
        }
    }
}
