using System;
class Aula20
{
  static void Main()
  {

    string senha = "123";
    string senhauser;
    int tentativas = 0;

    do
    {
      Console.Clear();
      Console.WriteLine("Digite a senha: ");
      senhauser = Console.ReadLine();
      tentativas++;
    } while (senha != senhauser);
    Console.WriteLine("Senha correta! {0} tentativas erradas!", tentativas);
  }
}