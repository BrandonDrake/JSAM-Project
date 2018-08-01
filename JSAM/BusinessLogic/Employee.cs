using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSAM.Repositories;

namespace JSAM.BusinessLogic
{
    public class Employee
    {
        public static List<Employee> employeeList = new List<Employee>();
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime HireDate { get; set; }
        public Trades EmployeeTrade { get; set; }
        public int CurrentJob { get; set; }
        public Address EmployeeAddress { get; set; }
        public string FullName {get; set;}
            


        public Employee() {}

        public Employee(int employeeID, string firstName, string lastName, bool isAvailable, DateTime hireDate, Trades trade, int jobNumber)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            IsAvailable = isAvailable;
            HireDate = hireDate;
            EmployeeTrade = trade;
            CurrentJob = jobNumber;
            CreateFullName();
            employeeList.Add(this);
        }

        private void CreateFullName()
        {
           FullName = $"{LastName}, {FirstName}";
        }

        public string ShowAttributes(Employee employeeChoice)
        {
            string attributes;

            attributes = $"Employee Name:\t{FullName}\n" +
                $"Years of Service:\t{DateTime.Now.Year - HireDate.Year}\n" +
                $"Trade:\t\t{EmployeeTrade}\n";
            
            return attributes;
        }

        public void UpdateJob(int employeeID, int jobNumber)
        {
            for(int i = 0; i < employeeList.Count(); i++)
            {
                if(employeeList[i].EmployeeID == employeeID)
                {
                    employeeList[i].CurrentJob = jobNumber;
                    employeeList[i].IsAvailable = false;
                    continue;
                }
            }
        }

        public override string ToString()
        {
            string attributes = ShowAttributes(this);
        
            return attributes;
        }

    }
}
