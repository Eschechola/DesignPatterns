using System;

namespace ChainOfResponsibilityPattern
{
    public class FreteMedio : Frete
    {
        public FreteMedio()
        {
            valorFrete = 50.00;
        }

        public override void CalcularFrete(Produto produto)
        {
            if (produto.Tamanho == ProdutoTamanho.Medio)
            {
                Console.WriteLine("Elegível a frete de produto pequeno");
                Console.WriteLine("O valor do produto: {0:0.00}, juntamente com o frete: R$ {1:0.00}", produto.Nome, produto.Preco * produto.Quantidade + valorFrete);
            }
            else if (CalculadorDeFrete != null)
            {
                CalculadorDeFrete.CalcularFrete(produto);
            }
        }
    }
}
