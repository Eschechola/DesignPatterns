namespace BridgePattern.Fretes
{
    public class Frete
    {
        IFrete _frete;

        public Frete(IFrete frete)
        {
            _frete = frete;
        }

        public double CalcularValorDoFrete(string cep)
        {
            return _frete.CalcularValorDoFrete(cep);
        }
    }
}
