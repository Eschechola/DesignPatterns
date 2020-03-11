using System;
using ProxyPattern.Classes;
using ProxyPattern.Interfaces;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //carrega os usuários e cria a instância pela primeira vez
            IUsuario usuarioProxy = new UsuarioProxy();
            usuarioProxy.Exibir();

            //já na segunda vez já utiliza a instância existente
            usuarioProxy.Exibir();

            Console.ReadKey();
        }
    }
}
