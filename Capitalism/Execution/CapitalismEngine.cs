using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execution
{
    using ConsoleApplication2;
    using ConsoleApplication2.Interfaces;
    using ConsoleApplication2.UserINterfaces;
    using Interfaces;
    public class CapitalismEngine : IEngine
    {
        private IUser UserInterface;
        private ICommandExecutor cmdExecutor;

        public CapitalismEngine()
        {
            this.UserInterface = new ConsoleUserInterfaces();
            this.cmdExecutor = new CommandExecutor();
        }

        public void Run()
        {
            string cmdLine;
            while ((cmdLine = this.UserInterface.ReadLIne()) != "end")
            {
                // string cmdLine = this.UserInterface.ReadLIne();
                var cmd = new Command(cmdLine);
                string cmdResult = this.cmdExecutor.ExecuteCMD(cmd);
                if (cmdResult != null)
                {
                    this.UserInterface.WriteLIne(cmdResult);
                }
                cmdLine = this.UserInterface.ReadLIne();
            }
        }
    }
}
