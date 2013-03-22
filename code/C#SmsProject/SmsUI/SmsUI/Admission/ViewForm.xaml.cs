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
    /// Interaction logic for ViewForm.xaml
    /// </summary>
    public partial class ViewForm : UserControl
    {
        public ViewForm()
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
    }
}
