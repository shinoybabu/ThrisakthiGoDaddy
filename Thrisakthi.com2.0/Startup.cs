using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Thrisakthi.com2._0.Startup))]
namespace Thrisakthi.com2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
