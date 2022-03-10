using System;
class Aula19
{
  static void Main()
  {
    int[] num = new int[10];
    for (int i = 0; i < num.Length; i++)
    {
      num[i] = i;
    }
    /*for --> caracterisca : teste lógico : resultado
    /caso a variavel seja usada somente para o loop 
    declarar dentro do loop 'for (int num = x)'*/

    for (int i = 0; i < num.Length; i++)
    {
      Console.WriteLine("Valor de num na pos {0}: {1}", i, num[i]);
    }

  }
}