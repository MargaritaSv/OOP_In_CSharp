namespace Interfaces
{
    using Execution;

    class Program
    {

        static void Main()
        {
            IEngine engine = new CapitalismEngine();
            engine.Run();
        }
    }
}
