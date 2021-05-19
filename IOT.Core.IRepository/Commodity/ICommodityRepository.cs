using IOT.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.IRepository.CommodityRepository
{
    public interface ICommodityRepository : IBaseRepository<IOT.Core.Model.Commodity>
    {
        int Uptstate(int id);
        int Uptsstate(int id);
    }
}
