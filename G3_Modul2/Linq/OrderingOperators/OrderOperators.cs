using G3_Modul2.Linq.SetOperators;
using System.Linq;

namespace G3_Modul2.Linq.OrderingOperators;

public class OrderOperators
{
    public static void RunOrderOperators()
    {
        List<G3_Modul2.Linq.SetOperators.Product> products = new()
        {
            new(){Id=1, Name="AppLeVision", Category= Category.Future,Price=3500  },
            new(){Id=3, Name="Fanta", Category = Category.New, Price = 1.1 },
            new(){Id=2, Name="Cola", Price= 1.1, Category= Category.New},
            new(){Id=11, Name="IPhone", Category = Category.Old, Price=1500 },
            new(){Id=1, Name="Samsung", Price = 1500, Category= Category.Old },

            new(){Id=4, Name="Rolls Roys Phantom", Price = 3500, Category = Category.Old },
        };

        //var groupingProductsMS = products.GroupBy(p => p.Category)
        //                               .OrderByDescending(p => p.Key.ToString())
        //                               .Select(p => new
        //                               {
        //                                   Key = p.Key,
        //                                   Products = p.OrderBy(x => x.Name)
        //                               });

        //var groupingProductsQS = from p in products
        //                         group p by p.Category into groupCategory
        //                         orderby groupCategory.Key.ToString() descending
        //                         select new
        //                         {
        //                             Key = groupCategory.Key,
        //                             Products = groupCategory.OrderBy(x => x.Name)
        //                         };

        foreach (var item in "abcdefghijklmonpqrstuvwxyz")
        {
            var groupingProductsMS = products.GroupBy(x => x.Name.ToLower().Where(x => x == item).Select(x => x).Count())
                                        .OrderByDescending(x => x.Key)
                                        .ThenByDescending(x => x.Key.ToString());

            foreach (var product in groupingProductsMS)
            {
                Console.WriteLine(item+"=>"+product.Key);

                foreach (var item1 in product)
                {
                    Console.WriteLine("  " + item1.Name);
                }
            }
        }
       
        //int[] ints = { 2,6, 10, 5, 2, 3, 21, 4, 13, 5, 6, 77, 7, 8 };

        //Console.WriteLine(ints.Aggregate((a, b) => (a + b)));
        //Console.WriteLine(ints.Sum(n=>n/2+1));
        //int count = products.Sum(p => p.Name.Length);
        //Console.WriteLine(count);
        // products.Reverse();

        //var res = from product in products
        //          orderby product.Name, product.Id descending
        //          select product;


        //foreach (var item in res)
        //{
        //    Console.WriteLine(item.Name+" Id:"+ item.Id);
        //}
    }

}
