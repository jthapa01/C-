using System;

namespace NullableCSharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable Types
            //int i = null;//Compile Error, Value type cant be null
            int? i = null;//Ok: special construct called nullable type
            Console.WriteLine(i==null);//true

            //translates to:
            Nullable<int> num = new Nullable<int>();
            Console.WriteLine(!num.HasValue);

            //Implicit and Explicit Nullable Conversions
            int? x = 5;//nullable type: implicit casting
            int y = (int)x; //explicit casting
            Console.WriteLine(y);

            //Boxing and Unboxing Nullable values
            object o = "string";
            int? x1 = o as int?;//unboxing: object type to nullable type
            Console.WriteLine(x1.HasValue);

            //Operator Lifting
            //Operator lifting means you can implicitly use T’s operators on T?.

            int? x2 = 5;
            int? y2 = null;

            //Equality operator examples
            Console.WriteLine(x2== y);  //False
            Console.WriteLine(x2 == null);//False
            Console.WriteLine(x2==5);//True
            Console.WriteLine(y2==null);
            Console.WriteLine(y2==5);
            Console.WriteLine(y2!=5);

            // Relational operator examples
            Console.WriteLine(x2 < 6); // True
            Console.WriteLine(y2 < 6); // False
            Console.WriteLine(y2 > 6); // False
            
            // All other operator examples
            Console.WriteLine(x2 + 5); // 10
            Console.WriteLine(x2 + y2); // null (prints empty line)

            //Equality operators(== and !=)
            Console.WriteLine(null == null); // True
            Console.WriteLine((bool?)null == (bool?)null); // True

            //Relational Operators(<, <=, >=, >)
            Console.WriteLine("Relational operator");
            bool b = x2 < y2;//Translation

            bool b1 = (x2.HasValue && y2.HasValue)
                     ? (x2.Value < y2.Value)
                     : false;
            Console.WriteLine(b);

            //All other operators (+, −, *, /, %, &, |, ^, <<, >>, +, ++, --, !, ~)
            //int? x2 = 5;int? y2 = null;
            int? c = x2 + y2;
            int? c2 = (x2.HasValue && y2.HasValue)              //compiler translates
                ? (int?)(x2.Value + y2.Value) : null;
            Console.WriteLine(c2);

            //Mixing nullable and non-nullable type
            int? a3 = null;
            int b3 = 2;
            int? c1 = a3 + b3; // c is null - equivalent to a + (int?)b

            //bool? with & and | Operators
            bool? n = null;
            bool? f = false;
            bool? t = true;
            Console.WriteLine(n | n); // (null)
            Console.WriteLine(n | f); // (null)
            Console.WriteLine(n | t); // True
            Console.WriteLine(n & n); // (null)
            Console.WriteLine(n & f); // False
            Console.WriteLine(n & t); // (null)

            //Null Coalescing Operator: Give me the actual value if it is
            //non null else give me th default value
            string s1 = null;
            string s2 = s1 ?? "nothing";//s2 evaluates to "nothing"
            Console.WriteLine(s2);

            //nullable types and null Operators(??)
            int? n1 = null;
            int n2 = n1 ?? 5; //y is 5
            //On nullable type: it is equivalent to calling 
            //GetValueOrDefault with an explicit default value

            int? a = null, b4 = 1, b5 = 2;
            Console.WriteLine(a ?? b4 ?? b5); //1

            //Null Conditional Operator(C#6)
            //?. is the null conditional operator or Elvis Operator
            //If expr on left null the expr evaluates to null instead of
            //throwing a NullReferenceException
            System.Text.StringBuilder sb = null;
            string s = sb?.ToString(); //No error, s instead evalates to null
            //equivalent to string s = (sb == null?null:sb.ToString());
            Console.WriteLine("Null Conditional Operator- elvis Operator");
            Console.WriteLine(s);
            //x?.y?.z and is equivalent to the following(except that x.y 
            //is evaluated only once):
            //x == null ? null
            //: (x.y == null ? null : x.y.z)
            System.Text.StringBuilder sb2 = null;
            //int length = sb?.ToString().Length; // Illegal : int cannot be null
            int? length = sb2?.ToString().Length; // OK : int? can be null
            string sb3 = sb?.ToString() ?? "nothing"; // s evaluates to "nothing"


            Console.ReadLine();
        }
    }
}
