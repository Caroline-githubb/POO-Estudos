using System;

namespace _06Encapsulamento
{
    class Aluno
    {
        //Atributos;
        private double nota1, nota2;

        //Metodo media
        private double Media()
        {
            return (nota1+nota2)/2;
        }

        //Mensagem
        public void Mensagem()
        {
            Console.WriteLine("Informe a primeira nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A sua média é "+ Media());
        }



    }
}