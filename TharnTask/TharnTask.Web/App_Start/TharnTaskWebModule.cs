using System;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using Abp.Dependency;
using Abp.Localization;
using Abp.Modules;
using Abp.Startup;
using TharnTask.Web.Localization.TharnTask;

namespace TharnTask.Web
{
    public class TharnTaskWebModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       typeof(TharnTaskDataModule),
                       typeof(TharnTaskApplicationModule),
                       typeof(TharnTaskWebApiModule)
                   };
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            LocalizationHelper.RegisterSource<TharnTaskLocalizationSource>();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
