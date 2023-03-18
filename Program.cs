using System.Reflection.Metadata.Ecma335;

namespace DiamentesX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int asteriscos, espacos;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Desenho de diamante com números ímpares!");
                Console.WriteLine();
                Console.Write("Digite um número ímpar: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (numero % 2 == 1)
                {
                    asteriscos = 1;
                    espacos = (numero - 1) / 2;

                    //parte superior --
                    for (int linha = 1; espacos > 0; linha++)
                    {

                        for (int i = 1; i <= espacos; i++)
                        {
                            Console.Write(" ");
                        }


                        for (int i = 1; i <= asteriscos; i++)
                        {
                            Console.Write("x");
                        }

                        espacos--;//decrementa 1
                        asteriscos += 2;//incrementa 2 
                        Console.WriteLine(); //parte para a próxima linha
                    }

                    //parte inferior ++
                    for (int linha = 1; asteriscos > 0; linha++)
                    {

                        for (int i = 1; i <= espacos; i++)
                        {
                            Console.Write(" ");
                        }


                        for (int i = 1; i <= asteriscos; i++)
                        {
                            Console.Write("x");
                        }

                        espacos++;//incrementa 1
                        asteriscos -= 2;//decrementa 2
                        Console.WriteLine(); //próxima linha
                    }
                }

                else
                {
                    Console.WriteLine("Não é Ímpar!"); //mensagem número par
                }
                Console.ReadLine();
                continue;
            }
        }
    }
}
