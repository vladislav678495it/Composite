using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class AbstractEntity
    {
        public abstract bool IsComposite();
        public abstract int Operation();
    }
}
