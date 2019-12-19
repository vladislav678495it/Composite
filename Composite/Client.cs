using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Client
    {
        public ICompositble Composite { get; set; }

        public Client(ICompositble composite)
        {
            Composite = composite;
        }

        public int GetInfo()
        {
            return Composite.Operation();
        }

        public void AddToComposite(ICompositble compositble)
        {
            if (Composite.IsComposite())
            {
                ((EntityComposite)Composite).Add(compositble);
            }
            if (Composite.GetType() == typeof(EntityComposite))
            {
                ((EntityComposite)Composite).Add(compositble);
            }
        }
    }
}
