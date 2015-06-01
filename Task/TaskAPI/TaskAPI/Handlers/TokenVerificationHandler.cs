using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAPI.Handlers
{
    public class TokenVerificationHandler : DelegatingHandler
    {
        /// <summary>
        /// Custom Header Method for Token Verification
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
                                                    CancellationToken cancellationToken)
        {

            if (request.Method != HttpMethod.Options)// This 'If' is used to validate that we are doing our 
                                                       //check in the final request from browser
            {
                IEnumerable<string> headerValue;

                bool isheaderPresent = request.Headers.TryGetValues("x-caller", out headerValue); //Try and fetch the token here

                if (!isheaderPresent || headerValue == null || !headerValue.Contains("Sunil")) //checking for the header value.

                    return new HttpResponseMessage(HttpStatusCode.BadRequest) //if token not found or not valid, Pass Bad Request
                    {
                        ReasonPhrase = "Token not present",
                        Content = new StringContent("Token not present")
                    };

            }
            return await base.SendAsync(request, cancellationToken);
        }
    }
}