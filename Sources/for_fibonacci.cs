using System;
using static System.Console;

public class Program
{
  public static void Main()
  {
    // Fibonacci
    int elementos = 7;
    int actual = 1;
    int sigui = 1;
    for(int i = 1; i <= elementos; i++)
    {
      WriteLine(actual);
      sigui = actual + (actual = sigui);
    }
  }
}
