using System;
class Carro{
    private int  velocidadeMax;
    public int vm{
        get{
                return  velocidadeMax;
        }
        set{
                if(value < 0){
                    velocidadeMax = 0;
                }else if (value > 300){
                    velocidadeMax = 300;
                } else{
                    velocidadeMax = value;
                }                
        }
    }
    public Carro(){
        vm = 120;
    }

}
class Aula41{
    static void Main()
    {
        Carro c1 = new Carro();
        c1.vm=200;
        System.Console.WriteLine("Velocidade: {0}", c1.vm);
    }
}