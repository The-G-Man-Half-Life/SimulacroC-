using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroPruebaDeDesempeñoDelModuloC_.Models;
public class Driver: User
{
    public string LicenseNumber {get; set;}
    public string LicenseCategory {get; set;}
    public int DrivingExperience {get; set;}

//constructor
    public Driver(string Name,string LastName,string TypeDocument,string IdentificationNumber,DateOnly BirthDate,string Email,string PhoneNumber,string Address,string LicenseNumber,string LicenseCategory,int DrivingExperience):base(Name,LastName,TypeDocument,IdentificationNumber,BirthDate,Email,PhoneNumber,Address)
    {
        this.LicenseNumber = LicenseNumber;
        this.LicenseCategory = LicenseCategory;
        this.DrivingExperience = DrivingExperience;
    }

//requested methods
    public static void UpdateLicenseCategory(List<Driver> Drivers)
    {
        Console.Write("Enter the identification number of the driver");
        int driverUbication = verificationSystem.verificateDriverExistence(Drivers,"Enter the identification number of the driver");

        string newKindOfDrivingLicense = VisualInterface.DisplayKindOfDrivingLicenses();

        Drivers[driverUbication].LicenseCategory= newKindOfDrivingLicense;
    }

    public static void UpdateDrivingExperience(List<Driver> Drivers)
    {
        Console.Write("Enter the identification number of the driver: ");
        int driverUbication = verificationSystem.verificateDriverExistence(Drivers,"Enter the new identification number of the driver: ");

        Console.Write("Enter your years of experience");
        int newYearsOfExperience = verificationSystem.VerificateInt("Enter your years of experience: ");

        Drivers[driverUbication].DrivingExperience= newYearsOfExperience;
    }
}
