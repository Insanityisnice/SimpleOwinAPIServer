using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

[assembly: OwinStartup(typeof(SimpleOwinAPI.Startup))]

namespace SimpleOwinAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(JsonLookupHandler);
        }

        public Task JsonLookupHandler(IOwinContext context)
        {
            //TODO: Load JSON File base on path and return file contents.

            return context.Response.WriteAsync(context.Request.Path.ToString());
        }
    }
}