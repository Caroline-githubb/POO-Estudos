using System;

namespace _13Abstracao
{
    abstract class Padrao
    {
        //Metodo Obrigatório - poder ser publico ou protegido
        public abstract void TaxaEmprestimo(double valor);

        //Metodo Opcional
        public void CalculoPoupanca(double valor, double taxa)
        {
            Console.WriteLine("Ganhos obtidos pela poupança: R$ " + (valor*taxa));
        }
        
    }
}