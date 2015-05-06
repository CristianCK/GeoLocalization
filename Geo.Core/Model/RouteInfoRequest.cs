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
    public class RouteInfoRequest : IRouteInfoRequest
    {
        /// <summary>
        /// Construtor padrão
        /// </summary>
        /// <param name="street">Rua/avenida</param>
        /// <param name="houseNumber">Número</param>
        /// <param name="city">Cidade</param>
        /// <param name="state">Estado</param>
        /// <param name="routeType">Tipo de otimização de rota</param>
        public RouteInfoRequest(string street, int houseNumber, string city, string state, RouteTypes routeType) 
        {
            Street = street;
            HouseNumber = houseNumber;
            City = city;
            State = state;
        }

        /// <summary>
        /// Rua/avenida
        /// </summary>
        public string Street
        {
            get;
            private set;
        }

        /// <summary>
        /// Número
        /// </summary>
        public int HouseNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// Cidade
        /// </summary>
        public string City
        {
            get;
            private set;
        }

        /// <summary>
        /// Estado
        /// </summary>
        public string State
        {
            get;
            private set;
        }

        /// <summary>
        /// Tipo de otimização de rota
        /// </summary>
        public RouteTypes RouteType
        {
            get;
            private set;
        }
    }
}
