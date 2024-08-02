using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroPruebaDeDesempeñoDelModuloC_.Models;
public class Management
{
    public List<Driver> Drivers { get; set; } = new List<Driver>();
    public List<Customer> Customers { get; set; } = new List<Customer>();
    public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();


    public void AddAVehicle()
    {

        //vehicle characteristic
        int ID = Drivers.Count();

        Console.Write("Enter the plate of the vehicle: ");
        string VehiclePlate = verificationSystem.NormalizationOfString("Enter the plate of the vehicle: ");

        string KindOfVehicle = VisualInterface.DisplayKindOfVehicles();

        Console.Write("Enter the engine number of the vehicle: ");
        string EngineNumber = verificationSystem.NormalizationOfString("Enter the engine number of the vehicle: ");

        Console.Write("Enter the serial number of the vehicle: ");
        string SerialNumber = verificationSystem.NormalizationOfString("Enter the serial number of the vehicle: ");

        Console.Write("Enter the people capacity of the vehicle: ");
        byte PeopleCapacity = verificationSystem.Verificatebyte("Enter the people capacity of the vehicle: ");

        //Driver characteristics
        Console.Write("Enter the name of the Driver: ");
        string DriverName = verificationSystem.NormalizationOfString("Enter the name of the Driver: ");

        Console.Write("Enter the last name of the Driver: ");
        string DriverLastName = verificationSystem.NormalizationOfString("Enter the last name of the Driver: ");

        Console.Write("Enter the type of document of the Driver: ");
        string DriverTypeOfDocument = verificationSystem.NormalizationOfString("Enter the name of the Driver: ");

        Console.Write("Enter the identification number of the driver: ");
        string DriverIdentificationNumber = verificationSystem.NormalizationOfString("Enter the identification number of the driver: ");

        Console.Write("Enter the year of birth of the driver: ");
        int DriveryearOfBirth = verificationSystem.VerificateYear("Enter the year of birth of the driver: ");

        Console.Write("Enter the month of birth of the driver: ");
        int DrivermonthOfBirth = verificationSystem.VerificateMonth("Enter the month of birth of the driver: ");

        Console.Write("Enter the day of birth of the driver: ");
        int DriverdayOfBirth = verificationSystem.VerificateMonth("Enter the day of birth of the driver: ");

        Console.Write("Enter the email of the driver: ");
        string Driveremail = verificationSystem.VerificateEmail("Enter the email of the driver: ");

        Console.WriteLine("Enter the phone number of the driver: ");
        string DriverPhoneNumber = verificationSystem.NormalizationOfString("Enter the phone number of the driver: ");

        Console.WriteLine("Enter the address of the driver: ");
        string DriverAddress = verificationSystem.NormalizationOfString("Enter the address of the driver: ");

        Console.WriteLine("Enter the license number of the driver: ");
        string DriverLicenseNumber = verificationSystem.NormalizationOfString("Enter the license number: ");

        string DriverLicenseCategory = VisualInterface.DisplayKindOfDrivingLicenses();

        Console.WriteLine("Enter the driving experience in years: ");
        int DriverYearsOfExperience = verificationSystem.VerificateInt("Enter the driving experience in years: ");

        int DriverCoincidence = Drivers.FindIndex(driver => driver.GetIdentificationNumber() == DriverIdentificationNumber);
        if (DriverCoincidence == 1)
        {
            Vehicles.Add(new Vehicle(ID, VehiclePlate, KindOfVehicle, EngineNumber, SerialNumber, PeopleCapacity, Drivers[DriverCoincidence]));
        }
        else
        {
            Vehicles.Add(new Vehicle(ID, VehiclePlate, KindOfVehicle, EngineNumber, SerialNumber, PeopleCapacity, new Driver(DriverName, DriverLastName, DriverTypeOfDocument, DriverIdentificationNumber, new DateOnly(DriveryearOfBirth, DrivermonthOfBirth, DriverdayOfBirth)
            , Driveremail, DriverPhoneNumber, DriverAddress, DriverLicenseNumber, DriverLicenseCategory, DriverYearsOfExperience)));

            Drivers.Add(new Driver(DriverName, DriverLastName, DriverTypeOfDocument, DriverIdentificationNumber, new DateOnly(DriveryearOfBirth, DrivermonthOfBirth, DriverdayOfBirth)
            , Driveremail, DriverPhoneNumber, DriverAddress, DriverLicenseNumber, DriverLicenseCategory, DriverYearsOfExperience));
        }




    }

