using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * CENÁRIO
             * Um produto deve ser entregue e temos que avaliar o tamanho do produto
             * Para ver o valor do frete
             * 
             */

            Frete freteGrande = new FreteGrande();
            Frete freteMedio = new FreteMedio();
            Frete fretePequeno = new FretePequeno();

            freteGrande.SetCalculador(freteMedio);
            freteMedio.SetCalculador(fretePequeno);

            Produto produto;

            //calculo de produto pequeno
            produto = new Produto(3, "Teclado RGB", 250.00, 2, ProdutoTamanho.Pequeno);
            freteGrande.CalcularFrete(produto);

            Console.WriteLine();

            //calculo de produto medio
            produto = new Produto(2, "Cadeira Gamer", 700.00, 1, ProdutoTamanho.Medio);
            freteGrande.CalcularFrete(produto);

            Console.WriteLine();

            //calculo de produto grande
            produto = new Produto(1, "Geladeira Cromada", 7000.00, 1, ProdutoTamanho.Grande);
            freteGrande.CalcularFrete(produto);
           

            Console.ReadKey();
        }
    }
}
