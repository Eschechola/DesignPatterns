using Strategy.Interfaces;

namespace Strategy.Currencys
{
    public class Libra : ICurrency
    {
        //Cotação do dia: 07/11/2020
        //Fonte: https://economia.uol.com.br/cotacoes/cambio/libra-esterlina-reino-unido/
        public double CalculateBRLQuote(double value)
        {
            return value * 7.09;
        }
    }
}
