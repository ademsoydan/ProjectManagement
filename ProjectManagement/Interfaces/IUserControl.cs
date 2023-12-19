using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Interfaces
{
     public interface IUserControl
    {
         void SaveOperation();
         void UpdateOperation();
         void DeleteOperation();
         void ClearOperation();
    }
}
