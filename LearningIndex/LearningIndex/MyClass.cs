using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningIndex
{
    class MyClass
    {
        public string this[int index]//Creating Indexes treates class like a virtual array
        {
            get
            {
                return MyArray[index];
            }
            set
            {
                MyArray[index] = value;
            }
        }
        string[] MyArray = { "Adam", "Jeevan", "Thapa" };
    }
}
