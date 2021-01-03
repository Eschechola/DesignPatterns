using System;
using FactoryPattern.Entities;
using FactoryPattern.Enum;
using FactoryPattern.Functions;

namespace FactoryPattern.Factory
{
    public static class SocorroFactory
    {
        public static Socorro GerarPedidoDeSocorro(TipoAcidente tipoAcidente)
        {
            switch (tipoAcidente)
            {
                case TipoAcidente.Pequeno:
                    return new SocorroAcidentePequeno();

                case TipoAcidente.Medio:
                    return new SocorroAcidenteMedio();

                case TipoAcidente.Grande:
                    return new SocorroAcidenteGrande();

                default:
                    throw new Exception("Tipo de acidente não identificado!");
            }
        }
    }
}
