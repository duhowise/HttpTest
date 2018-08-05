using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GoAmlMiddleWare.Models;

namespace HttpTest
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new HttpClient();
			var requestur= "http://localhost:1065/api/ecobankatm/getmoney";
			var request =  client.GetAsync(requestur).Result;
			var result =new Country();
			if (request.IsSuccessStatusCode)
			{
			result=	request.Content.ReadAsAsync<Country>().Result;

			
			}
		}


	}

	
}
