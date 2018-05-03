using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class MyClass
    {
        public event EventHandler OnPropertyChanged;//event Handler
        string name = "";
        public string Name //Method
        {
            get { return name; }
            set {
                name = value;
                OnPropertyChanged(this, new EventArgs());
                }
        }
    }
}
