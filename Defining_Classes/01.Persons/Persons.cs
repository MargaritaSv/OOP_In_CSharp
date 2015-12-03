using System;

namespace _01.Persons
{
    class Persons
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();
            Console.WriteLine("Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            Person p1 = new Person(name, age, email);
            Console.WriteLine(p1);

        }
    }
}
