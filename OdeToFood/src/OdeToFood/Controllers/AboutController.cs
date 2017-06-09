

using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
	[Route("about")]
	public class AboutController
    {
		[Route("")]
		public string Phone()
		{
			return "2145367436";
		}
    }
}
