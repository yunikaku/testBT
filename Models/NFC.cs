using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBT.Models
{
    public class NFC
    {
        public int? NfcId { get; set; }

        public string? NfcUid { get; set; }

        public string? UserId { get; set; } 

        public string? UserName { get; set; }

        public int? ClientCompanyEmployeesId { get; set; }

        public string? ClientCompanyEmployeesName { get; set; }

        public DateTime? AlloottedTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        public string? NfcPayload { get; set; } 

        
    }
    public class SearchNFC
    {
        public string? NfcUid { get; set; }

        //public string? UserId { get; set; }

        public string? UserName { get; set;}

        //public int? ClientCompanyEmployeesId { get; set; }

        public string? ClientCompanyEmployeesName { get; set; }
    }

    public class PostNFC
    {
        public string NfcUid { get; set; }
    }
}
