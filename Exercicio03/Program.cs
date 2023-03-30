namespace Exercicio03 //Cifra de césar (trocar umas letras por outras à frente pra fazer uma mensagem secreta - Coloquei o valor de +1 pra ficar mais fácil de conferir)
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" -------------------- Mensagem Secreta --------------------- ");
            Console.WriteLine(" - Escreva uma mensagem abaixo e a codificaremos para você - ");
            Console.WriteLine(" ----------------------------------------------------------- ");
            //necessária possível validação caso a pessoa escreva com acentos.
            string textoExemplo = Console.ReadLine()!.ToUpper();//recebe a mensagem a ser alterada

            char[] letrasMensagem = textoExemplo.ToCharArray(); // converte a mensagem pra uma array de char
            Console.WriteLine();
            Console.WriteLine(" - Sua mensagem secreta é:                                 - ");
            Console.Write("   ");

            for (int j = 0; j < letrasMensagem.Length; j++) 
            {
                int[] letrasTabelaAscii = new int[letrasMensagem.Length];

                letrasTabelaAscii[j] = Convert.ToInt32(letrasMensagem[j]); // laço de repetição que converte pra int
                if (letrasTabelaAscii[j] >= 65 && letrasTabelaAscii[j] <= 85) //if que muda os valores das characteres
                {
                    letrasTabelaAscii[j]+=5;
                }
                else if (letrasTabelaAscii[j] > 85 && letrasTabelaAscii[j] <= 90)
                {
                    letrasTabelaAscii[j] = 65;
                }

                char mensagemCodificada = Convert.ToChar(letrasTabelaAscii[j]);// conversão pra char

                Console.Write(mensagemCodificada);//escrita da mensagem

            }
            Console.ReadLine();
        }
    }
}