using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageTenScores
{
    public class AverageScore
    {
        private  double sum;
        private static string[] userInput;
        private int userOption;
        private double average;
        public static double Sum { get; set; }
        public static double Average { get; set; }
        public static int UserOption { get; set; }


        public static void InputValidation()
        {

            foreach (string item in userInput)
            {
                double result;


                if (Double.TryParse(item, out result))
                {
                    if (result >= 0 && result <= 100)
                    {   
                        Sum += result;
                        Average = (double) Sum / (userInput.Length);
                 
                    }
                    else
                    {
                        Console.WriteLine("Your score can't be negative or greater than 0.");
                        AskUserInput();
                    }

                }
                else
                {
                    Console.WriteLine("Your score {0} is not valid", item);
                }
            }
            LetterGrade(Average);
            //Console.WriteLine("Sum is: {0}", Sum);
            Console.WriteLine("Your average score is {0}", Average);
            AskUserToContinue();

        }

        public static void AskUserInput()
        {
            if (UserOption == 1)
            {
                do
                {
                    Console.WriteLine("Enter 10 Comma-Separated scores in the range of 0-100: ");
                    userInput = Console.ReadLine().Split(',');
                    Console.WriteLine("You have entered total of {0} scores", userInput.Length);
                } while (userInput.Length != 10);

            }
            else if (UserOption == 2)
            {
                int len;
                do
                {
                    Console.WriteLine("Enter specific number of scores you want to average: ");
                    string length = Console.ReadLine();
                    if(Int32.TryParse(length, out len))
                    {
                        Console.WriteLine("You want the average grade of {0} scores", len);
                    }
                    else
                    {
                        Console.WriteLine("Length of score is not in correct format.");
                    }
                    Console.WriteLine("Enter {0} Comma-Separated scores in the range of 0-100: ", len);
                    userInput = Console.ReadLine().Split(',');
                    Console.WriteLine("You entered:{0} scores", userInput.Length);
                    if(len != userInput.Length)
                    {
                        Console.WriteLine("You want to calculate {0} scores, " +
                            "but you entered {1} scores", len, userInput.Length);
                    }
                } while (len != userInput.Length );
            }
            else
            {
                    do
                    {
                        Console.WriteLine("Enter Comma-Separated scores in the range of 0-100: ");
                        userInput = Console.ReadLine().Split(',');
                        Console.WriteLine("You entered:{0} scores", userInput.Length);
                    } while (userInput.Length < 0 );
            }



            AverageScore.InputValidation();
        }

        public static void LetterGrade(double avgScore)
        {
            if (avgScore >= 90)
            {
                Console.WriteLine("Your average grade for the class is: A ");
            }
            else if(avgScore >=80 && avgScore < 90)
            {
                Console.WriteLine("Your average grade for the class is: B ");
            }
            else if(avgScore >= 70 && avgScore < 80)
            {
                Console.WriteLine("Your average grade for the class is: C ");
            }
            else if (avgScore >= 60 && avgScore < 70)
            {
                Console.WriteLine("Your average grade for the class is: D ");
            }
            else if (avgScore >= 0 && avgScore < 60)
            {
                Console.WriteLine("Your average grade for the class is: F ");
            }
            else
            {
                Console.WriteLine("Invalid average score for the class.");
            }
                
        }

        public static void AskUserToContinue()
        {
            Console.WriteLine("Do you want to run the program again?" +
                              @" Press ""Y"" to continue ""N"" to exit");
            string option = Console.ReadLine().ToUpper();
            if (option == "Y")
            {
                Console.Clear();
                ShowMenu();
                Sum = 0;
                AskUserInput();

                //InputValidation();
            }
            else if (option == "N")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid option!");
            }
        }

        public static int ShowMenu()
        {
            Console.WriteLine("Calculate Average Scores");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Choose any one option from the menu below: ");
            Console.WriteLine();
            Console.WriteLine("Choose 1: Average Ten Scores ");
            Console.WriteLine("Choose 2: Average a Specific Number of Scores");
            Console.WriteLine("Choose 3: Average a Unspecific Number of Scores\n");
            int option;
            string validNum = Console.ReadLine(); 
            if(Int32.TryParse(validNum, out option))
            {
                Console.WriteLine("Your option {0} is valid", option);
                UserOption = option;
            }
            else
            {
                Console.WriteLine("Your option is invalid", option);
                ShowMenu();
            }
            
            return UserOption;
            
        }

    }
}
