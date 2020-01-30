using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace ApiAuthorization.Models
{
    class TopStory
    {
        public string Section { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string Url { get; set; }
        public string Byline { get; set; }
        public static List<TopStory> GetArticles(string apiKey)
        {
        var apiCallTask = ApiHelper.ApiCall(apiKey);
        var result = apiCallTask.Result;

        JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
        List<TopStory> articleList = JsonConvert.DeserializeObject<List<TopStory>>(jsonResponse["results"].ToString());

        return articleList;
        }
    }
}