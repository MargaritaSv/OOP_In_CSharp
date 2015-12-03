using System;

namespace Learning_System
{
    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string fName, string secName, int age)
            : base(fName, secName, age)
        {
        }

        public void DeleteCourse(string delCourse)
        {
            Console.WriteLine(" Course has been deleted - ", delCourse);
        }
    }
}
