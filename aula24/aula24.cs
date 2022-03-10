using System;
class Aula24
{
  static void Main()
  {
    int v1, v2;
    Console.Write("Informe um valor: ");
    v1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe outro valor: ");
    v2 = Convert.ToInt32(Console.ReadLine());

    soma(v1, v2);
  }
  static void soma(int n1, int n2)
  {
    int res = n1 + n2;
    Console.WriteLine("A soma entre {0} e {1} é: {2}", n1, n2, res);
  }
}