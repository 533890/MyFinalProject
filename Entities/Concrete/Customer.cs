﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer: IEntity
    {
        public string CustomerId { get; set; }
        public string ContacName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }

    }
}
