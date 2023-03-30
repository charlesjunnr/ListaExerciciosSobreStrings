
namespace Exercicio06 //Exercicio do arquivo com as cidades.
                      //Desenvolver um programa que leia um arquivo e dê a possibilidade de apresentar as cidades:
                      //1 - agrupadas pela primeira letra.
                      //2 - agrupadas pelo estado que pertencem.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //precisamos ler o arquivo primeiramente
            string arquivo = File.ReadAllText(@"C:\Users\Charles Junior\source\repos\ListaExerciciosString\Exercicio06\Dados\Cidades.csv");

            //precisamos pegar as linhas dos arquivos
            string[] linhas = arquivo.Split("\r\n");

            //pegar a cidade e o estado 
            string[] cidadesEhEstados = new string[linhas.Length];

            int posicaoCidade = 2;
            int posicaoEstado = 3;
            int j = 0;
            for (int i = 1; i < linhas.Length; i++)
            {
                string[] colunas = linhas[i].Split(";");
                cidadesEhEstados[j] = colunas[posicaoCidade] + ";" + colunas[posicaoEstado];
                j++;
            }
            char[] alfabeto = new char[]
            {
                 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                   'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };

            for (int i = 0;i < alfabeto.Length; i++)
            {
                Console.WriteLine($"\nCidades com a letra {alfabeto[i]}\n");
                for(int x = 0; x < cidadesEhEstados.Length; x++) 
                {
                    char primeiraLetra = alfabeto[i];
                    if (cidadesEhEstados[x] != null && cidadesEhEstados[x].StartsWith(primeiraLetra))
                    {
                        int posicaoInicioEstado = cidadesEhEstados[x].IndexOf(";"); // mostra as cidades sem estado
                        string cidadeSemEstado = cidadesEhEstados[x].Remove(posicaoInicioEstado);
                        Console.WriteLine("\t" + cidadesEhEstados[x]);
                    }
                }
            }
            
            string[] estados = new string[]
            {
                "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal",
                "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul",
                "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro",
                "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina",
                "São Paulo", "Sergipe", "Tocantins"
            };
            for(int i = 0; i < estados.Length; i++)
            {
                string estado = estados[i];
                Console.WriteLine($"Cidades do estado: {estado}\n");
                for(int x = 0; x < cidadesEhEstados.Length; x++)
                {
                    if (cidadesEhEstados[x] != null && cidadesEhEstados[x].Contains(estado))
                    {
                        int posicaoInicioEstado = cidadesEhEstados[x].IndexOf(";");
                        string cidadeSemEstado = cidadesEhEstados[x].Remove(posicaoInicioEstado);
                        Console.WriteLine("\t" + cidadesEhEstados[x]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}