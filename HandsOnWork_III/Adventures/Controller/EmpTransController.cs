using Adventures.Model;
using Adventures.Model.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Controller
{
    public class EmpTransController
    {

        EmpTransDataStore empTransDataStore = new EmpTransDataStore();

        public List<EmpTrans> ListarEmpresas()
        {
            return empTransDataStore.ListarEmpresas();
        }

        public void CadastrarEmpTrans(EmpTrans empresa)
        {
            empTransDataStore.AddEmpTrans(empresa);
        }

        public void RemoverEmpTrans(int id)
        {
            empTransDataStore.RemoverEmpTrans(id);
        }
    }
}
