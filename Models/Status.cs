using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBT.Models
{
    public class Status
    {
        public int StatusId { get; set; }

        public string StatusName { get; set; }
    }

    public class SearchStatus
    {
        public int? StatusId { get; set; }

        public string? StatusName { get; set; }
    }

    public class PostStatus
    {
        public string StatusName { get; set; }
    }
}
