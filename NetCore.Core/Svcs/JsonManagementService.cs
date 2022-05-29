using NetCore.Core.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Core.Svcs
{
    public class JsonManagementService : IJsonManagement
    {
        public JsonManagementService()
        {

        }

        public JObject getJsonData(string fileName)
        {
            JObject resourceProperties = new JObject();

            try
            {
                resourceProperties = JObject.Parse(System.IO.File.ReadAllText(fileName));
            }
            catch (Exception e)
            {
                // [TODO] Custom Exception 구현 예정
                if(e.Source != null)
                {
                    Console.WriteLine("Exception Source: {0}", e.Source);
                }
                throw;
            }
            return resourceProperties;
        }

        public string[] getJsonDataValues(string fileName, string key)
        {
            // [TODO] 구현 에정 (2022.05.30)
            return null;
        }

        public string[] getJsonDataKeys(string fileName, string key)
        {
            // [TODO] 구현 에정 (2022.05.30)
            return null;
        }
    }
}
