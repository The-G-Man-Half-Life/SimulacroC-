using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroPruebaDeDesempeñoDelModuloC_.Models;
public static class VisualInterface
{
    public static string DisplayKindOfVehicles()
    {
Console.WriteLine(@"
1.Motorcycle
2.Car
3.Truck
4.MicroBus

Enter the number of your option: ");

int selection = verificationSystem.VerificateKindOfVehicleRange(@"
1.Motorcycle
2.Car
3.Truck
4.MicroBus

Enter the number of your option: ");

switch (selection)
{
    case 1:
    return "motorcycle";
    
    case 2:
    return "car";

    case 3:
    return "truck";

    case 4:
    return "microbus";

    default:
    return "no";
}
    }

    public static string DisplayKindOfDrivingLicenses()
    {
Console.WriteLine(@"
1.A2
2.B2

Enter the number of your option: ");

int selection = verificationSystem.VerificateKindOfVehicleRange2(@"
1.A2
2.B2

Enter the number of your option: ");

switch (selection)
{
    case 1:
    return "A2";
    
    case 2:
    return "B2";

    default:
    return "no";
}
    }

    public static int DisplayVehicleUpdateOptions()
    {
        Console.Write(@$"
1. Update owner data
2. Update car data

Enter your option: 
");

return verificationSystem.VerificateRangeVehicleUpdateOptions(@$"
1. Update owner data
2. Update car data

Enter your option: 
");
    }

    public static int DisplayVehicleUpdateOptionsvehicle()
    {
        Console.Write(@$"
1. Plate
2. KindOfCar
3. Engine number
4. Serial number
5. People capacity

Enter your option: 
");

return verificationSystem.VerificateRangeVehicleUpdateOptionsVehicle(@$"
1. Plate
2. KindOfCar
3. Engine number
4. Serial number
5. People capacity

Enter your option: 
");


    }

    public static void DisplayVehicleInfo(List<Vehicle> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(@$"
______________________________________________________________
Full name: {item.Owner.GetName()}
Type of document: {item.Owner.GetTypeDocument()}
Identification number: {item.Owner.GetIdentificationNumber()}
Birthdate: {item.Owner.GetBirthDate()}
Email: {item.Owner.GetEmail()}
Phone number: {item.Owner.GetPhoneNumber()}
Address: {item.Owner.GetAddress()}
License Number: {item.Owner.LicenseNumber}
License category: {item.Owner.LicenseCategory}
Driving experience: {item.Owner.DrivingExperience}
Plate: {item.Plate}
Kind of vehicle: {item.KindOfVehicle}
Engine number: {item.EngineNumber}
Serial number: {item.SerialNumber}
people capacity: {item.PeopleCapacity}");

        }
    }

    public static string DisplaymembershipLevels()
    {
        Console.Write(@$"
1. Gold
2. Silver
3. Cooper

Enter your option: 
");

switch (verificationSystem.VerificateRangeMembershipLevel(@$"
1. Gold
2. Silver
3. Cooper

Enter your option: 
"))
{
    case 1:
    return "gold";
    case 2:
    return "silver";
    case 3: 
    return "cooper";
    default:
    return "nothing";
}

    }

    public static int DisplayCustomerUpdateOptions()
    {
Console.WriteLine(@"
1.Name
2.last name
3.type of document
4.identification number
5.birthdate
6.email
7.phone number
8.address
9.membership level
10. prefered payment method

Enter the number of your option: ");

int selection = verificationSystem.VerificateKindOfVehicleRange3(@"
1.Name
2.last name
3.type of document
4.identification number
5.birthdate
6.email
7.phone number
8.address
9.membership level
10. prefered payment method

Enter the number of your option: ");

switch (selection)
{
    case 1:
    return 1;
    
    case 2:
    return 2;

    case 3:
    return 3;

    case 4:
    return 4;

    case 5:
    return 5;

    case 6:
    return 6;

    case 7:
    return 7;

    case 8:
    return 8;

    case 9:
    return 9;

    case 10:
    return 10;

    default:
    return 0;
}
    }

    public static void DisplayCustomerInfo(List<Customer> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(@$"
_________________________________________________________________
Full name: {item.GetName()}
Type of document: {item.GetTypeDocument()}
Identification number: {item.GetIdentificationNumber()}
Birthdate: {item.GetBirthDate()}
Email: {item.GetEmail()}
Phone number: {item.GetPhoneNumber()}
Address: {item.GetAddress()}
Membership level: {item.MembershipLevel}
Prefered payment method: {item.PreferredPaymentMethod}");
        }
    }

    public static void DisplayMenu()
    {
var management = new Management();
bool flag = true;
while(flag = true)
{
Console.WriteLine("press any key to continue");
Console.ReadKey();
Console.Clear();
        Console.WriteLine(@$"
1.Add a vehicle
2.Delete a vehicle
3.Update a vehicle
4.Find a vehicle
5.Add a customer
6.Delete a customer
7.Update a customer
8.Find a customer
9.Show all customers
10.Show all vehicles
11.Show all drivers
12.Update license category
13.Update experience years
14.Update membership level

Choose an option: ");


    int optionTaken = verificationSystem.VerificateMenuRange(@$"
1.Add a vehicle
2.Delete a vehicle
3.Update a vehicle
4.Find a vehicle
5.Add a customer
6.Delete a customer
7.Update a customer
8.Find a customer
9.Show all customers
10.Show all vehicles
11.Show all drivers
12.Update license category
13.Update experience years
14.Update membership level
15. exist the system

Choose an option: ");


switch (optionTaken)
{
    case 1:
    Console.Clear();
    management.AddAVehicle();
    break;
    case 2:
    Console.Clear();
    management.DeleteVehicle();
    break;
    case 3:
    Console.Clear();
    management.UpdateVehicle();
    break;
    case 4:
    Console.Clear();
    management.FindVehicle();
    break;
    case 5:
    Console.Clear();
    management.AddACustomer();
    break;
    case 6:
    Console.Clear();
    management.DeleteACustomer();
    break;
    case 7:
    Console.Clear();
    management.UpdateACustomer();
    break;
    case 8:
    Console.Clear();
    management.FindACustomer();
    break;
    case 9:
    Console.Clear();
    management.ShowAllCustomers();
    break;
    case 10:
    Console.Clear();
    management.ShowAllVehicles();
    break;
    case 11:
    Console.Clear();
    management.ShowAllDrivers();
    break;
    case 12:
    Console.Clear();
    management.UpdateLicenseCategory();
    break;
    case 13:
    Console.Clear();
    management.UpdateDrivingExperience();
    break;
    case 14:
    Console.Clear();
    management.UpdateMembershipLevel();
    break;
    case 15:
    Console.Clear();
    Console.WriteLine("See you later alligator");
    flag = false;
    break;
    default:
    break;
}
}

    }

        public static void DisplayDriverInfo(List<Driver> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(@$"
_________________________________________________________________
Full name: {item.GetName()}
Type of document: {item.GetTypeDocument()}
Identification number: {item.GetIdentificationNumber()}
Birthdate: {item.GetBirthDate()}
Email: {item.GetEmail()}
Phone number: {item.GetPhoneNumber()}
Address: {item.GetAddress()}
Membership level: {item.LicenseNumber}
Prefered payment method: {item.LicenseCategory}
Years of experience: {item.DrivingExperience}");
        }
    }
}
