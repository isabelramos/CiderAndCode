using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CiderAndCode.Web.DataModels;
using CiderAndCode.Web.ViewModels;

namespace CiderAndCode.Web.Controllers
{
    [RoutePrefix("api/users")]
    public class UserController : ApiController
    {
        [Route("list"), HttpGet]
        public HttpResponseMessage GetUserNameList()
        {
            var db = new AppDbContext();

            var users = db.Users.Select(user => new UserNameResult {Id = user.Id, Name = user.Name});

            return Request.CreateResponse(HttpStatusCode.OK, users);
        }
    }
}
