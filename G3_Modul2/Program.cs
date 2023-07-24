using G3_Modul2.Multithreading;
using System.Diagnostics;

namespace G3_Modul2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
           // List<Task<int>> tasks= new List<Task<int>>();   
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //tasks.Add(Start.Run());
            //tasks.Add(Start.Run());
            //tasks.Add(Start.Run());
            //tasks.Add(Start.Run());
            //tasks.Add(Start.Run());
            //tasks.Add(Start.Run());

            //Task<int[]> res = Task.WhenAll(tasks);
            Task<int> res1 = Start.Run();
            Task<int> res2 = Start.Run();
            Task<int> res3 = Start.Run();
            Task<int> res4 = Start.Run();
            //foreach (int task in res.Result)
            //{
            //    Console.WriteLine(task);
            //}

            //Console.WriteLine(await res);
            Console.WriteLine(res1.Result);
            Console.WriteLine(res2.Result);
            Console.WriteLine(res3.Result);
            Console.WriteLine( res4.Result);
            sw.Stop();
            Console.WriteLine("Main finished:"+sw.ElapsedMilliseconds);
        }
        public static void MethodWithThread()
        {
            for (int i = 0; i < 1000; i++)
            {
                //Thread thread = new(Test);
                //thread.Start();
            }
        }
        public static void MethodWithThreadPool()
        {
            for (int i = 0; i < 1000; i++)
            {
                //   ThreadPool.QueueUserWorkItem(new WaitCallback(Test));
            }
        }
        public static async Task Test(object? obj = null)
        {
            Thread.Sleep(1000);
        }
        public static async Task<int> Do()
        {
            await Test(null);
            Console.WriteLine("sddsf");
            return 5;
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

    public class Pet
    {
        public string Name { get; set; }
        public string Owner { get; set; }
    }
}