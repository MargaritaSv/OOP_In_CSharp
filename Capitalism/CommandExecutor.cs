using ConsoleApplication2.Interfaces;
using ConsoleApplication2.UserINterfaces;
using Interfaces;
using Interfaces.Interfaces;
using System.Linq;
using System;
using System.Reflection;
using ConsoleApplication2.Salaries;

namespace ConsoleApplication2
{
    public class CommandExecutor:ICommandExecutor
    {
        private IDatabase database;
        private IUser userINterfaces;
        private SalaryManager salaryManager;


        public CommandExecutor()
        {
            this.database = new Database();  //tyk 6te pazim dannite
            this.salaryManager = new SalaryManager();
        }

        public string ExecuteCMD(ICommand cmd)
        {
            string cmdResult = null;

            switch (cmd.Name)
            {
                case "create-company":
                    cmdResult = ExecuteCreateCompany(cmd);
                    break;
                case "create-department":
                    cmdResult = ExecuteCreateDepartmentCMD(cmd);
                    break;
                case "create-employee":
                    cmdResult = ExecuteCreateEmployeeCMD(cmd);
                    break;
                case "create-salaries":
                    break;

                case "show-employees":
                    //TODO: IMplement properly
                    cmdResult = "Employees go here";
                    break;
                case "end":
                    break;
                default:
                    throw new System.InvalidOperationException("The command name is invalid.");
            }
            return cmdResult;
        }

        private string ExecuteCreateEmployeeCMD(ICommand cmd)
        {
            string firstName = cmd.Parameters[0];
            string lastName = cmd.Parameters[1];
            string companyName = cmd.Parameters[2];

            var company = this.database.Comapanies.FirstOrDefault(c => c.Name == companyName);

            if (company == null)
            {
                return string.Format($"Company {companyName} does not exist");
            }

            if (company.Employee.Any(e => e.FirstName == firstName && e.LastName == lastName))
            {
                return string.Format($"Employee {firstName}{lastName} already exist in{company.Name} (no department)");
            }

            //       if (company.Department.SelectMany(e => e.Employee).Any(e => e.FirstName == firstName && e.LastName == lastName))
            //"selectMany" -kolekciq ot employee-ta t.e. kato select ,no vmesto kolekcii ot kolekcii,6te vurne samo edin spisuk ot employee-ta
            //any-vru6ta bylev resyzltat

            var firstFindEmployee = company.Department.SelectMany(e => e.Employee).FirstOrDefault(e => e.FirstName == firstName && e.LastName == lastName);

            if (firstFindEmployee != null)
            {
                return string.Format($"Employee {firstName}{lastName} already exist in {company.Name} (in department {firstFindEmployee.Department.Name})");
            }

            //reflection
            var employeeTypeName = cmd.Parameters[2];
            var employeeType = Assembly.GetExecutingAssembly().GetType("Interfaces.Interfaces" + employeeTypeName); //trqbva da dadem pulniq naespace (gledam CEO-to mi)
            var employee = Activator.CreateInstance(employeeType, args: new object[] { cmd.Parameters[0], cmd.Parameters[1] }) as IEmployee;  //instancirame go indirektno s klasa "Activator"
                                                                                                                                                    //Activator - tursi nai-konkretniq ctor

            //TODO replace salary to be valid
           

            /*   bez reflection
                        IPaidPerson person;
                        switch (cmd.Parameters[2])
                        {


                            case "ChiefTelephoneOfficer":
                                person = new ChiefTelephone("","",0m);
                                break;
                            case "Manager":
                                person = new Manager("","",0m);
                                break;
                            case "CEO":
                                throw new InvalidOperationException("Cannot creat a second CEO");
                            default:
                                break;
                        }
                        */

            if (cmd.Parameters.Count == 4)
            {
                company.Employee.Add(employee);
                company.CEO.SubEmployee.Add(employee);
            }
            else
            {
                string departmentName = cmd.Parameters[4];
                var department = company.Department.FirstOrDefault(d => d.Name == departmentName);
                if (department == null)//ako nqame department se opitvame da go vzemem kato poddep. na nqkoi dryg
                {
                    department = company.Department.SelectMany(d => d.SubDepartment).FirstOrDefault(x => x.Name == departmentName);

                }
                if (department == null)//ako produljava da hvurlq null -> excetion
                {
                    return string.Format($"Department {cmd.Parameters[4]} does not exist in company {company.Name}");
                }

                department.Employee.Add(employee);  //dobavqme
                department.Manager.SubEmployee.Add(employee); //no v drygiq sly4ai nqma direktno manager
                employee.Department = department;  //op set-me
            }

            decimal salary = salaryManager.GetSalary(employee, company);
            employee.Salary = salary;

            return null;
        }

        private string ExecuteCreateCompany(ICommand cmd)
        {

            var ceo = new CEO(cmd.Parameters[1], cmd.Parameters[2], decimal.Parse(cmd.Parameters[3]));
            var company = new Company(cmd.Parameters[0], ceo);
            string companyName = cmd.Parameters[0];
            this.database.Comapanies.Add(company);//zapisvame kompaniqta
            if (database.Comapanies.Any(x => x.Name == company.Name))
            {
                return string.Format("Comapany {0} is already exist.", company.Name);
            }
            this.database.Comapanies.Add(company);
            return null;
        }

