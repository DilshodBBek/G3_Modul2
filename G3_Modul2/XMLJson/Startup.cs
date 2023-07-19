using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace G3_Modul2.XMLJson;

public static class Startup
{
    public static void Run()
    {
        string path = "../../../DB.json";
        

        JObject o = JObject.Parse(@"{
  'Stores': [
    'Lambton Quay',
    'Willis Street'
  ],
  'Manufacturers': [
    {
      'Name': 'Acme Co',
      'Products': [
        {
          'Name': 'Anvil',
          'Price': 50
        }
      ]
    },
    {
      'Name': 'Contoso',
      'Products': [
        {
          'Name': 'Elbow Grease',
          'Price': 99.95
        },
        {
          'Name': 'Headlight Fluid',
          'Price': 4
        }
      ]
    }
  ]
}");

        Console.WriteLine(o.SelectToken("Manufacturers[1].Products[1].Name"));
        //JArray array = (JArray)o["Manufacturers"];
        //Console.WriteLine(array);
        //Console.WriteLine((JArray)array[0]["Products"][0]);


    }

    private static void Homework()
    {
        ProductService productService = new("../../../DB.json");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.Create ");
            Console.WriteLine("2.Read ");
            Console.WriteLine("3.Update ");
            Console.WriteLine("4.Delete ");
            Console.WriteLine("5.Quit ");



            string a;
            Console.Write("Enter ");
            a = Console.ReadLine();

            if (a == "1") productService.CreateProduct();
            else if (a == "2") productService.ReadProducts();
            else if (a == "3") productService.UpdateProduct();
            else if (a == "4") productService.DeleteProduct();
            else if (a == "5") break;
            Console.ReadKey();

        }
    }

    private static void LessonTask()
    {
        List<Person> people = GeneratePeople();

        string jsonPeople = JsonConvert.SerializeObject(people, Formatting.Indented);

        SaveJsonToDatabase(jsonPeople);

        List<Person> people1 = ReadPeopleFromDatabase();

        foreach (Person person in people1)
        {
            Console.WriteLine(person.ToString());
        }

        Console.ReadLine();
    }

    private static void SaveJsonToDatabase(string jsonPeople)
    {
        string path = @"C:\Users\User\Desktop\PeopleDatabase.txt";


        Console.WriteLine(jsonPeople);
        File.WriteAllText(path, jsonPeople);

        Console.WriteLine("Database was saved");
    }

    private static List<Person> ReadPeopleFromDatabase()
    {
        string path = @"C:\Users\User\Desktop\PeopleDatabase.txt";
        List<Person>? people = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(path));
        return people;
    }

    private static List<Person> GeneratePeople()
    {
        List<Person> people = new()
        {
           new Person()
           {
                FirstName = "Alex",
                Grade = "A",
                Cars = new[] {
                    new Car()
                    {
                        Name= "Maskvich"
                    },
                    new Car()
                    {
                        Name= "Onix"
                    }
                }
           },
            new Person()
            {
                Cars=new[]
                {
                    new Car { Name= "Tesla"},
                    new Car { Name= "BYD Han"}
                },
                FirstName= "Tom",
                Grade= "B"
            }
        };

        return people;
    }
}
public class Car
{
    public string Name { get; set; }
    public override string ToString()
    {
        return $"Name:{Name}";
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string Grade { get; set; }

    public Car[] Cars { get; set; }

    public override string ToString()
    {
        return $"FirstName:{FirstName}, Grade:{Grade}";
    }
}
