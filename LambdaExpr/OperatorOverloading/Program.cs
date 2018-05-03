using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operator overloading: Operators can be overloaded to provide
            //more natural syntax for custom types

            //Operator Functions:
            Note B = new Note(2);
            Note CSharpt = B + 2;
            Console.WriteLine(B);
            Console.WriteLine(B.value);
            Note n = (Note)554.37;//explicit conversion
            double x = n;//implicit conversion
            Console.WriteLine(n);

            //Overloading True and False
            SqlBoolean sb = SqlBoolean.Null;
            if (sb)
                Console.WriteLine("True");
            else if (!sb)
                Console.WriteLine("False");
            else
                Console.WriteLine("Null");



            Console.ReadLine();
        }
        public struct Note
        {
            public int value;
            public Note(int semitonesFromA)
            {
                value = semitonesFromA;
            }
            //public static Note operator + (Note x, int semitones)
            //{
            //    return new Note(x.value + semitones);
            //}
            public static Note operator +(Note x, int semitones)
                                            => new Note(x.value + semitones);

            //convert to HZ
            public static implicit operator double(Note x)
                =>440 * Math.Pow(2,(double)x.value/12);
            // Convert from hertz (accurate to the nearest semitone)
            public static explicit operator Note(double x)
                => new Note((int)(0.5 + 12* (Math.Log(x/440/Math.Log(2)))));


        }

        public struct SqlBoolean
        {
            private byte m_value;
            public static readonly SqlBoolean Null = new SqlBoolean(0);
            public static readonly SqlBoolean False = new SqlBoolean(1);
            public static readonly SqlBoolean True = new SqlBoolean(2);

            private SqlBoolean(byte value)
            {
                m_value = value;
            }

            public static bool operator true(SqlBoolean x)
                => x.m_value == True.m_value;
            public static bool operator false(SqlBoolean x)
                => x.m_value == False.m_value;
            public static SqlBoolean operator !(SqlBoolean x)
            {
                if (x.m_value == Null.m_value) return Null;
                if (x.m_value == False.m_value) return True;
                return False;
            }

        }
    }
}
