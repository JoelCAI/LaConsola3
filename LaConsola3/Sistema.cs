using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsola3
{
    public class Sistema
    {
        public void Saludo()
        {
            Validador.Tecla("De lo Contrario elija la tecla " + "*" + "X" + "*" + " para salir.");
        }

        public void Iniciar()
        {
            Saludo();
        }

    }
}
