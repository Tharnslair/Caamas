using System.Web;
using Abp.Localization.Sources.Xml;

namespace TharnTask.Web.Localization.TharnTask
{
    public class TharnTaskLocalizationSource : XmlLocalizationSource
    {
        public TharnTaskLocalizationSource()
            : base("TharnTask", HttpContext.Current.Server.MapPath("/Localization/TharnTask"))
        {
        }
    }
}