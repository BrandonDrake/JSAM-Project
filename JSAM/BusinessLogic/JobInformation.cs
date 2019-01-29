using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace JSAM.BusinessLogic
{
    class JobInformation : INotifyPropertyChanged
    {
        private int _jobNumber;
        private string _jobName;
        private int _manpowerNeeds;
        private int _currentManpower;
        private DateTime _startDate;
        private DateTime _endDate;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public JobInformation() { }

        /// <summary>
        /// Constructor for Job objects
        /// </summary>
        /// <param name="jobNumber"></param>
        /// <param name="jobName"></param>
        /// <param name="manpowerNeeds"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>

        public JobInformation(int jobNumber, string jobName, int manpowerNeeds, DateTime startDate, DateTime endDate)
        {
            JobNumber = jobNumber;
            JobName = jobName;
            ManpowerNeeds = manpowerNeeds;
            //SetCurrentManpower();
            StartDate = startDate;
            EndDate = endDate;
        }

        #region Properties
        public int JobNumber
        {
            get
            {
                return _jobNumber;
            }
            set
            {
                _jobNumber = value;
                PropertyChanged(this, new PropertyChangedEventArgs("JobNumber"));
            }
        }
        public string JobName
        {
            get
            {
                return _jobName;
            }
            set
            {
                _jobName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("JobName"));
            }
        }
        public int ManpowerNeeds
        {
            get
            {
                return _manpowerNeeds;
            }
            set
            {
                _manpowerNeeds = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ManPowerNeeds"));
            }
        }
        public int CurrentManpower
        {
            get
            {
                return _currentManpower;
            }
            set
            {
                _currentManpower = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CurrentManpower"));
            }
        }
        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
                PropertyChanged(this, new PropertyChangedEventArgs("StartDate"));
            }
        }
        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
                PropertyChanged(this, new PropertyChangedEventArgs("EndDate"));
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// ToString override for WPF list boxes
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string jobInformation = "";

            if (!string.IsNullOrEmpty(JobName))
            {
                jobInformation = $"Job Number:\t{JobNumber}\n" +
                    $"Job Name:\t{JobName}\n" +
                    $"Manpower Needs:\t{ManpowerNeeds}\n" +
                    $"Current Manpower:\t{CurrentManpower}\n";
            }
            return jobInformation;
        }

        
        #endregion
    }
}
