using System;
using FacadePattern.Entities;
using FacadePattern.Subsystem;

namespace FacadePattern.Facade
{
    public class FacadeClass
    {
        private UserIsMan userIsMen = new UserIsMan();
        private UserIsMaiority userIsMaiority = new UserIsMaiority();
        private UserIsValid userIsValid = new UserIsValid();

        public bool UserNeedAlistment(User user)
        {
            //se o usuário não for válido
            if (!userIsValid.IsValid(user))
            {
                Console.WriteLine("Usuário não tem um nome válido...");
                Console.WriteLine("Usuário nao precisa se alistar...");
                return false;
            }
            //se o usuário não for homem
            else if (!userIsMen.IsMen(user))
            {
                Console.WriteLine("Usuário não é do sexo masculino...");
                Console.WriteLine("Usuário nao precisa se alistar...");
                return false;
            }
            //se o usuário não for maior de idade
            else if (!userIsMaiority.IsMaiority(user))
            {
                Console.WriteLine("Usuário não tem a idade maior ou igual a 18 anos...");
                Console.WriteLine("Usuário nao precisa se alistar...");
                return false;
            }

            //caso ele tenha passado por todas as camadas de regras de negocio
            //retorna true, usuário precisa se alistar
            Console.WriteLine("Usuário precisa se alistar...");
            return true;
        }
    }
}
