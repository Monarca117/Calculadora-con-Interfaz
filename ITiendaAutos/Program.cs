using System;
using System.Collections;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

/*
 * @author: Miguel Angel Arellano Juárez
 * @version: 1.0.0.0
 * 
 * 
 */

namespace ITiendaAutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos la tienda
            CTiendauto tienda = new CTiendauto();

            //Recorremos cada uno de los elementos que la estructura expone.
            foreach (CAuto miAuto in tienda)
            {
                miAuto.CalcularTenencia(0.05);
                miAuto.Mostrar();
            }
        }
    }
}
