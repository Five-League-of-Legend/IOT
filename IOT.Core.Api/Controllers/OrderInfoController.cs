using IOT.Core.IRepository.OrderInfo;
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
    public class OrderInfoController : ControllerBase
    {

        // 依赖注入
        private readonly IOrderInfoRepository _Order;
        public OrderInfoController(IOrderInfoRepository Order)
        {
            _Order = Order;
        }

        // 显示
        [Route("/api/OrderInfoShow")]
        [HttpGet]
        public IActionResult OrderInfoShow()
        {
            var ls = _Order.ShowIOrderInfo();
            return Ok(new { msg = "", code = 0, data = ls });
        }

    }
}
