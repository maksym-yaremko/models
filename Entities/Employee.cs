using System;
using System.Collections.Generic;

namespace TransIT.API.Models.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            Issue = new HashSet<Issue>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ShortName { get; set; }
        public int PostId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModDate { get; set; }
        public int? CreateId { get; set; }
        public int? ModId { get; set; }
        public int BoardNumber { get; set; }

        public virtual User Create { get; set; }
        public virtual User Mod { get; set; }
        public virtual Post Post { get; set; }
        public virtual ICollection<Issue> Issue { get; set; }
    }
}
