using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    public class SingletonProvider: IProvider
    {
        private static SampleService sample = null;
        public SampleService GetSample() 
        { 
            if(sample==null)
                sample = new SampleService();
            return sample;
        }
    }
}
