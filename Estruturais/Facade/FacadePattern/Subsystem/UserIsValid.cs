using FacadePattern.Entities;

namespace FacadePattern.Subsystem
{
    public class UserIsValid
    {
        public bool IsValid(User user)
        {
            if(user.Name.Length >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
