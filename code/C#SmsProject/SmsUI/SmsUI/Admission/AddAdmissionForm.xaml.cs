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

namespace SMSUI
{
    /// <summary>
    /// Interaction logic for AddAdmissionForm.xaml
    /// </summary>
    public partial class AddAdmissionForm : UserControl
    {
        public AddAdmissionForm()
        {
            InitializeComponent();
        }

        private void submitadmisionBtn_Click(object sender, RoutedEventArgs e)
        {
            SmsData.AdmissionInfo newAdmission = new SmsData.AdmissionInfo();

            newAdmission.id = GenerateId();
            newAdmission.name = nameTxtbox.Text;
            newAdmission.grdain = GuardianNameTxtbox.Text;
            newAdmission.address = studentAddressTxtbox.Text;
            newAdmission.phone = PhoneNumberTxtbox.Text;
            newAdmission.applyfor = applyForTxtbox.Text;
            newAdmission.qualification = QualificationTxtbox.Text;
            newAdmission.marksprcntg = prcntMarksTxtbox.Text;
            newAdmission.formNo = formNoTxtbox.Text;



            SmsDb.DbInteraction.RegisterNewAdmission(newAdmission);
            
        }
        private string GenerateId()
        {
            return DateTime.Now.ToOADate().ToString();
        }
        
    }
}
