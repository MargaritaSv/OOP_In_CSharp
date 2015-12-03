using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// SULT TEST
/// </summary>
namespace Learning_System
{
    class Learning_System
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Ivan", "Ivanova", 11));
            people.Add(new Person("Terry", "Kalkalova", 26));
            people.Add(new Students("Dragan", "Draganov", 33, 3456, 4.50));
            people.Add(new Students("Nikola", "Nikolov", 23, 2659, 3.50));
            people.Add(new CurrentStudents("Petar", "Nikolov", 23, 1259, 3.50, "OOP"));
            people.Add(new CurrentStudents("Petar", "Draganov", 23, 1659, 3.50, "Databases"));
            people.Add(new GraduatedStudents("Ivan", "Petrov", 30, 7659, 4.50));
            people.Add(new DropoutStudents("Petar", "Ivanov", 20, 2623, 3.50, "drinking and gambling"));
            people.Add(new Trainer("Dragan", "Ivanov", 18));
            people.Add(new Trainer("Petar", "NIkolov", 18));
            people.Add(new SeniorTrainer("Dragan", "Petrov", 19));
            people.Add(new JuniorTrainer("Ivan", "Draganov", 19));
            people.Add(new OnlineStudents("Dragan", "Nikolov", 19, 9876, 5.50, "OOP"));
            people.Add(new OnlineStudents("Nikola", "Petrov", 23, 1234, 3.35, "Databases"));
            people.Add(new OnlineStudents("Nikola", "Ivanov", 25, 2341, 4.80, "JavaScript Applications"));
            people.Add(new OnsiteStudents("Nikola", "Draganov", 24, 1235, 3.95, "Java Basics"));

            var currentSt = people.Where(x => x is CurrentStudents).OrderBy(x => ((Students)x).AverageGrade).Select(x => x);

            foreach (var x in currentSt)
            {
                Console.WriteLine(x);
            }
        }
    }
}