    public void DeleteVehicle()
    {
        Console.Write("Enter the Id of the vehicle you want to Eliminate: ");
        int vehicleUbication = verificationSystem.verificateVehicleExistence(Vehicles, "Enter the Id of the vehicle you want to Eliminate: ");

        Guid userGuid = Vehicles[vehicleUbication].Owner.GetId();

        int TotalVehiclesOfTheDriver = Vehicles.Count(vehicle => vehicle.Owner.GetId() == userGuid);

        if (TotalVehiclesOfTheDriver > 1)
        {
            Vehicles.RemoveAt(vehicleUbication);
        }
        else
        {
            int driverUbication = Drivers.FindIndex(driver => driver.GetId() == userGuid);

            Vehicles.RemoveAt(vehicleUbication);
            Drivers.RemoveAt(driverUbication);
        }
    }

    public void UpdateVehicle()
    {
        Console.WriteLine("Enter the id of the vehicle: ");
        int vehicleUbication = verificationSystem.verificateVehicleExistence(Vehicles, "Enter the id of the vehicle: ");

        int option = VisualInterface.DisplayVehicleUpdateOptions();

        switch (option)
        {
            case 1:
                Console.Write("Enter the name of the Driver: ");
                string DriverName = verificationSystem.NormalizationOfString("Enter the name of the Driver: ");

                Console.Write("Enter the last name of the Driver: ");
                string DriverLastName = verificationSystem.NormalizationOfString("Enter the last name of the Driver: ");

                Console.Write("Enter the type of document of the Driver: ");
                string DriverTypeOfDocument = verificationSystem.NormalizationOfString("Enter the name of the Driver: ");

                Console.Write("Enter the identification number of the driver: ");
                string DriverIdentificationNumber = verificationSystem.NormalizationOfString("Enter the identification number of the driver: ");

                Console.Write("Enter the year of birth of the driver: ");
                int DriveryearOfBirth = verificationSystem.VerificateYear("Enter the year of birth of the driver: ");

                Console.Write("Enter the month of birth of the driver: ");
                int DrivermonthOfBirth = verificationSystem.VerificateMonth("Enter the month of birth of the driver: ");

                Console.Write("Enter the day of birth of the driver: ");
                int DriverdayOfBirth = verificationSystem.VerificateMonth("Enter the day of birth of the driver: ");

                Console.Write("Enter the email of the driver: ");
                string Driveremail = verificationSystem.VerificateEmail("Enter the email of the driver: ");

                Console.WriteLine("Enter the phone number of the driver: ");
                string DriverPhoneNumber = verificationSystem.NormalizationOfString("Enter the phone number of the driver: ");

                Console.WriteLine("Enter the address of the driver: ");
                string DriverAddress = verificationSystem.NormalizationOfString("Enter the address of the driver: ");

                Console.WriteLine("Enter the license number of the driver: ");
                string DriverLicenseNumber = verificationSystem.NormalizationOfString("Enter the license number: ");

                string DriverLicenseCategory = VisualInterface.DisplayKindOfDrivingLicenses();

                Console.WriteLine("Enter the driving experience in years: ");
                int DriverYearsOfExperience = verificationSystem.VerificateInt("Enter the driving experience in years: ");
                int ubicationOfTheOldOwner = Drivers.FindIndex(driver => driver.GetId() == Vehicles[vehicleUbication].Owner.GetId());

                List<int> allVehiclesOfTheOwner = Vehicles.Where(vehicle => vehicle.Owner.GetId() == Vehicles[vehicleUbication].Owner.GetId()).Select(vehicle => vehicle.Id).ToList();

                if (allVehiclesOfTheOwner.Count() > 1)
                {
                    Vehicles[vehicleUbication].Owner = new Driver(DriverName, DriverLastName, DriverTypeOfDocument, DriverIdentificationNumber, new DateOnly(DriveryearOfBirth, DrivermonthOfBirth, DriverdayOfBirth)
                    , Driveremail, DriverPhoneNumber, DriverAddress, DriverLicenseNumber, DriverLicenseCategory, DriverYearsOfExperience);

                    Drivers.Add(new Driver(DriverName, DriverLastName, DriverTypeOfDocument, DriverIdentificationNumber, new DateOnly(DriveryearOfBirth, DrivermonthOfBirth, DriverdayOfBirth)
                    , Driveremail, DriverPhoneNumber, DriverAddress, DriverLicenseNumber, DriverLicenseCategory, DriverYearsOfExperience));

                }
                else
                {
                    Drivers.RemoveAt(ubicationOfTheOldOwner);

                    Drivers.Add(new Driver(DriverName, DriverLastName, DriverTypeOfDocument, DriverIdentificationNumber, new DateOnly(DriveryearOfBirth, DrivermonthOfBirth, DriverdayOfBirth)
                    , Driveremail, DriverPhoneNumber, DriverAddress, DriverLicenseNumber, DriverLicenseCategory, DriverYearsOfExperience));

                    Vehicles[vehicleUbication].Owner = new Driver(DriverName, DriverLastName, DriverTypeOfDocument, DriverIdentificationNumber, new DateOnly(DriveryearOfBirth, DrivermonthOfBirth, DriverdayOfBirth)
                    , Driveremail, DriverPhoneNumber, DriverAddress, DriverLicenseNumber, DriverLicenseCategory, DriverYearsOfExperience);
                }
                break;

            case 2:
                int option2 = VisualInterface.DisplayVehicleUpdateOptionsvehicle();
                switch (option2)
                {
                    case 1:
                        Console.Write("Enter the new plate of the vehicle: ");
                        string newPlate = verificationSystem.NormalizationOfString("Enter the new plate of the vehicle: ");
                        Vehicles[vehicleUbication].Plate = newPlate;
                        break;

                    case 2:
                        string newKindOfVehicle = VisualInterface.DisplayKindOfVehicles();
                        Vehicles[vehicleUbication].KindOfVehicle = newKindOfVehicle;
                        break;

                    case 3:
                        Console.Write("Enter the new engine number of the vehicle: ");
                        string newEngineNumber = verificationSystem.NormalizationOfString("Enter the new engine number of the vehicle: ");
                        Vehicles[vehicleUbication].EngineNumber = newEngineNumber;
                        break;

                    case 4:
                        Console.Write("Enter the new serial number of the vehicle: ");
                        string newSerialNumber = verificationSystem.NormalizationOfString("Enter the new serial number of the vehicle: ");
                        Vehicles[vehicleUbication].SerialNumber = newSerialNumber;
                        break;

                    case 5:
                        Console.Write("Enter the new people capacity of the vehicle: ");
                        byte newPeopleCapacity = verificationSystem.Verificatebyte("Enter the new people capacity of the vehicle: ");
                        Vehicles[vehicleUbication].PeopleCapacity = newPeopleCapacity;
                        break;

                    default:
                        break;
                }
                break;
            default:
                break;
        }
    }

