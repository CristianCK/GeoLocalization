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
    public interface IRouteInfoResponse
    {
        /// <summary>
        /// Tempo total
        /// </summary>
        string TotalTime { get; }

        /// <summary>
        /// Distância total
        /// </summary>
        double TotalDistance { get; }

        /// <summary>
        /// Custo de combustível total
        /// </summary>
        double TotalFuelCost { get; }

        /// <summary>
        /// Custo total
        /// </summary>
        double TotalCost { get; }
    }
}
