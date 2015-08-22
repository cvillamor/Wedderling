using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Wedderling.Startup))]

namespace Wedderling
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
