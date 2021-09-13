using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Container
{
    public enum LifeCycleFlag
    {
        //Flag for Multiple Instance Across the Application
        Transient,
        //Flag for Single Instance Across the Application
        Singleton
    }
}
