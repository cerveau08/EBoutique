using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EBoutique.Startup))]
namespace EBoutique
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
