using System;
class Aula15
{
  static void Main()
  {

    int tempo = 0;
    char escolha;

  inicio: //LABEL

    Console.Clear();

    Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
    Console.WriteLine("Escolha o transporte: [a]Avião | [c]Carro | [o]ônibus ");
    escolha = char.Parse(Console.ReadLine());

    switch (escolha)
    {
      case 'a':
        tempo = 50;
        break;
      case 'c':
        tempo = 480;
        break;
      case 'o':
        tempo = 660;
        break;
      default:
        tempo = -1;
        break;
    }

    if (tempo < 0)
    {
      Console.WriteLine("Transporte indisponivel");
    }
    else
    {
      Console.WriteLine("Para o transporte escolhido o tempo é {0} minutos.", tempo);
    }

    Console.Write("\nVocê gostaria de calcular novamente? [s/n] ");
    escolha = char.Parse(Console.ReadLine());
    if (escolha == 's' || escolha == 'S')
    {
      goto inicio; // DIRECIONA PARA LABEL
    }
    else
    {
      Console.Clear();
      Console.WriteLine("Fim do programa!");
    }

  }
}