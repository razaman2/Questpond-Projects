﻿using System;

namespace MiddleLayer
{
    public abstract class CustomerBase
    {
        public string CustomerName { get; set; }

        public string PhoneNumber { get; set; }

        public decimal BillAmount { get; set; }

        public DateTime BillDate { get; set; }

        public string Address { get; set; }

        public abstract void Validate();
    }
}
