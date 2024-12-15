namespace StudentManagementSystem{
    public class Student{
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade{get; set;}

        public Student(string name, int age, double grade){
            Name = name;
            Age = age;
            Grade = grade;
        }
        public override string ToString(){
            return $"Name: {Name}, Age: {Age}, Grade: {Grade}";
        }
    }

    class Program{
        public delegate void Sortstudents(List<Student> students);

        static void Main(){
            List<Student> students = new List<Student>();

            AddStudent(students, "Alice",20,3.8);
            AddStudent(students, "Bob", 21, 3.9);
            AddStudent(students, "Charlie", 19, 3.7);
            AddStudent(students, "David", 20, 3.6);
            AddStudent(students, "Eve", 21, 3.5);

            bool exit= false;

            while(!exit){
                try{
                    Console.WriteLine("-----STUDENT MANAGEMENT SYSTEM-----");
                    Console.WriteLine("1. Display All students");
                    Console.WriteLine("2. Filter students (Grade > 3.0)");
                    Console.WriteLine("3. SOrt students by Name");
                    Console.WriteLine("4. Sort Students by Grade");
                    Console.WriteLine("5. Add new Student");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("Enter your choice..");
                    int choice= int.Parse(Console.ReadLine());

                    switch(choice){
                        case 1:
                        DisplayStudents(students);
                        break;

                        case 2:
                        FilterStudents(students);
                        break;

                        case 3:
                        Sortstudents sortByname = list => list.Sort((s1,s2)=> s1.Name.CompareTo(s2.Name));
                        sortByname(students);
                        Console.WriteLine("\n Students:");
                        DisplayStudents(students);
                        break;

                        case 4:
                        Sortstudents sortByGrade = list => list.Sort((s1,s2)=> s2.Grade.CompareTo(s1.Grade));
                        sortByGrade(students);
                        Console.WriteLine("\n Students:");
                        DisplayStudents(students);
                        break;

                        case 5:
                        Console.WriteLine("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter  Age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Grade: ");
                        double grade= double.Parse(Console.ReadLine());

                        AddStudent(students, name, age, grade);
                        break;

                        case 6:
                        exit = true;
                        Console.WriteLine("Exiting....");
                        break;

                        default:
                        Console.WriteLine("Invalid choice");
                        break;

                    }
                }
                catch(FormatException e){
                    Console.WriteLine("Error: " + e.Message);
                }catch(Exception e){
                    Console.WriteLine("An error occured: "+ e.Message);
                }
            }

            static void AddStudent(List<Student> students, string name, int age, double grade){
                try{
                    students.Add(new Student(name,age,grade));
                    Console.WriteLine("Student added successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to add student: {ex.Message}");
                }
            }
            static void DisplayStudents(List<Student> students)
            {
                Console.WriteLine("\nList of Students:");
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }

            static void FilterStudents(List<Student> students){
                var filteredStudents = students.Where(s => s.Grade > 3.0).ToList();

                Console.WriteLine("\nStudents with Grade > 3.0:");
                foreach (var student in filteredStudents)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}