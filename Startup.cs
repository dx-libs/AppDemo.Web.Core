using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.PlatformAbstractions;
//using Microsoft.AspNetCore.Hosting;

namespace AppDemo.Web.Core
{
    public class Startup : DxLibs.Framework.Web.Startup
    {
        public override void Configure(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                var msg = "My First CORE App";
                await context.Response.Body.WriteAsync(System.Text.Encoding.ASCII.GetBytes(msg), 0, msg.Length);
            });
        }
    }
}
