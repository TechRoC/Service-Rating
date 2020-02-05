using App12.Model1;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace App12.Service
{
    public class WebApiService
    {
        private string abc;

        public async Task<bool> RegistrationAsync(string email, string username, string password, string confirmPassword)
        {
            
            try
            {
                var client = new HttpClient();
                var model = new RegisterBindingModel
                {
                    Email = email,
                    Username = username,
                    Password = password,
                    ConfirmPassword = confirmPassword
                };
                var json = JsonConvert.SerializeObject(model);
                HttpContent content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("Application/json");
                var response = await client.PostAsync("http://192.168.1.100:29240/api/Account/Register", content);
                return response.IsSuccessStatusCode;
            }
            catch(Exception ex)
            {

            }
            return true;
        }
        

        public async Task<string> LoginAsync(string username, string password)
        {
            try
            {
                var keyvalues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", username),
                 new KeyValuePair<string, string>("password", password),
                  new KeyValuePair<string, string>("grant_type", "password"),

            };

                var request = new HttpRequestMessage(HttpMethod.Post, "http://192.168.1.100:29240/Token");
                request.Content = new FormUrlEncodedContent(keyvalues);
                var client = new HttpClient();
                var response = await client.SendAsync(request);
                var jwt = await response.Content.ReadAsStringAsync();
                JObject jwtDynamic = JsonConvert.DeserializeObject<dynamic>(jwt);
                var accesstoken = jwtDynamic.Value<string>("access_token");
                Debug.WriteLine(jwt);
                return accesstoken;
            }
            catch(Exception ex)
            {

            }
            return  abc  ;
        }
        public async Task<bool> ForgotPasswordAsync(string email)
        {
            var client = new HttpClient();
            var model = new ForgotPasswordViewModel
            {
                Email = email,
               
            };
            var json = JsonConvert.SerializeObject(model);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("Application/json");
            var response = await client.PostAsync("http://192.168.1.100:29240/api/Account/ForgotPassword", content);
            return response.IsSuccessStatusCode;
        }
       
       

    }
    public class RestClient<T>
    {
        public async Task<List<T>> GetAsync()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://192.168.1.100:29240/api/ClassRoom");
                var taskModels = JsonConvert.DeserializeObject<List<T>>(json);
            return taskModels;
        }
        public async Task<List<T>> GetAsync1()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://192.168.137.145:29240/api/ClassRoom");
            var taskModels = JsonConvert.DeserializeObject<List<T>>(json);
            return taskModels;
        }
    }
}
