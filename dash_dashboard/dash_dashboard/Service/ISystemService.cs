using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dash_dashboard.Service
{
    public interface ISystemService
    {
        string getProcessInfo();
        string getDiskUsage();
    }
}
