using System;
using System.Collections.Generic;
u

public class ClubRole
{
    private string name;
    private string role;
    private string contactInfo;
    public string Name { get { return name; } set { name = value; }}
    public string Role { get { return role; } set { role = value; } }
    public string ContactInfo { get { return contactInfo; } set { contactInfo = value; } }
}
public class StudentClub 
{
    private double budget;
    public double Budget { get { return budget; } set { budget = value; } }
    private string president;
    public string President { get { return president; } set { president = value; } }
    private string vicePresedent;
    public string VicePresedent { get { return president; } set { president = value; } }

    private ClubRole generalSecretary;
    private ClubRole financeSecretary;

    List<Society> society = new List<Society>();
    List<FundedSociety> fundingList= new List<FundedSociety>();
    FundedSociety tempFund=new FundedSociety();
    Society tempS = new Society();


    public void registerSociety()
    {

        Console.Write("Enter the name of new society : ");
        tempS.Name=Console.ReadLine();
        society.Add(tempS);
    }

    public void fundedSociety()
    {

        Console.Write("Enter the name of society : ");
        tempFund.Name=Console.ReadLine();
        Console.WriteLine("Proceed with caution.");
        Console.WriteLine("Fund will be calculated on the bases of how many members has joined this society.");
        Console.WriteLine("Rs/500 per member.");
        Console.Write("Enter the number of members joined in this society :");
        int input=int.Parse(Console.ReadLine());

        tempFund.FundingAmount= input * 500;
        fundingList.Add(tempFund);


    }
    public void dispenseFunds()
    {
        foreach(var a in fundingList)
        {
            Console.Write($"Society under name {a.Name} funds are {a.FundingAmount}");
        }

    }
    

}
public class Society
{
    private string name;
    private string contact;
    public string Name {get { return name; } set { name = value; } }
    public string Contact { get { return contact; } set { contact = value; } }

    List<ClubRole> clubRole = new List<ClubRole>();
    ClubRole tempClubRole = new ClubRole();
    public void addActivity(){
        Console.Write("Name of society : ");
        tempClubRole.Name = Console.ReadLine();
   
            Console.Write($"Name of activity:");
            tempClubRole.Role= Console.ReadLine();
            Console.Write("Enter contact information:");
            tempClubRole.ContactInfo = Console.ReadLine();
            clubRole.Add(tempClubRole);
    
    }
    public void listEvents()
    {
        Console.WriteLine("Listed Events are this ");
        foreach( var a in clubRole)
        {
            Console.WriteLine($"{a.Name:10} {a.Role:10} {a.ContactInfo:10}");
        }
    }
 

}

public class FundedSociety :Society{
    private double fundingAmount;
    public double FundingAmount { get { return fundingAmount; } set { fundingAmount = value; } }

    private string name;
    public string Name { get { return name; } set { name = value; } }

}
public class NonFundedSociety : Society 
{
}

public class User
{
    public static void Main()
    {
        int a=0;
        StudentClub obj = new StudentClub();
        Society society = new Society();
        do
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Student Club Management System");
            Console.WriteLine("1. Register a new society");
            Console.WriteLine("2. Allocate funding to society");
            Console.WriteLine("3. Register an event to societ");
            Console.WriteLine("4. Display society funding information");
            Console.WriteLine("5. Display events for society");
            Console.WriteLine("6. Exit");
            a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                obj.registerSociety();
            }
            else if (a == 2)
            {

                obj.fundedSociety();
            }
            else if (a == 3)
            {
                obj.dispenseFunds();

            }
            else if (a == 4) {
                society.listEvents();

            }
            else if (a == 5)
            {
                society.listEvents();
            }
        } while (a!=6);
    }
}
