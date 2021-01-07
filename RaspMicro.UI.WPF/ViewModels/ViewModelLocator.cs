using Autofac;
using RaspMicro.Services.Infrastructure;

namespace RaspMicro.UI.WPF.ViewModels
{
    public class ViewModelLocator
    {
        private readonly IContainer container;

        public ViewModelLocator()
        {
            //Dependecy injection

            var builder = new ContainerBuilder();
            builder.RegisterModule<ServicesModule>();
            builder.RegisterType<MainViewModel>().SingleInstance();
            container = builder.Build();
            container.Resolve<MainViewModel>();

        }

        public MainViewModel Main => container.Resolve<MainViewModel>();

    }
}
