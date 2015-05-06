using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo.Core.Model
{
    /// <summary>
    /// Responsável por encapsular informações de recebimento
    /// </summary>
    public class RouteInfoResponse : IRouteInfoResponse
    {
        /// <summary>
        /// Construtor padrão
        /// </summary>
        /// <param name="totalTime">Tempo total</param>
        /// <param name="totalDistance">Distância total</param>
        /// <param name="totalFuelCost">Custo de combustível total</param>
        /// <param name="totalCost">Custo total</param>
        public RouteInfoResponse(string totalTime, double totalDistance, double totalFuelCost, double totalCost) 
        {
            TotalTime = totalTime;
            TotalDistance = totalDistance;
            TotalFuelCost = totalFuelCost;
            TotalCost = totalCost;
        }

        /// <summary>
        /// Tempo total
        /// </summary>
        public string TotalTime
        {
            get;
            private set;
        }

        /// <summary>
        /// Distância total
        /// </summary>
        public double TotalDistance
        {
            get;
            private set;
        }

        /// <summary>
        /// Custo de combustível total
        /// </summary>
        public double TotalFuelCost
        {
            get;
            private set;
        }

        /// <summary>
        /// Custo total
        /// </summary>
        public double TotalCost
        {
            get;
            private set;
        }
    }
}
