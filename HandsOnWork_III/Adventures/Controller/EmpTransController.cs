using Adventures.Model;
using Adventures.Model.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Controller
{
    public class EmpTransController
    {
        public void CadastrarEmpTrans(EmpTrans empresa)
        {
            EmpTransDataStore empTransDataStore = new EmpTransDataStore();

            empTransDataStore.AddEmpTrans(empresa);
        }

    }
}
