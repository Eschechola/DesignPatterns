using MediatR;
using MediatorPattern.Data.MediatR.Mediator.Responses;

namespace MediatorPattern.Data.MediatR.Mediator.Requests
{
    public class UpdateUserRequest : IRequest<UpdateUserResponse>
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
