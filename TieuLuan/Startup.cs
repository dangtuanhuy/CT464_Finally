using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TieuLuan.Startup))]
namespace TieuLuan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
