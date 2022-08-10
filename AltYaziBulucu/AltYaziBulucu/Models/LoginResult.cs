using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltYaziBulucu.Models
{

    public class User
    {
        public int allowed_downloads { get; set; }
        public string level { get; set; }
        public int user_id { get; set; }
        public bool ext_installed { get; set; }
        public bool vip { get; set; }
    }

    public class LoginResult
    {
        public User user { get; set; }
        public string token { get; set; }
        public int status { get; set; }
    }

}
