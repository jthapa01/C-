using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureProperty

{
    struct Client: IClient //struc cant inherit from classes or another struc but it does from interface
    {
        public Client(string name)//ctor double tab cretes constructor
        {
            Name1 = name;
            Age = 0;
        }
        public string Name1;
        public int Age;
        public void ClearClientInfo()
        {
            Name1 = "";
            Age = 0;
        }

    }
    interface IClient
    {
        public string Name1;

    }
}

