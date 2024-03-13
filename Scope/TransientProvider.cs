using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    public class TransientProvider: IProvider
    {
        public SampleService GetSample() 
        { 
        return new SampleService();
        }
    }
}
