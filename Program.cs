using System;

namespace ExList
{
  public class Program
  {
    public static void Main(string [] args)
    {
      // declarando a list com variavel que seja implementar no caso eu usei string
      List<string> nomes = new List<string>();

      //aqui adiono varios  nomes de uma vez
      nomes.AddRange(new List<string>{"pessoa1","pessoa2","pessoa3"});

      // aqui adiciona 1 a 1
      nomes.Add("PESSOA1");
      nomes.Add("PESSOA2");
      nomes.Add("PESSOA3");

      //Aqui fiz com outra variavel,usei int

      List<int> numeros = new List<int>();

      numeros.Add(10);

      //aqui uso o ferach para ler
      foreach(string x in nomes)
      {
        Console.WriteLine(x);
      }

    }
  }
}
