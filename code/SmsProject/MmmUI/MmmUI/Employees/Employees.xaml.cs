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
    /// Interaction logic for Employees.xaml
    /// </summary>
    public partial class Employees : UserControl
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.AddEmployee AddEmployeeobj = new SMSUI.AddEmployee();

            employeeMainUG.Children.Clear();
            employeeMainUG.Children.Add(AddEmployeeobj);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SMSUI.ViewEmployee ViewEmployeeobj = new SMSUI.ViewEmployee();

            employeeMainUG.Children.Clear();
            employeeMainUG.Children.Add(ViewEmployeeobj);
        }
    }
}
