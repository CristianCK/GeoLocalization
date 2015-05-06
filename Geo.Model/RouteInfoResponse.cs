using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo.Model
{
    public class RouteInfoResponse : IRouteInfoResponse
    {
        public RouteInfoResponse(string totalTime, double totalDistance, double totalFuelCost, double totalCost) 
        {
            TotalTime = totalTime;
            TotalDistance = totalDistance;
            TotalFuelCost = totalFuelCost;
            TotalCost = totalCost;
        }

        public string TotalTime
        {
            get;
            private set;
        }

        public double TotalDistance
        {
            get;
            private set;
        }

        public double TotalFuelCost
        {
            get;
            private set;
        }

        public double TotalCost
        {
            get;
            private set;
        }
    }
}
