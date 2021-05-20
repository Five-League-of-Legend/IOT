using IOT.Core.Common;
using IOT.Core.IRepository.Colonel.Brokerage;
using IOT.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Repository.Colonel.Brokerage
{
    public class BrokerageRepository : IBrokerageRepository
    {
        /// <summary>
        /// 添加佣金流水
        /// </summary>
        /// <param name="brokerage"></param>
        /// <returns></returns>
        public int AddBrokerage(Model.Brokerage brokerage)
        {
            string sql = $" insert into Brokerage values (null,{brokerage.ColonelID},{brokerage.BrokerageType},{brokerage.Income},{brokerage.State},'{brokerage.EndTime}',{brokerage.OrderFormStatus}) ";
            return DapperHelper.Execute(sql);
        }


        /// <summary>
        /// 删除佣金流水
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelBrokerage(int id)
        {
            string sql = $" delete from Brokerage where BId = {id} ";
            return DapperHelper.Execute(sql);
        }

        /// <summary>
        /// 佣金流水   两表联查
        /// </summary>
        /// <param name="status">佣金状态</param>
        /// <param name="orderFormStatus">订单状态</param>
        /// <param name="colonel">所属团长</param>
        /// <param name="orderNumber">订单号</param>
        /// <returns></returns>  
        public List<ViewColonelAndBrokerage> GetBrokerages(int status, int orderFormStatus, string colonel, string orderNumber)
        {
            string sql = " select * from Brokerages ";
            return DapperHelper.GetList<ViewColonelAndBrokerage>(sql);
        }


        /// <summary>
        /// 修改佣金流水
        /// </summary>
        /// <param name="brokerage"></param>
        /// <returns></returns>       
        public int UptBrokerage(Model.Brokerage brokerage)
        {
            string sql = $" update Brokerage set ColonelID={brokerage.ColonelID},BrokerageType={brokerage.BrokerageType},Income={brokerage.Income},State={brokerage.State},EndTime='{brokerage.EndTime}',OrderFormStatus={brokerage.OrderFormStatus} ";
            return DapperHelper.Execute(sql);
        }
    }
}
