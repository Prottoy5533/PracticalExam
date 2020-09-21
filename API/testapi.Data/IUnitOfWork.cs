using System;
using System.Collections.Generic;
using System.Text;

namespace testapi.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
