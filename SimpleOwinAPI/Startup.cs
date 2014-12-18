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
            var pathStrings = context.Request.Path.Value.Split('/').Where(s => !String.IsNullOrWhiteSpace(s));

            var result = pathStrings.Any() ? JsonFile.Load(pathStrings) : "Error";
            return context.Response.WriteAsync(result);
        }
    }
}