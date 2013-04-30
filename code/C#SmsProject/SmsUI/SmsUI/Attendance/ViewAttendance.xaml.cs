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
using SmsDb;
using SmsData;
using System.Collections.ObjectModel;

namespace SMSUI
{
    /// <summary>
    /// Interaction logic for ViewAttendance.xaml
    /// </summary>
    public partial class ViewAttendance : UserControl
    {
        public ViewAttendance()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fetchAttendanceData();
        }

        ObservableCollection<AttendanceInfo> _allAttendanceCollection = new ObservableCollection<AttendanceInfo>();


        public ObservableCollection<AttendanceInfo> allAttendanceCollection
        {
            get
            {
                return _allAttendanceCollection;
            }
        }

        private void fetchAttendanceData()
        {
            List<AttendanceInfo> Attendances = DbInteraction.GetAllAttendanceList();

            _allAttendanceCollection.Clear();

            foreach (AttendanceInfo Attendance in Attendances)
            {
                _allAttendanceCollection.Add(Attendance);
            }
        }
    }
}
