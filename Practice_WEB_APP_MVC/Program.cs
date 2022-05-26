
using Microsoft.EntityFrameworkCore;
using NetCore.Services.Data;
using NetCore.Services.Interfaces;
using NetCore.Services.Svcs;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// ������ ������ ����ϱ� ���ؼ� ���񽺷� ���
//[������]             [���빰]
//IUser �������̽��� UserService Ŭ���� �ν��Ͻ� ����
builder.Services.AddScoped<IUser, UserService>();
// DB��������, Migration ������Ʈ ����
builder.Services.AddDbContext<DbFirstDbContext>(options => options.UseNpgsql("name=ConnectionStrings:DataAccessPostgreSqlProvider")) ;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
