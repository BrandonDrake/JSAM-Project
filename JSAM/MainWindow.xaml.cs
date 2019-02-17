using JSAM.Classes;
using JSAM.Repositories;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace JSAM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Jobs = JobRepository.JobList(); //Generate jobs
            Employees = EmployeeRepository.EmployeeList(); //Generate Employees
            EmployeeList.SelectedItem = Employees[0];
            JobList.SelectedItem = Jobs[0];
            DataContext = this; //Set data context for UI based on this window
        }


        #region Properties
        /// <summary>
        /// Employee Dependency Property
        /// </summary>
        public ObservableCollection<Employee> Employees
        {
            get { return (ObservableCollection<Employee>)GetValue(EmployeesProperty); }
            set { SetValue(EmployeesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Employees.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeesProperty =
            DependencyProperty.Register("Employees", typeof(ObservableCollection<Employee>), typeof(MainWindow), new PropertyMetadata(null));


        /// <summary>
        /// DP Property for currently selected employees
        /// </summary>
        public Employee CurrentEmployee
        {
            get { return (Employee)GetValue(CurrentEmployeeProperty); }
            set { SetValue(CurrentEmployeeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentEmployee.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentEmployeeProperty =
            DependencyProperty.Register("CurrentEmployee", typeof(Employee), typeof(MainWindow), new PropertyMetadata(null));



        public ObservableCollection<Jobs> Jobs
        {
            get { return (ObservableCollection<Jobs>)GetValue(JobsProperty); }
            set { SetValue(JobsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Jobs.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty JobsProperty =
            DependencyProperty.Register("Jobs", typeof(ObservableCollection<Jobs>), typeof(MainWindow), new PropertyMetadata(null));


        /// <summary>
        /// DP Prop for currently selected Job
        /// </summary>
        public Jobs CurrentJob
        {
            get { return (Jobs)GetValue(JobInformationProperty); }
            set { SetValue(JobInformationProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentJob.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty JobInformationProperty =
            DependencyProperty.Register("CurrentJob", typeof(Jobs), typeof(MainWindow), new PropertyMetadata(null));


        #endregion

        #region Employee Event Handlers
        private void UpdateJobNumber_Click(object sender, RoutedEventArgs e)
        {
            int updatedJobNumber = 0;

            if (Int32.TryParse(NewJobNumber.Text, out updatedJobNumber))
            {
                MessageBox.Show(
                EmployeeMethods.updateCurrentJob(updatedJobNumber, CurrentEmployee));

            }
            else
            {
                MessageBox.Show("Please enter a valid job number");
            }
        }

        private void OnEmployeeSelected(object sender, SelectionChangedEventArgs e)
        {
            CurrentEmployee = EmployeeList.SelectedItem as Employee;
            yearsOfService();
            getJobName();
        }
        #endregion

        #region Job Event Handlers
        private void OnJobSelected(object sender, SelectionChangedEventArgs e)
        {
            CurrentJob = JobList.SelectedItem as Jobs;
            currentJobManpower(CurrentJob.Id);
        }

        #endregion

        #region Methods
        /// <summary>
        /// Caluclates employees years of service based on hire date
        /// </summary>
        public void yearsOfService()
        {
            int yearsOfService;
            yearsOfService = DateTime.Now.Year - CurrentEmployee.HireDate.Year;
            YearsOfService.Text = yearsOfService.ToString();
        }

        /// <summary>
        /// Sets Job name for employee section
        /// </summary>
        public void getJobName()
        {

            foreach (var job in JobRepository.JobList())
            {
                if (CurrentEmployee.JobId == job.Id)
                {
                    EmpCurrentJobName.Text = job.JobName;
                    break;
                }
            }
        }

        /// <summary>
        /// Sets the current manpower of a specific job
        /// </summary>
        /// <param name="jobID"></param>
        public void currentJobManpower(int jobID)
        {
            var jobEmployees = Employees
                .Where(e => e.JobId == jobID); //Lambda to query Employee list using LINQ

            
            CurrentManpower.Text = jobEmployees.Count().ToString();
        }

        #endregion
    }
}
