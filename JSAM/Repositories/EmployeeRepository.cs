using JSAM.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
                
           emp.Add( new Employee
            (
                employeeID: 101,
                firstName:  "John",   
                lastName:   "Meyers",   
                isAvailable: true, 
                hireDate:   new DateTime(2017,6,12),
                jobNumber:  18001
            ));
            emp.Add(new Employee
            (
                employeeID: 102, 
                firstName:  "Jason",   
                lastName:   "Ott",      
                isAvailable: true, 
                hireDate:   new DateTime(1995,7,12), 
                jobNumber:  18002
            ));
            emp.Add(new Employee
            (
                employeeID:  103,
                firstName:  "Todd",   
                lastName:   "Gardner",
                isAvailable: true, 
                hireDate:   new DateTime(2014,8,20),
               jobNumber:  17104
            ));
            emp.Add(new Employee
            (
                employeeID: 104,
                firstName:  "Rick", 
                lastName:   "Heck",     
                isAvailable: true, 
                hireDate:   new DateTime(2017,5,16), 
                jobNumber:  18003
            ));
            emp.Add(new Employee
            (
                employeeID: 105, 
                firstName:  "Todd",   
                lastName:   "Ramey",    
                isAvailable: false,
                hireDate:   new DateTime(2001,5,12),
                jobNumber:  17104
            ));
            emp.Add(new Employee
            (
                employeeID: 106, 
                firstName:  "Mike",   
                lastName:   "Bartow",   
                isAvailable: true, 
                hireDate:   new DateTime(2006,4,17), 
                jobNumber:  18002
            ));
            emp.Add(new Employee
            (
                employeeID: 107,
                firstName:  "Rich", 
                lastName:   "Reeser",    
                isAvailable: true, 
                hireDate:   new DateTime(2016,6,8),
                jobNumber:  18001
            ));
            emp.Add(new Employee
            (
                employeeID: 108,
                firstName:  "Brian",
                lastName:   "Hoover",   
                isAvailable: true, 
                hireDate:   new DateTime(1998,3,15),
                jobNumber:  18003
            ));
            emp.Add(new Employee
            (
               employeeID: 109, 
               firstName:  "Todd",
               lastName:   "Bischoff",  
               isAvailable: true, 
               hireDate:   new DateTime(1993,3,30),
               jobNumber:  18002
            ));
            emp.Add(new Employee
            (
                employeeID: 110, 
                firstName:  "Tommy", 
                lastName:   "Elmlinger",
                isAvailable: false, 
                hireDate:   new DateTime(1990,6,19),
                jobNumber:  18001
            ));
            
            return emp;
        }
    }
}
