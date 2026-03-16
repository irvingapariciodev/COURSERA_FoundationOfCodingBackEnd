using Pastel;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using static Program.ToDoList;

public class Program
{
    const string applicationName = "Welcome to Coursera - Foundation Of Coding Back-End App.";
    const string application1Name = "Greeting message - First Hello World.";
    const string application2Name = "Show variables.";
    const string application3Name = "Assign and reference variables.";
    const string application4Name = "ToDoList";
    const string application5Name = "Animal";
    const string application6Name = "Polimorphism";
    const string application7Name = "Inheritance";
    const string application8Name = "Person";
    const string application9Name = "Student grades management system";
    const string application10Name = "Exit";

    private static List<Student> studentList = [];
    private static List<Dictionary<string, int?>> studentGradeList = [];
    private static void Main(string[] args)
    {
        Console.WriteLine(applicationName);

        bool openMenubar = true;
        while (openMenubar)
        {
            DisplayMenu();
            BreakLine();

            string optionSelected = Console.ReadLine();
            int menuSelected = 0;
            openMenubar = int.TryParse(optionSelected, out menuSelected);

            switch (menuSelected)
            {
                /// <summary>
                /// Gretting message.
                /// </summary>
                case 1:
                    Console.WriteLine($"You selected: {GetMenuOptionSelected(menuSelected)}");
                    Console.WriteLine("Hello World!");
                    break;
                /// <summary>
                /// Show multiple types of variables available in .NET C#.
                /// </summary>
                case 2:
                    Console.WriteLine($"You selected: {GetMenuOptionSelected(menuSelected)}");
                    Boolean flag = true;
                    Console.WriteLine(flag);

                    byte number1 = 1;
                    Console.WriteLine(number1 + " Size of byte: " + sizeof(byte));

                    Char letter1 = 'a';
                    Console.WriteLine(letter1);

                    DateTime datetime1 = DateTime.Now;
                    Console.WriteLine(datetime1);

                    Decimal number2 = 2.0m;
                    Console.WriteLine(number2 + " Size of Decimal: " + sizeof(Decimal));

                    Double number3 = 22336655447788.112233665577;
                    Console.WriteLine(number3 + " Size of Double: " + sizeof(Double));

                    Int16 number4 = 10365;
                    Console.WriteLine(number4 + " Size of Int16: " + sizeof(Int16));

                    Int32 number5 = 1036510365;
                    Console.WriteLine(number5 + " Size of Int32: " + sizeof(Int32));

                    Int64 number6 = 1036510365103651036;
                    Console.WriteLine(number6 + " Size of Int64: " + sizeof(Int64));

                    String cadenaTexto = "Prueba";
                    Console.WriteLine(cadenaTexto);

                    float number7 = 15.6f;
                    Console.WriteLine(number7 + " Size of float: " + sizeof(float));
                    break;
                /// <summary>
                /// How to assign and reference variables..
                /// </summary>
                case 3:
                    Console.WriteLine($"You selected: {GetMenuOptionSelected(menuSelected)}");
                    Int16 number10 = 50;
                    Int16 number11 = 60;

                    Console.WriteLine("Numero A: " + number10 + " Number B: " + number11);

                    Console.WriteLine("Modificacion de numeros");
                    number10 = number11;
                    Console.WriteLine("Numero A: " + number10 + " Number B: " + number11);
                    break;
                /// <summary>
                /// Create a ToDo list where adding, viewing, complete task are available.
                /// </summary>
                /// <param name="ToDoList">.</param>
                /// <param name="ID">.</param>
                /// <param name="Completed">.</param>"
                case 4:
                    Console.WriteLine($"You selected: {application4Name}");
                    ToDoList toDoList = new ToDoList();
                    Boolean TodoListMenu = true;
                    while (TodoListMenu)
                    {
                        Console.WriteLine("\nWelcome to the To-Do List Application".Pastel(Color.Magenta));
                        Console.WriteLine("1. Add Task".Pastel(Color.LightBlue));
                        Console.WriteLine("2. View Tasks".Pastel(Color.LightBlue));
                        Console.WriteLine("3. Complete Task".Pastel(Color.LightBlue));
                        Console.WriteLine("4. Exit".Pastel(Color.LightBlue));
                        Console.Write("Choose an option: ".Pastel(Color.Yellow));

                        string choice = Console.ReadLine();

                        if (choice == null || choice.Trim() == "")
                        {
                            Console.WriteLine("Please enter a valid option.".Pastel(Color.Red));
                            continue;
                        }

                        switch (choice)
                        {
                            case "1":
                                Console.Write("Enter task description: ".Pastel(Color.Yellow));
                                string task = Console.ReadLine();
                                toDoList.AddTask(task);
                                break;
                            case "2":
                                toDoList.ViewTasks();
                                break;
                            case "3":
                                Console.Write("Enter task number to complete: ".Pastel(Color.Yellow));
                                if (int.TryParse(Console.ReadLine(), out int taskNumber))
                                {
                                    toDoList.CompleteTask(taskNumber);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input.".Pastel(Color.Red));
                                }
                                break;
                            case "4":
                                Console.WriteLine("Exiting application. Goodbye!".Pastel(Color.Green));
                                TodoListMenu = false;
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.".Pastel(Color.Red));
                                break;
                        }
                    }
                    break;
                /// <summary>
                /// Create animal with two parameters and a method.
                /// </summary>
                ///  <param name="Name">Store the animal name.</param>
                /// <param name="Age">Store the animal age.</param>
                case 5:
                    Console.WriteLine($"You selected: {application5Name}");
                    var animal = new Animal
                    {
                        Name = "Buddy",
                        Age = 3
                    };
                    animal.MakeSound();
                    break;
                /// <summary>
                /// Apply concepts for Inheritance in POO.
                /// </summary>
                case 6:
                    Console.WriteLine($"You selected: {application6Name}");
                    Dog dog = new Dog
                    {
                        Name = "Rex",
                        Age = 5
                    };
                    Cat cat = new Cat
                    {
                        Name = "Whiskers",
                        Age = 2
                    };
                    dog.MakeSound();
                    cat.MakeSound();
                    break;
                /// <summary>
                /// Apply concepts for Polimorphism in POO.
                /// </summary>
                case 7:
                    Console.WriteLine($"You selected: {application7Name}");
                    List<IAnimal> animals = new List<IAnimal>
                        {
                            new Dog { Name = "Rex", Age = 5 },
                            new Cat { Name = "Whiskers", Age = 2 }
                        };
                    foreach (var item in animals)
                    {
                        Console.WriteLine($"{item.GetType().Name} named {((Animal)item).Name} is about to eat.".Pastel(Color.Orange));
                    }
                    break;
                /// <summary>
                /// Apply concepts  in POO.
                /// </summary>
                ///  <param name="Name">Store the person name.</param>
                /// <param name="Age">Store the person age.</param>
                case 8:
                    Console.WriteLine($"You selected: {application8Name}");
                    Person person = new Person("Alice", 30);
                    person.Introduce();

                    Person person2 = new Person("Bob", 25);
                    person2.Introduce();
                    break;
                /// <summary>
                /// Student grades management system.
                /// </summary>
                case 9:
                    Console.WriteLine($"You selected: {application9Name}");

                    Console.WriteLine("STUDENT GRADES MANAGEMENT SYSTEM\n\n");
                    bool exitSystem = false;

                    while (!exitSystem)
                    {
                        Console.WriteLine($"Please, select one of the following options:\r\n1 - ADD STUDENTS\r\n2 - ASSIGN GRADES\r\n3 - CALCULATE AVERAGE\r\n4 - DISPLAY STUDENT RECORDS\r\n5 - EXIT\n\n");

                        if (int.TryParse(Console.ReadLine(), out int studentMenuOptionSelected))
                        {
                            switch (studentMenuOptionSelected)
                            {
                                case 1:
                                    AddStudent();
                                    break;
                                case 2:
                                    AddGradesForStudent();
                                    break;
                                case 3:
                                    CalculareAverageForStudent();
                                    break;
                                case 4:
                                    ShowRecordsForStudent();
                                    break;
                                case 5:
                                    exitSystem = true;
                                    break;
                                default:
                                    Console.WriteLine("Invalid option selected, please enter a valid number.");
                                    break;
                            }
                        }
                    }
                    break;
                /// <summary>
                /// Exit the main menu.
                /// </summary>
                case 10:
                    Console.WriteLine($"You selected: {application10Name}");
                    openMenubar = false;
                    break;
                /// <summary>
                /// Invalid selection user input to display the menu.
                /// </summary>
                default:
                    Console.WriteLine("Please enter a valid entry.\n");
                    openMenubar = true;
                    break;
            }
        }
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the options in the main menu:");
        Console.WriteLine($"1 -{application1Name}");
        Console.WriteLine($"2 -{application2Name} ");
        Console.WriteLine($"3 -{application3Name} ");
        Console.WriteLine($"4 -{application4Name.Pastel(Color.LightBlue)} ");
        Console.WriteLine($"5 -{application5Name.Pastel(Color.LightBlue)} ");
        Console.WriteLine($"6 -{application6Name.Pastel(Color.LightBlue)} ");
        Console.WriteLine($"7 -{application7Name.Pastel(Color.LightBlue)} ");
        Console.WriteLine($"8 -{application8Name.Pastel(Color.LightBlue)} ");
        Console.WriteLine($"9 -{application9Name} ");
        Console.WriteLine($"10 -{application10Name} ");
        Console.WriteLine($"\n");
    }

