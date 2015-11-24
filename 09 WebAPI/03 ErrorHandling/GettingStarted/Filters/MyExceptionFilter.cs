using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace GettingStarted.Filters
{
    public class MyExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            var err = new ErrorResponse()
            {
                ErrorCode = 1,
                InternalMessage = context.Exception.Message,
                Message = "גןוגיןוגי",
            };

            context.Response = context.Request.CreateResponse(HttpStatusCode.InternalServerError, err);

            //base.OnException(actionExecutedContext);
        }
    }

    public class ErrorResponse
    {
        public int ErrorCode { get; set; }
        public string InternalMessage { get; set; }
        public string Message { get; set; }
    }
}