using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
   public interface IComposable
    {
        void Alerter();
        
        
    }
   public abstract class Decorator : IComparable
    {
        public void alerter();
    }

    public abstract class DecoAlerte : Decorator
    {

    }

}
