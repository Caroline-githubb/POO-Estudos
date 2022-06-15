using System;

namespace _13Abstracao
{
    class PessoaJuridica : Padrao
    {
        //Metodo obrigatório
        public override void TaxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de empréstimo para pessoa juridica: R$ " + (valor*0.20));
        }
    }
}