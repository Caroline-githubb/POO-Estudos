using System.Globalization;

namespace Ex_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine()+"";
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);

            //Console.WriteLine($"Dados do produto: {p.Nome}, R$ {p.Preco}, {p.Quantidade} unidades, Total: R$ {p.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p); 

            Console.WriteLine();
            Console.Write("Digite o número de produto a ser adicionado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine() + "");
            p.AdicionarProdutos(qtde);            

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtde = int.Parse(Console.ReadLine() + "");
            p.RemoveProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
