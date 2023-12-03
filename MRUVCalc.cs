using System;

namespace Myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de MRUV");

            // Valores
            Console.WriteLine("Digite o valor da Velocidade Inicial:");
            float vi = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da Velocidade Final:");
            float vf = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do Tempo Inicial:");
            float ti = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do Tempo Final:");
            float tf = float.Parse(Console.ReadLine());

            // Cálculos: Aceleração
            float vartemp = tf - ti;
            float varvelo = vf - vi;
            float aceleracao = varvelo / vartemp;

            // Cálculo do Deslocamento: MRUV
            float MRUV1 = vartemp * vartemp;
            float MRUV2 = aceleracao * MRUV1;
            float MRUV3 = vi * vartemp;
            float MRUV4 = MRUV3 + 0.5f * MRUV2; // Correção na fórmula do MRUV

            // Resultado
            Console.WriteLine("O deslocamento no MRUV é: " + MRUV4);
        }
    }
}
