using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterfaceDal;

namespace CommonDAL
{
    public abstract class AbstractDal<AnyType> : IDal<AnyType>
    {
        protected string ConnectionString;

        protected List<AnyType> AnyTypes = new List<AnyType>();

        public AbstractDal(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public virtual void IDal<AnyType>.Add(AnyType obj)
        {
            AnyTypes.Add(obj);
        }

        public virtual void IDal<AnyType>.Update(AnyType obj)
        {
            throw new NotImplementedException();
        }

        public virtual void IDal<AnyType>.Delete(AnyType obj)
        {
            throw new NotImplementedException();
        }

        public virtual List<AnyType> IDal<AnyType>.Search()
        {
            throw new NotImplementedException();
        }

        public virtual void IDal<AnyType>.Save(AnyType obj)
        {
            throw new NotImplementedException();
        }
    }
}
