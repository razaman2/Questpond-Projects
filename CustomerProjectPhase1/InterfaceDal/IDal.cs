using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceDal
{
    // Design Pattern :- Generic Repository
    public interface IDal<AnyType>
    {
        // In memory addition
        void Add(AnyType obj);

        // In memory update
        void Update(AnyType obj);

        void Delete(AnyType obj);

        List<AnyType> Search();

        // Physical commit
        void Save(AnyType obj);
    }
}
