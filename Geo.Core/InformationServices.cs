using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geo.Core.Model;
using Geo.Core.Properties;
using Geo.Core.maplink.addressfinder;
using Geo.Core.maplink.route;

namespace Geo.Core
{
    /// <summary>
    /// Responsável por consultar informações de rotas
    /// </summary>
    public class InformationServices
    {
        /// <summary>
        /// Contrutor padrão
        /// </summary>
        /// <param name="token">Token de acesso aos serviços do Maplink</param>
        public InformationServices(string token)
        {
            Token = token;
        }

        /// <summary>
        /// Retorna informações da rota
        /// </summary>
        /// <param name="request">Endereço da rota de destino</param>
        /// <returns>Informações de tempo, distância, consumo e custo</returns>
        public IRouteInfoResponse GetRouteInformation(IRouteInfoRequest request)
        {
            IRouteInfoResponse response = null;

            if (request != null)
            {
                var address = new Address();
                address.street = request.Street;
                address.houseNumber = request.HouseNumber.ToString();
                address.city = new maplink.addressfinder.City()
                {
                    name = request.City,
                    state = request.State
                };

                var source = new maplink.route.Point()
                {
                    x = Convert.ToDouble(Settings.Default.SourceCoordinateX),
                    y = Convert.ToDouble(Settings.Default.SourceCoordinateY)
                };

                var dPoint = GetPoint(address);
                if (dPoint != null)
                {
                    var destination = new maplink.route.Point() { x = dPoint.x, y = dPoint.y };

                    var routeTotals = GetRouteProximityTotals(source, destination, request.RouteType);
                    if (routeTotals != null)
                    {
                        response = new RouteInfoResponse(
                            routeTotals.routeTotals.totalTime,
                            routeTotals.routeTotals.totalDistance,
                            routeTotals.routeTotals.totalfuelCost,
                            routeTotals.routeTotals.totalCost
                            );
                    }
                }
            }

            return response;
        }

        /// <summary>
        /// Retorna coordenadas de um endereço
        /// </summary>
        /// <param name="address">Endereço</param>
        /// <returns>Coordenada</returns>
        private maplink.addressfinder.Point GetPoint(Address address)
        {
            var addressFinder = new AddressFinder();

            var point = addressFinder.getXY(address, Token);

            return point;
        }

        /// <summary>
        /// Retorna informações totais da rota
        /// </summary>
        /// <param name="source">Origem</param>
        /// <param name="destination">Destino</param>
        /// <param name="routeType">Tipo de otimização de rota</param>
        /// <returns>Informações da rota</returns>
        private GetRouteTotalsResponse GetRouteProximityTotals(maplink.route.Point source, maplink.route.Point destination, RouteTypes routeType)
        {
            var route = new Route();

            var routeStops = new RouteStop[2];
            routeStops[0] = new RouteStop() { description = "Origem", point = source };
            routeStops[1] = new RouteStop() { description = "Destino", point = destination };

            var routeOptions = new RouteOptions() { 
                vehicle = new Vehicle()
                {
                    averageConsumption = 10,
                    fuelPrice = 3,
                    tankCapacity = 50,
                    tollFeeCategoryId = 1,
                    averageSpeed = 100
                }
            };

            switch (routeType)
            {
                case RouteTypes.Fastest:
                    routeOptions.controls = new Controls() { mode = "fastest", map = "default" };
                    break;
                case RouteTypes.AvoidTraffic:
                    routeOptions.controls = new Controls() { traffic = "useInRouteWay", map = "traffic" };
                    break;
                default:
                    break;
            }

            var routeTotals = route.GetRouteTotals(routeStops, routeOptions, Token);

            return routeTotals;
        }

        /// <summary>
        /// Token de acesso aos serviços do Maplink
        /// </summary>
        private string Token { get; set; }
    }
}