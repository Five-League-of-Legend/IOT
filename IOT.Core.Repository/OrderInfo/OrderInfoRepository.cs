using IOT.Core.Common;
using IOT.Core.IRepository.OrderInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Repository.OrderInfo
{
    public class OrderInfoRepository:IOrderInfoRepository
    {

        // 显示
        public List<Model.OrderInfo> ShowIOrderInfo()
        {
            string sql = "select * from OrderInfo";
            return DapperHelper.GetList<Model.OrderInfo>(sql);
        }        

    }
}
