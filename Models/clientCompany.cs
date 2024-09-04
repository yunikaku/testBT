using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBT.Models
{
    public  class ClientCompany
    {

        public int ClientCompanyId { get; set; }

        public string ClientCompanyName { get; set; } 

        public string ClientCompanyEmail { get; set; }

        public string ClientCompanyPhoneNumber { get; set; } 

        public string ClientCompanyAddress { get; set; } 
    }

    public class SearchClientCompany
    {

        public int? Id { get; set; }

        public string? Name { get; set; }
    }

    public class PostClientCompany
    {
        public string ClientCompanyName { get; set; }

        public string ClientCompanyEmail { get; set; }

        public string ClientCompanyPhoneNumber { get; set; }

        public string ClientCompanyAddress { get; set; }
    }

    public class PutClientCompany
    {
        
            public int Id { get; set; }

            public string? Name { get; set; }

            public string? Email { get; set; }

            public string? PhoneNumber { get; set; }

            public string? Address { get; set; }
        
    }
}
