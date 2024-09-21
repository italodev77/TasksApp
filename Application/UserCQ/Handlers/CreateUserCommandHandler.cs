using Application.UserCQ.Commands;
using Application.UserCQ.ViewModels;
using Domain.Entity;
using Infra.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserCQ.Handlers
{
    public class CreateUserCommandHandler(TasksDbContext context) : IRequestHandler<CreateUserCommand, UserInfoViewModel>
    {
        private readonly TasksDbContext _tasksDbContext = context;
        public async Task<UserInfoViewModel> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User()
            {
                Name = request.Name,
                Surname = request.Surname,
                Email = request.Email,
                PasswordHash = request.Password,
                Username = request.Username,
                RefreshToken = Guid.NewGuid().ToString(),
                RefreshTokenExpirationTime = DateTime.Now.AddDays(5)
            };

           _tasksDbContext.Users.Add(user); 
           _tasksDbContext.SaveChanges();

            var userInfo = new UserInfoViewModel()
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Username = user.Username,
                RefreshnToken = user.RefreshToken,
                RefreshTokenExpirationTime = user.RefreshTokenExpirationTime,
                TokenJWT = Guid.NewGuid().ToString(),
            };
            return userInfo;


        }
    }
}
