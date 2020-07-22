using System;

namespace ChainOfResponsibilityPattern
{
    public class FretePequeno : Frete
    {
        public FretePequeno()
        {
            this.valorFrete = 12.00;
        }

        public override void CalcularFrete(Produto produto)
        {
            if(produto.Tamanho == ProdutoTamanho.Pequeno)
            {
                Console.WriteLine("Elegível a frete de produto pequeno.");
                Console.WriteLine("O valor do produto: {0:0.00}, juntamente com o frete: R$ {1:0.00}", produto.Nome, produto.Preco * produto.Quantidade + valorFrete);
            }
            else if(CalculadorDeFrete != null)
            {
                Console.WriteLine("Produto com o frete indisponível");
            }
        }
    }
}
