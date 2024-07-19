using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns.Factory_Method
{
    public abstract class HiringManager
    {
      
       abstract protected IInterviweir MakeInterviewer();
        public void TakeInterview()
        {
           var interviewer = this.MakeInterviewer();
           interviewer.AskQustion();
        }
        
    }
}
