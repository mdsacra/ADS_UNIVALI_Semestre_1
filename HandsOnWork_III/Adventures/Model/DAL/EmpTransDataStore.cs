using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Model.DAL
{
    class EmpTransDataStore
    {

        AdventuresContext context = new AdventuresContext();

        public void AddEmpTrans(EmpTrans empresa)
        {
            context.EmpTrans.Add(empresa);
            
            context.SaveChanges();
        }
    }
}
