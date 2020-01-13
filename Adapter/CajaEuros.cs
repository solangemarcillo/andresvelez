using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class CajaEuros
    {
        private double euros = 0;
        public CajaEuros()
        {

        }
        public double TotalEuros()
        {
            return this.euros;
        }
        public void sacarEuros(double euros)
        {
            this.euros -= euros;
        }
        public void ingresarEuros(double euros)
        {
            this.euros += euros;
        }
    }
}
