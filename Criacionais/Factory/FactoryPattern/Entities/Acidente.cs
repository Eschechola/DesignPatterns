using System;
using FactoryPattern.Enum;

namespace FactoryPattern.Entities
{
    public class Acidente
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAcidente { get; set; }
        public TipoAcidente TipoAcidente { get; set; }

        public Acidente(
            string titulo,
            string descricao,
            TipoAcidente tipoAcidente
        )
        {
            Id = new Random().Next(0, 999);
            Titulo = titulo;
            Descricao = descricao;
            DataAcidente = DateTime.Now;
            TipoAcidente = tipoAcidente;
        }
    }
}
