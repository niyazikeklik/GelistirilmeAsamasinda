
using Microsoft.Extensions.Configuration;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BinanceBot
{
    public class UserSettings
    {
        public class UserInfo
        {
            public string ApiKey { get; set; }
            public string ApiSecret { get; set; }
            public string SQLServerName { get; set; }
            public string YerelPara { get; set; }
            public string BorsaPara { get; set; }
            public static UserInfo Get()
            {
                var stringjson = File.ReadAllText(@"C:\Users\niyazi\Desktop\Projeler\BinanceBot\Bussines\Jsons\UserSettings.json");
                return JsonConvert.DeserializeObject<UserInfo>(stringjson);
            }
        }
    }
}
