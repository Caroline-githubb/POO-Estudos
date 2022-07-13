using System;
using System.Globalization;

namespace Ex_01
{
    public class Triangulo
    {
        //Atributos
        //são publicos para que possam serem acessados em outro lugar
        public double LadoA;
        public double LadoB;
        public double LadoC;

        //Metodo
        public double Area() // n foi necessario coloca parametros, pois todos os ados necessarios para calcular a area ja pertencem a classe
        {
            double p = (LadoA+LadoB+LadoC) / 2.0;
            return Math.Sqrt(p*(p-LadoA)*(p-LadoB)*(p-LadoC));
        }

        

        
    }
}