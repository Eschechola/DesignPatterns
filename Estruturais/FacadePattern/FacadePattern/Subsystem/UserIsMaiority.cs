using FacadePattern.Entities;

namespace FacadePattern.Subsystem
{
    public class UserIsMaiority
    {
        public bool IsMaiority(User user)
        {
            if(user.Age >= 18)
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
