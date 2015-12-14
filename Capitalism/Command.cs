using ConsoleApplication2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Command : ICommand
    {
        private string cmd;

        public Command(string cmd)
        {
            string[] cmdParts = cmd.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            this.Name = cmdParts[0];

            if (cmdParts.Length > 1)
            {
                this.Parameters = cmdParts.Skip(1).ToArray();
            }
        }

        public string Name { get; set; }

        public IList<string> Parameters { get; set; }
    }
}
