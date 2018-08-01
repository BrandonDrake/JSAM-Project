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
        #region Properties
        public static List<Employee> employeeList = new List<Employee>();
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime HireDate { get; set; }
        public Trades EmployeeTrade { get; set; }
        public int CurrentJob { get; set; }
        public Address EmployeeAddress { get; set; }
        public string FullName { get; set; }
        #endregion



        #region Constructors
        public Employee() { }

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
        #endregion

        #region Methods
        /// <summary>
        /// Use first name and last name properties to concat full name
        /// </summary>
        private void CreateFullName()
        {
            FullName = $"{LastName}, {FirstName}";
        }

        /// <summary>
        /// Defines which attributes to display inteh WPF Employee ListBox
        /// </summary>
        /// <param name="employeeChoice"></param>
        /// <returns></returns>
        public string ShowAttributes(Employee employeeChoice)
        {
            string attributes;

            attributes = $"Employee Name:\t{FullName}\n" +
                $"Years of Service:\t{DateTime.Now.Year - HireDate.Year}\n" +
                $"Trade:\t\t{EmployeeTrade}\n";

            return attributes;
        }

        /// <summary>
        /// Updates the selected employee in the Employee ListBox to a new job number
        /// and set the employee availability to false
        /// </summary>
        /// <param name="employeeID"></param>
        /// <param name="jobNumber"></param>
        public void UpdateJob(int employeeID, int jobNumber)
        {
            for (int i = 0; i < employeeList.Count(); i++)
            {
                if (employeeList[i].EmployeeID == employeeID)
                {
                    employeeList[i].CurrentJob = jobNumber;
                    employeeList[i].IsAvailable = false;
                    continue;
                }
            }
        }

        /// <summary>
        /// ToString Overrride for WPF listbox
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string attributes = ShowAttributes(this);

            return attributes;
        } 
        #endregion

    }
}
