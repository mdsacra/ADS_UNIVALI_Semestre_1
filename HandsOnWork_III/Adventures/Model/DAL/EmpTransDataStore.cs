using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventures.Model.DAL
{
    class EmpTransDataStore
    {

        AdventuresContext context = new AdventuresContext();

        public List<EmpTrans> ListarEmpresas()
        {
            return context.EmpTrans.ToList();
        }

        public void AddEmpTrans(EmpTrans empresa)
        {
            context.EmpTrans.Add(empresa);
            
            context.SaveChanges();
        }

        public void RemoverEmpTrans(int id)
        {
            EmpTrans empresa = context.EmpTrans.FirstOrDefault(e => e.Id == id);
            context.EmpTrans.Remove(empresa);

            context.SaveChanges();
        }

        public void EditarEmpTrans(EmpTrans empresa)
        {
            EmpTrans editEmp = context.EmpTrans.Find(empresa.Id);

            editEmp.Nome = empresa.Nome;
            editEmp.Responsavel = empresa.Responsavel;
            editEmp.Cnpj = empresa.Cnpj;
            editEmp.Tipo = empresa.Tipo;

            context.EmpTrans.Update(editEmp);
            context.SaveChanges();

        }
    }
}
