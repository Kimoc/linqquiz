using System;
using System.Collections.Generic;
using Modelo;
using System.Linq;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio01____________________________________________________
            List<Equipo> equipos = LigaDAO.Instance.Equipos;
            List<Jugador> jugadores = LigaDAO.Instance.Jugadores;
            List<Partido> partidos = LigaDAO.Instance.Partidos;
 
            Console.WriteLine("Equipos :");
            equipos.ForEach(Console.WriteLine);
            Console.WriteLine("Jugadores :");
            jugadores.ForEach(Console.WriteLine);
            Console.WriteLine("Partidos :");
            partidos.ForEach(Console.WriteLine);
      


            //Ejercicio02_____________________________________________

            //Jugadores Real Barcelona por fecha de alta
            Console.WriteLine("\nJugadores Real barcelona por fecha de alta");
            equipos.Where((e) => e.Nombre == "Regal Barcelona").First().Jugadores.OrderBy
                ((e) => e.FechaAlta).ToList().ForEach(Console.WriteLine);

            //Jugadores de gran canaria por apellidos
            Console.WriteLine("\nJugadores de Gran canarias ordenados por apellidos");
            equipos.Where((equipo) => equipo.Nombre == "Gran Canaria").First().Jugadores.OrderBy
                ((jugador) => jugador.Apellido).ToList().ForEach(Console.WriteLine);

            //El jugador mas alto y el euipo al que pertenece
            Console.WriteLine("\nJugador mas alto y el equipo al que pertenece");
            Jugador jugadorMasAlto = jugadores.OrderByDescending((e) => e.Altura).First();
            Console.WriteLine("Jugador: "+jugadorMasAlto.Nombre +jugadorMasAlto.Apellido+ " Equipo: "+jugadorMasAlto.Equipo.Nombre);

            //Jugadores que juegan de pivot
            Console.WriteLine("\nJugadores que juegan como pivot");
            jugadores.Where((e) => e.Posicion == "Pivot").ToList().ForEach(Console.WriteLine);

            //Ejercicio03_______________________________________________________

            //Equipo que tiene el jugador que mas cobre
            Console.WriteLine("\nEquipo con el jugador de mayor sueldo:");
            Jugador jugadorMasCaro   = jugadores.OrderByDescending((jug) => jug.Salario).First();
            Console.WriteLine( " Equipo: " + jugadorMasCaro.Equipo.Nombre);

            //Jugadores que miden mas de 2 metros
            Console.WriteLine("\nJugadores que midan mas de 2 metros");
            jugadores.Where((jug) => jug.Altura > 2).ToList().ForEach(Console.WriteLine);

            //Quienes son los capitanes de los equipos
            Console.WriteLine("Capitanes de los equipos");
            jugadores.Where((jug) => jug.Capitan != null && jug.Equipo.ID==jug.Id).
                ToList().ForEach(Console.WriteLine);


            Console.ReadLine();
        }
    }
}
