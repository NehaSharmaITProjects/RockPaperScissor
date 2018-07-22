using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RockPaperScissor.Startup))]
namespace RockPaperScissor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
