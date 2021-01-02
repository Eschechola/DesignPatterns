using FactoryPattern.Entities;
using System;

namespace FactoryPattern.Functions
{
    public abstract class Socorro
    {
        public long Id { get; set; }
        public DateTime DataSocorro { get; set; }

        public abstract void GerarSocorro(Acidente acidente);
    }
}
