                                        using System;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System.Collections.Generic;

using System.IO;
using Microsoft.AspNetCore.Hosting;
namespace ApiAuthorization
{
  class Program
  {
    static void Main(string[] args)
    {
    var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();
        host.Run();
  }
  }
}
