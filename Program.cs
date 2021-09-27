using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Calcule a parcela do FGTS sobre o salário de um funcionário (8%).

            Console.Write("Digite o salário do funcionário: R$ ");
            float salario = float.Parse(Console.ReadLine());

            Console.WriteLine($"\nFGTS: R$ {(salario*8)/100}");
        }
    }
}
