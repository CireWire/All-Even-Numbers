using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    for (int x = 0;  x < 99; x++ )
    {
      if (x % 2 != 0)
      continue;
      
      Console.WriteLine(x);
    }
  }
}
