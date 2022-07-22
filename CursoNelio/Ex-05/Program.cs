using System;
using System.Globalization;
namespace Ex_05
{
    class Program
    {
        static void Main(string[] args)
        {  
            //quando instanciamos o produto, ele está vazio
            Produto p = new Produto("TV", 500, 10);     
            p.Nome = "T";       
            Console.WriteLine(p.Nome);
            



        }
    }
}