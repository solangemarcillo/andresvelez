using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptador adaptador = new Adaptador();
            adaptador.IngresarPesetas(2000);
            adaptador.IngresarPesetas(5000);
            adaptador.IngresarPesetas(1000);
            Console.WriteLine("Total de Euros en a Caja: "+ adaptador.Saldo());
        }
    }
}
