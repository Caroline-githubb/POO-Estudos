using System.Globalization;
namespace Ex_05
{
    class Produto
    {
        //ORDEM SUGERIDA
        //1. Atributos Privados
        private string _nome;
        //2. Auto Properties
        public double Preco {get; private set;} // colocado private set para indicar que o preço nao pode ser alterado em outro arquivo
        public int Quantidade { get; private set; }

        //3. Construtores
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // 4. Propriedades customizadas
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        
        /*public string GetNome()
        {
            return _nome;
        }  

        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
            
        }*/

        /*public double Preco
        {
            get { return _preco; }

        }*/

        /*public int Quantidade
        {
            get { return _quantidade;}
        }
        /*public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }*/


        // 5. Outros metodos da classe
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}