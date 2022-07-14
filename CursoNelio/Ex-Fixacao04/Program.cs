using Ex_Fixacao04;

namespace CursoNelio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            func.LerDados();
            func.ExibirDados();
            func.AumentarSalario();            
            func.AtualizarDados();
        }
    }
}