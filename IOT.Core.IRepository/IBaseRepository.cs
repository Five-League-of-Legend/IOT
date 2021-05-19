using System;
using System.Collections.Generic;
using System.Linq;

namespace IOT.Core.IRepository
{
    public interface IBaseRepository<T>
    {
        int Delete(string ids);
        int Insert(T Model);
        List<T> Query();
    }
}
