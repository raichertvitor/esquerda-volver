using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de comandos emitidos pelo SGT: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a série de comandos emitidos pelo SGT, utilizando 'E' para esquerda e 'D' para direita: ");
            string comandos = Convert.ToString(Console.ReadLine().ToUpper());
            char inicial = 'N';

            foreach (char comando in comandos)
            {

                if (comando == 'D')
                {
                    if (inicial == 'N')
                    {
                        inicial = 'L';
                    }
                    else if (inicial == 'L')
                    {
                        inicial = 'S';
                    }
                    else if (inicial == 'S')
                    {
                        inicial = 'O';
                    }
                    else if (inicial == 'O')
                    {
                        inicial = 'N';
                    }
                }

                else if (comando == 'E')
                {
                    if (inicial == 'N')
                    {
                        inicial = 'O';
                    }
                    else if (inicial == 'O')
                    {
                        inicial = 'S';
                    }
                    else if (inicial == 'S')
                    {
                        inicial = 'L';
                    }
                    else if (inicial == 'L')
                    {
                        inicial = 'N';
                    }

                }
            }
            Console.WriteLine($"a direção para qual o soldado está olhando é: {inicial}");

        }
    }
}
