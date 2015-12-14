namespace Interfaces
{
    public class Salaryman : Employee
    {
        private const double SalesmanSalaryFactory =1.015;

        public Salaryman(string firsdtname, string lastName, Deparment department)
            : base(firsdtname, lastName,department)
        {
        }

        public Salaryman(string firsdtname, string lastName)
            : base(firsdtname, lastName)
        {
        }

        public override double SalaryFactor
        {
            get
            {
                return SalesmanSalaryFactory;
            }
        }
    }
}
