using Microsoft.EntityFrameworkCore;
using SpaceWebApi.EfCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<EF_DataContext>(options =>
   options.UseNpgsql(builder.Configuration.GetConnectionString("Ef_Postgres_Db"))
   );

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.UseRouting();

app.MapControllers();

app.Run();
