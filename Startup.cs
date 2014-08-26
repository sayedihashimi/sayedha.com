using Microsoft.AspNet.Builder;
using Microsoft.AspNet.StaticFiles;
using Microsoft.Framework.DependencyInjection;

namespace KWebStartup
{
    public class Startup
    {
        public void Configure(IBuilder app)
        {
            app.UseStaticFiles();
            app.UseErrorPage();
            // app.UseWelcomePage();
        }
    }
}
