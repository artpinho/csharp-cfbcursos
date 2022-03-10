using System;

class Aula12
{
  static void Main()
  {
    int nota = 80;
    string resultado;

    if (nota > 60)
    {
      resultado = "Aprovado";
    }
    else
    {
      resultado = "Reprovado";
    }

    Console.WriteLine("Sua nota é {0} e vc foi {1}", nota, resultado);
  }
}