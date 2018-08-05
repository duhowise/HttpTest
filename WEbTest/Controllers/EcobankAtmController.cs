using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using GoAmlMiddleWare.Models;

namespace WEbTest.Controllers
{
  [RoutePrefix("api/ecobankatm")]  public class EcobankAtmController : ApiController
    {
		[HttpGet][Route("getmoney")]public async Task<IHttpActionResult> GetMoney()
		{
			var client = new HttpClient();
			var requestur = "http://someapi/api/countries/WISE";
			var request = await client.GetAsync(requestur);
			var result = new Country();
			if (request.IsSuccessStatusCode)
			{
				result = request.Content.ReadAsAsync<Country>().Result;
				return Ok(result);
			}

			return NotFound();
		}
    }
}
