using System;

namespace UnsafeCodeAndPointers
{
    class Program
    {
        /*By marking a type, type member, or statement block with the unsafe keyword,
        you’re permitted to use pointer types and perform C++ style pointer operations on
        memory within that scope.*/
        int x;
        static void Main(string[] args)
        {
            /*the fixed statement tells
            the garbage collector to “pin” the object and not move it around. This may have an
            impact on the efficiency of the runtime, so fixed blocks should be used only briefly,
            and heap allocation should be avoided within the fixed block.*/
            Program pgm = new Program();
            unsafe
            {
                fixed (int* p = &pgm.x)//Pins pgm
                {
                    *p = 9;
                }
                Console.WriteLine(pgm.x);
            }

            /*& The address-of operator returns a pointer to the address of a variable
            * The dereference operator returns the variable at the address of a pointer
            -> The pointer-to-member operator is a syntactic shortcut, 
            in which x->y is equivalent to (*x).y */

            unsafe
            {
                Test test = new Test();
                Test* p = &test;
                p->x = 9;
                Console.WriteLine(test.x);
            }

            //Arrays: The stackalloc keyword
            //Memory can be allocated in a block on the stack explicitly using the stackalloc
            //keyword.Since it is allocated on the stack, its lifetime is limited to the 
            //execution of the method
            unsafe
            {
                int* a1 = stackalloc int[10];
                for (int i = 0; i < 10; ++i)
                    Console.WriteLine(a1[i]); // Print raw memory
            }

            //Fixed-size buffers
            //THe fixed keyword has another use which is to create fixed-size 
            //buffers within structs
            Console.WriteLine(new UnsafeClass("Christian Troy"));

            //Void*
            /*A void pointer (void*) makes no assumptions about the type of the underlying data
            and is useful for functions that deal with raw memory. An implicit conversion exists
            from any pointer type to void*. A void* cannot be dereferenced, and arithmetic
            operations cannot be performed*/

            short[] a = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            unsafe
            {
                fixed (short* p = a)
                {
                    //sizeof returns size of value-type in bytes
                    Zap(p, a.Length * sizeof(short));
                }
            }
            foreach (short x in a)
                System.Console.WriteLine(x); // Prints all zeros



            Console.ReadLine();
        }
        unsafe static void Zap(void* memory, int byteCount)
        {
            byte* b = (byte*)memory;
            for (int i = 0; i < byteCount; i++)
                *b++ = 0;
        }
        public struct Test
        {
            public int x;
        }

        unsafe struct UnsafeUnicodeString
        {
            public short Length;
            public fixed byte Buffer[30];//Allocate block of 30 bytes
        }

        unsafe class UnsafeClass
        {
            UnsafeUnicodeString uus;

            public UnsafeClass(string s)
            {
                uus.Length = (short)s.Length;
                fixed (byte* p = uus.Buffer)
                    for (int i = 0; i < s.Length; i++)
                        p[i] = (byte)s[i];
            }
        }
    }

}
