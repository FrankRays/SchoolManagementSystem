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
    /// Interaction logic for TakeAttendance.xaml
    /// </summary>
    public partial class TakeAttendance : UserControl
    {
        public TakeAttendance()
        {
            InitializeComponent();
        }

        private void studentAtndnce_Click(object sender, RoutedEventArgs e)
        {
            teacherLBL.Visibility = Visibility.Collapsed;
            atdntforTeacherCombobox.Visibility = Visibility.Collapsed;

            studentLBL.Visibility = Visibility.Visible;
            atdntforStudentCombobox.Visibility = Visibility.Visible;

            classLBl.Visibility = Visibility.Visible;
            ClassTxtbox.Visibility = Visibility.Visible;
        }

        private void teacherAtndnce_Click(object sender, RoutedEventArgs e)
        {
            studentLBL.Visibility = Visibility.Collapsed;
            atdntforStudentCombobox.Visibility = Visibility.Collapsed;

            teacherLBL.Visibility = Visibility.Visible;
            atdntforTeacherCombobox.Visibility = Visibility.Visible;

            classLBl.Visibility = Visibility.Collapsed;
            ClassTxtbox.Visibility = Visibility.Collapsed;
        }

        
        #region Insert Attendance
        private void atdncSubmitBtn_Click(object sender, RoutedEventArgs e)
        {

            //if (!nameTB.Text.Equals("") && !BrandTB.Text.Equals("") && !ProductypeCB.Text.Equals("") && !productdescriptionTB.Text.Equals(""))
            //{
            SmsData.AttendanceInfo newAttendance = new SmsData.AttendanceInfo();

            newAttendance.id = GenerateId();

            newAttendance.atnddate = atnddateDatepicker.SelectedDate.Value;
            newAttendance.stuname = atdntforStudentCombobox.Text;
            newAttendance.tchrname = atdntforTeacherCombobox.Text;
            newAttendance.stuclass = ClassTxtbox.Text;
            newAttendance.present = presentCB.Text;



            SmsDb.DbInteraction.DoEnterAttendance(newAttendance);
                //clearProductFields();
                //fetchProductData();
                //takepic();
            //}
            //else
            //{
            //    MessageBox.Show("Please Insert Info Properly");
            //}

        }

        private string GenerateId()
        {
            return DateTime.Now.ToOADate().ToString();
        }
        #endregion
    }
}
