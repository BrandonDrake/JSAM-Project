using System;
using System.ComponentModel;

namespace JSAM.Classes
{
    public class Jobs : INotifyPropertyChanged
    {
        private int _jobId;
        private string _jobName;
        private int _manpowerNeeds;
        private int _currentManpower;
        private DateTime _startDate;
        private DateTime _endDate;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public Jobs() { }

        /// <summary>
        /// Constructor for Job objects
        /// </summary>
        /// <param name="jobNumber"></param>
        /// <param name="jobName"></param>
        /// <param name="manpowerNeeds"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        //@brandon_drake
        public Jobs(int Id, string jobName, int manpowerNeeds, DateTime startDate, DateTime endDate)
        {
            this.Id = Id;
            JobName = jobName;
            ManpowerNeeds = manpowerNeeds;
            //SetCurrentManpower();
            StartDate = startDate;
            EndDate = endDate;
        }

        #region Properties
        
        public int Id
        {
            get
            {
                return _jobId;
            }
            private set
            {
                _jobId = value;
                PropertyChanged(this, new PropertyChangedEventArgs("JobId"));
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
                jobInformation = $"{JobName}({Id})";
                    
            }
            return jobInformation;
        }


        #endregion
    }
}
