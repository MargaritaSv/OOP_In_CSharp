namespace Interfaces
{
    public interface IEmployee : IPaidPerson
    {
        Deparment Department { get; set; }

        double SalaryFactory { get; }
    }
}
