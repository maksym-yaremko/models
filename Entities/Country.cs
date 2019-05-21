using System;
using System.Collections.Generic;

namespace TransIT.API.Models.Entities
{
    public partial class Country
    {
        public Country()
        {
            Supplier = new HashSet<Supplier>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModDate { get; set; }
        public int? CreateId { get; set; }
        public int? ModId { get; set; }

        public virtual User Create { get; set; }
        public virtual User Mod { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
