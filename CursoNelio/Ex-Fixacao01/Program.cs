using Ex_Fixacao01;

namespace CursoNelio
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite o nome da pessoa 1: ");
            p1.Nome = Console.ReadLine() + "";
            Console.WriteLine("Digite o nome da pessoa 1: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine() + "");

            Console.WriteLine("Digite o nome da pessoa 2: ");
            p2.Nome = Console.ReadLine() + "";
            Console.WriteLine("Digite o nome da pessoa 2: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine() + "");

            Console.WriteLine("A pessoa mais velha e: " + (p1.Idade > p2.Idade ? p1.Nome : p2.Nome));



        }

    }
}