using ActividadFulvoPenitencia;
using System;
using System.Collections.Generic;
#region Jugadores
Jugador jugador1 = new Jugador("Juan Pérez");
Jugador jugador2 = new Jugador("Luis Martínez");
Jugador jugador3 = new Jugador("Carlos Gómez");
Jugador jugador4 = new Jugador("Santiago Ramírez");
Jugador jugador5 = new Jugador("Matías Fernández");
Jugador jugador6 = new Jugador("Diego Torres");
#endregion

#region Equipos
Equipo equipo1 = new Equipo("Los Sin Sexo", "Carlo Ancelotti");
Equipo equipo2 = new Equipo("Los Con Sexo","Gago");
#endregion

#region Metodos
equipo1.AgregarJugador(jugador1);
equipo1.AgregarJugador(jugador2);
equipo1.AgregarJugador(jugador3);

equipo2.AgregarJugador(jugador4);
equipo2.AgregarJugador(jugador5);
equipo2.AgregarJugador(jugador6);

static void MostrarJugadoresDelEquipo(Equipo equipo, string nombreEquipo)
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

MostrarJugadoresDelEquipo(equipo1, equipo1.Nombre);

MostrarJugadoresDelEquipo(equipo2 , equipo2.Nombre);


EquipoLocal local = new EquipoLocal("Tigres", "Carlos");
EquipoVisitante visitante = new EquipoVisitante("Leones", "María");

string resultado = local.SimularPartido(local, visitante);


Console.WriteLine(resultado);

