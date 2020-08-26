using System;
using System.Collections.Generic;

namespace Exercise
{
    public class VehicleRegistry
    {
        private Dictionary<LicensePlate, string> owners;

        public VehicleRegistry()
        {
            this.owners = new Dictionary<LicensePlate, string>();
        }
        public bool Add(LicensePlate licensePlate, string owner)
        {
            if (!this.owners.ContainsKey(licensePlate))
            {
                this.owners.Add(licensePlate, owner);
                return true;
            }
            return false;
        }

        public string Get(LicensePlate licensePlate)
        {
            if (this.owners.ContainsKey(licensePlate))
            {
              return this.owners[licensePlate];
            }
            else
            {
              return "No such license";
            }
            
        }

        public bool Remove(LicensePlate licensePlate)
        {
            if (this.owners.ContainsKey(licensePlate))
            {
                this.owners.Remove(licensePlate);
                return true;
            }
            else
            {
              return false;
            }
        }
        public void PrintLicensePlates()
        {
            foreach (KeyValuePair<LicensePlate, string> kvp in this.owners)
            {
                Console.WriteLine(kvp.Key);
            }
        }

        public void PrintOwners()
        {
            List<string> list = new List<string>();
            foreach (KeyValuePair<LicensePlate, string> kvp in this.owners)
            {
                if (!list.Contains(kvp.Value))
                {
                  Console.WriteLine(kvp.Value);
                  list.Add(kvp.Value);
                }
                
                  
            }
        }
    }
}