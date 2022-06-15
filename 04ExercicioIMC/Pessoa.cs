using System;

namespace _04ExercicioIMC
{
    class Pessoa
    {
        //Atributos
        public double peso;
        public double altura;

        //Metodo
        public double CalculoImc()
        {
            return peso / (altura*altura);
        }

        public string SituacaoImc(double imc)
        {
            string retorno;

            if(imc < 18.5)
            {
                retorno = "Abaixo do peso";
            }
            else if(imc < 25)
            {
                retorno = "Peso normal";
            }
            else if(imc < 30)
            {
                retorno = "Acima do peso";
            }
            else if(imc < 35)
            {
                retorno = "Obesidade I";
            }
            else if(imc < 40)
            {
                retorno = "Obesidade II";
            }
            else
            {
                retorno = "Obesidade III";
            }

            return retorno;            
        }

        public void Mensagem()
        {
            double obterIMC = CalculoImc();
            string obterSituacao = SituacaoImc(obterIMC);
            Console.WriteLine($"O cálculo do seu IMC é {obterIMC} e a sua situação é {obterSituacao}");
        }


    }
}