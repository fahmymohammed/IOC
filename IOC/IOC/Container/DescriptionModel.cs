using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Container
{
    public class DescriptionModel
    {
        public DescriptionModel(Type registerType, Type registerImplementationType, LifeCycleFlag lifeCycleFlag)
        {
            RegisterType = registerType;
            RegisterImplementationType = registerImplementationType;
            LifeCycleFlag = lifeCycleFlag;
        }

        //Registered the Service
        public Type RegisterType { get; set; }

        //Registered Service Implementation
        public Type RegisterImplementationType { get; set; }

        //Registered Service Implementation only set if its Singleton
        public Object Implementation { get; set; }



        //Flag to Determine the LifeCycle
        public LifeCycleFlag LifeCycleFlag { get; set; }
    }
}
