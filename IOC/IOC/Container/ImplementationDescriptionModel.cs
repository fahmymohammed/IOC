using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Container
{
    public class ImplementationDescriptionModel
    {
        public ImplementationDescriptionModel(Type registerType, Type registerImplementationType, LifeCycleFlag lifeCycleFlag)
        {
            RegisterType = registerType;
            RegisterImplementationType = registerImplementationType;
            LifeCycleFlag = lifeCycleFlag;
        }

        //Registered the Service
        public Type RegisterType { get; }

        //Registered Service Implementation
        public Type RegisterImplementationType { get; }

        //Registered Service Implementation only set if its Singleton
        public Object Implementation { get; internal set; }

        //Flag to Determine the LifeCycle
        public LifeCycleFlag LifeCycleFlag { get;}
    }
}
