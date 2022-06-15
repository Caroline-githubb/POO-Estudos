using System;

namespace _03ExercicioEscolar
{
    class Aluno
    {
        //Atributos
        public string? nome;
        public double nota1,nota2;

        //Metodos:
        //Media
        public double Media()
        {
            return (nota1+nota2)/2;
        }

        //Situação
        public string Situacao(double media)
        {
            return media >=7 ? "APROVADO(A)" : "REPROVADO(A)";
        }

        //Mensagem
        public void Mensagem()
        {
            //obter media
            double obterMedia = Media();
            //obter a situacao
            string obterSituacao = Situacao(obterMedia);
            //mensagem
            Console.WriteLine(nome+ " está "+ obterSituacao + " com média " + obterMedia);
        }
    }
}