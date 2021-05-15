using System.Threading.Tasks;
using MediatorPattern.Data.Default.Mediator.Requests;
using MediatorPattern.Data.Default.Mediator.Responses;

namespace MediatorPattern.Data.Default.Mediator
{
    public interface IMediatorHandler
    {
        Task<CreateUserResponse> Handle(CreateUserRequest request);
        Task<UpdateUserResponse> Handle(UpdateUserRequest request);
    }
}
