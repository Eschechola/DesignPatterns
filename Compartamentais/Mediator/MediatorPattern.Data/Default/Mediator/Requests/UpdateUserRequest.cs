namespace MediatorPattern.Data.Default.Mediator.Requests
{
    public class UpdateUserRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public UpdateUserRequest()
        {}

        public UpdateUserRequest(long id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
