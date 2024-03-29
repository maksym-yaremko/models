﻿using System;
using System.Collections.Generic;
using TransIT.DAL.Models.Entities.Abstractions;

namespace TransIT.DAL.Models.Entities
{
    public partial class Supplier : IEntity
    {
        public Supplier()
        {
            IssueLog = new HashSet<IssueLog>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModDate { get; set; }
        public int? CreateId { get; set; }
        public int? ModId { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public int? CountryId { get; set; }
        public int? CurrencyId { get; set; }
        public string Edrpou { get; set; }

        public virtual Country Country { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual User Create { get; set; }
        public virtual User Mod { get; set; }
        public virtual ICollection<IssueLog> IssueLog { get; set; }
    }
}
