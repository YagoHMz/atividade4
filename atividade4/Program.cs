using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num_alunos;
        Console.WriteLine("Digite quantos alunos deseja ler: ");
        Int32.TryParse(Console.ReadLine(), out num_alunos);
        Double[] g1 = new Double[num_alunos];
        Double[] g2 = new Double[num_alunos];
        Double[] media = new Double[num_alunos];


        for (int i = 0; i < num_alunos; i++)
        {
            Console.WriteLine("Digite a nota G1 do aluno" + (i + 1) + ": ");
            Double.TryParse(Console.ReadLine(), out g1[i]);
            Console.WriteLine("Digite a nota G2 do aluno" + (i + 1) + ": ");
            Double.TryParse(Console.ReadLine(), out g2[i]);
            media[i] = (g1[i] + g2[i]) / 2;

        }

        for (int i = 0; i < num_alunos; i++)
        {
            Console.WriteLine("Aluno " + (i + 1));
            Console.WriteLine("Nota G1: " + g1[i]);
            Console.WriteLine("Nota G2: " + g2[i]);
            Console.WriteLine("Média Aritmética: " + media[i]);
            Console.WriteLine("\n");
        }


    }
}
