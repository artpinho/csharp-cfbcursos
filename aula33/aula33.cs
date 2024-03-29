using System;

class Jogador
{
  private int energia;
  private string nome;
  public Jogador(string nome)
  {
    this.nome = nome;
    energia = 100;
  }

  public string getNome()
  {
    return nome;
  }
  public int getEnergia()
  {
    return energia;
  }

  public void setEnergia(int e)
  {
    if (e < 0)
    {
      if (energia + e < 0)
      {
        energia = 0;
      }
      else
      {
        energia += e;
      }
    }
    else if (e > 0)
    {
      if (energia + e > 100)
      {
        energia = 100;
      }
      else
      {
        energia += e;
      }
    }
  }
  class Aula33
  {
    static void Main()
    {
      Jogador j1 = new Jogador("Bruno");

      j1.setEnergia(-150);

      System.Console.WriteLine("Nome...: {0}", j1.getNome());
      System.Console.WriteLine("Energia: {0}", j1.getEnergia());
    }
  }
}