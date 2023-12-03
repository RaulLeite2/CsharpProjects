using System;

namespace Myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Física");


            Console.WriteLine("Qual ecuação deseja calcular? \n 1. MRUV \n 2. MUV \n 3. MU \n 4. MRU \n 5. Relatividade Restrita");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    float mruv = deslocamento();
                    Console.WriteLine("O deslocamento foi de: " + mruv);
                    break;
                case 2:
                    float muv = movimentoUV();
                    Console.WriteLine("a Aceleração foi de: " + muv);
                    break;
                case 3:
                    float mu = MovimentoU();
                    Console.WriteLine("a Velocidade foi de " + mu);
                    break;
                case 4:
                    float mru = movimentoRU();
                    Console.WriteLine("o Movimento Retilíno Uniforme é: " + mru);
                    break;

                case 5:
                    float Relatividade = Rr();
                    Console.WriteLine("a Energia é de: " + Relatividade);
                    break;

                default:
                    Console.WriteLine("Erro 404: Ecuação Não encontrada!");
                    break;
            }

            // Funções
            static float deslocamento()
            {
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

                return MRUV4;
            }

            // Movimento Uniformimente Variado
            static float movimentoUV()
            {
                Console.WriteLine("Digite o valor da Velocidade Inicial:");
                float vi = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor da Velocidade Final:");
                float vf = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do Tempo Inicial:");
                float ti = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do Tempo Final:");
                float tf = float.Parse(Console.ReadLine());

                // Aceleração(MUV)
                float aceleracao = (tf - ti) / (vf - vi);

                return aceleracao;
            }

            // Movimento Uniforme
            static float MovimentoU()
            {
                Console.WriteLine("Digite o valor da Posição Final");
                int pf = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor da Posição Incial");
                int pi = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do Tempo Final:");
                float tf = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do Tempo Incial:");
                float ti = float.Parse(Console.ReadLine());

                float velocidade = (pf - pi) / (tf - ti);
                return velocidade;


            }

            // Relatividade E = mc²
            static float Rr()
            {
                Console.WriteLine("Digite a Massa do Objeto: ");
                float massa = float.Parse(Console.ReadLine());
                float energia = massa * 300000000f;
                return energia;
            }

            // Movimento Retilínio Uniforme
            static float movimentoRU()
            {
                Console.WriteLine("Digite o valor do Espaço Inicial: ");
                int espaco = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a Velocidade do objeto: ");
                int Velocidade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Tempo decorrido: ");
                int Tempo = int.Parse(Console.ReadLine());

                int mru = espaco + Velocidade * Tempo;
                return mru;
            }
        }
    }
}
