using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidify.Startup))]
namespace Vidify
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
