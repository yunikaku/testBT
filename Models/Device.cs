using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBT.Models
{
    public class Device
    {
        public int DeviceId { get; set; }

        public string DeviceName { get; set; }

        public string DeviceLocation { get; set; } 

        public DateTime CreationTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public string DeviceUpdateUserID { get; set; }

        public string DeviceUpdateUserName { get; set; }
    }
    public class SearchDevice 
    {
        public int? DeviceId { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceLocation { get; set; }

    }

    public class PostDevice
    {
        public string DeviceName { get; set; } = null!;

        public string DeviceLocation { get; set; } = null!;

        public string DeviceUpdateUserID { get; set; } = null!;
    }
}
