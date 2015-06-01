using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using TaskService.IServices;
using System.Collections.Generic;



namespace TaskAPI.Controllers
{
    /// <summary>
    /// This Class is responsible for providing the string Manipulator Controller Service
    /// </summary>
    public class StringManipulateController : ApiController
    {

        private readonly IStringMakerService _stringMakerService;

        /// <summary>
        /// Conststructor Injection by passing dependency as a parameter
        /// </summary>
        /// <param name="stringMakerService"></param>
        public StringManipulateController(IStringMakerService stringMakerService)
        {
            this._stringMakerService = stringMakerService;
        }

        /// <summary>
        /// Gets the string of number on the basis of the params provided as an input
        /// </summary>
        /// <param name="minVal"></param>
        /// <param name="maxVal"></param>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(string))]
        [Route("api/StringMaker")]
        public IHttpActionResult GetStringFromNumber(int minVal, int maxVal)
        {
            var resultString = this._stringMakerService.MakeMyString(minVal, maxVal);
            return Ok<string>(resultString);
        }




    }

}
