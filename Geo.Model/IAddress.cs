using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo.Model
{
    public interface IAddress
    {
        string Street { get; }
        string HouseNumber { get; }
        string Zip { get; }
        string District { get; }
        City City { get; }
    }
}
