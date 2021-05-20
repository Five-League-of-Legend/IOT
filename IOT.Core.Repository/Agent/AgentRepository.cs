using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOT.Core.Common;
using IOT.Core.IRepository.Agent;

namespace IOT.Core.Repository.Agent
{
    //public class ActivityRepository : IActivityRepository
    public class AgentRepository : IAgentRepository
    {
        
        public int AddAgent(Model.Agent a)
        {
            string sql = $"insert into Agent values (null,'{a.AgentName}', '{a.Icon}', '{a.BCImg}', '{a.BackgroudColor}', '{a.Fans}', {a.AgentState}, {a.One}, {a.Two}, {a.Three},'{a.Explaina}')";
           return DapperHelper.Execute(sql);
        }

        public int DelAgent(string id)
        {
            string sql = $"delete from Agent where AgentId={id}";
            return DapperHelper.Execute(sql);
        }

        public List<Model.Agent> ShowAgent()
        {
            string sql = "select * from Agent";
            return DapperHelper.GetList<Model.Agent>(sql);
        }

        public int UptAgent(Model.Agent a)
        {
            string sql = $"update  Agent set values (null,'{a.AgentName}', '{a.Icon}', '{a.BCImg}', '{a.BackgroudColor}', '{a.Fans}', {a.AgentState}, {a.One}, {a.Two}, {a.Three},'{a.Explaina}')";
            return DapperHelper.Execute(sql);
        }

        public int UptZt(int sid)
        {
            string sql = "select * from Agent";
            
            List<Model.Agent> la = DapperHelper.GetList<Model.Agent>(sql);

            Model.Agent aa = la.FirstOrDefault(x => x.AgentId.Equals(sid));
            string sql1 = "";
            if (aa.AgentState == 0)
            {
                sql1 = $"UPDATE Agent SET AgentState=AgentState+1 where AgentId={sid}";
                
            }
            else
            {
                sql1 = $"UPDATE Agent SET AgentState=AgentState-1 where AgentId={sid}";
               
            }
            int i = DapperHelper.Execute(sql1);
            return i;
        }
       

    }
}
