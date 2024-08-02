using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroPruebaDeDesempeñoDelModuloC_.Models;
public class User
{
    protected Guid Id { get; set; }
    protected string Name { get; set; }
    protected string LastName { get; set; }
    protected string TypeDocument { get; set; }
    protected string IdentificationNumber { get; set; }
    protected DateOnly BirthDate { get; set; }
    protected string Email { get; set; }
    protected string PhoneNumber { get; set; }
    protected string Address { get; set; }

//constructor
    public User(string Name, string LastName, string TypeDocument, string IdentificationNumber, DateOnly BirthDate, string Email, string PhoneNumber, string Address)
    {
        this.Id = new Guid();
        this.Name = Name;
        this.LastName = LastName;
        this.TypeDocument = TypeDocument;
        this.IdentificationNumber = IdentificationNumber;
        this.BirthDate = BirthDate;
        this.Email = Email;
        this.PhoneNumber = PhoneNumber;
        this.Address = Address;
    }

//main methods
    protected virtual void ShowDetails()
    {
Console.WriteLine(@$"
Full name: {this.Name}
Type of document: {this.TypeDocument}
Identification number: {this.IdentificationNumber}
Birthdate: {this.BirthDate}
Email: {this.Email}
Phone number: {this.PhoneNumber}
Address: {this.Address}");
    }

    protected int CalculateAge()
    {
        return DateTime.Now.Year - this.BirthDate.Year;
    }

    protected void ShowAge()
    {
        Console.WriteLine(CalculateAge());
    }


//extraction and update methods

public Guid GetId()=> Id;

    public string GetName() => Name;
    public void SetName(string name) => Name = name;

    public string GetLastName() => LastName;
    public void SetLastName(string lastName) =>LastName = lastName ;

    public string GetTypeDocument() => TypeDocument;
    public void SetTypeDocument(string typeDocument) => TypeDocument = typeDocument;

    public string GetIdentificationNumber() => IdentificationNumber;
    public void SetIdentificationNumber(string identificationNumber) => IdentificationNumber = identificationNumber;

    public DateOnly GetBirthDate() => BirthDate;
    public void SetBirthDate(DateOnly birthDate) => BirthDate = birthDate;

    public string GetEmail() => Email;
    public void SetEmail(string email) => Email = email;

    public string GetPhoneNumber() => PhoneNumber;
    public void SetPhoneNumber(string phoneNumber) => PhoneNumber = phoneNumber;

    public string GetAddress() => Address;
    public void Setaddress(string address) => Address = address;
}
