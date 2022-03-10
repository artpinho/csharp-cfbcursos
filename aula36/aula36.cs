using System;

class Veiculo //Classe Base
{
  public int velAtual;
  private int velMax;
  protected bool ligado;
  public Veiculo(int velMax)
  {
    velAtual = 0;
    this.velMax = velMax;
    ligado = false;
  }
  public bool getLigado()
  {
    return ligado;
  }
  public int getVelMax()
  {
    return velMax;
  }
}
class Carro : Veiculo
{ //Deridava de Veículo
  public string nome;
  public Carro(string nome, int vm) : base(vm)
  {
    this.nome = nome;
    ligado = true;
  }
}
class aula36
{
  static void Main()
  {
    Carro carro = new Carro("Bonitao", 120);

    System.Console.WriteLine("Nome......:{0}", carro.nome);
    System.Console.WriteLine("Vel.Máxima:{0}", carro.getVelMax());
    System.Console.WriteLine("Ligado....:{0}", carro.getLigado());
  }
}