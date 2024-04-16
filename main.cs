using System;

class Program {
  public static void Main (string[] args) {
    float varA, varB;
    Console.WriteLine("Digite um número real para A");
    varA = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite um número real para B");
    varB = float.Parse(Console.ReadLine());
    float RepA = varA;
    varA = varB;
    varB = RepA;
    Console.WriteLine("O Resultado da troca de valores é: " + "A:" + varA + " e " + "B:" + varB);
    Console.Read();

  }
}