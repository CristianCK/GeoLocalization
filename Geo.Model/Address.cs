using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo.Model
{
    public class Address : IAddress
    {
        public Address(string street, string houseNumber, string zip, string district, string cityName, string state)
        {
            Street = street;
            HouseNumber = houseNumber;
            Zip = zip;
            District = district;
            City = new City(cityName, state);
        }

        public string Street { get; private set; }

        public string HouseNumber { get; private set; }

        public string Zip { get; private set; }

        public string District { get; private set; }

        public City City { get; private set; }
    }
}
