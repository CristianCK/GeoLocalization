using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geo.BL.maplink.route;
//using Geo.BL.maplink.addressfinder;
//using Geo.Model;

namespace Geo.BL
{
    public class RouteServices
    {
        public RouteServices(string token) 
        {
            Token = token;
        }

        public GetRouteTotalsResponse GetRouteProximityTotals(Point source, Point destination)
        {
            GetRouteTotalsResponse routeTotals = null;

            var route = new Route();

            var routeStops = new RouteStop[2];
            routeStops[0] = new RouteStop() { description = "Origem", point = source };
            routeStops[1] = new RouteStop() { description = "Destino", point = destination };

            var routeOptions = new RouteOptions()
            {
                //routeDetails = new RouteDetails() { routeType }

            };

            routeTotals = route.GetRouteTotals(routeStops, routeOptions, Token);

            return routeTotals;
        }

        private string Token { get; set; }
    }
}
