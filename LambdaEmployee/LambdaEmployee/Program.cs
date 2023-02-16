using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEmployee
{
    internal class Program
    {
        static void Main()
        {
            // list of 10 employees

            List<Employee> EmployeeList = new List<Employee>
            {
                new Employee { Id=1, FirstName="Joe", LastName="McIntosh" },
                new Employee { Id=2, FirstName="Kevin", LastName="Locke" },
                new Employee { Id=3, FirstName="Joe", LastName="King" },
                new Employee { Id=4, FirstName="Kelly", LastName="Burns" },
                new Employee { Id=5, FirstName="Evan", LastName="Drake" },
                new Employee { Id=6, FirstName="Sylvan", LastName="Zimmer" },
                new Employee { Id=7, FirstName="Sally", LastName="Morrison" },
                new Employee { Id=8, FirstName="Jim", LastName="Sheffield" },
                new Employee { Id=9, FirstName="Joe", LastName="Cooke" },
                new Employee { Id=10, FirstName="Adrienne", LastName="Hook" }
            };
            // ***** This section uses foreach loops *******

            // new list to addd all Joes
            
            List<Employee> JoeList = new List<Employee>();
            foreach (Employee emp in EmployeeList)
            {
                // if first name is joe, will get added to the joe list
                
                if (emp.FirstName == "Joe")
                {
                    JoeList.Add(emp);
                }
            }

            // prints full list to console (for comparison)

            
            Console.WriteLine("Complete List of Employees:\n");

            foreach (Employee emp in EmployeeList)
            {
                Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName);
            }

            // prints list of Joe's to console
            Console.WriteLine("\n****** Using FOREACH Loop ******\n");
            Console.WriteLine("\nList of Employees named Joe:\n");

            foreach (Employee emp in JoeList)
            {
                Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName);
            }

            // ***** This section uses lambda functions to list the Joe employees *******

            Console.WriteLine("\n****** Using LAMBDA Functions ******\n");
            Console.WriteLine("\nList of Employees named Joe:\n");

            // uses lambda function Where() to make a new list of employees with first name Joe

            List<Employee> JoeListLambda = EmployeeList.Where(x => x.FirstName == "Joe").ToList();

            // printing out to console to compare to FOREACH list

            foreach (Employee emp in JoeListLambda)
            {
                Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName);
            }

            // uses lamdba function Where() to make a new list of employees with Id bigger than 5

            List<Employee> IdListLambda = EmployeeList.Where(x => x.Id > 5).ToList();

            // prints list to console for verification

            Console.WriteLine("\nList of Employees with IDs bigger than 5:\n");
            foreach (Employee emp in IdListLambda)
            {
                Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName);
            }
            Console.ReadLine();
        }
    }
}
