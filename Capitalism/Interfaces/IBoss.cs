﻿using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IBoss
    {
         ICollection<IEmployee> SubEmployee { get; }
    }
}