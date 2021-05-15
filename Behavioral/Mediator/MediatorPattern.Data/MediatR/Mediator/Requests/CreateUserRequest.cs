using MediatR;
using MediatorPattern.Data.MediatR.Mediator.Responses;

namespace MediatorPattern.Data.MediatR.Mediator.Requests
{
    public class CreateUserRequest : IRequest<CreateUserResponse>
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
