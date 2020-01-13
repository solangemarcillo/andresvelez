using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adaptador:IAdapter1
    {
        CajaEuros cajaEuros = new CajaEuros();

        public Adaptador()
        {

        }

        public double Saldo()
        {
            return this.cajaEuros.TotalEuros();

        }
        public void SacarPesetas(double pesetas)
        {
            double euros = pesetas / 166.386;
            cajaEuros.sacarEuros(euros);
        }
        public void IngresarPesetas(double pesetas)
        {
            double euros = pesetas / 166.386;
            cajaEuros.ingresarEuros(euros);
        }

        
    }
}