    public void FindVehicle()
    {
        Console.Write("Enter the id of the vehicle");
        int vehicleId = verificationSystem.verificateVehicleExistence(Vehicles, "Enter the id of the vehicle");

        List<Vehicle> foundVehicle = new List<Vehicle>();
        foundVehicle.Add(Vehicles[vehicleId]);

        VisualInterface.DisplayVehicleInfo(foundVehicle);
    }

    public void AddACustomer()
    {
        Console.Write("Enter your name: ");
        string name = verificationSystem.NormalizationOfString("Enter your name: ");

        Console.Write("Enter your last name: ");
        string surname = verificationSystem.NormalizationOfString("Enter your last name: ");

        Console.Write("Enter your type of document: ");
        string typeOfDocument = verificationSystem.NormalizationOfString("Enter your type of document: ");

        Console.Write("Enter your identification number: ");
        string identificationNumber = verificationSystem.NormalizationOfString("Enter your identification number: ");

        Console.Write("Enter your year of your birthdate: ");
        int yearOfBirthDate = verificationSystem.VerificateYear("Enter your year of your birthdate: ");

        Console.Write("Enter your month of birthdate: ");
        int monthOfBirthDate = verificationSystem.VerificateMonth("Enter your month of birthdate: ");

        Console.Write("Enter your day of birthdate: ");
        int dayOfBirthDate = verificationSystem.Verificateday("Enter your day of birthdate: ");

        Console.Write("Enter your email: ");
        string email = verificationSystem.VerificateEmail("Enter your email: ");

        Console.Write("Enter your phone number: ");
        string phoneNumber = verificationSystem.NormalizationOfString("Enter your phone number: ");

        Console.Write("Enter your address: ");
        string address = verificationSystem.NormalizationOfString("Enter your address");

        string membershipLevel = VisualInterface.DisplaymembershipLevels();

        Console.Write("Enter your prefered payment method: ");
        string preferedPaymentMethod = verificationSystem.NormalizationOfString("Enter your prefered payment method: ");

        Customers.Add(new Customer(name, surname, typeOfDocument, identificationNumber, new DateOnly(yearOfBirthDate, monthOfBirthDate, dayOfBirthDate), email, phoneNumber, address, membershipLevel, preferedPaymentMethod));
    }

    public void DeleteACustomer()
    {
        Console.Write("Enter the identification number of the customer: ");
        int customerUbication = verificationSystem.verificateCustomerExistence(Customers, "Enter the identification number of the customer: ");

        Customers.RemoveAt(customerUbication);
        Console.WriteLine("The customer was eliminated");
    }

