using AbstractFactoryPattern.Enum;
using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Entities;
using AbstractFactoryPattern.AbstractFactory;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Acidente acidentePequeno = new Acidente("Gato preso", "Gato preso em cima da árvore!", TipoAcidente.Pequeno, LocalAcidente.Terrestre);
            Acidente acidenteMedio = new Acidente("Batida de barcos", "Dois barcos se colidiram na praia XYZ as 2 horas da tarde.", TipoAcidente.Medio, LocalAcidente.Marinho);
            Acidente acidenteGrande = new Acidente("Queda de avião", "Avião sofre pane e cai durante a noite de segunda feira.", TipoAcidente.Grande, LocalAcidente.Aereo);

            Socorro socorroPequenoFactory = SocorroFactory.GerarFabricaDeSocorro(acidentePequeno.TipoAcidente);
            Socorro socorroMedioFactory = SocorroFactory.GerarFabricaDeSocorro(acidenteMedio.TipoAcidente);
            Socorro socorroGrandeFactory = SocorroFactory.GerarFabricaDeSocorro(acidenteGrande.TipoAcidente);

            var socorroPequeno = socorroPequenoFactory.GerarSolicitacaoDeSocorro(acidentePequeno);
            var socorroMedio = socorroMedioFactory.GerarSolicitacaoDeSocorro(acidenteMedio);
            var socorroGrande = socorroGrandeFactory.GerarSolicitacaoDeSocorro(acidenteGrande);

            socorroPequeno.ExibirSolicitacaoDeSocorro();
            socorroMedio.ExibirSolicitacaoDeSocorro();
            socorroGrande.ExibirSolicitacaoDeSocorro();
        }
    }
}
