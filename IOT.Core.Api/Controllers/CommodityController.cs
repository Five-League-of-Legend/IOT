using IOT.Core.IRepository.Commodity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommodityController : ControllerBase
    {

        // 依赖注入
        private readonly ICommodityRepository _Commodity;
        public CommodityController(ICommodityRepository Commodity)
        {
            _Commodity = Commodity;
        }

        // 显示
        [Route("/api/CommodityShow")]
        [HttpGet]
        public IActionResult CommodityShow()
        {
            var ls = _Commodity.ShowCommodity();
            return Ok(new { msg = "", code = 0, data = ls });
        }

        //删除
        [HttpPost]
        [Route("/api/CommodityDel")]
        public int CommodityDel(string ids)
        {
            return _Commodity.DelCommodity(ids);
        }

        //修改
        [HttpPost]
        [Route("/api/CommodityUpt")]
        public int CommodityUpt(IOT.Core.Model.Commodity a)
        {
            return _Commodity.UptCommodity(a);
        }

    }
}
