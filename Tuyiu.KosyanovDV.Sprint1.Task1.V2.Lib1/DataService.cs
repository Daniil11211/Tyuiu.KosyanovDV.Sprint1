using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tuyiu.KosyanovDV.Sprint1.Task1.V2.Lib
{
    public class DataService : ISprint1Task1V2
    {
        public double Calculate(double x, double y)
        {
            return x * y / (5 + x);
        }
    }
}
