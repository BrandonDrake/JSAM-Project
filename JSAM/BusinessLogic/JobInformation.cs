using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSAM.Repositories;

namespace JSAM.BusinessLogic
{
    class JobInformation
    {
        public JobInformation() { }

        /// <summary>
        /// Constructor for Job objects
        /// </summary>
        /// <param name="jobNumber"></param>
        /// <param name="jobName"></param>
        /// <param name="manpowerNeeds"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="trade1"></param>
        /// <param name="trade2"></param>
        /// <param name="trade3"></param>
        /// <param name="trade4"></param>
        /// <param name="trade5"></param>
        public JobInformation(int jobNumber, string jobName, int manpowerNeeds, DateTime startDate, DateTime endDate,
            Trades trade1, Trades trade2 = Trades.None, Trades trade3 = Trades.None, Trades trade4 = Trades.None, Trades trade5 = Trades.None)
        {
            TradesNeeded = new List<Trades>(); 
            
            JobNumber = jobNumber;
            JobName = jobName;
            ManpowerNeeds = manpowerNeeds;
            SetCurrentManpower();
            StartDate = startDate;
            EndDate = endDate;
            TradesNeeded.Add(trade1);
            TradesNeeded.Add(trade2);
            TradesNeeded.Add(trade3);
            TradesNeeded.Add(trade4);
            TradesNeeded.Add(trade5);
        }

        #region Properties
        public int JobNumber { get; set; }
        public string JobName { get; set; }
        public Address JobAddress { get; set; }
        public int ManpowerNeeds { get; set; }
        public int CurrentManpower { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Trades> TradesNeeded { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// ToString override for WPF list boxes
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string jobInformation = "";

            if(!string.IsNullOrEmpty(JobName))
            {
                jobInformation = $"Job Number:\t{JobNumber}\n" +
                    $"Job Name:\t{JobName}\n" +
                    $"Manpower Needs:\t{ManpowerNeeds}\n" +
                    $"Current Manpower:\t{CurrentManpower}\n";
                
                foreach(Trades trade in TradesNeeded) //Itterate trades to find all trades needed on job
                {
                    if(trade != Trades.None)
                    {
                        jobInformation += $"Required Trade:\t{trade}\n"; //Add each trade to job info displayed in list box
                    }
                }
            }

            return jobInformation;
        }

        /// <summary>
        /// Itterates list of empoloyees to check job numbers and get a count of employees currently working 
        /// on that job
        /// </summary>
        public void SetCurrentManpower()
        {
            {
                int employeeCount = 0;

                foreach (Employee employee in Employee.employeeList)
                {
                    if (this.JobNumber == employee.CurrentJob)
                    {
                        employeeCount++; //Increments employee count
                    }
                }

                CurrentManpower = employeeCount;
            }
        }
        #endregion
    }
}
