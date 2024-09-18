﻿using Application.UserCQ.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserCQ.Commands
{
    public class CreateUserCommand: IRequest<UserInfoViewModel>
    {

    }
}
