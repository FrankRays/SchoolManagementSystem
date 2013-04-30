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

        #region Insert 

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
        #region Show

        public static List<StudentInfo> GetAllStudentList()
        {
            return QueryAllStudentList();
        }
        private static List<StudentInfo> QueryAllStudentList()
        {
            List<StudentInfo> StudentList = new List<StudentInfo>();

            MySql.Data.MySqlClient.MySqlConnection msqlConnection = OpenDbConnection();

            try
            {   //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
                msqlCommand.Connection = msqlConnection;

                msqlCommand.CommandText = "Select * From student ;";
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();

                while (msqlReader.Read())
                {
                    StudentInfo Student = new StudentInfo();

                    Student.id = msqlReader.GetString("id");
                    Student.name = msqlReader.GetString("name");
                    Student.gurdain = msqlReader.GetString("guardian");
                    Student.address = msqlReader.GetString("address");
                    Student.phone = msqlReader.GetString("phone");
                    Student.dob = msqlReader.GetDateTime("dob");
                    Student.blodGroup = msqlReader.GetString("bloodGroup");
                    Student.joinClass = msqlReader.GetString("joinClass");
                    Student.schoolFrom = msqlReader.GetString("schoolFrom");
                    Student.joinDate = msqlReader.GetDateTime("joinDate");


                    StudentList.Add(Student);
                }

            }
            catch (Exception er)
            {
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }

            return StudentList;
        }
        #endregion

        #region Delete Student Info

        public static void DeleteStudent(string studentToDelete)
        {
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = OpenDbConnection();

            try
            {   //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
                msqlCommand.Connection = msqlConnection;

                msqlCommand.CommandText = "DELETE FROM student WHERE id=@studentToDelete";
                msqlCommand.Parameters.AddWithValue("@studentToDelete", studentToDelete);

                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();

            }
            catch (Exception er)
            {
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }
        }

        #endregion
        #endregion

        #region Admission

        #region insert
        public static int RegisterNewAdmission(AdmissionInfo NewAdmissionForm)
        {
            return RegisterNewAdmissionForm(NewAdmissionForm);
        }


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

                msqlCommand.CommandText = "INSERT INTO admission(id,name,gurdian,address,phone,applyfor,qualification,marksprcntg,formNo) " +
                                                         "VALUES(@id,@name,@gurdian,@address,@phone,@applyfor,@qualification,@marksprcntg,@formNo)";

                msqlCommand.Parameters.AddWithValue("@id", NewAdmissionForm.id);
                msqlCommand.Parameters.AddWithValue("@name", NewAdmissionForm.name);
                msqlCommand.Parameters.AddWithValue("@gurdian", NewAdmissionForm.grdain);
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

        #region show
        public static List<AdmissionInfo> GetAllAdmissionList()
        {
            return QueryAllAdmissionListinDb();
        }
        private static List<AdmissionInfo> QueryAllAdmissionListinDb()
        {
            List<AdmissionInfo> AdmissionList = new List<AdmissionInfo>();

            MySql.Data.MySqlClient.MySqlConnection msqlConnection = OpenDbConnection();

            try
            {   //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
                msqlCommand.Connection = msqlConnection;

                msqlCommand.CommandText = "Select * From admission ;";
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();

                while (msqlReader.Read())
                {
                    AdmissionInfo Admission = new AdmissionInfo();

                    Admission.id = msqlReader.GetString("id");
                    Admission.name = msqlReader.GetString("name");
                    Admission.grdain = msqlReader.GetString("gurdian");
                    Admission.address = msqlReader.GetString("address");
                    Admission.phone = msqlReader.GetString("phone");
                    Admission.applyfor = msqlReader.GetString("applyfor");
                    Admission.qualification = msqlReader.GetString("qualification");
                    Admission.marksprcntg = msqlReader.GetString("marksprcntg");
                    Admission.formNo = msqlReader.GetString("formNo");

                    AdmissionList.Add(Admission);
                }

            }
            catch (Exception er)
            {
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }

            return AdmissionList;
        }
        #endregion
        #region Delete Admission Info

        public static void DeleteAdmission(string admissionToDelete)
        {
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = OpenDbConnection();

            try
            {   //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
                msqlCommand.Connection = msqlConnection;

                msqlCommand.CommandText = "DELETE FROM admission WHERE id=@admissionToDelete";
                msqlCommand.Parameters.AddWithValue("@admissionToDelete", admissionToDelete);

                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();

            }
            catch (Exception er)
            {
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }
        }

        #endregion


        #endregion

        #region Teacher

        #region Insert

        public static int RegisterNewTeacher(TeacherInfo NewTeacher)
        {
            return DoRegisterNewTeacherindb(NewTeacher);
        }

        private static int DoRegisterNewTeacherindb(TeacherInfo NewTeacher)
        {
            int returnVal = 0;
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = OpenDbConnection();
            try
            {
                //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();

                //define the connection used by the command object
                msqlCommand.Connection = msqlConnection;

                msqlCommand.CommandText = "INSERT INTO teacher(id,name,joinDate,tdob,address,phone,email,jobId,faculty,salary) " +
                                    "VALUES(@id,@name,@joinDate,@tdob,@address,@phone,@email,@jobId,@faculty,@salary)";

                //msqlCommand.CommandText = "INSERT INTO teacher(id,name,guardian,address,phone,dob,bloodGroup,joinClass,schoolFrom,joinDate) " +
                //                   "VALUES(@id,@name,@guardian,@address,@phone,@dob,@bloodGroup,@joinClass,@schoolFrom,@joinDate)";


                msqlCommand.Parameters.AddWithValue("@id", NewTeacher.id);
                msqlCommand.Parameters.AddWithValue("@name", NewTeacher.name);
                msqlCommand.Parameters.AddWithValue("@joinDate", NewTeacher.joinDate);
                msqlCommand.Parameters.AddWithValue("@tdob", NewTeacher.tdob);
                msqlCommand.Parameters.AddWithValue("@address", NewTeacher.address);
                msqlCommand.Parameters.AddWithValue("@phone", NewTeacher.phone);
                msqlCommand.Parameters.AddWithValue("@email", NewTeacher.email);
                msqlCommand.Parameters.AddWithValue("@jobId", NewTeacher.jobId);
                msqlCommand.Parameters.AddWithValue("@faculty", NewTeacher.faculty);
                msqlCommand.Parameters.AddWithValue("@salary", NewTeacher.salary);

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


        public static List<TeacherInfo> GetAllResidenceList()
        {
            return QueryAllTeacherList();
        }
        private static List<TeacherInfo> QueryAllTeacherList()
        {
            List<TeacherInfo> TeacherList = new List<TeacherInfo>();

            MySql.Data.MySqlClient.MySqlConnection msqlConnection = OpenDbConnection();

            try
            {   //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
                msqlCommand.Connection = msqlConnection;

                msqlCommand.CommandText = "Select * From teacher ;";
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();

                while (msqlReader.Read())
                {
                    TeacherInfo Teacher = new TeacherInfo();

                    Teacher.id = msqlReader.GetString("id");
                    Teacher.name = msqlReader.GetString("name");
                    Teacher.joinDate = msqlReader.GetDateTime("joinDate");
                    Teacher.tdob = msqlReader.GetDateTime("tdob");
                    Teacher.address = msqlReader.GetString("address");
                    Teacher.phone = msqlReader.GetString("phone");
                    Teacher.email = msqlReader.GetString("email");
                    Teacher.jobId = msqlReader.GetString("jobId");
                    Teacher.faculty = msqlReader.GetString("faculty");
                    Teacher.salary = msqlReader.GetString("salary");


                    TeacherList.Add(Teacher);
                }

            }
            catch (Exception er)
            {
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }

            return TeacherList;
        }
        #endregion

        #region Delete Teacher Info

        public static void DeleteTeacher(string teacherToDelete)
        {
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = OpenDbConnection();

            try
            {   //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
                msqlCommand.Connection = msqlConnection;

                msqlCommand.CommandText = "DELETE FROM teacher WHERE id=@teacherToDelete";
                msqlCommand.Parameters.AddWithValue("@teacherToDelete", teacherToDelete);

                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();

            }
            catch (Exception er)
            {
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }
        }

        #endregion

        #endregion

        #region Insert Attendance

        public static int DoEnterAttendance(AttendanceInfo NewAttendance)
        {
            int returnVal = 0;
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = OpenDbConnection();

            try
            {
                //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();

                //define the connection used by the command object
                msqlCommand.Connection = msqlConnection;

                msqlCommand.CommandText = "INSERT INTO attendance(id,atnddate,stuname,tchrname,stuclass,present) " +
                                    "VALUES(@id,@atnddate,@stuname,@tchrname,@stuclass,@present)";

                msqlCommand.Parameters.AddWithValue("@id", NewAttendance.id);
                msqlCommand.Parameters.AddWithValue("@atnddate", NewAttendance.atnddate);
                msqlCommand.Parameters.AddWithValue("@stuname", NewAttendance.stuname);

                msqlCommand.Parameters.AddWithValue("@tchrname", NewAttendance.tchrname);
                msqlCommand.Parameters.AddWithValue("@stuclass", NewAttendance.stuclass);
                msqlCommand.Parameters.AddWithValue("@present", NewAttendance.present);

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

        #region Attendance

       
        public static List<AttendanceInfo> GetAllAttendanceList()
        {
            List<AttendanceInfo> AttendanceList = new List<AttendanceInfo>();

            MySql.Data.MySqlClient.MySqlConnection msqlConnection = OpenDbConnection();

            try
            {   //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
                msqlCommand.Connection = msqlConnection;

                msqlCommand.CommandText = "Select * From attendance ;";
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();

                while (msqlReader.Read())
                {
                    AttendanceInfo Attendance = new AttendanceInfo();

                    Attendance.id = msqlReader.GetString("id");
                    Attendance.atnddate = msqlReader.GetDateTime("atnddate");
                    Attendance.stuname = msqlReader.GetString("stuname");
                    Attendance.tchrname = msqlReader.GetString("tchrname");
                    Attendance.stuclass = msqlReader.GetString("stuclass");
                    Attendance.present = msqlReader.GetString("present");


                    AttendanceList.Add(Attendance);
                }

            }
            catch (Exception er)
            {
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }

            return AttendanceList;
        }
        #endregion

    }
}
