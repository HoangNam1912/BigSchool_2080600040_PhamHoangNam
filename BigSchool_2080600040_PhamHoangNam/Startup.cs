using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool_2080600040_PhamHoangNam.Startup))]
namespace BigSchool_2080600040_PhamHoangNam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
