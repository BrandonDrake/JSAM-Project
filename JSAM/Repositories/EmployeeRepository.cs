using System;
using System.Collections.ObjectModel;
using JSAM.Classes;
using JSAM.DataContext;

namespace JSAM.Repositories
{
    public class EmployeeRepository
    {
        /// <summary>
        /// Simulates importing employee data from a database and creates the employee objects
        /// </summary>
        public static ObservableCollection<Employee> EmployeeList()
        {
            var emp = new ObservableCollection<Employee>();

            emp.Add(new Employee
             (
                 Id: 101,
                 firstName: "John",
                 lastName: "Meyers",
                 hireDate: new DateTime(2017, 6, 12),
                 JobId: 1
             ));
            emp.Add(new Employee
            (
                Id: 102,
                firstName: "Jason",
                lastName: "Ott",
                hireDate: new DateTime(1995, 7, 12),
                JobId: 2
            ));
            emp.Add(new Employee
            (
                Id: 103,
                firstName: "Todd",
                lastName: "Gardner",
                hireDate: new DateTime(2014, 8, 20),
               JobId: 4
            ));
            emp.Add(new Employee
            (
                Id: 104,
                firstName: "Rick",
                lastName: "Heck",
                hireDate: new DateTime(2017, 5, 16),
                JobId: 3
            ));
            emp.Add(new Employee
            (
                Id: 105,
                firstName: "Todd",
                lastName: "Ramey",
                hireDate: new DateTime(2001, 5, 12),
                JobId: 4
            ));
            emp.Add(new Employee
            (
                Id: 106,
                firstName: "Mike",
                lastName: "Bartow",
                hireDate: new DateTime(2006, 4, 17),
                JobId: 2
            ));
            emp.Add(new Employee
            (
                Id: 107,
                firstName: "Rich",
                lastName: "Reeser",
                hireDate: new DateTime(2016, 6, 8),
                JobId: 1
            ));
            emp.Add(new Employee
            (
                Id: 108,
                firstName: "Brian",
                lastName: "Hoover",
                hireDate: new DateTime(1998, 3, 15),
                JobId: 3
            ));
            emp.Add(new Employee
            (
               Id: 109,
               firstName: "Todd",
               lastName: "Bischoff",
               hireDate: new DateTime(1993, 3, 30),
               JobId: 2
            ));
            emp.Add(new Employee
            (
                Id: 110,
                firstName: "Tommy",
                lastName: "Elmlinger",
                hireDate: new DateTime(1990, 6, 19),
                JobId: 1
            ));

            //foreach (var employee in emp)
            //{
            //    using (var context = new JSAMContext())
            //    {
            //        context.Employees.Add(employee);
            //        context.SaveChanges();
            //    }
            //}

            return emp;

        }            
    }
}
