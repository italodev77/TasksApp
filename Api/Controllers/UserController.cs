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

        /// <summary>
        /// Rota responsável pela criação de um usuário.
        /// </summary>
        /// <param name="comand">Um objeto <see cref="CreateUserCommand"/> contendo os dados do usuário a ser criado.</param>
        /// <returns>Um objeto <see cref="UserInfoViewModel"/> com os dados do usuário criado.</returns>
        /// <remarks>
        /// Exemplo de request:
        /// ```
        /// POST /User/Create-User
        /// {
        ///     "name": "Jhon",
        ///     "surname": "Doe",
        ///     "username": "JDoe",
        ///     "emai": "teste@teste.com",
        ///     "password": "1234
        /// }
        /// ```
        /// </remarks>
        /// <response code="200">Retorna os dados do usuário criado.</response>
        /// <response code="400">Caso haja erro de validação nos dados fornecidos.</response>

        [HttpPost("Create-User")]
        public async Task<ActionResult<UserInfoViewModel>> CreateUser( CreateUserCommand comand)
        {
            var result = await _mediator.Send(comand);
            return Ok(result);
        }
    }
}
