namespace Exercicio05 // criar um programa que:
                      // solicite uma frase e a mude para: maiúsculo, minúsculo, pegue a primeira palavra, pegue a última palavra e conte as caracteres.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ehContinuar=true;
            
            
                
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("--          Digite uma mensagem para aparecer abaixo:        --");
                string mensagemUsuario = Console.ReadLine()!;
                
            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine($"-- {mensagemUsuario} -- ");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine(" --              Menu de alterações da mensagem              -- ");
                Console.WriteLine(" -- 1 - Mudar para maiúsculo.");
                Console.WriteLine(" -- 2 - Mudar para minúsculo.");
                Console.WriteLine(" -- 3 - Informar a quantidade de caracteres da frase.");
                Console.WriteLine(" -- 4 - Mostrar a primeira palavra da frase.");
                Console.WriteLine(" -- 5 - Mostrar a última palavra da frase.");
                Console.WriteLine(" -- 6 - Sair.");
                int escolhaUsuario = Convert.ToInt32(Console.ReadLine());

                switch (escolhaUsuario)
                {
                    case 1: mensagemUsuario = mensagemUsuario.ToUpper(); break;
                    case 2: mensagemUsuario = mensagemUsuario.ToLower(); break;
                    case 3:
                        char[] mensagemCaractere = mensagemUsuario.ToCharArray();
                        Console.WriteLine($"A mensagem tem um total de {mensagemCaractere.Length} caracteres.");
                        break;

                    case 4:
                        string[] palavrasSeparadas = mensagemUsuario.Split(" ");
                        Console.WriteLine(palavrasSeparadas[0]);
                        break;

                    case 5:
                        palavrasSeparadas = mensagemUsuario.Split(" ");
                        Console.WriteLine(palavrasSeparadas[palavrasSeparadas.Length-1]);
                        break;

                    case 6:
                        ehContinuar = false; break;
                    default:
                        Console.WriteLine("Esse número é inválido!");
                        return;
                }
                Console.ReadKey();
            } while(ehContinuar);
            

            

        }
    }
}