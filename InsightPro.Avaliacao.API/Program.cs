using InsightPro.Avaliacao.Application.Services;
using InsightPro.Avaliacao.Data.AppData;
using InsightPro.Avaliacao.Data.Repositories;
using InsightPro.Avaliacao.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseOracle(builder.Configuration["ConnectionStrings:Oracle"]);
});


builder.Services.AddTransient<IAvaliacaoRepository, AvaliacaoRepository>();
builder.Services.AddTransient<IAvaliacaoApplicationService, AvaliacaoApplicationService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {

    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
