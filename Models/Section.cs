using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBT.Models
{
    public class Section
    {
        public int SectionId { get; set; }

        public string SectionName { get; set; } 

        public string SectionSlackId { get; set; } 

        public string SectionSlakUrl { get; set; } 

        public int DepartmentId { get; set; }

        public string DepartmentName { get; set;}
    }

    public class SearchSection
    {
        public int? SectionId { get; set; }

        public string? SectionName { get; set; } 

        public int? DepartmentId { get; set; }

        public string? DepartmentName { get; set; } 
    }

    public class PostSection
    {
        public string SectionName { get; set; }

        public string SectionSlakId { get; set; }

        public string SectionSlackUrl { get; set; }

        public int DepartmentId { get; set; }
    }
}
