using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TraningForProjectStructureMVCAutorization.Startup))]
namespace TraningForProjectStructureMVCAutorization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
