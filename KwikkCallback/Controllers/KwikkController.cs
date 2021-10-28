using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class KwikkController : ApiController
    {
        [HttpPost]
        public string Callback(CallbackDto callbackDto)
        {
            // ToDo: interesting things with data contained in [callbackDto]

            return "I have recieved some data";
        }
    }
}
