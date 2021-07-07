using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911061930_Lekhang_bigschool.Startup))]
namespace _1911061930_Lekhang_bigschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
