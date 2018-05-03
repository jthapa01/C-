using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Average ten scores
Create a console application that will accept ten test scores between 0 and 100, average them, 
and report a letter grade for the average based on the usual scale.
For example, a teacher will input ten test scores and see the average 
numerical grade and the letter grade.*/

namespace AverageTenScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInputVal = 0;
            do
            {
                userInputVal = AverageScore.ShowMenu();
            } while (userInputVal <0 && userInputVal < 3);
            AverageScore.AskUserInput();
            //Console.ReadLine();
        }
    }


}
