using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Core.Entities.Request
{
    public class StaffRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string StaffNo { get; set; }
        public string Type { get; set; }
        public string DeptId { get; set; }
        public string Status { get; set; }
    }
}
