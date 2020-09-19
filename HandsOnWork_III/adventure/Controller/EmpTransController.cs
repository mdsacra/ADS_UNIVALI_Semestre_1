using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class EmpTransController
    {

        IEmpTransView _empView;
        IList _empresas;
        EmpTrans EmpTrans;

        public EmpTransController(IEmpTransView empView, IList empresas)
        {
            _empView = empView;
            _empresas = empresas;
            empView.SetController(this);
        }

        public IList Users
        {
            get { return ArrayList.ReadOnly(_empresas); }
        }
    }
}
