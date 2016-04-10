using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Day1_Homework.Startup))]
namespace MVC_Day1_Homework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
