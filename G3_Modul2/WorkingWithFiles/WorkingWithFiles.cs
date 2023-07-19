using System.Text;

namespace G3_Modul2.WorkingWithFiles
{
    internal class WorkingWithFiles
    {
        static string path = @"C:\Users\User\Desktop\dotnet.png";
        static string path1 = @"C:\Users\User\Desktop\core.jpg";
        static int a = 0;
        public static void Run()
        {


            using (FileStream fileStream = new(path, FileMode.Open))
            {
                using (FileStream fileStream1 = new FileStream(path1, FileMode.Open))
                {
                    byte[] data = new byte[fileStream1.Length];
                    fileStream1.Read(data, 0, data.Length);

                    fileStream.Write(data, 0, data.Length);

                }
            }

            ////read
            //using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            //{
            //    byte[] data = new byte[fileStream.Length];
            //    fileStream.Read(data, 0, data.Length);

            //    string contents = Encoding.UTF8.GetString(data);
            //    Console.WriteLine(contents);
            //}

            ////append
            //using (FileStream fileStream = new FileStream(filePath, FileMode.Append))
            //{
            //    byte[] data = Encoding.UTF8.GetBytes(" Appended text!");
            //    fileStream.Write(data, 0, data.Length);
            //}

            //using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            //{
            //    fileStream.Seek(10, SeekOrigin.Begin); // Move to the 11th byte in the file
            //    byte[] data = new byte[10]; // Read 10 bytes from that position
            //    fileStream.Read(data, 0, data.Length);
            //    string contents = Encoding.UTF8.GetString(data);
            //    Console.WriteLine(contents);
            //}


            //string sourceFilePath = "source.txt";
            //string destinationFilePath = "destination.txt";
            //using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            //{
            //    using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            //    {
            //        sourceStream.CopyTo(destinationStream);
            //    }
            //}

            ////Reading file
            //int bufferSize = 1024;
            //byte[] buffer = new byte[bufferSize];
            //using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            //{
            //    int bytesRead;
            //    while ((bytesRead = fileStream.Read(buffer, 0, bufferSize)) > 0)
            //    {
            //        string chunk = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            //        Console.WriteLine(chunk);
            //    }
            //}


        }

        private static void MemoryStreamExamples()
        {
            MemoryStream memoryStream = new MemoryStream();

            byte[] data = File.ReadAllBytes(@"C:\Users\User\Desktop\test.txt");

            memoryStream.Write(data, 0, data.Length);

            //memoryStream.Position = 3;
            memoryStream.Seek(-6, SeekOrigin.End);
            Console.WriteLine(memoryStream.Position);

            byte[] buffer = new byte[memoryStream.Length + 6];


            memoryStream.Read(buffer, 0, buffer.Length);
            string text = System.Text.Encoding.UTF8.GetString(buffer);
            Console.WriteLine(text);

            foreach (var item in buffer)
            {
                Console.WriteLine(item);
            }

            memoryStream.Close();

            //MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(@"C:\Users\User\Desktop\test.txt"));

            //var res = await memoryStream.BeginRead(File.ReadAllBytes(@"C:\Users\User\Desktop\test.txt"), 2, 3);
            //byte[]? stream = File.ReadAllBytes(@"C:\Users\User\Desktop\test.txt");
            //foreach (var item in stream)
            //{
            //    Console.WriteLine(item);
            //}

            //memoryStream.TryGetBuffer(out var buffer);
            //Console.WriteLine(buffer.ToList());

            //byte[] bytes = memoryStream.ToArray();
            //Console.WriteLine(memoryStream.Read(bytes, 1, 2));
            //foreach (byte b in bytes)
            //{ Console.WriteLine(b); }
            //Console.WriteLine((char)memoryStream.ReadByte());
            //Console.WriteLine((char)memoryStream.ReadByte());
            //Console.WriteLine((char)memoryStream.ReadByte());
            //Console.WriteLine(memoryStream.Length);
            //var res=  memoryStream.Seek(2, SeekOrigin.End);
            //Console.WriteLine(res);
            // res = memoryStream.Seek(1, SeekOrigin.Begin);
            //Console.WriteLine(res);

            //Console.WriteLine(res);
        }

