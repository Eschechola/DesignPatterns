using Strategy.Interfaces;

namespace Strategy.Currencys
{
    public class Dollar : ICurrency
    {
        //Cotação do dia: 07/11/2020
        //Fonte: https://economia.uol.com.br/cotacoes/cambio/
        public double CalculateBRLQuote(double value)
        {
            return value * 5.39;
        }
    }
}
