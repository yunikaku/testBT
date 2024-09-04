using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBT.Models
{
    public  class Department
    {
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; } = null!;

        public string DepartmentSlackId { get; set; } = null!;
    }

    public class SearchDepartment
    {
        public int? DepartmentId { get; set; }
        public string? DepartmentName { get; set; } = null!;
    }

    public class PostDepartment
    {
        public string DepartmentName { get; set; }

        public string DepartmentSlakId { get; set; }
    }
}
