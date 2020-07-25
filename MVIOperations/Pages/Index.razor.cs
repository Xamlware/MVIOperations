using System;
using Microsoft.AspNetCore.Components;
using MVIOperations.Models;
using Radzen;
using System.Net;
using System.Net.Http;
using MVIOperations.Services;



namespace MVIOperations.Pages
{
	public class IndexBase: ComponentBase
	{
        [Inject] NavigationManager nav { get; set; }
        [Inject] HttpClient http { get; set; }
        [Inject] Blazored.LocalStorage.ISyncLocalStorageService localStorage { get; set; }

        public IndexBase()
		{
		}
	
        protected bool isUserAuthenticated;
        public void ButtonClick()
        {
            Console.WriteLine("Button Clicked");
        }

        public void LoginButtonClick()
        {
            //var dist = new DataService().GetData("District", "1");
            //Console.WriteLine(dist);

            Console.WriteLine("Login Button Clicked");
            Console.WriteLine("Navigating...");
            nav.NavigateTo("/auth/login");
            Console.WriteLine("Navigated.");
        }

        protected override void OnInitialized()
        {
            Console.WriteLine("base = " + http.BaseAddress.ToString());
            //localStorage.SetItem("token", "John Smith");
            localStorage.RemoveItem("token");

            isUserAuthenticated = (localStorage.GetItem<string>("token")) != null;
            Console.WriteLine(isUserAuthenticated);

            if (isUserAuthenticated)
            {

                    nav.NavigateTo("/main");

                //localStorage.SetItem("name", "John Smith");
                //var name = localStorage.GetItem<string>("name");
            }
        }

        protected void NavigateToPage(string route)
        {
            nav.NavigateTo(route);
        }


    }
}
