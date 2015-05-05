using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geo.BL.maplink.route;
using Geo.BL.maplink.addressfinder;
using Geo.Model;

namespace Geo.BL
{
    public class RouteServices
    {
        public RouteServices() { }

        public ICoordinate GetPoint(IAddress address)
        {
            Coordinate coordinate = null;

            //TODO: Chamada ao componente...

            return coordinate;
        }
    }
}
