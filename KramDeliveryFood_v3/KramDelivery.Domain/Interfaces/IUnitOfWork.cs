using Microsoft.EntityFrameworkCore;
using System;

namespace KramDelivery.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        void Save();
        void Dispose();
    }
}
