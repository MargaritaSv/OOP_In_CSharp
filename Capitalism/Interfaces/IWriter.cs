namespace ConsoleApplication2.UserINterfaces
{
    public interface IWriter
    {
        void WriTer(string msg);
        void WriteLIne(string format, params object[] args);
    }
}
