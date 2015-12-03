
namespace Learning_System
{
    public class Person
    {
        private string fName;
        private string lastName;
        private int age;

        public Person(string fName, string lastName, int age)
        {
            this.fName = fName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            get { return this.FirstName; }
            set
            {
                this.fName = value;
            }
        }

        public string SecondName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            return this.fName + " " + this.SecondName + " " + "\n Age: " + this.age;
        }
    }
}
