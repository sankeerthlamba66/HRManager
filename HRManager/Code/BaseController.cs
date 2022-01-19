using HRManager.Utilities;

namespace HRManager.Code
{
    public class BaseController : Microsoft.AspNetCore.Mvc.Controller
    {
        protected Microsoft.AspNetCore.Mvc.ObjectResult HandleException(Exception ex)
        {
            if (IsAjaxRequest())
            {
                var errorNumber = ErrorLogger.LogException(ex);
                return StatusCode(500, new Code.ErrorMessage(errorNumber));
            }
            else
            {
                throw ex;
            }
        }

        protected Microsoft.AspNetCore.Mvc.ViewResult ReturnErrorView(Exception ex)
        {
            var errorNumber = ErrorLogger.LogException(ex);
            return View("Error", new Models.ErrorViewModel { RequestId = errorNumber.ToString() });
        }

        protected bool IsAjaxRequest()
        {
            return HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
        }
    }
}
