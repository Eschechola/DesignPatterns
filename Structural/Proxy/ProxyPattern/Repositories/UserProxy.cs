namespace ProxyPattern.Repositories
{
    public class UserProxy : IUserRepository
    {
        private UserRepository _repository = null;

        public void Show()
        {
            if (_repository == null)
                _repository = new UserRepository();

            if(_repository != null)
                _repository.Load();

            _repository.Show();
        }
    }
}
