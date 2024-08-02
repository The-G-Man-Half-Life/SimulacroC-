using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroPruebaDeDesempeñoDelModuloC_.Models;

public class Customer: User
{
    public string MembershipLevel {get; set;}
    public string PreferredPaymentMethod {get; set;}

//constructor
    public Customer(string Name,string LastName,string TypeDocument,string IdentificationNumber,DateOnly BirthDate,string Email,string PhoneNumber,string Address,string MembershipLevel,string PreferredPaymentMethod):base(Name,LastName,TypeDocument,IdentificationNumber,BirthDate,Email,PhoneNumber,Address)
    {
        this.MembershipLevel = MembershipLevel;
        this.PreferredPaymentMethod = PreferredPaymentMethod;
    }

//requested method
    public static void UpdateMembershipLevel(List<Customer> list)
    { 
        string membershiplevel= "";
        int CustomerUbication = 0;
        while(true)
        {
        Console.Write("Enter your identification number: ");
        int identificationNumber = verificationSystem.verificateCustomerExistence(list,"Enter your identification number: ");
        
        if(identificationNumber==-1)
        {
            Console.WriteLine("The id does not exist pls try again");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Enter your identification number: ");
        }
        else
        {
            CustomerUbication= identificationNumber;
            string newMembershipLevel = VisualInterface.DisplaymembershipLevels();
            membershiplevel = newMembershipLevel;
            break;
        }
        }

        list[CustomerUbication].MembershipLevel = membershiplevel;
    }
}
