using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Filter_CustomHandleError.Startup))]
namespace Filter_CustomHandleError
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
