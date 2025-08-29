using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3._1.Models
{
    abstract public class Ave:Animal
    {
        bool estaViva = true;
        public bool EstaViva
        {
            get
            {
                return estaViva;
            }
            set
            {
                estaViva = value;
                if (!estaViva)
                {
                    acciones.Add("El ave ha muerto.");
                }
            }
        }

        abstract public int PoneHuevos();
        abstract public bool TieneHambre();
        abstract public void Come();

        public override List<string> CorreRutinas()
        {
            Come();
            PoneHuevos();
            return acciones;
        }

    }
}
