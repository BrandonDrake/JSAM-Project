using JSAM.BusinessLogic;
using System;
using System.Collections.Generic;

namespace JSAM.Repositories
{
    class JobRepository
    {
        /// <summary>
        /// Simulates importing job information from a database and creates job objects
        /// </summary>
        /// <returns></returns>
        public static List<JobInformation> JobList()
        {
            var jobList = new List<JobInformation>()
            {
                new JobInformation
                (
                    jobNumber: 17104,
                    jobName: "Nestle",
                    manpowerNeeds: 7,
                    startDate: new DateTime(2017, 4, 12),
                    endDate: new DateTime (2019, 2, 15)
                ),
                new JobInformation
                (
                    jobNumber: 18001,
                    jobName: "Bunge",
                    manpowerNeeds: 4,
                    startDate: DateTime.Now,
                    endDate: new DateTime (2019, 4, 15)
                ),
                new JobInformation
                (
                    jobNumber: 18002,
                    jobName: "Gundlach",
                    manpowerNeeds: 2,
                    startDate: new DateTime(2018, 2, 25),
                    endDate: new DateTime (2018, 8, 31)
                ),
                new JobInformation
                (
                    jobNumber: 18003,
                    jobName: "Pepperidge Farms",
                    manpowerNeeds: 1,
                    startDate: new DateTime(2018, 7, 30),
                    endDate: new DateTime (2018, 8, 2)
                ),

            };

            return jobList;
        }
    }
}
