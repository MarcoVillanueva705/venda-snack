using System.Collections.Generic;

namespace snacks.Models
{
    class Warehouse
    {
        public string Name { get; }
        public string Code { get; }
        public Dictionary<string, Warehouse> Destinations { get; set; }
        // public List<Package> Pickups { get; set; }

        //Method for adding warehouses
        public void AddWarehouseDestination(Warehouse destination)
        {
            Destinations.Add(destination.Code,destination);
        //Add this airport as destination to other 
            destination.Destinations.Add(Code, this);
        }

        public Warehouse(string name, string code)
        {
            Name = name;
            Code = code;
            Destinations = new Dictionary<string, Warehouse>();
        }
    }
}