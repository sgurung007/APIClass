using APIClass.DTO;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace APIClass
{
    public class GetUsers
    {
        public string FirstName { get; set; }

        public ListOfUsersDTO GetUsersList()
        {
            var restClient = new RestClient("https://reqres.in");
            var restRequest = new RestRequest("/api/users?page=2", Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var users = JsonConvert.DeserializeObject<ListOfUsersDTO>(content);

            return users;

        }
    }

    
}
