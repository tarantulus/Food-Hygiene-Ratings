using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Food_Hygiene_Ratings.Startup))]
namespace Food_Hygiene_Ratings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}


