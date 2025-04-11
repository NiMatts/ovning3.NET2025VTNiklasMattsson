using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.NET2025VTNiklasMattsson.Core
{
    //Vehicle has-a VehicleHandler?
    public class VehicleHandler
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public  Vehicle CreateVehicle(string brand, string model, int year, double weight)
        {
            Vehicle newVehicle = new Vehicle()
            {
                Brand = brand,
                Model = model,
                Year = year,
                Weight = weight
            };
            vehicles.Add(newVehicle);
            return newVehicle;
        }

        public void SetBrand(Vehicle vehicle, string brand) => vehicle.Brand = brand;
        public void SetModel(Vehicle vehicle, string model) => vehicle.Model = model;
        public void SetYear(Vehicle vehicle, int year) => vehicle.Year = year;
        public void SetWeight(Vehicle vehicle, double weight) => vehicle.Weight = weight;

        public void ListVehicles()
        {
            foreach (var v in vehicles)
            {
                Console.WriteLine(v);
            }
        }
    }
}
