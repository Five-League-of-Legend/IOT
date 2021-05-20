using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.IRepository.Colonel.ColonelManagement
{
    public interface IColonelManagementRepository
    {
        /// <summary>
        /// 添加核销员
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        int AddUsers(IOT.Core.Model.Users a);

        /// <summary>
        /// 显示核销员
        /// </summary>
        /// <param name="ColonelID">团长ID</param>
        /// <returns></returns>
        List<IOT.Core.Model.Users> ShowUsers(int ColonelID);


        /// <summary>
        /// 编辑团长
        /// </summary>
        /// <param name="a">编辑团长</param>
        /// <returns></returns>
        int UptColonel(IOT.Core.Model.Colonel a);

        /// <summary>
        /// 绑定团长商品
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        int Upt_Commodity_Colonel(IOT.Core.Model.Colonel a);


        //------------------------------------------------------------------------------------------------
        //团长审核and管理显示搜索

        /// <summary>
        /// 显示搜索团长
        /// </summary>
        /// <param name="CheckStatus">审核状态</param>
        /// <param name="nm">姓名</param>
        /// <returns></returns>  
        List<IOT.Core.Model.ViewColonelAndManager> ShowColonelList(int CheckStatus,string nm);


        //-------------------------------------------------------------------------------------------------


        /// <summary>
        /// 团长审核修改
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        int UptColonel_CheckStatus(IOT.Core.Model.ColonelManagement a);
    }
}
