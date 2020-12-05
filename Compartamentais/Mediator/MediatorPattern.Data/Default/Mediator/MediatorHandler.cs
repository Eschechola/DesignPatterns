using System;
using System.Threading.Tasks;
using MediatorPattern.Data.Entities;
using MediatorPattern.Data.Repository;
using MediatorPattern.Data.Default.Mediator.Requests;
using MediatorPattern.Data.Default.Mediator.Responses;

namespace MediatorPattern.Data.Default.Mediator
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IUserRepository _userRepository;

        public MediatorHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<CreateUserResponse> Handle(CreateUserRequest request)
        {
            var user = await _userRepository.Create(new User(request.Name, request.Email));

            return new CreateUserResponse
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                CreatedAt = DateTime.Now
            };
        }

        public async Task<UpdateUserResponse> Handle(UpdateUserRequest request)
        {
            var userExists = await _userRepository.GetById(request.Id);

            if (userExists == null)
                return null;

            var user = new User(request.Id, request.Name, request.Email);
            await _userRepository.Update(user);

            return new UpdateUserResponse
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                UpdatedAt = DateTime.Now
            };
        }
    }
}
