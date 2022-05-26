using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore.Data.Classes;
using NetCore.Data.DataModels;
using NetCore.Services.Data;

namespace Practice_WEB_APP_MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRUDController : ControllerBase
    {
        private DbFirstDbContext dbFirstDbContext;

        public CRUDController(DbFirstDbContext dbFirstDbContext)
        {
            this.dbFirstDbContext = dbFirstDbContext;
        }

        [HttpGet]
        [Route("test")]
        public string test()
        {
            return "hello World";
        }

        [HttpGet]
        [Route("testInsert")]
        public string testInsert()
        {
            Practice1_User user = new Practice1_User() { UserId = "test1", UserName="테스트사용자1", Password = "test1", UserEmail="test1@google.com" };
            dbFirstDbContext.users.Add(user);
            dbFirstDbContext.SaveChanges();

            return "Success";
        }
    }
}
