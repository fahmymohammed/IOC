using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Container
{
    class IOCContainer
    {
        private readonly List<DescriptionModel> descriptionModels;

        internal void Register<T1, T2>(object transient)
        {
            throw new NotImplementedException();
        }

        public IOCContainer(List<DescriptionModel> descriptionModels)
        {
            this.descriptionModels = descriptionModels;
        }

        internal object Resolve<T>()
        {
            throw new NotImplementedException();
        }
    }
}
