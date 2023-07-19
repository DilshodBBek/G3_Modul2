using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Modul2.WorkingWithFiles
{
    internal class Homework
    {
        public Homework()
        {
            Do();
        }
        public void Do()
        {
            string name;
            Console.Write("Enter : ");
            name = Console.ReadLine();

            string path = "D:\\C#\\codes\\Projects\\fayl";

            List<string> natija = new List<string>();

            natija = Check(name, path, natija);

            Console.WriteLine("Natija");

            foreach (string item in natija)
            {
                Console.WriteLine(item);
            }

            ///string path = "C:/folder1/folder2/file.txt";

        }
        public List<string> Check(string name, string adress, List<string> Result)
        {
            List<string> files = Directory.GetFileSystemEntries(adress).ToList();
            List<string> catalogs = Directory.GetDirectories(adress).ToList();
            List<string> names = new List<string>();

            for (int i = 0; i < files.Count; i++)
            {
                names.Add(new DirectoryInfo(files[i]).Name);
                if (names[i].Contains(name))
                {
                    Result.Add(files[i]);
                }
            }

            if (catalogs.Count > 0)
            {
                for (int i = 0; i < catalogs.Count; i++)
                {
                    Check(name, catalogs[i], Result);
                }
            }

            return Result;
        }
    }
}
