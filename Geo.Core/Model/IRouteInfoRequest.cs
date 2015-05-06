using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo.Core.Model
{
    /// <summary>
    /// Responsável por encapsular informações de envio
    /// </summary>
    public interface IRouteInfoRequest
    {
        /// <summary>
        /// Rua/avenida
        /// </summary>
        string Street { get; }

        /// <summary>
        /// Número
        /// </summary>
        int HouseNumber { get; }
        
        /// <summary>
        /// Cidade
        /// </summary>
        string City { get; }
        
        /// <summary>
        /// Estado
        /// </summary>
        string State { get; }

        /// <summary>
        /// Tipo de otimização de rota
        /// </summary>
        RouteTypes RouteType { get; }
    }
}
