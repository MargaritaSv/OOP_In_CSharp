namespace Interfaces
{
    public interface IEmployee : IPaidPerson
    {
        Deparment Department { get; set; }
        decimal Salary { get; set; }
        double SalaryFactory { get; }
    }
}
