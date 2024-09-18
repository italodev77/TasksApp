using Application.UserCQ.Commands;
using Application.UserCQ.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;
        public async Task<ActionResult<UserInfoViewModel>> CreateUser( CreateUserCommand comand)
        {
            var result = await _mediator.Send(comand);
            return Ok(result);
        }
    }
}
