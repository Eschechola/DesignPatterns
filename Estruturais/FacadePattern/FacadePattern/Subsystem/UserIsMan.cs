using FacadePattern.Entities;

namespace FacadePattern.Subsystem
{
    public class UserIsMan
    {
        public bool IsMen(User user)
        {
            if(user.Gender == 'M')
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
