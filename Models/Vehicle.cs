using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroPruebaDeDesempeñoDelModuloC_.Models;
public class Vehicle
{
    public int Id {get; set;}
    public string Plate {get; set;}
    public string KindOfVehicle {get; set;}
    public string EngineNumber {get; set;}
    public string SerialNumber {get; set;}
    public byte PeopleCapacity {get; set;}
    public Driver Owner {get; set;} 


    public Vehicle(int Id ,string Plate ,string KindOfVehicle ,string EngineNumber ,string SerialNumber ,byte PeopleCapacity,Driver Owner)
    {
        this.Id = Id;
        this.Plate = Plate;
        this.KindOfVehicle = KindOfVehicle;
        this.EngineNumber = EngineNumber;
        this.SerialNumber = SerialNumber;
        this.PeopleCapacity = PeopleCapacity;
        this.Owner = Owner;
    }
    
}
