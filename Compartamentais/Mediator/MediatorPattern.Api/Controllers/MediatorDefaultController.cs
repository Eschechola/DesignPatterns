using MediatorPattern.Data.Default.Mediator;
using MediatorPattern.Data.Default.Mediator.Requests;
using MediatorPattern.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MediatorPattern.Api.Controllers
{
    [ApiController]
    public class MediatorDefaultController : ControllerBase
    {
        private readonly IMediatorHandler _mediator;

        public MediatorDefaultController(IMediatorHandler mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("/api/v1/default/user/create")]
        public async Task<IActionResult> Create([FromBody] User user)
        {
            try
            {
                var userCreated = await _mediator.Handle(new CreateUserRequest(user.Name, user.Email));

                return Ok(userCreated);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocorreu algum erro interno na aplicaçao. Por favor tente novamente!");
            }
        }

        [HttpPut]
        [Route("/api/v1/default/user/update")]
        public async Task<IActionResult> Update([FromBody] User user)
        {
            try
            {
                var userUpdated = await _mediator.Handle(new UpdateUserRequest(user.Id, user.Name, user.Email));

                return Ok(userUpdated);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocorreu algum erro interno na aplicaçao. Por favor tente novamente!");
            }
        }
    }
}
