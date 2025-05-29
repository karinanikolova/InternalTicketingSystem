using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ITS.Api.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class BaseApiController : ControllerBase
	{

	}
}