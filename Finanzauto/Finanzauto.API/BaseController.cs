using Finanzauto.API.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;

namespace Finanzauto.API
{
	public class BaseController : Controller
	{
		protected int UserIdentity
		{
			get
			{
				if (User.Identity.IsAuthenticated)
				{
					var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
					if (int.TryParse(userIdClaim, out int userId))
					{
						return userId;
					}
				}
				throw new ApplicationException("The user ID is not available.");
			}
		}

		protected async Task<ResponseWithElements> ExecuteServiceAsync(Func<Task> serviceMethodAsync)
		{
			var response = new ResponseWithElements();

			try
			{
				await serviceMethodAsync();
				response.Success = true;
				response.StatusCode = (int)HttpStatusCode.OK;
				response.Data = "successful";
			}
			catch (Exception ex)
			{
				response.Success = false;
				response.StatusCode = (int)HttpStatusCode.BadRequest;
				response.Data = ex.Message;
			}

			return response;
		}

		protected async Task<ResponseWithElements> ExecuteServiceAsync<T>(Func<Task<T>> serviceMethodAsync)
		{
			var response = new ResponseWithElements();

			try
			{
				response.Success = true;
				response.StatusCode = (int)HttpStatusCode.OK;
				response.Data = await serviceMethodAsync();
			}
			catch (Exception ex)
			{
				response.Success = false;
				response.StatusCode = (int)HttpStatusCode.BadRequest;
				response.Data = ex.Message;
			}

			return response;
		}
	}
}
