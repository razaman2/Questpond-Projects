using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiddleLayer
{
    public class Lead : CustomerBase
    {
        public override void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is required!");
            }

            if (PhoneNumber.Length == 0)
            {
                throw new Exception("Phone Number is required!");
            }
        }
    }
}
