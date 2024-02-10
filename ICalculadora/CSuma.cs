using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculadora
{
    internal class CSuma : IOperacion
    {
        private double r = 0; //Variable para la respuesta
        private ArrayList resultados = new ArrayList(); //

        //Metodos a implementar de IOperacion
        public void calcular(double a, double b)
        {
            r = a + b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la suma es {0}", r);
            resultados.Add(r); //Se agrega a la lista
        }

        //Metodo independiente de IOperacion
        public void muestraResultados()
        {
            foreach (double r in resultados)
                Console.WriteLine(r);
        }
    }
}