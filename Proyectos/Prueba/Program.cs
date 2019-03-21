using System;
using static System.Console;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            EligiendoPais();
        }

        static void EligiendoPais()
        {
            DateTime hoy = new DateTime();
            hoy = DateTime.Now;
            long l = hoy.Ticks;
            int s = Math.Abs((int) DateTime.Now.Ticks);
            int i = (new Random(s)).Next(5);
            WriteLine("Array con Inicializador");
            string[] paises = new string[] 
            {"Alemania", "Francia", "Italia", "Finlandia", "Suiza"};
            WriteLine($"l = {l}");  
            WriteLine($"s = {s}");  
            WriteLine($"País elegido: [{i}] {paises[i]}");
        }
    }
}
