
namespace Learning_System
{
    class Students : Person
    {
        private int studentNumber;
        private double avgGraduate;

        public Students(string fName, string secName, int age, int number, double avgGraduate)
            : base(fName, secName, age)
        {
            this.studentNumber = number;
            this.avgGraduate = avgGraduate;
        }

        public int StudentNumber
        {
            get { return this.studentNumber; }
            set { this.studentNumber = value; }
        }

        public double AverageGrade
        {
            get { return this.avgGraduate; }
            set { this.avgGraduate = value; }
        }

        public override string ToString()
        {
            return "Person: " + this.GetType().Name + "\n" + base.ToString() + " Students number: " + this.StudentNumber + " Average grade - " + this.AverageGrade;
        }
    }
}
