using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trombinoscope
{
    public class VMTrombi : ViewModelBase
    {
        public List<Employe> Employes { get; }

        public VMTrombi()
        {
            Employes = new List<Employe>(DAL.GeEmployes());
        }
    }
}
