using Moq;
using MVCTestProject.Domain.Abstract;
using MVCTestProject.Domain.Entities;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestProject.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();  
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            Mock<IGamesRepository> mock = new Mock<IGamesRepository>();
            mock.Setup(m => m.Games).Returns(new List<Game>
            {
                new Game {Name = "Vier Gewinnt" },
                new Game {Name = "Mensch Äger dich nicht" },
                new Game {Name = "My Town Story" }
            });

            kernel.Bind<IGamesRepository>().ToConstant(mock.Object);
        }
    }
}