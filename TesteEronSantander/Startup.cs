using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteEronSantander.Startup))]
namespace TesteEronSantander
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
