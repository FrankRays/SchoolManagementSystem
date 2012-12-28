using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagementData
{
    public class StudentInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string bloodGroup { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public DateTime admissionDate { get; set; }
        public DateTime dob { get; set; }
    }

    public class CourseInfo
    {
        public string id { get; set; }
        public string eventTitle { get; set; }
        public DateTime eventDoe { get; set; }
        public string eventVenue { get; set; }
        public string eventGoal { get; set; }
    }

    public class ExpenseInfo
    {
        public string id { get; set; }
        public string purpose { get; set; }
        public DateTime doe { get; set; }
        public string expensed_by { get; set; }
        public double amount { get; set; }
    }

    public class FundInfo
    {
        public string id { get; set; }
        public string wellwisher_name { get; set; }
        public string contact { get; set; }
        public DateTime dod { get; set; }
        public string received_by { get; set; }
        public double amount { get; set; }
    }

    public class FacultyInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public DateTime doj { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public List<string> qualifications { get; set; }
        public List<string> courses { get; set; }
    }

    public class TransactionInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public double amount { get; set; }
        public string type { get; set; }
        public string reason { get; set; }
        public string receivedFrom { get; set; }
        public string receivedBy { get; set; }
        public DateTime date { get; set; }
    }

    public class BookInfo
    {
        public string id { get; set; }
        public DateTime issueDate { get; set; }
        public List<string> author { get; set; }
        public List<string> tag { get; set; }
    }

    public class WellWisherInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public DateTime doj { get; set; }
        public string phone { get; set; }
        public string remarks { get; set; }
    }

    public class AdmissionInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string purpose { get; set; }
        public int ageLimit { get; set; }
        public string Venue { get; set; }
        public string coordinatorPhone { get; set; }
        public string admittedAddress { get; set; }
        public DateTime examDate { get; set; }
        public DateTime resultDate { get; set; }
        public List<string> subjects { get; set; }
        public int numberOfSeats { get; set; }
    }


}
