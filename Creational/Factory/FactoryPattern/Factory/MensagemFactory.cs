using System;
using FactoryPattern.Enum;

namespace FactoryPattern.Factory
{
    public static class MensagemFactory
    {
        public static string GerarMensagem(Dia dia)
        {
            switch (dia)
            {
                case Dia.Manha:
                    return "Bom dia!";

                case Dia.Tarde:
                    return "Boa tarde!";

                case Dia.Noite:
                    return "Boa noite!";

                default:
                    throw new Exception("Horário não encontrado!");
            }
        }
    }
}
