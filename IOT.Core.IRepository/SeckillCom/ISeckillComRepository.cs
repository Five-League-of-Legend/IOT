using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.IRepository.SeckillCom
{
    public interface ISeckillComRepository:IBaseRepository<Model.SeckillCom>
    {
        int Uptdate(Model.SeckillCom Model);
        int UptZt(int sid);
    }
}