        public static void Text2File(string stringFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(stringFilePath))
            {
                string[] s = reader.ReadToEnd().Split(",");
                byte[] bytes = new byte[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    bytes[i] = Convert.ToByte(s[i]);
                }
                BytesToVideo(bytes, outputFilePath);
            }
            Console.WriteLine("done!");

        }
        public static void BytesToVideo(byte[] videoBytes, string outputFilePath)
        {
            File.WriteAllBytes(outputFilePath, videoBytes);
        }
        public static void Copy(string inputFilePath, string outputFilePath)
        {
            int bufferSize = 1024 * 1024;

            //using (FileStream fileStream = new FileStream(outputFilePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            ////using (FileStream fs = File.Open(<file-path>, FileMode.Open, FileAccess.Read, FileShare.Read))
            //{
            //    FileStream fs = new FileStream(inputFilePath, FileMode.Open, FileAccess.ReadWrite);
            //    fileStream.SetLength(fs.Length);
            //    int bytesRead = -1;
            //    byte[] bytes = new byte[bufferSize];

            //    while ((bytesRead = fs.Read(bytes, 0, bufferSize)) > 0)
            //    {
            //        fileStream.Write(bytes, 0, bytesRead);
            //    }
            //}

            using (StreamWriter fileStream = new StreamWriter(outputFilePath,true))//, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            //using (FileStream fs = File.Open(<file-path>, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                StreamReader reader = new StreamReader(inputFilePath);//, FileMode.Open, FileAccess.ReadWrite);
                //fileStream.l.SetLength(fs.Length);
                int bytesRead = -1;
                char[] bytes = new char[bufferSize];

                while ((bytesRead = reader.ReadBlock(bytes, 0, bufferSize)) > 0)
                {
                    fileStream.Write(bytes, 0, bytesRead);
                }
            }
        }

        private static void StreamReaderExamples()
        {
            using (StreamReader streamReader = new(path))
            {
                //var t = streamReader.ReadToEnd();

                char[] chars = new char[10];
                a = streamReader.ReadBlock(chars, a, chars.Length);

                //foreach (char item in chars)
                //{
                //    Console.WriteLine(item);
                //}
                chars = new char[10];
                a = streamReader.ReadBlock(chars, 0, chars.Length);
                foreach (char item in chars)
                {
                    Console.WriteLine(item);
                }
                //while (!streamReader.EndOfStream)
                //{
                //    int a = streamReader.Read();
                //    Console.Write("streamReader.Read());" + a + " =>");
                //    Console.WriteLine((char)a);
                //    // Console.WriteLine("streamReader.ReadLine())"+streamReader.ReadLine());
                //    //Console.WriteLine("streamReader.ReadToEnd()"+streamReader.ReadToEnd());
                //}
            }

            //string res= streamReader.ReadToEnd();

            //streamReader.Close();
        }

        private static void Task5()
        {
            string searchingFileName = Console.ReadLine();
            string searchingPath = @"C:\Users\User\source\repos\";

            List<string> res = Directory.GetFiles(searchingPath,
                $"*{searchingFileName}*", SearchOption.AllDirectories).ToList();

            res.AddRange(Directory.GetDirectories(searchingPath,
                $"*{searchingFileName}*", SearchOption.AllDirectories));

            foreach (var file in res)
            {
                Console.WriteLine(file);
            }
        }

        static void FindFile(string path, string fileName)
        {
            foreach (string file in Directory.GetFiles(path))
            {
                if (Path.GetFileName(file).Contains(fileName))
                    Console.WriteLine(Path.GetFileName(file) + "\t=>" + file);
            }
            foreach (string directory in Directory.GetDirectories(path))
            {
                FindFile(directory, fileName);
            }
        }

        private static void Example2()
        {
            Console.WriteLine("Matnni  kiriting:");
            string s = Console.ReadLine();
            WriteToFile(s);
            //Console.WriteLine(Path.Combine(@"C:\G3\Test", "EF Core"));
            //string path = @"C:\G3\Test\salom1.docx";

            //           File.AppendAllLines(path, new string[] {"salom", "Hello", "Privet"});


            //byte[] bytes = File.ReadAllBytes(path);
            //Console.WriteLine(Encoding.UTF8.GetString(bytes));
            //foreach (byte b in bytes)
            //{
            //    Console.Write(b);
            //}

            //FileInfo fileInfo = new FileInfo(path);


            //string[] files= Directory.GetFiles(@"C:\G3\Test\");

            // foreach (string file in files)
            // {
            //     Console.WriteLine(file);
            // }
        }

        private static void DirectoryExample()
        {
            string path = @"C:\G3\Test";

            //if (!File.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}
            //IEnumerable<string> dirs = Directory.GetDirectories(@"C:\Users\User\Desktop\3-modul vazifalar\", "", SearchOption.AllDirectories);
            //foreach (string file in dirs)
            //{
            //    Console.WriteLine(file);
            //}

            //Console.WriteLine(Directory.GetDirectoryRoot(path));
            //Console.WriteLine(Directory.GetParent(path));

            //Directory.Move(@"C:\Users\User\Desktop\3-modul vazifalar\1234", path);

            //Directory.Delete(path, true);

            DirectoryInfo directoryInfo = new(path);
        }

        private static void WriteToFile(string text)
        {
            string path = @"C:\G3\Log.txt";
            File.AppendAllLines(path, new string[] { $"Text:{text}, Date:{DateTime.Now}" });
        }
    }
}
