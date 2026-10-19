using System;
using System.Collections.Generic;
using System.Text;

namespace Task_EFcore_ERD.DAL.Entity
{
    public abstract class important_feld
    {
        public DateTime? CreatedOn { get; set; }
        public string? CreatorUser { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string? ModifiedUser { get; set; }

        public bool ISDeleted { get; set; }

        public DateTime? DeletedOn
        {
            get; set;
        }

        public string? DeletedUser { get; set; }
    }
}
