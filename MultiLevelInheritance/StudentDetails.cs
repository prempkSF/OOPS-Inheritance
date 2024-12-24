

namespace MultiLevelInheritance
{
    public class StudentDetails:AaadharRegistration
    {
        private int s_studentID=100;
        public int StudentID { get; set; }
        public string Standard { get; set; }
        
        //Here passing from Child to Parent and Parent to Grand Parent Class
        //StudentDetails --> AaadharRegistration --> BirthRegistration
        //Getting all the data for classes and passing using base()
        public StudentDetails(int registrationID,string name,string fatherName,string dob,string registerDate,string gender,int aaadharRegistrationID,string address,string standard):base(registrationID,name,fatherName,dob,registerDate,gender,aaadharRegistrationID,address)
        {
            s_studentID++;
            StudentID=s_studentID;
            Standard=standard;
        }

        //Method can Access Grand Parent and Parent class Methods
        public string DisplayStudentDetails()
        {
            return $"Student ID : {StudentID} Standard : {Standard} {DisplayAaadharRegistration()}";
        }
    }
}