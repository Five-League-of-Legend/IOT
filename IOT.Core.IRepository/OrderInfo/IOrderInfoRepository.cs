using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.IRepository.OrderInfo
{
    public interface IOrderInfoRepository
    {

        //显示
        List<IOT.Core.Model.OrderInfo> ShowIOrderInfo();

    }
}
