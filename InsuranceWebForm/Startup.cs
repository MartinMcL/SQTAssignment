using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InsuranceWebForm.Startup))]
namespace InsuranceWebForm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
