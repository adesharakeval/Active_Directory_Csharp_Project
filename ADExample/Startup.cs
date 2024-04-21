using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ADExample.Startup))]




namespace ADExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
      
            ConfigureAuth(app);
       
        }
    }
}
