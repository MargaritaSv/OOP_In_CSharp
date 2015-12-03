using System;

namespace Learning_System
{
    public class Trainer : Person
    {
        public Trainer(string fName,string secName,int age)
            :base(fName,secName,age)
        {
        }

        public void CreatCourse(string creatCourse)
        {
            Console.WriteLine("The course name is: ",creatCourse);
        }

        public override string ToString()
        {
            return " Position: " + GetType().Name + "\n" + base.ToString();
        }
    }
}
