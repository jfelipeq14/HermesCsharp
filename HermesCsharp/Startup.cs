using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HermesCsharp.Startup))]
namespace HermesCsharp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
