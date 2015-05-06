using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo.Model
{
    public interface IRouteInfoResponse
    {
        string TotalTime { get; }

        double TotalDistance { get; }

        double TotalFuelCost { get; }

        double TotalCost { get; }
    }
}
