using Application.UserCQ.Commands;
using Application.UserCQ.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Infra.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Api
{
    public static class BuilderExtensions
    {
        public static void AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblies(typeof(CreateUserCommand).Assembly));

        }
        public static void AddDatabase(this WebApplicationBuilder builder)
        {
            var configuration = builder.Configuration;
            builder.Services.AddDbContext<TasksDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        }
        public static void AddValidations(this WebApplicationBuilder builder)
        {
            builder.Services.AddValidatorsFromAssemblyContaining<CreateUserComandValidator>();
            builder.Services.AddFluentValidationAutoValidation();


        }
    }
}
