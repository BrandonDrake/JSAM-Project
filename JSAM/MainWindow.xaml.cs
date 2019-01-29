using JSAM.BusinessLogic;
using JSAM.Repositories;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
            Employees = EmployeeRepository.EmployeeList();
            var Jobs = new JobRepository();
            EmployeeList.SelectedItem = Employees[0];
            DataContext = this;
        }


        #region Properties
        public ObservableCollection<Employee> Employees
        {
            get { return (ObservableCollection<Employee>)GetValue(EmployeesProperty); }
            set { SetValue(EmployeesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Employees.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeesProperty =
            DependencyProperty.Register("Employees", typeof(ObservableCollection<Employee>), typeof(MainWindow), new PropertyMetadata(null));



        public Employee CurrentEmployee
        {
            get { return (Employee)GetValue(CurrentEmployeeProperty); }
            set { SetValue(CurrentEmployeeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentEmployee.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentEmployeeProperty =
            DependencyProperty.Register("CurrentEmployee", typeof(Employee), typeof(MainWindow), new PropertyMetadata(null)); 
        #endregion

        #region Employee Event Handlers

        private void OnCustomerSelected(object sender, SelectionChangedEventArgs e)
        {
            CurrentEmployee = EmployeeList.SelectedItem as Employee;
            yearsOfService();
            getJobName();
        }
        #endregion

        #region Methods
        public void yearsOfService()
        {
            int yearsOfService;
            yearsOfService = DateTime.Now.Year - CurrentEmployee.HireDate.Year;
            YearsOfService.Text = yearsOfService.ToString();
        }

        public void getJobName()
        {

            foreach (var job in JobRepository.JobList())
            {
                if (CurrentEmployee.CurrentJob == job.JobNumber)
                {
                    EmpCurrentJobName.Text = job.JobName;
                    break;
                }
            }
        }
        #endregion
    }
}
