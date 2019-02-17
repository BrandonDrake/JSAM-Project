using System;
using System.ComponentModel;

namespace JSAM.Classes
{
    public class Employee : INotifyPropertyChanged
    {
        #region Properties
       
        //Backing Fields
        private int _employeeID;
        private string _firstName;
        private string _lastName;
        private bool _isAvailable;
        private int _jobId;
        
        //Properties
        public int Id
        {
            get
            {
                return _employeeID;
            }
            set
            {
                _employeeID = value;
                PropertyChanged(this, new PropertyChangedEventArgs("EmployeeID"));
            }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("FirstName"));
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("LastName"));
            }
        }
        public bool IsAvailable
        {
            get
            {
                return _isAvailable;
            }
            set
            {
                _isAvailable = value;
                PropertyChanged(this, new PropertyChangedEventArgs("IsAvailable"));
            }
        }
        public DateTime HireDate { get; }
        
        public int JobId
        {
            get
            {
                return _jobId;
            }
            set
            {
                _jobId = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CurrentJob"));
            }
        }
        public string FullName { get; set; }
        public Jobs Job { get; set; } //Used to generate ERM realtionship
        #endregion



        #region Constructors
        public Employee() { }

        public Employee(int Id, string firstName, string lastName, DateTime hireDate, int JobId)
        {
            this.Id = Id;
            FirstName = firstName;
            LastName = lastName;
            IsAvailable = true;
            HireDate = hireDate;
            this.JobId = JobId;
            CreateFullName();
        }
        #endregion

        #region Methods

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        /// <summary>
        /// Use first name and last name properties to concat full name
        /// </summary>
        private void CreateFullName() => FullName = $"{LastName}, {FirstName}";

        /// <summary>
        /// Defines which attributes to display inteh WPF Employee ListBox
        /// </summary>
        /// <param name="employeeChoice"></param>
        /// <returns></returns>
        public string ShowAttributes(Employee employeeChoice)
        {
            string attributes;

            attributes = $"{FullName}";

            return attributes;
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
