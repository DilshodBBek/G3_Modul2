namespace G3_Modul2.Linq.SetOperators
{
    public static class SetExamples
    {
        public static void RunSetOperators()
        {
            List<Product> products = new()
            {
                new(){Id=1, Name="Milk"},
                new(){Id=1, Name="Milk"},
                new(){Id=2, Name="Choco"},
                new(){Id=3, Name="choco"},
            };
            Product a = products[0];
            Product b = products[1];
            Product c = products[2];
            
          
            List<Product> products2 = new()
            {   
                b,
                a,

                c,
                new(){Id=1, Name="silk"},
                new(){Id=2, Name="choco"},
                new(){Id=3, Name="Choco"},
            };

            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));



            int[] ints = { 1, 2, 4, 5, 7, 8 };
            int[] ints2 = { 1, 3, 4, 5, 7, 9, 11, 13, 14, 15, 16 };
            //3,9,11,13,14,15,16
            var res = products2.Intersect(products);
            foreach (var item in res)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Distinct()
        {
            List<Product> products = new()
            {
                new(){Id=1, Name="Milk"},
                new(){Id=1, Name="Milk"},
                new(){Id=2, Name="Choco"},
                new(){Id=3, Name="choco"},
            };
            string[] list = new string[] { "Hi", "hello", "Hi", "Privet", "Salom", "salom" };
            //list= list.Distinct().ToList();
            MyComparer myComparer = new();
            var distinctedList = products.Distinct();
            foreach (var item in distinctedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
