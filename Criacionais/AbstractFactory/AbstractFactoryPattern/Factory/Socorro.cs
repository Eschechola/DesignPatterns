using System;
using AbstractFactoryPattern.Entities;

namespace AbstractFactoryPattern.Factory
{
    public class Socorro
    {
        public long Id { get; set; }
        public DateTime DataSocorro { get; set; }
        public string MensagemSocorro { get; protected set; }

        public Socorro()
        {}

        public Socorro(string mensagemSocorro)
        {
            Id = new Random().Next(0, 999);
            DataSocorro = DateTime.Now;
            MensagemSocorro = mensagemSocorro;
        }

        public virtual Socorro GerarSolicitacaoDeSocorro(Acidente acidente) => throw new NotImplementedException();

        public void ExibirSolicitacaoDeSocorro() => Console.WriteLine(MensagemSocorro);
    }
}
