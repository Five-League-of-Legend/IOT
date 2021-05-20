using IOT.Core.Common;
using IOT.Core.IRepository.Commodity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Repository.Commodity
{
    /// <summary>
    /// 门店_商品
    /// </summary>
    public class CommodityRepository : ICommodityRepository
    {
        // 删除
        public int DelCommodity(string id)
        {
            string sql = $"delete from Commodity where CommodityId={id}";
            return DapperHelper.Execute(sql);
        }

        // 显示
        public List<Model.Commodity> ShowCommodity()
        {
            string sql = "select * from Commodity";
            return DapperHelper.GetList<Model.Commodity>(sql);
        }

        // 修改
        public int UptCommodity(Model.Commodity a)
        {
            string sql = $"Update Commodity Set  CommodityName='{a.CommodityName}' , CommodityPic='{a.CommodityPic}', ShopPrice='{a.ShopPrice}'," +
                $"ShopNum='{a.ShopNum}', Repertory='{a.Repertory}', Sort='{a.Sort}', State='{a.State}', OperationDate='{a.OperationDate}' where CommodityId='{a.CommodityId}' ";
            return DapperHelper.Execute(sql);
        }
    }
}
