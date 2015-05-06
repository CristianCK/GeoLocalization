using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geo.Core;
using Geo.Core.Model;

namespace Geo.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var services = new InformationServices("c13iyCvmcC9mzwkLd0LCbCBHcXYD5mUA5m2jNGutNXK6NJc6NJt=");

            var routeInfoRequest = new RouteInfoRequest("R. Correia de Lemos", 594, "São Paulo", "SP", RouteTypes.Fastest);

            var routeInfoResponse = services.GetRouteInformation(routeInfoRequest);

            Assert.IsTrue(
                routeInfoResponse != null &&
                routeInfoResponse.TotalCost > 0
            );
        }
    }
}
