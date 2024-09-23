using Api;


var builder = WebApplication.CreateBuilder(args);

builder.AddServices();
builder.AddDatabase();
builder.AddValidations();
builder.AddMapper();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
