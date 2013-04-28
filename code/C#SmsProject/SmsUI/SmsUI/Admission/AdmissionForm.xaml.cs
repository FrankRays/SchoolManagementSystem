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
    /// Interaction logic for AdmissionForm.xaml
    /// </summary>
    public partial class AdmissionForm : UserControl
    {
        public AdmissionForm()
        {
            InitializeComponent();

            SMSUI.ViewForm ViewFormobj = new SMSUI.ViewForm();

            AdmissionMainUG.Children.Clear();
            AdmissionMainUG.Children.Add(ViewFormobj);

            
        }

        private void viewFormBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.ViewForm ViewFormobj = new SMSUI.ViewForm();

            AdmissionMainUG.Children.Clear();
            AdmissionMainUG.Children.Add(ViewFormobj);
        }

        private void addAdmissionFormBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.AddAdmissionForm AddAdmissionFormobj = new SMSUI.AddAdmissionForm();

            AdmissionMainUG.Children.Clear();
            AdmissionMainUG.Children.Add(AddAdmissionFormobj);
        }

        private void manageFormBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.ManageAdmission AddAdmissionFormobj = new SMSUI.ManageAdmission();

            AdmissionMainUG.Children.Clear();
            AdmissionMainUG.Children.Add(AddAdmissionFormobj);
        }
    }
}