    public void UpdateACustomer()
    {
        Console.Write("Enter the identification number of the customer");
        string IN = verificationSystem.NormalizationOfString("Enter the identification number of the customer");

        int CustomerUbication = Customers.FindIndex(customer=>customer.GetIdentificationNumber()== IN);

        int optionChoosen = VisualInterface.DisplayCustomerUpdateOptions();

        switch (optionChoosen)
        {
            case 1:
                Console.Write("Enter the name of the Customer: ");
                string CustomerName = verificationSystem.NormalizationOfString("Enter the name of the customer: ");
                Customers[CustomerUbication].SetName(CustomerName);
                break;

            case 2:
                Console.Write("Enter the last name of the customer: ");
                string CustomerLastName = verificationSystem.NormalizationOfString("Enter the last name of customerDriver: ");
                Customers[CustomerUbication].SetLastName(CustomerLastName);
                break;

            case 3:
                Console.Write("Enter the type of document of the customer: ");
                string CustomerTypeOfDocument = verificationSystem.NormalizationOfString("Enter the name of the customer: ");
                Customers[CustomerUbication].SetTypeDocument(CustomerTypeOfDocument);
                break;

            case 4:
                Console.Write("Enter the identification number of the customer: ");
                string CustomerIdentificationNumber = verificationSystem.NormalizationOfString("Enter the identification number of the customer: ");
                Customers[CustomerUbication].SetIdentificationNumber(CustomerIdentificationNumber);
                break;

            case 5:
                Console.Write("Enter the year of birth of the customer: ");
                int CustomeryearOfBirth = verificationSystem.VerificateYear("Enter the year of birth of the customer: ");
                Console.Write("Enter the month of birth of the customer: ");
                int CustomermonthOfBirth = verificationSystem.VerificateMonth("Enter the month of birth of the customer: ");
                Console.Write("Enter the day of birth of the driver: ");
                int CustomerdayOfBirth = verificationSystem.VerificateMonth("Enter the day of birth of the customer: ");
                Customers[CustomerUbication].SetBirthDate(new DateOnly(CustomeryearOfBirth,CustomermonthOfBirth,CustomerdayOfBirth));
                break;

            case 6:
                Console.Write("Enter the email of the customer: ");
                string Customeremail = verificationSystem.VerificateEmail("Enter the email of the customer: ");
                Customers[CustomerUbication].SetEmail(Customeremail);
                break;

            case 7:
                Console.WriteLine("Enter the phone number of the customer: ");
                string CustomerPhoneNumber = verificationSystem.NormalizationOfString("Enter the phone number of the customer: ");
                Customers[CustomerUbication].SetPhoneNumber(CustomerPhoneNumber);
                break;

            case 8:
                Console.WriteLine("Enter the address of the customer: ");
                string CustomerAddress = verificationSystem.NormalizationOfString("Enter the address of the customer: ");
                Customers[CustomerUbication].Setaddress(CustomerAddress);
                break;

            case 9:
                string membershipLevel = VisualInterface.DisplaymembershipLevels();
                Customers[CustomerUbication].MembershipLevel = membershipLevel;
                break;

            case 10:
                Console.WriteLine("Enter your prefered payment method: ");
                string preferedPaymentMethod = verificationSystem.NormalizationOfString("Enter your prefered payment method: ");
                Customers[CustomerUbication].PreferredPaymentMethod = preferedPaymentMethod;
                break;

            default:
                break;
        }
    }

    public void FindACustomer()
    {
        Console.Write("Enter the identification number of the customer: ");
        int customerUbication = verificationSystem.verificateCustomerExistence(Customers, "Enter the identification number of the customer: ");

        List<Customer> foundCustomer = new List<Customer>();
        foundCustomer.Add(Customers[customerUbication]);

        VisualInterface.DisplayCustomerInfo(foundCustomer);
    }

    public void ShowAllCustomers()
    {
        VisualInterface.DisplayCustomerInfo(Customers);
    }

    public void ShowAllVehicles()
    {
        VisualInterface.DisplayVehicleInfo(Vehicles);
    }

    public void ShowAllDrivers()
    {
        VisualInterface.DisplayDriverInfo(Drivers);
    }

    public void UpdateLicenseCategory()
    {
        Driver.UpdateLicenseCategory(Drivers);
    }
    
    public void UpdateDrivingExperience()
    {
        Driver.UpdateDrivingExperience(Drivers);
    }

    public void UpdateMembershipLevel()
    {
        Customer.UpdateMembershipLevel(Customers);
    }
}
