using System;
using System.Collections.Generic;
using IOT.Core.IRepository;
using IOT.Core.Common;

namespace IOT.Core.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        public int Delete(string ids)
        {
            throw new NotImplementedException();
        }

        public int Insert(T Model)
        {
            throw new NotImplementedException();
        }

        public List<T> Query()
        {
            throw new NotImplementedException();
        }
    }
}
