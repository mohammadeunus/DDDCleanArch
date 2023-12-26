using Autofac;

namespace DDDCleanArch.Web;

public class WebModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        //builder.RegisterType<UnicodeSmsSender>().As<ISmsSender>();
    }

}
