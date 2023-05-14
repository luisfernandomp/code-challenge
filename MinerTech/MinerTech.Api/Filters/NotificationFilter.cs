using Microsoft.AspNetCore.Mvc.Filters;
using MinerTech.Domain.Entities;
using MinerTech.Domain.Response;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace MinerTech.Api.Filters
{
    public class NotificationFilter : IAsyncResultFilter
    {
        private readonly NotificationContext _notificationContext;
        public NotificationFilter(NotificationContext notificationContext)
        {
            _notificationContext = notificationContext;
        }

        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            if (_notificationContext.HasNotifications)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.HttpContext.Response.ContentType = "application/json";

                var response = new ResponseApi(false, "Não foi possível realizar a operação!", _notificationContext.Notifications);

                var bytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(response));

                await context.HttpContext.Response.Body.WriteAsync(bytes, 0, bytes.Length);

                return;
            }

            await next();
        }
    }
}
