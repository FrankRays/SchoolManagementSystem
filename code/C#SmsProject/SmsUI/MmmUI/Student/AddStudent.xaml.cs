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
using SmsData;
using SmsDb;

namespace SMSUI
{
    /// <summary>
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : UserControl
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void studentInfoSubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            SmsData.StudentInfo newStudent = new SmsData.StudentInfo();

            newStudent.id = GenerateId();
            newStudent.name = studentNameTxtbox.Text;
            newStudent.gurdain = GuardianNameTxtbox.Text;
            newStudent.address = addressTxtbox.Text;
            newStudent.phone = phoneNoTxtbox.Text;
            newStudent.dob = dobDatepicker.SelectedDate.Value;
            newStudent.blodGroup = bloodGroupTxtbox.Text;
            newStudent.joinClass = joinClassTxtbox.Text;
            newStudent.schoolFrom = schoolFromTxtbox.Text;
            newStudent.joinDate = joinDatePicker.SelectedDate.Value;

            

            SmsDb.DbInteraction.RegisterNewStudent(newStudent);
            
        }
        private string GenerateId()
        {
            return DateTime.Now.ToOADate().ToString();
        }

    }
}