    public static void BreakLine()
    {
        Console.WriteLine($"\n");
    }

    public static string GetMenuOptionSelected(int menuSelected)
    {
        string menuSelectedString = String.Empty;

        switch (menuSelected)
        {
            case 1:
                menuSelectedString = application1Name;
                break;
            case 2:
                menuSelectedString = application2Name;
                break;
            case 3:
                menuSelectedString = application3Name;
                break;
            case 4:
                menuSelectedString = application4Name;
                break;
            case 5:
                menuSelectedString = application5Name;
                break;
            case 6:
                menuSelectedString = application6Name;
                break;
            case 7:
                menuSelectedString = application7Name;
                break;
            case 8:
                menuSelectedString = application8Name;
                break;
            case 9:
                menuSelectedString = application9Name;
                break;
            case 10:
                menuSelectedString = application10Name;
                break;
        }

        return menuSelectedString;
    }

    public class ToDoList
    {
        string[] tasks = new string[10];
        int taskCount = 0;

        public void AddTask(string task)
        {
            if (taskCount < tasks.Length)
            {
                tasks[taskCount] = task;
                taskCount++;
                Console.WriteLine("Task added successfully.".Pastel(Color.Green));
            }
            else
            {
                Console.WriteLine("Task list is full.".Pastel(Color.Red));
            }
        }

