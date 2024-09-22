﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tuyiu.KosyanovDV.Sprint1.Task7.V1.Lib
{
    public class DataService : ISprint1Task7V1
    {
        public double Calculate(double a, double b, double c)
        {
            return double.Round((((b + Math.Sqrt(Math.Pow(b, 2)+4*a*c))/(2*a)) - Math.Pow(a, 3)*c+Math.Pow(b, -2)), 3);
        }
    }
}
