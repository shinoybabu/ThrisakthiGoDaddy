using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(thrisakthi.com.Startup))]
namespace thrisakthi.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
