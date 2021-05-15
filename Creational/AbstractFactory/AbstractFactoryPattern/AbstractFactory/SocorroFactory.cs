using System;
using AbstractFactoryPattern.Enum;
using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern.AbstractFactory
{
    public abstract class SocorroFactory
    {
        public static Socorro GerarFabricaDeSocorro(TipoAcidente tipoAcidente)
        {
            switch (tipoAcidente)
            {
                case TipoAcidente.Pequeno:
                    return new SocorroPequenoFactory();

                case TipoAcidente.Medio:
                    return new SocorroMedioFactory();

                case TipoAcidente.Grande:
                    return new SocorroGrandeFactory();

                default:
                    throw new Exception("Tipo de acidente não encontrado!");
            }
        }
    }
}
