using System;
using System.Collections.Generic;
using System.Linq;

namespace UseOfSelect
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            SelectSample app = new SelectSample();
            //Produce a filtered sequence of unmodified students
            IEnumerable<Student> studentQuery1 =
                from student in app.students
                where student.ID > 111
                select student;
            Console.WriteLine("Query1: select range_variable");
            foreach (Student s in studentQuery1)
            {
                Console.WriteLine(s.ToString());
            }

            //Produce a filtered sequence of elements that contain 
            //only one property of each student
            IEnumerable<String> studentQuery2 =
                from student in app.students
                where student.ID > 111
                select student.Last;
            Console.WriteLine("\r\n studentQuery2: select range_variable.Property");
            foreach (string s in studentQuery2)
            {
                Console.WriteLine(s);
            }

            //Produce a filtered sequence of objects created by
            // a method call on each student
            IEnumerable<ContactInfo> studentQuery3 =
                from student in app.students
                where student.ID > 111
                select student.GetContactInfo(app, student.ID);

            Console.WriteLine("\r\n studentQuery3: select range_variable.Method");
            foreach (ContactInfo ci in studentQuery3)
            {
                Console.WriteLine(ci.ToString());
            }

            //Product a filtered sequence of ints
            //from internal array inside each Student
            IEnumerable<int> studentQuery4 =
                from student in app.students
                where student.ID > 111
                select student.Scores[0];

            Console.WriteLine("\r\n studentQuery4: select range_variable[index]");
            foreach (int i in studentQuery4)
            {
                Console.WriteLine("First score = {0}", i);
            }


            // Produce a filtered sequence of doubles 
            // that are the result of an expression.
            IEnumerable<double> studentQuery5 =
                from student in app.students
                where student.ID > 111
                select student.Scores[0] * 1.1;

            Console.WriteLine("\r\n studentQuery5: select expression");
            foreach (double d in studentQuery5)
            {
                Console.WriteLine("Adjusted first score = {0}", d);
            }
            // Produce a filtered sequence of doubles that are
            // the result of a method call.
            IEnumerable<double> studentQuery6 =
                from student in app.students
                where student.ID > 111
                select student.Scores.Average();

            Console.WriteLine("\r\n studentQuery6: select expression2");
            foreach (double d in studentQuery6)
            {
                Console.WriteLine("Average = {0}", d);
            }

            //Produce a filtered sequence of anonymous types
            //that contain only two properties from each student
            var studentQuery7 =
                from student in app.students
                where student.ID > 111
                select new {student.First, student.Last };

            Console.WriteLine("\r\n studentQuery7: select new anonymous type");
            foreach (var item in studentQuery7)
            {
                Console.WriteLine("{0}, {1}", item.Last, item.First);
            }
            // Produce a filtered sequence of named objects that contain
            // a method return value and a property from each Student.
            // Use named types if you need to pass the query variable 
            // across a method boundary.

            IEnumerable<ScoreInfo> studentQuery8 =
                from student in app.students
                where student.ID > 111
                select new ScoreInfo
                {
                    Average = student.Scores.Average(),
                    ID = student.ID
                };

            Console.WriteLine("\r\n studentQuery8: select new named type");
            foreach (ScoreInfo si in studentQuery8)
            {
                Console.WriteLine("ID = {0}, Average = {1}", si.ID, si.Average);
            }

            // Produce a filtered sequence of students who appear on a contact list
            // and whose average is greater than 85.
            IEnumerable<ContactInfo> studentQuery9 =
                from student in app.students
                where student.Scores.Average() > 85
                join ci in app.contactList on student.ID equals ci.ID
                select ci;

            Console.WriteLine("\r\n studentQuery9: select result of join clause");
            foreach (ContactInfo ci in studentQuery9)
            {
                Console.WriteLine("ID = {0}, Email = {1}", ci.ID, ci.Email);
            }

            // Keep the console window open in debug mode
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
