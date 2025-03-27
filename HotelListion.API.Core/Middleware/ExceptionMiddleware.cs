using HotelListion.API.Core.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net;

namespace HotelListion.API.Core.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Something Went Wrong while processing {context.Request.Path}");
                await HandleExceptionAsync(context, e);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception e)
        {
            context.Response.ContentType = "application/json";
            var statusCode = HttpStatusCode.InternalServerError;
            var errorDetails = new ErrorDetails
            {
                ErrorType = "Failure",
                ErrorMessage = e.Message

            };

            switch (e)
            {
                case NotFoundException notFoundException:
                    statusCode = HttpStatusCode.NotFound;
                    errorDetails.ErrorType = "Not Found";
                    break;
                default:
                    break;
            }

            string response = JsonConvert.SerializeObject(errorDetails);
            context.Response.StatusCode = (int)statusCode;

            return context.Response.WriteAsync(response);
        }

        public class ErrorDetails
        {
            public string ErrorType { get; set; }
            public string ErrorMessage { get; set; }
        }
    }
}