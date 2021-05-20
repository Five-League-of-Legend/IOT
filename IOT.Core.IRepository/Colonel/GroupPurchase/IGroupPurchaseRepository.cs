using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.IRepository.Colonel.GroupPurchase
{
    public interface IGroupPurchaseRepository
    {
        /// <summary>
        /// 添加团购配置
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        int AddGroupPurchase(Model.GroupPurchase groupPurchase);



    }
}
