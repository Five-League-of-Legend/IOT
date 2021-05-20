using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.IRepository.Colonel.ColonelGrade
{
    public interface IColonelGradeRepository
    {
        /// <summary>
        /// 显示团长等级      根据团长等级ID反填
        /// </summary>
        /// <param name="CGId">团长等级ID</param>
        /// <returns></returns>
        List<IOT.Core.Model.ColonelGrade> ShowColonelGrade(int CGId);

        /// <summary>
        /// 编辑团长等级
        /// </summary>
        /// <param name="colonelGrade">团长等级</param>
        /// <returns></returns>
        int UptColonelGrade(Model.ColonelGrade colonelGrade);

        /// <summary>
        /// 删除团长等级
        /// </summary>
        /// <param name="CGId">团长等级Id</param>
        /// <returns></returns>
        int DelColonelGrade(int CGId);
    }
}
