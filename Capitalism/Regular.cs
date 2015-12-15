namespace Interfaces
{
    public class Regular : Employee
    {
        public Regular(string firsdtname, string lastName, Deparment department)
            : base(firsdtname, lastName, department)
        {
        }

        public Regular(string firsdtname, string lastName)
            : base(firsdtname, lastName)
        {
        }
    }
}
