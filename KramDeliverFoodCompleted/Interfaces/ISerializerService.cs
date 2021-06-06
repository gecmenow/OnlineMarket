using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface ISerializerService
    {
        void DoSerialization<T>(T input) where T : class;
        IList<T> DoDeserialization<T>() where T : class;
    }
}
