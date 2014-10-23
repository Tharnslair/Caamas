using Abp.Web.Mvc.Views;

namespace TharnTask.Web.Views
{
    public abstract class TharnTaskWebViewPageBase : TharnTaskWebViewPageBase<dynamic>
    {

    }

    public abstract class TharnTaskWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TharnTaskWebViewPageBase()
        {
            LocalizationSourceName = "TharnTask";
        }
    }
}