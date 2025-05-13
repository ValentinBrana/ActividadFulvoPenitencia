using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadFulvoPenitencia
{
    public class Equipo
    {
        #region Atributos
        private List<Jugador> jugadores = new List<Jugador>();
        string nombre;
        string entrenador;
        #endregion

        #region Constructor
        public Equipo(string nombre, string entrenador)
        {
            this.nombre = nombre;
            this.entrenador = entrenador;
        }
        #endregion

        #region GetSet
        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Entrenador { get => entrenador; set => entrenador = value; }
        #endregion

        #region Metodos
        public void AgregarJugador(Jugador jugador)
        {
            jugadores.Add(jugador);
        }

        public void BorrarJugador(Jugador jugador)
        {
            jugadores.Remove(jugador);
        }

        public void CambiarEntrenador(string nuevoEntrenador)
        {
            entrenador = nuevoEntrenador;
        }

        public static void MostrarJugadoresDelEquipo(Equipo equipo, string nombreEquipo)
        {
            Console.WriteLine($"\nJugadores del equipo {nombreEquipo}:");

            if (equipo.Jugadores.Count == 0)
            {
                Console.WriteLine("  (Sin jugadores)");
            }
            else
            {
                foreach (var jugador in equipo.Jugadores)
                {
                    Console.WriteLine("  - " + jugador.Nombre);
                }
            }
        }
        #endregion
    }
}
