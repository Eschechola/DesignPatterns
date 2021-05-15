namespace ChainOfResponsibilityPattern
{
    public abstract class Frete
    {
        protected double valorFrete;
        protected Frete CalculadorDeFrete;

        public void SetCalculador(Frete calculadorDeFrete)
        {
            this.CalculadorDeFrete = calculadorDeFrete;
        }

        public abstract void CalcularFrete(Produto produto);
    }
}
