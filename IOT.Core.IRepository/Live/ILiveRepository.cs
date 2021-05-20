using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.IRepository.Live
{
    public interface ILiveRepository:IBaseRepository<Model.Live>
    {
        int UptDate(Model.Live Model);
        int UptZt(int lid);
    }
}
