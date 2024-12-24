
namespace HierarchicalInheritance
{
    //Base Class (Parent Class)
    public class BirthRegistration
    {
        //Properties
        private static int s_registrationID=100;
        public int RegistrationID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string DateOfBirth { get; set; }
        public string RegistrationDate { get; set; }
        public string Gender { get; set; }

        //Default Constructor
        public BirthRegistration()
        {
            
        }

        //Parameter Constructor for General Purpose
        public BirthRegistration(string name,string fatherName,string dob,string registerDate,string gender)
        {
            s_registrationID++;
            RegistrationID=s_registrationID;
            Name=name;
            FatherName=fatherName;
            DateOfBirth=dob;
            RegistrationDate=registerDate;
            Gender=gender;
        }

        //Parameter Constructor for Derived Class
        public BirthRegistration(int registrationID,string name,string fatherName,string dob,string registerDate,string gender)
        {
            RegistrationID=registrationID;
            Name=name;
            FatherName=fatherName;
            DateOfBirth=dob;
            RegistrationDate=registerDate;
            Gender=gender;
        }
        public string DisplayBirthRegistration()
        {
            return $"Birth RegistrationID : {RegistrationID} Name : {Name} Father Name : {FatherName} Date Of Birth : {DateOfBirth} Registration Date : {RegistrationDate} Gender : {Gender}";
        }
    }
}