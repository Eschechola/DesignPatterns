using System;
using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatorPattern.Data.Entities;
using MediatorPattern.Data.MediatR.Mediator.Requests;

namespace MediatorPattern.Api.Controllers
{
    [ApiController]
    public class MediatorMediatRController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MediatorMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("/api/v1/mediatr/user/create")]
        public async Task<IActionResult> Create([FromBody]User user)
        {
            try
            {
                var userCreated = await _mediator.Send(new CreateUserRequest(user.Name, user.Email));

                return Ok(userCreated);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocorreu algum erro interno na aplicaçao. Por favor tente novamente!");
            }
        }

        [HttpPut]
        [Route("/api/v1/mediatr/user/update")]
        public async Task<IActionResult> Update([FromBody] User user)
        {
            try
            {
                var userUpdated = await _mediator.Send(new UpdateUserRequest(user.Id, user.Name, user.Email));

                return Ok(userUpdated);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocorreu algum erro interno na aplicaçao. Por favor tente novamente!");
            }
        }
    }
}
