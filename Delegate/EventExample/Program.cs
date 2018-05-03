using System;

namespace EventExample
{
    //delegate
    public delegate void myEventHandler(string newValue);

    class Program
    {
        private string theValue;
        //event 
        public event myEventHandler valueChanged;

        public string Val
        {
            set
            {
                this.theValue = value;//sets the value
                this.valueChanged(theValue);//calls the valueChanged event
            }
        }
        static void Main(string[] args)
        {
            Program myEvt = new Program();
            myEvt.valueChanged += new myEventHandler(myEvt_valueChanged);

            string input;
            do
            {
                input = Console.ReadLine();
                if (!input.Equals("exit"))
                {
                    myEvt.Val = input;
                }

            } while(!input.Equals("Exit"));
            Console.ReadLine();
        }

        private static void myEvt_valueChanged(string newValue)
        {
            Console.WriteLine("The value changed to {0}", newValue);
        }
    }
}
