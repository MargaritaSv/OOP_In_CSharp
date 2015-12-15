using System.Collections.Generic;

namespace Interfaces
{
    public interface IBoss
    {
         ICollection<IEmployee> SubEmployee { get; }
    }
}
