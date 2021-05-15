namespace MediatorPattern.Data.Default.Mediator.Requests
{
    public class CreateUserRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public CreateUserRequest()
        {}

        public CreateUserRequest(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
