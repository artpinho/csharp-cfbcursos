using System;
class Aula25
{
  static void Main()
  {
    int num = 10;
    dobrar2(num);
    Console.WriteLine(num);
  }
  static void dobrar1(ref int valor)
  {
    valor *= 2;
  }
  static void dobrar2(int valor)
  {
    valor *= 2;
  }
}