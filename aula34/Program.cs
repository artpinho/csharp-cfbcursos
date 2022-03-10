using System;

class Veiculo //Clase Base
{
    public int rodas;
    public int velMax;
    private bool ligado;
    public Veiculo(int rodas){
        this.rodas = rodas;
    }

    public void ligar()
    {
        ligado = true;
    }
    public void desligar()
    {
        ligado = false;
    }
    public string getLigado()
    {
        if (ligado)
        {
            return "sim";
        }
        else
        {
            return "não";
        }
    }
    public int getRodas(){
        return rodas;
    }
}

class Carro : Veiculo // Clase Derivada
{
    public string nome;
    public string cor;
    public Carro(string nome, string cor):base(4)
    {
        desligar();      
        velMax = 120;
        this.nome = nome;
        this.cor = cor;

    }
}

class aula34
{
    static void Main()
    {
        Carro c1 = new Carro("Ferrari", "Vermelho");
        Console.WriteLine("Cor.........: {0}", c1.nome);
        Console.WriteLine("Nome........: {0}", c1.cor);
        Console.WriteLine("Rodas.......: {0}", c1.getRodas);
        Console.WriteLine("VelMax......: {0}", c1.velMax);
        Console.WriteLine("Ligado......: {0}", c1.getLigado());

    }
}