using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculation
    {
        
        //bool sign = true;

        public string Plus(float fValue, float sValue)
        {
            float resValue;
            resValue = fValue + sValue;

            return Convert.ToString(resValue);
        }

        public string Minus(float fValue, float sValue)
        {
            float resValue;
            resValue = fValue - sValue;

            return Convert.ToString(resValue);
        }

        public string Multiplication(float fValue, float sValue)
        {
            float resValue;
            resValue = fValue * sValue;

            return Convert.ToString(resValue);
        }

        public string Division(float fValue, float sValue)
        {
            float resValue;
            resValue = fValue / sValue;

            return Convert.ToString(resValue);
        }
    }
}
