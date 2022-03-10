using   System; //Classes e Métodos Abstratos
abstract class Veiculo{
    protected int velocidadeMaxima;
    protected int velocidadeAtual;
    protected bool ligado;

    public Veiculo(){
        ligado = false;
        velocidadeAtual = 0;
    }
    public void setLigado(bool ligado){
        this.ligado = ligado;
    }
    public int getVelocidadeAtual(){
        return velocidadeAtual;
    }

    abstract public void acceleracao(int multiplicador);
}

class Carro:Veiculo{
    public Carro(){
        velocidadeMaxima = 120;
    }
    public override void acceleracao(int multiplicador)
    {
        velocidadeAtual += 10 * multiplicador;
    }
}
class Aula39{
    static void Main(){
        Carro carro1 = new Carro();
        carro1.acceleracao(1);
        Console.WriteLine(carro1.getVelocidadeAtual());
    }
}