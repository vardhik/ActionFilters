using System;
using Microsoft.AspNetCore.Mvc.Filters;
namespace FiltersExtension;
/// <summary>
/// Run after authorization.
/// </summary>
public class ResourcefilterAttribute : Attribute, IResourceFilter
{
    /// <summary>
    /// OnResourceExecuting runs code before the rest of the filter pipeline. For example, OnResourceExecuting runs code before model binding.
    /// </summary>
    /// <param name="context"></param>
    public void OnResourceExecuting(ResourceExecutingContext context) {
        var res = context;
        //the following code prevents the rest of the pipeline from executing:
        //context.Result = new ContentResult
        //{
        //    Content = nameof(ShortCircuitingResourceFilterAttribute)
        //};
    }
    /// <summary>
    /// OnResourceExecuted runs code after the rest of the pipeline has completed
    /// </summary>
    /// <param name="context"></param>
    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        var res = context.Result;
    }
}
public class SampleActionFilterAttribute : Attribute, IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        // Do something before the action executes.
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        // Do something after the action executes.
    }
}