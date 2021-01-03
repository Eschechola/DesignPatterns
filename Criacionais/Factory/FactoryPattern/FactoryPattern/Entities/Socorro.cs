using System;
using FactoryPattern.Entities;

namespace FactoryPattern.Entities
{
    public abstract class Socorro
    {
        public long Id { get; set; }
        public DateTime DataSocorro { get; set; }

        public abstract void Socorrer(Acidente acidente);
    }
}
