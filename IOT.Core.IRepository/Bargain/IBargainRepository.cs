using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.IRepository.Bargain
{
    public interface IBargainRepository:IBaseRepository<Model.Bargain>
    {
        int UptDate(Model.Bargain Model);
        int UptZt(int bid);
    }
}
