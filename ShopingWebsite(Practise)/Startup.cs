using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopingWebsite_Practise_.Startup))]
namespace ShopingWebsite_Practise_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
