using JSAM.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace JSAM.BusinessLogic
{
    public class Employee : INotifyPropertyChanged
    {
        #region Properties
       
        private int _employeeID;
        private string _firstName;
        private string _lastName;
        private bool _isAvailable;
        private int _currentJob;
       
        public int EmployeeID
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
        public int CurrentJob
        {
            get
            {
                return _currentJob;
            }
            set
            {
                _currentJob = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CurrentJob"));
            }
        }
        public string FullName { get; set; }






        #endregion



        #region Constructors
        public Employee() { }

        public Employee(int employeeID, string firstName, string lastName, bool isAvailable, DateTime hireDate, int jobNumber)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            IsAvailable = isAvailable;
            HireDate = hireDate;
            CurrentJob = jobNumber;
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
