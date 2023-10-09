using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace FiltersExtension;

public class CustomeExceptionfilters : IExceptionFilter
{
    //private readonly IHostEnvironment _hostEnvironment;
    public CustomeExceptionfilters() { }
    public void OnException(ExceptionContext context) {
        context.Result = new ContentResult
        {
            Content = context.Exception.ToString()
        };
    
    }
}
