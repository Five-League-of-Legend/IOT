using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.IRepository.CommType
{
    public interface ICommTypeRepository:IBaseRepository<IOT.Core.Model.CommType>
    {
        List<IOT.Core.Model.CommType> UptState(int id);
        int Uptss(Model.CommType c);
    }
}
