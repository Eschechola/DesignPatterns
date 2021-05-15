using System;
using FactoryPattern.Enum;
using FactoryPattern.Factory;
using FactoryPattern.Entities;
using System.Collections.Generic;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Selecione o tipo de factory a ser executada: ");
                Console.WriteLine("\n1 - Factory Simples");
                Console.WriteLine("2 - Factory Complexa\n");
                Console.Write("> ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine(MensagemFactory.GerarMensagem(Dia.Manha));
                        Console.WriteLine(MensagemFactory.GerarMensagem(Dia.Tarde));
                        Console.WriteLine(MensagemFactory.GerarMensagem(Dia.Noite));
                        break;

                    case 2:
                        var acidentes = new List<Acidente>
                        {
                            new Acidente("Gato preso", "Gato preso em cima da árvore!", TipoAcidente.Pequeno),
                            new Acidente("Batida de carro", "Dois carros se colidiram na avenida XYZ as 2 horas da tarde.", TipoAcidente.Medio),
                            new Acidente("Queda de avião", "Avião sofre pane e cai durante a noite de segunda feira.", TipoAcidente.Grande)
                        };

                        foreach (var acidente in acidentes)
                        {
                            var socorro = SocorroFactory.GerarPedidoDeSocorro(acidente.TipoAcidente);
                            socorro.Socorrer(acidente);
                        }
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
