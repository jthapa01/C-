using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class MyClass//Base Class
    {
        private string Name = "Bob";//protected members are only available in class
        public int Age = 10;
       // public void ShowMessage(string Message)
          public virtual void ShowMessage(string Message)//we can also override with a keyword override but base method must be virtual
        {
            System.Windows.Forms.MessageBox.Show(Message);
            
        }
    }
    class MySecondClass: MyClass,IMyInterface //Inheritance derived class; can nherit from interface as well
    {
        public string HairColor = "Brown";
        //public void MessageBoxSpecial()
        //public new void ShowMessage(string message)//Method overriding: overrides the method in base class
        public override void ShowMessage(string message)//method override using override keyword
        {
            //System.Windows.Forms.MessageBox.Show(base.Age.ToString());
            //base.ShowMessage(base.Age.ToString());
            System.Windows.Forms.MessageBox.Show(message,"My Title");
        }
        public void MyVoid()//interface definition
        {
            base.ShowMessage("My Void");
        }
    }

    class MyThirdClass: MySecondClass//Can be inherited down from derived or again from base class

    {

    }

    interface IMyInterface//multiple classes which do the same thing then create interface
    {
        void MyVoid();//defaul member are pulic and will remain public, no definition {}
    }
    
}
