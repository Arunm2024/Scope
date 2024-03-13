using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    public class Scope
    {
        public IProvider SingeltonProvider { get; }
        public IProvider TransientProvider { get; }
        public IProvider ScopeProvider { get; }
        public Scope()
        {
            SingeltonProvider= new SingletonProvider();
            TransientProvider= new TransientProvider();
            ScopeProvider= new ScopeProvider();
        }

    }

    public interface IProvider
    {
        public SampleService GetSample();
    }
}
