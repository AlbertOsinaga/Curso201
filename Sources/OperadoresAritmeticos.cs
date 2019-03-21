using System;
using static System.Console;

public class Program
{
  public static void Main()
  {
    int x = 12, y = 28, z = 56;
    double d = 32; 
    WriteLine($"x = x + 20 ({x = x + 20})");
    WriteLine($"y = x - 18 ({y = x - 18})");
    WriteLine($"z = x * y ({z = x * y})");
    WriteLine($"y = x / 3 ({y = x / 3})");
    WriteLine($"x = x % 3 ({x = x % 3})");
    WriteLine($"d = d / 3 ({d = d / 3})");
  }
}