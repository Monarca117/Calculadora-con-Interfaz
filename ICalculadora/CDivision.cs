using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculadora
{
    internal class CDivision: IOperacion
    {
        private double r = 0; //Variable para la respuesta 

        //Metodos a implementar de IOperacion
        public void calcular(double a, double b)
        {
            r = a / b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la division es {0}", r);
        }
    }
}
