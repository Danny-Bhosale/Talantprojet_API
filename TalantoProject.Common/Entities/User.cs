using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalantoProject.Common;

namespace TalantoProject.Common.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? ContactNo { get; set; }
        public Enumeration.Role Role { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDataTime { get; set; }
        public int CreatdById { get; set; }
        public int UpdatedById { get; set; }
    }
}
