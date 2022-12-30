using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using GraphQlTraining.GraphQueries;
using GraphQlTraining.GraphSchemas;
using GraphQlTraining.GraphTypes;
using GraphQlTraining.Services;
using GraphQlTraining.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IMenuService, MenuService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddSingleton<MenuType>();
builder.Services.AddSingleton<ProductType>();
builder.Services.AddSingleton<MenuQuery>();
builder.Services.AddSingleton<ProductQuery>();
builder.Services.AddSingleton<RootQuery>();
builder.Services.AddTransient<ISchema,RootSchema>();

builder.Services.AddGraphQL(options =>
{
    options.EnableMetrics = false;
}).AddSystemTextJson();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();
app.UseGraphiQl("/graph");
app.UseGraphQL<ISchema>();

app.Run();
