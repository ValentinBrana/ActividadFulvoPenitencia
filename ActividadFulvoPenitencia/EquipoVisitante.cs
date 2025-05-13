using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadFulvoPenitencia
{
    public class EquipoVisitante : Equipo, IPartido
    {
        public EquipoVisitante(string nombre, string entrenador)
            : base(nombre, entrenador)
        {
        }

        public string SimularPartido(Equipo equipo1, Equipo equipo2)
        {
            Random random = new Random();
            int golesEquipo1 = random.Next(0, 5);
            int golesEquipo2 = random.Next(0, 5);

            string resultado = $"{equipo1.Nombre} {golesEquipo1} - {golesEquipo2} {equipo2.Nombre}";

            if (golesEquipo1 > golesEquipo2)
                resultado += $" → Ganador: {equipo1.Nombre}";
            else if (golesEquipo2 > golesEquipo1)
                resultado += $" → Ganador: {equipo2.Nombre}";
            else
                resultado += " → Empate";

            return resultado;
        }
    }
}
