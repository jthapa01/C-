using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    namespace MySubNameSpace
    {

    }
   
    class MyClass
    {
        enum Names: byte//its like array, we can change it to data type
        {
            Adam=1,//deault integer
            Joe=4,
            Bob,//bob will be 5 one more than previous member
        }
        string Name;
        public MyClass(string name)//ctor tab twice creates constructor automatically; constructor has a same name as a class
        
        {
            Name = name;     
        }
        public MyClass(bool hello)//can have multiple constructors must have different parameters tough
        {

        }
        public string name()//access modifier:  default is always private
        {
            return Name;
        }
        Names myName = Names.Adam;//enumeration variable
        public static void ShowMessage(string message)// static method doesnt need 
            //instance of a class to call. only static variables can be used in static method
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

        public static void ShowMessage(int message)// overloading method: sa,e method
            //name but should have different parameters
                                                     
        {
            System.Windows.Forms.MessageBox.Show(message.ToString());
        }
    }
}
