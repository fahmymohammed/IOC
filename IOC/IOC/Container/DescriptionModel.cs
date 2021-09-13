using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Container
{
    public class DescriptionModel
    {
        //Registered the Service
        public Type RegisterType { get; set; }

        //Registered Service Implementation
        public Type RegisterImplementationType { get; set; }
        
        //Flag to Determine the LifeCycle
        public LifeCycleFlag LifeCycleFlag { get; set; }
    }
}
