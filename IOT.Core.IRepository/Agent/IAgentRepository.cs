using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.IRepository.Agent
{
    public interface IAgentRepository
    {
        int UptZt(int sid);//修改状态
        //添加
        int AddAgent(IOT.Core.Model.Agent a);

        //显示
        List<IOT.Core.Model.Agent> ShowAgent();

        //删除
        int DelAgent(string id);

        //修改
        int UptAgent(IOT.Core.Model.Agent a);
    }
}
