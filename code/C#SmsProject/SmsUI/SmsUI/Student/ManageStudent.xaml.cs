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
    /// Interaction logic for ManageStudent.xaml
    /// </summary>
    public partial class ManageStudent : UserControl
    {
        public ManageStudent()
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

       
        #region Delete Student Info

        private StudentInfo GetSelectedStudentItemforDel()
        {

            StudentInfo studentToDelete = null;

            if (manageStudentView.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select an Item");

            }
            else
            {
                StudentInfo i = (StudentInfo)manageStudentView.SelectedItem;

                studentToDelete = _allstudentCollection.Where(item => item.id.Equals(i.id)).First();
            }

            return studentToDelete;
        }

        private void delstudentBtn_Click(object sender, RoutedEventArgs e)
        {
            StudentInfo studentToDelete = GetSelectedStudentItemforDel();
            if (studentToDelete != null)
            {
                allstudentCollection.Remove(studentToDelete);
                SmsDb.DbInteraction.DeleteStudent(studentToDelete.id);
                fetchStudentData();
            }
        }
        #endregion
    }
}
