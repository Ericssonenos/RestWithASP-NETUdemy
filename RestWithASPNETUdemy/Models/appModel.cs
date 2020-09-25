using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace RestWithASPNETUdemy.Models
{
    public class appModel
    {
        public readonly double FistNumber;
        public readonly double SecondNumber;
        public readonly double Result;
        public readonly bool Validation =false;

        public appModel( string _firstnumber, string _secondNumber)
        {

            if (double.TryParse(_firstnumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out FistNumber)
            && double.TryParse(_secondNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out SecondNumber))
                Validation = true;
            Result = FistNumber + SecondNumber;
        }

      
    }
}
