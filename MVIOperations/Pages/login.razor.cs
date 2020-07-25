using System;
using Microsoft.AspNetCore.Components;
using MVIOperations.Models;
using Radzen;
using System.Net;
using System.Net.Http;
using MVIOperations.Services;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace MVIOperations.Pages
{
    public class LoginBase : ComponentBase
    {
        [Inject] NavigationManager nav { get; set; }
        [Inject] HttpClient http { get; set; }

        DataService dataService = new DataService();
        public LoginRequest model = new LoginRequest();
        public bool isBusy = false;

        public LoginBase()
        {

        }

        protected async override void OnInitialized()
        {

            base.OnInitialized();

            /*     LoginModel lm = new LoginModel();
                 lm.Username = "jbaird";
                 lm.Password = "((B((jb((1(";
                 lm.Token = "";

                 string serializedLogin = JsonConvert.SerializeObject(lm);

                 HttpRequestMessage msg = new HttpRequestMessage();
                 msg.Method = new HttpMethod("GET");
                 msg.RequestUri = new Uri("https://localhost:5001/api/district");
                 //msg.Content = new StringContent(serializedLogin);
                 //msg.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                 Console.WriteLine("Getting District");
                 var response = await http.SendAsync(msg);
                 Console.WriteLine(response);
            */
        }

        public void LoginUser()
        {

            isBusy = true;
            Console.WriteLine("Login User clicked.");

            //var type = Type.GetType("District");

            //var dist = dataService.GetData("District", "1");
            //Console.WriteLine(dist);
            //Console.WriteLine(args.Username);
            //books = await Http.GetJsonAsync<Book[]>("/api/BooksFunction");
            nav.NavigateTo("/Main");
            isBusy = false;

        }

        protected void Register(string name)
        {
        }

        protected void ResetPassword(string value, string name)
        {
        }
    }
}
