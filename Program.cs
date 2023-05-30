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
      numeros.Add(9);

      //aqui uso o ferach para ler
      foreach(string x in nomes)
      {
        Console.WriteLine(x);
      }

      foreach(int y in numeros)
      {
        Console.WriteLine(y);
      }

      nomes[0] = "Alteracao";
      foreach(string a in nomes)
      {
        Console.WriteLine(a);
      }
      nomes.Remove("Alterecao");
      nomes.Remove("pessoa2");
      nomes.Remove("pessoa3");
      nomes.RemoveAt(3);
      numeros.RemoveAt(0);

      foreach(string b in nomes)
      {
        Console.WriteLine(b);
      }

      foreach(int num in numeros)
      {
        Console.WriteLine(num);
      }

    }
  }
}
