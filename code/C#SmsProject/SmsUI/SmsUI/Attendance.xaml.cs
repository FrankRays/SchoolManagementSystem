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
    /// Interaction logic for Attendance.xaml
    /// </summary>
    public partial class Attendance : UserControl
    {
        public Attendance()
        {
            InitializeComponent();

            SMSUI.TakeAttendance ViewAttendance = new SMSUI.TakeAttendance();

            attendanceUG.Children.Clear();
            attendanceUG.Children.Add(ViewAttendance);
        }

        private void takeAttendanceBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.TakeAttendance ViewAttendance = new SMSUI.TakeAttendance();

            attendanceUG.Children.Clear();
            attendanceUG.Children.Add(ViewAttendance);
        }

        private void viewAttendanceBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.ViewAttendance ViewAttendance = new SMSUI.ViewAttendance();

            attendanceUG.Children.Clear();
            attendanceUG.Children.Add(ViewAttendance);
        }
    }
}
