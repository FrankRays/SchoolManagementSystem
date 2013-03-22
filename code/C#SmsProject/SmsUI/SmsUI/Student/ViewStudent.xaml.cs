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
    /// Interaction logic for ViewStudent.xaml
    /// </summary>
    public partial class ViewStudent : UserControl
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fetchStudentData();
        }

        ObservableCollection<StudentInfo> _allstudentCollection = new ObservableCollection<StudentInfo>();


        public ObservableCollection<StudentInfo> allstudentCollection
        {
            get
            {
                return _allstudentCollection;
            }
        }

        private void fetchStudentData()
        {
            List<StudentInfo> Students = DbInteraction.GetAllStudentList();

            _allstudentCollection.Clear();

            foreach (StudentInfo student in Students)
            {
                _allstudentCollection.Add(student);
            }
        }
    }
}
