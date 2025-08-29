using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3._1.Models
{
    public class Benteveo:Ave
    {
        static Random azar = new Random();

        public override int PoneHuevos()
        {
            int huevos = 0;
            if (TieneHambre() == false)
            {
                huevos = azar.Next(0, 1);
                return huevos;
            }

            acciones.Add($"El benteveo ha puesto {huevos} huevos.");

            return 0;
        }

        public override bool TieneHambre()
        {
            return azar.Next(0, 2) == 1;
        }

        public override void Come()
        {
            if (TieneHambre())
            {
                acciones.Add("El benteveo ha comido.");
            }
            else
            {
                acciones.Add("El benteveo no tiene hambre.");
            }
        }

        public override string ToString()
        {
            return "Benteveo";
        }
    }
}
