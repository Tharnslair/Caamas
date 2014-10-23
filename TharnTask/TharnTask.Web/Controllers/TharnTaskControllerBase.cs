using Abp.Web.Mvc.Controllers;

namespace TharnTask.Web.Controllers
{
    public abstract class TharnTaskControllerBase : AbpController
    {
        protected TharnTaskControllerBase()
        {
            LocalizationSourceName = "TharnTask";
        }
    }
}