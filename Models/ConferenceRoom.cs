using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBT.Models
{
    public class ConferenceRoom
    {
        public int ConferenceRoomId { get; set; }

        public string ConferenceRoomName { get; set; } 

        public int ConferenceRoomCapacity { get; set; }

        public DateTime UpdateTime { get; set; }

        public string UpdateUser { get; set; } 
    }
    public class SearchConferenceRoom
    {
        public int? ConferenceRoomId { get; set; }

        public string? ConferenceRoomName { get; set; }

        public int? ConferenceRoomCapacity { get; set; }
    }
    public class PostConferenceRoom
    {
        public string ConferenceRoomName { get; set; }

        public int ConferenceRoomCapacity { get; set; }

        public string UpdateUserId { get; set; }
    }
}
