using System;
using static System.Console;

public class Program
{
  public static void Main()
  {
    int x = 100;
    double d = x;
    WriteLine($"x += 20 ({x += 20})");
    WriteLine($"x -= 145 ({x -= 145})");
    WriteLine($"x *= 5 ({x *= 5})");
    WriteLine($"x /= 3 ({x /= 3})");
    WriteLine($"x %= 3 ({x %= 3})");
    WriteLine($"d /= 3 ({d /= 3})");
    WriteLine($"x++ ({x++})");
    WriteLine($"x = ({x})");
    WriteLine($"++x ({++x})");
    WriteLine($"x-- ({x--})");
    WriteLine($"x = ({x})");
    WriteLine($"--x ({--x})");
  }
}
