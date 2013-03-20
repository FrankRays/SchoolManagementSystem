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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        
        private void TeacherBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.Teacher Teacherobj = new SMSUI.Teacher();

            mainUniGrid.Children.Clear();
            mainUniGrid.Children.Add(Teacherobj);

            
        }

        private void StudentsBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.Student Studentobj = new SMSUI.Student();

            mainUniGrid.Children.Clear();
            mainUniGrid.Children.Add(Studentobj);
        }

        private void Attendance_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.Attendance Attendanceobj = new SMSUI.Attendance();

            mainUniGrid.Children.Clear();
            mainUniGrid.Children.Add(Attendanceobj);
        }

        private void admissionBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.AdmissionForm AdmissionFormobj = new SMSUI.AdmissionForm();

            mainUniGrid.Children.Clear();
            mainUniGrid.Children.Add(AdmissionFormobj);
        
        }

        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.Settings Settingsobj = new SMSUI.Settings();

            mainUniGrid.Children.Clear();
            mainUniGrid.Children.Add(Settingsobj);
        }

        private void helpBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.Help Helpobj = new SMSUI.Help();

            mainUniGrid.Children.Clear();
            mainUniGrid.Children.Add(Helpobj);
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void noticeBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.Notice Noticeobj = new SMSUI.Notice();

            mainUniGrid.Children.Clear();
            mainUniGrid.Children.Add(Noticeobj);
        }

        private void dologinBtn_Click(object sender, RoutedEventArgs e)
        {

            if (userNameTxtbox.Text.Equals("1") && userNameTxtbox.Text.Equals("1"))
            {
                TeacherBtn.IsEnabled = true;
                StudentsBtn.IsEnabled = true;
                admissionBtn.IsEnabled = true;
                AttendanceBtn.IsEnabled = true;
                settingsBtn.IsEnabled = true;
                noticeBtn.IsEnabled = true;
                helpBtn.IsEnabled = true;
                logoutBtn.Visibility = Visibility.Visible;
                loginBtn.Visibility = Visibility.Collapsed;
                SMSUI.Attendance Attendanceobj = new SMSUI.Attendance();

                mainUniGrid.Children.Clear();
                mainUniGrid.Children.Add(Attendanceobj);
            }
            else
                MessageBox.Show("Enter correct Info");

        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            TeacherBtn.IsEnabled = false;
            StudentsBtn.IsEnabled = false;
            admissionBtn.IsEnabled = false;
            AttendanceBtn.IsEnabled = false;
            settingsBtn.IsEnabled = false;
            noticeBtn.IsEnabled = false;
            helpBtn.IsEnabled = false;
            loginBtn.Visibility = Visibility.Visible;
            logoutBtn.Visibility = Visibility.Collapsed;

            mainUniGrid.Children.Clear();
            mainUniGrid.Children.Add(loginDP);
        }
    }
}
