var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte ao MVC (Controllers + Views)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Tratamento de erros em produção
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Rota padrão: quando acessar "/" vai para Aluno/Cadastrar
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Aluno}/{action=Cadastrar}/{id?}");

app.Run();
