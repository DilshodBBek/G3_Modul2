namespace G3_Modul2.Linq
{
    public static class Startup
    {
        public static void Run()
        {
            //var res1 = from emp in Employee.GetAllEmployees()
            //           //from project in emp.Projects
            //           select new
            //           {
            //               emp.FirstName,
            //               emp.LastName,
            //               Project = emp.Projects.SelectMany(s=>s)
            //           };

            //Print(res1);
            //List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////Method Syntax
            //IEnumerable<int> filteredData = intList.Where(num => num > 5);
            ////Query Syntax
            //IEnumerable<int> filteredResult = from num in intList
            //                                  where num > 5
            //                                  select num;

            //foreach (int number in filteredResult)
            //{
            //    Console.WriteLine(number);
            //}

            //var res = Employee.GetEmployees().Where(emp => emp.FirstName.Length > 5
            //                                               && emp.ID>102)
                                             
            //                                 .Select(x => x).ToList();

            //res.ForEach(x => Console.WriteLine(x));

            //List<Employee> queryRes = (from emp in Employee.GetEmployees()
            //                           where emp.FirstName.Length > 5 & emp.ID>102
            //                           select emp).ToList();

            //queryRes.ForEach(x => Console.WriteLine(x));



        }

        private static void SelectMany()
        {
            List<List<string>> Person = new()
            {
             new() {"Alex", "John", "Lisa", "Tom"},
             new() {"Tom", "Jerry", "Panda", "Duck"}
            };

            IEnumerable<string> methodSyntax = Person.SelectMany(x => x);// x.Select(s=> "Child" + s + " "));

            foreach (string c in methodSyntax)
            {
                Console.WriteLine(c);
            }

            IEnumerable<string> querySyntax = from array in Person
                                              from str in array
                                              select "child" + str + " ";

            Print(querySyntax);
        }

        private static void Print(IEnumerable<dynamic> querySyntax)
        {
            foreach (var c in querySyntax)
            {
                Console.WriteLine(c);
            }
        }

        private static void SelectLinq()
        {
            //List<Employee> employees = Employee.GetEmployees();

            //List<string> selectedEmployee = new();

            //foreach (Employee employee in employees)
            //{
            //    selectedEmployee.Add(employee.FirstName + " " + employee.LastName);
            //    Console.WriteLine(employee.FirstName + " " + employee.LastName);
            //}


            //  employees.Select(x =>x.FirstName+" " + x.LastName);


            //List<string> emps = (from emp in employees
            //                           select emp.FirstName + " " + emp.LastName).ToList();

            //var selectQuery = (from emp in Employee.GetEmployees()
            //                   select new
            //                   {
            //                       FirstName = emp.FirstName,
            //                       LastName = emp.LastName,
            //                       Salary = emp.Salary
            //                   });

            //foreach (var emp in selectQuery)
            //{
            //    Console.WriteLine(emp);
            //}
            Console.WriteLine("=======================================");

            //var selectMethod = Employee.GetEmployees().
            //                          Select(emp => new
            //                          {
            //                              FirstName = emp.FirstName,
            //                              LastName = emp.LastName,
            //                              //Salary = emp.Salary
            //                          }).ToList();

            //foreach (var item in selectMethod)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
