using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterestCalculatorGUI
{
    class Calculator_v1
    {
        // variables
        private double compound;
        public double _compound
        {
            get { return compound; }
            set { compound = value; }
        }

        private double principal;       
        public double _principal
        {
            get { return principal; }
            set { principal = value; }
        }

        private double interest;
        public double _interest
        {
            get { return interest; }
            set { interest = value; }
        }

        private int years;
        public int _years
        {
            get { return years; }
            set { years = value; }
        }

        // do the math
        // compound = principal(1 + (interest/n)^(n*years))
        public double CalculateInterest()
        {
            principal = _principal;
            interest = _interest;
            years = _years;
            compound = (principal * Math.Pow((1 + (interest / 1)), (1 * years)));
            return compound;
        }
    }
}