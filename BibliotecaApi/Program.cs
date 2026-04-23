using BibliotecaApi.Data;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Repositório em memória (Singleton para manter dados entre requisições)
builder.Services.AddSingleton<BibliotecaRepository>();

builder.Services.AddControllers();

// TODO: Configurar Swagger/OpenAPI aqui (Passo 2)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.OpenApiInfo
    {
        Version ="v1",
        Title = "API da Biblioteca",
        Description = " API REST para gerenciamento do acervo e emprestimo de uma biblioteca.",
        Contact = new Microsoft.OpenApi.OpenApiContact
        {
            Name =" Equipe de Desenvolvimento",
            Email = "dev@biblioteca.exemplo.com"
        }
    });
    // Inclui os comentários XML na documentação Swagger
    var xmlFilename = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFilename);
    if (File.Exists(xmlPath))
    {
        options.IncludeXmlComments(xmlPath);
    }
});

var app = builder.Build();

// TODO: Adicionar middlewares do Swagger aqui (Passo 3)
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "API da Biblioteca v1");
    options.RoutePrefix = string.Empty;
    options.DocumentTitle = "Documentação - API da Biblioteca";
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
