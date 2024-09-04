using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBT.Models
{
    public class EnteringAndLeaving
    {
        public int EnteringAndLeavingId { get; set; }

        public int DeviceId { get; set; }

        public string DeviceName { get; set; }

        public string NfcUid { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public int ClientCompanyEmployeesId { get; set; }

        public string ClientCompanyEmployeesName { get; set; }

        public string StatusName { get; set; }

        public int CompleteFlg { get; set; }

        public DateTime EnteringAndLeavingAdmissionTime { get; set; }

        public DateTime EnteringAndLeavingExitTime { get; set; }
    }

    public class SearchEnteringAndLeaving
    {
        public int? EnteringAndLeavingId { get; set; }

        public int? DeviceId { get; set; }

        public string? NfcUid { get; set; }

        public string? UserId { get; set; }

        public string? UserName { get; set; }

        public int? ClientCompanyEmployeesId { get; set; }

        public string? ClientCompanyEmployeesName { get; set; }

        public int? StatusId { get; set; }

        public int? CompleteFlg { get; set; }


        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }
    }
}
