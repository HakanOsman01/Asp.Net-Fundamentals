using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns.Prototype.Contracts
{
    public abstract class SandwichPrototype 
    {
       public abstract SandwichPrototype Clone();
       public abstract SandwichPrototype DeepCopy();

    }
}
