using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a console application that will accept ten numbers between 0 and 100, and report their sum.
namespace CalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            bool onSwitch = false;
            while (!onSwitch)
            {
                Console.WriteLine("Please enter exactly ten comma separated numbers between 0 and 100: ");
                string[] num = Console.ReadLine().Split(',');
                int elements;
                double average = 0;
                double sum = 0;
                foreach (string item in num)
                {
                    if (Int32.TryParse(item, out elements))
                    {
                        if (elements <= 100 && elements >= 0 && num.Length == 10)
                        {
                            sum += (double)elements;
                            average = sum / (num.Length);
                        }
                        else
                        {
                            if (num.Length < 10)
                            {
                                Console.WriteLine($"You entered {num.Length} numbers");
                                Console.WriteLine("Please enter exactly ten comma separated numbers between 0 and 100:");
                                onSwitch = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Your entered number is out of range: ");
                                onSwitch = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your input of {0} is invalid", item);
                        onSwitch = true;
                    }
                }
                if (!onSwitch)
                {

                    Console.WriteLine("The sum of the number is: {0}", sum);
                    Console.WriteLine($"The average of given number is: {average}");

                }

                while (true)
                {
                    if (EnterNumberAgain())
                    {
                        onSwitch = false;
                        break;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        static public bool EnterNumberAgain()
        {

            while (true)
            {
                Console.WriteLine("Do you want to continue [Y/N]?: ");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    return true;
                }
                if (answer == "N")
                {
                    return false;
                }
            }
        }
    }
}


