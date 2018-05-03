using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class MyClass //you can not create an instance of the abstract class. if member is abstract class must be abstract
    {
        public static string Name = "Adam";
        public static int Age = 15;
        public static void Message(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
        public abstract void ShowMessage(string message); //cant have implementation
    }
    class MySecondClass: MyClass
    {
        public override void ShowMessage(string message)//override and use implementation
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
    }

}
