using System;
using static System.Console;
using static System.Math;

public class Program
{
  public static void Main()
  {
    double d = 128.00;
    WriteLine($"cuadrado de {d} = {Math.Pow(d, 2)}");
    WriteLine($"cubo de {d} = {Pow(d, 3)}");
    WriteLine($"raiz cuadrada de {d} = {Sqrt(d)}");
    WriteLine($"d / 3 = {Round(d/3, 2)}");
    WriteLine($"Máximo de d y 100 = {Max(d, 100)}");
  }
}
