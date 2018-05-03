using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class MyClass
    {
        delegate void MyDelegate(string myStrig);//delegate are useful to call methods at one time and pass the same parameter
        public void ShowThoseMessages()
        {
            MyDelegate md = new MyDelegate(ShowMessage);//it will add method to delegate
            md += ShowAnotherMessage;//we not calling we are adding to delegate thats why no () after method name
            md("Adam");//Calling a method from delegate

        }
        void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
        void ShowAnotherMessage(string a)
        {
            System.Windows.Forms.MessageBox.Show(a,"Test");
        }
       
    }
}
