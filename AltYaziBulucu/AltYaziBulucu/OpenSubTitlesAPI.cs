using AltYaziBulucu.Models;

using Microsoft.VisualBasic.Logging;

using Newtonsoft.Json;

using RestSharp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AltYaziBulucu
{
    public class OpenSubTitlesAPI
    {
        private string ApiKey;
        private string ApiBaseUrl = "https://api.opensubtitles.com/api/v1/";
        public OpenSubTitlesAPI(string ApiKey = "C4b28tA0JTZgicYXB7DCKwc9xLgelbTL")
        {
            this.ApiKey = ApiKey;
        }
        public OpenSubTitlesAPI(string username, string password)
        {
            var result = Login(username, password);
            if (result?.status == 200)
                ApiKey = result.token;
            else throw new Exception("Can not login");
        }
        private LoginResult? Login(string username, string password)
        {
            var client = new RestClient(ApiBaseUrl + "login");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Api-Key", ApiKey);
            request.AddParameter("undefined", "{\n  \"username\": \"" + username + "\",\n  \"password\": \"" + password + "\"\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            LoginResult? myDeserializedClass = JsonConvert.DeserializeObject<LoginResult>(response.Content);
            return myDeserializedClass;
        }

        public Subtitles? GetSubtitles(string movieName, int episodeNumber, int seasonNumber, string language)
        {
            var client = new RestClient(ApiBaseUrl + $"subtitles?query={movieName}&languages={language}&season_number={seasonNumber}&episode_number={episodeNumber}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Api-Key", ApiKey);
            IRestResponse response = client.Execute(request);
            Subtitles? myDeserializedClass = JsonConvert.DeserializeObject<Subtitles>(response.Content);
            return myDeserializedClass;
        }
        public DowloandResult? DowloandSubtitle(int fileID)
        {
            var client = new RestClient(ApiBaseUrl + "download");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Api-Key", ApiKey);
            request.AddParameter("undefined", "{\n  \"file_id\": " + fileID + "\n}", ParameterType.RequestBody);
            string response = client.Execute(request).Content;
            DowloandResult? myDeserializedClass = JsonConvert.DeserializeObject<DowloandResult>(response);
            return myDeserializedClass;
        }
    }
}
