namespace Exercicio02 //escrever um programa que conta as palavras de uma frase digitada pelo usuário. 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string cabecalho = "*";
            Console.Write(cabecalho.PadLeft(10,'*') + " Digite uma frase de sua preferência: ");
            Console.WriteLine(cabecalho.PadRight(10, '*'));
            string frasePreferencia = Console.ReadLine()!;
            
            string[] palavrasContadas = frasePreferencia.Split(" ");
            Console.WriteLine();

            Console.WriteLine($"Sua frase tem um total de {palavrasContadas.Length} palavras.");
            if(palavrasContadas.Length > 10)
            {
                Console.WriteLine("É um palavrão!(literalmente)");
            }
            else
            {
                Console.WriteLine("É um palavrinho!");
            }
        }
    }
}