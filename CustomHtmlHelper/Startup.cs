using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomHtmlHelper.Startup))]
namespace CustomHtmlHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
