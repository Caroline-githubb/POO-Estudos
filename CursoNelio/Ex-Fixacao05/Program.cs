using System.Globalization;
using Ex_Fixacao05;

namespace CursoNelio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.LerAluno();
            aluno.ExibirResultado();
           
        }
    }
}