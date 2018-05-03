using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    public class MainProgram
    {
        private static int convertedSide;
        static void Main(string[] args)
        {
            //////The Perimeter and Area of a Circle
            ////Console.WriteLine("The Perimeter and Area of a Circle");
            ////Console.WriteLine("--------------------------------\n");
            ////Circle circle = new Circle();

            ////bool isValidated = false;
            ////while (!isValidated)//same as while(true) and at the end break out of the loop, 
            ////{                   //continue will continue the while lop ignoring the following code
            ////    string input = "";
            ////    try
            ////    {
            ////        Console.Write("Please Enter the radius of a Circle: ");

            ////        input = Console.ReadLine();
            ////        circle.Radius = Convert.ToInt32(input);

            ////        if (circle.Radius < 0)
            ////        {
            ////            //Console.WriteLine("You must enter a positive radius.");
            ////            throw new Exception();
            ////            //continue;

            ////        }
            ////    }
            ////    catch(FormatException)
            ////    {
            ////        Console.WriteLine("Input string must be a number.");
            ////        continue;
            ////    }
            ////    catch(Exception)
            ////    {
            ////        Console.WriteLine("You must enter a positive radius.");
            ////        continue;
            ////    }
            ////    finally
            ////    {
            ////        Console.WriteLine("The radius you have entered is: {0}", input);
            ////    }
            ////    isValidated = true;
            ////    //break;
            ////}
            ////Console.WriteLine("The area of a circle with a radius {0} is: {1}", circle.Radius, circle.CalculateArea());
            ////Console.WriteLine("The Circumference of a circle is: {0}", circle.calculatePerimeter());
            ////Console.WriteLine("\n------------------------------------");


            //////The Volume of a Hemisphere

            ////Console.WriteLine("The Volume of a Hemisphere");
            ////Console.WriteLine("-------------------------------------\n");
            ////Hemisphere hemisphere = new Hemisphere();
            ////while (true)
            ////{
            ////    Console.Write("Please Enter the radius of a Hemisphere: ");
            ////    double radius;
            ////    if (double.TryParse(Console.ReadLine(), out radius))
            ////    {
            ////        hemisphere.radius = radius;
            ////        if (hemisphere.radius < 0)
            ////        {
            ////            Console.WriteLine("You must enter a positive radius.");
            ////            continue;
            ////        }   
            ////    }
            ////    else 
            ////    {
            ////        Console.WriteLine("Input String must be a number ");
            ////        continue;          
            ////    }
            ////    break;
            ////}
            ////Console.WriteLine("The volume of a hemisphere is: {0}", hemisphere.calculateVolume());
            ////Console.WriteLine("\n----------------------------------");


            //The perimeter of a Triangle
            Console.WriteLine("The Perimeter and Area of a Triangle");
            Console.WriteLine("--------------------------------\n");
            int sideA, sideB, sideC;
            do
            {
                Console.WriteLine("Enter the first integer; side of a triangle: ");
                string side1 = Console.ReadLine();

                sideA = validateInput(side1);

                Console.WriteLine("Enter the second integer; side of a triangle: ");
                string side2 = Console.ReadLine();
                sideB = validateInput(side2);

                Console.WriteLine("Enter the third integer; side of a triangle: ");
                string side3 = Console.ReadLine();
                sideC = validateInput(side3);
            } while (sideA <= 0 || sideB <= 0 || sideC <= 0);

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            int perimeter = triangle.CalculatePerimeter();
            Console.WriteLine("The perimeter of a triangle is: {0}", perimeter);

            if (sideA >= (sideB + sideC) || sideB >= (sideC + sideA) || sideC >= (sideA + sideB))
            {
                Console.WriteLine("The sides of your triangle do not adhere to the triangle inequality theorem,\n"
                    + "which states that the sum of the side lengths of any 2 sides of a triangle "
                    + "\nmust exceed the length of the third side.");
            }
            else
            {
                double area = Math.Sqrt((perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
                Console.Write("The area of a triangle is: {0:f2}", area);
            }

            Console.ReadLine();






            //Console.WriteLine("--------------------------------\n");
            //Console.ReadLine();

            //Quadratic Equation
            //int coeffA, coeffB, coeffC;
            //bool wantContinue=false;
            //do
            //{
            //    Console.WriteLine("Quadratic Equation Calculation");
            //    Console.WriteLine("--------------------------------");
            //    Console.WriteLine("\n");
            //    //while (!isIntVal)
            //    do
            //    {

            //        Console.WriteLine("Enter the positive integer for coeffecient a: ");

            //        coeffA = Convert.ToInt32(Console.ReadLine());
            //    } while (coeffA < 0);
            //    do
            //    {
            //        Console.WriteLine("Enter the positive integer for coeffecient b: ");
            //        coeffB = Convert.ToInt32(Console.ReadLine());
            //    } while (coeffB < 0);

            //    do
            //    {
            //        Console.WriteLine("Enter the positive integer for coeffecient c: ");
            //        coeffC = Convert.ToInt32(Console.ReadLine());
            //    } while (coeffC < 0);


            //    QuadraticCalculator quadCalc = new QuadraticCalculator();

            //    if (quadCalc.QuadPart(coeffA, coeffB, coeffC) > 0)
            //    {
            //        quadCalc.CalculateQuadPosVal(coeffA, coeffB, coeffC);
            //    }
            //    else if (quadCalc.QuadPart(coeffA, coeffB, coeffC) == 0)
            //    {
            //        double val = quadCalc.CalculateQuadZeroVal(coeffA, coeffB, coeffC);
            //        Console.WriteLine("The quadratic value of a given coefficient is: {0}", val);
            //    }
            //    else
            //    {
            //        quadCalc.CalculateQuadNegativeVal();
            //    }
            //    Console.WriteLine("Do you want to Continue: Press (y) for continue or (n) for exit");
            //    string wantCount = Console.ReadLine();
            //    var wantCountLower = wantCount?.ToLower();
            //    //isIntVal = true;
            //    if (wantCountLower == "y")
            //    {
            //        wantContinue = false;
            //        continue;
            //    }
            //    else
            //    {
            //        wantContinue = true;
            //        break;
            //    }

            //    Console.ReadLine();

            //    //Console.ReadLine();
            //}while (!wantContinue);

        }
        private static int validateInput(String side)
        {
            //bool isChecked = false;
            //while(!isChecked)
            //{
                if (Int32.TryParse(side, out  convertedSide))
                {
                    if (convertedSide <= 0)
                    {
                        Console.WriteLine("Side must be greater than 0.");
                    }
                    //isChecked = true;
                }
                else
                {

                    Console.WriteLine("Side is not a valid input");
                }
           // }
            return checked(convertedSide);
        }

    }
}
