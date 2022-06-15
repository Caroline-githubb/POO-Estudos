using System;

namespace _03ExercicioEscolar
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instanciar objetoda classe Aluno
            Aluno aluno = new Aluno();

            aluno.nome = "Carol";
            aluno.nota1 = 8;
            aluno.nota2 = 10;
            aluno.Mensagem();

        }
    }
    
}