using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmsData;

namespace SmsDb
{
    public class DbInteraction
    {
        static string passwordCurrent = "technicise";
        static string dbmsCurrent = "schooldb";

        private static MySql.Data.MySqlClient.MySqlConnection OpenDbConnection()
        {
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = null;

            msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=root;Password=" + passwordCurrent + ";database=" + dbmsCurrent + ";persist security info=False");

            //open the connection
            if (msqlConnection.State != System.Data.ConnectionState.Open)
                msqlConnection.Open();

            return msqlConnection;
        }

        #region Student

        public static int RegisterNewStudent(StudentInfo NewStudent)
        {
            int returnVal = 0;
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = OpenDbConnection();

            try
            {
                //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();

                //define the connection used by the command object
                msqlCommand.Connection = msqlConnection;

                msqlCommand.CommandText = "INSERT INTO student(id,name,guardian,address,phone,dob,bloodGroup,joinClass,schoolFrom,joinDate) " +
                                    "VALUES(@id,@name,@guardian,@address,@phone,@dob,@bloodGroup,@joinClass,@schoolFrom,@joinDate)";

                msqlCommand.Parameters.AddWithValue("@id", NewStudent.id);
                msqlCommand.Parameters.AddWithValue("@name", NewStudent.name);
                msqlCommand.Parameters.AddWithValue("@guardian", NewStudent.gurdain);
                msqlCommand.Parameters.AddWithValue("@address", NewStudent.address);
                msqlCommand.Parameters.AddWithValue("@phone", NewStudent.phone);
                msqlCommand.Parameters.AddWithValue("@dob", NewStudent.dob);
                msqlCommand.Parameters.AddWithValue("@bloodGroup", NewStudent.blodGroup);
                msqlCommand.Parameters.AddWithValue("@joinClass", NewStudent.joinClass);
                msqlCommand.Parameters.AddWithValue("@schoolFrom", NewStudent.schoolFrom);
                msqlCommand.Parameters.AddWithValue("@joinDate", NewStudent.joinDate);

                msqlCommand.ExecuteNonQuery();

                returnVal = 1;
            }
            catch (Exception er)
            {
                returnVal = 0;
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }
            return returnVal;
        }

        #endregion

        #region Admission

        public static int RegisterNewAdmissionForm(AdmissionInfo NewAdmissionForm)
        {
            int returnVal = 0;
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = OpenDbConnection();

            try
            {
                //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();

                //define the connection used by the command object
                msqlCommand.Connection = msqlConnection;

                msqlCommand.CommandText = "INSERT INTO admission(id,name,grdain,address,phone,applyfor,qualification,marksprcntg,formNo) " +
                                                         "VALUES(@id,@name,@grdain,@address,@phone,@applyfor,@qualification,@marksprcntg,@formNo)";

                msqlCommand.Parameters.AddWithValue("@id", NewAdmissionForm.id);
                msqlCommand.Parameters.AddWithValue("@name", NewAdmissionForm.name);
                msqlCommand.Parameters.AddWithValue("@grdain", NewAdmissionForm.grdain);
                msqlCommand.Parameters.AddWithValue("@address", NewAdmissionForm.address);
                msqlCommand.Parameters.AddWithValue("@phone", NewAdmissionForm.phone);
                msqlCommand.Parameters.AddWithValue("@applyfor", NewAdmissionForm.applyfor);
                msqlCommand.Parameters.AddWithValue("@qualification", NewAdmissionForm.qualification);
                msqlCommand.Parameters.AddWithValue("@marksprcntg", NewAdmissionForm.marksprcntg);
                msqlCommand.Parameters.AddWithValue("@formNo", NewAdmissionForm.formNo);

                msqlCommand.ExecuteNonQuery();

                returnVal = 1;
            }
            catch (Exception er)
            {
                returnVal = 0;
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }
            return returnVal;
        }

        #endregion
      
    }
}
