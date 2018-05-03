using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class MyClass
    { 
        string mystring;
    
        public MyClass(string name)//constructor
        {
        mystring = name;
            //Name = name;
        }
        public string Name//property
        {
            get { return mystring; }//readonly property:default will make it public coz of property is public
            set {
                if (value == "")
                    System.Windows.Forms.MessageBox.Show("That cant be done");
            }//write property
        }
    }
}
