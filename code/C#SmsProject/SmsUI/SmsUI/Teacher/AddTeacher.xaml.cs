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
    /// Interaction logic for AddTeacher.xaml
    /// </summary>
    public partial class AddTeacher : UserControl
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void teacherInfoSubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            SmsData.TeacherInfo newTeacher = new SmsData.TeacherInfo();

            newTeacher.id = GenerateId();
            newTeacher.name = teacherNameTxtbox.Text;
            newTeacher.join = teacherJoinDatePicker.SelectedDate.Value;
            newTeacher.tdob = teacherDobDatepicker.SelectedDate.Value;
            newTeacher.address = teacherAddressTxtbox.Text;
            newTeacher.phone = teacherPhoneNumberTxtbox.Text;
            newTeacher.email = teacherEmailTxtbox.Text;
            newTeacher.jobId = teacherjobIdTxtbox.Text;
            newTeacher.faculty = teacherFacultyTxtbox.Text;
            newTeacher.salary = teacherSalaryTxtbox.Text;



            SmsDb.DbInteraction.RegisterNewTeacher(newTeacher);

        }
        private string GenerateId()
        {
            return DateTime.Now.ToOADate().ToString();
        }
    }
}
