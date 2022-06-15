using System; //importar funcionalidade

namespace _01Conceitos //local onde está o meu projeto
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Instanciar um objeto(cria-lo)
            Pessoa obj = new Pessoa();
            obj.nome = "Carol";
            obj.idade = 27;
            obj.Mensagem();


        }
    }

}