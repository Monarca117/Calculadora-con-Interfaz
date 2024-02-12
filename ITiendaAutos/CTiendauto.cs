using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITiendaAutos
{
    internal class CTiendauto
    {
        private CAuto[] disponibles;

        public CTiendauto()
        {
            disponibles = new CAuto[4];

            disponibles[0] = new CAuto("Soul", 200000.0 );
            disponibles[1] = new CAuto("Supra", 350000.0);
            disponibles[2] = new CAuto("Chevy", 150000.0);
            disponibles[3] = new CAuto("Impala", 8040000.0);
        }

        public IEnumerator GetEnumerator()
        {
            return disponibles.GetEnumerator();
        }
    }
}
