using JSAM.Classes;
using JSAM.DataContext;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JSAM.Repositories
{
    class JobRepository
    {
        /// <summary>
        /// Simulates importing job information from a database and creates job objects
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<Jobs> JobList()
        {
            var jobList = new ObservableCollection<Jobs>()
            {
                new Jobs
                (
                    Id: 4,
                    jobName: "Nestle",
                    manpowerNeeds: 7,
                    startDate: new DateTime(2017, 4, 12),
                    endDate: new DateTime (2019, 2, 15)
                ),
                new Jobs
                (
                    Id: 1,
                    jobName: "Bunge",
                    manpowerNeeds: 4,
                    startDate: DateTime.Now,
                    endDate: new DateTime (2019, 4, 15)
                ),
                new Jobs
                (
                    Id: 2,
                    jobName: "Gundlach",
                    manpowerNeeds: 2,
                    startDate: new DateTime(2018, 2, 25),
                    endDate: new DateTime (2018, 8, 31)
                ),
                new Jobs
                (
                    Id: 3,
                    jobName: "Pepperidge Farms",
                    manpowerNeeds: 1,
                    startDate: new DateTime(2018, 7, 30),
                    endDate: new DateTime (2018, 8, 2)
                ),

            };

            //foreach (Jobs job in jobList)
            //{
            //    using (var context = new JSAMContext())
            //    {
            //        context.Jobs.Add(job);
            //        context.SaveChanges();
            //    }
            //}

            return jobList;
        }
    }
}
