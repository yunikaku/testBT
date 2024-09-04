using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBT.Models
{
    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string UserNameKana { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public IList<string> Role { get; set; }
    }

    public class  UserInfo
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public IList<string> Role { get; set; }
        
        public DateTime Expiration { get; set; }
    }

    public class PostUser
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserNameKana { get; set; }
        [Required]
        public string UserGender { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Slak_ID { get; set; }
        public string Slak_URL { get; set; }
        [Required]
        public string Role { get; set; }

        public string UserAddress { get; set; }
        [Required]
        public string UserUpdataUserId { get; set; }

        public string UserIndustry { get; set; }


    }
}
