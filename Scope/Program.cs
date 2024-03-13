namespace Scope
{
    class Program
    {
        public static void Main(string[] args)
        {
            Scope scope1 = new Scope();
            Scope scope2 = new Scope();
            SampleService sampleService1a = scope1.ScopeProvider.GetSample();
            SampleService sampleService1b = scope1.ScopeProvider.GetSample();
            SampleService sampleService2a = scope2.ScopeProvider.GetSample();
            SampleService sampleService2b = scope2.ScopeProvider.GetSample();
            Console.WriteLine(sampleService1a.Id);
            Console.WriteLine(sampleService1b.Id);
            Console.WriteLine(sampleService2a.Id);
            Console.WriteLine(sampleService2b.Id);
        }
    }
}