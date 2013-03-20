using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolManagementData;

namespace SchoolManagementSystem
{
    public class AdmissionController
    {
        CourseController course;
        List<StudentInfo> registeredStudents;
    }

    public class StudentController
    {
        List<StudentInfo> students;
    }
    public class FacultyController
    {
        List<FacultyInfo> faculties;
    }
    public class CourseController
    {
        int maxStudents;
        int minFaculties;
        int noOfDays;
        List<CourseInfo> coursesToBeTaught;
    }
    public class AttendanceLeaveController
    {
        int minAttendance;
        List<DateTime> classDays;
        List<DateTime> holidays;
    }
    public class LibraryController
    {
        List<BookInfo> books;
    }
    public class AccountsController
    {
        List<TransactionInfo> coursesToBeTaught;
    }
    public class AdministrationController
    {
        AccountsController accounts;
        AdministrationController admission;
        StudentController studentsCon;
        FacultyController facultyCon;
        AttendanceLeaveController attCon;
        LibraryController lib;
    }

}