        private string ExecuteCreateDepartmentCMD(ICommand cmd)
        {
            var company = this.database.Comapanies.FirstOrDefault(x => x.Name == cmd.Parameters[0]); //kompaniqta,4ieto ime e ravno na kompaniqta,koqto ve4e q ima

            if (company == null) //"FirstOrDefault" -> ako ima kompaniq ...ok... ako nqma default value my e null
            {
                return string.Format("Comapany {0} does not exist", cmd.Parameters[0]);
            }
            if (cmd.Parameters.Count == 4) //namq mainDepartmen po yslovie za output-a
            {
                var manager = company.Employee.FirstOrDefault(e => e.FirstName == cmd.Parameters[2] && e.LastName == cmd.Parameters[3]);
                if (manager == null)
                {
                    return string.Format($"The is no employee called{cmd.Parameters[2]} {cmd.Parameters[3]} is company {company.Name}");
                }
                if (!(manager is Manager))
                {
                    /*
                    string pos = string.Empty;
                    switch (manager.GetType().Name)
                    {
                        case "ChiefTelephoneOfficer":
                            pos = "chieg telephone officer";
                            break;
                        case "CleaningLady":
                            pos = "cleaning lady";
                            break;
                        case "ManagerEmploy":
                            pos = "manager";
                            break;
                        default:
                            pos = manager.GetType().Name;
                            break;
                           
                    }
                     */

                    //S reflection t.e 1) vsqka malka bykva q zamenqme s glavna  2) ako glavna e v sredata interval i si ostava glavna

                    string pos = manager.GetType().Name;
                    string realPos = string.Empty;
                    for (int i = 0; i < pos.Length; i++)
                    {
                        if (realPos[i].ToString().ToUpper() == realPos[i].ToString())//string-osvame ,za6toto vzimame char; ideqta e,4e ako sled kato e oburnata na glavna pak e razna s purvona4alnata => bila si e glavna
                        {
                            realPos += " " + realPos[i];
                        }
                        else
                        {
                            realPos += realPos[i];
                        }
                        realPos = realPos.Trim();
                    }

                    return string.Format($"{cmd.Parameters[2]} {cmd.Parameters[3]} is not a manager (real position is{realPos})"); //istinskata poziq e klasa,v koito e
                }

                if (company.Department.Any(d => d.Name == cmd.Parameters[1]))
                {
                    return string.Format($"Employee{cmd.Parameters[2]}{cmd.Parameters[3]} already exist in {company.Name}");
                }

                var department = new Deparment(cmd.Parameters[1], manager as Manager); //kastvame kum podhpdq6tiq tip bez "as" gurmi; imame proverkite nagore predi da sme stignali  do tyk
                company.Department.Add(department);
            }
            else//5->ima
            {
                var mainDeparments = company.Department.FirstOrDefault(x => x.Name == cmd.Parameters[4]);
                if (mainDeparments == null)
                {
                    return string.Format($"There is no department {cmd.Parameters[4]} in {company.Name}");
                }

                var manager = mainDeparments.Employee.FirstOrDefault(e => e.FirstName == cmd.Parameters[2] && e.LastName == cmd.Parameters[3]);
                if (manager == null)
                {
                    return string.Format($"The is no employee called{cmd.Parameters[2]} {cmd.Parameters[3]} is departments {company.Name}");
                }

                if (!(manager is Manager))
                {
                    string pos = manager.GetType().Name;
                    string realPos = string.Empty;

                    for (int i = 0; i < pos.Length; i++)
                    {
                        if (realPos[i].ToString().ToUpper() == realPos[i].ToString())//string-osvame ,za6toto vzimame char; ideqta e,4e ako sled kato e oburnata na glavna pak e razna s purvona4alnata => bila si e glavna
                        {
                            realPos += " " + realPos[i];
                        }
                        else
                        {
                            realPos += realPos[i];
                        }
                        realPos = realPos.Trim();
                    }

                    return string.Format($"{cmd.Parameters[2]} {cmd.Parameters[3]} is not a manager (real position is{realPos})"); //istinskata poziq e klasa,v koito e
                }

                if (mainDeparments.Employee.Where(d => d is Manager).Cast<Manager>().Any(c => company.Department.Select(e => e.Manager).Contains(c)))
                {
                    return string.Format($"Employee{cmd.Parameters[2]}{cmd.Parameters[3]} already exist in {company.Name}");
                }

                //lipsva edin if za proverka za ..... dulga i shiroka :D

                var department = new Deparment(cmd.Parameters[1], manager as Manager); //kastvame kum podhpdq6tiq tip bez "as" gurmi; imame proverkite nagore predi da sme stignali  do tyk
                                                                                       //  mainDeparments.SubDeparments.Add(department);
                company.Department.Add(department);
            }
            return null;
        }
    }
}