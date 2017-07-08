using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CommonDAL;
using InterfaceDal;

namespace AdoDotnetDAL
{
    public class TemplateADO<AnyType> : AbstractDal<AnyType>
    {
        protected SqlConnection objConn;

        protected SqlCommand objCommand;

        public TemplateADO(string connectionString) : base(connectionString){}

        private void Open()
        {
            objConn = new SqlConnection(ConnectionString);

            objConn.Open();

            objCommand = new SqlCommand();

            objCommand.Connection = objConn;
        }

        protected abstract void ExecuteCommand(AnyType obj);

        private void Close()
        {
            objConn.Close();
        }

        // Design Pattern :- Template
        public void Execute(AnyType obj)
        {
            Open();

            ExecuteCommand(obj);

            Close();
        }

        public override void Save(AnyType obj)
        {
            foreach (AnyType o in AnyTypes)
            {
                Execute(o);
            }
        }
    }
}
