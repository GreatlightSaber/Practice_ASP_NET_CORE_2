using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Core.Interfaces
{
    public interface IJsonManagement
    {
        public JObject getJsonData(string fileName);

        public string[] getJsonDataValues(string fileName, string key);

        public string[] getJsonDataKeys(string fileName, string key);
    }
}
