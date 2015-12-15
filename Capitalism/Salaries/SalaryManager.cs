using ConsoleApplication2.Interfaces;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Salaries
{
    public class SalaryManager
    {
        private const decimal salaryPercentage = 0.15m;

        public decimal GetSalary(IEmployee employee, Company company)
        {
            if (company.Employee.Any(e => e.FirstName == employee.FirstName && e.LastName == employee.LastName))
            {
                return salaryPercentage * company.CEO.Salary;
            }
            else
            {
                return (decimal)employee.SalaryFactory * GetSalaryPercentage(employee, company) * company.CEO.Salary;
            }
        }

        private decimal GetSalaryPercentage(IEmployee employee, Company company)
        {
            if (employee.Department == null)//duno na recursiqta
            {
                return salaryPercentage;
            }

            return GetSalaryPercentage(employee.Department.Manager, company) - 0.01m;
        }
    }
}
