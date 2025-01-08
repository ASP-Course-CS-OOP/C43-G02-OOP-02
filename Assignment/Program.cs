using System.Transactions;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            #region 2- Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.Write("Enter coordinate(X) of point 1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter coordinate(Y) of point 1: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine();

            //Console.Write("Enter coordinate(X) of point 2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter coordinate(Y) of point 2: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //Point p1 = new Point(x1, y1);
            //Point p2 = new Point(x2, y2);

            //double distance = p1.Distance(p2);

            //Console.WriteLine();

            //Console.WriteLine($"Distance between the points: {distance:F3}");
            #endregion

            #region 3- Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] persons = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter Data Of Person {i + 1} => ");
            //    Console.Write($"Name => ");
            //    string Name = Console.ReadLine()!;
            //    Console.Write($"Age => ");
            //    int.TryParse(Console.ReadLine(), out int age);

            //    persons[i] = new Person(Name, age);

            //    Console.WriteLine();
            //}

            //Person oldPerson = persons[0];
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    if (persons[i].Age > oldPerson.Age)
            //    {
            //        oldPerson = persons[i];
            //    }
            //}
            //Console.WriteLine($"old person => Name: {oldPerson.Name}, Age: {oldPerson.Age}");
            #endregion



            #region Q1- Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            #region Q1.1

            //Person03 p01 = new Person03(3);
            //p01.AddPerson(1, "Eslam", 22);
            //p01.AddPerson(2, "Ahmed", 23);
            //p01.AddPerson(3, "Hany", 24);

            //p01.printPersons();  

            #endregion

            #region Q1.2

            //Person02[] p01 = new Person02[3];
            //for (int i = 0; i < p01.Length; i++)
            //{
            //    Console.WriteLine($"Enter Data Of Person {i + 1} => ");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine()!;
            //    bool isParsed;
            //    int age;
            //    do
            //    {
            //        Console.Write("Age: ");
            //        isParsed = int.TryParse(Console.ReadLine(), out age); 
            //    } while (!isParsed || age >100 || age<15 );

            //    Console.WriteLine();

            //    p01[i] = new Person02(name, age);
            //}

            //for (int i = 0; i < p01.Length; i++)
            //{
            //    Console.WriteLine($"Person {i + 1} => (Name: {p01[i].Name}, Age: {p01[i].Age})");
            //} 

            #endregion

            #endregion
        }
    }
}
