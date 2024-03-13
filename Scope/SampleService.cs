using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    public class SampleService
    {
        public Guid Id { get; }

        public SampleService() 
        { 
        Id = Guid.NewGuid();
        }
    }
}
