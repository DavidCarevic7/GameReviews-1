﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public abstract class BaseEntity
    {

        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
