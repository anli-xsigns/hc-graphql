using GraphQL;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services
    .AddGraphQLServer()
    .AddTypes()
    .AddMutationConventions();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGraphQL();

app.Run();