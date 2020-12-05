using System;

namespace MediatorPattern.Data.MediatR.Mediator.Responses
{
    public class UpdateUserResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
