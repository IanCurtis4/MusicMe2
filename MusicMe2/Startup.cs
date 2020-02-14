using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicMe2.Startup))]
namespace MusicMe2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
