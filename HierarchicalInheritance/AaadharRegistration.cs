
namespace HierarchicalInheritance
{
    //Derived Class (Child Class)
    //Derived Class:Base Class
    //Derived Class needs an Default Constructor of Parent Class to be declared
    public class AaadharRegistration:BirthRegistration
    {
        private static int s_aadharRegistrationID=100;
        public static int AaadharRegistrationID{get; set;}
        public string Address { get; set; }

        //Here for creating a dervied class object need to get the properties of parent class and pass those values to parent class parameter constructor
        public AaadharRegistration(int registrationID,string name,string fatherName,string dob,string registrationDate,string gender,string address):base(registrationID, name,fatherName,dob,registrationDate,gender)
        {
            s_aadharRegistrationID++;
            AaadharRegistrationID=s_aadharRegistrationID;
            Address=address;
        }

        //From Child Class Student Details
        public AaadharRegistration(int registrationID,string name,string fatherName,string dob,string registrationDate,string gender,int aaadharRegistrationID,string address):base(registrationID, name,fatherName,dob,registrationDate,gender)
        {
            
            AaadharRegistrationID=aaadharRegistrationID;
            Address=address;
        }
        public string DisplayAaadharRegistration()
        {
            return $"Aadhar Registration : {AaadharRegistrationID} {DisplayBirthRegistration()} Address : {Address}";
        }
    }
}