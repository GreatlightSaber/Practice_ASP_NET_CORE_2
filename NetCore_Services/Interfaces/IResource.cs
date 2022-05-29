using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Services.Interfaces
{
    public interface IResource
    {
        List<string> GetResourceList(string resourcePath);
    }
}
