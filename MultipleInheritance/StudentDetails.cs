

namespace MultipleInheritance
{
    //Multiple Inhertiance can be acheived by having more than 2 Inheritance
    //C# doesn't support Inheritance with two classes so it is acheived by interfaces
    public class StudentDetails:AaadharRegistration,IMarks
    {
        private int s_studentID=100;
        public int StudentID { get; set; }
        public string Standard { get; set; }

         public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }

        public void GetMarks(int physics,int chemistry,int maths)
        {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public string ShowMarks()
        {
            return $"Physics : {Physics} Chemistry : {Chemistry} Maths : {Maths}";
        }
        
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