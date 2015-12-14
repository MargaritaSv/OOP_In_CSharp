using System;

namespace ConsoleApplication2.UserINterfaces
{
    public class ConsoleUserInterfaces : IUser
    {
        public string ReadLIne()
        {
            return Console.ReadLine();
        }

        public void WriteLIne(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        public void WriTer(string msg)
        {
            Console.Write(msg);
        }
    }
}
