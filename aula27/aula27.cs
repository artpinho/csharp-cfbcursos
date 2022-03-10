using System;
class Aula27
{
  static void Main()
  {
    soma(4, 6, 65);
  }

  static void soma(params int[] n)
  {
    int res = 0;
    if (n.Length < 1)
    {
      Console.WriteLine("Não possuem valores a serem a somados!");
    }
    else if (n.Length < 2)
    {
      Console.WriteLine("Argumentos insuficientes para a soma!");
    }
    else
    {
      for (int i = 0; i < n.Length; i++)
      {
        res += n[i];
      }
      Console.WriteLine("A soma dos valores é: {0}", res);
    }
  }
}