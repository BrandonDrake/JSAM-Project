using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSAM.BusinessLogic;

namespace JSAM.Repositories
{
    public class EmployeeRepository
    {
        /// <summary>
        /// Simulates importing employee data from a database and creates the employee objects
        /// </summary>
        public static void EmployeeList()
        {
                
            new Employee
            (
                employeeID: 101,
                firstName:  "John",   
                lastName:   "Meyers",   
                isAvailable: true, 
                hireDate:   new DateTime(2017,6,12),
                trade:      Trades.Steel,
                jobNumber:  18001
            );
            new Employee
            (
                employeeID: 102, 
                firstName:  "Jason",   
                lastName:   "Ott",      
                isAvailable: true, 
                hireDate:   new DateTime(1995,7,12), 
                trade:      Trades.Carpentry, 
                jobNumber:  18002
            );
            new Employee
            (
                employeeID:  103,
                firstName:  "Todd",   
                lastName:   "Gardner",
                isAvailable: true, 
                hireDate:   new DateTime(2014,8,20),
                trade:      Trades.Masonry, 
                jobNumber:  17104
            );
            new Employee
            (
                employeeID: 104,
                firstName:  "Rick", 
                lastName:   "Heck",     
                isAvailable: true, 
                hireDate:   new DateTime(2017,5,16), 
                trade:      Trades.Steel,
                jobNumber:  18003
            );
            new Employee
            (
                employeeID: 105, 
                firstName:  "Todd",   
                lastName:   "Ramey",    
                isAvailable: false,
                hireDate:   new DateTime(2001,5,12),
                trade:      Trades.Carpentry, 
                jobNumber:  17104
            );
            new Employee
            (
                employeeID: 106, 
                firstName:  "Mike",   
                lastName:   "Bartow",   
                isAvailable: true, 
                hireDate:   new DateTime(2006,4,17), 
                trade:      Trades.Carpentry, 
                jobNumber:  18002
            );
            new Employee
            (
                employeeID: 107,
                firstName:  "Rich", 
                lastName:   "Reeser",    
                isAvailable: true, 
                hireDate:   new DateTime(2016,6,8),
                trade:      Trades.Drywall,
                jobNumber:  18001
            );
            new Employee
            (
                employeeID: 108,
                firstName:  "Brian",
                lastName:   "Hoover",   
                isAvailable: true, 
                hireDate:   new DateTime(1998,3,15),
                trade:      Trades.Drywall, 
                jobNumber:  18003
            );
            new Employee
            (
               employeeID: 109, 
               firstName:  "Todd",
               lastName:   "Bischoff",  
               isAvailable: true, 
               hireDate:   new DateTime(1993,3,30),
               trade:      Trades.Concrete, 
               jobNumber:  18002
            );
            new Employee
            (
                employeeID: 110, 
                firstName:  "Tommy", 
                lastName:   "Elmlinger",
                isAvailable: false, 
                hireDate:   new DateTime(1990,6,19),
                trade:      Trades.Concrete, 
                jobNumber:  18001
            );
        }
    }
}
