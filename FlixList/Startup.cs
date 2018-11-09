using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlixList.Startup))]
namespace FlixList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
