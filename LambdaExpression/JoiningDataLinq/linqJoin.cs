using System;
using System.Collections.Generic;
using System.Linq;
namespace JoiningDataLinq
{
    class linqJoin
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>()
            {
                new Category{ID = 1, Name = "Fruit"},
                new Category{ID = 2, Name = "Food"},
                new Category{ID = 3, Name = "Shoe"},
                new Category{ID = 4, Name = "Juice"}
            };

            List<Product> products = new List<Product>()
            {
                new Product{Name = "Strawberry", CategoryID = 1},
                new Product{Name = "Banana", CategoryID = 1},
                new Product{Name = "Chicken meat", CategoryID = 2},
                new Product{Name = "Apple juice", CategoryID =4 },
                new Product{Name = "Fish", CategoryID = 2},
                new Product{Name = "Orange Juice", CategoryID = 4},
                new Product{Name = "Sandal", CategoryID = 3}
            };

            var productsWithCategories =
                from product in products
                join category in categories
                   on product.CategoryID equals category.ID
                select new
                {
                    Name = product.Name,
                    Category = category.Name
                };
            foreach (var item in productsWithCategories)
            {
                Console.WriteLine(item);
            }


            //Nested LINQ Queries
            Console.WriteLine();
            var productsWithCategoriesNested =
                from product in products
                select new
                {
                    Name = product.Name,
                    Category =
                        (from category in categories
                         where category.ID == product.CategoryID
                         select category.Name).First()
                         
                };
            foreach (var item in productsWithCategoriesNested)
            {
                Console.WriteLine(item);
            }
            //Linq Performances

            List<int> l1 = new List<int>();
            DateTime startTime = DateTime.Now;
            l1.AddRange(Enumerable.Range(1,50000000));
            Console.WriteLine("Ext.method:\t{0}", DateTime.Now-startTime);

            startTime = DateTime.Now;
            List<int> l2 = new List<int>();
            for(int i = 0; i < 50000000; i++)
            {
                l2.Add(i);
            }
            Console.WriteLine("For-loop:\t{0}", DateTime.Now - startTime);

            List<int> list = new List<int>();
            list.AddRange(Enumerable.Range(1, 100000));

            DateTime start = DateTime.Now;
            for (int i = 0; i<10000; i++)
            {
                var elements = list.Where(e=>e>2000);
            }
            Console.WriteLine("No execution:\t{0}", DateTime.Now-start);

            start = DateTime.Now;
            for (int i = 0; i<10000;i++)
            {
                var element = list.Where(e=>e>20000).First();
            }
            Console.WriteLine("Execution:\t{0}",DateTime.Now-start);

            Console.WriteLine("Performance set");
            HashSet<Guid> set = new HashSet<Guid>();
            for (int i = 0; i < 50000; i++)
            {
                set.Add(Guid.NewGuid());//Add random GUID
            }
            Guid keyForSearching = new Guid();
            DateTime startA = DateTime.Now;
            for (int i = 0; i < 5000; i++)
            {
                //use hashset.contains
                bool found = set.Contains(keyForSearching);
            }
            Console.WriteLine("HashSet: {0}", DateTime.Now-startA);

            startA = DateTime.Now;
            for (int i = 0; i < 50000; i++)
            {
                //Use IEnumerable<Guid>.Contains(,,)extension method
                bool found = set.Contains<Guid>(keyForSearching);
            }
            Console.WriteLine("Contains: {0}", DateTime.Now-startA);

            startA = DateTime.Now;
            for(int i = 0; i < 50000; i++)
            {
                //Use IEnumerable<Guid>.Where(...) extension method
                bool found = set.Where(g=>g==keyForSearching).Count()>0;
            }
            Console.WriteLine("Where: {0}", DateTime.Now - start);


            Console.ReadKey();
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public int CategoryID { get; set; }
    }
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

}
