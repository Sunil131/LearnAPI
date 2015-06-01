using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace TaskAPI.Filters
{
    public class TaskExceptionFilter :ExceptionFilterAttribute
    {
        /// <summary>
        /// Sets the Status code to response.
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
           actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError);  // Returning with Status Code             
        }
    }
}