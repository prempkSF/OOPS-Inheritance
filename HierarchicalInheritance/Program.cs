
namespace HierarchicalInheritance;

class Program 
{
    // MultiLevelInheritance GrandParent --> Parent --> Child
    //So Child can inherit the properties of GrandParent
    public static void Main(string[] args)
    {
        //Parent Class Instance
        // BirthRegistration birthRegistration=new BirthRegistration("Prem","Kumar","21/02/2003","28/02/2003","male");
        //Derived Class Instance with Parent Class Property Values
        // AaadharRegistration aaadharRegistration=new AaadharRegistration(birthRegistration.RegistrationID,"Prs","Kumar","28/12/2000","30/12/2000","male","Balaji Avenue");

        // System.Console.WriteLine(birthRegistration.DisplayBirthRegistration());

        // System.Console.WriteLine(aaadharRegistration.DisplayAaadharRegistration());

        //Child Instance
        // StudentDetails studentDetails=new StudentDetails(101,"Prem","Kumar","21/02/2003","28/02/2003","male",1001,"Balaji Avenue","12th");
        //Child Method
        // System.Console.WriteLine(studentDetails.DisplayStudentDetails());


        //Hierarchical Inheritance
        VoterRegistration voterRegistration=new VoterRegistration(101,"Prem","Kumar","21/02/2003","28/02/2003","male",1001,"Chemmal Avenue","Shenoy Nagar");
        System.Console.WriteLine(voterRegistration.DisplayVoterRegistration());
    }
}