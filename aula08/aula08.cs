using System;
class Aula08
{
  static void Main()
  {
    int v1, v2, soma;
    string nome;

    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine();
    Console.Write("Digite o primeiro valor: ");
    v1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o segundo valor: ");
    v2 = Convert.ToInt32(Console.ReadLine());
    // Converter valor recebido em String para Int com int.Parse() ou Convert.ToInt()
    soma = v1 + v2;
    Console.WriteLine("Seu nome é {0} e a soma dos valores que vc informou é {1}", nome, soma);
    // {x} = se refere ao valor do inice 0,1,2,3 a,b,c,d - 0=a 2=c
  }
}