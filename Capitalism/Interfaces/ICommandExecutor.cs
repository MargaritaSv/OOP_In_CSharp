﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Interfaces
{
    public interface ICommandExecutor
    {
        string ExecuteCMD(ICommand cmd);
    }
}
