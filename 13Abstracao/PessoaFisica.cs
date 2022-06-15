using System;

namespace _13Abstracao
{
    class PessoaFisica : Padrao
    {
        //Metodo obrigatório
        public override void TaxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de empréstimo para pessoa fisica: R$ " + (valor*0.1));
        }
    }
}