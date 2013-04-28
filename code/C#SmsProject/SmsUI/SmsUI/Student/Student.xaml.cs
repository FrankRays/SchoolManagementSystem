using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SMSUI
{
    /// <summary>
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : UserControl
    {
        public Student()
        {
            InitializeComponent();

            SMSUI.ViewStudent ViewStudentobj = new SMSUI.ViewStudent();

            mainStudentUniGrid.Children.Clear();
            mainStudentUniGrid.Children.Add(ViewStudentobj);
        }

        private void viewStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.ViewStudent ViewStudentobj = new SMSUI.ViewStudent();

            mainStudentUniGrid.Children.Clear();
            mainStudentUniGrid.Children.Add(ViewStudentobj);
        }

        private void addStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.AddStudent AddStudentobj = new SMSUI.AddStudent();

            mainStudentUniGrid.Children.Clear();
            mainStudentUniGrid.Children.Add(AddStudentobj);
        }

        private void manageStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.ManageStudent AddStudentobj = new SMSUI.ManageStudent();

            mainStudentUniGrid.Children.Clear();
            mainStudentUniGrid.Children.Add(AddStudentobj);
        }

        
    }
}
