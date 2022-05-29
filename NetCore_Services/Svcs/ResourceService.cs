using NetCore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Services.Svcs
{
    public class ResourceService : IResource
    {
        
        public List<string> GetResourceList(string resourcePath)
        {
            List<string> fileList = new List<string>();

            string[] arrFileList = Directory.GetFiles(resourcePath, "*", SearchOption.AllDirectories);

            foreach (string file in arrFileList)
            {
                Console.WriteLine(file);
            }

            fileList = arrFileList.ToList();
            return fileList;
        }
    }
}
