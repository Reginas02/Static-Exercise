﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{

}
    internal static class TempConverter
{
    public static double FahrenheitToCelsius(double fTemp)
    {
        return (fTemp - 32) * 5 / 9;
    }
        public static double CelsiusToFahrenheit(double cTemp)
    {
        return (cTemp * 9) / 5 + 32;
    }

    internal static void FahrenheitToCelsiusCelsius(int v)
    {
        throw new NotImplementedException();
    }

    internal static void CelsiusToFahrenheit()
    {
        throw new NotImplementedException();
    }
}
