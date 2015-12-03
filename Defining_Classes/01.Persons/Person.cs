using System;
using System.Linq;

namespace _01.Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age) : this(name, age, null)
        {
        }

        public Person(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Enter your name");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("The age is out of range.");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {

                if (null == value || value.Length == 0 || !value.Contains('@'))
                {
                    throw new ArgumentException("Invalid e-mail");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            return string.Format(" Name: {0}\nAge: {1}\nEmail: {2}", this.Name, this.Age, this.Email ?? "is empty") + base.ToString();
        }
    }
}
