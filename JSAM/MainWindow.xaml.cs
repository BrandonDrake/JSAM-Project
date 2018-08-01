using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using JSAM.BusinessLogic;
using JSAM.Repositories;

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
            EmployeeRepository.EmployeeList();
        }

        #region Employee Event Handlers
        private void Button_Click_GenerateEmployeeList(object sender, RoutedEventArgs e)
        {
            new EmployeeRepository();
            EmployeeList.Items.Clear();

            foreach (Employee employee in Employee.employeeList)
            {
                if (employee.IsAvailable == true)
                {
                    EmployeeList.Items.Add(employee);
                }
            }
        }

        private void Button_Click_ShowCurrentJob(object sender, RoutedEventArgs e)
        {
            Employee employee = (Employee)EmployeeList.SelectedItem;

            int currentJob = employee.CurrentJob;
            string employeeName = employee.FullName;


            MessageBox.Show($"Employee: {employeeName}\n" +
                            $"Current Job: {currentJob.ToString()}");
        } 
        #endregion

        private void Button_Click_GenerateJobList(object sender, RoutedEventArgs e)
        {
            new JobRepository();
            JobList.Items.Clear();

            foreach (JobInformation job in JobRepository.JobList())
            {
                ListBoxItem newJob = new ListBoxItem();
                newJob.IsEnabled = false;

                if(job.CurrentManpower < job.ManpowerNeeds)
                {
                    newJob.Background = Brushes.LightCoral;
                }
                else {newJob.Background = Brushes.LightGreen; }

                newJob.Content = job;

                JobList.Items.Add(newJob);
            }
        }

        private void Button_Click_UpdateJob(object sender, RoutedEventArgs e)
        {
            var employee = (Employee)EmployeeList.SelectedItem;
            int newJobNumber;

            if(int.TryParse(NewJobNumber.Text, out newJobNumber))
            {
                employee.UpdateJob(employee.EmployeeID, newJobNumber);
                MessageBox.Show($"{employee.FullName} job assignment updated to {newJobNumber}.");
            }
            else
            {
                MessageBox.Show("Please enter a valid job number");
            }
         
            NewJobNumber.Text = "Enter New Job Number";
            Button_Click_GenerateEmployeeList(sender, e);
            Button_Click_GenerateJobList(sender, e);
        }

        private void EmployeeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currentSelection = (Employee)EmployeeList.SelectedItem;
            if(currentSelection != null)
            {
                SelectedEmployee.Text = currentSelection.FullName;
            }
            else
            {
                SelectedEmployee.Text = "Choose an Employee";
            }
            NewJobNumber.Focus();
            NewJobNumber.SelectionStart = 0;
            NewJobNumber.SelectionLength = NewJobNumber.Text.Length;
        }
    }
}
