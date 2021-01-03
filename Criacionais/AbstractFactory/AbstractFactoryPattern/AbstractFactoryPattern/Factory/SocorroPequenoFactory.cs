using System;
using System.Text;
using AbstractFactoryPattern.Entities;
using AbstractFactoryPattern.Enum;

namespace AbstractFactoryPattern.Factory
{
    public class SocorroPequenoFactory : Socorro
    {
        public SocorroPequenoFactory()
        {}

        public override Socorro GerarSolicitacaoDeSocorro(Acidente acidente)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Solicitação de socorro para o acidente: {acidente.Titulo}");
            stringBuilder.AppendLine($"Número da solicitação de socorro: #{acidente.Id}");
            stringBuilder.AppendLine($"Gerando solicitação de socorro para acidentes PEQUENOS.");


            switch (acidente.LocalAcidente)
            {
                case LocalAcidente.Terrestre:
                    stringBuilder.AppendLine("O tipo de resgate será TERRESTRE.");
                    break;

                case LocalAcidente.Marinho:
                    stringBuilder.AppendLine("O tipo de resgate será MARINHO.");
                    break;

                case LocalAcidente.Aereo:
                    stringBuilder.AppendLine("O tipo de resgate será AÉREO.");
                    break;

                default:
                    throw new Exception("Local do acidente desconhecido!");
            }

            return new Socorro(mensagemSocorro: stringBuilder.ToString());
        }
    }
}
