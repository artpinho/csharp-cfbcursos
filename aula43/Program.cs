using System;
public interface iVeiculo{ //Obrigatorio implementar membros abaixo:
    void ligar();
    void desligar();
    void info();
}
public interface iCombate{
    void disparar();
}
class Carro:iVeiculo,iCombate{
    public bool ligado;
    private int municao;
    public Carro(){
        setMunicao(100);
    }
    public void setMunicao(int qtde){
        this.municao = qtde;
    }
    public void ligar(){
        this.ligado = true;
    }
    public void desligar(){
        this.ligado = false;
    }
    public void disparar(){

    }
    public void info(){

    }
}
class Aula43{
    static void Main()
    {
        Carro c1 = new Carro();
    }
}