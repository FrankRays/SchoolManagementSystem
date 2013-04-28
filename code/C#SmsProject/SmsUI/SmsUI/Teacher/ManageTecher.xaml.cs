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
    /// Interaction logic for ManageTeacher.xaml
    /// </summary>
    public partial class ManageTeacher : UserControl
    {
        public ManageTeacher()
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

        #region Delete Teacher Info

        private TeacherInfo GetSelectedTeacherItemforDel()
        {

            TeacherInfo teacherToDelete = null;

            if (manageTeacherView.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select an Item");

            }
            else
            {
                TeacherInfo i = (TeacherInfo)manageTeacherView.SelectedItem;

                teacherToDelete = _allTeacherCollection.Where(item => item.id.Equals(i.id)).First();
            }

            return teacherToDelete;
        }

        private void deleteTeacherBtn_Click(object sender, RoutedEventArgs e)
        {
            TeacherInfo teacherToDelete = GetSelectedTeacherItemforDel();
            if (teacherToDelete != null)
            {
                allTeacherCollection.Remove(teacherToDelete);
                SmsDb.DbInteraction.DeleteTeacher(teacherToDelete.id);
                fetchTeacherData();
            }
        }
        #endregion
    }
}
