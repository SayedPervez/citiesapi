var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseExceptionHandler();
//app.UseHsts();
app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();
//app.UseCors();
//app.UseAuthentication();
//app.UseAuthorization();
//app.MapControllers();


app.Map("/admin", adminBranch =>
{
    adminBranch.Use(async (context, next) =>
    {
        Console.WriteLine("Admin Access Verified");
        await next();
    });
});

app.UseRouting();
app.MapControllers();


app.UseAuthorization();

app.MapControllers();


app.Run();
