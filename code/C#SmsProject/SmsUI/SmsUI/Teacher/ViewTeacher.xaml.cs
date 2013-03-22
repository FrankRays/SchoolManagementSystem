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
using System.Collections.ObjectModel;

namespace SMSUI
{
    /// <summary>
    /// Interaction logic for ViewTeacher.xaml
    /// </summary>
    public partial class ViewTeacher : UserControl
    {
        public ViewTeacher()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fetchTeacherData();
        }

        ObservableCollection<TeacherInfo> _allTeacherCollection = new ObservableCollection<TeacherInfo>();


        public ObservableCollection<TeacherInfo> allTeacherCollection
        {
            get
            {
                return _allTeacherCollection;
            }
        }

        private void fetchTeacherData()
        {
            List<TeacherInfo> Teachers = DbInteraction.GetAllResidenceList();

            _allTeacherCollection.Clear();

            foreach (TeacherInfo Teacher in Teachers)
            {
                _allTeacherCollection.Add(Teacher);
            }
        }
    }
}
