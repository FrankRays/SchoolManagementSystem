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
    /// Interaction logic for ManageAdmission.xaml
    /// </summary>
    public partial class ManageAdmission : UserControl
    {
        public ManageAdmission()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fetchAdmissionData();
        }

        ObservableCollection<AdmissionInfo> _allAdmissionFormCollection = new ObservableCollection<AdmissionInfo>();


        public ObservableCollection<AdmissionInfo> allAdmissionFormCollection
        {
            get
            {
                return _allAdmissionFormCollection;
            }
        }

        private void fetchAdmissionData()
        {
            List<AdmissionInfo> Admissions = DbInteraction.GetAllAdmissionList();

            _allAdmissionFormCollection.Clear();

            foreach (AdmissionInfo admission in Admissions)
            {
                _allAdmissionFormCollection.Add(admission);
            }
        }

        

        #region Delete Admission Info

        private AdmissionInfo GetSelectedAdmissionItemforDel()
        {

            AdmissionInfo admissionToDelete = null;

            if (manageAdmissionView.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select an Item");

            }
            else
            {
                AdmissionInfo i = (AdmissionInfo)manageAdmissionView.SelectedItem;

                admissionToDelete = _allAdmissionFormCollection.Where(item => item.id.Equals(i.id)).First();
            }

            return admissionToDelete;
        }

        private void delAdmission_Click(object sender, RoutedEventArgs e)
        {
            AdmissionInfo admissionToDelete = GetSelectedAdmissionItemforDel();
            if (admissionToDelete != null)
            {
                allAdmissionFormCollection.Remove(admissionToDelete);
                SmsDb.DbInteraction.DeleteAdmission(admissionToDelete.id);
                fetchAdmissionData();
            }
        }
        #endregion

        private void editAdmission_Click(object sender, RoutedEventArgs e)
        {
            //SMSUI.ViewForm ViewFormobj = new SMSUI.ViewForm();
            //var AdmissionForm = new AdmissionForm(); // or use the existing instance of Window1
            //AdmissionForm.Click(addAdmissionFormBtn);

            //SMSUI.AdmissionForm objAdmissionForm = new SMSUI.AdmissionForm();

            //objAdmissionFormAdmissionMainUG.Children.Clear();
            //objAdmissionFormAdmissionMainUG.Children.Add(ViewFormobj);
        }
    }
}
