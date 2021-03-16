using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7_EcuacionesLineales
{
    class Operaciones
    {
        public double CalculoDeX(double a, double b, double c, double ei, double d, double f)
        {
            double x = ((c * ei) - (b * f) / (a * ei) - (b * d));
            return (x);
        }
        public double CalculoDeY(double a, double b, double c, double ei, double d, double f)
        {
            double y = ((a * f) - (c * d) / (a * ei) - (b * d));
            return (y);
        }

    }
}
