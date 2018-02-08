using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LP.LikeTeacher.UI.Site.Startup))]
namespace LP.LikeTeacher.UI.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
