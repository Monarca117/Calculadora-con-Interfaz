using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculadora
{
    internal interface IOperacion
    {
        /*
        Se crean metodos vacios pues estos se quedan como pretederminados, solo se 
        le pasan los parametros necesarios. Después en cada clase que se implemente
        la interfaz ya se llenara que es lo que se quiere hacer.
        */
        void calcular(double a, double b);
        void mostrar();
    }
}