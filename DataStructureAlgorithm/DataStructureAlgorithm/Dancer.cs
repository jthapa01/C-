using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructureAlgorithm
{
    public struct Dancer
    {
        public string name;
        public string sex;

        public void GetName(string n)
        {
            name = n;
        }

        public override string ToString()
        {
            return name;
        }
    }

    class Class1
    {
        public static void NewDancers(Queue male, Queue female)
        {
            Dancer m, w;
            m = new Dancer();
            w = new Dancer();
            if(male.Count() > 0 && female.Count() > 0)
            {
                m.GetName(male.Peek().ToString());
                w.GetName(female.Peek().ToString());
            }
            else if ((male.Count()>0) && (female.Count() == 0))
            {
                Console.WriteLine("Waiting n a female dancer. ");
            }
            else if((female.Count()>0)&&(male.Count() == 0))
            {
                Console.WriteLine("Waiting on a male dancer.");
            }
        }
        public static void HeadOfLine(Queue male, Queue female)
        {
            Dancer w, m;
            w = new Dancer();
            m = new Dancer();
            if (male.Count()> 0)
            {
                m.GetName(male.Peek().ToString());
            }
            if (female.Count() > 0)
            {
                w.GetName(female.Peek().ToString());
            }
            if (m.name  != " " && w.name != " ")
            {
                Console.WriteLine("Next in line are: "+m.name+"\t"+w.name);
            }

            else if (m.name != "")
            {
                Console.WriteLine("Next in line is: " + m.name);
            }

            else
            {
                Console.WriteLine("Next in line is: " + w.name);
            }                
        }

        public static void StartDancing(Queue male, Queue female)
        {
            Dancer m, w;
            m = new Dancer();
            w = new Dancer();
            Console.WriteLine("Dance partners are: ");
            Console.WriteLine();
            for (int count = 0; count < 3; count++)
            {
                m.GetName(male.Peek().ToString());
                w.GetName(female.Peek().ToString());
                Console.WriteLine(w.name + "\t"+m.name);

            }
        }
        public static void FormLines(Queue male, Queue female)
        {
            Dancer d = new Dancer();
            StreamReader inFile;
            inFile = File.OpenText("C:\\Users\\New Laptop\\Documents\\dancers.txt");
            string line;
            while(inFile.Peek()!= -1)
            {
                line = inFile.ReadLine();
                d.sex = line.Substring(0, 1);
                d.name = line.Substring(2, line.Length - 2);
                if(d.sex == "M")
                {
                    male.EnQueue(d);
                }
                else
                {
                    female.EnQueue(d);
                }
            }
        }
    }
}
