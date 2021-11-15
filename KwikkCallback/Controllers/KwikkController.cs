using System;
using System.IO;
using System.Web.Http;

using Newtonsoft.Json;

namespace WebApplication2.Controllers
{
    public class KwikkController : ApiController
    {
        [HttpPost]
        public string Callback(CallbackDto callbackDto)
        {
            var fileLocation = @"c:/kwikk/callback.json";

            Directory.CreateDirectory("c:/kwikk/");
            var fileStream = File.Create(fileLocation);

            using (var writer = new StreamWriter(fileStream))
            {
                writer.Write(JsonConvert.SerializeObject(callbackDto));
            }

            return $"the callbackDto has been written to file, path: {fileLocation}";
        }

        [HttpGet]
        public string Test()
        {
            return "This is working fine";

        }
    }
}
