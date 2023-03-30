namespace Exercicio1 //todas as primeiras letras de algo digitado maiúscula;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Escreva o título da sua obra literária: ");//pede a informação pro usuário.
            string obraUsuario = Console.ReadLine()!;

            string obraUsuarioMinuscula = obraUsuario.ToLower();
            string[] obraDigitada = obraUsuarioMinuscula.Split(" ");

            Console.Clear();
            Console.WriteLine("A sua obra literária é: ");

            for (int i = 0; i < obraDigitada.Length; i++)
            {
                char[] primeirasLetras = obraDigitada[i].ToCharArray();
                Console.Write(primeirasLetras[0].ToString().ToUpper() + obraDigitada[i].Substring(1) + " ");

            }
        }
    }
}