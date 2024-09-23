using Application.Response;
using Application.UserCQ.Commands;
using Application.UserCQ.ViewModels;
using AutoMapper;
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
    public class CreateUserCommandHandler(TasksDbContext context, IMapper mapper) : IRequestHandler<CreateUserCommand, ResponseBase<UserInfoViewModel?>>
    {
        private readonly TasksDbContext _tasksDbContext = context;
        private readonly IMapper _mapper = mapper;
        public async Task<ResponseBase<UserInfoViewModel>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);
            

           _tasksDbContext.Users.Add(user); 
           _tasksDbContext.SaveChanges();

            return new ResponseBase<UserInfoViewModel>
            {
                ResponseInfo = null,
                Value = _mapper.Map<UserInfoViewModel>(user)
            };

        }
    }
}
