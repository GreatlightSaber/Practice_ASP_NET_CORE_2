
using Microsoft.EntityFrameworkCore;
using NetCore.Core.Interfaces;
using NetCore.Core.Svcs;
using NetCore.Services.Data;
using NetCore.Services.Interfaces;
using NetCore.Services.Svcs;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// 의존성 주입을 사용하기 위해서 서비스로 등록
//[껍데기]             [내용물]
//IUser 인터페이스에 UserService 클래스 인스턴스 주입
builder.Services.AddScoped<IUser, UserService>();
builder.Services.AddScoped<IResource, ResourceService>();
builder.Services.AddScoped<IJsonManagement, JsonManagementService>();

// DB접속정보, Migration 프로젝트 지정
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
