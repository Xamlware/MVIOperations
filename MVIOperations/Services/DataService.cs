using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace MVIOperations.Services
{
	public class DataService
	{

		private NavigationManager nav;
		[Inject] HttpClient http { get; set; }


		public DataService()
		{
		}

		public string GetData(string route, string index)
		{
			Console.WriteLine("base = " + http.BaseAddress.ToString());
			return "";
		}


	}
}
