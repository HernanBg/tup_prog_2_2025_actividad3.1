using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3._1.Models
{
    public class Gallina:Ave
    {
        static Random azar = new Random();

        int raciones;

        public override int PoneHuevos()
        {
            int huevos = 0;

            if (TieneHambre() == false)
            {
                int maxHuevos = raciones;
                if (maxHuevos > 1)
                    maxHuevos = 2;

                huevos = azar.Next(0, maxHuevos);

                raciones = 0;
            }

            acciones.Add($"La gallina ha puesto {huevos} huevos.");

            return huevos;
        }

        public override bool TieneHambre()
        {
            return raciones > 0;
        }

        public override void Come()
        {
            raciones += azar.Next(0, 2);

            acciones.Add($"La gallina ha comido {raciones} raciones");
        }

        public override string ToString()
        {
            return "Gallina";
        }
    }
}
