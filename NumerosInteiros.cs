using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    int [] numero = new int [10];
    
      for (int n = 1; n <= 10; n++){
        numero [n - 1] = n;
        Console.WriteLine(n);
    }
  int menor = numero.Min();
  int maior = numero.Max();
    
    Console.WriteLine($"O menor valor é {menor}");
    Console.WriteLine($"O maior valor é {maior}");

    
  }
}