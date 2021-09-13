using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Container
{
    class IOCContainer
    {
        private readonly List<ImplementationDescriptionModel> _descriptionModels;
        public IOCContainer()
        {
            this._descriptionModels = new List<ImplementationDescriptionModel>();
        }

        public void Register<TService, TImplementation>(LifeCycleFlag lifeCycleFlag = LifeCycleFlag.Transient) where TImplementation : TService
        {
            _descriptionModels.Add(new ImplementationDescriptionModel(typeof(TService), typeof(TImplementation), lifeCycleFlag));
        }


        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        public object Resolve(Type type)
        {
            var descModel = _descriptionModels
                .Where(x=>x.RegisterType == type)
                .SingleOrDefault();

            if (descModel == null)
                throw new Exception($"Service {type.Name} NOT yet registered");

            if (descModel.Implementation != null)
                return descModel.Implementation;

            var retrieved = descModel.RegisterImplementationType ?? descModel.RegisterType;

            if (retrieved.IsAbstract || retrieved.IsInterface)
            {
                throw new Exception("Can't Create Abstract or Interfaces");
            }

            var retrievedConstructorInfo = retrieved.GetConstructors().First();
            var retrievedConstructorParameters = retrievedConstructorInfo.GetParameters()
                .Select(x => Resolve(x.ParameterType)).ToArray();
            var implementation = Activator.CreateInstance(retrieved, retrievedConstructorParameters);

            if (descModel.LifeCycleFlag == LifeCycleFlag.Singleton)
                descModel.Implementation = implementation;

            return implementation;


            
        }
    }
}
