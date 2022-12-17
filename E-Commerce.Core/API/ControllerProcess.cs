using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Core.API
{
    public class ControllerProcess : ControllerBase
    {
        public IActionResult ProccessResult<T>(OperationResult<T> res)
        {
            if (res is null)
                return this.StatusCode(500, new { Message = "Internal Server Error While Processing The Result" });

            if (res.IsSucceded)
                return this.Ok(res.Data);
            else
                return this.StatusCode((int)res.HttpCode, new { ErrorMessage = res.Error.ErrorMessage, ErrorNumber = res.Error.ErrorNumber });
        }

    }
}
