using System;

namespace lab6

{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Computer Science");
            Department d2 = new Department("Electrical Engineering");

            Student s1 = new Student("riya", "0012", 3.50);
            Student s2 = new Student("tanvir", "65765", 3.70);
            Student s3 = new Student("Rahim", "5757", 3.02);
            Student s4 = new Student("musfiq", "57348", 3.92);

            d1.AddStudent(s1, s2);
            d2.AddStudent(s3);
            d2.AddStudent(s4);

            d1.PrintStudent();
            d2.PrintStudent();

            Console.ReadLine();
        }
    }
}