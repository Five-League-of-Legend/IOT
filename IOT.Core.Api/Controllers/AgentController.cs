using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IOT.Core.IRepository.Agent;

namespace IOT.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private readonly IAgentRepository _agentRepository;
        public AgentController(IAgentRepository agentRepository)
        {
            _agentRepository = agentRepository;
        }

        //显示
        [Route("/api/AgentShow")]
        [HttpGet]
        public IActionResult AgentShow()
        {
            var ls = _agentRepository.ShowAgent();
            return Ok(new { msg = "", code = 0, data = ls });
        }


        //删除
        [Route("/api/AgentDel")]
        [HttpDelete]
        public int AgentDel(string id)
        {
            return _agentRepository.DelAgent(id);
        }


        //修改
        [HttpPost]
        [Route("/api/AgentUpt")]
        public int AgentUpt(IOT.Core.Model.Agent a)
        {
            return _agentRepository.UptAgent(a);
        }
        //修改状态
        [HttpPost]
        [Route("/api/AgentUptZt")]
        public int AgentUptZt(int sid)
        {
            return _agentRepository.UptZt(sid);
        }
    }
}
