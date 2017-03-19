using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImpeCustomers.Startup))]
namespace ImpeCustomers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);



            
        }
    }
}
