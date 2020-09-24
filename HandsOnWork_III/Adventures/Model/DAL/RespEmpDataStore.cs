using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace Adventures.Model.DAL
{
    class RespEmpDataStore
    {
        AdventuresContext context = new AdventuresContext();

        public RespEmpresa AdicionarResponsavel(RespEmpresa resp)
        {
            context.RespsEmpresas.Add(resp);
            context.SaveChanges();

            return context.RespsEmpresas.FirstOrDefault(r => r.Id == resp.Id);
        }
    }
}
