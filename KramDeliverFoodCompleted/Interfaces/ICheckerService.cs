using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface ICheckerService
    {
        bool CheckPhone(string input);
        bool CheckAddress(string input);
    }
}
