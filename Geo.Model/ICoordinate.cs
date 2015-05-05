using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo.Model
{
    public interface ICoordinate
    {
        double X { get; }

        double Y { get; }
    }
}
