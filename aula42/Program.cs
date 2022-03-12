using System;
class Carro{
    private int[]  velocidadeMax = new int[5]{80, 120, 160, 240, 300};
    public int this[int i]{
        get{
                return  velocidadeMax[i];
        }
        set{
                if(value < 0){
                    velocidadeMax[i] = 0;
                }else if (value > 300){
                    velocidadeMax[i] = 300;
                } else{
                    velocidadeMax[i] = value;
                }                
        }
    }
    public Carro(){
    }

}
class Aula42{
    static void Main()
    {
        Carro c1 = new Carro();
        c1[4]=200;
        System.Console.WriteLine("Velocidade: {0}", c1[4]);
    }
}