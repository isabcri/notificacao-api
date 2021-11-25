using Context.Notificacao;
using infra.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using notificacaoapi.Service;

var builder = WebApplication.CreateBuilder(args);

string connectionString = "";

builder.Services.AddDbContext<NotificacaoContext>(options => options
.UseSqlServer(connectionString));

builder.Services.AddControllers();

builder.Services.AddScoped<INotificacaoService, NotificacaoService>();

builder.Services.AddScoped<INotificacaoRepository, NotificacaoRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
