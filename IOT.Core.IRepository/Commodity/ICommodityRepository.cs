using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.IRepository.Commodity
{
    /// <summary>
    /// 门店_商品
    /// </summary>
    public interface ICommodityRepository
    {

        //显示
        List<IOT.Core.Model.Commodity> ShowCommodity();

        //删除
        int DelCommodity(string id);

        //修改
        int UptCommodity(IOT.Core.Model.Commodity a);

    }
}
