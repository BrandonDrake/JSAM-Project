using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAM.Classes
{
    public class EmployeeMethods
    {
        /// <summary>
        /// Updates current slected employee in UI job assignment
        /// </summary>
        /// <param name="newJobNumber"></param>
        /// <param name="employee"></param>
        /// <returns></returns>
        public static string updateCurrentJob(int newJobNumber, Employee employee)
        {
            string confirmationMessage;

            if (employee.JobId != newJobNumber) //Check that a new job number was entered
            {
                employee.JobId = newJobNumber;
                confirmationMessage = "Job Updated Successfully";
            }
            else
            {
                confirmationMessage = "Employee already assigned to this job.";
            }

            return confirmationMessage; //Return message to UI for user confirmation message
        }
    }
}
