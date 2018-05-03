using System;
using System.IO;

namespace HackerRankChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of StreamReader to read from a file
            StreamReader reader = new StreamReader("Sample.txt");

            using (reader)
            {


                int lineNumber = 0;
                string line = reader.ReadLine();
                // Read the other lines from the text file
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();

                }

                
                // Close the resource after you've finished using it

                //reader.Close();//no need to close, using statement will automatically close the file
               
            }

            //create a streamwriter instance
            StreamWriter writer = new StreamWriter("numbers.txt");

            //Ensure the writer will be closed when no longer used
            using (writer)
            {
                //Loop through the numbers from 1-20 and write them
                for(int i = 0; i<=20; i++)
                {
                    writer.WriteLine(i);
                }
            }

            string fileName = @"somedir\somefile.txt";
            try
            {
                StreamReader readerObj = new StreamReader(fileName);
                Console.WriteLine(
                    "File {0} successfully opened.", fileName);
                Console.WriteLine("File contents:");
                using (readerObj)
                {
                    Console.WriteLine(reader.ReadToEnd());
                }

            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine(
                    "Can not find file {0}.", fileName);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine(
                    "Invalid directory in the file path.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine(
                    "Can not open the file {0}", fileName);
            }

            string fileName1 = @"..\..\..\sample1.txt";//Relative Path: always use relative path than full path
            string word = "C#";
            try
            {
                StreamReader readerString = new StreamReader(fileName1);
                using (reader)
                {
                    int occurences = 0;
                    string line = readerString.ReadLine();
                    while(line!= null)
                    {
                        int index = line.IndexOf(word);
                        while(index != -1)
                        {
                            occurences++;
                            index = line.IndexOf(word, (index + 1));
                        }
                        line = readerString.ReadLine();
                    }
                    Console.WriteLine(
                        "The word {0} occurs {1} times", word, occurences);
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(
                    "Can not find file {0}.", fileName1);
            }
            catch (IOException)
            {
                Console.WriteLine(
                    "Cannot read the file {0}.", fileName1);
            }
            
            Console.ReadLine();




        }
    }
}
