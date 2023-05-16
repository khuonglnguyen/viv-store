using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup("MyFriendlyNameForProject1", typeof(SourceCode.Startup))]

namespace SourceCode
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            //ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
