using Adventures.Model;
using Adventures.Model.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Controller
{
    public class RespEmpController
    {

        RespEmpDataStore respEmpDataStore = new RespEmpDataStore();

        public RespEmpresa AdicionarResponsavel(RespEmpresa resp)
        {
            return respEmpDataStore.AdicionarResponsavel(resp);
        }

    }
}
