using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Team2LibraryCatalog.Startup))]
namespace Team2LibraryCatalog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
