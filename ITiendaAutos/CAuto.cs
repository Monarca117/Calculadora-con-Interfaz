using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITiendaAutos
{
    internal class CAuto : IAutomovil
    {
        double costo;
        String modelo;
        double tenencia;

        //Constructor
        public CAuto(String pModelo, double pCosto) 
        {
            costo = pCosto;
            modelo = pModelo;
        }

        //Metodos de la interfaz
        public void CalcularTenencia(double pImpuesto)
        {
            tenencia = 5000.0 + costo * pImpuesto;
        }

        public void Mostrar()
        {
            Console.WriteLine("Tu automovil {0}", modelo);
            Console.WriteLine("Costo {0} con una tenencia de {1}", costo, tenencia);
            Console.WriteLine("Total de {0}", costo + tenencia);
            Console.WriteLine("----------------");
        }
    }
}
