using G3_Modul2.Linq.Joins;

namespace G3_Modul2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JoinOperators.StartJoin();

            //    List<Person> persons = new List<Person>
            //{
            //    new Person { Name = "John", Age = 25, City = "New York" },
            //    new Person { Name = "Alice", Age = 30, City = "London" },
            //    new Person { Name = "Mike", Age = 20, City = "Paris" }
            //};

            //    // Create a list of pets
            //    List<Pet> pets = new List<Pet>
            //{
            //    new Pet { Name = "Max", Owner = "John" },
            //    new Pet { Name = "Charlie", Owner = "Alice" },
            //    new Pet { Name = "Bella", Owner = "Mike" },
            //    new Pet { Name = "Lucy", Owner = "Alice" }
            //};

            //    // Perform a group join to match persons with their pets
            //    var query = from person in persons
            //                join pet in pets on person.Name equals pet.Owner 
            //                into petGroup
            //                select new {Person=person, Pets = petGroup };

            //    var queryMS = persons.GroupJoin(pets,
            //                         p => p.Name,
            //                         pet => pet.Owner,
            //                         (person, pet) => new
            //                         {
            //                             Person = person,
            //                             Pets = pet
            //                         }); 

            //    // Display the results
            //    foreach (var result in queryMS)
            //    {
            //        Console.WriteLine($"Person: {result.Person.Name} (Age: {result.Person.Age}, City: {result.Person.City})");
            //        Console.WriteLine("Pets:");
            //        foreach (var pet in result.Pets)
            //        {
            //            Console.WriteLine($"- {pet.Name}");
            //        }
            //        Console.WriteLine();
            //    }
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