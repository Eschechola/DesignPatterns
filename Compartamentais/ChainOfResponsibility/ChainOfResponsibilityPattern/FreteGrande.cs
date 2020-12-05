using System;

namespace ChainOfResponsibilityPattern
{
    public class FreteGrande : Frete
    {
        public FreteGrande()
        {
            this.valorFrete = 130.00;
        }

        public override void CalcularFrete(Produto produto)
        {
            if (produto.Tamanho == ProdutoTamanho.Grande)
            {
                Console.WriteLine("Elegível a frete de produto grande.");
                Console.WriteLine("O valor do produto: {0}, juntamente com o frete: R$ {1:0.00}", produto.Nome, produto.Preco * produto.Quantidade + valorFrete);
            }
            else if (CalculadorDeFrete != null)
            {
                CalculadorDeFrete.CalcularFrete(produto);
            }
        }
    }
}
