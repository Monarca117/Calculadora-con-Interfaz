using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * @author: Miguel Angel Arellano Juárez
 * @version: 1.0.0.0
 * 
 */

namespace ICalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES:
            int opcion = 0; //Se usa para que el usuario elija que opcion de operacion se lleve a cabo.

            //Operandos:
            double vala = 0.0;
            double valb = 0.0;

            //Variable de apoyo.
            string valor = "";

            //Variable con caracteristicas polimorficas:
            IOperacion operacion = new CSuma(); //Instanciacion de default temporal.
            while (opcion!=5)
            {
                Console.WriteLine("1.Suma, 2.Resta, 3.Multiplicacion, 4.Division, 5.Salir");
                Console.WriteLine("¿Qué opción deseas?");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                if (opcion != 5)
                {
                    Console.WriteLine("Dame el valor de a");
                    valor = Console.ReadLine();
                    vala = Convert.ToDouble(valor);

                    Console.WriteLine("Dame el valor de b");
                    valor = Console.ReadLine();
                    valb = Convert.ToDouble(valor);

                    // Polimorfismo
                    if (opcion == 1)
                        operacion = new CSuma();
                    if (opcion == 2)
                        operacion = new CResta();
                    if (opcion == 3)
                        operacion = new CMultiplicacion();
                    if (opcion == 4)
                        operacion = new CDivision();

                    operacion.calcular(vala, valb);
                    operacion.mostrar();
                }
            }
        }
    }
}
