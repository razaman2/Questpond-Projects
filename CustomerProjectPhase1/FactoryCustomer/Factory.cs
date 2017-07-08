using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MiddleLayer;

namespace FactoryCustomer
{
    // Design Pattern :- Simple Factory
    public static class Factory
    {
        private static Dictionary<string, CustomerBase> custs = new Dictionary<string, CustomerBase>();

        public static CustomerBase Create(string TypeCust)
        {
            // Design Pattern :- Lazy Loading || Eager Loading
            if (custs.Count == 0)
            {
                custs.Add("customer", new Customer());
                custs.Add("lead", new Lead());
            }

            // Design Pattern :- RIP Replace If With Polymorphism 
            return custs[TypeCust.ToLower()];
        }
    }
}
