using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Bubble Sort: For each pass the highest number will be worted to the right; like a bubble float.*/
namespace BasicSortingAlgorithm
{
    public class Program
    {
        private int[] arr;
        private int upper;
        private int numElements;
        public Program(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }
        public void Insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }
        public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
                Console.Write(arr[i] + " ");
        }

        public void Clear()
        {
            for (int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
            }
            numElements = 0;
        }

        static void Main(string[] args)
        {
            //Program nums = new Program(10);
            //for (int i = 0; i <= 49; i++)
            //    nums.Insert(i);
            //Random rnd = new Random(100);
            //for (int i = 0; i < 10; i++)
            //{
            //    nums.Insert((int)(rnd.NextDouble() * 100));
            //}
            ////bUBBLE SORT CALL
            //Console.WriteLine("BUBBLE SORT: Before sorting: ");
            //nums.DisplayElements();
            //Console.WriteLine();
            //Console.WriteLine("\nBUBBLE SORT: During sorting: ");
            //nums.BubbleSort();
            //Console.WriteLine("\nBUBBLE SORT: After sorting: ");
            //nums.DisplayElements();

            //nums.Clear();
            //nums.DisplayElements();


            //Program nums1 = new Program(10);
            //Random rnd1 = new Random(100);
            //for (int i = 0; i < 10; i++)
            //{
            //    nums1.Insert((int)(rnd1.NextDouble() * 100));
            //}
            //SELECTION SORT CALL
            //Console.WriteLine("___________________________________________");
            //Console.WriteLine("\nSELECTION SORT: Before sorting: ");
            //nums1.DisplayElements();
            //Console.WriteLine();
            //Console.WriteLine("\nSELECTION SORT: During sorting: ");
            //nums1.SelectionSort();
            //Console.WriteLine("\nSELECTION SORT: After sorting: ");
            //nums1.DisplayElements();

            Program nums1 = new Program(5);
            Random rnd1 = new Random(100);
            for (int i = 0; i < 5; i++)
            {
                nums1.Insert((int)(rnd1.NextDouble() * 100));
            }
            //SELECTION SORT CALL
            Console.WriteLine("___________________________________________");
            Console.WriteLine("\nINSERTION SORT: Before sorting: ");
            nums1.DisplayElements();
            Console.WriteLine();
            Console.WriteLine("\nINSERTION SORT: During sorting: ");
            nums1.InsertionSort();
            Console.WriteLine("\nINSERTION SORT: After sorting: ");
            nums1.DisplayElements();
            Console.ReadKey();
            // nums.Clear();
            //nums.DisplayElements();

        }
        public void BubbleSort()
        {
            int temp;
            //Bubble Sort
            for (int outer = upper; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    if ((int)arr[inner] > arr[inner + 1])
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                        this.DisplayElements();
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
                this.DisplayElements();
                Console.WriteLine();
            }

        }
        public void SelectionSort()
        {
            int min, temp;
            for (int outer = 0; outer <= upper; outer++)
            {
                min = outer;
                for (int inner = outer+1; inner <= upper; inner++)
                {
                    if (arr[inner] < arr[min])
                    {
                        min = inner;
                    }
                    //this.DisplayElements();
                   // Console.WriteLine();

                }
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
                Console.WriteLine();
                this.DisplayElements();
                Console.WriteLine();
            }

        }

        public void InsertionSort()
        {
            int inner, temp;
            for (int outer = 1; outer <=upper; outer++)
            {
                temp = arr[outer];
                inner = outer;
                while(inner>0 && arr[inner - 1] >= temp)
                {
                    arr[inner] = arr[inner - 1];
                    inner -= 1;
                }
                arr[inner] = temp;

                this.DisplayElements();
                Console.WriteLine();
            }
        }


    }
}
