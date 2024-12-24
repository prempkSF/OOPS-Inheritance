﻿using System;

namespace SingleInheritance;

class Program 
{
    public static void Main(string[] args)
    {
        //Parent Class Instance
        BirthRegistration birthRegistration=new BirthRegistration("Prem","Kumar","21/02/2003","28/02/2003","male");
        //Derived Class Instance with Parent Class Property Values
        AaadharRegistration aaadharRegistration=new AaadharRegistration(birthRegistration.RegistrationID,"Prs","Kumar","28/12/2000","30/12/2000","male","Balaji Avenue");

        System.Console.WriteLine(birthRegistration.DisplayBirthRegistration());

        System.Console.WriteLine(aaadharRegistration.DisplayAaadharRegistration());
    }
}