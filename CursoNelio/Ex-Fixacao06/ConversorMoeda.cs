namespace Ex_Fixacao06
{
    public class ConversorMoeda
    {
        public static double Iof = 0.06; 

        public static double DolarParaReal(double cotacao, double dolar)
        {
            double total = cotacao*dolar;
            return (total*Iof)+total;         
            
        }
    }
}