        public void ViewTasks()
        {
            if (taskCount == 0)
            {
                Console.WriteLine("No tasks available.".Pastel(Color.Yellow));
                return;
            }

            Console.WriteLine("Your Tasks:".Pastel(Color.Cyan));
            for (int i = 0; i < taskCount; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}".Pastel(Color.White));
            }
        }

        public void CompleteTask(int taskNumber)
        {
            if (taskNumber < 1 || taskNumber > taskCount)
            {
                Console.WriteLine("Invalid task number.".Pastel(Color.Red));
                return;
            }

            for (int i = taskNumber - 1; i < taskCount - 1; i++)
            {
                tasks[i] = tasks[i + 1];
            }
            tasks[taskCount - 1] = null;
            taskCount--;
            Console.WriteLine("Task completed successfully.".Pastel(Color.Green));
        }

        public class Animal : IAnimal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public virtual void MakeSound()
            {
                Console.WriteLine("The animal makes a sound.".Pastel(Color.Orange));
            }

            public void Eat()
            {
                Console.WriteLine($"{Name} is eating.".Pastel(Color.Green));
            }
        }

        public interface IAnimal
        {
            void Eat();
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Woof! Woof!".Pastel(Color.Brown));
            }
        }

        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow! Meow!".Pastel(Color.Purple));
            }
        }

        public class Person
        {
            public string FirstName { get; set; }
            public Int64 Age { get; set; }

            public void Introduce()
            {
                Console.WriteLine($"Hello, my name is {FirstName} and I'm  {Age} years old.".Pastel(Color.Teal));
            }

            public Person(string firstName, Int64 age)
            {
                FirstName = firstName;
                Age = age;
            }
        }

        public class Student
        {
            public string? Name { get; set; }
            public int? Id { get; set; }
            public List<Dictionary<string, int?>> gradesSubject { get; set; } = [];
        }

        public static void AddStudent()
        {
            string? studentName = string.Empty;
            string? studentId = string.Empty;
            var student = new Student();

            Console.WriteLine("Please, type the name of the student.");
            studentName = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(studentName))
            {
                Console.WriteLine("Student name cannot be empty. Please try again.\n\n");
                return;
            }
            else
            {
                Console.WriteLine("Please, type the ID for the students (no letters.)");
                studentId = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(studentId))
                {
                    Console.WriteLine("Student ID cannot be empty.Please try again.\n\n");
                    return;
                }
                else if (Regex.IsMatch(studentId, "[A-Za-z]"))
                {
                    Console.WriteLine("Student ID only accepts numbers.Please try again.\n\n");
                    return;
                }
                else
                {
                    if (DoesStudentExists(int.Parse(studentId)))
                    {
                        Console.WriteLine("Student ID already exists.Please try again.\n\n");
                        return;
                    }
                    else
                    {
                        student = new Student
                        {
                            Name = studentName,
                            Id = int.Parse(studentId)
                        };
                        studentList.Add(student);
                        Console.WriteLine($"Student {student.Name} with ID {student.Id} added successfully.\n");
                    }
                }
            }
        }

        public static void AddGradesForStudent()
        {
            Console.WriteLine("Please, enter your ID");
            string? studentId = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(studentId))
            {
                Console.WriteLine("ID cannot be empty. Please try again.");
                return;
            }
            else
            {
                if (studentList == null || studentList.Count == 0)
                {
                    Console.WriteLine("No students found. Please add students first.\n\n");
                    return;
                }
                else if (Regex.IsMatch(studentId, "[A-Za-z]"))
                {
                    Console.WriteLine("Student ID only accepts numbers.Please try again.\n\n");
                    return;
                }
                else
                {
                    var student = studentList.FirstOrDefault(s => s.Id == int.Parse(studentId));
                    if (student == null)
                    {
                        Console.WriteLine("No student was found. Please try again.\n");
                        return;
                    }

                    Console.WriteLine("Please, enter the grade for Math (from 1 to 10):");
                    if (!int.TryParse(Console.ReadLine()?.Trim(), out int gradeMath) || gradeMath < 1 || gradeMath > 10)
                    {
                        Console.WriteLine("Invalid grade. Must be a number from 1 to 10.\n");
                        return;
                    }

                    Console.WriteLine("Please, enter the grade for English (from 1 to 10):");
                    if (!int.TryParse(Console.ReadLine()?.Trim(), out int gradeEnglish) || gradeEnglish < 1 || gradeEnglish > 10)
                    {
                        Console.WriteLine("Invalid grade. Must be a number from 1 to 10.\n");
                        return;
                    }

                    var grades = new Dictionary<string, int?>
                {
                    { "Math", gradeMath },
                    { "English", gradeEnglish }
                };
                    student.gradesSubject.Add(grades);
                    Console.WriteLine($"Grades were added successfully for {student.Name} (ID: {student.Id}).\n");
                }
            }
        }

        public static void CalculareAverageForStudent()
        {
            Console.WriteLine("Please, enter your ID");
            string? studentId = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(studentId))
            {
                Console.WriteLine("ID cannot be empty. Please try again.");
                return;
            }
            else
            {
                if (studentList == null || studentList.Count == 0)
                {
                    Console.WriteLine("No students found. Please add students first.\n\n");
                    return;
                }
                else if (Regex.IsMatch(studentId, "[A-Za-z]"))
                {
                    Console.WriteLine("Student ID only accepts numbers.Please try again.\n\n");
                    return;
                }
                else
                {
                    var student = studentList.FirstOrDefault(s => s.Id == int.Parse(studentId));
                    if (student == null)
                    {
                        Console.WriteLine("No student was found. Please try again.\n");
                        return;
                    }

                    if (student.gradesSubject == null || student.gradesSubject.Count == 0)
                    {
                        Console.WriteLine("No grades found for this student. Please add grades first.\n");
                        return;
                    }

                    double totalGrades = 0;
                    int count = 0;

                    foreach (var gradeDict in student.gradesSubject)
                    {
                        foreach (var subject in gradeDict)
                        {
                            if (subject.Value.HasValue)
                            {
                                totalGrades += subject.Value.Value;
                                count++;
                            }
                        }
                    }

                    if (count > 0)
                    {
                        double average = totalGrades / count;
                        Console.WriteLine($"Average grade for student {student.Name} (ID: {student.Id}) is: {average:F2}\n");
                    }
                    else
                    {
                        Console.WriteLine("No valid grades found to calculate average.\n");
                    }
                }
            }
        }

        public static void ShowRecordsForStudent()
        {
            Console.WriteLine("Please, enter your ID");
            string? studentId = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(studentId))
            {
                Console.WriteLine("ID cannot be empty. Please try again.");
                return;
            }
            else
            {
                if (studentList == null || studentList.Count == 0)
                {
                    Console.WriteLine("No students found. Please add students first.\n\n");
                    return;
                }
                else if (Regex.IsMatch(studentId, "[A-Za-z]"))
                {
                    Console.WriteLine("Student ID only accepts numbers.Please try again.\n\n");
                    return;
                }
                else
                {
                    var student = studentList.FirstOrDefault(s => s.Id == int.Parse(studentId));
                    if (student == null)
                    {
                        Console.WriteLine("No student was found. Please try again.\n");
                        return;
                    }

                    if (student.gradesSubject == null || student.gradesSubject.Count == 0)
                    {
                        Console.WriteLine("No grades found for this student. Please add grades first.\n");
                        return;
                    }

                    Console.WriteLine($"\nStudent ID: {student.Id}, Name: {student.Name}");
                    foreach (var grades in student.gradesSubject)
                    {
                        foreach (var subject in grades)
                        {
                            Console.WriteLine($"Subject: {subject.Key}, Grade: {subject.Value}");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        public static bool DoesStudentExists(int studentId)
        {
            bool studentExists = false;

            foreach (var student in studentList)
            {
                if (student.Id == studentId)
                {
                    studentExists = true;
                }
            }

            return studentExists;
        }
    }
}