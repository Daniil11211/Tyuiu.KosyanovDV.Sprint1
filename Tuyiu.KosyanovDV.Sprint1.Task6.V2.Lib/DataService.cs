﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tuyiu.KosyanovDV.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public bool CheckHello(string value)
        {
            if (value.Contains("Hello"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
