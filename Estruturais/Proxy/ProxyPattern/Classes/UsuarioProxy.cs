using ProxyPattern.Interfaces;

namespace ProxyPattern.Classes
{
    public class UsuarioProxy : IUsuario
    {
        private static UsuarioRepositorio repositorioInstancia;

        public void Exibir()
        {
            if (repositorioInstancia == null)
            {
                repositorioInstancia = new UsuarioRepositorio();
            }

            if(repositorioInstancia.Usuarios != null)
            {
                repositorioInstancia.Carregar();
            }

            repositorioInstancia.Exibir();
        }
    }
}
