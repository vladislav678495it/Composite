using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class EntityComposite : ICompositble
    {
        public List<ICompositble> Entities { get; set; }

        public EntityComposite()
        {
            Entities = new List<ICompositble>();
        }

        public bool IsComposite()
        {
            return true;
        }

        public virtual int Operation()
        {
            int sum = 0;
            foreach (var item in Entities)
            {
                sum += item.Operation();
            }
            return sum;
        }

        public virtual void Add(ICompositble compositble)
        {
            Entities.Add(compositble);
        }

        public virtual void Remove(ICompositble compositble)
        {
            Entities.Remove(compositble);
        }
    }
}
