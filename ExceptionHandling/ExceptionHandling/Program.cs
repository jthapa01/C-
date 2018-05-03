using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {





            int zero = 0;

            try
            {
                int result = 5 / zero;  // this will throw an exception       

            }
            catch (Exception ex)
            {
                Console.WriteLine("Inside catch block. Exception: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Inside finally block.");

            }
            try
            {
                Console.Write("Please enter number: ");

                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Please enter number: ");

                int num2 = int.Parse(Console.ReadLine());
                if (num1 < 0 || num2<0)
                {
                    throw new Exception();
                }
                 
                
                int result = num1 / num2;

                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            }

            catch (DivideByZeroException ex)
            {
                //LogError(ex);
                Console.Write($"Cannot divide by zero. Please try again. {ex.Message}");
                //Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {

                //LogError(ex);
                Console.Write($"Not a valid number. {ex.Message}");
                //Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                //LogError(ex);
                Console.Write("Not a valid number. Please try again.");
            }
            catch (Exception ex)
            {
                //    throw new Exception();
                Console.WriteLine("Number must be a postive integer", ex.Message);
            }


            Console.ReadKey();

        }

    }


}


