using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class KwikkController : ApiController
    {
        [HttpPost]
        public string Callback(CallbackDto callbackDto)
        {
            return callbackDto.art_spec;
        }
    }
}
