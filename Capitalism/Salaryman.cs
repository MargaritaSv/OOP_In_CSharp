namespace Interfaces
{
    public class Salaryman : Employee
    {
        private const double SalesmanSalaryFactory =1.015;


        public Salaryman(string firsdtname, string lastName, decimal salary)
            : base(firsdtname, lastName, salary)
        {
        }

        protected override double SalaryFactor
        {
            get
            {
                return SalesmanSalaryFactory;//5%
            }
        }
    }
}
