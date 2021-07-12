using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface ISerializerService
    {
        void DoSerialization<T>(T input) where T : class;
        IList<T> DoDeserialization<T>() where T : class;
    }
}
