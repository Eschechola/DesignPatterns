using System;
using System.Collections.Generic;
using ProxyPattern.Interfaces;
using ProxyPattern.Modelos;

namespace ProxyPattern.Classes
{
    public class UsuarioRepositorio : IUsuario
    {
        public IList<Usuario> Usuarios = null;

        public void Exibir()
        {
            foreach (var usuario in Usuarios)
            {
                Console.WriteLine("");
                Console.WriteLine($"Id: {usuario.Id}");
                Console.WriteLine($"Nome: {usuario.Nome}");
                Console.WriteLine($"Email: {usuario.Email}");
            }
        } 

        public void Carregar()
        {
            Usuarios = new List<Usuario>
            {
                new Usuario { Id = 1, Nome = "Lucas", Email = "lucas@eu.com" },
                new Usuario { Id = 2, Nome = "Gabriel", Email = "gabriel@eu.com"},
                new Usuario { Id = 3, Nome = "Matheus", Email = "matheus@eu.com" },
            };
        }
    }
}
