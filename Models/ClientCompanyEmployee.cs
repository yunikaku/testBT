using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBT.Models
{
    public  class ClientCompanyEmployee
    {
        public int ClientCompanyEmployeesId { get; set; }
                   

        public int ClientCompanyId { get; set; }

        public string ClientCompanyName { get; set; }

        public string ClientCompanyEmployeesName { get; set; } 

        public string ClientCompanyEmployeesNameKana { get; set; }

        public string ClientCompanyEmployeesEmail { get; set; } 

        public string ClientCompanyEmployeesPhoneNumber { get; set; } 

        public string ClientCompanyEmployeesSection { get; set; } 

        public string ClientCompanyEmployeesPosition { get; set; } 
    }
    public class SearchClientCompanyEmployee
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public string? NameKana { get; set; }

        public int? ClientCompanyId { get; set; }

        public string? Section { get; set; }

        public string? Position { get; set; }
    }
    public class PostClientCompanyEmployee
    {
        public string ClientCompanyEmployeeName { get; set; }

        public string ClientCompanyEmployeeNameKana { get; set; }

        public int ClientCompanyId { get; set; }

        public string ClientCompanyEmployeePhoneNumber { get; set; }

        public string ClientCompanyEmployeeEmail { get; set; }

        public string ClientCompanyEmployeeSection { get; set; }

        public string ClientCompanyEmployeePosition { get; set; }
    }
}
