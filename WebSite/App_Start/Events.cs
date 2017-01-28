using System.Web.Optimization;
using Umbraco.Core;

namespace WebSite.App_Start
{
    public class Events : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}