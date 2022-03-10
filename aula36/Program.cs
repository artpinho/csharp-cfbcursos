using System;
class Veiculo{ //Clase base
    public int velocidadeAtual;
    protected int velocidadeMax;
    protected bool ligado;

    public Veiculo(int velocidadeMax){
        velocidadeAtual = 0;
        this.velocidadeMax = velocidadeMax;
        ligado = false;
    }
}

class Carro:Veiculo{
    public string nome;
    public Carro(string nome, int velocidadeMax):base(velocidadeMax){
        this.nome = nome;
        ligado = true;
    }
    public bool getLigado(){
        return ligado;
    }
    public int getVelocidadeMax(){
        return velocidadeMax;
    }
}
class Aula36{
    static void Main(){
        Carro carro = new Carro("Mustang", 120);
        Console.WriteLine("Nome......: {0}", carro.nome);
        Console.WriteLine("Vel.Máxima: {0}", carro.getVelocidadeMax());
        Console.WriteLine("Ligado....: {0}", carro.getLigado());
    }
}