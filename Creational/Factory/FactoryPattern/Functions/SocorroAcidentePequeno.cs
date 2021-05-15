using System;
using FactoryPattern.Entities;

namespace FactoryPattern.Functions
{
    public class SocorroAcidentePequeno : Socorro
    {
        public SocorroAcidentePequeno()
        {
            Id = new Random().Next(0, 999);
            DataSocorro = DateTime.Now;
        }

        public override void Socorrer(Acidente acidente)
        {
            Console.Write($"\n\nAcidente: {acidente.Titulo}\n");
            Console.Write($"Número da solicitação de socorro: #{Id}\n");
            Console.Write("Gerando solicitação de socorro para acidentes PEQUENOS.");
        }
    }
}
