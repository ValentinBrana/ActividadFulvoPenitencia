using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadFulvoPenitencia
{
    public class Jugador
    {
        string nombre;

        public Jugador(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}
//cuchucambiasoaltoque