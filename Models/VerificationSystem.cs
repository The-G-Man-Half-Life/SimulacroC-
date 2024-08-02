using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroPruebaDeDesempeñoDelModuloC_.Models;

public static class verificationSystem
{
    public static string NormalizationOfString(string phrase)
    {
        bool flag = true;
        string newWord = "";
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputWord))
            {
                Console.Clear();
                Console.WriteLine("You must write a valid Word");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                newWord = inputWord.Trim().ToLower();
                break;
            }
        }
        return newWord;
    } 

    public static double VerificateDouble(string phrase)
    {
        bool flag = true;
        double newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (double.TryParse(inputWord, out newNumber)== false || inputWord.Contains("-"))
            {
                Console.Clear();
                Console.WriteLine("You must write a valid number");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    } 

    public static byte Verificatebyte(string phrase)
    {
        bool flag = true;
        byte newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (byte.TryParse(inputWord, out newNumber)== false || inputWord.Contains("-"))
            {
                Console.Clear();
                Console.WriteLine("You must write a valid age");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    } 

    public static string VerificateEmail(string phrase)
    {
        bool flag = true;
        string newWord = "";
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputWord) || inputWord.Contains("@")== false || inputWord.Contains(".com")== false)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid email");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                newWord = inputWord.Trim().ToLower();
                break;
            }
        }
        return newWord;
    }

    public static int VerificateKindOfVehicleRange(string phrase)
    {
        bool flag = true;
        byte newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (byte.TryParse(inputWord, out newNumber)== false || newNumber<1 || newNumber>4)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid option");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    }

        public static int VerificateKindOfVehicleRange2(string phrase)
    {
        bool flag = true;
        byte newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (byte.TryParse(inputWord, out newNumber)== false || newNumber<1 || newNumber>2)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid option");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    }

    public static int VerificateYear(string phrase)
    {
        bool flag = true;
        int newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (int.TryParse(inputWord, out newNumber)== false || newNumber<0001 || newNumber>DateTime.Now.Year)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid year");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    }

    public static int VerificateMonth(string phrase)
    {
        bool flag = true;
        int newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (int.TryParse(inputWord, out newNumber)== false || newNumber<1 || newNumber>12)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid month");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    }

    public static int Verificateday(string phrase)

    {
        bool flag = true;
        int newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (int.TryParse(inputWord, out newNumber)== false || newNumber<1 || newNumber>31)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid day");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    }

    public static int VerificateInt(string phrase)
    {
        bool flag = true;
        int newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (int.TryParse(inputWord, out newNumber)== false || inputWord.Contains("-"))
            {
                Console.Clear();
                Console.WriteLine("You must write a valid number");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    } 

    public static int verificateVehicleExistence(List<Vehicle> list, string phrase)
    {
        bool flag = true;
        int vehicleUbication= 0;
        
        while(flag==true)
        {
            int inputWord =VerificateInt(phrase);
            bool vehicleExists = list.Any(item=>item.Id == inputWord);

            if (vehicleExists == false)
            {
                Console.Clear();
                Console.WriteLine("The vehicle doesnt exist keep trying");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                vehicleUbication = list.FindIndex(employee => employee.Id == inputWord);
                break;
            }
        }
        return vehicleUbication;
    }

    public static int VerificateRangeVehicleUpdateOptions(string phrase)
    {
        bool flag = true;
        int newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (int.TryParse(inputWord, out newNumber)== false || newNumber<1 || newNumber>2)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid option");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    }
    
    public static int VerificateRangeVehicleUpdateOptionsVehicle(string phrase)
    {
        bool flag = true;
        int newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (int.TryParse(inputWord, out newNumber)== false || newNumber<1 || newNumber>6)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid option");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    }
    
    public static int VerificateRangeMembershipLevel(string phrase)
    {
        bool flag = true;
        int newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (int.TryParse(inputWord, out newNumber)== false || newNumber<1 || newNumber>3)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid option");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    }
    
    public static int verificateCustomerExistence(List<Customer> list, string phrase)
    {
        bool flag = true;
        int vehicleUbication= 0;
        
        while(flag==true)
        {
            string inputWord =NormalizationOfString(phrase);
            bool vehicleExists = list.Any(item=>item.GetIdentificationNumber() == inputWord);

            if (vehicleExists == false)
            {
                Console.Clear();
                Console.WriteLine("The vehicle doesnt exist keep trying");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                vehicleUbication = list.FindIndex(employee => employee.GetIdentificationNumber() == inputWord);
                break;
            }
        }
        return vehicleUbication;
    }
    
    public static int VerificateKindOfVehicleRange3(string phrase)
    {
        bool flag = true;
        byte newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (byte.TryParse(inputWord, out newNumber)== false || newNumber<1 || newNumber>10)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid option");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    }
    
    public static int verificateDriverExistence(List<Driver> list, string phrase)
    {
        bool flag = true;
        int vehicleUbication= 0;
        
        while(flag==true)
        {
            string inputWord =NormalizationOfString(phrase);
            bool vehicleExists = list.Any(item=>item.GetIdentificationNumber() == inputWord);

            if (vehicleExists == false)
            {
                Console.Clear();
                Console.WriteLine("The vehicle doesnt exist keep trying");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                vehicleUbication = list.FindIndex(employee => employee.GetIdentificationNumber() == inputWord);
                break;
            }
        }
        return vehicleUbication;
    }
    
    public static int VerificateMenuRange(string phrase)
    {
        bool flag = true;
        byte newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (byte.TryParse(inputWord, out newNumber)== false || newNumber<1 || newNumber>14)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid option");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    }
    }



