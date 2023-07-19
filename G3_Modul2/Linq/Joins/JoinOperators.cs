namespace G3_Modul2.Linq.Joins;

public class JoinOperators
{
    public static void StartJoin()
    {
        var students = Student.GetAllStudents();
        var subjects = Subject.GetAllSubjects();

        var studentSubjects = from student in students
                              select new
                              {
                                  student.Name,
                                  Subjects = from subject in subjects
                                             where student.Subjects.Contains(subject.ID)
                                             select subject.SubjectName
                              };

        //var CrossJoinResult = from student in Student.GetAllStudents() //First Data Source
        //                      from studentSubjectId in student.Subjects 
        //                      join subject in Subject.GetAllSubjects() //Cross Join with Second Data Source
        //                      on studentSubjectId equals subject.ID
        //                      into studentSubject
        //                      group student by student.Name
        //                      into StudentName
        //                      select new
        //                      {
        //                          StudentName = StudentName.Key,
        //                          studentSubject
        //                      };
        //Accessing the Elements using For Each Loop
        foreach (var student in studentSubjects)
        {
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine("Subjects: ");
            foreach (var subject in student.Subjects)
            {
                Console.WriteLine(subject);
            }
            Console.WriteLine();
        }
        Console.ReadLine();

        //Add for git ignore test

        //var GroupJoinMS = Department.GetAllDepartments() //Outer Data Source i.e. Departments
        //                    .GroupJoin(Employee.GetAllEmployees(), //Inner Data Source
        //                                dept => dept.ID, //Outer Key Selector  i.e. the Common Property
        //                                emp => emp.DepartmentId, //Inner Key Selector  i.e. the Common Property
        //                                (dept, emp) => new { dept, emp } //Projecting the Result to an Anonymous Type
        //                            );
        //foreach (var item in GroupJoinMS)
        //{
        //    Console.WriteLine("Department :" + item.dept.Name);
        //    foreach (var employee in item.emp)
        //    {
        //        Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
        //    }
        //}
        //Console.ReadLine();
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int SubjectID { get; set; }
        public static List<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student { ID = 1, Name = "Preety", SubjectID=1 },
                new Student { ID = 2, Name = "Priyanka",SubjectID=2},
                new Student { ID = 3, Name = "Anurag",SubjectID=4},
                new Student { ID = 4, Name = "Pranaya",SubjectID=6},
                new Student { ID = 5, Name = "Hina",SubjectID=10},
                new Student { ID = 6, Name = "Kumar",SubjectID=7}
            };
        }
    }
    public class Subject
    {
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public static List<Subject> GetAllSubjects()
        {
            return new List<Subject>()
            {
                new Subject { ID = 1, SubjectName = "ASP.NET"},
                new Subject { ID = 2, SubjectName = "SQL Server" },
                new Subject { ID = 3, SubjectName = "My SQL" },
                new Subject { ID = 4, SubjectName = "MongoDB" },
                new Subject { ID = 5, SubjectName = "Linq"},
                new Subject { ID = 6, SubjectName = "Java" },
            };
        }
    }
}
