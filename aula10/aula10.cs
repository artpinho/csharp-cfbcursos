using System;
class Aula10
{
  enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
  static void Main()
  {
    //DiasSemana ds = (DiasSemana)3;
    //Converteu o inteiro em dias da semana

    int ds = (int)DiasSemana.Sexta;
    //Converteu o indice de sexta em inteiro

    Console.WriteLine(ds);
  }
}