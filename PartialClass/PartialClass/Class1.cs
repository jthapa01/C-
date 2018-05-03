using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    
    
        partial class MyClass//no access modifier in partial method
        {
            public string HairColor = "Brown";
            public bool Glasses = false;
        partial void Message(string message)//must have a signature : same name
        {
            System.Windows.Forms.MessageBox.Show(message); //mbox tab twice
        }
        public void ShowMessage(string message)
        {
            Message(message);
        }
    }
    
}
