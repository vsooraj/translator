using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranslatorWeb.Startup))]
namespace TranslatorWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
