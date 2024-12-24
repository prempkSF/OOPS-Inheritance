

namespace MultipleInheritance
{
    //Hierarchical Inheritance
    //Base class can have more than one dervied Class
    //Here Aaadhar class --> Base Class has Student and Voter Classes as its Derived Class
    public class VoterRegistration:AaadharRegistration
    {
        private static int s_voterRegistrationID=0;
        public int VoterRegistrationID { get; set; }
        public string AssemblyConstituency { get; set; }

        public VoterRegistration(int registrationID,string name,string fatherName,string dob,string registrationDate,string gender,int aaadharRegistrationID,string address,string assemblyConstituency):base(registrationID,name,fatherName,dob,registrationDate,gender,aaadharRegistrationID,address)
        {
            s_voterRegistrationID++;
            VoterRegistrationID=s_voterRegistrationID;
            AssemblyConstituency=assemblyConstituency;
        }

        public string DisplayVoterRegistration()
        {
            return $"Voter Registration ID : {VoterRegistrationID} {DisplayAaadharRegistration()} Assembly Constituency : {AssemblyConstituency}";
        }
    }
}