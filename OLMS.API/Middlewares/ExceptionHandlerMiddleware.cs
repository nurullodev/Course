using OLMS.Service.Exceptions;
using OLMS.Service.Models;

namespace OLMS.Service.Middlerwares;

public class ExceptionHandlerMiddleware
{
    public readonly RequestDelegate request;
    public ExceptionHandlerMiddleware(RequestDelegate request)
    {
        this.request = request;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
           await this.request(context);
        }

        catch (NotFoundException ex)
        {
            context.Response.StatusCode = ex.StatusCode;
            await context.Response.WriteAsJsonAsync(new Response
            {
                Status = context.Response.StatusCode,
                Message = ex.Message
            });
        }

        catch (AlreadExistException ex)
        {
            context.Response.StatusCode = ex.StatusCode;
            await context.Response.WriteAsJsonAsync(new Response
            {
                Status = context.Response.StatusCode,
                Message = ex.Message
            });
        }

        catch (Exception ex)
        {
            context.Response.StatusCode = 500;
            await context.Response.WriteAsJsonAsync(new Response
            {
                Status = context.Response.StatusCode,
                Message = ex.Message
            });
        }
    }
}
