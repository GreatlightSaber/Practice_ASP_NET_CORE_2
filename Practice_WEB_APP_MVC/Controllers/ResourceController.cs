using Microsoft.AspNetCore.Mvc;
using NetCore.Core.Interfaces;
using NetCore.Services.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Practice_WEB_APP_MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private IResource _resource;
        private IJsonManagement _jsonManagement;

        public ResourceController(IResource resource, IJsonManagement jsonManagement)
        {
            _resource = resource;
            _jsonManagement = jsonManagement;

        }

        [HttpPost]
        [Route("fileList")]
        public async Task<IActionResult> resource()
        {
            JObject resourceProperties = new JObject();
            List<string> fileList = new List<string>();
            var resourcePath = new object();

            try
            {
                resourceProperties = _jsonManagement.getJsonData("Json/Resource/Resource.json");
                resourcePath = resourceProperties["Resource"]["local"]["resourcePath"];
            }
            catch (Exception ex)
            {
                // [TODO] Custom Exception 구현 예정
                if (ex.Source != null)
                {
                    Console.WriteLine("Exception Source: {0}", ex.Source);
                }
                return StatusCode(500);
            }

            fileList = _resource.GetResourceList(resourcePath.ToString());


            return Ok(new { message = "ok" , data = fileList});
        }

    }
}
