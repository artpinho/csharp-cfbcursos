using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }
    public Jogador(string n, int e)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }

    public Jogador(string n, int e, bool v)
    {
        energia = e;
        vivo = v;
        nome = n;
    }

    public info()
    {
        Console.WriteLine("Nome jogador: {0}", nome);
        Console.WriteLine("Energia jogador: {0}", energia);
        Console.WriteLine("Estado jogador: {0}", vivo);
    }
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
~Jogador()
    {
    Console.WriteLine("Jogador {0} foi destruido", nome);
}
}
class Aula30
{
    static void Main()
    {
        string nome1;
        Console.WriteLine("Digite o nome do jogador 1: ");
        nome1 = Console.ReadLine();
        Jogador j1 = new Jogador(nome1);
        Jogador j2 = new Jogador("Otto");

        j1.energia = 50;

        Console.WriteLine("Energia do jogador 1: {0}", j1.nome);
        Console.WriteLine("Energia do jogador 1: {0}", j2.nome);
    }
}