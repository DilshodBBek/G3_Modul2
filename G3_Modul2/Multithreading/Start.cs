namespace G3_Modul2.Multithreading
{
    public class Start
    {
        public static Task<int> Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                 Task.Delay(TimeSpan.FromSeconds(1));
            }

            return Task.FromResult(5);
        }

    }
}
