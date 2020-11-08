using Strategy.Interfaces;

namespace Strategy.Currencys
{
    public class Euro : ICurrency
    {
        //Cotação do dia: 07/11/2020
        //Fonte: https://economia.uol.com.br/cotacoes/cambio/euro-uniao-europeia/
        public double CalculateBRLQuote(double value)
        {
            return value * 6.40;
        }
    }
}
