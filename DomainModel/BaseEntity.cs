using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class BaseEntity
    {
        protected BaseEntity()
        {
            Created = DateTime.UtcNow;
        }

        public int Id { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool IsDelete { get; set; }

    }
}
