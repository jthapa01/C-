using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace StringsAndChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcde";
            str = "jeevan";
            string assigned = str;
            Console.WriteLine($"{ str}");
            Console.WriteLine("Assigned value:{0} ", assigned);
            char ch = str[1];//ch ==b
            //str[1] = 'a'; cant override
            //  ch = str[50];//runtime error 
            Console.WriteLine("-------------------------");
            string word1 = "C#";
            string word2 = "c#";
            Console.WriteLine(word1.Equals("C#"));
            Console.WriteLine(word1.Equals(word2));
            Console.WriteLine(word1 == "C#");
            Console.WriteLine(word1==word2);
            Console.WriteLine(word1.Equals(word2,
                StringComparison.CurrentCultureIgnoreCase));

            //Lexicographical order
            Console.WriteLine("-----------which comes first------");
            string score = "sCore";
            string scary = "sary";
            Console.WriteLine(score.CompareTo(scary));
            Console.WriteLine(scary.CompareTo(score));
            Console.WriteLine(scary.CompareTo(scary));

            //use equals or == operator to compare strings
            string alpha = "alpha";
            string score1 = "sCorE";
            string score2 = "score";
            Console.WriteLine(string.Compare(alpha, score1, false));
            Console.WriteLine(string.Compare(score1, score2, false));
            Console.WriteLine(string.Compare(score1, score2, true));
            Console.WriteLine(string.Compare(score1, score2, StringComparison.CurrentCultureIgnoreCase));

            // lexicographical comparison does not follow the letter arrangement in the Unicode table.
            string first = "Straße";
            string second = "Strasse";
            Console.WriteLine(first == second); // False
            Console.WriteLine(first.CompareTo(second)); // 0 – equal strings

            Console.WriteLine("====================== operator=========================");
            string string1 = "hello";
            string str2 = string1;
            Console.WriteLine(string1 == str2);

            string hel = "Hel";
            string hello = "Hello";
            string copy = hel + "lo";
            Console.WriteLine(copy == hello);

            string hello1 = "Hello";//they both points to the same reference in Heap
            string name = "Hello";//becaise of the string interning the copiler checks whether the 
            //same string is already available, is so then points to the same obj

            string declared = "Intern pool";
            string built = new StringBuilder("Intern pool").ToString();
            string interned = string.Intern(built);
            Console.WriteLine(object.ReferenceEquals(declared,built));
            Console.WriteLine(object.ReferenceEquals(declared, interned));

            //IndexOf LastIndexOf
            Console.WriteLine("---------------------INDEX----------------");
            string book = "Introduction to C# book";
            int index = book.IndexOf("C#");
            Console.WriteLine(index);

            string strn = "C# Programming Course";
            int indexVal = strn.IndexOf("C#");//0
            index = strn.IndexOf("Course");//15
            index = strn.IndexOf("COURSE");//-1
            index = strn.IndexOf("ram");//7
            index = strn.IndexOf("r");//4
            index = strn.IndexOf("r",5);//7
            index = strn.IndexOf("r", 10);//18

            //Finding all occurrences of a Substring
            string quote = "The main intent of the \"Into C#\""+
                " book is to introduce the C# programming to newbies.";
            string keyword = "C#";
            int indexFind = quote.IndexOf(keyword);

            while (indexFind != -1)
            {
                Console.WriteLine("{0} found at index: {1}", keyword, indexFind);
                indexFind = quote.IndexOf(keyword, indexFind + 1);
            }

            //Extracting a File Name and file extension
            string path = "C:\\Pics\\CoolPic.jpg";
            int indexStr = path.LastIndexOf("\\");
            string fileFullName = path.Substring(indexStr+1);

            //Splitting the string by a separator
            string listOfBeers = "Amstel, Heineken, Tuborg, Becks";
            char[] separators = new char[] { ' ', '.', '.' };
            string[] beersArr = listOfBeers.Split(separators);
            foreach (var beer in beersArr)//it is not removing from the array it is just not printing empty array elements
            {
                if(beer != "")
                {
                    Console.WriteLine(beer);
                }
            }

            string[] beersArray = listOfBeers.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //Replacing a Substing
            string doc = "Hello, some@gmail.com, " +
                                "you have been using some@gmail.com in your registration.";
            string fixedDoc = doc.Replace("some@gmail.com", "john@smith.com");
            Console.WriteLine(fixedDoc);

            //Regular Expression
            string docTest = "Smith's number: 0898880022\nFranky can be " +
                            "found at 0888445566.\nSteven's mobile number: 0887654321";
            string replacedDoc = Regex.Replace(
                docTest, "(08)[0-9]{8}", "$1********");//(08) separate group,[0-9]=range,{8}=length, replace with $1 first group
            Console.WriteLine(replacedDoc);

            string fileData = "   \n\n     David Allen    ";
            string reduced = fileData.Trim();


            string fileData1 = "   111 $  %    David Allen  ### s   ";
            char[] trimChars = new char[] { ' ', '1', '$', '%', '#', 's' };
            string reducedData = fileData1.Trim(trimChars);
            Console.WriteLine(reducedData);

            string reduced1 = fileData1.TrimEnd(trimChars);
            // reduced = "   111 $  %    David Allen

            //Do not concatenate string in a for loop Why?

                //Console.WriteLine(DateTime.Now);//took more than 5 mins

                //string collector = "Numbers: ";
                //for (int indexin = 1; indexin <= 200000; indexin++)
                //{
                //    collector += index;
                //}

                //Console.WriteLine(collector.Substring(0, 1024));
                //Console.WriteLine(DateTime.Now);

            Console.WriteLine(DateTime.Now);
            StringBuilder sb = new StringBuilder();
            sb.Append("Numbers: ");
            for(int i =1; i <= 200000; i++)
            {
                sb.Append(i);
            }
            Console.WriteLine(sb.ToString().Substring(0,1024));
            Console.WriteLine(DateTime.Now);

            //Reversing a String
            string text = "EM edit";
            string reversed = ReverseText(text);
            Console.WriteLine(reversed);

            //Extract all capital letters from  a text
            string capitalLetter = CountCapitalLetter(text);
            Console.WriteLine(capitalLetter);

            //String Format
            DateTime date = DateTime.Now;
            string namePerson = "David Scott";
            string task = "Introdcution to C# book";
            string location = "his office";
            string formattedText = String.Format(
                "Today is {0: MM/dd/yyyy} and {1} is working on {2} in {3}.",
                date, name, task, location);
            Console.WriteLine(formattedText);

            string textDate = "11/12/2001";
            string format = "MM/dd/yyyy";
            DateTime parsedDate = DateTime.ParseExact(
                textDate, format, CultureInfo.InvariantCulture);
            Console.WriteLine("Day: {0}\nMonth: {1}\nYear: {2}",
                parsedDate.Day, parsedDate.Month, parsedDate.Year);





            Console.ReadKey();
        }

        private static string CountCapitalLetter(string text)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i <= text.Length-1; i++)
            {
                char ch = text[i];
                if (char.IsUpper(ch))
                {
                    result.Append(ch);
                }
            }
            return result.ToString();
        }

        private static string ReverseText(string str)
        {
            StringBuilder sb = new StringBuilder(7);//using parameter will save unnecessary 
            //dynamic memory allocation of default 16 char
            
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
